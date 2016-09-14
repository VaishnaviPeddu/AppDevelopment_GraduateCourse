<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.AccesoriesButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RentedButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LblReports = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AccesoriesButton
        '
        Me.AccesoriesButton.Location = New System.Drawing.Point(32, 111)
        Me.AccesoriesButton.Name = "AccesoriesButton"
        Me.AccesoriesButton.Size = New System.Drawing.Size(103, 23)
        Me.AccesoriesButton.TabIndex = 0
        Me.AccesoriesButton.Text = "Accesories Report"
        Me.AccesoriesButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Invoice"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RentedButton
        '
        Me.RentedButton.Location = New System.Drawing.Point(221, 111)
        Me.RentedButton.Name = "RentedButton"
        Me.RentedButton.Size = New System.Drawing.Size(104, 23)
        Me.RentedButton.TabIndex = 2
        Me.RentedButton.Text = "Rented Storage"
        Me.RentedButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(221, 167)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Customer Report"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LblReports
        '
        Me.LblReports.AutoSize = True
        Me.LblReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReports.Location = New System.Drawing.Point(130, 32)
        Me.LblReports.Name = "LblReports"
        Me.LblReports.Size = New System.Drawing.Size(95, 26)
        Me.LblReports.TabIndex = 4
        Me.LblReports.Text = "Reports"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(275, 12)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 69
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 271)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.LblReports)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.RentedButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AccesoriesButton)
        Me.MaximizeBox = False
        Me.Name = "ReportForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReportForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AccesoriesButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RentedButton As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LblReports As System.Windows.Forms.Label
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
