<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSalesDishes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSalesDishes))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxNonVegDishes = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVegDishes = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxNonVegDishes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVegDishes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(465, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Non-Veg Dishes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 359)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Veg Dishes"
        '
        'PictureBoxNonVegDishes
        '
        Me.PictureBoxNonVegDishes.BackgroundImage = CType(resources.GetObject("PictureBoxNonVegDishes.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxNonVegDishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxNonVegDishes.Location = New System.Drawing.Point(452, 190)
        Me.PictureBoxNonVegDishes.Name = "PictureBoxNonVegDishes"
        Me.PictureBoxNonVegDishes.Size = New System.Drawing.Size(176, 166)
        Me.PictureBoxNonVegDishes.TabIndex = 5
        Me.PictureBoxNonVegDishes.TabStop = False
        '
        'PictureBoxVegDishes
        '
        Me.PictureBoxVegDishes.BackgroundImage = CType(resources.GetObject("PictureBoxVegDishes.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxVegDishes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBoxVegDishes.Location = New System.Drawing.Point(195, 190)
        Me.PictureBoxVegDishes.Name = "PictureBoxVegDishes"
        Me.PictureBoxVegDishes.Size = New System.Drawing.Size(176, 166)
        Me.PictureBoxVegDishes.TabIndex = 4
        Me.PictureBoxVegDishes.TabStop = False
        '
        'FormSalesDishes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(782, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxNonVegDishes)
        Me.Controls.Add(Me.PictureBoxVegDishes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSalesDishes"
        Me.Text = "FormSalesDishes"
        CType(Me.PictureBoxNonVegDishes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVegDishes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBoxNonVegDishes As PictureBox
    Friend WithEvents PictureBoxVegDishes As PictureBox
End Class
