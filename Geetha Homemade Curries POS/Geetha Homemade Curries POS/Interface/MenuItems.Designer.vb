<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MenuItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SmallPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LargePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSet = New Geetha_Homemade_Curries_POS.group22DataSet()
        Me.MenuItemTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.MenuItemTableAdapter()
        Me.TableAdapterManager1 = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.TableAdapterManager()
        Me.EditGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.AddBtn.Location = New System.Drawing.Point(177, 204)
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
        Me.EditGroupBox.Location = New System.Drawing.Point(812, 60)
        Me.EditGroupBox.Name = "EditGroupBox"
        Me.EditGroupBox.Size = New System.Drawing.Size(516, 247)
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
        Me.Label6.Location = New System.Drawing.Point(349, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Price - Medium"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(174, 95)
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
        Me.Label3.Location = New System.Drawing.Point(316, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Item Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 40)
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
        Me.MedTxtbox.Location = New System.Drawing.Point(352, 111)
        Me.MedTxtbox.Name = "MedTxtbox"
        Me.MedTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.MedTxtbox.TabIndex = 7
        '
        'SmallTxtbox
        '
        Me.SmallTxtbox.Location = New System.Drawing.Point(177, 111)
        Me.SmallTxtbox.Name = "SmallTxtbox"
        Me.SmallTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.SmallTxtbox.TabIndex = 6
        '
        'CostTxtbox
        '
        Me.CostTxtbox.Location = New System.Drawing.Point(319, 56)
        Me.CostTxtbox.Name = "CostTxtbox"
        Me.CostTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.CostTxtbox.TabIndex = 4
        '
        'NameTxtbox
        '
        Me.NameTxtbox.Location = New System.Drawing.Point(107, 56)
        Me.NameTxtbox.Name = "NameTxtbox"
        Me.NameTxtbox.Size = New System.Drawing.Size(191, 20)
        Me.NameTxtbox.TabIndex = 3
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(349, 487)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(89, 26)
        Me.DeleteBtn.TabIndex = 4
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuItemIDDataGridViewTextBoxColumn, Me.MenuItemNameDataGridViewTextBoxColumn, Me.MenuItemCostDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.SmallPriceDataGridViewTextBoxColumn, Me.MedPriceDataGridViewTextBoxColumn, Me.LargePriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MenuItemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(755, 397)
        Me.DataGridView1.TabIndex = 5
        '
        'MenuItemIDDataGridViewTextBoxColumn
        '
        Me.MenuItemIDDataGridViewTextBoxColumn.DataPropertyName = "MenuItemID"
        Me.MenuItemIDDataGridViewTextBoxColumn.HeaderText = "MenuItemID"
        Me.MenuItemIDDataGridViewTextBoxColumn.Name = "MenuItemIDDataGridViewTextBoxColumn"
        '
        'MenuItemNameDataGridViewTextBoxColumn
        '
        Me.MenuItemNameDataGridViewTextBoxColumn.DataPropertyName = "MenuItemName"
        Me.MenuItemNameDataGridViewTextBoxColumn.HeaderText = "MenuItemName"
        Me.MenuItemNameDataGridViewTextBoxColumn.Name = "MenuItemNameDataGridViewTextBoxColumn"
        '
        'MenuItemCostDataGridViewTextBoxColumn
        '
        Me.MenuItemCostDataGridViewTextBoxColumn.DataPropertyName = "MenuItemCost"
        Me.MenuItemCostDataGridViewTextBoxColumn.HeaderText = "MenuItemCost"
        Me.MenuItemCostDataGridViewTextBoxColumn.Name = "MenuItemCostDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'SmallPriceDataGridViewTextBoxColumn
        '
        Me.SmallPriceDataGridViewTextBoxColumn.DataPropertyName = "SmallPrice"
        Me.SmallPriceDataGridViewTextBoxColumn.HeaderText = "SmallPrice"
        Me.SmallPriceDataGridViewTextBoxColumn.Name = "SmallPriceDataGridViewTextBoxColumn"
        '
        'MedPriceDataGridViewTextBoxColumn
        '
        Me.MedPriceDataGridViewTextBoxColumn.DataPropertyName = "MedPrice"
        Me.MedPriceDataGridViewTextBoxColumn.HeaderText = "MedPrice"
        Me.MedPriceDataGridViewTextBoxColumn.Name = "MedPriceDataGridViewTextBoxColumn"
        '
        'LargePriceDataGridViewTextBoxColumn
        '
        Me.LargePriceDataGridViewTextBoxColumn.DataPropertyName = "LargePrice"
        Me.LargePriceDataGridViewTextBoxColumn.HeaderText = "LargePrice"
        Me.LargePriceDataGridViewTextBoxColumn.Name = "LargePriceDataGridViewTextBoxColumn"
        '
        'MenuItemBindingSource
        '
        Me.MenuItemBindingSource.DataMember = "MenuItem"
        Me.MenuItemBindingSource.DataSource = Me.Group22DataSet
        '
        'Group22DataSet
        '
        Me.Group22DataSet.DataSetName = "group22DataSet"
        Me.Group22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuItemTableAdapter
        '
        Me.MenuItemTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.CustomerOrderTableAdapter = Nothing
        Me.TableAdapterManager1.CustomerTableAdapter = Nothing
        Me.TableAdapterManager1.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager1.IngredientTableAdapter = Nothing
        Me.TableAdapterManager1.MemberTableAdapter = Nothing
        Me.TableAdapterManager1.MenuItemIngredientTableAdapter = Nothing
        Me.TableAdapterManager1.MenuItemTableAdapter = Nothing
        Me.TableAdapterManager1.TestCasesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Geetha_Homemade_Curries_POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UserStory_MemberTableAdapter = Nothing
        Me.TableAdapterManager1.UserStoryTableAdapter = Nothing
        '
        'MenuItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 575)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditGroupBox)
        Me.Name = "MenuItems"
        Me.Text = "MenuItems"
        Me.EditGroupBox.ResumeLayout(False)
        Me.EditGroupBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents MenuItemBindingSource As BindingSource
    Friend WithEvents MenuItemTableAdapter As group22DataSetTableAdapters.MenuItemTableAdapter
    Friend WithEvents MenuItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SmallPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MedPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LargePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager1 As DataSetTableAdapters.TableAdapterManager
End Class
