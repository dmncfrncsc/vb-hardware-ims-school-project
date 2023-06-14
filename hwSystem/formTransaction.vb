
Imports System.Data.OleDb
Imports System.Data

Public Class formTransaction
    Dim selectedIndex As Integer
    Dim subTotal, transID As Integer

    Dim receiptNo As New Random

    Public receipt As String
    Private Sub formTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DbInventorySysDataSet.PRODUCTS' table. You can move, or remove it, as needed.
        lblUsername.Text = formLogin.txtUsername.Text
        productLoad()
        lblTotalAmount.Text = ""
        generateReceiptNo()

        receipt = transID
        Timer1.Enabled = True
        dgvCart.Columns(6).DefaultCellStyle.Format = "N2"
        tableProducts.Columns(2).DefaultCellStyle.Format = "N2"
    End Sub
    Private Sub generateReceiptNo()

        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT [Receipt No] FROM SALES ORDER BY [Receipt No] DESC"
            Dim red As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If red.Read = True Then
                transID = Val(red(0)) + 1
            End If
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub productLoad()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT [ID], [ProductName], [ProductPrice], [ProductQuantity], [Category] FROM PRODUCTS  ORDER BY [Category] DESC"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
          
            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop


            Dim buttonColumn As New DataGridViewButtonColumn()
            buttonColumn.HeaderText = ""

            buttonColumn.Name = "Select Product"
            buttonColumn.Text = "Select Product"
            buttonColumn.FlatStyle = FlatStyle.Flat



            buttonColumn.UseColumnTextForButtonValue = True
            tableProducts.Columns.Add(buttonColumn)
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub





    Private Sub btnHndTools_Click(sender As Object, e As EventArgs) Handles btnHndTools.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Hand Tool And Power Tools'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPaint_Click(sender As Object, e As EventArgs) Handles btnPaint.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Paints'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Home And Living'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAutoMotive_Click(sender As Object, e As EventArgs) Handles btnAutoMotive.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Automotive'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop

            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOut_Click(sender As Object, e As EventArgs) Handles btnOut.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Outdoor Living'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop

            cmd.Dispose()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnHomeImprov_Click(sender As Object, e As EventArgs) Handles btnHomeImprov.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Home Improvement'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPlumbing_Click(sender As Object, e As EventArgs) Handles btnPlumbing.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Plumbing'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnElectrical_Click(sender As Object, e As EventArgs) Handles btnElectrical.Click
        tableProducts.DataSource = Nothing
        tableProducts.Rows.Clear()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT * FROM PRODUCTS WHERE [CATEGORY]='Electrical'"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

            Loop
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click
        Dim buttonColumn, btnInc, btnDec As New DataGridViewButtonColumn()

        buttonColumn.HeaderText = ""
        buttonColumn.Name = "Remove Product"
        buttonColumn.Text = "Remove"
        buttonColumn.FlatStyle = FlatStyle.Flat
        buttonColumn.DefaultCellStyle.BackColor = Color.Khaki

        btnInc.HeaderText = ""
        btnInc.Name = "Increase Product"
        btnInc.Text = "+"
        btnInc.FlatStyle = FlatStyle.Flat
        btnInc.DefaultCellStyle.BackColor = Color.MediumAquamarine

        btnDec.HeaderText = ""
        btnDec.Name = "Decrease Product"
        btnDec.Text = "-"
        btnDec.FlatStyle = FlatStyle.Flat
        btnDec.DefaultCellStyle.BackColor = Color.LightCoral

        buttonColumn.UseColumnTextForButtonValue = True
        btnInc.UseColumnTextForButtonValue = True
        btnDec.UseColumnTextForButtonValue = True
        dgvCart.Columns.Add(buttonColumn)
        dgvCart.Columns.Add(btnInc)
        dgvCart.Columns.Add(btnDec)
        btnVoid.Visible = False
        btnConfirmVoid.Visible = True
        btnCheckOut.Visible = False
        dgvCart.Enabled = True

    End Sub

    Private Sub btnConfirmVoid_Click(sender As Object, e As EventArgs) Handles btnConfirmVoid.Click
        btnVoid.Visible = True
        btnConfirmVoid.Visible = False
        btnCheckOut.Visible = True
        dgvCart.Columns.Remove("Remove Product")
        dgvCart.Columns.Remove("Decrease Product")
        dgvCart.Columns.Remove("Increase Product")
        dgvCart.Enabled = False

    End Sub

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick
        If e.ColumnIndex = 7 Then
            selectedIndex = e.RowIndex
            dgvCart.Rows.RemoveAt(selectedIndex)
        ElseIf e.ColumnIndex = 8 Then
            Dim qty As Integer
            Dim subtotal As Double
            selectedIndex = e.RowIndex
            qty = dgvCart.Rows(selectedIndex).Cells(5).Value
            dgvCart.Rows(e.RowIndex).Cells(5).Value = qty + 1
            subtotal = dgvCart.Rows(selectedIndex).Cells(4).Value * dgvCart.Rows(e.RowIndex).Cells(5).Value
            dgvCart.Rows(e.RowIndex).Cells(6).Value = Format(subtotal, "#,##0.00")
        ElseIf e.ColumnIndex = 9 Then
            Dim qty As Integer
            Dim subtotal As Double
            selectedIndex = e.RowIndex
            qty = dgvCart.Rows(selectedIndex).Cells(5).Value
            If qty > 1 Then
                dgvCart.Rows(e.RowIndex).Cells(5).Value = qty - 1
                subtotal = dgvCart.Rows(selectedIndex).Cells(4).Value * dgvCart.Rows(e.RowIndex).Cells(5).Value
                dgvCart.Rows(e.RowIndex).Cells(6).Value = Format(subtotal, "#,##0.00")
            Else
                MsgBox("Quantity cannot be lowered", MsgBoxStyle.Critical)
            End If

        Else
            Exit Sub

        End If
        Dim total As Double

        For index As Integer = 0 To dgvCart.RowCount - 1
            total += Convert.ToDouble(dgvCart.Rows(index).Cells(6).Value)
            lblTotalAmount.Text = Format(total, "#,##0.00")
        Next

    End Sub

    Private Sub searchProd()
        Try
            Dim sqlconn As New OleDbConnection
            Dim sqlquery As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "SELECT * FROM PRODUCTS WHERE ProductName LIKE '" & txtSearch.Text & "%' Order by ID"
            Dim myReader As OleDbDataReader = sqlquery.ExecuteReader(CommandBehavior.CloseConnection)
            tableProducts.Rows.Clear()
            Do While myReader.Read = True
                tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))
            Loop
            sqlquery.Dispose()
            sqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvCart_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCart.RowsRemoved
        Dim total As Double
        If dgvCart.Rows.Count = 0 Then
            total = 0
            lblTotalAmount.Text = Format(total, "#,##0.00")


        End If
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim payment, totalAmount As Double
        payment = txtPayment.Text
        totalAmount = lblTotalAmount.Text

        If payment < totalAmount Then
            lblError.Text = "Insufficient payment"
            lblError.Visible = True
            txtPayment.Focus()

        Else
            lblError.Text = ""

            Dim result As Integer = MessageBox.Show("Proceed checkout?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then

                Dim receiptNo, prodCode, qty As Integer
                Dim price, tAmount As Double
                Dim prodName, prodCategory As String
                Dim dt As Date = Today
                Dim conns As New OleDbConnection
                Dim cmds As New OleDbCommand
                Dim connStrings As String
                Try
                    For i As Integer = 0 To dgvCart.Rows.Count - 1
                        Using conn As New OleDbConnection(My.Settings.dbInventorySysConnectionString)
                            Using command As New OleDbCommand()
                                With command
                                    .Connection = conn
                                    .CommandType = CommandType.Text
                                    .CommandText = "INSERT INTO SALES ([Receipt No], [Product ID], [Product Name], [Category], [Quantity], [Price], [Total Amount], [Transaction Date]) VALUES (@receipt, @prodCode, @prodName, @prodCat, @qty, @price, @totalAm, @dt)"
                                    receiptNo = dgvCart.Rows(i).Cells(0).Value
                                    prodCode = dgvCart.Rows(i).Cells(1).Value
                                    prodCategory = dgvCart.Rows(i).Cells(2).Value
                                    prodName = dgvCart.Rows(i).Cells(3).Value
                                    price = dgvCart.Rows(i).Cells(4).Value
                                    qty = dgvCart.Rows(i).Cells(5).Value
                                    tAmount = dgvCart.Rows(i).Cells(6).Value
                                    .Parameters.AddWithValue("@receipt", receiptNo)
                                    .Parameters.AddWithValue("@prodCode", prodCode)
                                    .Parameters.AddWithValue("@prodName", prodName)
                                    .Parameters.AddWithValue("@prodCat", prodCategory)
                                    .Parameters.AddWithValue("@qty", qty)
                                    .Parameters.AddWithValue("@price", price)
                                    .Parameters.AddWithValue("@totalAm", tAmount)
                                    .Parameters.AddWithValue("@dt", dt)
                                End With
                                Try
                                    conn.Open()
                                    command.ExecuteNonQuery()
                                    conn.Close()
                                    command.Dispose()
                                Catch ex As Exception
                                    MessageBox.Show(ex.Message.ToString())
                                End Try
                            End Using
                            Using command As New OleDbCommand()
                                With command

                                    .Connection = conn
                                    .CommandType = CommandType.Text
                                    .CommandText = "UPDATE [PRODUCTS] SET [ProductQuantity]=[ProductQuantity] - @qty WHERE [ID]=@prodCode"

                                    .Parameters.AddWithValue("@prodCode", prodCode)
                                    .Parameters.AddWithValue("@qty", qty)
                                End With

                                Try
                                    conn.Open()
                                    command.ExecuteNonQuery()

                                Catch ex As Exception
                                    MessageBox.Show(ex.Message.ToString())
                                End Try
                            End Using
                        End Using

                    Next
                    For i As Integer = 0 To dgvCart.Rows.Count - 1

                        connStrings = My.Settings.dbInventorySysConnectionString
                        conns.ConnectionString = connStrings
                        cmds.Connection = conns
                        conns.Open()
                        prodCode = dgvCart.Rows(i).Cells(1).Value
                        qty = dgvCart.Rows(i).Cells(5).Value
                        cmds.CommandText = "UPDATE PRODUCTS SET [ProductQuantity] =  [ProductQuantity]-@quanti WHERE [ID] = @id"
                        cmds.Parameters.AddWithValue("@quanti", qty)
                        cmds.Parameters.AddWithValue("@id", prodCode)
                        cmds.ExecuteNonQuery()
                        conns.Close()
                        cmds.Dispose()


                    Next
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
                formReceipt.Show()

                dgvCart.Rows.Clear()
                Try
                    Dim conn As New OleDbConnection
                    Dim cmd As New OleDbCommand
                    Dim connString As String
                    connString = My.Settings.dbInventorySysConnectionString
                    conn.ConnectionString = connString
                    cmd.Connection = conn
                    conn.Open()
                    cmd.CommandText = "SELECT [ID], [ProductName], [ProductPrice], [ProductQuantity], [Category] FROM PRODUCTS ORDER BY [Category] DESC"
                    Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                    tableProducts.Rows.Clear()
                    Do While myReader.Read = True
                        tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

                    Loop
                    cmd.Dispose()
                    conn.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                generateReceiptNo()
                Dim total As Integer = 0

                txtPayment.Text = total
                lblTotalAmount.Text = total

            End If
        End If

    End Sub

    Private Sub tableProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableProducts.CellContentClick
        If e.ColumnIndex <> 5 Then
            Exit Sub
        ElseIf e.ColumnIndex = 5 Then
            Dim price As Double
            selectedIndex = e.RowIndex
            Dim selectedRow As DataGridViewRow = tableProducts.Rows(selectedIndex)
            txtProduct.Text = selectedRow.Cells(0).Value.ToString
            txtProductName.Text = selectedRow.Cells(1).Value.ToString
            price = selectedRow.Cells(2).Value.ToString
            txtPrice.Text = Format(price, "#,##0.00")
            txtAvailQty.Text = selectedRow.Cells(3).Value.ToString
            txtCategory.Text = selectedRow.Cells(4).Value.ToString

            txtQuantity.Focus()

            If txtAvailQty.Text <= 0 Then

                txtQuantity.Enabled = False
                lblErroMessageQty.Visible = True
            Else
                lblErroMessageQty.Visible = False
                txtQuantity.Enabled = True
                btnConfirm.Enabled = True
            End If


            btnCancel.Enabled = True

            tableProducts.Enabled = False
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim inqty, availqty As Integer
        inqty = txtQuantity.Text
        availqty = txtAvailQty.Text
        If inqty > availqty Then
            lblErrorQuantity.Visible = True
        Else
            btnConfirm.Enabled = True
            lblErrorQuantity.Visible = False
            Dim code, qty As Integer
            Dim price, total, subtotal As Double
            code = txtProduct.Text
            qty = txtQuantity.Text
            price = txtPrice.Text
            subtotal = price * qty
            total = Format(subtotal, "#,##0.00")


            dgvCart.Rows.Add(receipt, code, txtCategory.Text.ToString, txtProductName.Text.ToString, price, qty, total)
            txtAvailQty.Text = ""
            txtCategory.Text = ""
            txtPrice.Text = ""
            txtProduct.Text = ""
            txtProductName.Text = ""
            txtQuantity.Text = ""
            txtSearch.Text = ""
            btnConfirm.Enabled = False
            btnCancel.Enabled = False
            tableProducts.Enabled = True
        End If



    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim t As TextBox = sender
        Dim search As String
        If t.Text IsNot "" Then

            searchProd()
        Else
            search = ""
            txtSearch.Text = search

            Try
                Dim conn As New OleDbConnection
                Dim cmd As New OleDbCommand
                Dim connString As String
                connString = My.Settings.dbInventorySysConnectionString
                conn.ConnectionString = connString
                cmd.Connection = conn
                conn.Open()
                cmd.CommandText = "SELECT [ID], [ProductName], [ProductPrice], [ProductQuantity], [Category] FROM PRODUCTS WHERE [ProductName]"
                Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                tableProducts.Rows.Clear()
                Do While myReader.Read = True
                    tableProducts.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4))

                Loop

                cmd.Dispose()
                conn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lblErroMessageQty.Visible = False
        txtCategory.Text = ""
        txtPrice.Text = ""
        txtProduct.Text = ""
        txtProductName.Text = ""
        txtQuantity.Text = ""
        txtAvailQty.Text = ""
        tableProducts.Enabled = True
        txtQuantity.Enabled = False
        btnConfirm.Enabled = False
        btnCancel.Enabled = False

        For index As Integer = 0 To tableProducts.RowCount - 1
            tableProducts.Rows(index).DefaultCellStyle.BackColor = Color.White
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss")
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        If MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
            formLogin.txtPassword.Text = ""
            formLogin.txtUsername.Text = ""
            formLogin.Show()
        End If



    End Sub


    Private Sub dgvCart_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvCart.RowsAdded
        Dim total As Double
        For index As Integer = 0 To dgvCart.RowCount - 1
            total += Convert.ToDouble(dgvCart.Rows(index).Cells(6).Value)
            lblTotalAmount.Text = Format(total, "#,##0.00")
        Next
    End Sub



    Private Sub btnIncrease_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class