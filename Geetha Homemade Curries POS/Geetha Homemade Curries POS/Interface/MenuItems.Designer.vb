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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet = New Geetha_Homemade_Curries_POS.DataSet()
        Me.MenuItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuItemTableAdapter = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.MenuItemTableAdapter()
        Me.MenuItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuItemCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MenuItemIDDataGridViewTextBoxColumn, Me.MenuItemNameDataGridViewTextBoxColumn, Me.MenuItemCostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MenuItemBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 238)
        Me.DataGridView1.TabIndex = 0
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuItemBindingSource
        '
        Me.MenuItemBindingSource.DataMember = "MenuItem"
        Me.MenuItemBindingSource.DataSource = Me.DataSet
        '
        'MenuItemTableAdapter
        '
        Me.MenuItemTableAdapter.ClearBeforeFill = True
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(611, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 425)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MenuItems"
        Me.Text = "MenuItems"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet As DataSet
    Friend WithEvents MenuItemBindingSource As BindingSource
    Friend WithEvents MenuItemTableAdapter As DataSetTableAdapters.MenuItemTableAdapter
    Friend WithEvents MenuItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuItemCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
