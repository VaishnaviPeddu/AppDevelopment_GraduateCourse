'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Employee Form 

Imports System.Net.Mail
Public Class EmployeeForm

    Private AXtraWindoorsDataSet As New XtraWindoorsDataSet
    Private AEmployeeTableAdapter As New XtraWindoorsDataSetTableAdapters.EmployeeTableAdapter
    Private ALocationTableAdapter As New XtraWindoorsDataSetTableAdapters.LocationTableAdapter
    Private AEmployeeBindingSource As New BindingSource
    Private AEmployeeGridBindingSource As New BindingSource
    Private AddFlag As Boolean
    Private EditFlag As Boolean
    'Public Property EnforceConstraints As Boolean

    Private Sub EmployeeForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'XtraWindoorsDataSet.Employee' table. You can move, or remove it, as needed.
        'Me.EmployeeTableAdapter.Fill(Me.XtraWindoorsDataSet.Employee) 
        'EnforceConstraints = False
        Try
            AEmployeeTableAdapter = New XtraWindoorsDataSetTableAdapters.EmployeeTableAdapter
            AXtraWindoorsDataSet = New XtraWindoorsDataSet
            AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
            AEmployeeBindingSource = New BindingSource
            AEmployeeGridBindingSource = New BindingSource

            With AEmployeeBindingSource
                .DataSource = AXtraWindoorsDataSet
                .DataMember = "Employee"
            End With

            'With AEmployeeGridBindingSource
            '    .DataSource = AStorageDataSet
            '    .DataMember = "Employee"
            '    .Sort = "EmployeeID"
            'End With

            With EmpIDComboBox
                .DataSource = AEmployeeBindingSource
                .DisplayMember = "EmpID"
                .DataBindings.Add("text", AEmployeeBindingSource, "EmpID", False, DataSourceUpdateMode.Never)
            End With
            FirstNameTextBox.DataBindings.Add("text", AEmployeeBindingSource, "FirstName")
            LastNameTextBox.DataBindings.Add("text", AEmployeeBindingSource, "LastName")
            LocationIDTextBox.DataBindings.Add("text", AEmployeeBindingSource, "LocationID")
            PositionTextBox.DataBindings.Add("text", AEmployeeBindingSource, "Position")
            AddressTextBox.DataBindings.Add("text", AEmployeeBindingSource, "Address")
            CItyTextBox.DataBindings.Add("text", AEmployeeBindingSource, "City")
            StateTextBox.DataBindings.Add("text", AEmployeeBindingSource, "State")
            PhoneTextBox.DataBindings.Add("text", AEmployeeBindingSource, "Phone")
            EmailIDTextBox.DataBindings.Add("text", AEmployeeBindingSource, "EmailID")
            PasswordTextBox.DataBindings.Add("text", AEmployeeBindingSource, "Password")
            OwnerFlagTextBox.DataBindings.Add("text", AEmployeeBindingSource, "OwnerFlag")
            FirstLoginTextBox.DataBindings.Add("text", AEmployeeBindingSource, "FirstLogin")
            SetFieldsforReadonly()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Add_SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles Add_SaveButton.Click
        EmpIDComboBox.SelectedIndex = -1
        If Add_SaveButton.Text = "Add" Then
            Add_SaveButton.Text = "Save"
            Delete_CancelButton.Text = "Cancel"
            Edit_SaveButton.Text = "Edit"
            Edit_SaveButton.Enabled = False
            AddFlag = True
            EditFlag = False
            SetFieldsforEditing()
        ElseIf Add_SaveButton.Text = "Save" Then
            Add_SaveButton.Text = "Add"
            Delete_CancelButton.Text = "Delete"
            Edit_SaveButton.Text = "Edit"
            Edit_SaveButton.Enabled = True
            'SetFieldsforReadonly()


            If FirstLoginTextBox.Text = "1" Then
                Try
                    Dim SmtpServer As New SmtpClient()
                    Dim mail As New MailMessage()
                    SmtpServer.Credentials = New  _
          Net.NetworkCredential("xtrawindoors@gmail.com", "GalaxySoft")
                    SmtpServer.Port = 587
                    SmtpServer.EnableSsl = True
                    SmtpServer.Host = "smtp.gmail.com"
                    mail = New MailMessage()
                    mail.From = New MailAddress("xtrawindoors@gmail.com")
                    mail.To.Add(EmailIDTextBox.Text)
                    mail.Subject = "Initital Password from XTRAWINDOORS"
                    mail.Body = String.Format("Your new Password for Your Email account {0} is {1} SMTP mail from GMAIL", EmailIDTextBox.Text, PasswordTextBox.Text)
                    SmtpServer.Send(mail)
                    MsgBox("New password as been sent your mail")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

            Dim ANewEmployeeRow As DataRow = AXtraWindoorsDataSet.Employee.NewRow
            Dim ANewLocationRow As DataRow = AXtraWindoorsDataSet.Location.NewRow

            'ANewEmployeeRow("EmpID") = Convert.ToInt32(EmpIDComboBox.Text) 'EmployeeIDTextBox.Text 
            ANewEmployeeRow("LocationID") = LocationIDTextBox.Text
            ANewEmployeeRow("FirstName") = FirstNameTextBox.Text
            ANewEmployeeRow("LastName") = LastNameTextBox.Text
            ANewEmployeeRow("Position") = PositionTextBox.Text
            ANewEmployeeRow("Address") = AddressTextBox.Text
            ANewEmployeeRow("City") = CItyTextBox.Text
            ANewEmployeeRow("State") = StateTextBox.Text
            ANewEmployeeRow("Phone") = PhoneTextBox.Text
            ANewEmployeeRow("EmailID") = EmailIDTextBox.Text
            ANewEmployeeRow("Password") = PasswordTextBox.Text
            ANewEmployeeRow("OwnerFlag") = OwnerFlagTextBox.Text
            ANewEmployeeRow("FirstLogin") = FirstLoginTextBox.Text

            ANewLocationRow("LocationID") = LocationIDTextBox.Text

            Try
                ALocationTableAdapter.Update(AXtraWindoorsDataSet.Location)
                AXtraWindoorsDataSet.Employee.Rows.Add(ANewEmployeeRow)
                AEmployeeTableAdapter.Update(AXtraWindoorsDataSet.Employee)
                AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
                MessageBox.Show("New Employee Record has been Added to Database", "New Employee Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Add Record Error:" & ex.Message, "Add Record Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
            End Try
            SetFieldsforReadonly()
        End If
    End Sub

    Private Sub Edit_SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles Edit_SaveButton.Click
        If Edit_SaveButton.Text = "Edit" Then
            Add_SaveButton.Text = "Add"
            Add_SaveButton.Enabled = False
            Edit_SaveButton.Text = "Save"
            Delete_CancelButton.Text = "Cancel"
            EditFlag = True
            AddFlag = False
            SetFieldsforEditing()
        ElseIf Edit_SaveButton.Text = "Save" Then
            Edit_SaveButton.Text = "Edit"
            Delete_CancelButton.Text = "Delete"
            Add_SaveButton.Enabled = True
            Try
                AEmployeeBindingSource.EndEdit()
                AEmployeeTableAdapter.Update(AXtraWindoorsDataSet.Employee)
                ''Refresh dataset from physical Database
                Dim i As Integer = AEmployeeBindingSource.Position
                AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
                AEmployeeBindingSource.Position = i
                MessageBox.Show("The record has been updated to the database successfully!", "Record updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Update Record error:" & ex.Message, "Update Record Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
            End Try
            SetFieldsforReadonly()
        End If
    End Sub

    Private Sub Delete_CancelButton_Click(sender As System.Object, e As System.EventArgs) Handles Delete_CancelButton.Click
        If Delete_CancelButton.Text = "Delete" Then
            If MessageBox.Show("Delete current record? Click 'Yes' to delete, 'No' to cancel.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If AEmployeeBindingSource.Count > 0 Then
                    Try
                        AEmployeeBindingSource.RemoveCurrent()
                        AEmployeeTableAdapter.Update(AXtraWindoorsDataSet.Employee)
                        AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
                        MessageBox.Show("Record is deleted successfully", "Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Add_SaveButton.Text = "Add"
                        Edit_SaveButton.Text = "Edit"
                        Add_SaveButton.Enabled = True
                        Edit_SaveButton.Enabled = True
                        SetFieldsforReadonly()
                    Catch ex As Exception
                        MessageBox.Show("Delete record error: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
                    End Try
                End If
            End If
        ElseIf Delete_CancelButton.Text = "Cancel" Then
            If MessageBox.Show("Unsaved Data will be lost. Do you want to Cancel?", "Cancel?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = Windows.Forms.DialogResult.OK Then
                Add_SaveButton.Text = "Add"
                Edit_SaveButton.Text = "Edit"
                Add_SaveButton.Enabled = True
                Edit_SaveButton.Enabled = True
                Delete_CancelButton.Text = "Delete"
                SetFieldsforReadonly()
                Dim i As Integer = AEmployeeBindingSource.Position
                AEmployeeTableAdapter.Fill(AXtraWindoorsDataSet.Employee)
                AEmployeeBindingSource.Position = i
            End If
        End If
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Sub SetFieldsforEditing()
        If AddFlag = True Then
            EmpIDComboBox.DropDownStyle = ComboBoxStyle.Simple
            EmpIDComboBox.Enabled = False
            EmpIDComboBox.Text = ""
            LocationIDTextBox.Text = ""
            FirstNameTextBox.Text = ""
            LastNameTextBox.Text = ""
            PositionTextBox.Text = ""
            AddressTextBox.Text = ""
            CItyTextBox.Text = ""
            StateTextBox.Text = ""
            PhoneTextBox.Text = ""
            EmailIDTextBox.Text = ""
            PasswordTextBox.Text = ""
            OwnerFlagTextBox.Text = ""
            FirstLoginTextBox.Text = ""
        Else
        End If
        FirstNameTextBox.Enabled = True
        LocationIDTextBox.Enabled = True
        LastNameTextBox.Enabled = True
        PositionTextBox.Enabled = True
        AddressTextBox.Enabled = True
        CItyTextBox.Enabled = True
        StateTextBox.Enabled = True
        PhoneTextBox.Enabled = True
        EmailIDTextBox.Enabled = True
        PasswordTextBox.Enabled = True
        OwnerFlagTextBox.Enabled = True
        FirstLoginTextBox.Enabled = True
    End Sub

    Sub SetFieldsforReadonly()
        EmpIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        EmpIDComboBox.Enabled = True
        LocationIDTextBox.Enabled = False
        FirstNameTextBox.Enabled = False
        LastNameTextBox.Enabled = False
        PositionTextBox.Enabled = False
        AddressTextBox.Enabled = False
        CItyTextBox.Enabled = False
        StateTextBox.Enabled = False
        PhoneTextBox.Enabled = False
        EmailIDTextBox.Enabled = False
        PasswordTextBox.Enabled = False
        OwnerFlagTextBox.Enabled = False
        FirstLoginTextBox.Enabled = False
    End Sub

    Private Sub EMPIDSearchButton_Click(sender As System.Object, e As System.EventArgs) Handles EMPIDSearchButton.Click
        Try
            Me.EmployeeTableAdapter.FillByEmpID(Me.XtraWindoorsDataSet.Employee, EmployeeIDSearchTextBox.Text)
        Catch ex As Exception
            MessageBox.Show(" There is no record exist !!")
        End Try
    End Sub

    Private Sub EmpPhoneSearchButton_Click(sender As System.Object, e As System.EventArgs) Handles EmpPhoneSearchButton.Click
        Try
            Me.EmployeeTableAdapter.FillByPhone(Me.XtraWindoorsDataSet.Employee, PhoneSearchTextBox.Text)
        Catch ex As Exception
            MessageBox.Show(" There is no record exist !!")
        End Try
    End Sub

    Private Sub ClearSearchButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearSearchButton.Click
        PhoneSearchTextBox.Clear()
        EmployeeIDSearchTextBox.Clear()
        EmployeeDataGridView.Refresh()
    End Sub

    Private Sub HomeButton_Click(sender As System.Object, e As System.EventArgs) Handles HomeButton.Click
        Me.Hide()
        HomePageScreen.Show()
    End Sub


    Private Sub BookingForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        HomePageScreen.Show()
    End Sub

    Private Sub StateTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles StateTextBox.Validating
        Dim StateInput As String
        StateInput = StateTextBox.Text
        Dim lengthValid As Boolean = StateInput.Length.Equals(2)
        If Not lengthValid Then
            MainErrorProvider.SetError(StateTextBox, "Invalid State, must be 2 Character")
        End If
    End Sub

    Private Sub PhoneTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles StateTextBox.Validating
        Dim phoCode As String
        phoCode = PhoneTextBox.Text
        Dim lengthValid As Boolean = phoCode.Length.Equals(5)
        If Not lengthValid Then
            MainErrorProvider.SetError(StateTextBox, "Invalid Phone, must be 10 digits")
        End If
    End Sub
End Class
