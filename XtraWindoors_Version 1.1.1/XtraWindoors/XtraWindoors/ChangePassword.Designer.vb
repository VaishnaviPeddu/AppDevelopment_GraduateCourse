<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.TxtRePass = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LabelReNewPass = New System.Windows.Forms.Label()
        Me.LblNewPass = New System.Windows.Forms.Label()
        Me.LblResetPassword = New System.Windows.Forms.Label()
        Me.TxtCPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EmpIDlabel = New System.Windows.Forms.Label()
        Me.TxtEmpID = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtRePass
        '
        Me.TxtRePass.Location = New System.Drawing.Point(212, 190)
        Me.TxtRePass.MaxLength = 10
        Me.TxtRePass.Name = "TxtRePass"
        Me.TxtRePass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtRePass.Size = New System.Drawing.Size(100, 20)
        Me.TxtRePass.TabIndex = 3
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(212, 152)
        Me.TxtPass.MaxLength = 10
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtPass.TabIndex = 2
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(212, 242)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(94, 243)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 4
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LabelReNewPass
        '
        Me.LabelReNewPass.AutoSize = True
        Me.LabelReNewPass.Location = New System.Drawing.Point(69, 192)
        Me.LabelReNewPass.Name = "LabelReNewPass"
        Me.LabelReNewPass.Size = New System.Drawing.Size(125, 13)
        Me.LabelReNewPass.TabIndex = 0
        Me.LabelReNewPass.Text = "Re-enter New Password:"
        '
        'LblNewPass
        '
        Me.LblNewPass.Location = New System.Drawing.Point(69, 155)
        Me.LblNewPass.Name = "LblNewPass"
        Me.LblNewPass.Size = New System.Drawing.Size(125, 13)
        Me.LblNewPass.TabIndex = 0
        Me.LblNewPass.Text = "Enter New Password:"
        '
        'LblResetPassword
        '
        Me.LblResetPassword.AutoSize = True
        Me.LblResetPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResetPassword.Location = New System.Drawing.Point(32, 33)
        Me.LblResetPassword.Name = "LblResetPassword"
        Me.LblResetPassword.Size = New System.Drawing.Size(144, 20)
        Me.LblResetPassword.TabIndex = 0
        Me.LblResetPassword.Text = "Reset Password:"
        '
        'TxtCPass
        '
        Me.TxtCPass.Location = New System.Drawing.Point(212, 112)
        Me.TxtCPass.MaxLength = 10
        Me.TxtCPass.Name = "TxtCPass"
        Me.TxtCPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtCPass.Size = New System.Drawing.Size(100, 20)
        Me.TxtCPass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(69, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Current Password:"
        '
        'EmpIDlabel
        '
        Me.EmpIDlabel.AutoSize = True
        Me.EmpIDlabel.Location = New System.Drawing.Point(214, 79)
        Me.EmpIDlabel.Name = "EmpIDlabel"
        Me.EmpIDlabel.Size = New System.Drawing.Size(0, 13)
        Me.EmpIDlabel.TabIndex = 0
        '
        'TxtEmpID
        '
        Me.TxtEmpID.AutoSize = True
        Me.TxtEmpID.Location = New System.Drawing.Point(68, 80)
        Me.TxtEmpID.Name = "TxtEmpID"
        Me.TxtEmpID.Size = New System.Drawing.Size(70, 13)
        Me.TxtEmpID.TabIndex = 6
        Me.TxtEmpID.Text = "Employee ID:"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 308)
        Me.Controls.Add(Me.TxtEmpID)
        Me.Controls.Add(Me.EmpIDlabel)
        Me.Controls.Add(Me.TxtCPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtRePass)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LabelReNewPass)
        Me.Controls.Add(Me.LblNewPass)
        Me.Controls.Add(Me.LblResetPassword)
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtRePass As System.Windows.Forms.TextBox
    Friend WithEvents TxtPass As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents LabelReNewPass As System.Windows.Forms.Label
    Friend WithEvents LblNewPass As System.Windows.Forms.Label
    Friend WithEvents LblResetPassword As System.Windows.Forms.Label
    Friend WithEvents TxtCPass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmpIDlabel As System.Windows.Forms.Label
    Friend WithEvents TxtEmpID As System.Windows.Forms.Label
End Class
