<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewCustomers
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim AmountDueLabel As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Group22DataSet = New Geetha_Homemade_Curries_POS.group22DataSet()
        Me.CustomerOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerOrderTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.CustomerOrderTableAdapter()
        Me.TableAdapterManager = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.TableAdapterManager()
        Me.CustomerTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.CustomerTableAdapter()
        Me.CustomerOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.AddCustBtn = New System.Windows.Forms.Button()
        Me.DltCustBtn = New System.Windows.Forms.Button()
        Me.UpdateCustBtn = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.buttonRefresh = New System.Windows.Forms.Button()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBoxAmountCap = New System.Windows.Forms.TextBox()
        Me.TextBoxPhysicalAddress = New System.Windows.Forms.TextBox()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountCap = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        FirstNameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        AmountDueLabel = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        FirstNameLabel.ForeColor = System.Drawing.Color.White
        FirstNameLabel.Location = New System.Drawing.Point(804, 231)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel.TabIndex = 48
        FirstNameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.BackColor = System.Drawing.Color.Transparent
        SurnameLabel.ForeColor = System.Drawing.Color.White
        SurnameLabel.Location = New System.Drawing.Point(804, 282)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(69, 17)
        SurnameLabel.TabIndex = 50
        SurnameLabel.Text = "Surname:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.BackColor = System.Drawing.Color.Transparent
        PhoneNumberLabel.ForeColor = System.Drawing.Color.White
        PhoneNumberLabel.Location = New System.Drawing.Point(804, 331)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(107, 17)
        PhoneNumberLabel.TabIndex = 52
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'AmountDueLabel
        '
        AmountDueLabel.AutoSize = True
        AmountDueLabel.BackColor = System.Drawing.Color.Transparent
        AmountDueLabel.ForeColor = System.Drawing.Color.White
        AmountDueLabel.Location = New System.Drawing.Point(804, 388)
        AmountDueLabel.Name = "AmountDueLabel"
        AmountDueLabel.Size = New System.Drawing.Size(90, 17)
        AmountDueLabel.TabIndex = 54
        AmountDueLabel.Text = "Amount Due:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.ForeColor = System.Drawing.Color.White
        CustomerIDLabel.Image = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        CustomerIDLabel.Location = New System.Drawing.Point(804, 176)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 59
        CustomerIDLabel.Text = "Customer ID:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Image = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Label1.Location = New System.Drawing.Point(17, 103)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(57, 17)
        Label1.TabIndex = 61
        Label1.Text = "Search:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.ForeColor = System.Drawing.Color.White
        Label2.Location = New System.Drawing.Point(804, 443)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(89, 17)
        Label2.TabIndex = 63
        Label2.Text = "Amount Cap:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.ForeColor = System.Drawing.Color.White
        Label3.Location = New System.Drawing.Point(804, 503)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(120, 17)
        Label3.TabIndex = 65
        Label3.Text = "Physical Address:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Gabriola", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(21, -2)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(379, 87)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Customer Information"
        '
        'Group22DataSet
        '
        Me.Group22DataSet.DataSetName = "group22DataSet"
        Me.Group22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerOrderBindingSource
        '
        Me.CustomerOrderBindingSource.DataMember = "CustomerOrder"
        Me.CustomerOrderBindingSource.DataSource = Me.Group22DataSet
        '
        'CustomerOrderTableAdapter
        '
        Me.CustomerOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerOrderTableAdapter = Me.CustomerOrderTableAdapter
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.IngredientTableAdapter = Nothing
        Me.TableAdapterManager.MenuItemIngredientTableAdapter = Nothing
        Me.TableAdapterManager.MenuItemTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerOrderDataGridView
        '
        Me.CustomerOrderDataGridView.AllowUserToAddRows = False
        Me.CustomerOrderDataGridView.AllowUserToDeleteRows = False
        Me.CustomerOrderDataGridView.AutoGenerateColumns = False
        Me.CustomerOrderDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomerOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.AmountDueDataGridViewTextBoxColumn, Me.AmountCap, Me.PhysicalAddress})
        Me.CustomerOrderDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerOrderDataGridView.Location = New System.Drawing.Point(20, 135)
        Me.CustomerOrderDataGridView.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerOrderDataGridView.Name = "CustomerOrderDataGridView"
        Me.CustomerOrderDataGridView.ReadOnly = True
        Me.CustomerOrderDataGridView.RowTemplate.Height = 28
        Me.CustomerOrderDataGridView.Size = New System.Drawing.Size(724, 460)
        Me.CustomerOrderDataGridView.TabIndex = 46
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Group22DataSet
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(949, 229)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(297, 22)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(949, 279)
        Me.SurnameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(297, 22)
        Me.SurnameTextBox.TabIndex = 2
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(949, 329)
        Me.PhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(297, 22)
        Me.PhoneNumberTextBox.TabIndex = 3
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AmountDue", True))
        Me.AmountDueTextBox.Location = New System.Drawing.Point(949, 387)
        Me.AmountDueTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.Size = New System.Drawing.Size(297, 22)
        Me.AmountDueTextBox.TabIndex = 4
        '
        'AddCustBtn
        '
        Me.AddCustBtn.Location = New System.Drawing.Point(357, 625)
        Me.AddCustBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddCustBtn.Name = "AddCustBtn"
        Me.AddCustBtn.Size = New System.Drawing.Size(204, 50)
        Me.AddCustBtn.TabIndex = 5
        Me.AddCustBtn.Text = "Add"
        Me.AddCustBtn.UseVisualStyleBackColor = True
        '
        'DltCustBtn
        '
        Me.DltCustBtn.Location = New System.Drawing.Point(821, 625)
        Me.DltCustBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DltCustBtn.Name = "DltCustBtn"
        Me.DltCustBtn.Size = New System.Drawing.Size(204, 50)
        Me.DltCustBtn.TabIndex = 56
        Me.DltCustBtn.Text = "Delete"
        Me.DltCustBtn.UseVisualStyleBackColor = True
        '
        'UpdateCustBtn
        '
        Me.UpdateCustBtn.Location = New System.Drawing.Point(591, 625)
        Me.UpdateCustBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UpdateCustBtn.Name = "UpdateCustBtn"
        Me.UpdateCustBtn.Size = New System.Drawing.Size(204, 50)
        Me.UpdateCustBtn.TabIndex = 57
        Me.UpdateCustBtn.Text = "Update"
        Me.UpdateCustBtn.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.ForeColor = System.Drawing.Color.Gray
        Me.SearchTextBox.Location = New System.Drawing.Point(80, 98)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(296, 22)
        Me.SearchTextBox.TabIndex = 58
        '
        'buttonRefresh
        '
        Me.buttonRefresh.Location = New System.Drawing.Point(393, 94)
        Me.buttonRefresh.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.buttonRefresh.Name = "buttonRefresh"
        Me.buttonRefresh.Size = New System.Drawing.Size(204, 34)
        Me.buttonRefresh.TabIndex = 59
        Me.buttonRefresh.Text = "Refresh"
        Me.buttonRefresh.UseVisualStyleBackColor = True
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(948, 176)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(297, 22)
        Me.CustomerIDTextBox.TabIndex = 60
        '
        'TextBoxAmountCap
        '
        Me.TextBoxAmountCap.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AmountCap", True))
        Me.TextBoxAmountCap.Location = New System.Drawing.Point(949, 442)
        Me.TextBoxAmountCap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxAmountCap.Name = "TextBoxAmountCap"
        Me.TextBoxAmountCap.Size = New System.Drawing.Size(297, 22)
        Me.TextBoxAmountCap.TabIndex = 62
        '
        'TextBoxPhysicalAddress
        '
        Me.TextBoxPhysicalAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PhysicalAddress", True))
        Me.TextBoxPhysicalAddress.Location = New System.Drawing.Point(949, 502)
        Me.TextBoxPhysicalAddress.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxPhysicalAddress.Name = "TextBoxPhysicalAddress"
        Me.TextBoxPhysicalAddress.Size = New System.Drawing.Size(297, 22)
        Me.TextBoxPhysicalAddress.TabIndex = 64
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer ID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDueDataGridViewTextBoxColumn
        '
        Me.AmountDueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AmountDueDataGridViewTextBoxColumn.DataPropertyName = "AmountDue"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.AmountDueDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.AmountDueDataGridViewTextBoxColumn.HeaderText = "Amount Due"
        Me.AmountDueDataGridViewTextBoxColumn.Name = "AmountDueDataGridViewTextBoxColumn"
        Me.AmountDueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountCap
        '
        Me.AmountCap.DataPropertyName = "AmountCap"
        Me.AmountCap.HeaderText = "Amount Cap"
        Me.AmountCap.Name = "AmountCap"
        Me.AmountCap.ReadOnly = True
        '
        'PhysicalAddress
        '
        Me.PhysicalAddress.DataPropertyName = "PhysicalAddress"
        Me.PhysicalAddress.HeaderText = "Address"
        Me.PhysicalAddress.Name = "PhysicalAddress"
        Me.PhysicalAddress.ReadOnly = True
        '
        'ViewCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1300, 710)
        Me.ControlBox = False
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.TextBoxPhysicalAddress)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBoxAmountCap)
        Me.Controls.Add(Label1)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(Me.buttonRefresh)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.UpdateCustBtn)
        Me.Controls.Add(Me.DltCustBtn)
        Me.Controls.Add(Me.AddCustBtn)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(AmountDueLabel)
        Me.Controls.Add(Me.AmountDueTextBox)
        Me.Controls.Add(Me.CustomerOrderDataGridView)
        Me.Controls.Add(Me.Label10)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ViewCustomers"
        Me.Text = "ViewCustomers"
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents CustomerOrderBindingSource As BindingSource
    Friend WithEvents CustomerOrderTableAdapter As group22DataSetTableAdapters.CustomerOrderTableAdapter
    Friend WithEvents TableAdapterManager As group22DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerOrderDataGridView As DataGridView
    Friend WithEvents CustomerTableAdapter As group22DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents AmountDueTextBox As TextBox
    Friend WithEvents AddCustBtn As Button
    Friend WithEvents DltCustBtn As Button
    Friend WithEvents UpdateCustBtn As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents buttonRefresh As Button
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents TextBoxAmountCap As TextBox
    Friend WithEvents TextBoxPhysicalAddress As TextBox
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountCap As DataGridViewTextBoxColumn
    Friend WithEvents PhysicalAddress As DataGridViewTextBoxColumn
End Class
