Imports System.Data.OleDb
Public Class ViewReservations
    Dim connect As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim sql, conString, path As String

    Private Sub AccountSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountSettingsToolStripMenuItem.Click
        AccountSettings.Show()
        Me.Close()
    End Sub

    Private Sub ViewReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReservationsToolStripMenuItem.Click
        Reservation.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Login.currentAccountID = Nothing
            Login.Show()
            Reservation.Close()
            AccountSettings.Close()
            Me.Close()
        End If
    End Sub


    Private Sub ViewReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            path = "|DataDirectory|\BlueCaribbean.mdb"
            conString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & path

            connect = New OleDbConnection(conString)
            connect.Open()
            sql = "SELECT * FROM CustReserves WHERE CustomerID = " & Login.currentAccountID
            da = New OleDbDataAdapter(sql, connect)
            da.Fill(ds, "BlueCaribbean")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        dtgCurrentReserves.DataSource = ds.Tables("BlueCaribbean")
        WelcomeNAMEToolStripMenuItem.Text = "Welcome, " & Reservation.CustName
    End Sub
End Class