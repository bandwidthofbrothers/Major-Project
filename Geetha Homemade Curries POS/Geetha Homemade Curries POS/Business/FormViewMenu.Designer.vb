﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewMenu
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TextBoxMenuItemID = New System.Windows.Forms.TextBox()
        Me.MenuItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSet = New Geetha_Homemade_Curries_POS.group22DataSet()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.ComboBoxCategory = New System.Windows.Forms.ComboBox()
        Me.MenuItemTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.MenuItemTableAdapter()
        Me.MenuItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxMenuItemID
        '
        Me.TextBoxMenuItemID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuItemBindingSource, "MenuItemID", True))
        Me.TextBoxMenuItemID.Enabled = False
        Me.TextBoxMenuItemID.Location = New System.Drawing.Point(946, 141)
        Me.TextBoxMenuItemID.Name = "TextBoxMenuItemID"
        Me.TextBoxMenuItemID.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxMenuItemID.TabIndex = 26
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(769, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Menu Item ID"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuItemBindingSource, "MenuItemPrice", True))
        Me.TextBoxPrice.Location = New System.Drawing.Point(946, 346)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxPrice.TabIndex = 24
        '
        'TextBoxName
        '
        Me.TextBoxName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuItemBindingSource, "MenuItemName", True))
        Me.TextBoxName.Location = New System.Drawing.Point(946, 198)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxName.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(769, 349)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(769, 273)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(769, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Name"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(802, 615)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(197, 53)
        Me.ButtonDelete.TabIndex = 18
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(584, 615)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(197, 53)
        Me.ButtonUpdate.TabIndex = 17
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(367, 615)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(197, 53)
        Me.ButtonAdd.TabIndex = 16
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gabriola", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, -5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 87)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Menu:"
        '
        'MenuItemDataGridView
        '
        Me.MenuItemDataGridView.AllowUserToAddRows = False
        Me.MenuItemDataGridView.AllowUserToDeleteRows = False
        Me.MenuItemDataGridView.AutoGenerateColumns = False
        Me.MenuItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuItemIDDataGridViewTextBoxColumn, Me.MenuItemNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.MenuItemPriceDataGridViewTextBoxColumn})
        Me.MenuItemDataGridView.DataSource = Me.MenuItemBindingSource
        Me.MenuItemDataGridView.Location = New System.Drawing.Point(12, 85)
        Me.MenuItemDataGridView.Name = "MenuItemDataGridView"
        Me.MenuItemDataGridView.ReadOnly = True
        Me.MenuItemDataGridView.RowTemplate.Height = 24
        Me.MenuItemDataGridView.Size = New System.Drawing.Size(707, 499)
        Me.MenuItemDataGridView.TabIndex = 14
        '
        'ComboBoxCategory
        '
        Me.ComboBoxCategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MenuItemBindingSource, "Category", True))
        Me.ComboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategory.FormattingEnabled = True
        Me.ComboBoxCategory.Items.AddRange(New Object() {"Briyani" & Global.Microsoft.VisualBasic.ChrW(9), "Bunnies", "Chutney", "Veg Curries", "Non-Veg Curries", "Veg Dishes", "Non-Veg Dishes", "Hot Drinks", "Cold Drinks", "Extras/Sides", "Pasta", "Regulars", "Roti Rolls", "Specials", "Toasted Sandwiches"})
        Me.ComboBoxCategory.Location = New System.Drawing.Point(946, 273)
        Me.ComboBoxCategory.Name = "ComboBoxCategory"
        Me.ComboBoxCategory.Size = New System.Drawing.Size(306, 24)
        Me.ComboBoxCategory.TabIndex = 27
        '
        'MenuItemTableAdapter
        '
        Me.MenuItemTableAdapter.ClearBeforeFill = True
        '
        'MenuItemIDDataGridViewTextBoxColumn
        '
        Me.MenuItemIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemIDDataGridViewTextBoxColumn.DataPropertyName = "MenuItemID"
        Me.MenuItemIDDataGridViewTextBoxColumn.HeaderText = "MenuItemID"
        Me.MenuItemIDDataGridViewTextBoxColumn.Name = "MenuItemIDDataGridViewTextBoxColumn"
        Me.MenuItemIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuItemNameDataGridViewTextBoxColumn
        '
        Me.MenuItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemNameDataGridViewTextBoxColumn.DataPropertyName = "MenuItemName"
        Me.MenuItemNameDataGridViewTextBoxColumn.HeaderText = "MenuItemName"
        Me.MenuItemNameDataGridViewTextBoxColumn.Name = "MenuItemNameDataGridViewTextBoxColumn"
        Me.MenuItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MenuItemPriceDataGridViewTextBoxColumn
        '
        Me.MenuItemPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemPriceDataGridViewTextBoxColumn.DataPropertyName = "MenuItemPrice"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.MenuItemPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MenuItemPriceDataGridViewTextBoxColumn.HeaderText = "MenuItemPrice"
        Me.MenuItemPriceDataGridViewTextBoxColumn.Name = "MenuItemPriceDataGridViewTextBoxColumn"
        Me.MenuItemPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormViewMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1319, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxCategory)
        Me.Controls.Add(Me.TextBoxMenuItemID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuItemDataGridView)
        Me.Name = "FormViewMenu"
        Me.Text = "FormViewMenu"
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxMenuItemID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuItemDataGridView As DataGridView
    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents MenuItemBindingSource As BindingSource
    Friend WithEvents MenuItemTableAdapter As group22DataSetTableAdapters.MenuItemTableAdapter
    Friend WithEvents ComboBoxCategory As ComboBox
    Friend WithEvents MenuItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
