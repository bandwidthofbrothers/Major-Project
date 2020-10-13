<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUserStoryForm
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataSet = New User_Story_Application.DataSet()
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.TableAdapterManager = New User_Story_Application.DataSetTableAdapters.TableAdapterManager()
        Me.TestCasesTableAdapter = New User_Story_Application.DataSetTableAdapters.TestCasesTableAdapter()
        Me.UserStoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.TestCasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBoxTestCases = New System.Windows.Forms.ListBox()
        Me.UserStory_MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStory_MemberTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStory_MemberTableAdapter()
        Me.UserStory_MemberDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxProgrammerDetails = New System.Windows.Forms.GroupBox()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataSet1 = New User_Story_Application.DataSet()
        Me.MemberTableAdapter = New User_Story_Application.DataSetTableAdapters.MemberTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStory_MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStory_MemberDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProgrammerDetails.SuspendLayout()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStoryBindingSource
        '
        Me.UserStoryBindingSource.DataMember = "UserStory"
        Me.UserStoryBindingSource.DataSource = Me.DataSet
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MemberTableAdapter = Nothing
        Me.TableAdapterManager.TestCasesTableAdapter = Me.TestCasesTableAdapter
        Me.TableAdapterManager.UpdateOrder = User_Story_Application.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserStory_MemberTableAdapter = Nothing
        Me.TableAdapterManager.UserStoryTableAdapter = Me.UserStoryTableAdapter
        '
        'TestCasesTableAdapter
        '
        Me.TestCasesTableAdapter.ClearBeforeFill = True
        '
        'UserStoryDataGridView
        '
        Me.UserStoryDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UserStoryDataGridView.AllowUserToAddRows = False
        Me.UserStoryDataGridView.AllowUserToDeleteRows = False
        Me.UserStoryDataGridView.AutoGenerateColumns = False
        Me.UserStoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.UserStoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.UserStoryDataGridView.DataSource = Me.UserStoryBindingSource
        Me.UserStoryDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.UserStoryDataGridView.Name = "UserStoryDataGridView"
        Me.UserStoryDataGridView.ReadOnly = True
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UserStoryDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.UserStoryDataGridView.RowTemplate.Height = 24
        Me.UserStoryDataGridView.Size = New System.Drawing.Size(1245, 264)
        Me.UserStoryDataGridView.TabIndex = 1
        '
        'TestCasesBindingSource
        '
        Me.TestCasesBindingSource.DataMember = "FK_TestCases_UserStory"
        Me.TestCasesBindingSource.DataSource = Me.UserStoryBindingSource
        '
        'ListBoxTestCases
        '
        Me.ListBoxTestCases.DataSource = Me.TestCasesBindingSource
        Me.ListBoxTestCases.DisplayMember = "TestCaseDetails"
        Me.ListBoxTestCases.FormattingEnabled = True
        Me.ListBoxTestCases.HorizontalScrollbar = True
        Me.ListBoxTestCases.ItemHeight = 16
        Me.ListBoxTestCases.Location = New System.Drawing.Point(0, 303)
        Me.ListBoxTestCases.Name = "ListBoxTestCases"
        Me.ListBoxTestCases.Size = New System.Drawing.Size(854, 324)
        Me.ListBoxTestCases.TabIndex = 2
        Me.ListBoxTestCases.ValueMember = "UserStoryNo"
        '
        'UserStory_MemberBindingSource
        '
        Me.UserStory_MemberBindingSource.DataMember = "FK__UserStory__UserS__108157BA"
        Me.UserStory_MemberBindingSource.DataSource = Me.UserStoryBindingSource
        '
        'UserStory_MemberTableAdapter
        '
        Me.UserStory_MemberTableAdapter.ClearBeforeFill = True
        '
        'UserStory_MemberDataGridView
        '
        Me.UserStory_MemberDataGridView.AllowUserToAddRows = False
        Me.UserStory_MemberDataGridView.AllowUserToDeleteRows = False
        Me.UserStory_MemberDataGridView.AutoGenerateColumns = False
        Me.UserStory_MemberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStory_MemberDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.UserStory_MemberDataGridView.DataSource = Me.UserStory_MemberBindingSource
        Me.UserStory_MemberDataGridView.Location = New System.Drawing.Point(885, 303)
        Me.UserStory_MemberDataGridView.Name = "UserStory_MemberDataGridView"
        Me.UserStory_MemberDataGridView.RowTemplate.Height = 24
        Me.UserStory_MemberDataGridView.Size = New System.Drawing.Size(360, 123)
        Me.UserStory_MemberDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GroupMemberNo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "GroupMemberNo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Responsibility"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Responsibility"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'GroupBoxProgrammerDetails
        '
        Me.GroupBoxProgrammerDetails.BackgroundImage = Global.User_Story_Application.My.Resources.Resources.Background
        Me.GroupBoxProgrammerDetails.Controls.Add(Me.TextBoxSurname)
        Me.GroupBoxProgrammerDetails.Controls.Add(Me.TextBoxFirstName)
        Me.GroupBoxProgrammerDetails.Controls.Add(Me.Label2)
        Me.GroupBoxProgrammerDetails.Controls.Add(Me.Label1)
        Me.GroupBoxProgrammerDetails.ForeColor = System.Drawing.Color.White
        Me.GroupBoxProgrammerDetails.Location = New System.Drawing.Point(885, 443)
        Me.GroupBoxProgrammerDetails.Name = "GroupBoxProgrammerDetails"
        Me.GroupBoxProgrammerDetails.Size = New System.Drawing.Size(360, 149)
        Me.GroupBoxProgrammerDetails.TabIndex = 3
        Me.GroupBoxProgrammerDetails.TabStop = False
        Me.GroupBoxProgrammerDetails.Text = "Programmer Details"
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Surname", True))
        Me.TextBoxSurname.Location = New System.Drawing.Point(133, 92)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(210, 22)
        Me.TextBoxSurname.TabIndex = 3
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.DataSet
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "FirstName", True))
        Me.TextBoxFirstName.Location = New System.Drawing.Point(133, 38)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(210, 22)
        Me.TextBoxFirstName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(24, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserStoryNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserStoryNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserStoryTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserStoryTitle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserRole"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserRole"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserStoryDescription"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserStoryDescription"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserStoryStartDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserStoryStartDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UserStoryEndDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UserStoryEndDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UserStoryStatus"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UserStoryStatus"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UserStoryPriority"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UserStoryPriority"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'ViewUserStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.User_Story_Application.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1265, 636)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxProgrammerDetails)
        Me.Controls.Add(Me.UserStory_MemberDataGridView)
        Me.Controls.Add(Me.ListBoxTestCases)
        Me.Controls.Add(Me.UserStoryDataGridView)
        Me.Name = "ViewUserStoryForm"
        Me.Text = "View User Story"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStory_MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStory_MemberDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProgrammerDetails.ResumeLayout(False)
        Me.GroupBoxProgrammerDetails.PerformLayout()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataSet As DataSet
    Friend WithEvents UserStoryBindingSource As BindingSource
    Friend WithEvents UserStoryTableAdapter As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TestCasesTableAdapter As DataSetTableAdapters.TestCasesTableAdapter
    Friend WithEvents UserStoryDataGridView As DataGridView
    Friend WithEvents TestCasesBindingSource As BindingSource
    Friend WithEvents ListBoxTestCases As ListBox
    Friend WithEvents UserStory_MemberBindingSource As BindingSource
    Friend WithEvents UserStory_MemberTableAdapter As DataSetTableAdapters.UserStory_MemberTableAdapter
    Friend WithEvents UserStory_MemberDataGridView As DataGridView
    Friend WithEvents GroupBoxProgrammerDetails As GroupBox
    Friend WithEvents TextBoxSurname As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents MemberTableAdapter As DataSetTableAdapters.MemberTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
