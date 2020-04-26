<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchUserStoryForm
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
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New User_Story_Application.DataSet()
        Me.UserStoryTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.TableAdapterManager = New User_Story_Application.DataSetTableAdapters.TableAdapterManager()
        CType(Me.UserStoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserStoryDataGridView
        '
        Me.UserStoryDataGridView.AutoGenerateColumns = False
        Me.UserStoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserStoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.UserStoryDataGridView.DataSource = Me.UserStoryBindingSource
        Me.UserStoryDataGridView.Location = New System.Drawing.Point(0, 59)
        Me.UserStoryDataGridView.Name = "UserStoryDataGridView"
        Me.UserStoryDataGridView.RowTemplate.Height = 24
        Me.UserStoryDataGridView.Size = New System.Drawing.Size(957, 377)
        Me.UserStoryDataGridView.TabIndex = 1
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(27, 22)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(277, 22)
        Me.TextBoxSearch.TabIndex = 2
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Location = New System.Drawing.Point(337, 18)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(140, 31)
        Me.ButtonSearch.TabIndex = 3
        Me.ButtonSearch.Text = "Search"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "UserStoryNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "UserStoryNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserStoryTitle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserStoryTitle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "UserRole"
        Me.DataGridViewTextBoxColumn3.HeaderText = "UserRole"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UserStoryDescription"
        Me.DataGridViewTextBoxColumn4.HeaderText = "UserStoryDescription"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserStoryStartDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserStoryStartDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UserStoryEndDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UserStoryEndDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UserStoryStatus"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UserStoryStatus"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UserStoryPriority"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UserStoryPriority"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'UserStoryBindingSource
        '
        Me.UserStoryBindingSource.DataMember = "UserStory"
        Me.UserStoryBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MemberTableAdapter = Nothing
        Me.TableAdapterManager.TestCasesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = User_Story_Application.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserStory_MemberTableAdapter = Nothing
        Me.TableAdapterManager.UserStoryTableAdapter = Me.UserStoryTableAdapter
        '
        'SearchUserStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 445)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonSearch)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.UserStoryDataGridView)
        Me.Name = "SearchUserStoryForm"
        Me.Text = "SearchUserStoryForm"
        CType(Me.UserStoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet As DataSet
    Friend WithEvents UserStoryBindingSource As BindingSource
    Friend WithEvents UserStoryTableAdapter As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserStoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonSearch As Button
End Class
