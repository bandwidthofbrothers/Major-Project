<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReport
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
        Dim DataPoint2 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, 0R)
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.TabPageAllTime = New System.Windows.Forms.TabPage()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TabPageMonthly = New System.Windows.Forms.TabPage()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LabelMonthlyProfitLoss = New System.Windows.Forms.Label()
        Me.LabelTextMonthlyProfitLoss = New System.Windows.Forms.Label()
        Me.LabelMonthlyExpenses = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LabelMonthlyIncome = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TabPageDaily = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChartDailyProductivity = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.CustomerOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group22DataSet = New Geetha_Homemade_Curries_POS.group22DataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelLeastSoldProductName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelMostSoldProductName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelProfitLoss = New System.Windows.Forms.Label()
        Me.LabelTextProfitLoss = New System.Windows.Forms.Label()
        Me.LabelExpenses = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelIncome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabAllTime = New System.Windows.Forms.TabControl()
        Me.CustomerOrderTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.CustomerOrderTableAdapter()
        Me.MenuItemTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.MenuItemTableAdapter()
        Me.IngredientTableAdapter = New Geetha_Homemade_Curries_POS.group22DataSetTableAdapters.IngredientTableAdapter()
        Me.TabPageAllTime.SuspendLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.TabPageMonthly.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPageDaily.SuspendLayout()
        CType(Me.ChartDailyProductivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabAllTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar
        '
        Me.MonthCalendar.Location = New System.Drawing.Point(1013, 50)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 0
        '
        'TabPageAllTime
        '
        Me.TabPageAllTime.Controls.Add(Me.Label29)
        Me.TabPageAllTime.Controls.Add(Me.Chart3)
        Me.TabPageAllTime.Controls.Add(Me.GroupBox4)
        Me.TabPageAllTime.Location = New System.Drawing.Point(4, 38)
        Me.TabPageAllTime.Name = "TabPageAllTime"
        Me.TabPageAllTime.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageAllTime.Size = New System.Drawing.Size(930, 618)
        Me.TabPageAllTime.TabIndex = 6
        Me.TabPageAllTime.Text = "All Time"
        Me.TabPageAllTime.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(586, 54)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(136, 29)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Productivity"
        '
        'Chart3
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend1)
        Me.Chart3.Location = New System.Drawing.Point(449, 115)
        Me.Chart3.Name = "Chart3"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart3.Series.Add(Series1)
        Me.Chart3.Size = New System.Drawing.Size(475, 454)
        Me.Chart3.TabIndex = 1
        Me.Chart3.Text = "Chart1"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.Label36)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label39)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(407, 584)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Statistics"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(214, 276)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(136, 25)
        Me.Label30.TabIndex = 9
        Me.Label30.Text = "Product Name"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(11, 276)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(188, 25)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Least Sold Product: "
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(214, 231)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(136, 25)
        Me.Label32.TabIndex = 7
        Me.Label32.Text = "Product Name"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(16, 231)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(183, 25)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Most Sold Product: "
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(138, 150)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 25)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "00,00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(17, 150)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(115, 25)
        Me.Label35.TabIndex = 4
        Me.Label35.Text = "Profit/Loss: "
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(138, 98)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(61, 25)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "00,00"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(17, 98)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(110, 25)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Expenses: "
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(138, 49)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(61, 25)
        Me.Label38.TabIndex = 1
        Me.Label38.Text = "00,00"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(17, 49)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(87, 25)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "Income: "
        '
        'TabPageMonthly
        '
        Me.TabPageMonthly.Controls.Add(Me.Label18)
        Me.TabPageMonthly.Controls.Add(Me.Chart2)
        Me.TabPageMonthly.Controls.Add(Me.GroupBox3)
        Me.TabPageMonthly.Location = New System.Drawing.Point(4, 38)
        Me.TabPageMonthly.Name = "TabPageMonthly"
        Me.TabPageMonthly.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageMonthly.Size = New System.Drawing.Size(930, 618)
        Me.TabPageMonthly.TabIndex = 5
        Me.TabPageMonthly.Text = "Monthly"
        Me.TabPageMonthly.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(586, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 29)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Productivity"
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(449, 115)
        Me.Chart2.Name = "Chart2"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart2.Series.Add(Series2)
        Me.Chart2.Size = New System.Drawing.Size(475, 454)
        Me.Chart2.TabIndex = 1
        Me.Chart2.Text = "ChartMonthyProductivity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.LabelMonthlyProfitLoss)
        Me.GroupBox3.Controls.Add(Me.LabelTextMonthlyProfitLoss)
        Me.GroupBox3.Controls.Add(Me.LabelMonthlyExpenses)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.LabelMonthlyIncome)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(407, 316)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Statistics"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(214, 257)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(136, 25)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Product Name"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(11, 257)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(188, 25)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Least Sold Product: "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(214, 212)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(136, 25)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Product Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(16, 212)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 25)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Most Sold Product: "
        '
        'LabelMonthlyProfitLoss
        '
        Me.LabelMonthlyProfitLoss.AutoSize = True
        Me.LabelMonthlyProfitLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonthlyProfitLoss.Location = New System.Drawing.Point(138, 150)
        Me.LabelMonthlyProfitLoss.Name = "LabelMonthlyProfitLoss"
        Me.LabelMonthlyProfitLoss.Size = New System.Drawing.Size(61, 25)
        Me.LabelMonthlyProfitLoss.TabIndex = 5
        Me.LabelMonthlyProfitLoss.Text = "00,00"
        '
        'LabelTextMonthlyProfitLoss
        '
        Me.LabelTextMonthlyProfitLoss.AutoSize = True
        Me.LabelTextMonthlyProfitLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextMonthlyProfitLoss.Location = New System.Drawing.Point(17, 150)
        Me.LabelTextMonthlyProfitLoss.Name = "LabelTextMonthlyProfitLoss"
        Me.LabelTextMonthlyProfitLoss.Size = New System.Drawing.Size(115, 25)
        Me.LabelTextMonthlyProfitLoss.TabIndex = 4
        Me.LabelTextMonthlyProfitLoss.Text = "Profit/Loss: "
        '
        'LabelMonthlyExpenses
        '
        Me.LabelMonthlyExpenses.AutoSize = True
        Me.LabelMonthlyExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonthlyExpenses.Location = New System.Drawing.Point(138, 98)
        Me.LabelMonthlyExpenses.Name = "LabelMonthlyExpenses"
        Me.LabelMonthlyExpenses.Size = New System.Drawing.Size(61, 25)
        Me.LabelMonthlyExpenses.TabIndex = 3
        Me.LabelMonthlyExpenses.Text = "00,00"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(17, 98)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(110, 25)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Expenses: "
        '
        'LabelMonthlyIncome
        '
        Me.LabelMonthlyIncome.AutoSize = True
        Me.LabelMonthlyIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonthlyIncome.Location = New System.Drawing.Point(138, 49)
        Me.LabelMonthlyIncome.Name = "LabelMonthlyIncome"
        Me.LabelMonthlyIncome.Size = New System.Drawing.Size(61, 25)
        Me.LabelMonthlyIncome.TabIndex = 1
        Me.LabelMonthlyIncome.Text = "00,00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(17, 49)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(87, 25)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Income: "
        '
        'TabPageDaily
        '
        Me.TabPageDaily.Controls.Add(Me.Label2)
        Me.TabPageDaily.Controls.Add(Me.ChartDailyProductivity)
        Me.TabPageDaily.Controls.Add(Me.GroupBox1)
        Me.TabPageDaily.Location = New System.Drawing.Point(4, 38)
        Me.TabPageDaily.Name = "TabPageDaily"
        Me.TabPageDaily.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDaily.Size = New System.Drawing.Size(930, 618)
        Me.TabPageDaily.TabIndex = 0
        Me.TabPageDaily.Text = "Daily"
        Me.TabPageDaily.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(586, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Productivity"
        '
        'ChartDailyProductivity
        '
        ChartArea3.Name = "ChartArea1"
        Me.ChartDailyProductivity.ChartAreas.Add(ChartArea3)
        Me.ChartDailyProductivity.DataSource = Me.CustomerOrderBindingSource
        Legend3.Name = "Legend1"
        Me.ChartDailyProductivity.Legends.Add(Legend3)
        Me.ChartDailyProductivity.Location = New System.Drawing.Point(449, 115)
        Me.ChartDailyProductivity.Name = "ChartDailyProductivity"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Productivity"
        Series3.Points.Add(DataPoint1)
        Series3.Points.Add(DataPoint2)
        Series3.XValueMember = "OrderTime"
        Series3.YValueMembers = "SaleID"
        Me.ChartDailyProductivity.Series.Add(Series3)
        Me.ChartDailyProductivity.Size = New System.Drawing.Size(475, 454)
        Me.ChartDailyProductivity.TabIndex = 1
        Me.ChartDailyProductivity.Text = "ChartProductivity"
        '
        'CustomerOrderBindingSource
        '
        Me.CustomerOrderBindingSource.DataMember = "CustomerOrder"
        Me.CustomerOrderBindingSource.DataSource = Me.Group22DataSet
        '
        'Group22DataSet
        '
        Me.Group22DataSet.DataSetName = "group22DataSet"
        Me.Group22DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelLeastSoldProductName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LabelMostSoldProductName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelProfitLoss)
        Me.GroupBox1.Controls.Add(Me.LabelTextProfitLoss)
        Me.GroupBox1.Controls.Add(Me.LabelExpenses)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LabelIncome)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(407, 584)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statistics"
        '
        'LabelLeastSoldProductName
        '
        Me.LabelLeastSoldProductName.AutoSize = True
        Me.LabelLeastSoldProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLeastSoldProductName.Location = New System.Drawing.Point(214, 276)
        Me.LabelLeastSoldProductName.Name = "LabelLeastSoldProductName"
        Me.LabelLeastSoldProductName.Size = New System.Drawing.Size(136, 25)
        Me.LabelLeastSoldProductName.TabIndex = 9
        Me.LabelLeastSoldProductName.Text = "Product Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Least Sold Product: "
        '
        'LabelMostSoldProductName
        '
        Me.LabelMostSoldProductName.AutoSize = True
        Me.LabelMostSoldProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMostSoldProductName.Location = New System.Drawing.Point(214, 231)
        Me.LabelMostSoldProductName.Name = "LabelMostSoldProductName"
        Me.LabelMostSoldProductName.Size = New System.Drawing.Size(136, 25)
        Me.LabelMostSoldProductName.TabIndex = 7
        Me.LabelMostSoldProductName.Text = "Product Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Most Sold Product: "
        '
        'LabelProfitLoss
        '
        Me.LabelProfitLoss.AutoSize = True
        Me.LabelProfitLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProfitLoss.Location = New System.Drawing.Point(138, 150)
        Me.LabelProfitLoss.Name = "LabelProfitLoss"
        Me.LabelProfitLoss.Size = New System.Drawing.Size(61, 25)
        Me.LabelProfitLoss.TabIndex = 5
        Me.LabelProfitLoss.Text = "00,00"
        '
        'LabelTextProfitLoss
        '
        Me.LabelTextProfitLoss.AutoSize = True
        Me.LabelTextProfitLoss.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTextProfitLoss.Location = New System.Drawing.Point(17, 150)
        Me.LabelTextProfitLoss.Name = "LabelTextProfitLoss"
        Me.LabelTextProfitLoss.Size = New System.Drawing.Size(115, 25)
        Me.LabelTextProfitLoss.TabIndex = 4
        Me.LabelTextProfitLoss.Text = "Profit/Loss: "
        '
        'LabelExpenses
        '
        Me.LabelExpenses.AutoSize = True
        Me.LabelExpenses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExpenses.Location = New System.Drawing.Point(138, 98)
        Me.LabelExpenses.Name = "LabelExpenses"
        Me.LabelExpenses.Size = New System.Drawing.Size(61, 25)
        Me.LabelExpenses.TabIndex = 3
        Me.LabelExpenses.Text = "00,00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Expenses: "
        '
        'LabelIncome
        '
        Me.LabelIncome.AutoSize = True
        Me.LabelIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIncome.Location = New System.Drawing.Point(138, 49)
        Me.LabelIncome.Name = "LabelIncome"
        Me.LabelIncome.Size = New System.Drawing.Size(61, 25)
        Me.LabelIncome.TabIndex = 1
        Me.LabelIncome.Text = "00,00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Income: "
        '
        'TabAllTime
        '
        Me.TabAllTime.Controls.Add(Me.TabPageDaily)
        Me.TabAllTime.Controls.Add(Me.TabPageMonthly)
        Me.TabAllTime.Controls.Add(Me.TabPageAllTime)
        Me.TabAllTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabAllTime.Location = New System.Drawing.Point(12, 12)
        Me.TabAllTime.Name = "TabAllTime"
        Me.TabAllTime.SelectedIndex = 0
        Me.TabAllTime.Size = New System.Drawing.Size(938, 660)
        Me.TabAllTime.TabIndex = 1
        '
        'CustomerOrderTableAdapter
        '
        Me.CustomerOrderTableAdapter.ClearBeforeFill = True
        '
        'MenuItemTableAdapter
        '
        Me.MenuItemTableAdapter.ClearBeforeFill = True
        '
        'IngredientTableAdapter
        '
        Me.IngredientTableAdapter.ClearBeforeFill = True
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Geetha_Homemade_Curries_POS.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(1325, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabAllTime)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Name = "FormReport"
        Me.Text = "Reports"
        Me.TabPageAllTime.ResumeLayout(False)
        Me.TabPageAllTime.PerformLayout()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPageMonthly.ResumeLayout(False)
        Me.TabPageMonthly.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPageDaily.ResumeLayout(False)
        Me.TabPageDaily.PerformLayout()
        CType(Me.ChartDailyProductivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group22DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabAllTime.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents CustomerOrderTableAdapter As group22DataSetTableAdapters.CustomerOrderTableAdapter
    Friend WithEvents MenuItemTableAdapter As group22DataSetTableAdapters.MenuItemTableAdapter
    Friend WithEvents IngredientTableAdapter As group22DataSetTableAdapters.IngredientTableAdapter
    Friend WithEvents Group22DataSet As group22DataSet
    Friend WithEvents CustomerOrderBindingSource As BindingSource
    Friend WithEvents TabPageAllTime As TabPage
    Friend WithEvents Label29 As Label
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents TabPageMonthly As TabPage
    Friend WithEvents Label18 As Label
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents LabelMonthlyProfitLoss As Label
    Friend WithEvents LabelTextMonthlyProfitLoss As Label
    Friend WithEvents LabelMonthlyExpenses As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents LabelMonthlyIncome As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents TabPageDaily As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents ChartDailyProductivity As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelLeastSoldProductName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelMostSoldProductName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelProfitLoss As Label
    Friend WithEvents LabelTextProfitLoss As Label
    Friend WithEvents LabelExpenses As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelIncome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabAllTime As TabControl
End Class
