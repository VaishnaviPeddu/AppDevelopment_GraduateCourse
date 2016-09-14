<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerName
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
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim LeaseIDLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.InvoiceReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceReportTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceReportTableAdapter()
        Me.TableAdapterManager = New XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager()
        Me.LastNameComboBox = New System.Windows.Forms.ComboBox()
        Me.LeaseIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        LastNameLabel = New System.Windows.Forms.Label()
        LeaseIDLabel = New System.Windows.Forms.Label()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(53, 74)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'LeaseIDLabel
        '
        LeaseIDLabel.AutoSize = True
        LeaseIDLabel.Location = New System.Drawing.Point(61, 113)
        LeaseIDLabel.Name = "LeaseIDLabel"
        LeaseIDLabel.Size = New System.Drawing.Size(53, 13)
        LeaseIDLabel.TabIndex = 5
        LeaseIDLabel.Text = "Lease ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InvoiceReportBindingSource
        '
        Me.InvoiceReportBindingSource.DataMember = "InvoiceReport"
        Me.InvoiceReportBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'InvoiceReportTableAdapter
        '
        Me.InvoiceReportTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesSaleTableAdapter = Nothing
        Me.TableAdapterManager.AccessoriesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.LeaseTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.StorageTableAdapter = Nothing
        Me.TableAdapterManager.StorageTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LastNameComboBox
        '
        Me.LastNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceReportBindingSource, "LastName", True))
        Me.LastNameComboBox.DataSource = Me.InvoiceReportBindingSource
        Me.LastNameComboBox.DisplayMember = "LastName"
        Me.LastNameComboBox.FormattingEnabled = True
        Me.LastNameComboBox.Location = New System.Drawing.Point(120, 71)
        Me.LastNameComboBox.Name = "LastNameComboBox"
        Me.LastNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LastNameComboBox.TabIndex = 4
        Me.LastNameComboBox.ValueMember = "CustomerID"
        '
        'LeaseIDComboBox
        '
        Me.LeaseIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceReportBindingSource, "LeaseID", True))
        Me.LeaseIDComboBox.DataSource = Me.InvoiceReportBindingSource
        Me.LeaseIDComboBox.DisplayMember = "LeaseID"
        Me.LeaseIDComboBox.FormattingEnabled = True
        Me.LeaseIDComboBox.Location = New System.Drawing.Point(120, 110)
        Me.LeaseIDComboBox.Name = "LeaseIDComboBox"
        Me.LeaseIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LeaseIDComboBox.TabIndex = 6
        Me.LeaseIDComboBox.ValueMember = "LeaseID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Please select customer's Last name or Lease ID"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(257, 5)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 8
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'CustomerName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 225)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(LeaseIDLabel)
        Me.Controls.Add(Me.LeaseIDComboBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CustomerName"
        Me.Text = "Select Customer Name"
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents InvoiceReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceReportTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceReportTableAdapter
    Friend WithEvents TableAdapterManager As XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LastNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LeaseIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
