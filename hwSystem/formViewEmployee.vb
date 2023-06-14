Imports System.Data.OleDb

Public Class formViewEmployee
    Dim selectedIndex As Integer
    Private Sub formViewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbInventorySysDataSet.USERS' table. You can move, or remove it, as needed.
        Me.USERSTableAdapter.Fill(Me.DbInventorySysDataSet.USERS)
        Timer1.Enabled = True

        cbUserType.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dataTable.Columns.Contains("Remove Product") Then
            dataTable.Columns.Remove("Remove Product")
        End If
        btnDelete.Visible = False
        btnConfirm.Visible = True
        btnUpdate.Visible = False
        Dim id As New Random
        Dim emId As Integer
        emId = id.Next(100, 999)
        txtID.Text = emId
        btnDelete.FlatAppearance.BorderSize = 0
        btnConfirm.FlatAppearance.BorderSize = 2
        btnUpdate.FlatAppearance.BorderSize = 0
        btnDeleteEmployee.Enabled = True
        btnAdd.Enabled = False
        btnConfirm.Enabled = True
        btnUpdate.Enabled = False
        btnUpdateEmployee.Enabled = True
        btnDelete.Enabled = False
        txtFirstName.Enabled = True
        txtLastName.Enabled = True
        txtMiddleName.Enabled = True
        txtPassword.Enabled = True
        txtUser.Enabled = True
        txtID.Enabled = False
        btnSearch.Enabled = False
        cbUserType.Enabled = True
        cbUserType.Text = ""
        txtFirstName.Text = ""
        txtID.Text = id.Next(1000, 9999)
        txtLastName.Text = ""
        txtMiddleName.Text = ""
        txtPassword.Text = ""
        txtUser.Text = ""

    End Sub



    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim Value As Integer
        Dim ranDom As Integer
        ranDom = Math.Floor(Rnd() * 1000000) + 1
        If Integer.TryParse(txtID.Text, Value) Then
            If Value > 0 AndAlso Value < ranDom Then
                Try
                    Dim connection As New OleDbConnection(My.Settings.dbInventorySysConnectionString)
                    Dim command As New OleDbCommand("SELECT * FROM USERS WHERE ID=@Id", connection)

                    command.Parameters.AddWithValue("@Id", OleDbType.Integer).Value = txtID.Text

                    Dim adaptr As New OleDbDataAdapter(command)

                    Dim table As New DataTable()

                    adaptr.Fill(table)
                    txtUser.Text = table.Rows(0)(1).ToString()
                    txtPassword.Text = table.Rows(0)(2).ToString()
                    txtFirstName.Text = table.Rows(0)(3).ToString()
                    txtMiddleName.Text = table.Rows(0)(4).ToString()
                    txtLastName.Text = table.Rows(0)(5).ToString()
                    cbUserType.Text = table.Rows(0)(6).ToString()
                    cbUserType.Enabled = True
                    txtFirstName.Enabled = True
                    txtLastName.Enabled = True
                    txtMiddleName.Enabled = True
                    txtPassword.Enabled = True
                    txtUser.Enabled = True
                    txtID.Enabled = True
                Catch ex As Exception
                    MessageBox.Show("ID NOT FOUND")
                    txtID.Focus()
                    txtID.Text = ""
                End Try
            Else
                MessageBox.Show("Please enter a number!")
            End If

        Else
            MessageBox.Show("Please enter a number!")
        End If

    End Sub



    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        If dataTable.Columns.Contains("Remove Product") Then
            dataTable.Columns.Remove("Remove Product")
        End If
        btnDelete.FlatAppearance.BorderSize = 0
        btnConfirm.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.BorderSize = 2
        cbUserType.Text = ""
        btnDelete.Visible = False
        btnConfirm.Visible = False
        btnUpdate.Visible = True
        txtFirstName.Text = ""
        txtID.Text = ""
        txtLastName.Text = ""
        txtMiddleName.Text = ""
        txtPassword.Text = ""
        txtUser.Text = ""
        txtID.Enabled = True
        btnDeleteEmployee.Enabled = True
        btnConfirm.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = True
        btnSearch.Enabled = True
        btnUpdateEmployee.Enabled = False
        btnAdd.Enabled = True

        cbUserType.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtMiddleName.Enabled = False
        txtPassword.Enabled = False
        txtUser.Enabled = False


    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        btnAdd.Enabled = True
        btnUpdateEmployee.Enabled = True
        Dim id As Integer
        id = txtID.Text
        If MessageBox.Show("Add User?", "Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If txtconfirmPass.Text = txtPassword.Text Then


                Try
                    Dim sqlconn As New OleDbConnection
                    Dim sqlquery As New OleDbCommand
                    Dim connString As String

                    Dim userType As String

                    Dim firstName, middleName, lastName As String
                    firstName = txtFirstName.Text.Substring(0, 1).ToUpper + txtFirstName.Text.Substring(1)
                    middleName = txtMiddleName.Text.Substring(0, 1).ToUpper + txtMiddleName.Text.Substring(1)
                    lastName = txtLastName.Text.Substring(0, 1).ToUpper + txtLastName.Text.Substring(1)

                    userType = cbUserType.SelectedItem


                    connString = My.Settings.dbInventorySysConnectionString
                    sqlconn.ConnectionString = connString
                    sqlquery.Connection = sqlconn
                    sqlconn.Open()
                    sqlquery.CommandText = " INSERT INTO [USERS] ([ID],[Username], [Password], [First Name], [Middle Name], [Last Name], [UserType]) VALUES (?,?,?,?,?,?,?)"
                    sqlquery.Parameters.AddWithValue("?", id)
                    sqlquery.Parameters.AddWithValue("?", txtUser.Text.ToString)
                    sqlquery.Parameters.AddWithValue("?", txtPassword.Text.ToString)
                    sqlquery.Parameters.AddWithValue("?", firstName.ToString)
                    sqlquery.Parameters.AddWithValue("?", middleName.ToString)
                    sqlquery.Parameters.AddWithValue("?", lastName.ToString)
                    sqlquery.Parameters.AddWithValue("?", userType)

                    Dim i As Integer
                    i = sqlquery.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("User Added", MsgBoxStyle.Information)
                        Me.USERSTableAdapter.Fill(Me.DbInventorySysDataSet.USERS)
                        cbUserType.Text = ""
                        txtFirstName.Text = ""
                        txtID.Text = ""
                        txtLastName.Text = ""
                        txtMiddleName.Text = ""
                        txtPassword.Text = ""
                        txtUser.Text = ""
                        txtFirstName.Enabled = False
                        txtLastName.Enabled = False
                        txtMiddleName.Enabled = False
                        txtPassword.Enabled = False
                        txtUser.Enabled = False
                        btnAdd.Enabled = True
                        btnUpdateEmployee.Enabled = True
                        btnDelete.Enabled = True
                        btnDeleteEmployee.Enabled = True

                        btnDelete.Enabled = False
                        btnConfirm.Enabled = False
                        btnUpdate.Enabled = False
                        btnDelete.FlatAppearance.BorderSize = 0
                        btnConfirm.FlatAppearance.BorderSize = 0
                        btnUpdate.FlatAppearance.BorderSize = 0

                    Else
                        MsgBox("Failed to add user", MsgBoxStyle.Critical)
                    End If
                Catch ex As Exception
                    MsgBox("Duplicate ID found please try again!")
                Finally

                End Try
            Else
                MsgBox("Password mismatch", MsgBoxStyle.Critical)
                txtPassword.Focus()
                lblMismatch.Visible = True
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id As Integer
        id = txtID.Text
        If MessageBox.Show("Update User?", "Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim sqlconn As New OleDbConnection
                Dim sqlquery As New OleDbCommand
                Dim connString As String
                Dim userType, status As String
                userType = cbUserType.SelectedItem
                connString = My.Settings.dbInventorySysConnectionString
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn
                sqlquery.CommandText = "UPDATE USERS SET [Username]=@user, [Password]=@password, [First Name]=@firstName, [Middle Name]=@midName, [Last Name]=@lasName, [UserType]=@userType WHERE [ID]=@id"
                sqlconn.Open()
                sqlquery.Parameters.AddWithValue("@user", txtUser.Text.ToString)
                sqlquery.Parameters.AddWithValue("@password", txtPassword.Text.ToString)
                sqlquery.Parameters.AddWithValue("@firstName", txtFirstName.Text.ToString)
                sqlquery.Parameters.AddWithValue("@midName", txtMiddleName.Text.ToString)
                sqlquery.Parameters.AddWithValue("@lasName", txtLastName.Text.ToString)
                sqlquery.Parameters.AddWithValue("@userType", userType)

                sqlquery.Parameters.AddWithValue("@id", id)
                Dim i As Integer
                i = sqlquery.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)
                    cbUserType.Text = ""
                    txtFirstName.Text = ""
                    txtID.Text = ""
                    txtLastName.Text = ""
                    txtMiddleName.Text = ""
                    txtPassword.Text = ""
                    txtUser.Text = ""
                    cbUserType.Enabled = False
                    txtLastName.Enabled = False
                    txtMiddleName.Enabled = False
                    txtPassword.Enabled = False
                    txtUser.Enabled = False
                    txtFirstName.Enabled = False
                    btnSearch.Enabled = False
                    btnUpdateEmployee.Enabled = True
                    txtID.Enabled = False
                    btnDeleteEmployee.Enabled = True
                    btnAdd.Enabled = True
                    btnDelete.FlatAppearance.BorderSize = 0
                    btnConfirm.FlatAppearance.BorderSize = 0
                    btnUpdate.FlatAppearance.BorderSize = 0
                Else
                    MsgBox("Failed to Update", MsgBoxStyle.Critical)
                End If
                sqlconn.Close()
                sqlquery.Dispose()


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Me.USERSTableAdapter.Fill(Me.DbInventorySysDataSet.USERS)
            End Try

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dataTable.Columns.Remove("Remove Product")
        btnDeleteEmployee.Enabled = True
        btnConfirm.Visible = True
        btnDelete.Visible = False
        btnUpdate.Visible = True
    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
        Dim buttonColumn As New DataGridViewButtonColumn()

        btnDelete.Visible = True
        btnConfirm.Visible = False
        btnUpdate.Visible = False
        buttonColumn.HeaderText = ""

        buttonColumn.Name = "Remove Product"
        buttonColumn.Text = "Remove"
        buttonColumn.FlatStyle = FlatStyle.Flat
        MsgBox("Select the employee you want to delete", MsgBoxStyle.Information)


        buttonColumn.UseColumnTextForButtonValue = True
        dataTable.Columns.Add(buttonColumn)
        btnConfirm.Visible = False
        btnUpdate.Visible = False
        btnSearch.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 2
        btnConfirm.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.BorderSize = 0
        cbUserType.Text = ""
        txtFirstName.Text = ""
        txtID.Text = ""
        txtLastName.Text = ""
        txtMiddleName.Text = ""
        txtPassword.Text = ""
        txtUser.Text = ""

        btnDelete.Enabled = False
        btnAdd.Enabled = True
        btnUpdateEmployee.Enabled = True
        btnDeleteEmployee.Enabled = False
        btnConfirm.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = True


        txtID.Enabled = False
        cbUserType.Enabled = False
        txtFirstName.Enabled = False
        txtLastName.Enabled = False
        txtMiddleName.Enabled = False
        txtPassword.Enabled = False
        txtUser.Enabled = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        formAdminvb.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TxtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtconfirmPass_TextChanged(sender As Object, e As EventArgs) Handles txtconfirmPass.TextChanged
        lblMismatch.Visible = False
    End Sub

    Private Sub dataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable.CellContentClick
        If e.ColumnIndex <> 7 Then
            Exit Sub
        ElseIf e.ColumnIndex = 7 Then
            If MessageBox.Show("Delete this employee?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim id As Integer
                selectedIndex = e.RowIndex

                Try
                    Dim conn As New OleDbConnection
                    Dim cmd As New OleDbCommand
                    Dim connString As String
                    connString = My.Settings.dbInventorySysConnectionString
                    conn.ConnectionString = connString
                    cmd.Connection = conn

                    id = dataTable.Rows(selectedIndex).Cells(0).Value
                    cmd.CommandText = "DELETE * FROM USERS WHERE ID = @ID"
                    conn.Open()

                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    dataTable.Rows.RemoveAt(selectedIndex)
                    conn.Close()
                    cmd.Dispose()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



            End If

        End If


    End Sub
End Class