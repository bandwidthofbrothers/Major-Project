<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesCheckout
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewOrder = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonProcessOrder = New System.Windows.Forms.Button()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerOrderTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.CustomerOrderTableAdapter()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewOrder
        '
        Me.DataGridViewOrder.AllowUserToAddRows = False
        Me.DataGridViewOrder.AllowUserToDeleteRows = False
        Me.DataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.MenuItemName, Me.Price, Me.Quantity, Me.SubTotal})
        Me.DataGridViewOrder.Location = New System.Drawing.Point(12, 82)
        Me.DataGridViewOrder.Name = "DataGridViewOrder"
        Me.DataGridViewOrder.ReadOnly = True
        Me.DataGridViewOrder.RowTemplate.Height = 24
        Me.DataGridViewOrder.Size = New System.Drawing.Size(503, 418)
        Me.DataGridViewOrder.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'MenuItemName
        '
        Me.MenuItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemName.HeaderText = "Name"
        Me.MenuItemName.Name = "MenuItemName"
        Me.MenuItemName.ReadOnly = True
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle1
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, -8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 87)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order: "
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(27, 557)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(230, 59)
        Me.ButtonCancel.TabIndex = 3
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonProcessOrder
        '
        Me.ButtonProcessOrder.Location = New System.Drawing.Point(285, 557)
        Me.ButtonProcessOrder.Name = "ButtonProcessOrder"
        Me.ButtonProcessOrder.Size = New System.Drawing.Size(230, 59)
        Me.ButtonProcessOrder.TabIndex = 4
        Me.ButtonProcessOrder.Text = "Process Order"
        Me.ButtonProcessOrder.UseVisualStyleBackColor = True
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.BackColor = System.Drawing.Color.Transparent
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.White
        Me.LabelTotal.Location = New System.Drawing.Point(411, 520)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(63, 25)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.Text = "R0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(356, 520)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total: "
        '
        'CustomerOrderTableAdapter
        '
        Me.CustomerOrderTableAdapter.ClearBeforeFill = True
        '
        'PrintDocument
        '
        '
        'FormSalesCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(557, 669)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonProcessOrder)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewOrder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormSalesCheckout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checkout"
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewOrder As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents ButtonProcessOrder As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents CustomerOrderTableAdapter As group22DataSetTableAdapters.CustomerOrderTableAdapter
    Friend WithEvents PrintDocument As Printing.PrintDocument
End Class
