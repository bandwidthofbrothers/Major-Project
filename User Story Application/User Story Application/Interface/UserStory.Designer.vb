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
        Me.DataSet1 = New User_Story_Application.DataSet()
        Me.MemberTableAdapter1 = New User_Story_Application.DataSetTableAdapters.MemberTableAdapter()
        Me.GroupBoxProgrammer1.SuspendLayout()
        Me.GroupBoxProgrammer2.SuspendLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserStoryLbl
        '
        Me.UserStoryLbl.AutoSize = True
        Me.UserStoryLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserStoryLbl.Location = New System.Drawing.Point(22, 32)
        Me.UserStoryLbl.Name = "UserStoryLbl"
        Me.UserStoryLbl.Size = New System.Drawing.Size(161, 26)
        Me.UserStoryLbl.TabIndex = 0
        Me.UserStoryLbl.Text = "User Story Title"
        '
        'UserRoleLbl
        '
        Me.UserRoleLbl.AutoSize = True
        Me.UserRoleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserRoleLbl.Location = New System.Drawing.Point(359, 32)
        Me.UserRoleLbl.Name = "UserRoleLbl"
        Me.UserRoleLbl.Size = New System.Drawing.Size(109, 26)
        Me.UserRoleLbl.TabIndex = 1
        Me.UserRoleLbl.Text = "User Role"
        '
        'StartDateLbl
        '
        Me.StartDateLbl.AutoSize = True
        Me.StartDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateLbl.Location = New System.Drawing.Point(524, 32)
        Me.StartDateLbl.Name = "StartDateLbl"
        Me.StartDateLbl.Size = New System.Drawing.Size(110, 26)
        Me.StartDateLbl.TabIndex = 2
        Me.StartDateLbl.Text = "Start Date"
        '
        'EndDateLbl
        '
        Me.EndDateLbl.AutoSize = True
        Me.EndDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLbl.Location = New System.Drawing.Point(709, 32)
        Me.EndDateLbl.Name = "EndDateLbl"
        Me.EndDateLbl.Size = New System.Drawing.Size(103, 26)
        Me.EndDateLbl.TabIndex = 3
        Me.EndDateLbl.Text = "End Date"
        '
        'PriorityLbl
        '
        Me.PriorityLbl.AutoSize = True
        Me.PriorityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityLbl.Location = New System.Drawing.Point(808, 172)
        Me.PriorityLbl.Name = "PriorityLbl"
        Me.PriorityLbl.Size = New System.Drawing.Size(80, 26)
        Me.PriorityLbl.TabIndex = 4
        Me.PriorityLbl.Text = "Priority"
        '
        'StatusLbl
        '
        Me.StatusLbl.AutoSize = True
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(808, 278)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(74, 26)
        Me.StatusLbl.TabIndex = 5
        Me.StatusLbl.Text = "Status"
        '
        'DescriptionLbl
        '
        Me.DescriptionLbl.AutoSize = True
        Me.DescriptionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLbl.Location = New System.Drawing.Point(22, 172)
        Me.DescriptionLbl.Name = "DescriptionLbl"
        Me.DescriptionLbl.Size = New System.Drawing.Size(230, 26)
        Me.DescriptionLbl.TabIndex = 6
        Me.DescriptionLbl.Text = "User Story Description"
        '
        'TitleTextbox
        '
        Me.TitleTextbox.Location = New System.Drawing.Point(25, 73)
        Me.TitleTextbox.Multiline = True
        Me.TitleTextbox.Name = "TitleTextbox"
        Me.TitleTextbox.Size = New System.Drawing.Size(296, 59)
        Me.TitleTextbox.TabIndex = 7
        '
        'UserRoleComboBox
        '
        Me.UserRoleComboBox.FormattingEnabled = True
        Me.UserRoleComboBox.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.UserRoleComboBox.Location = New System.Drawing.Point(364, 73)
        Me.UserRoleComboBox.Name = "UserRoleComboBox"
        Me.UserRoleComboBox.Size = New System.Drawing.Size(138, 21)
        Me.UserRoleComboBox.TabIndex = 8
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(529, 74)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(156, 20)
        Me.StartDate.TabIndex = 9
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(713, 74)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(156, 20)
        Me.EndDate.TabIndex = 10
        '
        'StatusComboBox
        '
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"In-Progress", "Complete"})
        Me.StatusComboBox.Location = New System.Drawing.Point(814, 321)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(138, 21)
        Me.StatusComboBox.TabIndex = 11
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.FormattingEnabled = True
        Me.PriorityComboBox.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.PriorityComboBox.Location = New System.Drawing.Point(814, 215)
        Me.PriorityComboBox.Name = "PriorityComboBox"
        Me.PriorityComboBox.Size = New System.Drawing.Size(138, 21)
        Me.PriorityComboBox.TabIndex = 12
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(25, 213)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(296, 230)
        Me.DescriptionTextBox.TabIndex = 13
        '
        'RecordUserStoryBtn
        '
        Me.RecordUserStoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordUserStoryBtn.Location = New System.Drawing.Point(817, 458)
        Me.RecordUserStoryBtn.Name = "RecordUserStoryBtn"
        Me.RecordUserStoryBtn.Size = New System.Drawing.Size(134, 74)
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
        Me.GroupBoxProgrammer1.Location = New System.Drawing.Point(26, 458)
        Me.GroupBoxProgrammer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxProgrammer1.Name = "GroupBoxProgrammer1"
        Me.GroupBoxProgrammer1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxProgrammer1.Size = New System.Drawing.Size(294, 81)
        Me.GroupBoxProgrammer1.TabIndex = 15
        Me.GroupBoxProgrammer1.TabStop = False
        Me.GroupBoxProgrammer1.Text = "Programmer 1"
        '
        'LabelResponsibility
        '
        Me.LabelResponsibility.AutoSize = True
        Me.LabelResponsibility.Location = New System.Drawing.Point(188, 18)
        Me.LabelResponsibility.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelResponsibility.Name = "LabelResponsibility"
        Me.LabelResponsibility.Size = New System.Drawing.Size(69, 13)
        Me.LabelResponsibility.TabIndex = 3
        Me.LabelResponsibility.Text = "Responsiblity"
        '
        'Name
        '
        Me.Name.AutoSize = True
        Me.Name.Location = New System.Drawing.Point(20, 18)
        Me.Name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Name.Name = "Name"
        Me.Name.Size = New System.Drawing.Size(35, 13)
        Me.Name.TabIndex = 2
        Me.Name.Text = "Name"
        '
        'ComboBoxProgrammer1Responsibility
        '
        Me.ComboBoxProgrammer1Responsibility.FormattingEnabled = True
        Me.ComboBoxProgrammer1Responsibility.Location = New System.Drawing.Point(188, 39)
        Me.ComboBoxProgrammer1Responsibility.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxProgrammer1Responsibility.Name = "ComboBoxProgrammer1Responsibility"
        Me.ComboBoxProgrammer1Responsibility.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxProgrammer1Responsibility.TabIndex = 1
        '
        'ComboBoxProgrammer1Name
        '
        Me.ComboBoxProgrammer1Name.FormattingEnabled = True
        Me.ComboBoxProgrammer1Name.Location = New System.Drawing.Point(22, 39)
        Me.ComboBoxProgrammer1Name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxProgrammer1Name.Name = "ComboBoxProgrammer1Name"
        Me.ComboBoxProgrammer1Name.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxProgrammer1Name.TabIndex = 0
        '
        'GroupBoxProgrammer2
        '
        Me.GroupBoxProgrammer2.Controls.Add(Me.Label1)
        Me.GroupBoxProgrammer2.Controls.Add(Me.ComboBoxProgrammer2Responsibility)
        Me.GroupBoxProgrammer2.Controls.Add(Me.LabelName)
        Me.GroupBoxProgrammer2.Controls.Add(Me.ComboBoxProgrammer2Name)
        Me.GroupBoxProgrammer2.Location = New System.Drawing.Point(364, 458)
        Me.GroupBoxProgrammer2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxProgrammer2.Name = "GroupBoxProgrammer2"
        Me.GroupBoxProgrammer2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxProgrammer2.Size = New System.Drawing.Size(294, 81)
        Me.GroupBoxProgrammer2.TabIndex = 16
        Me.GroupBoxProgrammer2.TabStop = False
        Me.GroupBoxProgrammer2.Text = "Programmer 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(187, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Responsiblity"
        '
        'ComboBoxProgrammer2Responsibility
        '
        Me.ComboBoxProgrammer2Responsibility.FormattingEnabled = True
        Me.ComboBoxProgrammer2Responsibility.Location = New System.Drawing.Point(189, 39)
        Me.ComboBoxProgrammer2Responsibility.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxProgrammer2Responsibility.Name = "ComboBoxProgrammer2Responsibility"
        Me.ComboBoxProgrammer2Responsibility.Size = New System.Drawing.Size(92, 21)
        Me.ComboBoxProgrammer2Responsibility.TabIndex = 5
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(21, 18)
        Me.LabelName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(35, 13)
        Me.LabelName.TabIndex = 6
        Me.LabelName.Text = "Name"
        '
        'ComboBoxProgrammer2Name
        '
        Me.ComboBoxProgrammer2Name.FormattingEnabled = True
        Me.ComboBoxProgrammer2Name.Location = New System.Drawing.Point(23, 39)
        Me.ComboBoxProgrammer2Name.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxProgrammer2Name.Name = "ComboBoxProgrammer2Name"
        Me.ComboBoxProgrammer2Name.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxProgrammer2Name.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 331)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(401, 112)
        Me.TextBox1.TabIndex = 17
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(364, 213)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(400, 59)
        Me.TextBox2.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 26)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "New Test Case Details"
        '
        'ButtonAddNewTestCase
        '
        Me.ButtonAddNewTestCase.Location = New System.Drawing.Point(416, 285)
        Me.ButtonAddNewTestCase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonAddNewTestCase.Name = "ButtonAddNewTestCase"
        Me.ButtonAddNewTestCase.Size = New System.Drawing.Size(100, 40)
        Me.ButtonAddNewTestCase.TabIndex = 20
        Me.ButtonAddNewTestCase.Text = "Add new Test Case"
        Me.ButtonAddNewTestCase.UseVisualStyleBackColor = True
        '
        'ButtonRemoveTestCase
        '
        Me.ButtonRemoveTestCase.Location = New System.Drawing.Point(623, 285)
        Me.ButtonRemoveTestCase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonRemoveTestCase.Name = "ButtonRemoveTestCase"
        Me.ButtonRemoveTestCase.Size = New System.Drawing.Size(100, 40)
        Me.ButtonRemoveTestCase.TabIndex = 21
        Me.ButtonRemoveTestCase.Text = "Remove Test Case"
        Me.ButtonRemoveTestCase.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberTableAdapter1
        '
        Me.MemberTableAdapter1.ClearBeforeFill = True
        '
        'UserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 549)
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
        Me.Name = "UserStory"
        Me.Text = "UserStory"
        Me.GroupBoxProgrammer1.ResumeLayout(False)
        Me.GroupBoxProgrammer1.PerformLayout()
        Me.GroupBoxProgrammer2.ResumeLayout(False)
        Me.GroupBoxProgrammer2.PerformLayout()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents MemberTableAdapter1 As DataSetTableAdapters.MemberTableAdapter
End Class
