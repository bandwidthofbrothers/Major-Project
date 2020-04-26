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
        Me.UserStory = New System.Windows.Forms.ListBox()
        Me.TestCases = New System.Windows.Forms.ListBox()
        Me.TestCaseBox = New System.Windows.Forms.TextBox()
        Me.TestCaseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserStory
        '
        Me.UserStory.FormattingEnabled = True
        Me.UserStory.Location = New System.Drawing.Point(34, 53)
        Me.UserStory.Name = "UserStory"
        Me.UserStory.Size = New System.Drawing.Size(216, 277)
        Me.UserStory.TabIndex = 0
        '
        'TestCases
        '
        Me.TestCases.FormattingEnabled = True
        Me.TestCases.Location = New System.Drawing.Point(292, 53)
        Me.TestCases.Name = "TestCases"
        Me.TestCases.Size = New System.Drawing.Size(263, 121)
        Me.TestCases.TabIndex = 1
        '
        'TestCaseBox
        '
        Me.TestCaseBox.Location = New System.Drawing.Point(292, 193)
        Me.TestCaseBox.Name = "TestCaseBox"
        Me.TestCaseBox.Size = New System.Drawing.Size(263, 20)
        Me.TestCaseBox.TabIndex = 2
        '
        'TestCaseBtn
        '
        Me.TestCaseBtn.Location = New System.Drawing.Point(384, 240)
        Me.TestCaseBtn.Name = "TestCaseBtn"
        Me.TestCaseBtn.Size = New System.Drawing.Size(110, 38)
        Me.TestCaseBtn.TabIndex = 3
        Me.TestCaseBtn.Text = "Add New Test Case"
        Me.TestCaseBtn.UseVisualStyleBackColor = True
        '
        'AddTestCase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 367)
        Me.Controls.Add(Me.TestCaseBtn)
        Me.Controls.Add(Me.TestCaseBox)
        Me.Controls.Add(Me.TestCases)
        Me.Controls.Add(Me.UserStory)
        Me.Name = "AddTestCase"
        Me.Text = "AddTestCase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserStory As ListBox
    Friend WithEvents TestCases As ListBox
    Friend WithEvents TestCaseBox As TextBox
    Friend WithEvents TestCaseBtn As Button
End Class
