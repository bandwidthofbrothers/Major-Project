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
        Me.UserStoryDescLbl = New System.Windows.Forms.Label()
        Me.StartDateLbl = New System.Windows.Forms.Label()
        Me.UserRoleLbl = New System.Windows.Forms.Label()
        Me.EndDateLbl = New System.Windows.Forms.Label()
        Me.PriorityLbl = New System.Windows.Forms.Label()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.UserStoryTextbox = New System.Windows.Forms.TextBox()
        Me.UserRoleComboBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.PriorityComboBox = New System.Windows.Forms.ComboBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.UserDescTextBox = New System.Windows.Forms.TextBox()
        Me.RecordUserStoryBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserStoryLbl
        '
        Me.UserStoryLbl.AutoSize = True
        Me.UserStoryLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserStoryLbl.Location = New System.Drawing.Point(43, 33)
        Me.UserStoryLbl.Name = "UserStoryLbl"
        Me.UserStoryLbl.Size = New System.Drawing.Size(161, 26)
        Me.UserStoryLbl.TabIndex = 0
        Me.UserStoryLbl.Text = "User Story Title"
        '
        'UserStoryDescLbl
        '
        Me.UserStoryDescLbl.AutoSize = True
        Me.UserStoryDescLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserStoryDescLbl.Location = New System.Drawing.Point(43, 190)
        Me.UserStoryDescLbl.Name = "UserStoryDescLbl"
        Me.UserStoryDescLbl.Size = New System.Drawing.Size(230, 26)
        Me.UserStoryDescLbl.TabIndex = 1
        Me.UserStoryDescLbl.Text = "User Story Description"
        '
        'StartDateLbl
        '
        Me.StartDateLbl.AutoSize = True
        Me.StartDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDateLbl.Location = New System.Drawing.Point(401, 33)
        Me.StartDateLbl.Name = "StartDateLbl"
        Me.StartDateLbl.Size = New System.Drawing.Size(110, 26)
        Me.StartDateLbl.TabIndex = 2
        Me.StartDateLbl.Text = "Start Date"
        '
        'UserRoleLbl
        '
        Me.UserRoleLbl.AutoSize = True
        Me.UserRoleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserRoleLbl.Location = New System.Drawing.Point(251, 33)
        Me.UserRoleLbl.Name = "UserRoleLbl"
        Me.UserRoleLbl.Size = New System.Drawing.Size(109, 26)
        Me.UserRoleLbl.TabIndex = 3
        Me.UserRoleLbl.Text = "User Role"
        '
        'EndDateLbl
        '
        Me.EndDateLbl.AutoSize = True
        Me.EndDateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndDateLbl.Location = New System.Drawing.Point(641, 33)
        Me.EndDateLbl.Name = "EndDateLbl"
        Me.EndDateLbl.Size = New System.Drawing.Size(103, 26)
        Me.EndDateLbl.TabIndex = 4
        Me.EndDateLbl.Text = "End Date"
        '
        'PriorityLbl
        '
        Me.PriorityLbl.AutoSize = True
        Me.PriorityLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriorityLbl.Location = New System.Drawing.Point(379, 191)
        Me.PriorityLbl.Name = "PriorityLbl"
        Me.PriorityLbl.Size = New System.Drawing.Size(80, 26)
        Me.PriorityLbl.TabIndex = 5
        Me.PriorityLbl.Text = "Priority"
        '
        'StatusLbl
        '
        Me.StatusLbl.AutoSize = True
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.Location = New System.Drawing.Point(592, 190)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(74, 26)
        Me.StatusLbl.TabIndex = 7
        Me.StatusLbl.Text = "Status"
        '
        'UserStoryTextbox
        '
        Me.UserStoryTextbox.Location = New System.Drawing.Point(48, 79)
        Me.UserStoryTextbox.Multiline = True
        Me.UserStoryTextbox.Name = "UserStoryTextbox"
        Me.UserStoryTextbox.Size = New System.Drawing.Size(156, 63)
        Me.UserStoryTextbox.TabIndex = 8
        '
        'UserRoleComboBox
        '
        Me.UserRoleComboBox.DisplayMember = "Admin"
        Me.UserRoleComboBox.FormattingEnabled = True
        Me.UserRoleComboBox.Items.AddRange(New Object() {"Cashier", "Admin", "Manager"})
        Me.UserRoleComboBox.Location = New System.Drawing.Point(256, 79)
        Me.UserRoleComboBox.Name = "UserRoleComboBox"
        Me.UserRoleComboBox.Size = New System.Drawing.Size(104, 21)
        Me.UserRoleComboBox.TabIndex = 9
        Me.UserRoleComboBox.ValueMember = "Admin"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(406, 74)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(646, 74)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'PriorityComboBox
        '
        Me.PriorityComboBox.FormattingEnabled = True
        Me.PriorityComboBox.Items.AddRange(New Object() {"Low", "Medium", "High"})
        Me.PriorityComboBox.Location = New System.Drawing.Point(384, 230)
        Me.PriorityComboBox.Name = "PriorityComboBox"
        Me.PriorityComboBox.Size = New System.Drawing.Size(108, 21)
        Me.PriorityComboBox.TabIndex = 12
        '
        'StatusComboBox
        '
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"In Progress", "Complete"})
        Me.StatusComboBox.Location = New System.Drawing.Point(588, 230)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(108, 21)
        Me.StatusComboBox.TabIndex = 13
        '
        'UserDescTextBox
        '
        Me.UserDescTextBox.Location = New System.Drawing.Point(48, 230)
        Me.UserDescTextBox.Multiline = True
        Me.UserDescTextBox.Name = "UserDescTextBox"
        Me.UserDescTextBox.Size = New System.Drawing.Size(253, 191)
        Me.UserDescTextBox.TabIndex = 14
        '
        'RecordUserStoryBtn
        '
        Me.RecordUserStoryBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordUserStoryBtn.Location = New System.Drawing.Point(749, 350)
        Me.RecordUserStoryBtn.Name = "RecordUserStoryBtn"
        Me.RecordUserStoryBtn.Size = New System.Drawing.Size(97, 71)
        Me.RecordUserStoryBtn.TabIndex = 15
        Me.RecordUserStoryBtn.Text = "Record User Story"
        Me.RecordUserStoryBtn.UseVisualStyleBackColor = True
        '
        'UserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 447)
        Me.Controls.Add(Me.RecordUserStoryBtn)
        Me.Controls.Add(Me.UserDescTextBox)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.PriorityComboBox)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.UserRoleComboBox)
        Me.Controls.Add(Me.UserStoryTextbox)
        Me.Controls.Add(Me.StatusLbl)
        Me.Controls.Add(Me.PriorityLbl)
        Me.Controls.Add(Me.EndDateLbl)
        Me.Controls.Add(Me.UserRoleLbl)
        Me.Controls.Add(Me.StartDateLbl)
        Me.Controls.Add(Me.UserStoryDescLbl)
        Me.Controls.Add(Me.UserStoryLbl)
        Me.Name = "UserStory"
        Me.Text = "UserStory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserStoryLbl As Label
    Friend WithEvents UserStoryDescLbl As Label
    Friend WithEvents StartDateLbl As Label
    Friend WithEvents UserRoleLbl As Label
    Friend WithEvents EndDateLbl As Label
    Friend WithEvents PriorityLbl As Label
    Friend WithEvents StatusLbl As Label
    Friend WithEvents UserStoryTextbox As TextBox
    Friend WithEvents UserRoleComboBox As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents PriorityComboBox As ComboBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents UserDescTextBox As TextBox
    Friend WithEvents RecordUserStoryBtn As Button
End Class
