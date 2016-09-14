'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Booking Form 

'Final Copy
Imports System.Net.Mail
Public Class BookingForm
   
    Private AddingBoolean As Boolean = False
    Private EditingBoolean As Boolean = False
    Private ClosingBoolean As Boolean = False
    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.XtraWindoorsDataSet)
    End Sub

    Private Sub BookingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.InvoiceTableAdapter.Fill(Me.XtraWindoorsDataSet.Invoice)
        Me.AccessoriesTableAdapter.Fill(Me.XtraWindoorsDataSet.Accessories)
        Me.StorageTableAdapter.Fill(Me.XtraWindoorsDataSet.Storage)
        Me.StorageTypeTableAdapter.Fill(Me.XtraWindoorsDataSet.StorageType)
        Me.CustomerTableAdapter.Fill(Me.XtraWindoorsDataSet.Customer)
        'bind the form controls

        ClearPanel()
        SetControlsReadOnly(False)
        SetValues()

        Dim Qty As New DataGridViewComboBoxColumn()
        With Qty
            '.Width = 30
            .HeaderText = "Quantity"
            .Name = "Qty"
            .MaxDropDownItems = 4
            .Items.Add("1")
            .Items.Add("2")
            .Items.Add("3")
            .Items.Add("4")
        End With
        AccesoriesDataGridView.Columns.Add(Qty)

        Dim chk As New DataGridViewCheckBoxColumn()
        AccesoriesDataGridView.Columns.Add(chk)
        With chk
            .HeaderText = "Cart"
            .Name = "chk"
            .Width = 30
        End With
        AccesoriesDataGridView.Rows(2).Cells(0).Value = True

        LeaseDataGridView.Columns(1).HeaderText = "Active"
        LeaseDataGridView.Columns(1).Width = 60
        LeaseDataGridView.Columns(2).HeaderText = "Cancelled"
        LeaseDataGridView.Columns(2).Width = 65

        StorageIDTextBox.Text = ""
        StorageIDTextBox.Focus()
    End Sub


    Private Sub SearchIDButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchIDButton.Click
        Try
            LeaseDataGridView.Visible = True
            'TODO: This line of code loads data into the 'XtraWindoorsDataSet.Lease' table. You can move, or remove it, as needed.
            'Me.LeaseBindingSource.DataSource = XtraWindoorsDataSet.Lease
            Me.LeaseTableAdapter.FillByStorageID(Me.XtraWindoorsDataSet.Lease, StorageIDTextBox.Text)
            Me.CustomerTableAdapter.Fill(Me.XtraWindoorsDataSet.Customer)
            Me.CustomerBindingSource.Filter = "CustomerID = '" & CustomerIDTextBox.Text & "'"
            Me.StorageTypeTableAdapter.FillByStorageID(Me.XtraWindoorsDataSet.StorageType, StorageIDTextBox.Text)
            SetControlsReadOnly(False)
            FirstNameTextBox.Text = FirstNameComboBox.Text
            StorageIDTextBox.Text = StorageIDTextBox1.Text
        Catch ex As System.Exception
            MessageBox.Show("No record found")
            ClearPanel()
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchCustomerButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchCustomerButton.Click
        Try
            LeaseDataGridView.Visible = True
            'TODO: This line of code loads data into the 'XtraWindoorsDataSet.Lease' table. You can move, or remove it, as needed.
            Me.LeaseTableAdapter.FillByFirstName(Me.XtraWindoorsDataSet.Lease, FirstNameTextBox.Text)
            Me.StorageTypeTableAdapter.FillByFirstName(Me.XtraWindoorsDataSet.StorageType, FirstNameTextBox.Text)
            Me.CustomerTableAdapter.Fill(Me.XtraWindoorsDataSet.Customer)
            Me.CustomerBindingSource.Filter = "CustomerID = '" & CustomerIDTextBox.Text & "'"

        Catch ex As System.Exception
            MessageBox.Show("No record found")
            ClearPanel()
        End Try
        SetControlsReadOnly(False)
    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles FirstNameTextBox.TextChanged
        If String.IsNullOrWhiteSpace(FirstNameTextBox.Text) Then
            SearchCustomerButton.Enabled = False
        Else
            SearchCustomerButton.Enabled = True
        End If
    End Sub

    Private Sub StorageIDTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles StorageIDTextBox.TextChanged
        If String.IsNullOrWhiteSpace(StorageIDTextBox.Text) And ShowRadioButton.Checked = True Then
            LeaseDataGridView.DataSource = LeaseBindingSource
            LeaseBindingSource.Filter = Nothing
            Me.LeaseTableAdapter.Fill(Me.XtraWindoorsDataSet.Lease)
        ElseIf String.IsNullOrWhiteSpace(StorageIDTextBox.Text) Then
            SearchIDButton.Enabled = False
        Else
            SearchIDButton.Enabled = True
        End If
    End Sub

    Private Sub NumberOfMonthTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles NumberOfMonthTextBox.TextChanged
        Try
            If String.IsNullOrWhiteSpace(NumberOfMonthTextBox.Text) = False And String.IsNullOrWhiteSpace(TypePriceTextBox.Text) = False Then
                CostTextBox.Text = TypePriceTextBox.Text * NumberOfMonthTextBox.Text
                CheckOutDateTimePicker.Value = CheckOutDateTimePicker.Value.AddMonths(NumberOfMonthTextBox.Text)
            Else
                CostTextBox.Text = ""
                CheckOutDateTimePicker.Value = System.DateTime.Today
            End If
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FilterRadioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles FilterRadioButton.CheckedChanged
        ClearPanel()
        LeaseDataGridView.Visible = False
        'ClearGrid()
    End Sub

    Private Sub ShowRadioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles ShowRadioButton.CheckedChanged
        ClearPanel()
        LeaseDataGridView.Visible = True
        ShowGrid()
    End Sub


    Private Sub LeaseDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles LeaseDataGridView.CellClick
        Try
            Dim i As Integer
            i = LeaseDataGridView.CurrentRow.Index
            Me.StorageIDTextBox.Text = Me.LeaseDataGridView.Item(0, i).Value
            Me.StorageIDTextBox1.Text = Me.StorageIDTextBox.Text
            'TODO: This line of code loads data into the 'XtraWindoorsDataSet.Lease' table. You can move, or remove it, as needed.
            'Me.LeaseTableAdapter.FillByStorageID(Me.XtraWindoorsDataSet.Lease, StorageIDTextBox.Text)
            Me.CustomerTableAdapter.Fill(Me.XtraWindoorsDataSet.Customer)
            Me.CustomerBindingSource.Filter = "CustomerID = '" & CustomerIDTextBox.Text & "'"
            Me.StorageTypeTableAdapter.FillByStorageID(Me.XtraWindoorsDataSet.StorageType, StorageIDTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub LeaseDataGridView_DataBindingComplete(sender As Object, e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) Handles LeaseDataGridView.DataBindingComplete
        Try
            Dim i As Integer
            i = LeaseDataGridView.CurrentRow.Index
            Me.StorageIDTextBox.Text = Me.LeaseDataGridView.Item(0, i).Value
            Me.StorageIDTextBox1.Text = Me.LeaseDataGridView.Item(0, i).Value
        Catch ex As Exception
        End Try
    End Sub

    Private Function GridViewRow() As Object
        Throw New NotImplementedException
    End Function



    Private Sub AddSaveButton_Click(sender As System.Object, e As System.EventArgs) Handles AddSaveButton.Click
        If AddSaveButton.Text = "&Add" Then
            'Add Button is clicked 

            ClearPanel()
            AddingBoolean = True
            SetControlsReadOnly(True)
            SetButtonForEdit()
            AddSaveButton.Text = "&Save"
            CustomerBindingSource.Filter = Nothing
            StorageTypeBindingSource.Filter = Nothing
            btnCheck.Enabled = True
            btnCancelLease.Enabled = True
            LeaseIDTextBox.Visible = False
            'If String.IsNullOrEmpty(TypeSizeComboBox.Text) Then
            'Else
            '    StorageTypeBindingSource.Filter = "TypeSize = '" & TypeSizeComboBox.Text & "'"
            '    StorageIDTextBox.Text = Me.StorageTableAdapter.FillByStorageAvail(Me.XtraWindoorsDataSet.Storage, TypeSizeComboBox.Text)
            'End If
        Else
            Try
                Dim ctl1 As Control
                For Each ctl1 In SplitContainer1.Panel2.Controls
                    If TypeOf ctl1 Is TextBox Then
                        If IsNothing(ctl1) Then
                            BookingErrorProvider.SetError(ctl1, "Manditory Field")
                        End If
                    ElseIf TypeOf ctl1 Is ComboBox Then
                        If IsNothing(ctl1) Then
                            BookingErrorProvider.SetError(ctl1, "Manditory Field")
                        End If
                    End If
                Next
                Dim q, c, Acctotal As Int32
                Acctotal = 0
                For Each row As DataGridViewRow In AccesoriesDataGridView.Rows

                    If row.Cells("chk").Value = True Then
                        q = row.Cells("Qty").Value
                        c = row.Cells(1).Value
                        If q = 0 Then
                            Acctotal = Acctotal + (1 * c).ToString
                        Else
                            Acctotal = Acctotal + (q * c).ToString
                        End If

                    End If
                Next
                If String.IsNullOrWhiteSpace(CostTextBox.Text) Then
                    CostTextBox.Text = 0
                End If
                CostTextBox.Text = Acctotal + CostTextBox.Text
                LeaseBindingSource.EndEdit()
                btnCancelLease.Enabled = False
                btnCheck.Enabled = False
                LeaseIDTextBox.Visible = True


                Dim ANewLeaseRow As DataRow = XtraWindoorsDataSet.Lease.NewRow
               
                ANewLeaseRow("CustomerID") = FirstNameComboBox.SelectedValue
                ANewLeaseRow("StorageID") = StorageIDTextBox1.Text
                ANewLeaseRow("LeaseActive") = 1
                ANewLeaseRow("CheckIn") = CheckInDateTimePicker.Value
                ANewLeaseRow("CheckOut") = CheckOutDateTimePicker.Value
                ANewLeaseRow("LeaseCancelled") = 0
                XtraWindoorsDataSet.Lease.Rows.Add(ANewLeaseRow)

                'declare a variable to add a row to the dataset 
          
                'Update data to database
                LeaseTableAdapter.Update(XtraWindoorsDataSet.Lease)

                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(False)
                ResetButtonafterEdit()

                Try
                    Dim SmtpServer As New SmtpClient()
                    Dim mail As New MailMessage()
                    SmtpServer.Credentials = New Net.NetworkCredential("xtrawindoors@gmail.com", "GalaxySoft")
                    SmtpServer.Port = 587
                    SmtpServer.EnableSsl = True
                    SmtpServer.Host = "smtp.gmail.com"
                    mail = New MailMessage()
                    mail.From = New MailAddress("xtrawindoors@gmail.com")
                    mail.To.Add(EmailTextBox1.Text)
                    mail.Subject = "Booking Confirmation for Unit " & StorageIDTextBox1.Text
                    mail.Body = String.Format("Congrats! Your booking has been confirmed." & vbNewLine & " Assigned Unit : {0} " & vbNewLine & "Check-in: {1}" & vbNewLine & " Check-out: {2}", StorageIDTextBox1.Text, CheckInDateTimePicker.Text, CheckOutDateTimePicker.Text)
                    SmtpServer.Send(mail)
                    MsgBox("Booking Confirmation E-mail delivered")
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try


            Catch ex As Exception
                MessageBox.Show("DataBase Operation Error :" & ex.Message, "Adding Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub DeleteCancelButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteCancelButton.Click
        'Delete the current record after coonfirming or cancel and add or Edit
        Dim DeleteDialogResult As DialogResult
        Try
            If DeleteCancelButton.Text = "&Delete" Then
                'delete records
                DeleteDialogResult = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DeleteDialogResult = Windows.Forms.DialogResult.Yes Then
                    LeaseBindingSource.RemoveCurrent()
                    LeaseTableAdapter.Update(XtraWindoorsDataSet.Lease)
                End If
            Else
                'Cancel button is clicked
                LeaseBindingSource.CancelEdit()
                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(False)
                btnCancelLease.Enabled = False
                btnCancelLease.Enabled = False
                LeaseIDTextBox.Visible = True
                btnCheck.Enabled = False
                ResetButtonafterEdit()
                ClearPanel()
            End If
        Catch ex As Exception
            MessageBox.Show("unable to complete the delete/cancel operation:" & ex.Message, "Delete/Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub ClearPanel()
        Dim ctl1 As Control
        For Each ctl1 In SplitContainer1.Panel2.Controls
            If TypeOf ctl1 Is TextBox Then
                ctl1.Text = ""
            ElseIf TypeOf ctl1 Is ComboBox Then
                ctl1.Text = ""
            End If
        Next
    End Sub

    Private Sub SetControlsReadOnly(ByVal ValueBoolean As Boolean)

        Dim ctl1 As Control
        For Each ctl1 In SplitContainer1.Panel2.Controls
            If TypeOf ctl1 Is TextBox Then
                ctl1.Enabled = ValueBoolean
            ElseIf TypeOf ctl1 Is ComboBox Then
                ctl1.Enabled = ValueBoolean
            ElseIf TypeOf ctl1 Is DateTimePicker Then
                ctl1.Enabled = ValueBoolean
            ElseIf TypeOf ctl1 Is DataGridView Then
                ctl1.Visible = ValueBoolean
            End If
            CustomerIDTextBox.Enabled = False
            LeaseIDTextBox.Enabled = False
        Next
    End Sub

    Private Sub ResetButtonafterEdit()
        AddSaveButton.Text = "&Add"
        DeleteCancelButton.Text = "&Delete"
        EditButton.Enabled = True
    End Sub

    Private Sub EditButton_Click(sender As System.Object, e As System.EventArgs) Handles EditButton.Click
        EditingBoolean = True
        btnCancelLease.Enabled = True
        SetControlsReadOnly(True)
        'SetButtonForEdit()

        If EditButton.Text = "&Edit" Then
            'Edit Button is clicked 

            EditingBoolean = True
            SetControlsReadOnly(True)
            EditButton.Text = "&Update"
            'SetButtonForEdit()
        Else
            Try
                Dim ctl1 As Control
                For Each ctl1 In SplitContainer1.Panel2.Controls
                    If TypeOf ctl1 Is TextBox Then
                        If IsNothing(ctl1) Then
                            BookingErrorProvider.SetError(ctl1, "Manditory Field")
                        End If
                    ElseIf TypeOf ctl1 Is ComboBox Then
                        If IsNothing(ctl1) Then
                            BookingErrorProvider.SetError(ctl1, "Manditory Field")
                        End If
                    End If
                Next
                Dim q, c, Acctotal As Int32
                Acctotal = 0
                For Each row As DataGridViewRow In AccesoriesDataGridView.Rows

                    If row.Cells("chk").Value = True Then
                        q = row.Cells("Qty").Value
                        c = row.Cells(1).Value
                        If q = 0 Then
                            Acctotal = Acctotal + (1 * c).ToString
                        Else
                            Acctotal = Acctotal + (q * c).ToString
                        End If

                    End If
                Next
                If String.IsNullOrWhiteSpace(CostTextBox.Text) Then
                    CostTextBox.Text = 0
                End If
                CostTextBox.Text = Acctotal + CostTextBox.Text
                LeaseBindingSource.EndEdit()
                btnCancelLease.Enabled = False


                'Dim ANewLeaseRow As DataRow = XtraWindoorsDataSet.Lease.NewRow

                'ANewLeaseRow("StorageID") = StorageIDTextBox1.Text
                'ANewLeaseRow("CheckIn") = CheckInDateTimePicker.Value
                'ANewLeaseRow("CheckOut") = CheckOutDateTimePicker.Value
                'XtraWindoorsDataSet.Lease.Rows.Add(ANewLeaseRow)

                ' ''declare a variable to add a row to the dataset 

                ''Update data to database
                'LeaseBindingSource.EndEdit()
                'LeaseTableAdapter.Update(ANewLeaseRow)
                XtraWindoorsDataSet.Tables("Lease").Rows(0).Item("StorageID") = StorageIDTextBox1.Text
                XtraWindoorsDataSet.Tables("Lease").Rows(0).Item("CheckIn") = CheckInDateTimePicker.Value
                XtraWindoorsDataSet.Tables("Lease").Rows(0).Item("CheckOut") = CheckOutDateTimePicker.Value
                'Update data to database
                LeaseBindingSource.EndEdit()
                LeaseTableAdapter.Update(XtraWindoorsDataSet.Lease)


                MessageBox.Show("The record has been updated to the database successfully!", "Record updated", MessageBoxButtons.OK, MessageBoxIcon.Information)

                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(False)
                EditButton.Text = "&Edit"
            Catch ex As Exception
                MessageBox.Show("DataBase Operation Error :" & ex.Message, "Adding Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub SetButtonForEdit()
        AddSaveButton.Text = "&Save"
        DeleteCancelButton.Text = "&Cancel"
        EditButton.Enabled = False
    End Sub

    Private Sub SetValues()
        With FirstNameComboBox
            .DataSource = CustomerBindingSource
            .DisplayMember = "FirstName"
            .ValueMember = "CustomerID"
            .DataBindings.Add("text", CustomerBindingSource, "FirstName", False, DataSourceUpdateMode.Never)
            .SelectedIndex = -1
        End With

        With LastNameComboBox
            .DataSource = CustomerBindingSource
            .DisplayMember = "LastName"
            .ValueMember = "CustomerID"
            .DataBindings.Add("text", CustomerBindingSource, "LastName", False, DataSourceUpdateMode.Never)
            .SelectedIndex = -1
        End With

        With TypeSizeComboBox
            .DataSource = StorageTypeBindingSource
            .DisplayMember = "TypeSize"
            .ValueMember = "StorageTypeID"
            .DataBindings.Add("text", StorageTypeBindingSource, "TypeSize", False, DataSourceUpdateMode.Never)
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ClearGrid()
        CustomerBindingSource.Filter = ""
        LeaseDataGridView.DataSource = Nothing
        'LeaseDataGridView.Refresh()
    End Sub

    Private Sub ShowGrid()
        LeaseDataGridView.DataSource = LeaseBindingSource
        Me.LeaseTableAdapter.Fill(Me.XtraWindoorsDataSet.Lease)
        LeaseDataGridView.Columns(1).HeaderText = "Active"
        LeaseDataGridView.Columns(1).Width = 50
        LeaseDataGridView.Columns(2).HeaderText = "Cancelled"
        LeaseDataGridView.Columns(2).Width = 55
    End Sub

    'Private Sub EmailTextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles EmailTextBox1.TextChanged
    '    Dim myRowView As DataRowView = CustomerBindingSource.Current
    '    CustomerIDTextBox.Text = (myRowView.Item("CustomerID"))
    'End Sub

    Private Sub btnCheck_Click(sender As System.Object, e As System.EventArgs) Handles btnCheck.Click
        If TypeSizeComboBox.SelectedIndex = -1 Then

        Else
            CheckAvailability.GetStorageID(TypeSizeComboBox.SelectedValue)
            CheckAvailability.Show()
        End If
    End Sub

    Private Sub HomeButton_Click(sender As System.Object, e As System.EventArgs) Handles HomeButton.Click
        Me.Close()
        HomePageScreen.Show()
    End Sub

    Private Sub BookingForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        HomePageScreen.Show()
    End Sub

    Private Sub btnCancelLease_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelLease.Click

        Dim DeleteDialogResult As DialogResult
        DeleteDialogResult = MessageBox.Show("Cancel current Lease? Click 'Yes' to delete, 'No' to cancel.", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If DeleteDialogResult = Windows.Forms.DialogResult.Yes Then
            CheckOutDateTimePicker.Value = System.DateTime.Now
            MessageBox.Show("The Lease has been cancelled!", "Fine updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If String.IsNullOrWhiteSpace(CostTextBox.Text) Then
                CostTextBox.Text = 0
            End If
            CostTextBox.Text = 50 + CostTextBox.Text

            XtraWindoorsDataSet.Tables("Lease").Rows(0).Item("LeaseCancelled") = 1
            'Update data to database
            LeaseBindingSource.EndEdit()
            LeaseTableAdapter.Update(XtraWindoorsDataSet.Lease)
        End If
        
    End Sub

End Class
