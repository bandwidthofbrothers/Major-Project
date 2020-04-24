<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserStoryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUserStoryTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxUserRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePickerEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxPriority = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxUserStoryDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxStatus = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxNewTestCaseDetail = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxProg1Responsibility = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProg1Name = New System.Windows.Forms.ComboBox()
        Me.BSProg1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSUserStory = New User_Story_Application.DataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxProg2Responsibility = New System.Windows.Forms.ComboBox()
        Me.ComboBoxProg2Name = New System.Windows.Forms.ComboBox()
        Me.BSProg2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ButtonRecordUserStory = New System.Windows.Forms.Button()
        Me.TAMember = New User_Story_Application.DataSetTableAdapters.MemberTableAdapter()
        Me.TAUserStory = New User_Story_Application.DataSetTableAdapters.UserStoryTableAdapter()
        Me.TAUserMember = New User_Story_Application.DataSetTableAdapters.UserStory_MemberTableAdapter()
        Me.ListBoxNewTestCaseDetails = New System.Windows.Forms.ListBox()
        Me.TATestCase = New User_Story_Application.DataSetTableAdapters.TestCasesTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BSProg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSUserStory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BSProg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Story Title"
        '
        'TextBoxUserStoryTitle
        '
        Me.TextBoxUserStoryTitle.Location = New System.Drawing.Point(18, 58)
        Me.TextBoxUserStoryTitle.Multiline = True
        Me.TextBoxUserStoryTitle.Name = "TextBoxUserStoryTitle"
        Me.TextBoxUserStoryTitle.Size = New System.Drawing.Size(287, 65)
        Me.TextBoxUserStoryTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(352, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Role"
        '
        'ComboBoxUserRole
        '
        Me.ComboBoxUserRole.FormattingEnabled = True
        Me.ComboBoxUserRole.Items.AddRange(New Object() {"Manager", "Cashier"})
        Me.ComboBoxUserRole.Location = New System.Drawing.Point(357, 58)
        Me.ComboBoxUserRole.Name = "ComboBoxUserRole"
        Me.ComboBoxUserRole.Size = New System.Drawing.Size(178, 24)
        Me.ComboBoxUserRole.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(569, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Start Date"
        '
        'DateTimePickerStartDate
        '
        Me.DateTimePickerStartDate.CustomFormat = "dd/mm/yyyy"
        Me.DateTimePickerStartDate.Location = New System.Drawing.Point(574, 56)
        Me.DateTimePickerStartDate.Name = "DateTimePickerStartDate"
        Me.DateTimePickerStartDate.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerStartDate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(793, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "End Date"
        '
        'DateTimePickerEndDate
        '
        Me.DateTimePickerEndDate.CustomFormat = "dd/mm/yyyy"
        Me.DateTimePickerEndDate.Location = New System.Drawing.Point(798, 56)
        Me.DateTimePickerEndDate.Name = "DateTimePickerEndDate"
        Me.DateTimePickerEndDate.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePickerEndDate.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1010, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 29)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Priority"
        '
        'ComboBoxPriority
        '
        Me.ComboBoxPriority.FormattingEnabled = True
        Me.ComboBoxPriority.Items.AddRange(New Object() {"High" & Global.Microsoft.VisualBasic.ChrW(9), "Medium", "Low"})
        Me.ComboBoxPriority.Location = New System.Drawing.Point(1015, 54)
        Me.ComboBoxPriority.Name = "ComboBoxPriority"
        Me.ComboBoxPriority.Size = New System.Drawing.Size(178, 24)
        Me.ComboBoxPriority.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(253, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "User Story Description"
        '
        'TextBoxUserStoryDescription
        '
        Me.TextBoxUserStoryDescription.Location = New System.Drawing.Point(31, 198)
        Me.TextBoxUserStoryDescription.Multiline = True
        Me.TextBoxUserStoryDescription.Name = "TextBoxUserStoryDescription"
        Me.TextBoxUserStoryDescription.Size = New System.Drawing.Size(287, 252)
        Me.TextBoxUserStoryDescription.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1010, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 29)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Status"
        '
        'ComboBoxStatus
        '
        Me.ComboBoxStatus.FormattingEnabled = True
        Me.ComboBoxStatus.Items.AddRange(New Object() {"Complete", "Incomplete"})
        Me.ComboBoxStatus.Location = New System.Drawing.Point(1015, 198)
        Me.ComboBoxStatus.Name = "ComboBoxStatus"
        Me.ComboBoxStatus.Size = New System.Drawing.Size(178, 24)
        Me.ComboBoxStatus.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(352, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(247, 29)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "New Test Case Detail"
        '
        'TextBoxNewTestCaseDetail
        '
        Me.TextBoxNewTestCaseDetail.Location = New System.Drawing.Point(357, 198)
        Me.TextBoxNewTestCaseDetail.Multiline = True
        Me.TextBoxNewTestCaseDetail.Name = "TextBoxNewTestCaseDetail"
        Me.TextBoxNewTestCaseDetail.Size = New System.Drawing.Size(610, 76)
        Me.TextBoxNewTestCaseDetail.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 39)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add New Test Case"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(732, 280)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 39)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Remove Test Case"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ComboBoxProg1Responsibility)
        Me.GroupBox1.Controls.Add(Me.ComboBoxProg1Name)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 481)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(435, 100)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Programmer 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(235, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Responsibility"
        '
        'ComboBoxProg1Responsibility
        '
        Me.ComboBoxProg1Responsibility.FormattingEnabled = True
        Me.ComboBoxProg1Responsibility.Items.AddRange(New Object() {"Main" & Global.Microsoft.VisualBasic.ChrW(9), "Sub"})
        Me.ComboBoxProg1Responsibility.Location = New System.Drawing.Point(238, 51)
        Me.ComboBoxProg1Responsibility.Name = "ComboBoxProg1Responsibility"
        Me.ComboBoxProg1Responsibility.Size = New System.Drawing.Size(178, 24)
        Me.ComboBoxProg1Responsibility.TabIndex = 21
        '
        'ComboBoxProg1Name
        '
        Me.ComboBoxProg1Name.DataSource = Me.BSProg1
        Me.ComboBoxProg1Name.DisplayMember = "FirstName"
        Me.ComboBoxProg1Name.FormattingEnabled = True
        Me.ComboBoxProg1Name.Location = New System.Drawing.Point(29, 51)
        Me.ComboBoxProg1Name.Name = "ComboBoxProg1Name"
        Me.ComboBoxProg1Name.Size = New System.Drawing.Size(178, 24)
        Me.ComboBoxProg1Name.TabIndex = 20
        Me.ComboBoxProg1Name.ValueMember = "GroupMemberNo"
        '
        'BSProg1
        '
        Me.BSProg1.DataMember = "Member"
        Me.BSProg1.DataSource = Me.DSUserStory
        '
        'DSUserStory
        '
        Me.DSUserStory.DataSetName = "DataSet"
        Me.DSUserStory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ComboBoxProg2Responsibility)
        Me.GroupBox2.Controls.Add(Me.ComboBoxProg2Name)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(532, 481)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 100)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Programmer 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(235, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Responsibility"
        '
        'ComboBoxProg2Responsibility
        '
        Me.ComboBoxProg2Responsibility.FormattingEnabled = True
        Me.ComboBoxProg2Responsibility.Items.AddRange(New Object() {"Main", "Sub"})
        Me.ComboBoxProg2Responsibility.Location = New System.Drawing.Point(238, 51)
        Me.ComboBoxProg2Responsibility.Name = "ComboBoxProg2Responsibility"
        Me.ComboBoxProg2Responsibility.Size = New System.Drawing.Size(178, 24)
        Me.ComboBoxProg2Responsibility.TabIndex = 21
        '
        'ComboBoxProg2Name
        '
        Me.ComboBoxProg2Name.DataSource = Me.BSProg2
        Me.ComboBoxProg2Name.DisplayMember = "FirstName"
        Me.ComboBoxProg2Name.FormattingEnabled = True
        Me.ComboBoxProg2Name.Location = New System.Drawing.Point(29, 51)
        Me.ComboBoxProg2Name.Name = "ComboBoxProg2Name"
        Me.ComboBoxProg2Name.Size = New System.Drawing.Size(178, 24)
        Me.ComboBoxProg2Name.TabIndex = 20
        Me.ComboBoxProg2Name.ValueMember = "GroupMemberNo"
        '
        'BSProg2
        '
        Me.BSProg2.DataMember = "Member"
        Me.BSProg2.DataSource = Me.DSUserStory
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Name"
        '
        'ButtonRecordUserStory
        '
        Me.ButtonRecordUserStory.Location = New System.Drawing.Point(993, 492)
        Me.ButtonRecordUserStory.Name = "ButtonRecordUserStory"
        Me.ButtonRecordUserStory.Size = New System.Drawing.Size(217, 89)
        Me.ButtonRecordUserStory.TabIndex = 24
        Me.ButtonRecordUserStory.Text = "Record User Story"
        Me.ButtonRecordUserStory.UseVisualStyleBackColor = True
        '
        'TAMember
        '
        Me.TAMember.ClearBeforeFill = True
        '
        'TAUserStory
        '
        Me.TAUserStory.ClearBeforeFill = True
        '
        'TAUserMember
        '
        Me.TAUserMember.ClearBeforeFill = True
        '
        'ListBoxNewTestCaseDetails
        '
        Me.ListBoxNewTestCaseDetails.FormattingEnabled = True
        Me.ListBoxNewTestCaseDetails.ItemHeight = 16
        Me.ListBoxNewTestCaseDetails.Location = New System.Drawing.Point(357, 334)
        Me.ListBoxNewTestCaseDetails.Name = "ListBoxNewTestCaseDetails"
        Me.ListBoxNewTestCaseDetails.Size = New System.Drawing.Size(610, 116)
        Me.ListBoxNewTestCaseDetails.TabIndex = 25
        '
        'TATestCase
        '
        Me.TATestCase.ClearBeforeFill = True
        '
        'UserStoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.ListBoxNewTestCaseDetails)
        Me.Controls.Add(Me.ButtonRecordUserStory)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxNewTestCaseDetail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBoxStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxUserStoryDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxPriority)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimePickerEndDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePickerStartDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxUserRole)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUserStoryTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserStoryForm"
        Me.Text = "UserStoryForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BSProg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSUserStory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BSProg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUserStoryTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxUserRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePickerStartDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePickerEndDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxPriority As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxUserStoryDescription As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxStatus As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxNewTestCaseDetail As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBoxProg1Responsibility As ComboBox
    Friend WithEvents ComboBoxProg1Name As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBoxProg2Responsibility As ComboBox
    Friend WithEvents ComboBoxProg2Name As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonRecordUserStory As Button
    Friend WithEvents TAMember As DataSetTableAdapters.MemberTableAdapter
    Friend WithEvents DSUserStory As DataSet
    Friend WithEvents BSProg1 As BindingSource
    Friend WithEvents BSProg2 As BindingSource
    Friend WithEvents TAUserStory As DataSetTableAdapters.UserStoryTableAdapter
    Friend WithEvents TAUserMember As DataSetTableAdapters.UserStory_MemberTableAdapter
    Friend WithEvents ListBoxNewTestCaseDetails As ListBox
    Friend WithEvents TATestCase As DataSetTableAdapters.TestCasesTableAdapter
End Class
