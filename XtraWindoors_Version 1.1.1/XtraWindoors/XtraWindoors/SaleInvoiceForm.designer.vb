<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleInvoiceForm
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
        Dim InvoiceIDLabel As System.Windows.Forms.Label
        Dim LeaseIDLabel As System.Windows.Forms.Label
        Dim InvoiceDateLabel As System.Windows.Forms.Label
        Dim PaymentMethodLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Dim TaxLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel2 As System.Windows.Forms.Label
        Dim InvoiceIDLabel1 As System.Windows.Forms.Label
        Dim AccessoriesNameLabel1 As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AccessoriesNameComboBox = New System.Windows.Forms.ComboBox()
        Me.AccessoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.UnitPriceLabel3 = New System.Windows.Forms.Label()
        Me.SubAmountTextBox = New System.Windows.Forms.TextBox()
        Me.PaymentMethodComboBox = New System.Windows.Forms.ComboBox()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvoiceIDTextBox = New System.Windows.Forms.TextBox()
        Me.LeaseIDTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteItemButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.AccessoriesListBox = New System.Windows.Forms.ListBox()
        Me.AddItemButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteCancelButton = New System.Windows.Forms.Button()
        Me.AddSaveButton = New System.Windows.Forms.Button()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.InvoiceTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceTableAdapter()
        Me.TableAdapterManager = New XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager()
        Me.AccessoriesTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.AccessoriesTableAdapter()
        Me.InvoiceTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.NewButton = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        InvoiceIDLabel = New System.Windows.Forms.Label()
        LeaseIDLabel = New System.Windows.Forms.Label()
        InvoiceDateLabel = New System.Windows.Forms.Label()
        PaymentMethodLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        TaxLabel = New System.Windows.Forms.Label()
        UnitPriceLabel2 = New System.Windows.Forms.Label()
        InvoiceIDLabel1 = New System.Windows.Forms.Label()
        AccessoriesNameLabel1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AccessoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvoiceIDLabel
        '
        InvoiceIDLabel.AutoSize = True
        InvoiceIDLabel.Location = New System.Drawing.Point(336, 33)
        InvoiceIDLabel.Name = "InvoiceIDLabel"
        InvoiceIDLabel.Size = New System.Drawing.Size(59, 13)
        InvoiceIDLabel.TabIndex = 50
        InvoiceIDLabel.Text = "Invoice ID:"
        '
        'LeaseIDLabel
        '
        LeaseIDLabel.AutoSize = True
        LeaseIDLabel.Location = New System.Drawing.Point(336, 99)
        LeaseIDLabel.Name = "LeaseIDLabel"
        LeaseIDLabel.Size = New System.Drawing.Size(53, 13)
        LeaseIDLabel.TabIndex = 47
        LeaseIDLabel.Text = "Lease ID:"
        '
        'InvoiceDateLabel
        '
        InvoiceDateLabel.AutoSize = True
        InvoiceDateLabel.Location = New System.Drawing.Point(336, 68)
        InvoiceDateLabel.Name = "InvoiceDateLabel"
        InvoiceDateLabel.Size = New System.Drawing.Size(71, 13)
        InvoiceDateLabel.TabIndex = 38
        InvoiceDateLabel.Text = "Invoice Date:"
        '
        'PaymentMethodLabel
        '
        PaymentMethodLabel.AutoSize = True
        PaymentMethodLabel.Location = New System.Drawing.Point(36, 305)
        PaymentMethodLabel.Name = "PaymentMethodLabel"
        PaymentMethodLabel.Size = New System.Drawing.Size(90, 13)
        PaymentMethodLabel.TabIndex = 40
        PaymentMethodLabel.Text = "Payment Method:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Location = New System.Drawing.Point(36, 385)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(31, 13)
        CostLabel.TabIndex = 42
        CostLabel.Text = "Cost:"
        '
        'TaxLabel
        '
        TaxLabel.AutoSize = True
        TaxLabel.Location = New System.Drawing.Point(36, 347)
        TaxLabel.Name = "TaxLabel"
        TaxLabel.Size = New System.Drawing.Size(28, 13)
        TaxLabel.TabIndex = 44
        TaxLabel.Text = "Tax:"
        '
        'UnitPriceLabel2
        '
        UnitPriceLabel2.AutoSize = True
        UnitPriceLabel2.Location = New System.Drawing.Point(36, 67)
        UnitPriceLabel2.Name = "UnitPriceLabel2"
        UnitPriceLabel2.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel2.TabIndex = 64
        UnitPriceLabel2.Text = "Unit Price:"
        '
        'InvoiceIDLabel1
        '
        InvoiceIDLabel1.AutoSize = True
        InvoiceIDLabel1.Location = New System.Drawing.Point(110, 106)
        InvoiceIDLabel1.Name = "InvoiceIDLabel1"
        InvoiceIDLabel1.Size = New System.Drawing.Size(59, 13)
        InvoiceIDLabel1.TabIndex = 15
        InvoiceIDLabel1.Text = "Invoice ID:"
        '
        'AccessoriesNameLabel1
        '
        AccessoriesNameLabel1.AutoSize = True
        AccessoriesNameLabel1.Location = New System.Drawing.Point(36, 30)
        AccessoriesNameLabel1.Name = "AccessoriesNameLabel1"
        AccessoriesNameLabel1.Size = New System.Drawing.Size(98, 13)
        AccessoriesNameLabel1.TabIndex = 65
        AccessoriesNameLabel1.Text = "Accessories Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(AccessoriesNameLabel1)
        Me.GroupBox1.Controls.Add(Me.AccessoriesNameComboBox)
        Me.GroupBox1.Controls.Add(UnitPriceLabel2)
        Me.GroupBox1.Controls.Add(Me.UnitPriceLabel3)
        Me.GroupBox1.Controls.Add(Me.SubAmountTextBox)
        Me.GroupBox1.Controls.Add(Me.PaymentMethodComboBox)
        Me.GroupBox1.Controls.Add(Me.InvoiceIDTextBox)
        Me.GroupBox1.Controls.Add(Me.LeaseIDTextBox)
        Me.GroupBox1.Controls.Add(Me.InvoiceDateDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.CostTextBox)
        Me.GroupBox1.Controls.Add(Me.TaxTextBox)
        Me.GroupBox1.Controls.Add(InvoiceIDLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(LeaseIDLabel)
        Me.GroupBox1.Controls.Add(InvoiceDateLabel)
        Me.GroupBox1.Controls.Add(PaymentMethodLabel)
        Me.GroupBox1.Controls.Add(CostLabel)
        Me.GroupBox1.Controls.Add(TaxLabel)
        Me.GroupBox1.Controls.Add(Me.DeleteItemButton)
        Me.GroupBox1.Controls.Add(Me.CalculateButton)
        Me.GroupBox1.Controls.Add(Me.AccessoriesListBox)
        Me.GroupBox1.Controls.Add(Me.AddItemButton)
        Me.GroupBox1.Controls.Add(Me.EditButton)
        Me.GroupBox1.Controls.Add(Me.DeleteCancelButton)
        Me.GroupBox1.Controls.Add(Me.AddSaveButton)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.PriceLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(Me.QuantityLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 314)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 521)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Invoice Information"
        Me.GroupBox1.Visible = False
        '
        'AccessoriesNameComboBox
        '
        Me.AccessoriesNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccessoriesBindingSource, "AccessoriesName", True))
        Me.AccessoriesNameComboBox.DataSource = Me.AccessoriesBindingSource
        Me.AccessoriesNameComboBox.DisplayMember = "AccessoriesName"
        Me.AccessoriesNameComboBox.FormattingEnabled = True
        Me.AccessoriesNameComboBox.Location = New System.Drawing.Point(165, 30)
        Me.AccessoriesNameComboBox.Name = "AccessoriesNameComboBox"
        Me.AccessoriesNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AccessoriesNameComboBox.TabIndex = 66
        Me.AccessoriesNameComboBox.ValueMember = "AccessoriesName"
        '
        'AccessoriesBindingSource
        '
        Me.AccessoriesBindingSource.DataMember = "Accessories"
        Me.AccessoriesBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnitPriceLabel3
        '
        Me.UnitPriceLabel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccessoriesBindingSource, "UnitPrice", True))
        Me.UnitPriceLabel3.Location = New System.Drawing.Point(163, 68)
        Me.UnitPriceLabel3.Name = "UnitPriceLabel3"
        Me.UnitPriceLabel3.Size = New System.Drawing.Size(100, 23)
        Me.UnitPriceLabel3.TabIndex = 65
        Me.UnitPriceLabel3.Text = "Label2"
        '
        'SubAmountTextBox
        '
        Me.SubAmountTextBox.Location = New System.Drawing.Point(442, 134)
        Me.SubAmountTextBox.Name = "SubAmountTextBox"
        Me.SubAmountTextBox.Size = New System.Drawing.Size(142, 20)
        Me.SubAmountTextBox.TabIndex = 63
        '
        'PaymentMethodComboBox
        '
        Me.PaymentMethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "PaymentMethod", True))
        Me.PaymentMethodComboBox.FormattingEnabled = True
        Me.PaymentMethodComboBox.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.PaymentMethodComboBox.Location = New System.Drawing.Point(164, 302)
        Me.PaymentMethodComboBox.Name = "PaymentMethodComboBox"
        Me.PaymentMethodComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PaymentMethodComboBox.TabIndex = 62
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "Invoice"
        Me.InvoiceBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'InvoiceIDTextBox
        '
        Me.InvoiceIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "InvoiceID", True))
        Me.InvoiceIDTextBox.Location = New System.Drawing.Point(437, 31)
        Me.InvoiceIDTextBox.Name = "InvoiceIDTextBox"
        Me.InvoiceIDTextBox.Size = New System.Drawing.Size(143, 20)
        Me.InvoiceIDTextBox.TabIndex = 51
        '
        'LeaseIDTextBox
        '
        Me.LeaseIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "LeaseID", True))
        Me.LeaseIDTextBox.Location = New System.Drawing.Point(441, 99)
        Me.LeaseIDTextBox.Name = "LeaseIDTextBox"
        Me.LeaseIDTextBox.Size = New System.Drawing.Size(143, 20)
        Me.LeaseIDTextBox.TabIndex = 53
        '
        'InvoiceDateDateTimePicker
        '
        Me.InvoiceDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InvoiceBindingSource, "InvoiceDate", True))
        Me.InvoiceDateDateTimePicker.Location = New System.Drawing.Point(437, 62)
        Me.InvoiceDateDateTimePicker.Name = "InvoiceDateDateTimePicker"
        Me.InvoiceDateDateTimePicker.ShowCheckBox = True
        Me.InvoiceDateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.InvoiceDateDateTimePicker.TabIndex = 55
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(163, 385)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.ReadOnly = True
        Me.CostTextBox.Size = New System.Drawing.Size(122, 20)
        Me.CostTextBox.TabIndex = 59
        '
        'TaxTextBox
        '
        Me.TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "Tax", True))
        Me.TaxTextBox.Location = New System.Drawing.Point(164, 347)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.Size = New System.Drawing.Size(122, 20)
        Me.TaxTextBox.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Lease Amount:"
        '
        'DeleteItemButton
        '
        Me.DeleteItemButton.Location = New System.Drawing.Point(179, 199)
        Me.DeleteItemButton.Name = "DeleteItemButton"
        Me.DeleteItemButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteItemButton.TabIndex = 34
        Me.DeleteItemButton.Text = "Clear Item"
        Me.DeleteItemButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(39, 441)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 43)
        Me.CalculateButton.TabIndex = 33
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'AccessoriesListBox
        '
        Me.AccessoriesListBox.Location = New System.Drawing.Point(39, 141)
        Me.AccessoriesListBox.Name = "AccessoriesListBox"
        Me.AccessoriesListBox.Size = New System.Drawing.Size(120, 95)
        Me.AccessoriesListBox.TabIndex = 28
        '
        'AddItemButton
        '
        Me.AddItemButton.Location = New System.Drawing.Point(179, 152)
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(75, 23)
        Me.AddItemButton.TabIndex = 27
        Me.AddItemButton.Text = "&Add Item"
        Me.AddItemButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(320, 441)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 43)
        Me.EditButton.TabIndex = 12
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteCancelButton
        '
        Me.DeleteCancelButton.Location = New System.Drawing.Point(505, 441)
        Me.DeleteCancelButton.Name = "DeleteCancelButton"
        Me.DeleteCancelButton.Size = New System.Drawing.Size(75, 43)
        Me.DeleteCancelButton.TabIndex = 11
        Me.DeleteCancelButton.Text = "Delete"
        Me.DeleteCancelButton.UseVisualStyleBackColor = True
        '
        'AddSaveButton
        '
        Me.AddSaveButton.Location = New System.Drawing.Point(166, 441)
        Me.AddSaveButton.Name = "AddSaveButton"
        Me.AddSaveButton.Size = New System.Drawing.Size(75, 43)
        Me.AddSaveButton.TabIndex = 7
        Me.AddSaveButton.Text = "Add"
        Me.AddSaveButton.UseVisualStyleBackColor = True
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(165, 259)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(120, 20)
        Me.PriceTextBox.TabIndex = 14
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(36, 259)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(56, 13)
        Me.PriceLabel.TabIndex = 13
        Me.PriceLabel.Text = "Sub Total:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(166, 112)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 7
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(36, 103)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(52, 13)
        Me.QuantityLabel.TabIndex = 1
        Me.QuantityLabel.Text = "Quantity :"
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesSaleTableAdapter = Nothing
        Me.TableAdapterManager.AccessoriesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Me.InvoiceTableAdapter
        Me.TableAdapterManager.LeaseTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.StorageTableAdapter = Nothing
        Me.TableAdapterManager.StorageTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccessoriesTableAdapter
        '
        Me.AccessoriesTableAdapter.ClearBeforeFill = True
        '
        'InvoiceTextBox
        '
        Me.InvoiceTextBox.Location = New System.Drawing.Point(202, 103)
        Me.InvoiceTextBox.Name = "InvoiceTextBox"
        Me.InvoiceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.InvoiceTextBox.TabIndex = 17
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(326, 102)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 16
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'NewButton
        '
        Me.NewButton.Location = New System.Drawing.Point(439, 103)
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(135, 23)
        Me.NewButton.TabIndex = 18
        Me.NewButton.Text = "Add New Invoice"
        Me.NewButton.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Tax"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tax"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Cost"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cost"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PaymentMethod"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PaymentMethod"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "InvoiceDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "InvoiceDate"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "LeaseID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "LeaseID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "InvoiceID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "InvoiceID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'InvoiceDataGridView
        '
        Me.InvoiceDataGridView.AllowUserToAddRows = False
        Me.InvoiceDataGridView.AllowUserToDeleteRows = False
        Me.InvoiceDataGridView.AutoGenerateColumns = False
        Me.InvoiceDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.InvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoiceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.InvoiceDataGridView.DataSource = Me.InvoiceBindingSource
        Me.InvoiceDataGridView.Location = New System.Drawing.Point(106, 151)
        Me.InvoiceDataGridView.Name = "InvoiceDataGridView"
        Me.InvoiceDataGridView.ReadOnly = True
        Me.InvoiceDataGridView.Size = New System.Drawing.Size(541, 147)
        Me.InvoiceDataGridView.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(205, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(328, 33)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Customer Sales Invoices Form"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(681, 23)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 70
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'SaleInvoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 871)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.InvoiceDataGridView)
        Me.Controls.Add(Me.NewButton)
        Me.Controls.Add(Me.InvoiceTextBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(InvoiceIDLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SaleInvoiceForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sale Invoice Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AccessoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeleteItemButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents AccessoriesListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddItemButton As System.Windows.Forms.Button
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteCancelButton As System.Windows.Forms.Button
    Friend WithEvents AddSaveButton As System.Windows.Forms.Button
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityLabel As System.Windows.Forms.Label
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents InvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents TableAdapterManager As XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentMethodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents InvoiceIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LeaseIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InvoiceDateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TaxTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubAmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccessoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccessoriesTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.AccessoriesTableAdapter
    Friend WithEvents UnitPriceLabel3 As System.Windows.Forms.Label
    Friend WithEvents InvoiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents NewButton As System.Windows.Forms.Button
    Friend WithEvents AccessoriesNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
