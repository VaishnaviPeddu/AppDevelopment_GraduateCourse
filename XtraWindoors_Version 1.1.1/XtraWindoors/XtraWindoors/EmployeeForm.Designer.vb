<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Dim Label3 As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim LocationIDLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CItyLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailIDLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim OwnerFlagLabel As System.Windows.Forms.Label
        Dim FirstLoginLabel As System.Windows.Forms.Label
        Dim PhoneLabel1 As System.Windows.Forms.Label
        Dim EmployeeIDLabel1 As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.XtraWindoorsDataSet = New XtraWindoors.XtraWindoorsDataSet()
        Me.ClearSearchButton = New System.Windows.Forms.Button()
        Me.EmpPhoneSearchButton = New System.Windows.Forms.Button()
        Me.EMPIDSearchButton = New System.Windows.Forms.Button()
        Me.PhoneSearchTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeIDSearchTextBox = New System.Windows.Forms.TextBox()
        Me.EmpSearchLabel = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmpIDComboBox = New System.Windows.Forms.ComboBox()
        Me.Delete_CancelButton = New System.Windows.Forms.Button()
        Me.Edit_SaveButton = New System.Windows.Forms.Button()
        Me.Add_SaveButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LocationIDTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CItyTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OwnerFlagTextBox = New System.Windows.Forms.TextBox()
        Me.FirstLoginTextBox = New System.Windows.Forms.TextBox()
        Me.EmployeeTableAdapter = New XtraWindoors.XtraWindoorsDataSetTableAdapters.EmployeeTableAdapter()
        Me.MainErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Label3 = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        LocationIDLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CItyLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailIDLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        OwnerFlagLabel = New System.Windows.Forms.Label()
        FirstLoginLabel = New System.Windows.Forms.Label()
        PhoneLabel1 = New System.Windows.Forms.Label()
        EmployeeIDLabel1 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(90, 62)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(70, 13)
        Label3.TabIndex = 64
        Label3.Text = "Employee ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(90, 87)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 37
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(90, 113)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 39
        LastNameLabel.Text = "Last Name:"
        '
        'LocationIDLabel
        '
        LocationIDLabel.AutoSize = True
        LocationIDLabel.Location = New System.Drawing.Point(90, 139)
        LocationIDLabel.Name = "LocationIDLabel"
        LocationIDLabel.Size = New System.Drawing.Size(65, 13)
        LocationIDLabel.TabIndex = 41
        LocationIDLabel.Text = "Location ID:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Location = New System.Drawing.Point(90, 165)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(47, 13)
        PositionLabel.TabIndex = 43
        PositionLabel.Text = "Position:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(90, 191)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 45
        AddressLabel.Text = "Address:"
        '
        'CItyLabel
        '
        CItyLabel.AutoSize = True
        CItyLabel.Location = New System.Drawing.Point(90, 217)
        CItyLabel.Name = "CItyLabel"
        CItyLabel.Size = New System.Drawing.Size(28, 13)
        CItyLabel.TabIndex = 47
        CItyLabel.Text = "CIty:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(90, 243)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(35, 13)
        StateLabel.TabIndex = 49
        StateLabel.Text = "State:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(90, 269)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 51
        PhoneLabel.Text = "Phone:"
        '
        'EmailIDLabel
        '
        EmailIDLabel.AutoSize = True
        EmailIDLabel.Location = New System.Drawing.Point(90, 295)
        EmailIDLabel.Name = "EmailIDLabel"
        EmailIDLabel.Size = New System.Drawing.Size(49, 13)
        EmailIDLabel.TabIndex = 53
        EmailIDLabel.Text = "Email ID:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(90, 321)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 55
        PasswordLabel.Text = "Password:"
        '
        'OwnerFlagLabel
        '
        OwnerFlagLabel.AutoSize = True
        OwnerFlagLabel.Location = New System.Drawing.Point(90, 347)
        OwnerFlagLabel.Name = "OwnerFlagLabel"
        OwnerFlagLabel.Size = New System.Drawing.Size(64, 13)
        OwnerFlagLabel.TabIndex = 57
        OwnerFlagLabel.Text = "Owner Flag:"
        '
        'FirstLoginLabel
        '
        FirstLoginLabel.AutoSize = True
        FirstLoginLabel.Location = New System.Drawing.Point(90, 373)
        FirstLoginLabel.Name = "FirstLoginLabel"
        FirstLoginLabel.Size = New System.Drawing.Size(58, 13)
        FirstLoginLabel.TabIndex = 59
        FirstLoginLabel.Text = "First Login:"
        '
        'PhoneLabel1
        '
        PhoneLabel1.AutoSize = True
        PhoneLabel1.Location = New System.Drawing.Point(22, 137)
        PhoneLabel1.Name = "PhoneLabel1"
        PhoneLabel1.Size = New System.Drawing.Size(41, 13)
        PhoneLabel1.TabIndex = 43
        PhoneLabel1.Text = "Phone:"
        '
        'EmployeeIDLabel1
        '
        EmployeeIDLabel1.AutoSize = True
        EmployeeIDLabel1.Location = New System.Drawing.Point(22, 90)
        EmployeeIDLabel1.Name = "EmployeeIDLabel1"
        EmployeeIDLabel1.Size = New System.Drawing.Size(70, 13)
        EmployeeIDLabel1.TabIndex = 41
        EmployeeIDLabel1.Text = "Employee ID:"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.EmployeeDataGridView)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ClearSearchButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EmpPhoneSearchButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EMPIDSearchButton)
        Me.SplitContainer1.Panel1.Controls.Add(PhoneLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PhoneSearchTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(EmployeeIDLabel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EmployeeIDSearchTextBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EmpSearchLabel)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.HomeButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EmpIDComboBox)
        Me.SplitContainer1.Panel2.Controls.Add(Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Delete_CancelButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Edit_SaveButton)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Add_SaveButton)
        Me.SplitContainer1.Panel2.Controls.Add(FirstNameLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FirstNameTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(LastNameLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LastNameTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(LocationIDLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LocationIDTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(PositionLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PositionTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(AddressLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.AddressTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(CItyLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CItyTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(StateLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.StateTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(PhoneLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PhoneTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(EmailIDLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.EmailIDTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(PasswordLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PasswordTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(OwnerFlagLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.OwnerFlagTextBox)
        Me.SplitContainer1.Panel2.Controls.Add(FirstLoginLabel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FirstLoginTextBox)
        Me.SplitContainer1.Size = New System.Drawing.Size(832, 477)
        Me.SplitContainer1.SplitterDistance = 419
        Me.SplitContainer1.TabIndex = 0
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(0, 214)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(416, 249)
        Me.EmployeeDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EmpID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EmpID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LocationID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LocationID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Position"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CIty"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CIty"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn8.HeaderText = "State"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EmailID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EmailID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Password"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "OwnerFlag"
        Me.DataGridViewTextBoxColumn12.HeaderText = "OwnerFlag"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FirstLogin"
        Me.DataGridViewTextBoxColumn13.HeaderText = "FirstLogin"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.XtraWindoorsDataSet
        '
        'XtraWindoorsDataSet
        '
        Me.XtraWindoorsDataSet.DataSetName = "XtraWindoorsDataSet"
        Me.XtraWindoorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClearSearchButton
        '
        Me.ClearSearchButton.Location = New System.Drawing.Point(272, 179)
        Me.ClearSearchButton.Name = "ClearSearchButton"
        Me.ClearSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearSearchButton.TabIndex = 4
        Me.ClearSearchButton.Text = "&Clear"
        Me.ClearSearchButton.UseVisualStyleBackColor = True
        '
        'EmpPhoneSearchButton
        '
        Me.EmpPhoneSearchButton.Location = New System.Drawing.Point(272, 132)
        Me.EmpPhoneSearchButton.Name = "EmpPhoneSearchButton"
        Me.EmpPhoneSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.EmpPhoneSearchButton.TabIndex = 3
        Me.EmpPhoneSearchButton.Text = "S&earch"
        Me.EmpPhoneSearchButton.UseVisualStyleBackColor = True
        '
        'EMPIDSearchButton
        '
        Me.EMPIDSearchButton.Location = New System.Drawing.Point(272, 84)
        Me.EMPIDSearchButton.Name = "EMPIDSearchButton"
        Me.EMPIDSearchButton.Size = New System.Drawing.Size(75, 23)
        Me.EMPIDSearchButton.TabIndex = 1
        Me.EMPIDSearchButton.Text = "S&earch"
        Me.EMPIDSearchButton.UseVisualStyleBackColor = True
        '
        'PhoneSearchTextBox
        '
        Me.PhoneSearchTextBox.Location = New System.Drawing.Point(107, 134)
        Me.PhoneSearchTextBox.Name = "PhoneSearchTextBox"
        Me.PhoneSearchTextBox.Size = New System.Drawing.Size(147, 20)
        Me.PhoneSearchTextBox.TabIndex = 2
        '
        'EmployeeIDSearchTextBox
        '
        Me.EmployeeIDSearchTextBox.Location = New System.Drawing.Point(107, 87)
        Me.EmployeeIDSearchTextBox.Name = "EmployeeIDSearchTextBox"
        Me.EmployeeIDSearchTextBox.Size = New System.Drawing.Size(147, 20)
        Me.EmployeeIDSearchTextBox.TabIndex = 0
        '
        'EmpSearchLabel
        '
        Me.EmpSearchLabel.AutoSize = True
        Me.EmpSearchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpSearchLabel.Location = New System.Drawing.Point(22, 43)
        Me.EmpSearchLabel.Name = "EmpSearchLabel"
        Me.EmpSearchLabel.Size = New System.Drawing.Size(131, 16)
        Me.EmpSearchLabel.TabIndex = 40
        Me.EmpSearchLabel.Text = "Employee Search"
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(307, 16)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 67
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Harlow Solid Italic", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(46, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 30)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Employee Details"
        '
        'EmpIDComboBox
        '
        Me.EmpIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmpID", True))
        Me.EmpIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EmpIDComboBox.FormattingEnabled = True
        Me.EmpIDComboBox.Location = New System.Drawing.Point(161, 59)
        Me.EmpIDComboBox.Name = "EmpIDComboBox"
        Me.EmpIDComboBox.Size = New System.Drawing.Size(121, 21)
        Me.EmpIDComboBox.TabIndex = 0
        '
        'Delete_CancelButton
        '
        Me.Delete_CancelButton.Location = New System.Drawing.Point(244, 424)
        Me.Delete_CancelButton.Name = "Delete_CancelButton"
        Me.Delete_CancelButton.Size = New System.Drawing.Size(62, 23)
        Me.Delete_CancelButton.TabIndex = 15
        Me.Delete_CancelButton.Text = "Delete"
        Me.Delete_CancelButton.UseVisualStyleBackColor = True
        '
        'Edit_SaveButton
        '
        Me.Edit_SaveButton.Location = New System.Drawing.Point(166, 424)
        Me.Edit_SaveButton.Name = "Edit_SaveButton"
        Me.Edit_SaveButton.Size = New System.Drawing.Size(62, 23)
        Me.Edit_SaveButton.TabIndex = 14
        Me.Edit_SaveButton.Text = "Edit"
        Me.Edit_SaveButton.UseVisualStyleBackColor = True
        '
        'Add_SaveButton
        '
        Me.Add_SaveButton.Location = New System.Drawing.Point(88, 424)
        Me.Add_SaveButton.Name = "Add_SaveButton"
        Me.Add_SaveButton.Size = New System.Drawing.Size(62, 23)
        Me.Add_SaveButton.TabIndex = 13
        Me.Add_SaveButton.Text = "Add"
        Me.Add_SaveButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(161, 84)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(139, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(161, 110)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(139, 20)
        Me.LastNameTextBox.TabIndex = 2
        '
        'LocationIDTextBox
        '
        Me.LocationIDTextBox.Location = New System.Drawing.Point(161, 136)
        Me.LocationIDTextBox.Name = "LocationIDTextBox"
        Me.LocationIDTextBox.Size = New System.Drawing.Size(139, 20)
        Me.LocationIDTextBox.TabIndex = 3
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Location = New System.Drawing.Point(161, 162)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(139, 20)
        Me.PositionTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(161, 188)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(139, 20)
        Me.AddressTextBox.TabIndex = 5
        '
        'CItyTextBox
        '
        Me.CItyTextBox.Location = New System.Drawing.Point(161, 214)
        Me.CItyTextBox.Name = "CItyTextBox"
        Me.CItyTextBox.Size = New System.Drawing.Size(139, 20)
        Me.CItyTextBox.TabIndex = 6
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(161, 240)
        Me.StateTextBox.MaxLength = 2
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(26, 20)
        Me.StateTextBox.TabIndex = 7
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(161, 266)
        Me.PhoneTextBox.MaxLength = 10
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(83, 20)
        Me.PhoneTextBox.TabIndex = 8
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.Location = New System.Drawing.Point(161, 292)
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(139, 20)
        Me.EmailIDTextBox.TabIndex = 9
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(161, 318)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(139, 20)
        Me.PasswordTextBox.TabIndex = 10
        '
        'OwnerFlagTextBox
        '
        Me.OwnerFlagTextBox.Location = New System.Drawing.Point(161, 344)
        Me.OwnerFlagTextBox.MaxLength = 1
        Me.OwnerFlagTextBox.Name = "OwnerFlagTextBox"
        Me.OwnerFlagTextBox.Size = New System.Drawing.Size(26, 20)
        Me.OwnerFlagTextBox.TabIndex = 11
        '
        'FirstLoginTextBox
        '
        Me.FirstLoginTextBox.Location = New System.Drawing.Point(161, 370)
        Me.FirstLoginTextBox.MaxLength = 1
        Me.FirstLoginTextBox.Name = "FirstLoginTextBox"
        Me.FirstLoginTextBox.Size = New System.Drawing.Size(26, 20)
        Me.FirstLoginTextBox.TabIndex = 12
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'MainErrorProvider
        '
        Me.MainErrorProvider.ContainerControl = Me
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 477)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraWindoorsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EmpSearchLabel As System.Windows.Forms.Label
    Friend WithEvents XtraWindoorsDataSet As XtraWindoors.XtraWindoorsDataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Delete_CancelButton As System.Windows.Forms.Button
    Friend WithEvents Edit_SaveButton As System.Windows.Forms.Button
    Friend WithEvents Add_SaveButton As System.Windows.Forms.Button
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocationIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PositionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CItyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OwnerFlagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstLoginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmpIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ClearSearchButton As System.Windows.Forms.Button
    Friend WithEvents EmpPhoneSearchButton As System.Windows.Forms.Button
    Friend WithEvents EMPIDSearchButton As System.Windows.Forms.Button
    Friend WithEvents PhoneSearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeIDSearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeTableAdapter As XtraWindoors.XtraWindoorsDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents HomeButton As System.Windows.Forms.Button
    Friend WithEvents MainErrorProvider As System.Windows.Forms.ErrorProvider

End Class
