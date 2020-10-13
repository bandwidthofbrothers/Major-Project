<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrders
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewOrders = New System.Windows.Forms.DataGridView()
        Me.OrderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 87)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Orders: "
        '
        'DataGridViewOrders
        '
        Me.DataGridViewOrders.AllowUserToAddRows = False
        Me.DataGridViewOrders.AllowUserToDeleteRows = False
        Me.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderID, Me.MenuItemName, Me.Quantity})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewOrders.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewOrders.Location = New System.Drawing.Point(27, 99)
        Me.DataGridViewOrders.Name = "DataGridViewOrders"
        Me.DataGridViewOrders.ReadOnly = True
        Me.DataGridViewOrders.RowTemplate.Height = 24
        Me.DataGridViewOrders.Size = New System.Drawing.Size(1139, 594)
        Me.DataGridViewOrders.TabIndex = 20
        '
        'OrderID
        '
        Me.OrderID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OrderID.HeaderText = "OrderID"
        Me.OrderID.Name = "OrderID"
        Me.OrderID.ReadOnly = True
        '
        'MenuItemName
        '
        Me.MenuItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemName.HeaderText = "Menu Item Name"
        Me.MenuItemName.Name = "MenuItemName"
        Me.MenuItemName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'FormOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1195, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridViewOrders)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormOrders"
        Me.Text = "Orders"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewOrders As DataGridView
    Friend WithEvents OrderID As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
End Class
