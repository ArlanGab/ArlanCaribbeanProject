﻿Imports System.Data.OleDb
Public Class AccountSettings
    Dim connect As New OleDbConnection
    Dim ds As New DataSet
    Dim da As New OleDbDataAdapter
    Dim sql, conString, path As String


    Private Sub ReserveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReserveToolStripMenuItem.Click
        Reservation.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If

            If tbxUser.Text <> "" And tbxPass.Text <> "" And tbxCustName.Text <> "" And tbxCustAdd.Text <> "" And tbxPhone.Text <> "" Then
                sql = "UPDATE CustAccounts SET [Username] = '" & tbxUser.Text & "', [Password] = '" & tbxPass.Text &
                    "', [CustomerName] = '" & tbxCustName.Text & "', [CustomerAddress] = '" & tbxCustAdd.Text & "', [PhoneNo] = '" & tbxPhone.Text &
                    "' WHERE [ID] = " & Login.currentAccountID

                Dim cmd As OleDbCommand = New OleDbCommand(sql, connect)

                cmd.Parameters.Add(New OleDbParameter("@Username", tbxUser.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("@Password", tbxPass.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("@CustomerName", tbxCustName.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("@CustomerAddress", tbxCustAdd.Text.ToString()))
                cmd.Parameters.Add(New OleDbParameter("@PhoneNo", tbxPhone.Text.ToString()))

                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    connect.Close()
                    MessageBox.Show("Account updated successfully.")
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                MessageBox.Show("One or more fields are left blank.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Reservation.Show()
        Me.Close()
    End Sub

    Private Sub ViewReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewReservationsToolStripMenuItem.Click
        ViewReservations.Show()
        Me.Close()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Login.currentAccountID = Nothing
            Login.Show()
            Reservation.Close()
            ViewReservations.Close()
            Me.Close()
        End If
    End Sub

    Private Sub AccountSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            path = "|DataDirectory|\BlueCaribbean.mdb"
            conString = "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" & path
            connect = New OleDbConnection(conString)
            connect.Open()
            sql = "SELECT * FROM CustAccounts WHERE ID = " & Login.currentAccountID
            da = New OleDbDataAdapter(sql, connect)
            da.Fill(ds, "BlueCaribbean")
            connect.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        LoadAccInfo()
        WelcomeNAMEToolStripMenuItem.Text = "Welcome, " & Reservation.CustName
    End Sub

    Private Sub LoadAccInfo()
        tbxUser.Text = ds.Tables("BlueCaribbean").Rows(0).Item(1)
        tbxPass.Text = ds.Tables("BlueCaribbean").Rows(0).Item(2)
        tbxCustName.Text = ds.Tables("BlueCaribbean").Rows(0).Item(3)
        tbxCustAdd.Text = ds.Tables("BlueCaribbean").Rows(0).Item(4)
        tbxPhone.Text = ds.Tables("BlueCaribbean").Rows(0).Item(5)
    End Sub


End Class