<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.Group22DataSet = New Geetha_Homemade_Curries_POS.group22DataSet()
        Me.EmployeeTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.EmployeeTableAdapter()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxLogo.Location = New System.Drawing.Point(80, 15)
        Me.PictureBoxLogo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(231, 151)
        Me.PictureBoxLogo.TabIndex = 0
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.BackColor = System.Drawing.Color.Transparent
        Me.LabelUsername.ForeColor = System.Drawing.Color.White
        Me.LabelUsername.Location = New System.Drawing.Point(15, 201)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(91, 20)
        Me.LabelUsername.TabIndex = 1
        Me.LabelUsername.Text = "Username: "
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.ForeColor = System.Drawing.Color.White
        Me.LabelPassword.Location = New System.Drawing.Point(15, 270)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(86, 20)
        Me.LabelPassword.TabIndex = 2
        Me.LabelPassword.Text = "Password: "
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(112, 201)
        Me.TextBoxUserName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(249, 26)
        Me.TextBoxUserName.TabIndex = 3
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(112, 270)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(249, 26)
        Me.TextBoxPassword.TabIndex = 4
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonLogin.Location = New System.Drawing.Point(80, 348)
        Me.ButtonLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(231, 55)
        Me.ButtonLogin.TabIndex = 5
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'Group22DataSet
        '
        Me.Group22DataSet.DataSetName = "group22DataSet"
        Me.Group22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(398, 456)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUserName)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents EmployeeTableAdapter As group22DataSetTableAdapters.EmployeeTableAdapter
End Class
