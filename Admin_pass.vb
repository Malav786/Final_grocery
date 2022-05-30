Public Class Admin_pass

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "charly" Then
            Me.Hide()
            Admin_MainPage.Show()
        Else
            MessageBox.Show("Entered Password Is Wrong. Try Again")
            Me.Show()
        End If
    End Sub
End Class