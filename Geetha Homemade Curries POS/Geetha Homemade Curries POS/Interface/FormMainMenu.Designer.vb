﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMainMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.AccessControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpensesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTipLogin = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ToolTipSales = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonSale = New System.Windows.Forms.Button()
        Me.ToolTipMenu = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonMenu = New System.Windows.Forms.Button()
        Me.ToolTipAccounts = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonAccounts = New System.Windows.Forms.Button()
        Me.ToolTipExpenses = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonExpenses = New System.Windows.Forms.Button()
        Me.ToolTipExit = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.ToolTipReports = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonReports = New System.Windows.Forms.Button()
        Me.ToolTipStaff = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonStaff = New System.Windows.Forms.Button()
        Me.ToolTipHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtonHelp = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccessControlToolStripMenuItem, Me.SaleToolStripMenuItem, Me.MenuToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.ExpensesToolStripMenuItem, Me.StaffToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1533, 28)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip"
        '
        'AccessControlToolStripMenuItem
        '
        Me.AccessControlToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.AccessControlToolStripMenuItem.Name = "AccessControlToolStripMenuItem"
        Me.AccessControlToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.AccessControlToolStripMenuItem.Text = "Access Control"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(121, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(121, 26)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.Enabled = False
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.SaleToolStripMenuItem.Text = "Sale"
        Me.SaleToolStripMenuItem.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Enabled = False
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        Me.MenuToolStripMenuItem.Visible = False
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Enabled = False
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        Me.ReportsToolStripMenuItem.Visible = False
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Enabled = False
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        Me.AccountsToolStripMenuItem.Visible = False
        '
        'ExpensesToolStripMenuItem
        '
        Me.ExpensesToolStripMenuItem.Enabled = False
        Me.ExpensesToolStripMenuItem.Name = "ExpensesToolStripMenuItem"
        Me.ExpensesToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.ExpensesToolStripMenuItem.Text = "Expenses"
        Me.ExpensesToolStripMenuItem.Visible = False
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.Enabled = False
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.StaffToolStripMenuItem.Text = "Staff"
        Me.StaffToolStripMenuItem.Visible = False
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolTipLogin
        '
        Me.ToolTipLogin.Tag = ""
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackgroundImage = CType(resources.GetObject("ButtonLogin.BackgroundImage"), System.Drawing.Image)
        Me.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Location = New System.Drawing.Point(1331, 31)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(202, 91)
        Me.ButtonLogin.TabIndex = 3
        Me.ToolTipLogin.SetToolTip(Me.ButtonLogin, "Login")
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonSale
        '
        Me.ButtonSale.BackgroundImage = CType(resources.GetObject("ButtonSale.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSale.Enabled = False
        Me.ButtonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSale.Location = New System.Drawing.Point(1331, 119)
        Me.ButtonSale.Name = "ButtonSale"
        Me.ButtonSale.Size = New System.Drawing.Size(202, 91)
        Me.ButtonSale.TabIndex = 4
        Me.ToolTipSales.SetToolTip(Me.ButtonSale, "Sales")
        Me.ButtonSale.UseVisualStyleBackColor = True
        Me.ButtonSale.Visible = False
        '
        'ButtonMenu
        '
        Me.ButtonMenu.BackgroundImage = CType(resources.GetObject("ButtonMenu.BackgroundImage"), System.Drawing.Image)
        Me.ButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonMenu.Enabled = False
        Me.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMenu.Location = New System.Drawing.Point(1331, 205)
        Me.ButtonMenu.Name = "ButtonMenu"
        Me.ButtonMenu.Size = New System.Drawing.Size(202, 91)
        Me.ButtonMenu.TabIndex = 6
        Me.ToolTipMenu.SetToolTip(Me.ButtonMenu, "Menu")
        Me.ButtonMenu.UseVisualStyleBackColor = True
        Me.ButtonMenu.Visible = False
        '
        'ButtonAccounts
        '
        Me.ButtonAccounts.BackgroundImage = CType(resources.GetObject("ButtonAccounts.BackgroundImage"), System.Drawing.Image)
        Me.ButtonAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonAccounts.Enabled = False
        Me.ButtonAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAccounts.Location = New System.Drawing.Point(1331, 380)
        Me.ButtonAccounts.Name = "ButtonAccounts"
        Me.ButtonAccounts.Size = New System.Drawing.Size(202, 91)
        Me.ButtonAccounts.TabIndex = 7
        Me.ToolTipAccounts.SetToolTip(Me.ButtonAccounts, "Accounts")
        Me.ButtonAccounts.UseVisualStyleBackColor = True
        Me.ButtonAccounts.Visible = False
        '
        'ButtonExpenses
        '
        Me.ButtonExpenses.BackgroundImage = CType(resources.GetObject("ButtonExpenses.BackgroundImage"), System.Drawing.Image)
        Me.ButtonExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonExpenses.Enabled = False
        Me.ButtonExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExpenses.Location = New System.Drawing.Point(1331, 468)
        Me.ButtonExpenses.Name = "ButtonExpenses"
        Me.ButtonExpenses.Size = New System.Drawing.Size(202, 91)
        Me.ButtonExpenses.TabIndex = 11
        Me.ToolTipExpenses.SetToolTip(Me.ButtonExpenses, "Expenses")
        Me.ButtonExpenses.UseVisualStyleBackColor = True
        Me.ButtonExpenses.Visible = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackgroundImage = CType(resources.GetObject("ButtonExit.BackgroundImage"), System.Drawing.Image)
        Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExit.Location = New System.Drawing.Point(1331, 729)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(202, 91)
        Me.ButtonExit.TabIndex = 9
        Me.ToolTipExit.SetToolTip(Me.ButtonExit, "Exit")
        Me.ButtonExit.UseVisualStyleBackColor = True
        '
        'ButtonReports
        '
        Me.ButtonReports.BackgroundImage = CType(resources.GetObject("ButtonReports.BackgroundImage"), System.Drawing.Image)
        Me.ButtonReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonReports.Enabled = False
        Me.ButtonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReports.Location = New System.Drawing.Point(1331, 292)
        Me.ButtonReports.Name = "ButtonReports"
        Me.ButtonReports.Size = New System.Drawing.Size(202, 91)
        Me.ButtonReports.TabIndex = 5
        Me.ToolTipReports.SetToolTip(Me.ButtonReports, "Reports")
        Me.ButtonReports.UseVisualStyleBackColor = True
        Me.ButtonReports.Visible = False
        '
        'ButtonStaff
        '
        Me.ButtonStaff.BackgroundImage = CType(resources.GetObject("ButtonStaff.BackgroundImage"), System.Drawing.Image)
        Me.ButtonStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonStaff.Enabled = False
        Me.ButtonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStaff.Location = New System.Drawing.Point(1331, 556)
        Me.ButtonStaff.Name = "ButtonStaff"
        Me.ButtonStaff.Size = New System.Drawing.Size(202, 91)
        Me.ButtonStaff.TabIndex = 13
        Me.ToolTipStaff.SetToolTip(Me.ButtonStaff, "Staff")
        Me.ButtonStaff.UseVisualStyleBackColor = True
        Me.ButtonStaff.Visible = False
        '
        'ButtonHelp
        '
        Me.ButtonHelp.BackgroundImage = CType(resources.GetObject("ButtonHelp.BackgroundImage"), System.Drawing.Image)
        Me.ButtonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHelp.Location = New System.Drawing.Point(1331, 641)
        Me.ButtonHelp.Name = "ButtonHelp"
        Me.ButtonHelp.Size = New System.Drawing.Size(202, 91)
        Me.ButtonHelp.TabIndex = 15
        Me.ToolTipHelp.SetToolTip(Me.ButtonHelp, "Help")
        Me.ButtonHelp.UseVisualStyleBackColor = True
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1533, 823)
        Me.Controls.Add(Me.ButtonHelp)
        Me.Controls.Add(Me.ButtonStaff)
        Me.Controls.Add(Me.ButtonExpenses)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonAccounts)
        Me.Controls.Add(Me.ButtonMenu)
        Me.Controls.Add(Me.ButtonReports)
        Me.Controls.Add(Me.ButtonSale)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Geetha's Homemade Curries Point of Sales System"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents AccessControlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonSale As Button
    Friend WithEvents ButtonReports As Button
    Friend WithEvents ButtonMenu As Button
    Friend WithEvents ButtonAccounts As Button
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonExit As Button
    Friend WithEvents ExpensesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonExpenses As Button
    Friend WithEvents ToolTipLogin As ToolTip
    Friend WithEvents ToolTipSales As ToolTip
    Friend WithEvents ToolTipMenu As ToolTip
    Friend WithEvents ToolTipAccounts As ToolTip
    Friend WithEvents ToolTipExit As ToolTip
    Friend WithEvents ToolTipExpenses As ToolTip
    Friend WithEvents ToolTipReports As ToolTip
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonStaff As Button
    Friend WithEvents ToolTipStaff As ToolTip
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonHelp As Button
    Friend WithEvents ToolTipHelp As ToolTip
End Class
