<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTestCaseForm
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TestCaseDetailsTextbox = New System.Windows.Forms.TextBox()
        Me.FKTestCasesUserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New User_Story_Application.DataSet()
        Me.ButtonEditTestCase = New System.Windows.Forms.Button()
        Me.TestCaseBox = New System.Windows.Forms.ListBox()
        Me.ListBoxUserStory = New System.Windows.Forms.ListBox()
        Me.UserStoryTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.TestCasesTableAdapter = New User_Story_Application.DataSetTableAdapters.TestCasesTableAdapter()
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "User Story"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Test Case"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(377, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Test Case Details"
        '
        'TestCaseDetailsTextbox
        '
        Me.TestCaseDetailsTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FKTestCasesUserStoryBindingSource, "TestCaseDetails", True))
        Me.TestCaseDetailsTextbox.Location = New System.Drawing.Point(381, 173)
        Me.TestCaseDetailsTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.TestCaseDetailsTextbox.Multiline = True
        Me.TestCaseDetailsTextbox.Name = "TestCaseDetailsTextbox"
        Me.TestCaseDetailsTextbox.Size = New System.Drawing.Size(499, 121)
        Me.TestCaseDetailsTextbox.TabIndex = 14
        '
        'FKTestCasesUserStoryBindingSource
        '
        Me.FKTestCasesUserStoryBindingSource.DataMember = "FK_TestCases_UserStory"
        Me.FKTestCasesUserStoryBindingSource.DataSource = Me.UserStoryBindingSource
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
        'ButtonEditTestCase
        '
        Me.ButtonEditTestCase.Location = New System.Drawing.Point(542, 318)
        Me.ButtonEditTestCase.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonEditTestCase.Name = "ButtonEditTestCase"
        Me.ButtonEditTestCase.Size = New System.Drawing.Size(168, 55)
        Me.ButtonEditTestCase.TabIndex = 13
        Me.ButtonEditTestCase.Text = "Edit Test Case"
        Me.ButtonEditTestCase.UseVisualStyleBackColor = True
        '
        'TestCaseBox
        '
        Me.TestCaseBox.DataSource = Me.FKTestCasesUserStoryBindingSource
        Me.TestCaseBox.DisplayMember = "TestCaseDetails"
        Me.TestCaseBox.FormattingEnabled = True
        Me.TestCaseBox.ItemHeight = 16
        Me.TestCaseBox.Location = New System.Drawing.Point(377, 56)
        Me.TestCaseBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TestCaseBox.Name = "TestCaseBox"
        Me.TestCaseBox.Size = New System.Drawing.Size(503, 68)
        Me.TestCaseBox.TabIndex = 12
        Me.TestCaseBox.ValueMember = "TestCaseNo"
        '
        'ListBoxUserStory
        '
        Me.ListBoxUserStory.DataSource = Me.UserStoryBindingSource
        Me.ListBoxUserStory.DisplayMember = "UserStoryTitle"
        Me.ListBoxUserStory.FormattingEnabled = True
        Me.ListBoxUserStory.ItemHeight = 16
        Me.ListBoxUserStory.Location = New System.Drawing.Point(13, 56)
        Me.ListBoxUserStory.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBoxUserStory.Name = "ListBoxUserStory"
        Me.ListBoxUserStory.Size = New System.Drawing.Size(292, 340)
        Me.ListBoxUserStory.TabIndex = 11
        Me.ListBoxUserStory.ValueMember = "UserStoryNo"
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
        '
        'TestCasesTableAdapter
        '
        Me.TestCasesTableAdapter.ClearBeforeFill = True
        '
        'EditTestCaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TestCaseDetailsTextbox)
        Me.Controls.Add(Me.ButtonEditTestCase)
        Me.Controls.Add(Me.TestCaseBox)
        Me.Controls.Add(Me.ListBoxUserStory)
        Me.Name = "EditTestCaseForm"
        Me.Text = "EditTestCaseForm"
        CType(Me.FKTestCasesUserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TestCaseDetailsTextbox As TextBox
    Friend WithEvents ButtonEditTestCase As Button
    Friend WithEvents TestCaseBox As ListBox
    Friend WithEvents ListBoxUserStory As ListBox
    Friend WithEvents DataSet As DataSet
    Friend WithEvents UserStoryBindingSource As BindingSource
    Friend WithEvents UserStoryTableAdapter As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents FKTestCasesUserStoryBindingSource As BindingSource
    Friend WithEvents TestCasesTableAdapter As DataSetTableAdapters.TestCasesTableAdapter
End Class
