<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentedStorageForm
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.RentedStorageReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RentedStorageReportTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.RentedStorageReportTableAdapter()
        Me.HomeButton = New System.Windows.Forms.Button()
        CType(Me.RentedStorageReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RentedStorageReportBindingSource
        '
        Me.RentedStorageReportBindingSource.DataMember = "RentedStorageReport"
        Me.RentedStorageReportBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.RentedStorageReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "XtraWindoors.RentedStorageReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(754, 409)
        Me.ReportViewer1.TabIndex = 0
        '
        'RentedStorageReportTableAdapter
        '
        Me.RentedStorageReportTableAdapter.ClearBeforeFill = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(667, 0)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 69
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'RentedStorageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 409)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "RentedStorageForm"
        Me.Text = "Rented Storage Form"
        CType(Me.RentedStorageReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RentedStorageReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents RentedStorageReportTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.RentedStorageReportTableAdapter
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
