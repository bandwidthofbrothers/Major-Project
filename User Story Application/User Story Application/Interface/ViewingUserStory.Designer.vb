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
        Me.Group22DataSet = New User_Story_Application.group22DataSet()
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryTableAdapter = New User_Story_Application.group22DataSetTableAdapters.UserStoryTableAdapter()
        Me.UserStoryNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Group22DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKTestCasesUserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCasesTableAdapter = New User_Story_Application.group22DataSetTableAdapters.TestCasesTableAdapter()
        Me.TestCaseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TestCaseDetailsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Group22DataSet
        '
        Me.Group22DataSet.DataSetName = "group22DataSet"
        Me.Group22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStoryBindingSource
        '
        Me.UserStoryBindingSource.DataMember = "UserStory"
        Me.UserStoryBindingSource.DataSource = Me.Group22DataSet
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
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
        'Group22DataSetBindingSource
        '
        Me.Group22DataSetBindingSource.DataSource = Me.Group22DataSet
        Me.Group22DataSetBindingSource.Position = 0
        '
        'FKTestCasesUserStoryBindingSource
        '
        Me.FKTestCasesUserStoryBindingSource.DataMember = "FK_TestCases_UserStory"
        Me.FKTestCasesUserStoryBindingSource.DataSource = Me.UserStoryBindingSource
        '
        'TestCasesTableAdapter
        '
        Me.TestCasesTableAdapter.ClearBeforeFill = True
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
        'ViewingUserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 457)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Name = "ViewingUserStory"
        Me.Text = "ViewingUserStory"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
