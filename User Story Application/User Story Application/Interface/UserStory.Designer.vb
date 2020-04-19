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
        Me.PriorityLbl.Location = New System.Drawing.Point(301, 170)
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
        'UserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 376)
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
End Class
