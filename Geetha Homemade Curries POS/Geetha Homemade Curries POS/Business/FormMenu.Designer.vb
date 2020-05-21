<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
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
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PriceTxtbox = New System.Windows.Forms.TextBox()
        Me.NameTxtbox = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.ItemTxtbox = New System.Windows.Forms.TextBox()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CategoryTxtbox = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(648, 308)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(87, 24)
        Me.UpdateBtn.TabIndex = 34
        Me.UpdateBtn.Text = "Update Item"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(513, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Price "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(513, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(514, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(512, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = " Item ID"
        '
        'PriceTxtbox
        '
        Me.PriceTxtbox.Location = New System.Drawing.Point(516, 183)
        Me.PriceTxtbox.Name = "PriceTxtbox"
        Me.PriceTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.PriceTxtbox.TabIndex = 25
        '
        'NameTxtbox
        '
        Me.NameTxtbox.Location = New System.Drawing.Point(515, 85)
        Me.NameTxtbox.Name = "NameTxtbox"
        Me.NameTxtbox.Size = New System.Drawing.Size(191, 20)
        Me.NameTxtbox.TabIndex = 21
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(517, 308)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(87, 24)
        Me.AddBtn.TabIndex = 20
        Me.AddBtn.Text = "Add Item"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ItemTxtbox
        '
        Me.ItemTxtbox.Location = New System.Drawing.Point(515, 46)
        Me.ItemTxtbox.Name = "ItemTxtbox"
        Me.ItemTxtbox.Size = New System.Drawing.Size(67, 20)
        Me.ItemTxtbox.TabIndex = 19
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(159, 308)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(89, 26)
        Me.DeleteBtn.TabIndex = 35
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(455, 207)
        Me.DataGridView1.TabIndex = 36
        '
        'CategoryTxtbox
        '
        Me.CategoryTxtbox.Location = New System.Drawing.Point(514, 132)
        Me.CategoryTxtbox.Name = "CategoryTxtbox"
        Me.CategoryTxtbox.Size = New System.Drawing.Size(153, 20)
        Me.CategoryTxtbox.TabIndex = 37
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 360)
        Me.Controls.Add(Me.CategoryTxtbox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PriceTxtbox)
        Me.Controls.Add(Me.NameTxtbox)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ItemTxtbox)
        Me.Name = "FormMenu"
        Me.Text = "Menu"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PriceTxtbox As TextBox
    Friend WithEvents NameTxtbox As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents ItemTxtbox As TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CategoryTxtbox As TextBox
End Class
