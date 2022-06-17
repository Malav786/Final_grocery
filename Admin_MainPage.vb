Public Class Admin_MainPage
    Private Sub CustomerReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerReportToolStripMenuItem.Click
        Customer_Rep.MdiParent = Me
        Customer_Rep.Show()
    End Sub

    Private Sub EditCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCustomerToolStripMenuItem.Click
        customer_edit.MdiParent = Me
        customer_edit.Show()
    End Sub

    Private Sub StockReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockReportToolStripMenuItem.Click
        stock_rep.MdiParent = Me
        stock_rep.Show()
    End Sub

    Private Sub AddStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStockToolStripMenuItem.Click
        stock_edit.MdiParent = Me
        stock_edit.Show()
    End Sub
End Class