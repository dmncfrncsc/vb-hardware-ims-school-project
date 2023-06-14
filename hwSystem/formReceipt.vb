Imports System.Data.OleDb

Public Class formReceipt
    Dim username As String
    Public id As String
    Private Sub formReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblReceiptNo.Text = formTransaction.receipt
        username = formLogin.txtUsername.Text

        LoadReceipt()

        getName()

        getNumberOfItems()
        getTotalCashChange()

        lblDate.Text = Format(Now, "MMMM dd, yyyy").ToUpper
        lblTime.Text = Format(Now, "hh:mm:ss tt")

        PrintDialog1.Document = Me.PrintDocument1

        'Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        'If (ButtonPressed = DialogResult.OK) Then
        '    PrintDocument1.Print()
        'End If
    End Sub

    Private Sub getName()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            Dim user As String
            user = lblID.Text
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT [Last Name], [First Name] FROM USERS WHERE [ID]=@user"
            cmd.Parameters.AddWithValue("@user", user)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If dr.Read = True Then
                lblCashierName.Text = dr("Last Name") & ", " & dr("First Name")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub LoadReceipt()
        Dim sqlconn As New OleDbConnection
        Dim sqlquery As New OleDbCommand
        Dim connString As String
        Dim x As Integer = 0
        Dim y As Integer = 0

        Try

            connString = My.Settings.dbInventorySysConnectionString
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "SELECT [Quantity], [Product Name], [Price], [Total Amount] FROM SALES WHERE [Receipt No]=@no"
            sqlquery.Parameters.AddWithValue("@no", lblReceiptNo.Text)
            Dim myReader As OleDbDataReader = sqlquery.ExecuteReader(CommandBehavior.CloseConnection)
            dgvCart.Rows.Clear()
            Do While myReader.Read = True
                dgvCart.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3))
                dgvCart.Height += 19
                x += 19
            Loop
            y = x - 30
            itemCount.Location = New Point(35, 264 + y)
            lblItemNumber.Location = New Point(265, 264 + y)

            total.Location = New Point(35, 289 + y)
            lblTotal.Location = New Point(265, 289 + y)

            cash.Location = New Point(35, 306 + y)
            lblCash.Location = New Point(265, 306 + y)

            change.Location = New Point(35, 330 + y)
            lblChange.Location = New Point(265, 330 + y)

            lblLine.Location = New Point(58, 360 + y)
            lblDetails.Location = New Point(100, 379 + y)
            Panel1.Height = Panel1.Height + y
            Me.Height = Me.Height + y
            sqlquery.Dispose()
            sqlconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub getNumberOfItems()
        lblItemNumber.Text = dgvCart.Rows.Count
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPs As New PageSetupDialog
        aPs.Document = PrintDocument1
    End Sub

    Private Sub getTotalCashChange()
        Dim total As Double
        Dim payment As Double
        Dim change As Double

        For index As Integer = 0 To dgvCart.RowCount - 1
            total += Convert.ToDouble(dgvCart.Rows(index).Cells(3).Value)
            lblTotal.Text = Format(total, "#,##0.00")

        Next

        payment = formTransaction.txtPayment.Text
        lblCash.Text = Format(payment, "#,##0.00")
        Convert.ToDouble(payment)
        Convert.ToDouble(total)
        change = payment - total
        Convert.ToDouble(change)
        lblChange.Text = Format(change, "#,##0.00")

    End Sub

End Class