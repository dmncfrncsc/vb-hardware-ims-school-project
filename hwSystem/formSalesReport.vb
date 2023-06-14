Imports System.Data.OleDb

Public Class formSalesReport


    Private Sub formSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportLoad()
        getTotalIncome()

        PrintDialog1.Document = Me.PrintDocument1

        'Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        'If (ButtonPressed = DialogResult.OK) Then
        '    PrintDocument1.Print()
        'End If

        Me.Hide()

    End Sub

    Private Sub reportLoad()
        Dim x As Integer = 0
        Dim y As Integer = 0
        Dim receNo, prodID, qty As Integer
        Dim price, totalAmount As Double
        Dim transactionDate As Date
        Dim prodname, category As String



        For q As Integer = 0 To formSales.dgvSales.Rows.Count - 1
            receNo = formSales.dgvSales.Rows(q).Cells(1).Value
            prodID = formSales.dgvSales.Rows(q).Cells(2).Value
            prodname = formSales.dgvSales.Rows(q).Cells(3).Value
            category = formSales.dgvSales.Rows(q).Cells(4).Value
            qty = formSales.dgvSales.Rows(q).Cells(5).Value
            price = formSales.dgvSales.Rows(q).Cells(6).Value
            totalAmount = formSales.dgvSales.Rows(q).Cells(7).Value
            transactionDate = formSales.dgvSales.Rows(q).Cells(8).Value

            dgvSalesReport.Rows.Add(receNo, prodID, prodname, category, qty, price, totalAmount, transactionDate)

            dgvSalesReport.Height += 19
            x += 19
        Next
        y = x - 30

        dgvSalesReport.Columns(7).DefaultCellStyle.Format = "dd/MM/yyyy"
        lblIncome.Location = New Point(886, 201 + y)
        lblTotal.Location = New Point(1031, 201 + y)
        Panel1.Height = Panel1.Height + y
        Me.Height = Me.Height + y

    End Sub
    Private Sub getTotalIncome()
        lblTotal.Text = Format(formSales.lblIncome.Text)
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Dim aPs As New PageSetupDialog
        aPs.Document = PrintDocument1

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class