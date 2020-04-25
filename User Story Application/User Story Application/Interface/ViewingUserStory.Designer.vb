<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewingUserStory
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.UserStoryNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSet = New User_Story_Application.group22DataSet()
        Me.UserStoryTableAdapter = New User_Story_Application.group22DataSetTableAdapters.UserStoryTableAdapter()
        Me.FKTestCasesUserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCasesTableAdapter = New User_Story_Application.group22DataSetTableAdapters.TestCasesTableAdapter()
        Me.UserStoryMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStory_MemberTableAdapter = New User_Story_Application.group22DataSetTableAdapters.UserStory_MemberTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupMemberNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryMemberBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataSet1 = New User_Story_Application.DataSet()
        Me.UserStory_MemberTableAdapter1 = New User_Story_Application.DataSetTableAdapters.UserStory_MemberTableAdapter()
        Me.MemberTableAdapter1 = New User_Story_Application.DataSetTableAdapters.MemberTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TestCasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSet1 = New User_Story_Application.group22DataSet()
        Me.MemberTableAdapter = New User_Story_Application.group22DataSetTableAdapters.MemberTableAdapter()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryMemberBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn, Me.UserStoryTitleDataGridViewTextBoxColumn, Me.UserRoleDataGridViewTextBoxColumn, Me.UserStoryDescriptionDataGridViewTextBoxColumn, Me.UserStoryStartDateDataGridViewTextBoxColumn, Me.UserStoryEndDateDataGridViewTextBoxColumn, Me.UserStoryStatusDataGridViewTextBoxColumn, Me.UserStoryPriorityDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.UserStoryBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(849, 247)
        Me.DataGridView2.TabIndex = 2
        '
        'UserStoryNoDataGridViewTextBoxColumn
        '
        Me.UserStoryNoDataGridViewTextBoxColumn.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.HeaderText = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.Name = "UserStoryNoDataGridViewTextBoxColumn"
        '
        'UserStoryTitleDataGridViewTextBoxColumn
        '
        Me.UserStoryTitleDataGridViewTextBoxColumn.DataPropertyName = "UserStoryTitle"
        Me.UserStoryTitleDataGridViewTextBoxColumn.HeaderText = "UserStoryTitle"
        Me.UserStoryTitleDataGridViewTextBoxColumn.Name = "UserStoryTitleDataGridViewTextBoxColumn"
        '
        'UserRoleDataGridViewTextBoxColumn
        '
        Me.UserRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole"
        Me.UserRoleDataGridViewTextBoxColumn.HeaderText = "UserRole"
        Me.UserRoleDataGridViewTextBoxColumn.Name = "UserRoleDataGridViewTextBoxColumn"
        '
        'UserStoryDescriptionDataGridViewTextBoxColumn
        '
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "UserStoryDescription"
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.HeaderText = "UserStoryDescription"
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.Name = "UserStoryDescriptionDataGridViewTextBoxColumn"
        '
        'UserStoryStartDateDataGridViewTextBoxColumn
        '
        Me.UserStoryStartDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryStartDate"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.HeaderText = "UserStoryStartDate"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.Name = "UserStoryStartDateDataGridViewTextBoxColumn"
        '
        'UserStoryEndDateDataGridViewTextBoxColumn
        '
        Me.UserStoryEndDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryEndDate"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.HeaderText = "UserStoryEndDate"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.Name = "UserStoryEndDateDataGridViewTextBoxColumn"
        '
        'UserStoryStatusDataGridViewTextBoxColumn
        '
        Me.UserStoryStatusDataGridViewTextBoxColumn.DataPropertyName = "UserStoryStatus"
        Me.UserStoryStatusDataGridViewTextBoxColumn.HeaderText = "UserStoryStatus"
        Me.UserStoryStatusDataGridViewTextBoxColumn.Name = "UserStoryStatusDataGridViewTextBoxColumn"
        '
        'UserStoryPriorityDataGridViewTextBoxColumn
        '
        Me.UserStoryPriorityDataGridViewTextBoxColumn.DataPropertyName = "UserStoryPriority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.HeaderText = "UserStoryPriority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.Name = "UserStoryPriorityDataGridViewTextBoxColumn"
        '
        'UserStoryBindingSource
        '
        Me.UserStoryBindingSource.DataMember = "UserStory"
        Me.UserStoryBindingSource.DataSource = Me.Group22DataSet
        '
        'Group22DataSet
        '
        Me.Group22DataSet.DataSetName = "group22DataSet"
        Me.Group22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
        '
        'FKTestCasesUserStoryBindingSource
        '
        Me.FKTestCasesUserStoryBindingSource.DataMember = "FK_TestCases_UserStory"
        Me.FKTestCasesUserStoryBindingSource.DataSource = Me.UserStoryBindingSource
        '
        'Group22DataSetBindingSource
        '
        Me.Group22DataSetBindingSource.DataSource = Me.Group22DataSet
        Me.Group22DataSetBindingSource.Position = 0
        '
        'TestCasesTableAdapter
        '
        Me.TestCasesTableAdapter.ClearBeforeFill = True
        '
        'UserStoryMemberBindingSource
        '
        Me.UserStoryMemberBindingSource.DataMember = "UserStory_Member"
        Me.UserStoryMemberBindingSource.DataSource = Me.Group22DataSetBindingSource
        '
        'UserStory_MemberTableAdapter
        '
        Me.UserStory_MemberTableAdapter.ClearBeforeFill = True
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GroupMemberNoDataGridViewTextBoxColumn, Me.ResponsibilityDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.UserStoryMemberBindingSource1
        Me.DataGridView3.Location = New System.Drawing.Point(652, 262)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(251, 175)
        Me.DataGridView3.TabIndex = 5
        '
        'GroupMemberNoDataGridViewTextBoxColumn
        '
        Me.GroupMemberNoDataGridViewTextBoxColumn.DataPropertyName = "GroupMemberNo"
        Me.GroupMemberNoDataGridViewTextBoxColumn.HeaderText = "GroupMemberNo"
        Me.GroupMemberNoDataGridViewTextBoxColumn.Name = "GroupMemberNoDataGridViewTextBoxColumn"
        '
        'ResponsibilityDataGridViewTextBoxColumn
        '
        Me.ResponsibilityDataGridViewTextBoxColumn.DataPropertyName = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.HeaderText = "Responsibility"
        Me.ResponsibilityDataGridViewTextBoxColumn.Name = "ResponsibilityDataGridViewTextBoxColumn"
        '
        'UserStoryMemberBindingSource1
        '
        Me.UserStoryMemberBindingSource1.DataMember = "UserStory_Member"
        Me.UserStoryMemberBindingSource1.DataSource = Me.Group22DataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(652, 468)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 124)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Programmer Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Surname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "Surname", True))
        Me.TextBox2.Location = New System.Drawing.Point(85, 78)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 20)
        Me.TextBox2.TabIndex = 1
        '
        'MemberBindingSource
        '
        Me.MemberBindingSource.DataMember = "Member"
        Me.MemberBindingSource.DataSource = Me.Group22DataSet
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MemberBindingSource, "FirstName", True))
        Me.TextBox1.Location = New System.Drawing.Point(85, 34)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 20)
        Me.TextBox1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStory_MemberTableAdapter1
        '
        Me.UserStory_MemberTableAdapter1.ClearBeforeFill = True
        '
        'MemberTableAdapter1
        '
        Me.MemberTableAdapter1.ClearBeforeFill = True
        '
        'BindingSource1
        '
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.TestCasesBindingSource
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 262)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(620, 173)
        Me.ListBox1.TabIndex = 7
        '
        'TestCasesBindingSource
        '
        Me.TestCasesBindingSource.DataMember = "TestCases"
        Me.TestCasesBindingSource.DataSource = Me.Group22DataSetBindingSource
        '
        'Group22DataSet1
        '
        Me.Group22DataSet1.DataSetName = "group22DataSet"
        Me.Group22DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'ViewingUserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 604)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "ViewingUserStory"
        Me.Text = "ViewingUserStory"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryMemberBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents UserStory_MemberTableAdapter1 As DataSetTableAdapters.UserStory_MemberTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents UserStoryBindingSource As BindingSource
    Friend WithEvents UserStoryTableAdapter As group22DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryPriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Group22DataSetBindingSource As BindingSource
    Friend WithEvents FKTestCasesUserStoryBindingSource As BindingSource
    Friend WithEvents TestCasesTableAdapter As group22DataSetTableAdapters.TestCasesTableAdapter
    Friend WithEvents UserStoryMemberBindingSource As BindingSource
    Friend WithEvents UserStory_MemberTableAdapter As group22DataSetTableAdapters.UserStory_MemberTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents UserStoryMemberBindingSource1 As BindingSource
    Friend WithEvents GroupMemberNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsibilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MemberTableAdapter1 As DataSetTableAdapters.MemberTableAdapter
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TestCasesBindingSource As BindingSource
    Friend WithEvents Group22DataSet1 As group22DataSet
    Friend WithEvents MemberBindingSource As BindingSource
    Friend WithEvents MemberTableAdapter As group22DataSetTableAdapters.MemberTableAdapter
End Class
