Imports System.Data.OleDb
Public Class CustomerReservations
    Dim connect As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim sql, conString, path As String
    Dim inc, maxrows As Integer

    Private Sub CustomerReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReservationsToolStripMenuItem.Click
        CustomerAccs.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Login.currentAccountID = Nothing
            Login.Show()
            CustomerAccs.Close()
            Me.Close()
        End If
    End Sub

    Private Sub CustomerAccs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            path = "|DataDirectory|\BlueCaribbean.mdb"
            conString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & path

            connect = New OleDbConnection(conString)
            connect.Open()
            sql = "SELECT * FROM CustReserves"
            da = New OleDbDataAdapter(sql, connect)
            da.Fill(ds, "BlueCaribbean")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        navigateRecords()
        dtgReserves.DataSource = ds.Tables("BlueCaribbean")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clearFields()
        btnAdd.Enabled = False
        btnDel.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveContact()
        loadGridView()
        navigateRecords()
    End Sub

    Private Sub saveContact()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            If tbxCustName.Text <> "" And tbxCustAdd.Text <> "" And tbxPhone.Text <> "" And cmbTourLoc.Text <> "" And cmbTourLength.Text <> "" And tbxPax.Text <> "" And cmbMode.Text <> "" And tbxCost.Text <> "" Then
                sql = "INSERT INTO CustReserves([CustomerName], [CustomerAddress], [PhoneNum], [TourLocation], [TourDays], [NumPax], [DepDate], [ModPayment], [TotalCost]) " &
                    "values(?,?,?,?,?,?,?,?)"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, connect)

                cmd.Parameters.Add(New OleDbParameter("CustomerName", tbxCustName.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("CustomerAddress", tbxCustAdd.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("PhoneNum", tbxPhone.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("TourLocation", tbxPhone.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("TourDays", cmbTourLength.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("NumPax", Convert.ToInt32(tbxPax.Text())))
                cmd.Parameters.Add(New OleDbParameter("DepDate", datDepart.Value.Date))
                cmd.Parameters.Add(New OleDbParameter("ModPayment", cmbMode.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("TotalCost", Convert.ToInt32(tbxCost.Text())))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    connect.Close()
                    MessageBox.Show("Data inserted successfully.")
                    clearFields()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        btnAdd.Enabled = True
        btnDel.Enabled = True
        btnEdit.Enabled = True
    End Sub

    Private Sub editContact()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            If tbxCustName.Text <> "" And tbxCustAdd.Text <> "" And tbxPhone.Text <> "" And cmbTourLoc.Text <> "" And tbxPax.Text <> "" And cmbMode.Text <> "" And tbxCost.Text <> "" Then
                sql = "UPDATE CustReserves SET CustomerName = '" & tbxCustName.Text & "', CustomerAddress = '" & tbxCustAdd.Text & "', PhoneNum = '" & tbxPhone.Text &
                    "', TourLocation = '" & cmbTourLoc.Text & "', TourDays = '" & cmbTourLength.Text & "', NumPax = " & tbxPax.Text & ", DepDate = #" & datDepart.Value.Date & "#, ModPayment = '" & cmbMode.Text &
                    "', TotalCost = " & tbxCost.Text & " WHERE ReservationID = " & tbxID.Text

                Dim cmd As OleDbCommand = New OleDbCommand(sql, connect)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    connect.Close()
                    MessageBox.Show("Data updated successfully.")
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                MessageBox.Show("One or more fields are left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub clearFields()
        tbxID.Text = ""
        tbxCustName.Text = ""
        tbxCustAdd.Text = ""
        tbxPhone.Text = ""
        cmbTourLoc.SelectedIndex = 0
        tbxPax.Text = ""
        cmbMode.Text = ""
        tbxCost.Text = ""
    End Sub

    Private Sub deleteContact()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            If MessageBox.Show("Are you sure you want to delete the record? (This cannot be undone!)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                Exit Sub
            ElseIf tbxID.Text <> "" Then
                sql = "DELETE FROM CustReserves WHERE ReservationID = " & tbxID.Text.ToString()
                Dim cmd As OleDbCommand = New OleDbCommand(sql, connect)

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    connect.Close()
                    MessageBox.Show("Record deleted successfully.")
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub navigateRecords()
        tbxID.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(0)
        tbxCustID.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(1)
        tbxCustName.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(2)
        tbxCustAdd.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(3)
        tbxPhone.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(4)
        cmbTourLoc.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(5)
        cmbTourLength.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(6)
        tbxPax.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(7)
        datDepart.Value = ds.Tables("BlueCaribbean").Rows(inc).Item(8)
        cmbMode.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(9)
        tbxCost.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(10)
        maxrows = ds.Tables("BlueCaribbean").Rows.Count
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        editContact()
        loadGridView()
    End Sub

    Private Sub loadGridView()
        dtgReserves.DataSource.Clear()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
            sql = "SELECT * FROM CustReserves"
            da = New OleDbDataAdapter(sql, connect)
            da.Fill(ds, "BlueCaribbean")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        dtgReserves.DataSource = ds.Tables("BlueCaribbean")
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        deleteContact()
        loadGridView()
        clearFields()
    End Sub

    Private Sub tlsFirst_Click(sender As Object, e As EventArgs) Handles tlsFirst.Click
        If inc <> 0 Then
            inc = 0
            navigateRecords()
        End If
    End Sub

    Private Sub tlsPrev_Click(sender As Object, e As EventArgs) Handles tlsPrev.Click
        If inc <> 0 Then
            inc -= 1
            navigateRecords()
        Else
            MessageBox.Show("No more previous records.")
        End If
    End Sub

    Private Sub tlsNext_Click(sender As Object, e As EventArgs) Handles tlsNext.Click
        If inc <> maxrows - 1 Then
            inc += 1
            navigateRecords()
        Else
            MessageBox.Show("No more next records.")
        End If
    End Sub

    Private Sub tlsLast_Click(sender As Object, e As EventArgs) Handles tlsLast.Click
        Try
            If inc <> maxrows - 1 Then
                inc = maxrows - 1
                navigateRecords()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
End Class