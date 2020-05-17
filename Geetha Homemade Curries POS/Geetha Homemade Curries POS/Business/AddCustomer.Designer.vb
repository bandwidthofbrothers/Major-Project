<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Me.Group22DataSet = New Geetha_Homemade_Curries_POS.group22DataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.TableAdapterManager()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.AddCustBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        AmountDueLabel = New System.Windows.Forms.Label()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.BackColor = System.Drawing.Color.Transparent
        CustomerIDLabel.ForeColor = System.Drawing.Color.White
        CustomerIDLabel.Location = New System.Drawing.Point(67, 53)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        FirstNameLabel.ForeColor = System.Drawing.Color.White
        FirstNameLabel.Location = New System.Drawing.Point(67, 86)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.BackColor = System.Drawing.Color.Transparent
        SurnameLabel.ForeColor = System.Drawing.Color.White
        SurnameLabel.Location = New System.Drawing.Point(67, 120)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(69, 17)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Surname:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.BackColor = System.Drawing.Color.Transparent
        PhoneNumberLabel.ForeColor = System.Drawing.Color.White
        PhoneNumberLabel.Location = New System.Drawing.Point(67, 153)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(107, 17)
        PhoneNumberLabel.TabIndex = 7
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'AmountDueLabel
        '
        AmountDueLabel.AutoSize = True
        AmountDueLabel.BackColor = System.Drawing.Color.Transparent
        AmountDueLabel.ForeColor = System.Drawing.Color.White
        AmountDueLabel.Location = New System.Drawing.Point(67, 186)
        AmountDueLabel.Name = "AmountDueLabel"
        AmountDueLabel.Size = New System.Drawing.Size(90, 17)
        AmountDueLabel.TabIndex = 9
        AmountDueLabel.Text = "Amount Due:"
        '
        'Group22DataSet
        '
        Me.Group22DataSet.DataSetName = "group22DataSet"
        Me.Group22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.Group22DataSet
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerOrderTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.IngredientTableAdapter = Nothing
        Me.TableAdapterManager.MenuItemIngredientTableAdapter = Nothing
        Me.TableAdapterManager.MenuItemTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(252, 53)
        Me.CustomerIDTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(89, 22)
        Me.CustomerIDTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(252, 86)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(89, 22)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(252, 120)
        Me.SurnameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(89, 22)
        Me.SurnameTextBox.TabIndex = 6
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "PhoneNumber", True))
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(252, 153)
        Me.PhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(89, 22)
        Me.PhoneNumberTextBox.TabIndex = 8
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "AmountDue", True))
        Me.AmountDueTextBox.Location = New System.Drawing.Point(252, 186)
        Me.AmountDueTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.Size = New System.Drawing.Size(89, 22)
        Me.AmountDueTextBox.TabIndex = 10
        '
        'AddCustBtn
        '
        Me.AddCustBtn.Location = New System.Drawing.Point(252, 249)
        Me.AddCustBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AddCustBtn.Name = "AddCustBtn"
        Me.AddCustBtn.Size = New System.Drawing.Size(89, 30)
        Me.AddCustBtn.TabIndex = 11
        Me.AddCustBtn.Text = "Add"
        Me.AddCustBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(70, 249)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(89, 30)
        Me.CloseBtn.TabIndex = 12
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(424, 342)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.AddCustBtn)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AddCustomer"
        Me.Text = "AddCustomer"
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents CustomerBindingSource As BindingSource
    Friend WithEvents CustomerTableAdapter As group22DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As group22DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents AmountDueTextBox As TextBox
    Friend WithEvents AddCustBtn As Button
    Friend WithEvents CloseBtn As Button
End Class
