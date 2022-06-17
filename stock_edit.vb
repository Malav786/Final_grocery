Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Public Class stock_edit
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqlRd As MySqlDataReader
    Dim sqlDt As New DataTable
    Dim dtA As New MySqlDataAdapter
    Dim sqlQuery As String

    Dim server As String = "localhost"
    Dim username As String = "root"
    Dim password As String = "Malav108020"
    Dim database As String = "myconnector"

    Private bitmap As Bitmap
    Private Sub updateTable()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * FROM myconnector.stocks"
        sqlRd = sqlCmd.ExecuteReader
        sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
        DataGridView1.DataSource = sqlDt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        Try
            sqlConn.Open()
            sqlQuery = "insert into myconnector.stocks(desc, quantity, category, price, dof) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & DateTimePicker1.Text & "')"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MySql Connector", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            For Each txt In Me.Controls
                If TypeOf txt Is TextBox Then
                    txt.text = ""
                End If
            Next
            MessageBox.Show("Data Reset")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            sqlConn.Open()
            sqlQuery = "Delete from myconnector.stocks where name = '" & TextBox1.Text & "'"
            sqlCmd = New MySqlCommand(sqlQuery, sqlConn)
            sqlRd = sqlCmd.ExecuteReader
            MessageBox.Show("Data Deleted")
            sqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            sqlConn.Dispose()
        End Try
        updateTable()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        With sqlCmd
            .CommandText = "Update myconnector.stocks set desc = @desc , quantity = @quantity , category = @category , price = @price , dof = @dof"
            .CommandType = CommandType.Text
            .Parameters.AddWithValue("@desc", TextBox1.Text)
            .Parameters.AddWithValue("@quantity", TextBox2.Text)
            .Parameters.AddWithValue("@category", TextBox3.Text)
            .Parameters.AddWithValue("@price", TextBox4.Text)
            .Parameters.AddWithValue("@dof", DateTimePicker1.Text)
        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        updateTable()
    End Sub

    Private Sub stock_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTable()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            TextBox1.Text = DataGridView1.SelectedRows(0).Cells(1).Value.ToString
            TextBox2.Text = DataGridView1.SelectedRows(0).Cells(2).Value.ToString
            TextBox3.Text = DataGridView1.SelectedRows(0).Cells(3).Value.ToString
            TextBox4.Text = DataGridView1.SelectedRows(0).Cells(4).Value.ToString
            DateTimePicker1.Text = DataGridView1.SelectedRows(0).Cells(5).Value.ToString
        Catch ex As Exception
            MessageBox.Show("Not done properly")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim recP As RectangleF = e.PageSettings.PrintableArea
        If Me.DataGridView1.Height - recP.Height > 0 Then e.HasMorePages = True
    End Sub
End Class