<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSales
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxOrder = New System.Windows.Forms.GroupBox()
        Me.DataGridViewOrder = New System.Windows.Forms.DataGridView()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonProceedToCheckout = New System.Windows.Forms.Button()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.ButtonRemoveItem = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MenuItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxOrder.SuspendLayout()
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxOrder
        '
        Me.GroupBoxOrder.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxOrder.Controls.Add(Me.DataGridViewOrder)
        Me.GroupBoxOrder.Controls.Add(Me.LabelTotal)
        Me.GroupBoxOrder.Controls.Add(Me.Label1)
        Me.GroupBoxOrder.ForeColor = System.Drawing.Color.White
        Me.GroupBoxOrder.Location = New System.Drawing.Point(22, 13)
        Me.GroupBoxOrder.Name = "GroupBoxOrder"
        Me.GroupBoxOrder.Size = New System.Drawing.Size(457, 608)
        Me.GroupBoxOrder.TabIndex = 0
        Me.GroupBoxOrder.TabStop = False
        Me.GroupBoxOrder.Text = "Order"
        '
        'DataGridViewOrder
        '
        Me.DataGridViewOrder.AllowUserToAddRows = False
        Me.DataGridViewOrder.AllowUserToDeleteRows = False
        Me.DataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuItemID, Me.MenuItemName, Me.Price, Me.Quantity, Me.SubTotal})
        Me.DataGridViewOrder.Location = New System.Drawing.Point(18, 31)
        Me.DataGridViewOrder.Name = "DataGridViewOrder"
        Me.DataGridViewOrder.ReadOnly = True
        Me.DataGridViewOrder.RowTemplate.Height = 24
        Me.DataGridViewOrder.Size = New System.Drawing.Size(421, 523)
        Me.DataGridViewOrder.TabIndex = 3
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.ForeColor = System.Drawing.Color.White
        Me.LabelTotal.Location = New System.Drawing.Point(70, 573)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(46, 17)
        Me.LabelTotal.TabIndex = 2
        Me.LabelTotal.Text = "R0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 573)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total: "
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.Location = New System.Drawing.Point(497, 25)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(815, 596)
        Me.Panel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.ButtonProceedToCheckout)
        Me.GroupBox1.Controls.Add(Me.ButtonBack)
        Me.GroupBox1.Location = New System.Drawing.Point(498, 627)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(815, 74)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'ButtonProceedToCheckout
        '
        Me.ButtonProceedToCheckout.Location = New System.Drawing.Point(540, 21)
        Me.ButtonProceedToCheckout.Name = "ButtonProceedToCheckout"
        Me.ButtonProceedToCheckout.Size = New System.Drawing.Size(256, 39)
        Me.ButtonProceedToCheckout.TabIndex = 0
        Me.ButtonProceedToCheckout.Text = "Proceed to Checkout"
        Me.ButtonProceedToCheckout.UseVisualStyleBackColor = True
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(17, 21)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(256, 39)
        Me.ButtonBack.TabIndex = 2
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'ButtonRemoveItem
        '
        Me.ButtonRemoveItem.Location = New System.Drawing.Point(106, 21)
        Me.ButtonRemoveItem.Name = "ButtonRemoveItem"
        Me.ButtonRemoveItem.Size = New System.Drawing.Size(256, 39)
        Me.ButtonRemoveItem.TabIndex = 1
        Me.ButtonRemoveItem.Text = "Remove Item"
        Me.ButtonRemoveItem.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ButtonRemoveItem)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 627)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(457, 74)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'MenuItemID
        '
        Me.MenuItemID.HeaderText = "ID"
        Me.MenuItemID.Name = "MenuItemID"
        Me.MenuItemID.ReadOnly = True
        Me.MenuItemID.Visible = False
        '
        'MenuItemName
        '
        Me.MenuItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.MenuItemName.DefaultCellStyle = DataGridViewCellStyle1
        Me.MenuItemName.HeaderText = "Name"
        Me.MenuItemName.Name = "MenuItemName"
        Me.MenuItemName.ReadOnly = True
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Price.DefaultCellStyle = DataGridViewCellStyle2
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle3
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'SubTotal
        '
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.SubTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'FormSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1325, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.GroupBoxOrder)
        Me.Name = "FormSales"
        Me.Text = "Sales"
        Me.GroupBoxOrder.ResumeLayout(False)
        Me.GroupBoxOrder.PerformLayout()
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxOrder As GroupBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonProceedToCheckout As Button
    Friend WithEvents ButtonRemoveItem As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridViewOrder As DataGridView
    Friend WithEvents MenuItemID As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemName As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
End Class
