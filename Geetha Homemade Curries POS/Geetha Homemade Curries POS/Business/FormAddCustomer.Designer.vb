<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAddCustomer
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
        Me.TextBoxFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAmountDue = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.CustomerTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.CustomerTableAdapter()
        Me.TextBoxAmountCap = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPhysicalAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxFirstName
        '
        Me.TextBoxFirstName.Location = New System.Drawing.Point(218, 43)
        Me.TextBoxFirstName.Name = "TextBoxFirstName"
        Me.TextBoxFirstName.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxFirstName.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name:"
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.Location = New System.Drawing.Point(218, 110)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxSurname.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(41, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Surname:"
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(218, 177)
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxPhoneNumber.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(41, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone Number:"
        '
        'TextBoxAmountDue
        '
        Me.TextBoxAmountDue.Location = New System.Drawing.Point(218, 241)
        Me.TextBoxAmountDue.Name = "TextBoxAmountDue"
        Me.TextBoxAmountDue.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxAmountDue.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(41, 240)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Amount Due:"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(48, 567)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(100, 37)
        Me.ButtonClose.TabIndex = 14
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(221, 567)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(306, 36)
        Me.ButtonAdd.TabIndex = 13
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TextBoxAmountCap
        '
        Me.TextBoxAmountCap.Location = New System.Drawing.Point(218, 311)
        Me.TextBoxAmountCap.Name = "TextBoxAmountCap"
        Me.TextBoxAmountCap.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxAmountCap.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 310)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Amount Cap:"
        '
        'TextBoxPhysicalAddress
        '
        Me.TextBoxPhysicalAddress.Location = New System.Drawing.Point(218, 371)
        Me.TextBoxPhysicalAddress.Name = "TextBoxPhysicalAddress"
        Me.TextBoxPhysicalAddress.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxPhysicalAddress.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(41, 370)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Physical Address:"
        '
        'TextBoxEmailAddress
        '
        Me.TextBoxEmailAddress.Location = New System.Drawing.Point(218, 441)
        Me.TextBoxEmailAddress.Name = "TextBoxEmailAddress"
        Me.TextBoxEmailAddress.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxEmailAddress.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(41, 440)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Email Address:"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(218, 501)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(306, 22)
        Me.TextBoxPassword.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(41, 500)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Password:"
        '
        'FormAddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(600, 646)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxEmailAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxPhysicalAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxAmountCap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.TextBoxAmountDue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxSurname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormAddCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Customer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxSurname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxAmountDue As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonClose As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents CustomerTableAdapter As group22DataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TextBoxAmountCap As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPhysicalAddress As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEmailAddress As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label8 As Label
End Class
