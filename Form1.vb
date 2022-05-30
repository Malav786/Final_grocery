Imports MySql.Data.MySqlClient
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32

Public Class Form1

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
    Private Sub updateTableCon()
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        sqlCmd.CommandText = "SELECT * FROM myconnector.user_reg"
        sqlRd = sqlCmd.ExecuteReader
        'sqlDt.Load(sqlRd)
        sqlRd.Close()
        sqlConn.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        new_acc_reg.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sqlConn.ConnectionString = "server =" + server + ";" + "user id =" + username + ";" + "password =" + password + ";" + "database =" + database
        sqlConn.Open()
        sqlCmd.Connection = sqlConn
        With sqlCmd
            .CommandText = "Select * from myconnector.user_reg u1 , myconnector.user_reg p1 where u1.username = '" & TextBox1.Text & "' and p1.password = '" & TextBox2.Text & "'"
            .CommandType = CommandType.Text
        End With
        sqlCmd.ExecuteNonQuery()
        sqlConn.Close()
        If TextBox1.Text.Trim() = "" Or TextBox1.Text.Trim().ToLower() = "username" Then
            MessageBox.Show("Enter Your Username To Login", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox2.Text.Trim() = "" Or TextBox2.Text.Trim().ToLower() = "password" Then
            MessageBox.Show("Enter Your Password To Login", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            dtA.SelectCommand = sqlCmd
            dtA.Fill(sqlDt)
            If sqlDt.Rows.Count = 1 Then
                Me.Hide()
                loading.Show()
            Else
                MessageBox.Show("This Username Or/And Password Doesn't Exists", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        updateTableCon()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Admin_pass.Show()
    End Sub
End Class
