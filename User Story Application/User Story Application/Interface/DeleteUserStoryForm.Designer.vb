<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteUserStoryForm
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
        Me.UserStoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.BSUserStory = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New User_Story_Application.DataSet()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.UserStoryTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.TestCasesTableAdapter = New User_Story_Application.DataSetTableAdapters.TestCasesTableAdapter()
        Me.UserStory_MemberTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStory_MemberTableAdapter()
        Me.UserStoryNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStartDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryEndDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.UserStoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSUserStory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserStoryDataGridView
        '
        Me.UserStoryDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.UserStoryDataGridView.AutoGenerateColumns = False
        Me.UserStoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserStoryNoDataGridViewTextBoxColumn, Me.UserStoryTitleDataGridViewTextBoxColumn, Me.UserRoleDataGridViewTextBoxColumn, Me.UserStoryDescriptionDataGridViewTextBoxColumn, Me.UserStoryStartDateDataGridViewTextBoxColumn, Me.UserStoryEndDateDataGridViewTextBoxColumn, Me.UserStoryStatusDataGridViewTextBoxColumn, Me.UserStoryPriorityDataGridViewTextBoxColumn})
        Me.UserStoryDataGridView.DataSource = Me.BSUserStory
        Me.UserStoryDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.UserStoryDataGridView.Name = "UserStoryDataGridView"
        Me.UserStoryDataGridView.RowTemplate.Height = 24
        Me.UserStoryDataGridView.Size = New System.Drawing.Size(1245, 264)
        Me.UserStoryDataGridView.TabIndex = 2
        '
        'BSUserStory
        '
        Me.BSUserStory.DataMember = "UserStory"
        Me.BSUserStory.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(546, 292)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(194, 60)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
        '
        'TestCasesTableAdapter
        '
        Me.TestCasesTableAdapter.ClearBeforeFill = True
        '
        'UserStory_MemberTableAdapter
        '
        Me.UserStory_MemberTableAdapter.ClearBeforeFill = True
        '
        'UserStoryNoDataGridViewTextBoxColumn
        '
        Me.UserStoryNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserStoryNoDataGridViewTextBoxColumn.DataPropertyName = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.HeaderText = "UserStoryNo"
        Me.UserStoryNoDataGridViewTextBoxColumn.Name = "UserStoryNoDataGridViewTextBoxColumn"
        '
        'UserStoryTitleDataGridViewTextBoxColumn
        '
        Me.UserStoryTitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserStoryTitleDataGridViewTextBoxColumn.DataPropertyName = "UserStoryTitle"
        Me.UserStoryTitleDataGridViewTextBoxColumn.HeaderText = "UserStoryTitle"
        Me.UserStoryTitleDataGridViewTextBoxColumn.Name = "UserStoryTitleDataGridViewTextBoxColumn"
        '
        'UserRoleDataGridViewTextBoxColumn
        '
        Me.UserRoleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserRoleDataGridViewTextBoxColumn.DataPropertyName = "UserRole"
        Me.UserRoleDataGridViewTextBoxColumn.HeaderText = "UserRole"
        Me.UserRoleDataGridViewTextBoxColumn.Name = "UserRoleDataGridViewTextBoxColumn"
        '
        'UserStoryDescriptionDataGridViewTextBoxColumn
        '
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "UserStoryDescription"
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.HeaderText = "UserStoryDescription"
        Me.UserStoryDescriptionDataGridViewTextBoxColumn.Name = "UserStoryDescriptionDataGridViewTextBoxColumn"
        '
        'UserStoryStartDateDataGridViewTextBoxColumn
        '
        Me.UserStoryStartDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserStoryStartDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryStartDate"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.HeaderText = "UserStoryStartDate"
        Me.UserStoryStartDateDataGridViewTextBoxColumn.Name = "UserStoryStartDateDataGridViewTextBoxColumn"
        '
        'UserStoryEndDateDataGridViewTextBoxColumn
        '
        Me.UserStoryEndDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserStoryEndDateDataGridViewTextBoxColumn.DataPropertyName = "UserStoryEndDate"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.HeaderText = "UserStoryEndDate"
        Me.UserStoryEndDateDataGridViewTextBoxColumn.Name = "UserStoryEndDateDataGridViewTextBoxColumn"
        '
        'UserStoryStatusDataGridViewTextBoxColumn
        '
        Me.UserStoryStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserStoryStatusDataGridViewTextBoxColumn.DataPropertyName = "UserStoryStatus"
        Me.UserStoryStatusDataGridViewTextBoxColumn.HeaderText = "UserStoryStatus"
        Me.UserStoryStatusDataGridViewTextBoxColumn.Name = "UserStoryStatusDataGridViewTextBoxColumn"
        '
        'UserStoryPriorityDataGridViewTextBoxColumn
        '
        Me.UserStoryPriorityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserStoryPriorityDataGridViewTextBoxColumn.DataPropertyName = "UserStoryPriority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.HeaderText = "UserStoryPriority"
        Me.UserStoryPriorityDataGridViewTextBoxColumn.Name = "UserStoryPriorityDataGridViewTextBoxColumn"
        '
        'DeleteUserStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.User_Story_Application.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1270, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.UserStoryDataGridView)
        Me.Name = "DeleteUserStoryForm"
        Me.Text = "Delete User Story"
        CType(Me.UserStoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSUserStory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserStoryDataGridView As DataGridView
    Friend WithEvents BSUserStory As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents UserStoryTableAdapter As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TestCasesTableAdapter As DataSetTableAdapters.TestCasesTableAdapter
    Friend WithEvents UserStory_MemberTableAdapter As DataSetTableAdapters.UserStory_MemberTableAdapter
    Friend WithEvents UserStoryNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryTitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStartDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryEndDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserStoryPriorityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
