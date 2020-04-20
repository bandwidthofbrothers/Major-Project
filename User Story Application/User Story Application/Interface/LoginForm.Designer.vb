<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.DataSetUserStory = New User_Story_Application.DataSet()
        Me.MemberTableAdapter = New User_Story_Application.DataSetTableAdapters.MemberTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetUserStory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 46)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 218)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(316, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(316, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(315, 82)
        Me.TextBoxUserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxUserName.TabIndex = 3
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(315, 170)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(186, 22)
        Me.TextBoxPassword.TabIndex = 4
        '
        'ButtonLogin
        '
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Location = New System.Drawing.Point(315, 235)
        Me.ButtonLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(93, 32)
        Me.ButtonLogin.TabIndex = 5
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Location = New System.Drawing.Point(414, 235)
        Me.ButtonCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(93, 32)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'DataSetUserStory
        '
        Me.DataSetUserStory.DataSetName = "DataSet"
        Me.DataSetUserStory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberTableAdapter
        '
        Me.MemberTableAdapter.ClearBeforeFill = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(557, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetUserStory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents DataSetUserStory As DataSet
    Friend WithEvents MemberTableAdapter As DataSetTableAdapters.MemberTableAdapter
End Class
