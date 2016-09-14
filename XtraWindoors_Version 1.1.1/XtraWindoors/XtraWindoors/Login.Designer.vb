<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.AdminAccess = New System.Windows.Forms.GroupBox()
        Me.ContactUsLink = New System.Windows.Forms.LinkLabel()
        Me.ForgotPasswordLink = New System.Windows.Forms.LinkLabel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.UserPass = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UserNameLabel = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.TextBox()
        Me.ProjectName = New System.Windows.Forms.Label()
        Me.GroupLogo = New System.Windows.Forms.PictureBox()
        Me.ProjectInfo = New System.Windows.Forms.Label()
        Me.AdminAccess.SuspendLayout()
        CType(Me.GroupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdminAccess
        '
        Me.AdminAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AdminAccess.Controls.Add(Me.ContactUsLink)
        Me.AdminAccess.Controls.Add(Me.ForgotPasswordLink)
        Me.AdminAccess.Controls.Add(Me.ExitButton)
        Me.AdminAccess.Controls.Add(Me.SignInButton)
        Me.AdminAccess.Controls.Add(Me.UserPass)
        Me.AdminAccess.Controls.Add(Me.PasswordLabel)
        Me.AdminAccess.Controls.Add(Me.UserNameLabel)
        Me.AdminAccess.Controls.Add(Me.EmployeeID)
        Me.AdminAccess.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminAccess.Location = New System.Drawing.Point(81, 136)
        Me.AdminAccess.Name = "AdminAccess"
        Me.AdminAccess.Size = New System.Drawing.Size(359, 218)
        Me.AdminAccess.TabIndex = 0
        Me.AdminAccess.TabStop = False
        Me.AdminAccess.Text = "Admin Login"
        '
        'ContactUsLink
        '
        Me.ContactUsLink.AutoSize = True
        Me.ContactUsLink.Location = New System.Drawing.Point(289, 194)
        Me.ContactUsLink.Name = "ContactUsLink"
        Me.ContactUsLink.Size = New System.Drawing.Size(63, 13)
        Me.ContactUsLink.TabIndex = 6
        Me.ContactUsLink.TabStop = True
        Me.ContactUsLink.Text = "Contact Us!"
        '
        'ForgotPasswordLink
        '
        Me.ForgotPasswordLink.AutoSize = True
        Me.ForgotPasswordLink.Location = New System.Drawing.Point(5, 194)
        Me.ForgotPasswordLink.Name = "ForgotPasswordLink"
        Me.ForgotPasswordLink.Size = New System.Drawing.Size(92, 13)
        Me.ForgotPasswordLink.TabIndex = 5
        Me.ForgotPasswordLink.TabStop = True
        Me.ForgotPasswordLink.Text = "Forgot Password?"
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ExitButton.Location = New System.Drawing.Point(190, 137)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(80, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SignInButton
        '
        Me.SignInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignInButton.Location = New System.Drawing.Point(90, 137)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(80, 23)
        Me.SignInButton.TabIndex = 3
        Me.SignInButton.Text = "SignIn"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'UserPass
        '
        Me.UserPass.Location = New System.Drawing.Point(177, 87)
        Me.UserPass.MaxLength = 10
        Me.UserPass.Name = "UserPass"
        Me.UserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserPass.Size = New System.Drawing.Size(100, 20)
        Me.UserPass.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(84, 91)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLabel.TabIndex = 0
        Me.PasswordLabel.Text = "Password:"
        '
        'UserNameLabel
        '
        Me.UserNameLabel.AutoSize = True
        Me.UserNameLabel.Location = New System.Drawing.Point(81, 51)
        Me.UserNameLabel.Name = "UserNameLabel"
        Me.UserNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.UserNameLabel.TabIndex = 0
        Me.UserNameLabel.Text = "UserName:"
        '
        'EmployeeID
        '
        Me.EmployeeID.Location = New System.Drawing.Point(177, 47)
        Me.EmployeeID.MaxLength = 6
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeID.TabIndex = 1
        '
        'ProjectName
        '
        Me.ProjectName.AutoSize = True
        Me.ProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectName.ForeColor = System.Drawing.Color.Maroon
        Me.ProjectName.Location = New System.Drawing.Point(109, 52)
        Me.ProjectName.Name = "ProjectName"
        Me.ProjectName.Size = New System.Drawing.Size(184, 24)
        Me.ProjectName.TabIndex = 6
        Me.ProjectName.Text = "XTRA WINDOORS"
        '
        'GroupLogo
        '
        Me.GroupLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.GroupLogo.Image = CType(resources.GetObject("GroupLogo.Image"), System.Drawing.Image)
        Me.GroupLogo.Location = New System.Drawing.Point(299, 21)
        Me.GroupLogo.Name = "GroupLogo"
        Me.GroupLogo.Size = New System.Drawing.Size(159, 109)
        Me.GroupLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GroupLogo.TabIndex = 5
        Me.GroupLogo.TabStop = False
        '
        'ProjectInfo
        '
        Me.ProjectInfo.AutoSize = True
        Me.ProjectInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectInfo.ForeColor = System.Drawing.Color.Maroon
        Me.ProjectInfo.Location = New System.Drawing.Point(124, 80)
        Me.ProjectInfo.Name = "ProjectInfo"
        Me.ProjectInfo.Size = New System.Drawing.Size(153, 20)
        Me.ProjectInfo.TabIndex = 7
        Me.ProjectInfo.Text = "Storage Solutions"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.SignInButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(510, 417)
        Me.Controls.Add(Me.AdminAccess)
        Me.Controls.Add(Me.ProjectName)
        Me.Controls.Add(Me.GroupLogo)
        Me.Controls.Add(Me.ProjectInfo)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.AdminAccess.ResumeLayout(False)
        Me.AdminAccess.PerformLayout()
        CType(Me.GroupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdminAccess As System.Windows.Forms.GroupBox
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SignInButton As System.Windows.Forms.Button
    Friend WithEvents UserPass As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UserNameLabel As System.Windows.Forms.Label
    Friend WithEvents EmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents ProjectName As System.Windows.Forms.Label
    Friend WithEvents GroupLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ProjectInfo As System.Windows.Forms.Label
    Friend WithEvents ForgotPasswordLink As System.Windows.Forms.LinkLabel
    Friend WithEvents ContactUsLink As System.Windows.Forms.LinkLabel
    'Friend WithEvents XtraWindoorsDBVersion10DataSetBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents _XtraWindoorsDB_Version_1_0DataSet As HomePage._XtraWindoorsDB_Version_1_0DataSet
    ' Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents EmployeeTableAdapter As HomePage._XtraWindoorsDB_Version_1_0DataSetTableAdapters.EmployeeTableAdapter
End Class
