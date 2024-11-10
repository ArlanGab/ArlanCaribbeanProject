Public Class Login
    Public currentAccountID As Integer
    Public userType As String

    Function UserAuth(username As String, password As String)
        Using conLogin As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BlueCaribbean.mdb")
            Dim commLogin As New OleDb.OleDbCommand(
                "SELECT ID, UserType FROM CustAccounts WHERE Username = @username AND Password = @password", conLogin)
            commLogin.Parameters.AddWithValue("@username", username)
            commLogin.Parameters.AddWithValue("@password", password)

            conLogin.Open()
            Dim reader = commLogin.ExecuteReader()
            If reader.Read() Then
                currentAccountID = reader("ID".ToString())
                userType = reader("UserType").ToString()
                Return userType
            Else
                Return String.Empty
            End If
        End Using
    End Function

    Private Sub CheckAccess(userType As String)
        Select Case userType
            Case "admin"
                MessageBox.Show("Login successful. Welcome, admin.", "Login Success (admin)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CustomerAccs.Show()
            Case "customer"
                MessageBox.Show("Login successful. Welcome, user.", "Login Success (user)", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reservation.Show()
        End Select
        tbxUser.Text = ""
        tbxPass.Text = ""
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username, password As String
        username = tbxUser.Text
        password = tbxPass.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Username or password is empty. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxUser.Focus()
            Return
        End If

        Dim userType = UserAuth(username, password)
        If String.IsNullOrEmpty(userType) Then
            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbxUser.Clear()
            tbxPass.Clear()
            tbxUser.Focus()
        Else
            CheckAccess(userType)
        End If
    End Sub

    Private Sub lnkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkRegister.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub
End Class
