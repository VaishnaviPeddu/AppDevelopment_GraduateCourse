<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccesoriesReportForm
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.AccessoriesReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AccessoriesReportTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.AccessoriesReportTableAdapter()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.HomeButton = New System.Windows.Forms.Button()
        CType(Me.AccessoriesReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccessoriesReportBindingSource
        '
        Me.AccessoriesReportBindingSource.DataMember = "AccessoriesReport"
        Me.AccessoriesReportBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.AccessoriesReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "XtraWindoors.AccesoriesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 38)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(559, 491)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date:"
        '
        'AccessoriesReportTableAdapter
        '
        Me.AccessoriesReportTableAdapter.ClearBeforeFill = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(76, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(486, 4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 9
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'AccesoriesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 541)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "AccesoriesReportForm"
        Me.Text = "Accesories Report Form"
        CType(Me.AccessoriesReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AccessoriesReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents AccessoriesReportTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.AccessoriesReportTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
