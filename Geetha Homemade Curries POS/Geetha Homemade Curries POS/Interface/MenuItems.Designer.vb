<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItems
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuGridView = New System.Windows.Forms.DataGridView()
        Me.MenuItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Geetha_Homemade_Curries_POS.DataSet()
        Me.ItemTxtbox = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.EditGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.CategoryBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LargeTxtbox = New System.Windows.Forms.TextBox()
        Me.MedTxtbox = New System.Windows.Forms.TextBox()
        Me.SmallTxtbox = New System.Windows.Forms.TextBox()
        Me.CostTxtbox = New System.Windows.Forms.TextBox()
        Me.NameTxtbox = New System.Windows.Forms.TextBox()
        Me.MenuItemTableAdapter1 = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.MenuItemTableAdapter()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        CType(Me.MenuGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EditGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuGridView
        '
        Me.MenuGridView.AllowUserToOrderColumns = True
        Me.MenuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuGridView.Location = New System.Drawing.Point(12, 26)
        Me.MenuGridView.Name = "MenuGridView"
        Me.MenuGridView.Size = New System.Drawing.Size(542, 238)
        Me.MenuGridView.TabIndex = 0
        '
        'MenuItemBindingSource
        '
        Me.MenuItemBindingSource.DataMember = "MenuItem"
        Me.MenuItemBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemTxtbox
        '
        Me.ItemTxtbox.Location = New System.Drawing.Point(24, 56)
        Me.ItemTxtbox.Name = "ItemTxtbox"
        Me.ItemTxtbox.Size = New System.Drawing.Size(67, 20)
        Me.ItemTxtbox.TabIndex = 1
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(160, 204)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(87, 24)
        Me.AddBtn.TabIndex = 2
        Me.AddBtn.Text = "Add Item"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'EditGroupBox
        '
        Me.EditGroupBox.Controls.Add(Me.UpdateBtn)
        Me.EditGroupBox.Controls.Add(Me.CategoryBox)
        Me.EditGroupBox.Controls.Add(Me.Label7)
        Me.EditGroupBox.Controls.Add(Me.Label6)
        Me.EditGroupBox.Controls.Add(Me.Label5)
        Me.EditGroupBox.Controls.Add(Me.Label4)
        Me.EditGroupBox.Controls.Add(Me.Label3)
        Me.EditGroupBox.Controls.Add(Me.Label2)
        Me.EditGroupBox.Controls.Add(Me.Label1)
        Me.EditGroupBox.Controls.Add(Me.LargeTxtbox)
        Me.EditGroupBox.Controls.Add(Me.MedTxtbox)
        Me.EditGroupBox.Controls.Add(Me.SmallTxtbox)
        Me.EditGroupBox.Controls.Add(Me.CostTxtbox)
        Me.EditGroupBox.Controls.Add(Me.NameTxtbox)
        Me.EditGroupBox.Controls.Add(Me.AddBtn)
        Me.EditGroupBox.Controls.Add(Me.ItemTxtbox)
        Me.EditGroupBox.Location = New System.Drawing.Point(604, 36)
        Me.EditGroupBox.Name = "EditGroupBox"
        Me.EditGroupBox.Size = New System.Drawing.Size(608, 255)
        Me.EditGroupBox.TabIndex = 3
        Me.EditGroupBox.TabStop = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(339, 204)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(87, 24)
        Me.UpdateBtn.TabIndex = 18
        Me.UpdateBtn.Text = "Update Item"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'CategoryBox
        '
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Location = New System.Drawing.Point(24, 111)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(141, 21)
        Me.CategoryBox.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price - Large"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Price - Medium"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Price - Small"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Item Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = " Item ID"
        '
        'LargeTxtbox
        '
        Me.LargeTxtbox.Location = New System.Drawing.Point(24, 158)
        Me.LargeTxtbox.Name = "LargeTxtbox"
        Me.LargeTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.LargeTxtbox.TabIndex = 8
        '
        'MedTxtbox
        '
        Me.MedTxtbox.Location = New System.Drawing.Point(378, 111)
        Me.MedTxtbox.Name = "MedTxtbox"
        Me.MedTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.MedTxtbox.TabIndex = 7
        '
        'SmallTxtbox
        '
        Me.SmallTxtbox.Location = New System.Drawing.Point(202, 111)
        Me.SmallTxtbox.Name = "SmallTxtbox"
        Me.SmallTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.SmallTxtbox.TabIndex = 6
        '
        'CostTxtbox
        '
        Me.CostTxtbox.Location = New System.Drawing.Point(378, 56)
        Me.CostTxtbox.Name = "CostTxtbox"
        Me.CostTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.CostTxtbox.TabIndex = 4
        '
        'NameTxtbox
        '
        Me.NameTxtbox.Location = New System.Drawing.Point(127, 56)
        Me.NameTxtbox.Name = "NameTxtbox"
        Me.NameTxtbox.Size = New System.Drawing.Size(191, 20)
        Me.NameTxtbox.TabIndex = 3
        '
        'MenuItemTableAdapter1
        '
        Me.MenuItemTableAdapter1.ClearBeforeFill = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(203, 322)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(89, 26)
        Me.DeleteBtn.TabIndex = 4
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'MenuItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 368)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditGroupBox)
        Me.Controls.Add(Me.MenuGridView)
        Me.Name = "MenuItems"
        Me.Text = "MenuItems"
        CType(Me.MenuGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EditGroupBox.ResumeLayout(False)
        Me.EditGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuGridView As DataGridView
    Friend WithEvents ItemTxtbox As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents EditGroupBox As GroupBox
    Friend WithEvents CategoryBox As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LargeTxtbox As TextBox
    Friend WithEvents MedTxtbox As TextBox
    Friend WithEvents SmallTxtbox As TextBox
    Friend WithEvents CostTxtbox As TextBox
    Friend WithEvents NameTxtbox As TextBox
    Friend WithEvents MenuItemBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents MenuItemTableAdapter1 As DataSetTableAdapters.MenuItemTableAdapter
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
End Class
