<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePageScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePageScreen))
        Me.QuickAccess = New System.Windows.Forms.GroupBox()
        Me.ReportsPictureBox = New System.Windows.Forms.PictureBox()
        Me.EmployeePictureBox = New System.Windows.Forms.PictureBox()
        Me.CustomersPictureBox = New System.Windows.Forms.PictureBox()
        Me.ReservationsPictureBox = New System.Windows.Forms.PictureBox()
        Me.RoomAvailabilityStatus = New System.Windows.Forms.GroupBox()
        Me.StatusTextBox7 = New System.Windows.Forms.TextBox()
        Me.StatusTextBox6 = New System.Windows.Forms.TextBox()
        Me.StatusTextBox5 = New System.Windows.Forms.TextBox()
        Me.StatusTextBox4 = New System.Windows.Forms.TextBox()
        Me.StatusTextBox3 = New System.Windows.Forms.TextBox()
        Me.StatusTextBox2 = New System.Windows.Forms.TextBox()
        Me.StatusTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoomsAvailableLabel = New System.Windows.Forms.Label()
        Me.RoomSizeLabel = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FileLabel = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ExitLabel = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataLabel = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CustomerMasterLabel = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeMasterLabel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ReportsLabel = New System.Windows.Forms.ToolStripLabel()
        Me.InvoiceToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.AboutLabel = New System.Windows.Forms.ToolStripLabel()
        Me.UserProfileLabel = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpLabel = New System.Windows.Forms.ToolStripLabel()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.LblUserDesig = New System.Windows.Forms.Label()
        Me.QuickAccess.SuspendLayout()
        CType(Me.ReportsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoomAvailabilityStatus.SuspendLayout()
        Me.MenuToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuickAccess
        '
        Me.QuickAccess.Controls.Add(Me.ReportsPictureBox)
        Me.QuickAccess.Controls.Add(Me.EmployeePictureBox)
        Me.QuickAccess.Controls.Add(Me.CustomersPictureBox)
        Me.QuickAccess.Controls.Add(Me.ReservationsPictureBox)
        Me.QuickAccess.Location = New System.Drawing.Point(47, 83)
        Me.QuickAccess.Name = "QuickAccess"
        Me.QuickAccess.Size = New System.Drawing.Size(279, 336)
        Me.QuickAccess.TabIndex = 5
        Me.QuickAccess.TabStop = False
        Me.QuickAccess.Text = "Quick Links"
        '
        'ReportsPictureBox
        '
        Me.ReportsPictureBox.Image = CType(resources.GetObject("ReportsPictureBox.Image"), System.Drawing.Image)
        Me.ReportsPictureBox.Location = New System.Drawing.Point(147, 60)
        Me.ReportsPictureBox.Name = "ReportsPictureBox"
        Me.ReportsPictureBox.Size = New System.Drawing.Size(100, 90)
        Me.ReportsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReportsPictureBox.TabIndex = 3
        Me.ReportsPictureBox.TabStop = False
        '
        'EmployeePictureBox
        '
        Me.EmployeePictureBox.Image = CType(resources.GetObject("EmployeePictureBox.Image"), System.Drawing.Image)
        Me.EmployeePictureBox.Location = New System.Drawing.Point(147, 211)
        Me.EmployeePictureBox.Name = "EmployeePictureBox"
        Me.EmployeePictureBox.Size = New System.Drawing.Size(100, 90)
        Me.EmployeePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmployeePictureBox.TabIndex = 2
        Me.EmployeePictureBox.TabStop = False
        '
        'CustomersPictureBox
        '
        Me.CustomersPictureBox.Image = CType(resources.GetObject("CustomersPictureBox.Image"), System.Drawing.Image)
        Me.CustomersPictureBox.Location = New System.Drawing.Point(20, 211)
        Me.CustomersPictureBox.Name = "CustomersPictureBox"
        Me.CustomersPictureBox.Size = New System.Drawing.Size(100, 90)
        Me.CustomersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CustomersPictureBox.TabIndex = 1
        Me.CustomersPictureBox.TabStop = False
        '
        'ReservationsPictureBox
        '
        Me.ReservationsPictureBox.Image = CType(resources.GetObject("ReservationsPictureBox.Image"), System.Drawing.Image)
        Me.ReservationsPictureBox.Location = New System.Drawing.Point(20, 60)
        Me.ReservationsPictureBox.Name = "ReservationsPictureBox"
        Me.ReservationsPictureBox.Size = New System.Drawing.Size(100, 90)
        Me.ReservationsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ReservationsPictureBox.TabIndex = 0
        Me.ReservationsPictureBox.TabStop = False
        '
        'RoomAvailabilityStatus
        '
        Me.RoomAvailabilityStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RoomAvailabilityStatus.Controls.Add(Me.StatusTextBox7)
        Me.RoomAvailabilityStatus.Controls.Add(Me.StatusTextBox6)
        Me.RoomAvailabilityStatus.Controls.Add(Me.StatusTextBox5)
        Me.RoomAvailabilityStatus.Controls.Add(Me.StatusTextBox4)
        Me.RoomAvailabilityStatus.Controls.Add(Me.StatusTextBox3)
        Me.RoomAvailabilityStatus.Controls.Add(Me.StatusTextBox2)
        Me.RoomAvailabilityStatus.Controls.Add(Me.StatusTextBox1)
        Me.RoomAvailabilityStatus.Controls.Add(Me.Label7)
        Me.RoomAvailabilityStatus.Controls.Add(Me.Label2)
        Me.RoomAvailabilityStatus.Controls.Add(Me.Label1)
        Me.RoomAvailabilityStatus.Controls.Add(Me.Label6)
        Me.RoomAvailabilityStatus.Controls.Add(Me.Label5)
        Me.RoomAvailabilityStatus.Controls.Add(Me.Label4)
        Me.RoomAvailabilityStatus.Controls.Add(Me.Label3)
        Me.RoomAvailabilityStatus.Controls.Add(Me.RoomsAvailableLabel)
        Me.RoomAvailabilityStatus.Controls.Add(Me.RoomSizeLabel)
        Me.RoomAvailabilityStatus.Location = New System.Drawing.Point(363, 84)
        Me.RoomAvailabilityStatus.Name = "RoomAvailabilityStatus"
        Me.RoomAvailabilityStatus.Size = New System.Drawing.Size(305, 337)
        Me.RoomAvailabilityStatus.TabIndex = 6
        Me.RoomAvailabilityStatus.TabStop = False
        Me.RoomAvailabilityStatus.Text = "Room Status"
        '
        'StatusTextBox7
        '
        Me.StatusTextBox7.Enabled = False
        Me.StatusTextBox7.Location = New System.Drawing.Point(180, 299)
        Me.StatusTextBox7.MaxLength = 2
        Me.StatusTextBox7.Name = "StatusTextBox7"
        Me.StatusTextBox7.ReadOnly = True
        Me.StatusTextBox7.Size = New System.Drawing.Size(51, 20)
        Me.StatusTextBox7.TabIndex = 15
        Me.StatusTextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusTextBox6
        '
        Me.StatusTextBox6.Enabled = False
        Me.StatusTextBox6.Location = New System.Drawing.Point(180, 262)
        Me.StatusTextBox6.MaxLength = 2
        Me.StatusTextBox6.Name = "StatusTextBox6"
        Me.StatusTextBox6.ReadOnly = True
        Me.StatusTextBox6.Size = New System.Drawing.Size(51, 20)
        Me.StatusTextBox6.TabIndex = 14
        Me.StatusTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusTextBox5
        '
        Me.StatusTextBox5.Enabled = False
        Me.StatusTextBox5.Location = New System.Drawing.Point(180, 225)
        Me.StatusTextBox5.MaxLength = 2
        Me.StatusTextBox5.Name = "StatusTextBox5"
        Me.StatusTextBox5.ReadOnly = True
        Me.StatusTextBox5.Size = New System.Drawing.Size(51, 20)
        Me.StatusTextBox5.TabIndex = 13
        Me.StatusTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusTextBox4
        '
        Me.StatusTextBox4.Enabled = False
        Me.StatusTextBox4.Location = New System.Drawing.Point(180, 183)
        Me.StatusTextBox4.MaxLength = 2
        Me.StatusTextBox4.Name = "StatusTextBox4"
        Me.StatusTextBox4.ReadOnly = True
        Me.StatusTextBox4.Size = New System.Drawing.Size(51, 20)
        Me.StatusTextBox4.TabIndex = 12
        Me.StatusTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusTextBox3
        '
        Me.StatusTextBox3.Enabled = False
        Me.StatusTextBox3.Location = New System.Drawing.Point(180, 149)
        Me.StatusTextBox3.MaxLength = 2
        Me.StatusTextBox3.Name = "StatusTextBox3"
        Me.StatusTextBox3.ReadOnly = True
        Me.StatusTextBox3.Size = New System.Drawing.Size(51, 20)
        Me.StatusTextBox3.TabIndex = 11
        Me.StatusTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusTextBox2
        '
        Me.StatusTextBox2.Enabled = False
        Me.StatusTextBox2.Location = New System.Drawing.Point(180, 114)
        Me.StatusTextBox2.MaxLength = 2
        Me.StatusTextBox2.Name = "StatusTextBox2"
        Me.StatusTextBox2.ReadOnly = True
        Me.StatusTextBox2.Size = New System.Drawing.Size(51, 20)
        Me.StatusTextBox2.TabIndex = 10
        Me.StatusTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusTextBox1
        '
        Me.StatusTextBox1.Enabled = False
        Me.StatusTextBox1.Location = New System.Drawing.Point(180, 75)
        Me.StatusTextBox1.MaxLength = 2
        Me.StatusTextBox1.Name = "StatusTextBox1"
        Me.StatusTextBox1.ReadOnly = True
        Me.StatusTextBox1.Size = New System.Drawing.Size(51, 20)
        Me.StatusTextBox1.TabIndex = 9
        Me.StatusTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "10 x 30"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "10 x 10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "10 x 25"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "10 x 20"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "10 x 15"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "5 x 10"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "5 x 5"
        '
        'RoomsAvailableLabel
        '
        Me.RoomsAvailableLabel.AutoSize = True
        Me.RoomsAvailableLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomsAvailableLabel.Location = New System.Drawing.Point(155, 45)
        Me.RoomsAvailableLabel.Name = "RoomsAvailableLabel"
        Me.RoomsAvailableLabel.Size = New System.Drawing.Size(101, 13)
        Me.RoomsAvailableLabel.TabIndex = 1
        Me.RoomsAvailableLabel.Text = "Rooms Available"
        '
        'RoomSizeLabel
        '
        Me.RoomSizeLabel.AutoSize = True
        Me.RoomSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomSizeLabel.Location = New System.Drawing.Point(43, 45)
        Me.RoomSizeLabel.Name = "RoomSizeLabel"
        Me.RoomSizeLabel.Size = New System.Drawing.Size(67, 13)
        Me.RoomSizeLabel.TabIndex = 0
        Me.RoomSizeLabel.Text = "Room Size"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 20
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShowShortcutKeys = False
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MenuToolStrip
        '
        Me.MenuToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileLabel, Me.MasterDataLabel, Me.ReservationLabel, Me.ReportsLabel, Me.InvoiceToolStripLabel, Me.AboutLabel, Me.UserProfileLabel, Me.HelpLabel})
        Me.MenuToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuToolStrip.Name = "MenuToolStrip"
        Me.MenuToolStrip.Size = New System.Drawing.Size(719, 25)
        Me.MenuToolStrip.TabIndex = 9
        Me.MenuToolStrip.Text = "ToolStrip"
        '
        'FileLabel
        '
        Me.FileLabel.AutoToolTip = False
        Me.FileLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileLabel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitLabel})
        Me.FileLabel.Name = "FileLabel"
        Me.FileLabel.Size = New System.Drawing.Size(38, 22)
        Me.FileLabel.Text = "File"
        '
        'ExitLabel
        '
        Me.ExitLabel.Name = "ExitLabel"
        Me.ExitLabel.Size = New System.Drawing.Size(92, 22)
        Me.ExitLabel.Text = "Exit"
        '
        'MasterDataLabel
        '
        Me.MasterDataLabel.AutoToolTip = False
        Me.MasterDataLabel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerMasterLabel, Me.EmployeeMasterLabel})
        Me.MasterDataLabel.Name = "MasterDataLabel"
        Me.MasterDataLabel.Size = New System.Drawing.Size(83, 22)
        Me.MasterDataLabel.Text = "Master Data"
        '
        'CustomerMasterLabel
        '
        Me.CustomerMasterLabel.Name = "CustomerMasterLabel"
        Me.CustomerMasterLabel.Size = New System.Drawing.Size(165, 22)
        Me.CustomerMasterLabel.Text = "Customer Master"
        '
        'EmployeeMasterLabel
        '
        Me.EmployeeMasterLabel.Name = "EmployeeMasterLabel"
        Me.EmployeeMasterLabel.Size = New System.Drawing.Size(165, 22)
        Me.EmployeeMasterLabel.Text = "Employee Master"
        '
        'ReservationLabel
        '
        Me.ReservationLabel.Name = "ReservationLabel"
        Me.ReservationLabel.Size = New System.Drawing.Size(73, 22)
        Me.ReservationLabel.Text = "Reservations"
        '
        'ReportsLabel
        '
        Me.ReportsLabel.Name = "ReportsLabel"
        Me.ReportsLabel.Size = New System.Drawing.Size(47, 22)
        Me.ReportsLabel.Text = "Reports"
        '
        'InvoiceToolStripLabel
        '
        Me.InvoiceToolStripLabel.Name = "InvoiceToolStripLabel"
        Me.InvoiceToolStripLabel.Size = New System.Drawing.Size(45, 22)
        Me.InvoiceToolStripLabel.Text = "Invoice"
        '
        'AboutLabel
        '
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(56, 22)
        Me.AboutLabel.Text = "About Us"
        '
        'UserProfileLabel
        '
        Me.UserProfileLabel.AutoToolTip = False
        Me.UserProfileLabel.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem})
        Me.UserProfileLabel.Name = "UserProfileLabel"
        Me.UserProfileLabel.Size = New System.Drawing.Size(77, 22)
        Me.UserProfileLabel.Text = "UserProfile"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'HelpLabel
        '
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(32, 22)
        Me.HelpLabel.Text = "Help"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(616, 28)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 69
        Me.HomeButton.Text = "&Logout"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(269, 30)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(0, 24)
        Me.LblUserName.TabIndex = 70
        '
        'LblUserDesig
        '
        Me.LblUserDesig.AutoSize = True
        Me.LblUserDesig.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserDesig.Location = New System.Drawing.Point(291, 53)
        Me.LblUserDesig.Name = "LblUserDesig"
        Me.LblUserDesig.Size = New System.Drawing.Size(0, 18)
        Me.LblUserDesig.TabIndex = 71
        Me.LblUserDesig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HomePageScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 480)
        Me.Controls.Add(Me.LblUserDesig)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.MenuToolStrip)
        Me.Controls.Add(Me.QuickAccess)
        Me.Controls.Add(Me.RoomAvailabilityStatus)
        Me.MaximizeBox = False
        Me.Name = "HomePageScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.QuickAccess.ResumeLayout(False)
        CType(Me.ReportsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoomAvailabilityStatus.ResumeLayout(False)
        Me.RoomAvailabilityStatus.PerformLayout()
        Me.MenuToolStrip.ResumeLayout(False)
        Me.MenuToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuickAccess As System.Windows.Forms.GroupBox
    Friend WithEvents ReportsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents EmployeePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents CustomersPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ReservationsPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RoomAvailabilityStatus As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RoomsAvailableLabel As System.Windows.Forms.Label
    Friend WithEvents RoomSizeLabel As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents StatusTextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FileLabel As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ExitLabel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MasterDataLabel As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents CustomerMasterLabel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeMasterLabel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents AboutLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents UserProfileLabel As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ReservationLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents InvoiceToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents LblUserDesig As System.Windows.Forms.Label

End Class
