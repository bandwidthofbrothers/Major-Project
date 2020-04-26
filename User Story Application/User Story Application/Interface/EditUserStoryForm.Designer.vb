<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditUserStoryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxUserStory = New System.Windows.Forms.ListBox()
        Me.DSUserStory = New User_Story_Application.DataSet()
        Me.TAUserStory = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        CType(Me.DSUserStory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User Story:"
        '
        'ListBoxUserStory
        '
        Me.ListBoxUserStory.FormattingEnabled = True
        Me.ListBoxUserStory.ItemHeight = 16
        Me.ListBoxUserStory.Location = New System.Drawing.Point(17, 51)
        Me.ListBoxUserStory.Name = "ListBoxUserStory"
        Me.ListBoxUserStory.Size = New System.Drawing.Size(311, 548)
        Me.ListBoxUserStory.TabIndex = 2
        Me.ListBoxUserStory.ValueMember = "UserStoryNo"
        '
        'DSUserStory
        '
        Me.DSUserStory.DataSetName = "DataSet"
        Me.DSUserStory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAUserStory
        '
        Me.TAUserStory.ClearBeforeFill = True
        '
        'EditUserStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBoxUserStory)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditUserStoryForm"
        Me.Text = "EditUserStoryForm"
        CType(Me.DSUserStory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxUserStory As ListBox
    Friend WithEvents DSUserStory As DataSet
    Friend WithEvents TAUserStory As DataSetTableAdapters.UserStoryTableAdapter
End Class
