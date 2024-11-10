Imports System.Data.OleDb
Public Class CustomerAccs
    Dim connect As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim sql, conString, path As String
    Dim inc, maxrows As Integer

    Private Sub CustomerAccs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            path = "|DataDirectory|\BlueCaribbean.mdb"
            conString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & path
            connect = New OleDbConnection(conString)
            connect.Open()
            sql = "SELECT * FROM CustAccounts"
            da = New OleDbDataAdapter(sql, connect)
            da.Fill(ds, "BlueCaribbean")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        navigateRecords()
        dtgCustAccs.DataSource = ds.Tables("BlueCaribbean")
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
    End Sub

    Private Sub saveContact()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            If tbxUsername.Text <> "" And tbxPassword.Text <> "" And tbxCustName.Text <> "" And tbxCustAdd.Text <> "" And tbxPhone.Text <> "" And cmbUserType.Text <> "" Then
                sql = "INSERT INTO CustAccounts([Username], [Password], [CustomerName], [CustomerAddress], [PhoneNo], [UserType]) " &
                    "values(?,?,?,?,?,?)"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, connect)

                cmd.Parameters.Add(New OleDbParameter("Username", tbxUsername.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("Password", tbxPassword.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("CustomerName", tbxCustName.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("CustomerAddress", tbxCustAdd.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("PhoneNo", tbxPhone.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("UserType", cmbUserType.Text.ToString()))

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

            If tbxUsername.Text <> "" And tbxPassword.Text <> "" And tbxCustName.Text <> "" And tbxCustAdd.Text <> "" And tbxPhone.Text <> "" And cmbUserType.Text <> "" Then
                sql = "UPDATE CustAccounts SET [Username] = '" & tbxUsername.Text & "', [Password] = '" & tbxPassword.Text &
                    "', [CustomerName] = '" & tbxCustName.Text & "', [CustomerAddress] = '" & tbxCustAdd.Text & "', [PhoneNo] = '" & tbxPhone.Text &
                    "', [UserType] = '" & cmbUserType.Text & "' WHERE [ID] = " & tbxID.Text

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
        tbxUsername.Text = ""
        tbxPassword.Text = ""
        tbxCustName.Text = ""
        tbxCustAdd.Text = ""
        tbxPhone.Text = ""
        cmbUserType.SelectedIndex = 0
    End Sub

    Private Sub deleteContact()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            If MessageBox.Show("Are you sure you want to delete the record? (This cannot be undone!)", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                Exit Sub
            ElseIf tbxID.Text <> "" Then
                sql = "DELETE FROM CustAccounts WHERE ID = " & tbxID.Text.ToString()
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
        tbxUsername.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(1)
        tbxPassword.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(2)
        tbxCustName.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(3)
        tbxCustAdd.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(4)
        tbxPhone.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(5)
        cmbUserType.Text = ds.Tables("BlueCaribbean").Rows(inc).Item(6)
        maxrows = ds.Tables("BlueCaribbean").Rows.Count
    End Sub



    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        editContact()
        loadGridView()
    End Sub

    Private Sub loadGridView()
        dtgCustAccs.DataSource.Clear()
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
            sql = "SELECT * FROM CustAccounts"
            da = New OleDbDataAdapter(sql, connect)
            da.Fill(ds, "BlueCaribbean")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        dtgCustAccs.DataSource = ds.Tables("BlueCaribbean")
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

    Private Sub CustomerReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReservationsToolStripMenuItem.Click
        CustomerReservations.Show()
        Me.Hide()
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

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Login.currentAccountID = Nothing
            Login.Show()
            CustomerReservations.Close()
            Me.Close()
        End If
    End Sub
End Class