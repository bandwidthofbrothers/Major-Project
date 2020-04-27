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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.UserStoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet = New User_Story_Application.DataSet()
        Me.UserStoryTableAdapter = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New User_Story_Application.DataSetTableAdapters.TableAdapterManager()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBoxUserRole = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxPriority = New System.Windows.Forms.ComboBox()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.UserStoryBindingSource
        Me.ListBox1.DisplayMember = "UserStoryTitle"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(17, 52)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(282, 580)
        Me.ListBox1.TabIndex = 2
        '
        'UserStoryBindingSource
        '
        Me.UserStoryBindingSource.DataMember = "UserStory"
        Me.UserStoryBindingSource.DataSource = Me.DataSet
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserStoryTableAdapter
        '
        Me.UserStoryTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Story Title:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(387, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(259, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Story Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(387, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "User Role:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(387, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Start Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(387, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "End Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(387, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 29)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Priority:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(387, 482)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 29)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Status:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MemberTableAdapter = Nothing
        Me.TableAdapterManager.TestCasesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = User_Story_Application.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserStory_MemberTableAdapter = Nothing
        Me.TableAdapterManager.UserStoryTableAdapter = Me.UserStoryTableAdapter
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserStoryBindingSource, "UserStoryTitle", True))
        Me.TextBox1.Location = New System.Drawing.Point(677, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(366, 22)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserStoryBindingSource, "UserStoryDescription", True))
        Me.TextBox2.Location = New System.Drawing.Point(677, 137)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(366, 52)
        Me.TextBox2.TabIndex = 15
        '
        'ComboBoxUserRole
        '
        Me.ComboBoxUserRole.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserStoryBindingSource, "UserRole", True))
        Me.ComboBoxUserRole.FormattingEnabled = True
        Me.ComboBoxUserRole.Items.AddRange(New Object() {"Manager", "Cashier"})
        Me.ComboBoxUserRole.Location = New System.Drawing.Point(677, 212)
        Me.ComboBoxUserRole.Name = "ComboBoxUserRole"
        Me.ComboBoxUserRole.Size = New System.Drawing.Size(366, 24)
        Me.ComboBoxUserRole.TabIndex = 16
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.CustomFormat = "dd MMMM yyyy"
        Me.DateTimePickerStartDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserStoryBindingSource, "UserStoryStartDate", True))
        Me.DateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(677, 278)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(366, 22)
        Me.DateTimePickerStartDate.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserStoryBindingSource, "UserStoryEndDate", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(677, 352)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(366, 22)
        Me.DateTimePicker1.TabIndex = 18
        '
        'ComboBoxPriority
        '
        Me.ComboBoxPriority.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserStoryBindingSource, "UserStoryPriority", True))
        Me.ComboBoxPriority.FormattingEnabled = True
        Me.ComboBoxPriority.Items.AddRange(New Object() {"High" & Global.Microsoft.VisualBasic.ChrW(9), "Medium", "Low"})
        Me.ComboBoxPriority.Location = New System.Drawing.Point(677, 420)
        Me.ComboBoxPriority.Name = "ComboBoxPriority"
        Me.ComboBoxPriority.Size = New System.Drawing.Size(366, 24)
        Me.ComboBoxPriority.TabIndex = 19
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserStoryBindingSource, "UserStoryStatus", True))
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(677, 489)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(366, 24)
        Me.ComboBoxStatus.TabIndex = 20
        '
        'EditUserStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1140, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.ComboBoxPriority)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DateTimePickerStartDate)
        Me.Controls.Add(Me.ComboBoxUserRole)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditUserStoryForm"
        Me.Text = "EditUserStoryForm"
        CType(Me.UserStoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataSet As DataSet
    Friend WithEvents UserStoryBindingSource As BindingSource
    Friend WithEvents UserStoryTableAdapter As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBoxUserRole As ComboBox
    Friend WithEvents DateTimePickerStartDate As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBoxPriority As ComboBox
    Friend WithEvents ComboBoxStatus As ComboBox
End Class
