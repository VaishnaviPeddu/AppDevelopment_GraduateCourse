<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckAvailability
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
        Me.StorageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StorageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.StorageTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.StorageTableAdapter()
        Me.TableAdapterManager = New XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.StorageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StorageDataGridView
        '
        Me.StorageDataGridView.AutoGenerateColumns = False
        Me.StorageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StorageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.StorageDataGridView.DataSource = Me.StorageBindingSource
        Me.StorageDataGridView.Location = New System.Drawing.Point(12, 62)
        Me.StorageDataGridView.Name = "StorageDataGridView"
        Me.StorageDataGridView.Size = New System.Drawing.Size(245, 249)
        Me.StorageDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StorageID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "StorageID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StorageTypeID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StorageTypeID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'StorageBindingSource
        '
        Me.StorageBindingSource.DataMember = "Storage"
        Me.StorageBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StorageTableAdapter
        '
        Me.StorageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesSaleTableAdapter = Nothing
        Me.TableAdapterManager.AccessoriesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.LeaseTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.StorageTableAdapter = Me.StorageTableAdapter
        Me.TableAdapterManager.StorageTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(41, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Available Rooms"
        '
        'CheckAvailability
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 336)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StorageDataGridView)
        Me.Name = "CheckAvailability"
        Me.Text = "CheckAvailability"
        CType(Me.StorageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents StorageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StorageTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.StorageTableAdapter
    Friend WithEvents TableAdapterManager As XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StorageDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
