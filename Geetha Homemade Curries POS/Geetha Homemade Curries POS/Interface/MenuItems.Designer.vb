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
        Me.TableAdapterManager1 = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.TableAdapterManager()
        Me.MenuItemTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.MenuItemTableAdapter()
        Me.EditGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemTxtbox
        '
        Me.ItemTxtbox.Enabled = False
        Me.ItemTxtbox.Location = New System.Drawing.Point(32, 69)
        Me.ItemTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.ItemTxtbox.Name = "ItemTxtbox"
        Me.ItemTxtbox.Size = New System.Drawing.Size(88, 22)
        Me.ItemTxtbox.TabIndex = 1
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(236, 251)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(116, 30)
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
        Me.EditGroupBox.Location = New System.Drawing.Point(1083, 74)
        Me.EditGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EditGroupBox.Name = "EditGroupBox"
        Me.EditGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.EditGroupBox.Size = New System.Drawing.Size(688, 304)
        Me.EditGroupBox.TabIndex = 3
        Me.EditGroupBox.TabStop = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(452, 251)
        Me.UpdateBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(116, 30)
        Me.UpdateBtn.TabIndex = 18
        Me.UpdateBtn.Text = "Update Item"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'CategoryBox
        '
        Me.CategoryBox.FormattingEnabled = True
        Me.CategoryBox.Items.AddRange(New Object() {"Biryani", "Bunnies", "Chutney", "Curry", "Drinks", "Extras", "Regulars", "Roti Rolls", "Seafood", "Toasted Sandwich", "Vegetables", ""})
        Me.CategoryBox.Location = New System.Drawing.Point(32, 137)
        Me.CategoryBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CategoryBox.Name = "CategoryBox"
        Me.CategoryBox.Size = New System.Drawing.Size(187, 24)
        Me.CategoryBox.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 175)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Price - Large"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(465, 117)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Price - Medium"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Price - Small"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(421, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Item Cost"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = " Item ID"
        '
        'LargeTxtbox
        '
        Me.LargeTxtbox.Location = New System.Drawing.Point(32, 194)
        Me.LargeTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.LargeTxtbox.Name = "LargeTxtbox"
        Me.LargeTxtbox.Size = New System.Drawing.Size(203, 22)
        Me.LargeTxtbox.TabIndex = 8
        '
        'MedTxtbox
        '
        Me.MedTxtbox.Location = New System.Drawing.Point(469, 137)
        Me.MedTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.MedTxtbox.Name = "MedTxtbox"
        Me.MedTxtbox.Size = New System.Drawing.Size(203, 22)
        Me.MedTxtbox.TabIndex = 7
        '
        'SmallTxtbox
        '
        Me.SmallTxtbox.Location = New System.Drawing.Point(236, 137)
        Me.SmallTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.SmallTxtbox.Name = "SmallTxtbox"
        Me.SmallTxtbox.Size = New System.Drawing.Size(203, 22)
        Me.SmallTxtbox.TabIndex = 6
        '
        'CostTxtbox
        '
        Me.CostTxtbox.Location = New System.Drawing.Point(425, 69)
        Me.CostTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.CostTxtbox.Name = "CostTxtbox"
        Me.CostTxtbox.Size = New System.Drawing.Size(203, 22)
        Me.CostTxtbox.TabIndex = 4
        '
        'NameTxtbox
        '
        Me.NameTxtbox.Location = New System.Drawing.Point(143, 69)
        Me.NameTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTxtbox.Name = "NameTxtbox"
        Me.NameTxtbox.Size = New System.Drawing.Size(253, 22)
        Me.NameTxtbox.TabIndex = 3
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(465, 599)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(119, 32)
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
        Me.DataGridView1.Location = New System.Drawing.Point(40, 44)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1007, 489)
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
        'MenuItemTableAdapter
        '
        Me.MenuItemTableAdapter.ClearBeforeFill = True
        '
        'MenuItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1827, 708)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
