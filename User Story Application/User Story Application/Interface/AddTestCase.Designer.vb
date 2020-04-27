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
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New User_Story_Application.DataSet()
        Me.TestCaseBox = New System.Windows.Forms.ListBox()
        Me.TestCasesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestCaseNoTextbox = New System.Windows.Forms.TextBox()
        Me.NewTestCaseBtn = New System.Windows.Forms.Button()
        Me.DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserStoryTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.TestCasesTableAdapter = New User_Story_Application.DataSetTableAdapters.TestCasesTableAdapter()
        Me.TestCaseDetailsTextbox = New System.Windows.Forms.TextBox()
        Me.UserStoryNoTextbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TestCaseBox
        '
        Me.TestCaseBox.DataSource = Me.TestCasesBindingSource
        Me.TestCaseBox.FormattingEnabled = True
        Me.TestCaseBox.Location = New System.Drawing.Point(301, 53)
        Me.TestCaseBox.Name = "TestCaseBox"
        Me.TestCaseBox.Size = New System.Drawing.Size(183, 56)
        Me.TestCaseBox.TabIndex = 1
        '
        'TestCasesBindingSource
        '
        Me.TestCasesBindingSource.DataMember = "TestCases"
        Me.TestCasesBindingSource.DataSource = Me.DataSet
        '
        'TestCaseNoTextbox
        '
        Me.TestCaseNoTextbox.Location = New System.Drawing.Point(301, 158)
        Me.TestCaseNoTextbox.Name = "TestCaseNoTextbox"
        Me.TestCaseNoTextbox.Size = New System.Drawing.Size(89, 20)
        Me.TestCaseNoTextbox.TabIndex = 2
        '
        'NewTestCaseBtn
        '
        Me.NewTestCaseBtn.Location = New System.Drawing.Point(423, 219)
        Me.NewTestCaseBtn.Name = "NewTestCaseBtn"
        Me.NewTestCaseBtn.Size = New System.Drawing.Size(126, 45)
        Me.NewTestCaseBtn.TabIndex = 3
        Me.NewTestCaseBtn.Text = "Add New Test Case"
        Me.NewTestCaseBtn.UseVisualStyleBackColor = True
        '
        'DataSetBindingSource
        '
        Me.DataSetBindingSource.DataSource = Me.DataSet
        Me.DataSetBindingSource.Position = 0
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
        '
        'TestCasesTableAdapter
        '
        Me.TestCasesTableAdapter.ClearBeforeFill = True
        '
        'TestCaseDetailsTextbox
        '
        Me.TestCaseDetailsTextbox.Location = New System.Drawing.Point(423, 158)
        Me.TestCaseDetailsTextbox.Multiline = True
        Me.TestCaseDetailsTextbox.Name = "TestCaseDetailsTextbox"
        Me.TestCaseDetailsTextbox.Size = New System.Drawing.Size(154, 20)
        Me.TestCaseDetailsTextbox.TabIndex = 4
        '
        'UserStoryNoTextbox
        '
        Me.UserStoryNoTextbox.Location = New System.Drawing.Point(606, 158)
        Me.UserStoryNoTextbox.Name = "UserStoryNoTextbox"
        Me.UserStoryNoTextbox.Size = New System.Drawing.Size(73, 20)
        Me.UserStoryNoTextbox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Test Case No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Test Case Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(603, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "User Story No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Test Case"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "User Story"
        '
        'AddTestCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 396)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UserStoryNoTextbox)
        Me.Controls.Add(Me.TestCaseDetailsTextbox)
        Me.Controls.Add(Me.NewTestCaseBtn)
        Me.Controls.Add(Me.TestCaseNoTextbox)
        Me.Controls.Add(Me.TestCaseBox)
        Me.Controls.Add(Me.UserStoryBox)
        Me.Name = "AddTestCase"
        Me.Text = "AddTestCase"
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestCasesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserStoryBox As ListBox
    Friend WithEvents TestCaseBox As ListBox
    Friend WithEvents TestCaseNoTextbox As TextBox
    Friend WithEvents NewTestCaseBtn As Button
    Friend WithEvents DataSetBindingSource As BindingSource
    Friend WithEvents DataSet As DataSet
    Friend WithEvents UserStoryBindingSource As BindingSource
    Friend WithEvents UserStoryTableAdapter As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents TestCasesBindingSource As BindingSource
    Friend WithEvents TestCasesTableAdapter As DataSetTableAdapters.TestCasesTableAdapter
    Friend WithEvents TestCaseDetailsTextbox As TextBox
    Friend WithEvents UserStoryNoTextbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
