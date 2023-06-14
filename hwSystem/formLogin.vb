Imports System.Data.OleDb
Imports System.Data


Public Class formLogin


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As New formTransaction

        If txtPassword.Text = Nothing Then
            MsgBox("Please input password", MsgBoxStyle.Exclamation)
            txtPassword.Focus()
        ElseIf txtUsername.Text = Nothing Then
            MsgBox("Please input username", MsgBoxStyle.Exclamation)
            txtUsername.Focus()
        Else
            Try


                Dim cmd As New OleDbCommand
                Dim con As New OleDbConnection
                Dim conString As String
                conString = My.Settings.dbInventorySysConnectionString
                con.ConnectionString = conString
                cmd.Connection = con
                con.Open()
                cmd.CommandText = "SELECT * FROM [USERS] WHERE [Username]=@user AND [Password]=@pass"
                cmd.Parameters.AddWithValue("@user", txtUsername.Text.ToString)
                cmd.Parameters.AddWithValue("@pass", txtPassword.Text.ToString)



                Dim dr As OleDbDataReader
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                If dr.Read = True Then
                    If dr("UserType") = "Admin" Then
                        MsgBox("Admin logged in", MsgBoxStyle.Information)
                        Me.Hide()
                        formAdminvb.Show()

                    ElseIf dr("UserType") = "Employee" Then

                        MsgBox("Welcome Employee, " & txtUsername.Text, MsgBoxStyle.Information)
                        formReceipt.lblID.Text = dr("ID")
                        Me.Hide()
                        formTransaction.Show()

                    End If
                Else
                    MsgBox("Invalid username or password", MsgBoxStyle.Critical)
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                    txtUsername.Focus()

                End If
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("     hh:mm:ss" & vbCrLf & "MMMM dd, yyyy")
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub
End Class
