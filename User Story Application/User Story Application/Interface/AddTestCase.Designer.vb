<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTestCase
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
        Me.UserStoryBox = New System.Windows.Forms.ListBox()
        Me.TestCaseBox = New System.Windows.Forms.ListBox()
        Me.TestCaseTextbox = New System.Windows.Forms.TextBox()
        Me.NewTestCaseBtn = New System.Windows.Forms.Button()
        Me.DataSet = New User_Story_Application.DataSet()
        Me.DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.TestCasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCasesTableAdapter = New User_Story_Application.DataSetTableAdapters.TestCasesTableAdapter()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserStoryBox
        '
        Me.UserStoryBox.DataSource = Me.UserStoryBindingSource
        Me.UserStoryBox.FormattingEnabled = True
        Me.UserStoryBox.Location = New System.Drawing.Point(28, 53)
        Me.UserStoryBox.Name = "UserStoryBox"
        Me.UserStoryBox.Size = New System.Drawing.Size(220, 277)
        Me.UserStoryBox.TabIndex = 0
        '
        'TestCaseBox
        '
        Me.TestCaseBox.DataSource = Me.TestCasesBindingSource
        Me.TestCaseBox.FormattingEnabled = True
        Me.TestCaseBox.Location = New System.Drawing.Point(301, 53)
        Me.TestCaseBox.Name = "TestCaseBox"
        Me.TestCaseBox.Size = New System.Drawing.Size(183, 56)
        Me.TestCaseBox.TabIndex = 1
        '
        'TestCaseTextbox
        '
        Me.TestCaseTextbox.Location = New System.Drawing.Point(301, 146)
        Me.TestCaseTextbox.Name = "TestCaseTextbox"
        Me.TestCaseTextbox.Size = New System.Drawing.Size(183, 20)
        Me.TestCaseTextbox.TabIndex = 2
        '
        'NewTestCaseBtn
        '
        Me.NewTestCaseBtn.Location = New System.Drawing.Point(333, 201)
        Me.NewTestCaseBtn.Name = "NewTestCaseBtn"
        Me.NewTestCaseBtn.Size = New System.Drawing.Size(126, 45)
        Me.NewTestCaseBtn.TabIndex = 3
        Me.NewTestCaseBtn.Text = "Add New Test Case"
        Me.NewTestCaseBtn.UseVisualStyleBackColor = True
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSetBindingSource
        '
        Me.DataSetBindingSource.DataSource = Me.DataSet
        Me.DataSetBindingSource.Position = 0
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
        'TestCasesBindingSource
        '
        Me.TestCasesBindingSource.DataMember = "TestCases"
        Me.TestCasesBindingSource.DataSource = Me.DataSet
        '
        'TestCasesTableAdapter
        '
        Me.TestCasesTableAdapter.ClearBeforeFill = True
        '
        'AddTestCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 396)
        Me.Controls.Add(Me.NewTestCaseBtn)
        Me.Controls.Add(Me.TestCaseTextbox)
        Me.Controls.Add(Me.TestCaseBox)
        Me.Controls.Add(Me.UserStoryBox)
        Me.Name = "AddTestCase"
        Me.Text = "AddTestCase"
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserStoryBox As ListBox
    Friend WithEvents TestCaseBox As ListBox
    Friend WithEvents TestCaseTextbox As TextBox
    Friend WithEvents NewTestCaseBtn As Button
    Friend WithEvents DataSetBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents UserStoryBindingSource As BindingSource
    Friend WithEvents UserStoryTableAdapter As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents TestCasesBindingSource As BindingSource
    Friend WithEvents TestCasesTableAdapter As DataSetTableAdapters.TestCasesTableAdapter
End Class
