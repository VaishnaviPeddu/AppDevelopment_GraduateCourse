<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Search2Button = New System.Windows.Forms.Button()
        Me.Search1Button = New System.Windows.Forms.Button()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.CustomerNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.CustomerPhoneTextBox1 = New System.Windows.Forms.TextBox()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.CustomerPhoneLabel = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DeleteCancelButton = New System.Windows.Forms.Button()
        Me.AddSaveButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager()
        Me.MainErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.EButton = New System.Windows.Forms.Button()
        Me.CustomerPhoneTextBox = New System.Windows.Forms.TextBox()
        CustomerIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MainErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(46, 58)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(68, 13)
        CustomerIDLabel.TabIndex = 0
        CustomerIDLabel.Text = "Customer ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(46, 99)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 2
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(46, 140)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(46, 181)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 6
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(46, 222)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 8
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(46, 263)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 10
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(46, 304)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(25, 13)
        ZipLabel.TabIndex = 12
        ZipLabel.Text = "Zip:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(46, 345)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 14
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(46, 386)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 16
        EmailLabel.Text = "Email:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.HomeButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClearButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Search2Button)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Search1Button)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CustomerDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CustomerNameTextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CustomerPhoneTextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CustomerNameLabel)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CustomerPhoneLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.EditButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DeleteCancelButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddSaveButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1039, 588)
        Me.SplitContainer1.SplitterDistance = 534
        Me.SplitContainer1.TabIndex = 0
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(438, 60)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 5
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(438, 107)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Search2Button
        '
        Me.Search2Button.Location = New System.Drawing.Point(345, 108)
        Me.Search2Button.Name = "Search2Button"
        Me.Search2Button.Size = New System.Drawing.Size(75, 23)
        Me.Search2Button.TabIndex = 6
        Me.Search2Button.Text = "Search"
        Me.Search2Button.UseVisualStyleBackColor = True
        '
        'Search1Button
        '
        Me.Search1Button.Location = New System.Drawing.Point(345, 60)
        Me.Search1Button.Name = "Search1Button"
        Me.Search1Button.Size = New System.Drawing.Size(75, 23)
        Me.Search1Button.TabIndex = 5
        Me.Search1Button.Text = "Search"
        Me.Search1Button.UseVisualStyleBackColor = True
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(12, 207)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.Size = New System.Drawing.Size(501, 268)
        Me.CustomerDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn5.HeaderText = "City"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn6.HeaderText = "State"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Zip"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Zip"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
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
        'CustomerNameTextBox1
        '
        Me.CustomerNameTextBox1.Location = New System.Drawing.Point(151, 110)
        Me.CustomerNameTextBox1.Name = "CustomerNameTextBox1"
        Me.CustomerNameTextBox1.Size = New System.Drawing.Size(125, 20)
        Me.CustomerNameTextBox1.TabIndex = 3
        '
        'CustomerPhoneTextBox1
        '
        Me.CustomerPhoneTextBox1.Location = New System.Drawing.Point(151, 62)
        Me.CustomerPhoneTextBox1.Name = "CustomerPhoneTextBox1"
        Me.CustomerPhoneTextBox1.Size = New System.Drawing.Size(125, 20)
        Me.CustomerPhoneTextBox1.TabIndex = 2
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Location = New System.Drawing.Point(54, 115)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(82, 13)
        Me.CustomerNameLabel.TabIndex = 1
        Me.CustomerNameLabel.Text = "CustomerName:"
        '
        'CustomerPhoneLabel
        '
        Me.CustomerPhoneLabel.AutoSize = True
        Me.CustomerPhoneLabel.Location = New System.Drawing.Point(54, 62)
        Me.CustomerPhoneLabel.Name = "CustomerPhoneLabel"
        Me.CustomerPhoneLabel.Size = New System.Drawing.Size(91, 13)
        Me.CustomerPhoneLabel.TabIndex = 0
        Me.CustomerPhoneLabel.Text = "Customer Phone :"
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(328, 534)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 4
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DeleteCancelButton
        '
        Me.DeleteCancelButton.Location = New System.Drawing.Point(192, 534)
        Me.DeleteCancelButton.Name = "DeleteCancelButton"
        Me.DeleteCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteCancelButton.TabIndex = 3
        Me.DeleteCancelButton.Text = "Delete"
        Me.DeleteCancelButton.UseVisualStyleBackColor = True
        '
        'AddSaveButton
        '
        Me.AddSaveButton.Location = New System.Drawing.Point(56, 534)
        Me.AddSaveButton.Name = "AddSaveButton"
        Me.AddSaveButton.Size = New System.Drawing.Size(75, 23)
        Me.AddSaveButton.TabIndex = 2
        Me.AddSaveButton.Text = "Add"
        Me.AddSaveButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(CustomerIDLabel)
        Me.GroupBox1.Controls.Add(Me.CustomerIDTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(CityLabel)
        Me.GroupBox1.Controls.Add(Me.CityTextBox)
        Me.GroupBox1.Controls.Add(StateLabel)
        Me.GroupBox1.Controls.Add(Me.StateTextBox)
        Me.GroupBox1.Controls.Add(ZipLabel)
        Me.GroupBox1.Controls.Add(Me.ZipTextBox)
        Me.GroupBox1.Controls.Add(PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 439)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(220, 51)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIDTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(220, 92)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(220, 133)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 5
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(220, 174)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 7
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(220, 215)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 9
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "State", True))
        Me.StateTextBox.Location = New System.Drawing.Point(220, 256)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(27, 20)
        Me.StateTextBox.TabIndex = 11
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(220, 297)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(42, 20)
        Me.ZipTextBox.TabIndex = 13
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(220, 338)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 15
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(220, 379)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(145, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 30)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer  Form"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccessoriesSaleTableAdapter = Nothing
        Me.TableAdapterManager.AccessoriesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.LeaseTableAdapter = Nothing
        Me.TableAdapterManager.LocationTableAdapter = Nothing
        Me.TableAdapterManager.StorageTableAdapter = Nothing
        Me.TableAdapterManager.StorageTypeTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainErrorProvider
        '
        Me.MainErrorProvider.ContainerControl = Me
        '
        'EButton
        '
        Me.EButton.Location = New System.Drawing.Point(331, 513)
        Me.EButton.Name = "EButton"
        Me.EButton.Size = New System.Drawing.Size(75, 23)
        Me.EButton.TabIndex = 4
        Me.EButton.Text = "Edit"
        Me.EButton.UseVisualStyleBackColor = True
        '
        'CustomerPhoneTextBox
        '
        Me.CustomerPhoneTextBox.Location = New System.Drawing.Point(134, 64)
        Me.CustomerPhoneTextBox.Name = "CustomerPhoneTextBox"
        Me.CustomerPhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerPhoneTextBox.TabIndex = 2
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 588)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "CustomerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MainErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CustomerNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CustomerPhoneTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CustomerNameLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As XtraWindoors.XtraWindoorsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Search2Button As System.Windows.Forms.Button
    Friend WithEvents Search1Button As System.Windows.Forms.Button
    Friend WithEvents CustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditButton As System.Windows.Forms.Button
    Friend WithEvents DeleteCancelButton As System.Windows.Forms.Button
    Friend WithEvents AddSaveButton As System.Windows.Forms.Button
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents MainErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents EButton As System.Windows.Forms.Button
    Friend WithEvents CustomerPhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomeButton As System.Windows.Forms.Button
End Class
