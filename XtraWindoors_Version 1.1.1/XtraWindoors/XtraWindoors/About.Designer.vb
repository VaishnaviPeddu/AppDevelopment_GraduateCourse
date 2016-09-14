<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.txtMsg = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMsg
        '
        Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMsg.Location = New System.Drawing.Point(36, 69)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(744, 410)
        Me.txtMsg.TabIndex = 2
        Me.txtMsg.Text = resources.GetString("txtMsg.Text")
        Me.txtMsg.UseCompatibleTextRendering = True
        '
        'txtTitle
        '
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(33, 39)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(245, 24)
        Me.txtTitle.TabIndex = 3
        Me.txtTitle.Text = "About XTRAWINDOORS:"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 577)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtMsg)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMsg As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.Label
End Class
