<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim AmountDueLabel As System.Windows.Forms.Label
        Me.DataSet1 = New Geetha_Homemade_Curries_POS.DataSet()
        Me.CustomerTableAdapter1 = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.CustomerTableAdapter()
        Me.CustomerOrderTableAdapter1 = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.CustomerOrderTableAdapter()
        Me.CustomerTableAdapter2 = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.CustomerTableAdapter()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Geetha_Homemade_Curries_POS.DataSetTableAdapters.TableAdapterManager()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddCustBtn = New System.Windows.Forms.Button()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        CustomerIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        AmountDueLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'CustomerOrderTableAdapter1
        '
        Me.CustomerOrderTableAdapter1.ClearBeforeFill = True
        '
        'CustomerTableAdapter2
        '
        Me.CustomerTableAdapter2.ClearBeforeFill = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.DataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerOrderTableAdapter = Me.CustomerOrderTableAdapter1
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter1
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.IngredientTableAdapter = Nothing
        Me.TableAdapterManager.MemberTableAdapter = Nothing
        Me.TableAdapterManager.MenuItemIngredientTableAdapter = Nothing
        Me.TableAdapterManager.MenuItemTableAdapter = Nothing
        Me.TableAdapterManager.TestCasesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Geetha_Homemade_Curries_POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserStory_MemberTableAdapter = Nothing
        Me.TableAdapterManager.UserStoryTableAdapter = Nothing
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(1, 458)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.RowTemplate.Height = 28
        Me.CustomerDataGridView.Size = New System.Drawing.Size(543, 60)
        Me.CustomerDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PhoneNumber"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "AmountDue"
        Me.DataGridViewTextBoxColumn5.HeaderText = "AmountDue"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'AddCustBtn
        '
        Me.AddCustBtn.Location = New System.Drawing.Point(506, 57)
        Me.AddCustBtn.Name = "AddCustBtn"
        Me.AddCustBtn.Size = New System.Drawing.Size(134, 46)
        Me.AddCustBtn.TabIndex = 11
        Me.AddCustBtn.Text = "Add Customer"
        Me.AddCustBtn.UseVisualStyleBackColor = True
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(37, 57)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(103, 20)
        CustomerIDLabel.TabIndex = 12
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(216, 57)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(209, 26)
        Me.CustomerIDTextBox.TabIndex = 13
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(37, 107)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(90, 20)
        FirstNameLabel.TabIndex = 14
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(216, 107)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(209, 26)
        Me.FirstNameTextBox.TabIndex = 15
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(37, 156)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(78, 20)
        SurnameLabel.TabIndex = 16
        SurnameLabel.Text = "Surname:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(216, 156)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(209, 26)
        Me.SurnameTextBox.TabIndex = 17
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Location = New System.Drawing.Point(37, 206)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(119, 20)
        PhoneNumberLabel.TabIndex = 18
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(216, 206)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(209, 26)
        Me.PhoneNumberTextBox.TabIndex = 19
        '
        'AmountDueLabel
        '
        AmountDueLabel.AutoSize = True
        AmountDueLabel.Location = New System.Drawing.Point(37, 258)
        AmountDueLabel.Name = "AmountDueLabel"
        AmountDueLabel.Size = New System.Drawing.Size(103, 20)
        AmountDueLabel.TabIndex = 20
        AmountDueLabel.Text = "Amount Due:"
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AmountDue", True))
        Me.AmountDueTextBox.Location = New System.Drawing.Point(216, 258)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.Size = New System.Drawing.Size(209, 26)
        Me.AmountDueTextBox.TabIndex = 21
        '
        'Customers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 519)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberTextBox)
        Me.Controls.Add(AmountDueLabel)
        Me.Controls.Add(Me.AmountDueTextBox)
        Me.Controls.Add(Me.AddCustBtn)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Name = "Customers"
        Me.Text = "Customers"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents CustomerTableAdapter1 As DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerOrderTableAdapter1 As DataSetTableAdapters.CustomerOrderTableAdapter
    Friend WithEvents CustomerTableAdapter2 As DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents AddCustBtn As Button
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents AmountDueTextBox As TextBox
End Class
