<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.Txtemailadd = New System.Windows.Forms.TextBox()
        Me.TxtEmpID = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.LblEmailAdd = New System.Windows.Forms.Label()
        Me.LblEmpID = New System.Windows.Forms.Label()
        Me.LblValidateDetails = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txtemailadd
        '
        Me.Txtemailadd.Location = New System.Drawing.Point(179, 170)
        Me.Txtemailadd.Name = "Txtemailadd"
        Me.Txtemailadd.Size = New System.Drawing.Size(180, 20)
        Me.Txtemailadd.TabIndex = 13
        '
        'TxtEmpID
        '
        Me.TxtEmpID.Location = New System.Drawing.Point(179, 128)
        Me.TxtEmpID.Name = "TxtEmpID"
        Me.TxtEmpID.Size = New System.Drawing.Size(180, 20)
        Me.TxtEmpID.TabIndex = 12
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(244, 233)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Location = New System.Drawing.Point(126, 234)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnSubmit.TabIndex = 10
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'LblEmailAdd
        '
        Me.LblEmailAdd.AutoSize = True
        Me.LblEmailAdd.Location = New System.Drawing.Point(87, 170)
        Me.LblEmailAdd.Name = "LblEmailAdd"
        Me.LblEmailAdd.Size = New System.Drawing.Size(76, 13)
        Me.LblEmailAdd.TabIndex = 9
        Me.LblEmailAdd.Text = "Email Address:"
        '
        'LblEmpID
        '
        Me.LblEmpID.AutoSize = True
        Me.LblEmpID.Location = New System.Drawing.Point(87, 128)
        Me.LblEmpID.Name = "LblEmpID"
        Me.LblEmpID.Size = New System.Drawing.Size(70, 13)
        Me.LblEmpID.TabIndex = 8
        Me.LblEmpID.Text = "Employee ID:"
        '
        'LblValidateDetails
        '
        Me.LblValidateDetails.AutoSize = True
        Me.LblValidateDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValidateDetails.Location = New System.Drawing.Point(59, 63)
        Me.LblValidateDetails.Name = "LblValidateDetails"
        Me.LblValidateDetails.Size = New System.Drawing.Size(176, 20)
        Me.LblValidateDetails.TabIndex = 7
        Me.LblValidateDetails.Text = "Validate Credentials:"
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 321)
        Me.Controls.Add(Me.Txtemailadd)
        Me.Controls.Add(Me.TxtEmpID)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.LblEmailAdd)
        Me.Controls.Add(Me.LblEmpID)
        Me.Controls.Add(Me.LblValidateDetails)
        Me.MaximizeBox = False
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtemailadd As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents LblEmailAdd As System.Windows.Forms.Label
    Friend WithEvents LblEmpID As System.Windows.Forms.Label
    Friend WithEvents LblValidateDetails As System.Windows.Forms.Label
End Class
