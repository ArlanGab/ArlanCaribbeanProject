Imports System.Data.OleDb
Public Class Reservation
    Dim connect As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim sql, conString, path As String
    Public CustName, CustAddress, PhoneNo As String

    Private Sub AccountSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        AccountSettings.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Login.currentAccountID = Nothing
            Login.Show()
            AccountSettings.Close()
            ViewReservations.Close()
            Me.Close()
        End If
    End Sub

    Private Sub ViewReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReservationsToolStripMenuItem.Click
        ViewReservations.Show()
        Me.Close()
    End Sub

    Dim inc, maxrows As Integer

    Dim Prices = New Integer(,) {{3250, 6000}, {4250, 7999}, {3300, 7200}, {5000, 9000}}
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            path = "|DataDirectory|\BlueCaribbean.mdb"
            conString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & path

            connect = New OleDbConnection(conString)
            connect.Open()
            sql = "SELECT CustomerName, CustomerAddress, PhoneNo FROM CustAccounts WHERE ID = " & Login.currentAccountID
            da = New OleDbDataAdapter(sql, connect)
            da.Fill(ds, "BlueCaribbean")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        CustName = ds.Tables("BlueCaribbean").Rows(inc).Item(0)
        CustAddress = ds.Tables("BlueCaribbean").Rows(inc).Item(1)
        PhoneNo = ds.Tables("BlueCaribbean").Rows(inc).Item(2)

        WelcomeNAMEToolStripMenuItem.Text = "Welcome, " & CustName
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        Dim Pax, TotalCost, DayIndex As Integer
        Dim TourDays As String

        If lstTours.SelectedIndex <> -1 And cmbMode.Text <> "" And tbxPax.Text <> "" Then
            If datDepart.Value.Date <= DateAndTime.Today Then
                MessageBox.Show("Invalid date. Current date cannot exceed the reservation date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If rdb7.Checked = True Then
                    DayIndex = 0
                    TourDays = "7 Days"
                ElseIf rdb14.Checked = True Then
                    DayIndex = 1
                    TourDays = "14 Days"
                End If
                Integer.TryParse(tbxPax.Text, Pax)
                TotalCost = Prices(lstTours.SelectedIndex, DayIndex) * Pax
                lblCost.Text = TotalCost

                Try
                    If connect.State = ConnectionState.Closed Then
                        connect.Open()
                    End If

                    sql = "INSERT INTO CustReserves([CustomerID], [CustomerName], [CustomerAddress], [PhoneNum], [TourLocation], [TourDays], [NumPax], [DepDate], [ModPayment], [TotalCost]) " &
                        "values(?,?,?,?,?,?,?,?,?,?)"

                    Dim cmd As OleDbCommand = New OleDbCommand(sql, connect)

                    cmd.Parameters.Add(New OleDbParameter("CustomerID", Login.currentAccountID))
                    cmd.Parameters.Add(New OleDbParameter("CustomerName", CustName.ToString()))
                    cmd.Parameters.Add(New OleDbParameter("CustomerAddress", CustAddress.ToString()))
                    cmd.Parameters.Add(New OleDbParameter("PhoneNum", PhoneNo.ToString()))
                    cmd.Parameters.Add(New OleDbParameter("TourLocation", lstTours.SelectedItem.ToString()))
                    cmd.Parameters.Add(New OleDbParameter("TourDays", TourDays))
                    cmd.Parameters.Add(New OleDbParameter("NumPax", Pax))
                    cmd.Parameters.Add(New OleDbParameter("DepDate", datDepart.Value.Date))
                    cmd.Parameters.Add(New OleDbParameter("ModPayment", cmbMode.Text.ToString()))
                    cmd.Parameters.Add(New OleDbParameter("TotalCost", TotalCost))

                    Try
                        cmd.ExecuteNonQuery()
                        cmd.Dispose()
                        connect.Close()
                        MessageBox.Show("Reservation complete.")
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Else
            MessageBox.Show("Reservation form incomplete. Please complete all details and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

End Class