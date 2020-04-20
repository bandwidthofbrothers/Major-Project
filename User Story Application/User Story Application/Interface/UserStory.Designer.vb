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
        Me.UserRoleLbl.Location = New System.Drawing.Point(288, 32)
        Me.UserRoleLbl.Name = "UserRoleLbl"
        Me.UserRoleLbl.Size = New System.Drawing.Size(109, 26)
        Me.UserRoleLbl.TabIndex = 1
        Me.UserRoleLbl.Text = "User Role"
        '
        'StartDateLbl
        '
        Me.StartDateLbl.AutoSize = True
        Me.StartDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateLbl.Location = New System.Drawing.Point(471, 32)
        Me.StartDateLbl.Name = "StartDateLbl"
        Me.StartDateLbl.Size = New System.Drawing.Size(110, 26)
        Me.StartDateLbl.TabIndex = 2
        Me.StartDateLbl.Text = "Start Date"
        '
        'EndDateLbl
        '
        Me.EndDateLbl.AutoSize = True
        Me.EndDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLbl.Location = New System.Drawing.Point(656, 32)
        Me.EndDateLbl.Name = "EndDateLbl"
        Me.EndDateLbl.Size = New System.Drawing.Size(103, 26)
        Me.EndDateLbl.TabIndex = 3
        Me.EndDateLbl.Text = "End Date"
        '
        'PriorityLbl
        '
        Me.PriorityLbl.AutoSize = True
        Me.PriorityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityLbl.Location = New System.Drawing.Point(288, 170)
        Me.PriorityLbl.Name = "PriorityLbl"
        Me.PriorityLbl.Size = New System.Drawing.Size(80, 26)
        Me.PriorityLbl.TabIndex = 4
        Me.PriorityLbl.Text = "Priority"
        '
        'StatusLbl
        '
        Me.StatusLbl.AutoSize = True
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(483, 170)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(74, 26)
        Me.StatusLbl.TabIndex = 5
        Me.StatusLbl.Text = "Status"
        '
        'DescriptionLbl
        '
        Me.DescriptionLbl.AutoSize = True
        Me.DescriptionLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionLbl.Location = New System.Drawing.Point(12, 170)
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
        Me.TitleTextbox.Size = New System.Drawing.Size(198, 59)
        Me.TitleTextbox.TabIndex = 7
        '
        'UserRoleComboBox
        '
        Me.UserRoleComboBox.FormattingEnabled = True
        Me.UserRoleComboBox.Items.AddRange(New Object() {"Admin", "Cashier", "Manager"})
        Me.UserRoleComboBox.Location = New System.Drawing.Point(293, 73)
        Me.UserRoleComboBox.Name = "UserRoleComboBox"
        Me.UserRoleComboBox.Size = New System.Drawing.Size(138, 21)
        Me.UserRoleComboBox.TabIndex = 8
        '
        'StartDate
        '
        Me.StartDate.Location = New System.Drawing.Point(476, 74)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(156, 20)
        Me.StartDate.TabIndex = 9
        '
        'EndDate
        '
        Me.EndDate.Location = New System.Drawing.Point(661, 74)
        Me.EndDate.Name = "EndDate"
        Me.EndDate.Size = New System.Drawing.Size(156, 20)
        Me.EndDate.TabIndex = 10
        '
        'StatusComboBox
        '
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"In-Progress", "Complete"})
        Me.StatusComboBox.Location = New System.Drawing.Point(488, 213)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(138, 21)
        Me.StatusComboBox.TabIndex = 11
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.FormattingEnabled = True
        Me.PriorityComboBox.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.PriorityComboBox.Location = New System.Drawing.Point(293, 213)
        Me.PriorityComboBox.Name = "PriorityComboBox"
        Me.PriorityComboBox.Size = New System.Drawing.Size(138, 21)
        Me.PriorityComboBox.TabIndex = 12
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(25, 213)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(198, 142)
        Me.DescriptionTextBox.TabIndex = 13
        '
        'RecordUserStoryBtn
        '
        Me.RecordUserStoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordUserStoryBtn.Location = New System.Drawing.Point(498, 263)
        Me.RecordUserStoryBtn.Name = "RecordUserStoryBtn"
        Me.RecordUserStoryBtn.Size = New System.Drawing.Size(134, 74)
        Me.RecordUserStoryBtn.TabIndex = 14
        Me.RecordUserStoryBtn.Text = "Record User Story"
        Me.RecordUserStoryBtn.UseVisualStyleBackColor = True
        '
        'UserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 376)
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
End Class
