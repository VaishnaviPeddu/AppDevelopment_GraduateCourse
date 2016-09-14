<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingForm
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim StorageIDLabel As System.Windows.Forms.Label
        Dim StorageIDLabel1 As System.Windows.Forms.Label
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim TypePriceLabel As System.Windows.Forms.Label
        Dim TypeSizeLabel As System.Windows.Forms.Label
        Dim EmailLabel1 As System.Windows.Forms.Label
        Dim CustomerName As System.Windows.Forms.Label
        Dim LeaseIDLabel As System.Windows.Forms.Label
        Dim CheckInLabel As System.Windows.Forms.Label
        Dim CheckOutLabel As System.Windows.Forms.Label
        Dim NumberOfMonthLabel As System.Windows.Forms.Label
        Dim LeaseValueLabel As System.Windows.Forms.Label
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.StorageIDTextBox = New System.Windows.Forms.TextBox()
        Me.StorageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StorageTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilterRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShowRadioButton = New System.Windows.Forms.RadioButton()
        Me.LeaseDataGridView = New System.Windows.Forms.DataGridView()
        Me.StorageIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaseActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LeaseCancelledDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LeaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchCustomerButton = New System.Windows.Forms.Button()
        Me.SearchIDButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.btnCancelLease = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteCancelButton = New System.Windows.Forms.Button()
        Me.AddSaveButton = New System.Windows.Forms.Button()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.InvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckInDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CheckOutDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.StorageIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.LeaseIDTextBox = New System.Windows.Forms.TextBox()
        Me.TypePriceTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox1 = New System.Windows.Forms.TextBox()
        Me.AccesoriesDataGridView = New System.Windows.Forms.DataGridView()
        Me.AccessoriesNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccessoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypeSizeComboBox = New System.Windows.Forms.ComboBox()
        Me.LastNameComboBox = New System.Windows.Forms.ComboBox()
        Me.FirstNameComboBox = New System.Windows.Forms.ComboBox()
        Me.NumberOfMonthTextBox = New System.Windows.Forms.TextBox()
        Me.BookingErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.CustomerTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager()
        Me.AccessoriesTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.AccessoriesTableAdapter()
        Me.LeaseTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.LeaseTableAdapter()
        Me.StorageTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.StorageTableAdapter()
        Me.StorageTypeTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.StorageTypeTableAdapter()
        Me.CustomerReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerReportTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.CustomerReportTableAdapter()
        Me.InvoiceTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceTableAdapter()
        FirstNameLabel = New System.Windows.Forms.Label()
        StorageIDLabel = New System.Windows.Forms.Label()
        StorageIDLabel1 = New System.Windows.Forms.Label()
        CustomerIDLabel = New System.Windows.Forms.Label()
        TypePriceLabel = New System.Windows.Forms.Label()
        TypeSizeLabel = New System.Windows.Forms.Label()
        EmailLabel1 = New System.Windows.Forms.Label()
        CustomerName = New System.Windows.Forms.Label()
        LeaseIDLabel = New System.Windows.Forms.Label()
        CheckInLabel = New System.Windows.Forms.Label()
        CheckOutLabel = New System.Windows.Forms.Label()
        NumberOfMonthLabel = New System.Windows.Forms.Label()
        LeaseValueLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StorageTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaseDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccesoriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccessoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookingErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(31, 138)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(85, 13)
        FirstNameLabel.TabIndex = 35
        FirstNameLabel.Text = "Customer Name:"
        '
        'StorageIDLabel
        '
        StorageIDLabel.AutoSize = True
        StorageIDLabel.Location = New System.Drawing.Point(30, 106)
        StorageIDLabel.Name = "StorageIDLabel"
        StorageIDLabel.Size = New System.Drawing.Size(61, 13)
        StorageIDLabel.TabIndex = 33
        StorageIDLabel.Text = "Storage ID:"
        '
        'StorageIDLabel1
        '
        StorageIDLabel1.AutoSize = True
        StorageIDLabel1.Location = New System.Drawing.Point(22, 223)
        StorageIDLabel1.Name = "StorageIDLabel1"
        StorageIDLabel1.Size = New System.Drawing.Size(61, 13)
        StorageIDLabel1.TabIndex = 44
        StorageIDLabel1.Text = "Storage ID:"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerIDLabel.Location = New System.Drawing.Point(24, 104)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 43
        CustomerIDLabel.Text = "Customer ID:"
        '
        'TypePriceLabel
        '
        TypePriceLabel.AutoSize = True
        TypePriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypePriceLabel.Location = New System.Drawing.Point(22, 248)
        TypePriceLabel.Name = "TypePriceLabel"
        TypePriceLabel.Size = New System.Drawing.Size(65, 13)
        TypePriceLabel.TabIndex = 40
        TypePriceLabel.Text = "Room Price:"
        '
        'TypeSizeLabel
        '
        TypeSizeLabel.AutoSize = True
        TypeSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeSizeLabel.Location = New System.Drawing.Point(23, 196)
        TypeSizeLabel.Name = "TypeSizeLabel"
        TypeSizeLabel.Size = New System.Drawing.Size(61, 13)
        TypeSizeLabel.TabIndex = 39
        TypeSizeLabel.Text = "Room Size:"
        '
        'EmailLabel1
        '
        EmailLabel1.AutoSize = True
        EmailLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel1.Location = New System.Drawing.Point(23, 164)
        EmailLabel1.Name = "EmailLabel1"
        EmailLabel1.Size = New System.Drawing.Size(35, 13)
        EmailLabel1.TabIndex = 38
        EmailLabel1.Text = "Email:"
        '
        'CustomerName
        '
        CustomerName.AutoSize = True
        CustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerName.Location = New System.Drawing.Point(23, 132)
        CustomerName.Name = "CustomerName"
        CustomerName.Size = New System.Drawing.Size(85, 13)
        CustomerName.TabIndex = 38
        CustomerName.Text = "Customer Name:"
        '
        'LeaseIDLabel
        '
        LeaseIDLabel.AutoSize = True
        LeaseIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LeaseIDLabel.Location = New System.Drawing.Point(23, 72)
        LeaseIDLabel.Name = "LeaseIDLabel"
        LeaseIDLabel.Size = New System.Drawing.Size(53, 13)
        LeaseIDLabel.TabIndex = 0
        LeaseIDLabel.Text = "Lease ID:"
        '
        'CheckInLabel
        '
        CheckInLabel.AutoSize = True
        CheckInLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CheckInLabel.Location = New System.Drawing.Point(22, 281)
        CheckInLabel.Name = "CheckInLabel"
        CheckInLabel.Size = New System.Drawing.Size(53, 13)
        CheckInLabel.TabIndex = 8
        CheckInLabel.Text = "Check In:"
        '
        'CheckOutLabel
        '
        CheckOutLabel.AutoSize = True
        CheckOutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CheckOutLabel.Location = New System.Drawing.Point(22, 311)
        CheckOutLabel.Name = "CheckOutLabel"
        CheckOutLabel.Size = New System.Drawing.Size(61, 13)
        CheckOutLabel.TabIndex = 10
        CheckOutLabel.Text = "Check Out:"
        '
        'NumberOfMonthLabel
        '
        NumberOfMonthLabel.AutoSize = True
        NumberOfMonthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NumberOfMonthLabel.Location = New System.Drawing.Point(22, 344)
        NumberOfMonthLabel.Name = "NumberOfMonthLabel"
        NumberOfMonthLabel.Size = New System.Drawing.Size(94, 13)
        NumberOfMonthLabel.TabIndex = 12
        NumberOfMonthLabel.Text = "Number Of Month:"
        '
        'LeaseValueLabel
        '
        LeaseValueLabel.AutoSize = True
        LeaseValueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LeaseValueLabel.Location = New System.Drawing.Point(22, 372)
        LeaseValueLabel.Name = "LeaseValueLabel"
        LeaseValueLabel.Size = New System.Drawing.Size(69, 13)
        LeaseValueLabel.TabIndex = 14
        LeaseValueLabel.Text = "Lease Value:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.StorageIDTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FilterRadioButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ShowRadioButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LeaseDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchCustomerButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchIDButton)
        Me.SplitContainer1.Panel1.Controls.Add(FirstNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(StorageIDLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.HomeButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCancelLease)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnCheck)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DeleteCancelButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddSaveButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CostTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CheckInDateTimePicker)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CheckOutDateTimePicker)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CustomerIDTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StorageIDTextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LeaseIDTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TypePriceTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EmailTextBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AccesoriesDataGridView)
        Me.SplitContainer1.Panel2.Controls.Add(StorageIDLabel1)
        Me.SplitContainer1.Panel2.Controls.Add(CustomerIDLabel)
        Me.SplitContainer1.Panel2.Controls.Add(TypePriceLabel)
        Me.SplitContainer1.Panel2.Controls.Add(TypeSizeLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TypeSizeComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(EmailLabel1)
        Me.SplitContainer1.Panel2.Controls.Add(CustomerName)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LastNameComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FirstNameComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(LeaseIDLabel)
        Me.SplitContainer1.Panel2.Controls.Add(CheckInLabel)
        Me.SplitContainer1.Panel2.Controls.Add(CheckOutLabel)
        Me.SplitContainer1.Panel2.Controls.Add(NumberOfMonthLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.NumberOfMonthTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(LeaseValueLabel)
        Me.SplitContainer1.Size = New System.Drawing.Size(808, 641)
        Me.SplitContainer1.SplitterDistance = 362
        Me.SplitContainer1.TabIndex = 3
        '
        'StorageIDTextBox
        '
        Me.StorageIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StorageBindingSource, "StorageID", True))
        Me.StorageIDTextBox.Location = New System.Drawing.Point(122, 99)
        Me.StorageIDTextBox.Name = "StorageIDTextBox"
        Me.StorageIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StorageIDTextBox.TabIndex = 41
        '
        'StorageBindingSource
        '
        Me.StorageBindingSource.DataMember = "StorageTypeStorage"
        Me.StorageBindingSource.DataSource = Me.StorageTypeBindingSource
        '
        'StorageTypeBindingSource
        '
        Me.StorageTypeBindingSource.DataMember = "StorageType"
        Me.StorageTypeBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'FilterRadioButton
        '
        Me.FilterRadioButton.AutoSize = True
        Me.FilterRadioButton.Checked = True
        Me.FilterRadioButton.Location = New System.Drawing.Point(157, 38)
        Me.FilterRadioButton.Name = "FilterRadioButton"
        Me.FilterRadioButton.Size = New System.Drawing.Size(71, 17)
        Me.FilterRadioButton.TabIndex = 40
        Me.FilterRadioButton.TabStop = True
        Me.FilterRadioButton.Text = "Filter data"
        Me.FilterRadioButton.UseVisualStyleBackColor = True
        '
        'ShowRadioButton
        '
        Me.ShowRadioButton.AutoSize = True
        Me.ShowRadioButton.Location = New System.Drawing.Point(33, 38)
        Me.ShowRadioButton.Name = "ShowRadioButton"
        Me.ShowRadioButton.Size = New System.Drawing.Size(89, 17)
        Me.ShowRadioButton.TabIndex = 39
        Me.ShowRadioButton.Text = "Show all data"
        Me.ShowRadioButton.UseVisualStyleBackColor = True
        '
        'LeaseDataGridView
        '
        Me.LeaseDataGridView.AutoGenerateColumns = False
        Me.LeaseDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.LeaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LeaseDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StorageIDDataGridViewTextBoxColumn, Me.LeaseActiveDataGridViewCheckBoxColumn, Me.LeaseCancelledDataGridViewCheckBoxColumn})
        Me.LeaseDataGridView.DataSource = Me.LeaseBindingSource
        Me.LeaseDataGridView.Location = New System.Drawing.Point(9, 225)
        Me.LeaseDataGridView.Name = "LeaseDataGridView"
        Me.LeaseDataGridView.Size = New System.Drawing.Size(338, 373)
        Me.LeaseDataGridView.TabIndex = 38
        '
        'StorageIDDataGridViewTextBoxColumn
        '
        Me.StorageIDDataGridViewTextBoxColumn.DataPropertyName = "StorageID"
        Me.StorageIDDataGridViewTextBoxColumn.HeaderText = "StorageID"
        Me.StorageIDDataGridViewTextBoxColumn.Name = "StorageIDDataGridViewTextBoxColumn"
        Me.StorageIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeaseActiveDataGridViewCheckBoxColumn
        '
        Me.LeaseActiveDataGridViewCheckBoxColumn.DataPropertyName = "LeaseActive"
        Me.LeaseActiveDataGridViewCheckBoxColumn.HeaderText = "LeaseActive"
        Me.LeaseActiveDataGridViewCheckBoxColumn.Name = "LeaseActiveDataGridViewCheckBoxColumn"
        Me.LeaseActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'LeaseCancelledDataGridViewCheckBoxColumn
        '
        Me.LeaseCancelledDataGridViewCheckBoxColumn.DataPropertyName = "LeaseCancelled"
        Me.LeaseCancelledDataGridViewCheckBoxColumn.HeaderText = "LeaseCancelled"
        Me.LeaseCancelledDataGridViewCheckBoxColumn.Name = "LeaseCancelledDataGridViewCheckBoxColumn"
        Me.LeaseCancelledDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'LeaseBindingSource
        '
        Me.LeaseBindingSource.DataMember = "Lease"
        Me.LeaseBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'SearchCustomerButton
        '
        Me.SearchCustomerButton.Enabled = False
        Me.SearchCustomerButton.Location = New System.Drawing.Point(122, 174)
        Me.SearchCustomerButton.Name = "SearchCustomerButton"
        Me.SearchCustomerButton.Size = New System.Drawing.Size(89, 38)
        Me.SearchCustomerButton.TabIndex = 38
        Me.SearchCustomerButton.Text = "Search by Customer Name"
        Me.SearchCustomerButton.UseVisualStyleBackColor = True
        '
        'SearchIDButton
        '
        Me.SearchIDButton.Enabled = False
        Me.SearchIDButton.Location = New System.Drawing.Point(27, 172)
        Me.SearchIDButton.Name = "SearchIDButton"
        Me.SearchIDButton.Size = New System.Drawing.Size(89, 37)
        Me.SearchIDButton.TabIndex = 37
        Me.SearchIDButton.Text = "Search by Room No"
        Me.SearchIDButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(122, 135)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Lease Search"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(307, 12)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 4
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'btnCancelLease
        '
        Me.btnCancelLease.Enabled = False
        Me.btnCancelLease.Location = New System.Drawing.Point(272, 341)
        Me.btnCancelLease.Name = "btnCancelLease"
        Me.btnCancelLease.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelLease.TabIndex = 60
        Me.btnCancelLease.Text = "Cancel Lease"
        Me.btnCancelLease.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Enabled = False
        Me.btnCheck.Location = New System.Drawing.Point(271, 223)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 59
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(307, 587)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 58
        Me.EditButton.Text = "&Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteCancelButton
        '
        Me.DeleteCancelButton.Location = New System.Drawing.Point(193, 587)
        Me.DeleteCancelButton.Name = "DeleteCancelButton"
        Me.DeleteCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteCancelButton.TabIndex = 57
        Me.DeleteCancelButton.Text = "&Delete"
        Me.DeleteCancelButton.UseVisualStyleBackColor = True
        '
        'AddSaveButton
        '
        Me.AddSaveButton.Location = New System.Drawing.Point(70, 587)
        Me.AddSaveButton.Name = "AddSaveButton"
        Me.AddSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.AddSaveButton.TabIndex = 56
        Me.AddSaveButton.Text = "&Add"
        Me.AddSaveButton.UseVisualStyleBackColor = True
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvoiceBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(147, 369)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostTextBox.TabIndex = 55
        '
        'InvoiceBindingSource
        '
        Me.InvoiceBindingSource.DataMember = "LeaseInvoice"
        Me.InvoiceBindingSource.DataSource = Me.LeaseBindingSource
        '
        'CheckInDateTimePicker
        '
        Me.CheckInDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LeaseBindingSource, "CheckIn", True))
        Me.CheckInDateTimePicker.Location = New System.Drawing.Point(147, 277)
        Me.CheckInDateTimePicker.Name = "CheckInDateTimePicker"
        Me.CheckInDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CheckInDateTimePicker.TabIndex = 54
        '
        'CheckOutDateTimePicker
        '
        Me.CheckOutDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LeaseBindingSource, "CheckOut", True))
        Me.CheckOutDateTimePicker.Location = New System.Drawing.Point(147, 307)
        Me.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker"
        Me.CheckOutDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CheckOutDateTimePicker.TabIndex = 53
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LeaseBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(147, 101)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIDTextBox.TabIndex = 52
        '
        'StorageIDTextBox1
        '
        Me.StorageIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LeaseBindingSource, "CheckIn", True))
        Me.StorageIDTextBox1.Location = New System.Drawing.Point(147, 220)
        Me.StorageIDTextBox1.Name = "StorageIDTextBox1"
        Me.StorageIDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.StorageIDTextBox1.TabIndex = 51
        '
        'LeaseIDTextBox
        '
        Me.LeaseIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LeaseBindingSource, "LeaseID", True))
        Me.LeaseIDTextBox.Location = New System.Drawing.Point(147, 69)
        Me.LeaseIDTextBox.Name = "LeaseIDTextBox"
        Me.LeaseIDTextBox.ReadOnly = True
        Me.LeaseIDTextBox.Size = New System.Drawing.Size(180, 20)
        Me.LeaseIDTextBox.TabIndex = 50
        '
        'TypePriceTextBox
        '
        Me.TypePriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StorageTypeBindingSource, "TypePrice", True))
        Me.TypePriceTextBox.Location = New System.Drawing.Point(147, 245)
        Me.TypePriceTextBox.Name = "TypePriceTextBox"
        Me.TypePriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TypePriceTextBox.TabIndex = 48
        '
        'EmailTextBox1
        '
        Me.EmailTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.EmailTextBox1.Location = New System.Drawing.Point(147, 161)
        Me.EmailTextBox1.Name = "EmailTextBox1"
        Me.EmailTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.EmailTextBox1.TabIndex = 47
        '
        'AccesoriesDataGridView
        '
        Me.AccesoriesDataGridView.AllowUserToAddRows = False
        Me.AccesoriesDataGridView.AutoGenerateColumns = False
        Me.AccesoriesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AccesoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AccesoriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccessoriesNameDataGridViewTextBoxColumn, Me.UnitPriceDataGridViewTextBoxColumn})
        Me.AccesoriesDataGridView.DataSource = Me.AccessoriesBindingSource
        Me.AccesoriesDataGridView.Location = New System.Drawing.Point(12, 409)
        Me.AccesoriesDataGridView.Name = "AccesoriesDataGridView"
        Me.AccesoriesDataGridView.RowHeadersWidth = 20
        Me.AccesoriesDataGridView.Size = New System.Drawing.Size(402, 153)
        Me.AccesoriesDataGridView.TabIndex = 45
        '
        'AccessoriesNameDataGridViewTextBoxColumn
        '
        Me.AccessoriesNameDataGridViewTextBoxColumn.DataPropertyName = "AccessoriesName"
        Me.AccessoriesNameDataGridViewTextBoxColumn.HeaderText = "AccessoriesName"
        Me.AccessoriesNameDataGridViewTextBoxColumn.Name = "AccessoriesNameDataGridViewTextBoxColumn"
        '
        'UnitPriceDataGridViewTextBoxColumn
        '
        Me.UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn"
        '
        'AccessoriesBindingSource
        '
        Me.AccessoriesBindingSource.DataMember = "Accessories"
        Me.AccessoriesBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'TypeSizeComboBox
        '
        Me.TypeSizeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeSizeComboBox.FormattingEnabled = True
        Me.TypeSizeComboBox.Location = New System.Drawing.Point(147, 193)
        Me.TypeSizeComboBox.Name = "TypeSizeComboBox"
        Me.TypeSizeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TypeSizeComboBox.TabIndex = 40
        '
        'LastNameComboBox
        '
        Me.LastNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameComboBox.FormattingEnabled = True
        Me.LastNameComboBox.Location = New System.Drawing.Point(285, 129)
        Me.LastNameComboBox.Name = "LastNameComboBox"
        Me.LastNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LastNameComboBox.TabIndex = 19
        '
        'FirstNameComboBox
        '
        Me.FirstNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameComboBox.FormattingEnabled = True
        Me.FirstNameComboBox.Location = New System.Drawing.Point(147, 129)
        Me.FirstNameComboBox.Name = "FirstNameComboBox"
        Me.FirstNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FirstNameComboBox.TabIndex = 17
        '
        'NumberOfMonthTextBox
        '
        Me.NumberOfMonthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfMonthTextBox.Location = New System.Drawing.Point(147, 341)
        Me.NumberOfMonthTextBox.Name = "NumberOfMonthTextBox"
        Me.NumberOfMonthTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberOfMonthTextBox.TabIndex = 13
        '
        'BookingErrorProvider
        '
        Me.BookingErrorProvider.ContainerControl = Me
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesSaleTableAdapter = Nothing
        Me.TableAdapterManager.AccessoriesTableAdapter = Me.AccessoriesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.LeaseTableAdapter = Me.LeaseTableAdapter
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.StorageTableAdapter = Me.StorageTableAdapter
        Me.TableAdapterManager.StorageTypeTableAdapter = Me.StorageTypeTableAdapter
        Me.TableAdapterManager.UpdateOrder = XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccessoriesTableAdapter
        '
        Me.AccessoriesTableAdapter.ClearBeforeFill = True
        '
        'LeaseTableAdapter
        '
        Me.LeaseTableAdapter.ClearBeforeFill = True
        '
        'StorageTableAdapter
        '
        Me.StorageTableAdapter.ClearBeforeFill = True
        '
        'StorageTypeTableAdapter
        '
        Me.StorageTypeTableAdapter.ClearBeforeFill = True
        '
        'CustomerReportBindingSource
        '
        Me.CustomerReportBindingSource.DataMember = "CustomerReport"
        Me.CustomerReportBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'CustomerReportTableAdapter
        '
        Me.CustomerReportTableAdapter.ClearBeforeFill = True
        '
        'InvoiceTableAdapter
        '
        Me.InvoiceTableAdapter.ClearBeforeFill = True
        '
        'BookingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 641)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BookingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.StorageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StorageTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaseDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccesoriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccessoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookingErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccessoriesTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.AccessoriesTableAdapter
    Friend WithEvents AccessoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LeaseTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.LeaseTableAdapter
    Friend WithEvents LeaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StorageTypeTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.StorageTypeTableAdapter
    Friend WithEvents StorageTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FilterRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ShowRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LeaseDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SearchCustomerButton As System.Windows.Forms.Button
    Friend WithEvents SearchIDButton As System.Windows.Forms.Button
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AccesoriesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TypeSizeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LastNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FirstNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NumberOfMonthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StorageTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.StorageTableAdapter
    Friend WithEvents StorageBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmailTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TypePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AccessoriesNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeaseIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StorageIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StorageIDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerReportTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.CustomerReportTableAdapter
    Friend WithEvents CheckInDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckOutDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents InvoiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvoiceTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.InvoiceTableAdapter
    Friend WithEvents CostTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteCancelButton As System.Windows.Forms.Button
    Friend WithEvents AddSaveButton As System.Windows.Forms.Button
    Friend WithEvents StorageIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LeaseActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LeaseCancelledDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BookingErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents btnCancelLease As System.Windows.Forms.Button
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
