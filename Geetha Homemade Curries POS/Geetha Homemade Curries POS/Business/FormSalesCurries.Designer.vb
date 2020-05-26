<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesCurries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesCurries))
        Me.PictureBoxVegCurries = New System.Windows.Forms.PictureBox()
        Me.PictureBoxNonVegCurries = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBoxVegCurries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxNonVegCurries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxVegCurries
        '
        Me.PictureBoxVegCurries.BackgroundImage = CType(resources.GetObject("PictureBoxVegCurries.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxVegCurries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxVegCurries.Location = New System.Drawing.Point(196, 169)
        Me.PictureBoxVegCurries.Name = "PictureBoxVegCurries"
        Me.PictureBoxVegCurries.Size = New System.Drawing.Size(176, 166)
        Me.PictureBoxVegCurries.TabIndex = 0
        Me.PictureBoxVegCurries.TabStop = False
        '
        'PictureBoxNonVegCurries
        '
        Me.PictureBoxNonVegCurries.BackgroundImage = CType(resources.GetObject("PictureBoxNonVegCurries.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxNonVegCurries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxNonVegCurries.Location = New System.Drawing.Point(453, 169)
        Me.PictureBoxNonVegCurries.Name = "PictureBoxNonVegCurries"
        Me.PictureBoxNonVegCurries.Size = New System.Drawing.Size(176, 166)
        Me.PictureBoxNonVegCurries.TabIndex = 1
        Me.PictureBoxNonVegCurries.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Veg Curries"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(490, 338)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Non-Veg Curries"
        '
        'FormSalesCurries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 577)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxNonVegCurries)
        Me.Controls.Add(Me.PictureBoxVegCurries)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSalesCurries"
        Me.Text = "FormSalesCurriesvb"
        CType(Me.PictureBoxVegCurries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxNonVegCurries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBoxVegCurries As PictureBox
    Friend WithEvents PictureBoxNonVegCurries As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
