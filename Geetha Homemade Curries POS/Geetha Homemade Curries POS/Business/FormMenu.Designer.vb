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
        Me.UpdateBtn.Location = New System.Drawing.Point(864, 379)
        Me.UpdateBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(116, 30)
        Me.UpdateBtn.TabIndex = 34
        Me.UpdateBtn.Text = "Update Item"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(684, 205)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Price "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(684, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(685, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(683, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = " Item ID"
        '
        'PriceTxtbox
        '
        Me.PriceTxtbox.Location = New System.Drawing.Point(688, 225)
        Me.PriceTxtbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PriceTxtbox.Name = "PriceTxtbox"
        Me.PriceTxtbox.Size = New System.Drawing.Size(203, 22)
        Me.PriceTxtbox.TabIndex = 25
        '
        'NameTxtbox
        '
        Me.NameTxtbox.Location = New System.Drawing.Point(687, 105)
        Me.NameTxtbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameTxtbox.Name = "NameTxtbox"
        Me.NameTxtbox.Size = New System.Drawing.Size(253, 22)
        Me.NameTxtbox.TabIndex = 21
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(689, 379)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(116, 30)
        Me.AddBtn.TabIndex = 20
        Me.AddBtn.Text = "Add Item"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'ItemTxtbox
        '
        Me.ItemTxtbox.Enabled = False
        Me.ItemTxtbox.Location = New System.Drawing.Point(687, 57)
        Me.ItemTxtbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ItemTxtbox.Name = "ItemTxtbox"
        Me.ItemTxtbox.Size = New System.Drawing.Size(88, 22)
        Me.ItemTxtbox.TabIndex = 19
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(212, 379)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(119, 32)
        Me.DeleteBtn.TabIndex = 35
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 57)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(607, 255)
        Me.DataGridView1.TabIndex = 36
        '
        'CategoryTxtbox
        '
        Me.CategoryTxtbox.Location = New System.Drawing.Point(686, 163)
        Me.CategoryTxtbox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CategoryTxtbox.Name = "CategoryTxtbox"
        Me.CategoryTxtbox.Size = New System.Drawing.Size(203, 22)
        Me.CategoryTxtbox.TabIndex = 37
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 443)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
