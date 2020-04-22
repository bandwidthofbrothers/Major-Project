<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewingUserStory
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
        Me.ViewBtn = New System.Windows.Forms.Button()
        Me.DataSet1 = New User_Story_Application.DataSet()
        Me.UserStory_MemberTableAdapter1 = New User_Story_Application.DataSetTableAdapters.UserStory_MemberTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewBtn
        '
        Me.ViewBtn.Location = New System.Drawing.Point(241, 266)
        Me.ViewBtn.Name = "ViewBtn"
        Me.ViewBtn.Size = New System.Drawing.Size(95, 32)
        Me.ViewBtn.TabIndex = 0
        Me.ViewBtn.Text = "View User Story"
        Me.ViewBtn.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStory_MemberTableAdapter1
        '
        Me.UserStory_MemberTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.DataSet1
        Me.DataGridView1.Location = New System.Drawing.Point(36, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(490, 191)
        Me.DataGridView1.TabIndex = 1
        '
        'ViewingUserStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 400)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ViewBtn)
        Me.Name = "ViewingUserStory"
        Me.Text = "ViewingUserStory"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ViewBtn As Button
    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents UserStory_MemberTableAdapter1 As DataSetTableAdapters.UserStory_MemberTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
End Class
