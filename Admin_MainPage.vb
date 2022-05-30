Public Class Admin_MainPage
    Private Sub CustomerReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReportToolStripMenuItem.Click
        Customer_Rep.MdiParent = Me
        Customer_Rep.Show()
    End Sub

    Private Sub EditCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCustomerToolStripMenuItem.Click
        customer_edit.MdiParent = Me
        customer_edit.Show()
    End Sub
End Class