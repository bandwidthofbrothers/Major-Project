<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesItems
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.MenuItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSet = New Geetha_Homemade_Curries_POS.group22DataSet()
        Me.MenuItemTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.MenuItemTableAdapter()
        Me.MenuItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(132, 512)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(537, 47)
        Me.ButtonAdd.TabIndex = 1
        Me.ButtonAdd.Text = "Add to Order"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AutoGenerateColumns = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuItemIDDataGridViewTextBoxColumn, Me.MenuItemNameDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.MenuItemPriceDataGridViewTextBoxColumn, Me.Quantity})
        Me.DataGridView.DataSource = Me.MenuItemBindingSource
        Me.DataGridView.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(785, 475)
        Me.DataGridView.TabIndex = 2
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
        'MenuItemIDDataGridViewTextBoxColumn
        '
        Me.MenuItemIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemIDDataGridViewTextBoxColumn.DataPropertyName = "MenuItemID"
        Me.MenuItemIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.MenuItemIDDataGridViewTextBoxColumn.Name = "MenuItemIDDataGridViewTextBoxColumn"
        Me.MenuItemIDDataGridViewTextBoxColumn.Visible = False
        '
        'MenuItemNameDataGridViewTextBoxColumn
        '
        Me.MenuItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemNameDataGridViewTextBoxColumn.DataPropertyName = "MenuItemName"
        Me.MenuItemNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.MenuItemNameDataGridViewTextBoxColumn.Name = "MenuItemNameDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Visible = False
        '
        'MenuItemPriceDataGridViewTextBoxColumn
        '
        Me.MenuItemPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MenuItemPriceDataGridViewTextBoxColumn.DataPropertyName = "MenuItemPrice"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.MenuItemPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.MenuItemPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.MenuItemPriceDataGridViewTextBoxColumn.Name = "MenuItemPriceDataGridViewTextBoxColumn"
        '
        'Quantity
        '
        Me.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.NullValue = "1"
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle2
        Me.Quantity.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.Quantity.DisplayStyleForCurrentCellOnly = True
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Quantity.Name = "Quantity"
        '
        'FormSalesItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.ButtonAdd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSalesItems"
        Me.Text = "FormSalesItems"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents MenuItemBindingSource As BindingSource
    Friend WithEvents MenuItemTableAdapter As group22DataSetTableAdapters.MenuItemTableAdapter
    Friend WithEvents MenuItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewComboBoxColumn
End Class
