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
        Me.UserStoryBox = New System.Windows.Forms.ListBox()
        Me.TestCaseBox = New System.Windows.Forms.ListBox()
        Me.TestCaseTextbox = New System.Windows.Forms.TextBox()
        Me.NewTestCaseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserStoryBox
        '
        Me.UserStoryBox.FormattingEnabled = True
        Me.UserStoryBox.Location = New System.Drawing.Point(28, 53)
        Me.UserStoryBox.Name = "UserStoryBox"
        Me.UserStoryBox.Size = New System.Drawing.Size(220, 277)
        Me.UserStoryBox.TabIndex = 0
        '
        'TestCaseBox
        '
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserStoryBox As ListBox
    Friend WithEvents TestCaseBox As ListBox
    Friend WithEvents TestCaseTextbox As TextBox
    Friend WithEvents NewTestCaseBtn As Button
End Class
