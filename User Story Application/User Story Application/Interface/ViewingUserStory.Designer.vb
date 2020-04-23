<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewingUserStory
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
        Me.DataSet1 = New User_Story_Application.DataSet()
        Me.UserStory_MemberTableAdapter1 = New User_Story_Application.DataSetTableAdapters.UserStory_MemberTableAdapter()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TestCaseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestCaseDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKTestCasesUserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCasesTableAdapter = New User_Story_Application.group22DataSetTableAdapters.TestCasesTableAdapter()
        Me.UserStoryMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStory_MemberTableAdapter = New User_Story_Application.group22DataSetTableAdapters.UserStory_MemberTableAdapter()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.UserStoryMemberBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryNoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupMemberNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsibilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryMemberBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn, Me.UserStoryTitleDataGridViewTextBoxColumn, Me.UserRoleDataGridViewTextBoxColumn, Me.UserStoryDescriptionDataGridViewTextBoxColumn, Me.UserStoryStartDateDataGridViewTextBoxColumn, Me.UserStoryEndDateDataGridViewTextBoxColumn, Me.UserStoryStatusDataGridViewTextBoxColumn, Me.UserStoryPriorityDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.UserStoryBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(899, 247)
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TestCaseNoDataGridViewTextBoxColumn, Me.TestCaseDetailsDataGridViewTextBoxColumn, Me.UserStoryNoDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.FKTestCasesUserStoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(382, 167)
        Me.DataGridView1.TabIndex = 4
        '
        'TestCaseNoDataGridViewTextBoxColumn
        '
        Me.TestCaseNoDataGridViewTextBoxColumn.DataPropertyName = "TestCaseNo"
        Me.TestCaseNoDataGridViewTextBoxColumn.HeaderText = "TestCaseNo"
        Me.TestCaseNoDataGridViewTextBoxColumn.Name = "TestCaseNoDataGridViewTextBoxColumn"
        '
        'TestCaseDetailsDataGridViewTextBoxColumn
        '
        Me.TestCaseDetailsDataGridViewTextBoxColumn.DataPropertyName = "TestCaseDetails"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.HeaderText = "TestCaseDetails"
        Me.TestCaseDetailsDataGridViewTextBoxColumn.Name = "TestCaseDetailsDataGridViewTextBoxColumn"
        '
        'UserStoryNoDataGridViewTextBoxColumn1
        '
        Me.UserStoryNoDataGridViewTextBoxColumn1.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn1.HeaderText = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn1.Name = "UserStoryNoDataGridViewTextBoxColumn1"
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
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn2, Me.GroupMemberNoDataGridViewTextBoxColumn, Me.ResponsibilityDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.UserStoryMemberBindingSource1
        Me.DataGridView3.Location = New System.Drawing.Point(416, 265)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(417, 167)
        Me.DataGridView3.TabIndex = 5
        '
        'UserStoryMemberBindingSource1
        '
        Me.UserStoryMemberBindingSource1.DataMember = "UserStory_Member"
        Me.UserStoryMemberBindingSource1.DataSource = Me.Group22DataSet
        '
        'UserStoryNoDataGridViewTextBoxColumn2
        '
        Me.UserStoryNoDataGridViewTextBoxColumn2.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn2.HeaderText = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn2.Name = "UserStoryNoDataGridViewTextBoxColumn2"
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
        'ViewingUserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 457)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "ViewingUserStory"
        Me.Text = "ViewingUserStory"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryMemberBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Group22DataSetBindingSource As BindingSource
    Friend WithEvents FKTestCasesUserStoryBindingSource As BindingSource
    Friend WithEvents TestCasesTableAdapter As group22DataSetTableAdapters.TestCasesTableAdapter
    Friend WithEvents TestCaseNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TestCaseDetailsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryMemberBindingSource As BindingSource
    Friend WithEvents UserStory_MemberTableAdapter As group22DataSetTableAdapters.UserStory_MemberTableAdapter
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupMemberNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResponsibilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryMemberBindingSource1 As BindingSource
End Class
