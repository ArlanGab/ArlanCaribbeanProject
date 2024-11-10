Imports System.Data.OleDb
Public Class Register
    Dim connect As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim sql, conString, path As String

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            If tbxUser.Text <> "" And tbxPass.Text <> "" And tbxCustName.Text <> "" And tbxCustAdd.Text <> "" And tbxPhone.Text <> "" Then
                sql = "INSERT INTO CustAccounts([Username], [Password], [CustomerName], [CustomerAddress], [PhoneNo]) " &
                    "values(?,?,?,?,?)"

                Dim cmd As OleDbCommand = New OleDbCommand(sql, connect)

                cmd.Parameters.Add(New OleDbParameter("Username", tbxUser.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("Password", tbxPass.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("CustomerName", tbxCustName.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("CustomerAddress", tbxCustAdd.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("PhoneNo", tbxPhone.Text.ToString()))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    connect.Close()
                    MessageBox.Show("Registration successful.", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Login.Show()
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class