<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesDrinks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesDrinks))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxColdDrinks = New System.Windows.Forms.PictureBox()
        Me.PictureBoxHotDrinks = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxColdDrinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxHotDrinks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(480, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cold Drinks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 341)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hot Drinks"
        '
        'PictureBoxColdDrinks
        '
        Me.PictureBoxColdDrinks.BackgroundImage = CType(resources.GetObject("PictureBoxColdDrinks.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxColdDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxColdDrinks.Location = New System.Drawing.Point(450, 172)
        Me.PictureBoxColdDrinks.Name = "PictureBoxColdDrinks"
        Me.PictureBoxColdDrinks.Size = New System.Drawing.Size(176, 166)
        Me.PictureBoxColdDrinks.TabIndex = 5
        Me.PictureBoxColdDrinks.TabStop = False
        '
        'PictureBoxHotDrinks
        '
        Me.PictureBoxHotDrinks.BackgroundImage = CType(resources.GetObject("PictureBoxHotDrinks.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxHotDrinks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxHotDrinks.Location = New System.Drawing.Point(193, 172)
        Me.PictureBoxHotDrinks.Name = "PictureBoxHotDrinks"
        Me.PictureBoxHotDrinks.Size = New System.Drawing.Size(176, 166)
        Me.PictureBoxHotDrinks.TabIndex = 4
        Me.PictureBoxHotDrinks.TabStop = False
        '
        'FormSalesDrinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(791, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxColdDrinks)
        Me.Controls.Add(Me.PictureBoxHotDrinks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSalesDrinks"
        Me.Text = "FormSalesDrinks"
        CType(Me.PictureBoxColdDrinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxHotDrinks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxColdDrinks As PictureBox
    Friend WithEvents PictureBoxHotDrinks As PictureBox
End Class
