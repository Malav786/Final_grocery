<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockQuantityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StockReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerReportToolStripMenuItem, Me.EditCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(86, 24)
        Me.CustomerToolStripMenuItem.Text = "Customer"
        '
        'CustomerReportToolStripMenuItem
        '
        Me.CustomerReportToolStripMenuItem.Name = "CustomerReportToolStripMenuItem"
        Me.CustomerReportToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CustomerReportToolStripMenuItem.Text = "Customer Report"
        '
        'EditCustomerToolStripMenuItem
        '
        Me.EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem"
        Me.EditCustomerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.EditCustomerToolStripMenuItem.Text = "Edit Customer"
        '
        'StockQuantityToolStripMenuItem
        '
        Me.StockQuantityToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockReportToolStripMenuItem, Me.AddStockToolStripMenuItem})
        Me.StockQuantityToolStripMenuItem.Name = "StockQuantityToolStripMenuItem"
        Me.StockQuantityToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.StockQuantityToolStripMenuItem.Text = "Stock Quantity"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerToolStripMenuItem, Me.StockQuantityToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1208, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StockReportToolStripMenuItem
        '
        Me.StockReportToolStripMenuItem.Name = "StockReportToolStripMenuItem"
        Me.StockReportToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.StockReportToolStripMenuItem.Text = "Stock Report"
        '
        'AddStockToolStripMenuItem
        '
        Me.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem"
        Me.AddStockToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddStockToolStripMenuItem.Text = "Add Stock"
        '
        'Admin_MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 764)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin_MainPage"
        Me.Text = "Admin_MainPage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockQuantityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StockReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStockToolStripMenuItem As ToolStripMenuItem
End Class
