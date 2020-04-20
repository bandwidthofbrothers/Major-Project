<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserStory
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
        Me.UserStoryLbl = New System.Windows.Forms.Label()
        Me.UserRoleLbl = New System.Windows.Forms.Label()
        Me.StartDateLbl = New System.Windows.Forms.Label()
        Me.EndDateLbl = New System.Windows.Forms.Label()
        Me.PriorityLbl = New System.Windows.Forms.Label()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.DescriptionLbl = New System.Windows.Forms.Label()
        Me.TitleTextbox = New System.Windows.Forms.TextBox()
        Me.UserRoleComboBox = New System.Windows.Forms.ComboBox()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.EndDate = New System.Windows.Forms.DateTimePicker()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.PriorityComboBox = New System.Windows.Forms.ComboBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.RecordUserStoryBtn = New System.Windows.Forms.Button()
        Me.GroupBoxProgrammer1 = New System.Windows.Forms.GroupBox()
        Me.LabelResponsibility = New System.Windows.Forms.Label()
        Me.Name = New System.Windows.Forms.Label()
        Me.ComboBoxProgrammer1Responsibility = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProgrammer1Name = New System.Windows.Forms.ComboBox()
        Me.GroupBoxProgrammer2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxProgrammer2Responsibility = New System.Windows.Forms.ComboBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.ComboBoxProgrammer2Name = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAddNewTestCase = New System.Windows.Forms.Button()
        Me.ButtonRemoveTestCase = New System.Windows.Forms.Button()
        Me.GroupBoxProgrammer1.SuspendLayout()
        Me.GroupBoxProgrammer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserStoryLbl
        '
        Me.UserStoryLbl.AutoSize = True
        Me.UserStoryLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserStoryLbl.Location = New System.Drawing.Point(29, 39)
        Me.UserStoryLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserStoryLbl.Name = "UserStoryLbl"
        Me.UserStoryLbl.Size = New System.Drawing.Size(202, 31)
        Me.UserStoryLbl.TabIndex = 0
        Me.UserStoryLbl.Text = "User Story Title"
        '
        'UserRoleLbl
        '
        Me.UserRoleLbl.AutoSize = True
        Me.UserRoleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserRoleLbl.Location = New System.Drawing.Point(479, 39)
        Me.UserRoleLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserRoleLbl.Name = "UserRoleLbl"
        Me.UserRoleLbl.Size = New System.Drawing.Size(135, 31)
        Me.UserRoleLbl.TabIndex = 1
        Me.UserRoleLbl.Text = "User Role"
        '
        'StartDateLbl
        '
        Me.StartDateLbl.AutoSize = True
        Me.StartDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateLbl.Location = New System.Drawing.Point(698, 39)
        Me.StartDateLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StartDateLbl.Name = "StartDateLbl"
        Me.StartDateLbl.Size = New System.Drawing.Size(137, 31)
        Me.StartDateLbl.TabIndex = 2
        Me.StartDateLbl.Text = "Start Date"
        '
        'EndDateLbl
        '
        Me.EndDateLbl.AutoSize = True
        Me.EndDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLbl.Location = New System.Drawing.Point(945, 39)
        Me.EndDateLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EndDateLbl.Name = "EndDateLbl"
        Me.EndDateLbl.Size = New System.Drawing.Size(127, 31)
        Me.EndDateLbl.TabIndex = 3
        Me.EndDateLbl.Text = "End Date"
        '
        'PriorityLbl
        '
        Me.PriorityLbl.AutoSize = True
        Me.PriorityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityLbl.Location = New System.Drawing.Point(1078, 212)
        Me.PriorityLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriorityLbl.Name = "PriorityLbl"
        Me.PriorityLbl.Size = New System.Drawing.Size(99, 31)
        Me.PriorityLbl.TabIndex = 4
        Me.PriorityLbl.Text = "Priority"
        '
        'StatusLbl
        '
        Me.StatusLbl.AutoSize = True
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(1078, 342)
        Me.StatusLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(92, 31)
        Me.StatusLbl.TabIndex = 5
        Me.StatusLbl.Text = "Status"
        '
        'DescriptionLbl
        '
        Me.DescriptionLbl.AutoSize = True
        Me.DescriptionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLbl.Location = New System.Drawing.Point(29, 212)
        Me.DescriptionLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DescriptionLbl.Name = "DescriptionLbl"
        Me.DescriptionLbl.Size = New System.Drawing.Size(287, 31)
        Me.DescriptionLbl.TabIndex = 6
        Me.DescriptionLbl.Text = "User Story Description"
        '
        'TitleTextbox
        '
        Me.TitleTextbox.Location = New System.Drawing.Point(33, 90)
        Me.TitleTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleTextbox.Multiline = True
        Me.TitleTextbox.Name = "TitleTextbox"
        Me.TitleTextbox.Size = New System.Drawing.Size(394, 72)
        Me.TitleTextbox.TabIndex = 7
        '
        'UserRoleComboBox
        '
        Me.UserRoleComboBox.FormattingEnabled = True
        Me.UserRoleComboBox.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.UserRoleComboBox.Location = New System.Drawing.Point(486, 90)
        Me.UserRoleComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UserRoleComboBox.Name = "UserRoleComboBox"
        Me.UserRoleComboBox.Size = New System.Drawing.Size(183, 24)
        Me.UserRoleComboBox.TabIndex = 8
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(705, 91)
        Me.StartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(207, 22)
        Me.StartDate.TabIndex = 9
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(951, 91)
        Me.EndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(207, 22)
        Me.EndDate.TabIndex = 10
        '
        'StatusComboBox
        '
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"In-Progress", "Complete"})
        Me.StatusComboBox.Location = New System.Drawing.Point(1085, 395)
        Me.StatusComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(183, 24)
        Me.StatusComboBox.TabIndex = 11
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.FormattingEnabled = True
        Me.PriorityComboBox.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.PriorityComboBox.Location = New System.Drawing.Point(1085, 265)
        Me.PriorityComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PriorityComboBox.Name = "PriorityComboBox"
        Me.PriorityComboBox.Size = New System.Drawing.Size(183, 24)
        Me.PriorityComboBox.TabIndex = 12
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(33, 262)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(394, 282)
        Me.DescriptionTextBox.TabIndex = 13
        '
        'RecordUserStoryBtn
        '
        Me.RecordUserStoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordUserStoryBtn.Location = New System.Drawing.Point(1089, 564)
        Me.RecordUserStoryBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.RecordUserStoryBtn.Name = "RecordUserStoryBtn"
        Me.RecordUserStoryBtn.Size = New System.Drawing.Size(179, 91)
        Me.RecordUserStoryBtn.TabIndex = 14
        Me.RecordUserStoryBtn.Text = "Record User Story"
        Me.RecordUserStoryBtn.UseVisualStyleBackColor = True
        '
        'GroupBoxProgrammer1
        '
        Me.GroupBoxProgrammer1.Controls.Add(Me.LabelResponsibility)
        Me.GroupBoxProgrammer1.Controls.Add(Me.Name)
        Me.GroupBoxProgrammer1.Controls.Add(Me.ComboBoxProgrammer1Responsibility)
        Me.GroupBoxProgrammer1.Controls.Add(Me.ComboBoxProgrammer1Name)
        Me.GroupBoxProgrammer1.Location = New System.Drawing.Point(35, 564)
        Me.GroupBoxProgrammer1.Name = "GroupBoxProgrammer1"
        Me.GroupBoxProgrammer1.Size = New System.Drawing.Size(392, 100)
        Me.GroupBoxProgrammer1.TabIndex = 15
        Me.GroupBoxProgrammer1.TabStop = False
        Me.GroupBoxProgrammer1.Text = "Programmer 1"
        '
        'LabelResponsibility
        '
        Me.LabelResponsibility.AutoSize = True
        Me.LabelResponsibility.Location = New System.Drawing.Point(250, 22)
        Me.LabelResponsibility.Name = "LabelResponsibility"
        Me.LabelResponsibility.Size = New System.Drawing.Size(92, 17)
        Me.LabelResponsibility.TabIndex = 3
        Me.LabelResponsibility.Text = "Responsiblity"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(26, 22)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(45, 17)
        Me.Name.TabIndex = 2
        Me.Name.Text = "Name"
        '
        'ComboBoxProgrammer1Responsibility
        '
        Me.ComboBoxProgrammer1Responsibility.FormattingEnabled = True
        Me.ComboBoxProgrammer1Responsibility.Location = New System.Drawing.Point(250, 48)
        Me.ComboBoxProgrammer1Responsibility.Name = "ComboBoxProgrammer1Responsibility"
        Me.ComboBoxProgrammer1Responsibility.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxProgrammer1Responsibility.TabIndex = 1
        '
        'ComboBoxProgrammer1Name
        '
        Me.ComboBoxProgrammer1Name.FormattingEnabled = True
        Me.ComboBoxProgrammer1Name.Location = New System.Drawing.Point(29, 48)
        Me.ComboBoxProgrammer1Name.Name = "ComboBoxProgrammer1Name"
        Me.ComboBoxProgrammer1Name.Size = New System.Drawing.Size(190, 24)
        Me.ComboBoxProgrammer1Name.TabIndex = 0
        '
        'GroupBoxProgrammer2
        '
        Me.GroupBoxProgrammer2.Controls.Add(Me.Label1)
        Me.GroupBoxProgrammer2.Controls.Add(Me.ComboBoxProgrammer2Responsibility)
        Me.GroupBoxProgrammer2.Controls.Add(Me.LabelName)
        Me.GroupBoxProgrammer2.Controls.Add(Me.ComboBoxProgrammer2Name)
        Me.GroupBoxProgrammer2.Location = New System.Drawing.Point(485, 564)
        Me.GroupBoxProgrammer2.Name = "GroupBoxProgrammer2"
        Me.GroupBoxProgrammer2.Size = New System.Drawing.Size(392, 100)
        Me.GroupBoxProgrammer2.TabIndex = 16
        Me.GroupBoxProgrammer2.TabStop = False
        Me.GroupBoxProgrammer2.Text = "Programmer 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Responsiblity"
        '
        'ComboBoxProgrammer2Responsibility
        '
        Me.ComboBoxProgrammer2Responsibility.FormattingEnabled = True
        Me.ComboBoxProgrammer2Responsibility.Location = New System.Drawing.Point(252, 48)
        Me.ComboBoxProgrammer2Responsibility.Name = "ComboBoxProgrammer2Responsibility"
        Me.ComboBoxProgrammer2Responsibility.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxProgrammer2Responsibility.TabIndex = 5
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(28, 22)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(45, 17)
        Me.LabelName.TabIndex = 6
        Me.LabelName.Text = "Name"
        '
        'ComboBoxProgrammer2Name
        '
        Me.ComboBoxProgrammer2Name.FormattingEnabled = True
        Me.ComboBoxProgrammer2Name.Location = New System.Drawing.Point(31, 48)
        Me.ComboBoxProgrammer2Name.Name = "ComboBoxProgrammer2Name"
        Me.ComboBoxProgrammer2Name.Size = New System.Drawing.Size(190, 24)
        Me.ComboBoxProgrammer2Name.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(485, 407)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(533, 137)
        Me.TextBox1.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(486, 262)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(532, 72)
        Me.TextBox2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(479, 212)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 31)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "New Test Case Details"
        '
        'ButtonAddNewTestCase
        '
        Me.ButtonAddNewTestCase.Location = New System.Drawing.Point(554, 351)
        Me.ButtonAddNewTestCase.Name = "ButtonAddNewTestCase"
        Me.ButtonAddNewTestCase.Size = New System.Drawing.Size(134, 49)
        Me.ButtonAddNewTestCase.TabIndex = 20
        Me.ButtonAddNewTestCase.Text = "Add new Test Case"
        Me.ButtonAddNewTestCase.UseVisualStyleBackColor = True
        '
        'ButtonRemoveTestCase
        '
        Me.ButtonRemoveTestCase.Location = New System.Drawing.Point(831, 351)
        Me.ButtonRemoveTestCase.Name = "ButtonRemoveTestCase"
        Me.ButtonRemoveTestCase.Size = New System.Drawing.Size(134, 49)
        Me.ButtonRemoveTestCase.TabIndex = 21
        Me.ButtonRemoveTestCase.Text = "Remove Test Case"
        Me.ButtonRemoveTestCase.UseVisualStyleBackColor = True
        '
        'UserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1293, 676)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonRemoveTestCase)
        Me.Controls.Add(Me.ButtonAddNewTestCase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBoxProgrammer2)
        Me.Controls.Add(Me.GroupBoxProgrammer1)
        Me.Controls.Add(Me.RecordUserStoryBtn)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.PriorityComboBox)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.EndDate)
        Me.Controls.Add(Me.StartDate)
        Me.Controls.Add(Me.UserRoleComboBox)
        Me.Controls.Add(Me.TitleTextbox)
        Me.Controls.Add(Me.DescriptionLbl)
        Me.Controls.Add(Me.StatusLbl)
        Me.Controls.Add(Me.PriorityLbl)
        Me.Controls.Add(Me.EndDateLbl)
        Me.Controls.Add(Me.StartDateLbl)
        Me.Controls.Add(Me.UserRoleLbl)
        Me.Controls.Add(Me.UserStoryLbl)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UserStory"
        Me.Text = "UserStory"
        Me.GroupBoxProgrammer1.ResumeLayout(False)
        Me.GroupBoxProgrammer1.PerformLayout()
        Me.GroupBoxProgrammer2.ResumeLayout(False)
        Me.GroupBoxProgrammer2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserStoryLbl As Label
    Friend WithEvents UserRoleLbl As Label
    Friend WithEvents StartDateLbl As Label
    Friend WithEvents EndDateLbl As Label
    Friend WithEvents PriorityLbl As Label
    Friend WithEvents StatusLbl As Label
    Friend WithEvents DescriptionLbl As Label
    Friend WithEvents TitleTextbox As TextBox
    Friend WithEvents UserRoleComboBox As ComboBox
    Friend WithEvents StartDate As DateTimePicker
    Friend WithEvents EndDate As DateTimePicker
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents PriorityComboBox As ComboBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents RecordUserStoryBtn As Button
    Friend WithEvents GroupBoxProgrammer1 As GroupBox
    Friend WithEvents LabelResponsibility As Label
    Friend WithEvents Name As Label
    Friend WithEvents ComboBoxProgrammer1Responsibility As ComboBox
    Friend WithEvents ComboBoxProgrammer1Name As ComboBox
    Friend WithEvents GroupBoxProgrammer2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxProgrammer2Responsibility As ComboBox
    Friend WithEvents LabelName As Label
    Friend WithEvents ComboBoxProgrammer2Name As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAddNewTestCase As Button
    Friend WithEvents ButtonRemoveTestCase As Button
End Class
