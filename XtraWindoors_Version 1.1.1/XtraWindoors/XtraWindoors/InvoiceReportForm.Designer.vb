<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceReportForm
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
        Me.InvoiceReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InvoiceReportTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceReportTableAdapter()
        Me.HomeButton = New System.Windows.Forms.Button()
        CType(Me.InvoiceReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceReportBindingSource
        '
        Me.InvoiceReportBindingSource.DataMember = "InvoiceReport"
        Me.InvoiceReportBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.InvoiceReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "XtraWindoors.InvoiceReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(746, 397)
        Me.ReportViewer1.TabIndex = 0
        '
        'InvoiceReportTableAdapter
        '
        Me.InvoiceReportTableAdapter.ClearBeforeFill = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(659, 0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 68
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'InvoiceReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 397)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "InvoiceReportForm"
        Me.Text = "Invoice Report Form"
        CType(Me.InvoiceReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InvoiceReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents InvoiceReportTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceReportTableAdapter
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
