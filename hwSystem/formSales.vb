Imports System.Data.OleDb
Imports System.Data
Public Class formSales


    Private Sub formSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim amount As Double

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        salesLoad()


        For x As Integer = 0 To dgvSales.RowCount - 1
            amount += Convert.ToDouble(dgvSales.Rows(x).Cells(7).Value)
        Next
        lblIncome.Text = Format(amount, "#,##0.00")


        Timer1.Enabled = True
        dgvSales.Columns(6).DefaultCellStyle.Format = "N2"
        dgvSales.Columns(7).DefaultCellStyle.Format = "N2"
    End Sub

    Private Sub salesLoad()
        Try
            Dim conn As New OleDbConnection
            Dim cmd As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            conn.ConnectionString = connString
            cmd.Connection = conn
            conn.Open()
            cmd.CommandText = "SELECT [IDs], [Receipt No], [Product ID], [Product Name], [Category], [Quantity], [Price], [Total Amount], [Transaction Date] FROM SALES"
            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            dgvSales.Rows.Clear()
            Do While myReader.Read = True
                dgvSales.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4), myReader(5), myReader(6), myReader(7), myReader(8))

            Loop

            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        dgvSales.Columns(8).DefaultCellStyle.Format = "dd/MM/yyyy"
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        dateSearch()
        Dim amount As Double

        For x As Integer = 0 To dgvSales.RowCount - 1
            amount += Convert.ToDouble(dgvSales.Rows(x).Cells(7).Value)
        Next
        lblIncome.Text = Format(amount, "#,##0.00")

    End Sub

    Private Sub dateSearch()
        Try


            Dim con As New OleDbConnection
            Dim conString As String
            Dim cmd As New OleDbCommand
            conString = My.Settings.dbInventorySysConnectionString
            con.ConnectionString = conString
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "SELECT * FROM [SALES] WHERE [Transaction Date] >= @Date1 AND [Transaction Date] <= @Date2"
            cmd.Parameters.AddWithValue("@Date1", OleDbType.Date).Value = DateTimePicker1.Value
            cmd.Parameters.AddWithValue("@Date2", OleDbType.Date).Value = DateTimePicker2.Value
            cmd.ExecuteNonQuery()

            Dim myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            dgvSales.Rows.Clear()
            Do While myReader.Read = True
                dgvSales.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4), myReader(5), myReader(6), myReader(7), myReader(8))

            Loop

            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim t As TextBox = sender
        Dim amount As Double
        If t.Text IsNot "" Then

            searchSales()

            For x As Integer = 0 To dgvSales.RowCount - 1
                amount += Convert.ToDouble(dgvSales.Rows(x).Cells(7).Value)
            Next
            lblIncome.Text = Format(amount, "#,##0.00")

        Else

            salesLoad()
            For x As Integer = 0 To dgvSales.RowCount - 1
                amount += Convert.ToDouble(dgvSales.Rows(x).Cells(7).Value)
            Next
            lblIncome.Text = Format(amount, "#,##0.00")

        End If
    End Sub

    Private Sub searchSales()
        Try

            Dim searchn As Integer
            searchn = txtSearch.Text
            Dim sqlconn As New OleDbConnection
            Dim sqlquery As New OleDbCommand
            Dim connString As String
            connString = My.Settings.dbInventorySysConnectionString
            sqlconn.ConnectionString = connString
            sqlquery.Connection = sqlconn
            sqlconn.Open()
            sqlquery.CommandText = "SELECT * FROM [SALES] WHERE [Receipt No] LIKE '" & searchn & "%' Order by IDs"
            Dim myReader As OleDbDataReader = sqlquery.ExecuteReader(CommandBehavior.CloseConnection)
            dgvSales.Rows.Clear()

            Do While myReader.Read = True
                dgvSales.Rows.Add(myReader(0), myReader(1), myReader(2), myReader(3), myReader(4), myReader(5), myReader(6), myReader(7), myReader(8))
            Loop
            sqlquery.Dispose()
            sqlconn.Close()
        Catch ex As Exception
            MsgBox("Invalid Input" & vbCrLf & "Please input a number")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = Date.Now.ToString("MMMM dd, yyyy hh:mm:ss")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        formAdminvb.Show()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        formSalesReport.Show()

    End Sub

    Private Sub lblIncome_Click(sender As Object, e As EventArgs) Handles lblIncome.Click

    End Sub
End Class