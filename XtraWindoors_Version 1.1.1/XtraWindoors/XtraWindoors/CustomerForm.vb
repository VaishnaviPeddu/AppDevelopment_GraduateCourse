'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Customer Form 

Public Class CustomerForm

    ' Module-level declarations.
    Private AxtrawindoorsDateSet As New XtraWindoorsDataSet
    Private ACustomertableAdapter As New XtraWindoorsDataSetTableAdapters.CustomerTableAdapter
    Private WithEvents ACustomerBindingSource As BindingSource

    Private AddingBoolean As Boolean = False
    Private EditingBoolean As Boolean = False
    Private ClosingBoolean As Boolean = False

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.XtraWindoorsDataSet)

    End Sub


    Private Sub CustomerForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'AAAStorageDataSet.Customer' table. You can move, or remove it, as needed.
        'Me.CustomerTableAdapter.Fill(Me.AAAStorageDataSet.Customer)
        MainErrorProvider.Clear()
    End Sub

    Private Sub SetControlsReadOnly(ByVal ValueBoolean As Boolean)
        CustomerIDTextBox.ReadOnly = ValueBoolean
        PhoneTextBox.ReadOnly = ValueBoolean
        FirstNameTextBox.ReadOnly = ValueBoolean
        LastNameTextBox.ReadOnly = ValueBoolean
        AddressTextBox.ReadOnly = ValueBoolean
        CityTextBox.ReadOnly = ValueBoolean
        StateTextBox.ReadOnly = ValueBoolean
        ZipTextBox.ReadOnly = ValueBoolean
        EmailTextBox.ReadOnly = ValueBoolean
    End Sub
    Private Sub SetButtonForEdit()
        AddSaveButton.Text = "Save"
        DeleteCancelButton.Text = "Cancel"
        EditButton.Enabled = False
    End Sub
    Private Sub ResetButtonafterEdit()
        AddSaveButton.Text = " Add"
        DeleteCancelButton.Text = "Delete"
        EditButton.Enabled = True
    End Sub

    Private Sub ExitProc()
        Dim ADialogResult As DialogResult
        ADialogResult = MessageBox.Show("Do you Want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If ADialogResult = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Call ExitProc()
    End Sub

    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        Try
            CustomerBindingSource.Filter = ""
            CustomerDataGridView.DataSource = Nothing
            CustomerDataGridView.Refresh()

            Dim ctl As Control
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is TextBox Then
                    ctl.Text = ""
                End If
            Next

            Dim ctl1 As Control
            For Each ctl1 In SplitContainer1.Panel1.Controls
                If TypeOf ctl1 Is TextBox Then
                    ctl1.Text = ""
                End If
            Next

            'Me.CustomerTableAdapter.Fill(Me.AAAStorageDataSet.Customer)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CustomerDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CustomerDataGridView.CellContentClick

        'TODO: This line of code loads data into the 'AAAStorageDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.XtraWindoorsDataSet.Customer)

        'retrieve the Orders information for the grid.  
        Dim CustomerIDString As String
        Static GridInitializedBoolean As Boolean = False

        'retrieve the ID of the selected store.  
        CustomerIDString = CustomerDataGridView.CurrentCell.Value.ToString

        'initialize the grid's binding.  
        If Not GridInitializedBoolean Then
            'bind and format the grid             
            'OrdersDataGridView.DataSource = OrderBindingSource
            'SetUpGridCoumns2()
            'GridInitializedBoolean = True
            'OrdersDataGridView.AllowUserToAddRows = False
            'OrdersDataGridView.AllowUserToDeleteRows = False
            'OrdersDataGridView.ReadOnly = True
        End If
        SetControlsReadOnly(False)

        'filter the grid's data.  
        'OrderBindingSource.Filter = "CustomerID = '" & CustomerIDString & "'"
    End Sub

    Dim WithEvents mPrintDocument As New Printing.PrintDocument
    Dim mPrintBitMap As Bitmap


    Private Sub m_PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles mPrintDocument.PrintPage
        ' Draw the image centered.
        Dim lWidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) \ 2
        Dim lHeight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) \ 2
        e.Graphics.DrawImage(mPrintBitMap, lWidth, lHeight)

        ' There's only one page.
        e.HasMorePages = False
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

        ' Copy the form's image into a bitmap.
        mPrintBitMap = New Bitmap(Me.Width, Me.Width)
        Dim lRect As System.Drawing.Rectangle
        lRect.Width = Me.Width
        lRect.Height = Me.Width
        Me.DrawToBitmap(mPrintBitMap, lRect)


        ' Make a PrintDocument and print.
        mPrintDocument = New Printing.PrintDocument
        mPrintDocument.Print()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Allow editing the current record.
        EditingBoolean = True
        SetControlsReadOnly(False)
        SetButtonForEdit()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        'Delete the current record after coonfirming or cancel and addd or Edit
        Dim DeleteDialogResult As DialogResult
        Try
            If DeleteCancelButton.Text = "Delete" Then
                'delete records
                DeleteDialogResult = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DeleteDialogResult = Windows.Forms.DialogResult.Yes Then
                    CustomerBindingSource.RemoveCurrent()
                    CustomerTableAdapter.Update(XtraWindoorsDataSet.Customer)
                End If
            Else
                'Cancel button is clicked
                CustomerBindingSource.CancelEdit()
                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(True)
                ResetButtonafterEdit()
            End If
        Catch ex As Exception
            MessageBox.Show("unable to complete the delete/cancel operation:" & ex.Message, "Delete/Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        If AddSaveButton.Text = "Add" Then
            'Add Button is clicked 
            Dim ctl As Control
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is TextBox Then
                    ctl.Text = ""
                End If
            Next

            With CustomerBindingSource
                .EndEdit()
                .AddNew()
            End With
            AddingBoolean = True
            SetControlsReadOnly(False)
            SetButtonForEdit()
            AddSaveButton.Text = "save"
            MainErrorProvider.Clear()

        Else
            'save button is Clicked
            Try

                If CustomerIDTextBox.Text = String.Empty Then
                    MainErrorProvider.SetError(CustomerIDTextBox, "CustomerID is a required Entry")

                ElseIf LastNameTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(LastNameTextBox, "Last Name is a required Entry")

                ElseIf FirstNameTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(FirstNameTextBox, " First Name is a required Entry.")

                ElseIf AddressTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(AddressTextBox, "Address is a required Entry")

                ElseIf CityTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(CityTextBox, "City is a required Entry")

                ElseIf StateTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(StateTextBox, "State is a required Entry")

                ElseIf ZipTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(ZipTextBox, "zip is a required Entry")

                ElseIf PhoneTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(PhoneTextBox, "Phone is a required Entry")


                ElseIf EmailTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(EmailTextBox, "Email is a required Entry")
                    PhoneTextBox.Focus()
                Else
                    CustomerBindingSource.EndEdit()
                    'Update data to database
                    CustomerTableAdapter.Update(XtraWindoorsDataSet.Customer)
                    AddingBoolean = False
                    EditingBoolean = False
                    SetControlsReadOnly(True)
                    ResetButtonafterEdit()


                End If
            Catch ex As Exception
                MessageBox.Show("DataBase Operation Error :" & ex.Message, "Adding Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Search2Button_Click(sender As System.Object, e As System.EventArgs) Handles Search2Button.Click
        Try
            CustomerDataGridView.DataSource = CustomerBindingSource
            Me.CustomerTableAdapter.FillByFirstName(Me.XtraWindoorsDataSet.Customer, CustomerNameTextBox1.Text)
            SetControlsReadOnly(True)
        Catch ex As Exception
            MessageBox.Show(" There is no record exist !!")
        End Try
    End Sub

    Private Sub Search1Button_Click(sender As System.Object, e As System.EventArgs) Handles Search1Button.Click
        Try
            CustomerDataGridView.DataSource = CustomerBindingSource
            Me.CustomerTableAdapter.FillByphone(Me.XtraWindoorsDataSet.Customer, CustomerPhoneTextBox1.Text)
            SetControlsReadOnly(True)
        Catch ex As System.Exception
            MessageBox.Show(" There is no record exist !!")
        End Try
    End Sub


    Private Sub DeleteCancelButton_Click_1(sender As System.Object, e As System.EventArgs) Handles DeleteCancelButton.Click
        'Delete the current record after coonfirming or cancel and addd or Edit
        Dim DeleteDialogResult As DialogResult
        Try
            If DeleteCancelButton.Text = "Delete" Then
                'delete records
                DeleteDialogResult = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DeleteDialogResult = Windows.Forms.DialogResult.Yes Then
                    CustomerBindingSource.RemoveCurrent()
                    CustomerTableAdapter.Update(XtraWindoorsDataSet.Customer)
                End If
            Else
                'Cancel button is clicked
                CustomerBindingSource.CancelEdit()
                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(True)
                ResetButtonafterEdit()
            End If
        Catch ex As Exception
            MessageBox.Show("unable to complete the delete/cancel operation:" & ex.Message, "Delete/Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub EditButton_Click_1(sender As System.Object, e As System.EventArgs) Handles EditButton.Click
        'Allow editing the current record.
        EditingBoolean = True
        SetControlsReadOnly(False)
        SetButtonForEdit()
    End Sub

    Private Sub CustomerIDTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CustomerIDTextBox.TextChanged
        MainErrorProvider.Clear()
    End Sub

    Private Sub AddSaveButton_Click(sender As System.Object, e As System.EventArgs) Handles AddSaveButton.Click
        If AddSaveButton.Text = "Add" Then
            'Add Button is clicked 
            Dim ctl As Control
            For Each ctl In GroupBox1.Controls
                If TypeOf ctl Is TextBox Then
                    ctl.Text = ""
                End If
            Next

            With CustomerBindingSource
                .EndEdit()
                .AddNew()
            End With
            AddingBoolean = True
            SetControlsReadOnly(False)
            SetButtonForEdit()
            AddSaveButton.Text = "save"
            MainErrorProvider.Clear()

        Else
            'save button is Clicked
            Try

                If CustomerIDTextBox.Text = String.Empty Then
                    MainErrorProvider.SetError(CustomerIDTextBox, "CustomerID is a required Entry")

                ElseIf LastNameTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(LastNameTextBox, "Last Name is a required Entry")

                ElseIf FirstNameTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(FirstNameTextBox, " First Name is a required Entry.")

                ElseIf AddressTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(AddressTextBox, "Address is a required Entry")

                ElseIf CityTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(CityTextBox, "City is a required Entry")

                ElseIf StateTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(StateTextBox, "State is a required Entry")

                ElseIf ZipTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(ZipTextBox, "zip is a required Entry")

                ElseIf PhoneTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(PhoneTextBox, "Phone is a required Entry")


                ElseIf EmailTextBox.Text = String.Empty Then
                    MainErrorProvider.Clear()
                    MainErrorProvider.SetError(EmailTextBox, "Email is a required Entry")
                    PhoneTextBox.Focus()
                Else
                    CustomerBindingSource.EndEdit()
                    'Update data to database
                    CustomerTableAdapter.Update(XtraWindoorsDataSet.Customer)
                    AddingBoolean = False
                    EditingBoolean = False
                    SetControlsReadOnly(True)
                    ResetButtonafterEdit()


                End If
            Catch ex As Exception
                MessageBox.Show("DataBase Operation Error :" & ex.Message, "Adding Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Sub HomeButton_Click(sender As System.Object, e As System.EventArgs) Handles HomeButton.Click
        Me.Hide()
        HomePageScreen.Show()
    End Sub

    Private Sub BookingForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        HomePageScreen.Show()
    End Sub

    Private Sub ZipTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ZipTextBox.Validating
        Dim ZipCode As String
        ZipCode = ZipTextBox.Text
        Dim lengthValid As Boolean = ZipCode.Length.Equals(5)
        If Not lengthValid Then
            MainErrorProvider.SetError(ZipTextBox, "Invalid ZIP code, must be 5 digits")
        End If
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

