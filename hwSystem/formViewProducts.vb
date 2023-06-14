Imports System.Data.OleDb

Public Class formViewProducts
    Dim selectedindex As Integer
    Private Sub formViewProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbInventorySysDataSet.PRODUCTS' table. You can move, or remove it, as needed.
        Me.PRODUCTSTableAdapter.Fill(Me.DbInventorySysDataSet.PRODUCTS)
        'TODO: This line of code loads data into the 'DbInventorySysDataSet.PRODUCTS' table. You can move, or remove it, as needed.

        Timer1.Enabled = True
        dataTable.Columns(2).DefaultCellStyle.Format = "N2"
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        formAdminvb.Show()

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        btnAdd.Enabled = True
        btnUpdateProduct.Enabled = True
        Dim id, quantity As Integer
        Dim price As Double
        id = txtID.Text
        quantity = txtQty.Text
        price = txtPrice.Text
        Dim combo As String
        combo = cbCategory.SelectedItem
        If MessageBox.Show("Add Product?", "Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim sqlconn As New OleDbConnection
                Dim sqlquery As New OleDbCommand
                Dim connString As String
                connString = My.Settings.dbInventorySysConnectionString
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn
                sqlconn.Open()
                sqlquery.CommandText = " INSERT INTO [PRODUCTS] ([ID],[ProductName], [ProductPrice], [ProductQuantity], [Category]) VALUES (?,?,?,?,?)"
                sqlquery.Parameters.AddWithValue("?", id)
                sqlquery.Parameters.AddWithValue("?", txtProdName.Text.ToString)
                sqlquery.Parameters.AddWithValue("?", price)
                sqlquery.Parameters.AddWithValue("?", quantity)
                sqlquery.Parameters.AddWithValue("?", combo)


                Dim i As Integer
                i = sqlquery.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Product Added", MsgBoxStyle.Information)
                    Me.PRODUCTSTableAdapter.Fill(Me.DbInventorySysDataSet.PRODUCTS)
                    txtPrice.Text = ""
                    txtProdName.Text = ""
                    txtID.Text = ""
                    txtQty.Text = ""
                    cbCategory.Text = ""
                    txtID.Enabled = False
                    txtQty.Enabled = False
                    txtPrice.Enabled = False
                    txtProdName.Enabled = False
                    cbCategory.Enabled = False
                    btnConfirm.Enabled = False
                    btnDelete.FlatAppearance.BorderSize = 0
                    btnConfirm.FlatAppearance.BorderSize = 0
                    btnUpdate.FlatAppearance.BorderSize = 0

                Else
                    MsgBox("Failed to add Product", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

            End Try

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If dataTable.Columns.Contains("Remove Product") Then
            dataTable.Columns.Remove("Remove Product")
        End If
        Dim rnd As New Random
        btnDelete.Visible = False
        btnConfirm.Visible = True
        btnUpdate.Visible = False
        btnDelete.FlatAppearance.BorderSize = 0
        btnConfirm.FlatAppearance.BorderSize = 2
        btnUpdate.FlatAppearance.BorderSize = 0
        btnSearch.Enabled = False
        btnAdd.Enabled = False
        btnDeleteProduct.Enabled = True
        btnUpdateProduct.Enabled = True
        btnConfirm.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtID.Enabled = False
        txtPrice.Enabled = True
        txtProdName.Enabled = True
        txtQty.Enabled = True
        cbCategory.Enabled = True
        txtPrice.Text = ""
        txtProdName.Text = ""
        txtID.Text = rnd.Next(10000, 99999)
        txtQty.Text = ""
        cbCategory.Text = ""

    End Sub

    Private Sub btnUpdateProduct_Click(sender As Object, e As EventArgs) Handles btnUpdateProduct.Click
        If dataTable.Columns.Contains("Remove Product") Then
            dataTable.Columns.Remove("Remove Product")
        End If
        btnDelete.Visible = False
        btnConfirm.Visible = False
        btnUpdate.Visible = True
        txtPrice.Text = ""
        txtProdName.Text = ""
        txtID.Text = ""
        txtQty.Text = ""
        cbCategory.Text = ""
        btnUpdateProduct.Enabled = False
        btnAdd.Enabled = True
        btnDeleteProduct.Enabled = True
        btnConfirm.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = True
        txtID.Enabled = True
        btnSearch.Enabled = True
        txtPrice.Enabled = False
        txtProdName.Enabled = False
        txtQty.Enabled = False
        cbCategory.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 0
        btnConfirm.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.BorderSize = 2

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim Value As Integer
        Dim ranDom As Integer
        ranDom = Math.Floor(Rnd() * 100000000) + 1
        If Integer.TryParse(txtID.Text, Value) Then
            If Value > 0 AndAlso Value < ranDom Then
                Try
                    Dim connection As New OleDbConnection(My.Settings.dbInventorySysConnectionString)
                    Dim command As New OleDbCommand("SELECT * FROM PRODUCTS WHERE ID=@Id", connection)

                    command.Parameters.AddWithValue("@Id", OleDbType.Integer).Value = txtID.Text

                    Dim adaptr As New OleDbDataAdapter(command)

                    Dim table As New DataTable()

                    adaptr.Fill(table)
                    txtProdName.Text = table.Rows(0)(1).ToString()
                    txtPrice.Text = table.Rows(0)(2).ToString()
                    txtQty.Text = table.Rows(0)(3).ToString()
                    cbCategory.SelectedItem = table.Rows(0)(4).ToString()


                    txtPrice.Enabled = True
                    txtProdName.Enabled = True
                    txtQty.Enabled = True
                    cbCategory.Enabled = True

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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim id, quantity As Integer
        Dim price As Double
        id = txtID.Text
        price = txtPrice.Text
        quantity = txtQty.Text
        If MessageBox.Show("Update Product?", "Message", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim sqlconn As New OleDbConnection
                Dim sqlquery As New OleDbCommand
                Dim connString As String
                connString = My.Settings.dbInventorySysConnectionString
                sqlconn.ConnectionString = connString
                sqlquery.Connection = sqlconn
                sqlquery.CommandText = "UPDATE PRODUCTS SET [ProductName]=@prodName, [ProductPrice]=@prodPrice, [ProductQuantity]=@prodQuantity, [Category]=@category WHERE [ID]=@id"
                sqlconn.Open()
                sqlquery.Parameters.AddWithValue("@prodName", txtProdName.Text.ToString)
                sqlquery.Parameters.AddWithValue("@prodPrice", price)
                sqlquery.Parameters.AddWithValue("@prodQuantity", quantity)
                sqlquery.Parameters.AddWithValue("@category", cbCategory.SelectedItem.ToString)

                sqlquery.Parameters.AddWithValue("@id", id)
                Dim i As Integer
                i = sqlquery.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Successfully Updated!", MsgBoxStyle.Information)

                    txtPrice.Text = ""
                    txtProdName.Text = ""
                    txtID.Text = ""
                    txtQty.Text = ""
                    cbCategory.Text = ""

                    txtQty.Enabled = False
                    txtPrice.Enabled = False
                    txtProdName.Enabled = False
                    cbCategory.Enabled = False
                    btnUpdateProduct.Enabled = True
                    btnDelete.FlatAppearance.BorderSize = 0
                    btnConfirm.FlatAppearance.BorderSize = 0
                    btnUpdate.FlatAppearance.BorderSize = 0
                    txtID.Enabled = False
                    btnUpdate.Enabled = False
                    btnDeleteProduct.Enabled = True
                    btnAdd.Enabled = True

                Else
                    MsgBox("Failed to Update", MsgBoxStyle.Critical)
                End If
            Catch ex As Exception
                MsgBox("Error")
            Finally
                Me.PRODUCTSTableAdapter.Fill(Me.DbInventorySysDataSet.PRODUCTS)
            End Try

        End If
    End Sub

    Private Sub btnDeleteProduct_Click(sender As Object, e As EventArgs) Handles btnDeleteProduct.Click
        Dim buttonColumn As New DataGridViewButtonColumn()
        buttonColumn.HeaderText = ""
        btnDelete.Visible = True
        btnConfirm.Visible = False
        btnUpdate.Visible = False
        buttonColumn.Name = "Remove Product"
        buttonColumn.Text = "Remove"
        buttonColumn.FlatStyle = FlatStyle.Flat

        buttonColumn.UseColumnTextForButtonValue = True
        dataTable.Columns.Add(buttonColumn)
        MsgBox("Select the employee you want to delete", MsgBoxStyle.Information)
        txtPrice.Text = ""
        txtProdName.Text = ""
        txtID.Text = ""
        txtQty.Text = ""
        cbCategory.Text = ""
        txtID.Enabled = False
        btnSearch.Enabled = False
        btnDeleteProduct.Enabled = False
        btnAdd.Enabled = True
        btnUpdateProduct.Enabled = True
        txtPrice.Enabled = False
        txtProdName.Enabled = False
        txtQty.Enabled = False
        cbCategory.Enabled = False
        btnConfirm.Enabled = False
        btnDelete.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.FlatAppearance.BorderSize = 2
        btnConfirm.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        dataTable.Columns.Remove("Remove Product")
        btnDeleteProduct.Enabled = True
        btnConfirm.Visible = True
        btnDelete.Visible = False
        btnUpdate.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy hh: mm : ss")
    End Sub

    Private Sub dataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataTable.CellContentClick
        If e.ColumnIndex <> 5 Then
            Exit Sub
        ElseIf e.ColumnIndex = 5 Then
            If MessageBox.Show("Delete this Product?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
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
                    cmd.CommandText = "DELETE * FROM PRODUCTS WHERE ID = @ID"
                    conn.Open()

                    cmd.Parameters.AddWithValue("@ID", id)
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