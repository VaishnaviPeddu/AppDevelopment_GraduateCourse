
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Sale Invoice Form

Public Class SaleInvoiceForm
    Private SubTotaDecimal, TaxDecimal, TotalAmountInteger, SubAmountLeaseDecimal As Decimal
    Private AddingBoolean As Boolean = False
    Private EditingBoolean As Boolean = False

    Private Sub InvoiceBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.InvoiceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.XtraWindoorsDataSet)

    End Sub

    Private Sub SaleInvoiceForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'XtraWindoorsDataSet.Invoice' table. You can move, or remove it, as needed.
        Me.InvoiceTableAdapter.Fill(Me.XtraWindoorsDataSet.Invoice)
        'TODO: This line of code loads data into the 'XtraWindoorsDataSet.Accessories' table. You can move, or remove it, as needed.
        Me.AccessoriesTableAdapter.Fill(Me.XtraWindoorsDataSet.Accessories)

    End Sub


    Private Sub NewButton_Click(sender As System.Object, e As System.EventArgs) Handles NewButton.Click
        GroupBox1.Visible = True
        InvoiceDateDateTimePicker.Value = Today
        SetControlsReadOnly(False)
        Me.InvoiceBindingSource.EndEdit()
        Me.InvoiceBindingSource.AddNew()
    End Sub

    Private Sub CalculateButton_Click(sender As System.Object, e As System.EventArgs) Handles CalculateButton.Click
        Try

            SubAmountLeaseDecimal = Decimal.Parse(SubAmountTextBox.Text)
            TaxDecimal = Decimal.Parse(TaxTextBox.Text)
            TotalAmountInteger = Convert.ToInt32((SubTotaDecimal + SubAmountLeaseDecimal) * (1 + TaxDecimal))
            CostTextBox.Text = TotalAmountInteger.ToString

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub AddSaveButton_Click(sender As System.Object, e As System.EventArgs) Handles AddSaveButton.Click
        Try
            Me.Validate()
            Me.InvoiceBindingSource.EndEdit()
            'AccessoriesBindingSource.EndEdit()

            Me.InvoiceTableAdapter.Update(Me.XtraWindoorsDataSet.Invoice)

            ' Me.TableAdapterManager.UpdateAll(Me.XtraWindoorsDataSet)
            MessageBox.Show("Database updated successfully!")

            InvoiceTableAdapter.Fill(XtraWindoorsDataSet.Invoice)
            SetValues(True)
            InvoiceDateDateTimePicker.Enabled = False

        Catch ex As Exception
            MessageBox.Show("Unable to complete the add/save operation: " & ex.Message, "Add/Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub SetValues(Switch As Boolean)
        InvoiceIDTextBox.ReadOnly = Switch
        LeaseIDTextBox.ReadOnly = Switch
        SubAmountTextBox.ReadOnly = Switch
        ' CostTextBox.ReadOnly = Switch
        TaxTextBox.ReadOnly = Switch
        QuantityTextBox.ReadOnly = Switch
        PaymentMethodComboBox.Enabled = Not (Switch)
        AccessoriesNameComboBox.Enabled = Not (Switch)
        AccessoriesListBox.Enabled = Not (Switch)






    End Sub

    Private Sub EditButton_Click(sender As System.Object, e As System.EventArgs) Handles EditButton.Click
        'Allow editing the current record.
        EditingBoolean = True
        SetControlsReadOnly(False)
        SetButtonForEdit()
        ' SetValues(True)


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

    Private Sub DeleteCancelButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteCancelButton.Click
        Dim DeleteDialogResult As DialogResult
        Try
            If DeleteCancelButton.Text = "Delete" Then
                'delete records
                DeleteDialogResult = MessageBox.Show("Delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If DeleteDialogResult = Windows.Forms.DialogResult.Yes Then
                    InvoiceBindingSource.RemoveCurrent()
                    InvoiceTableAdapter.Update(XtraWindoorsDataSet.Invoice)
                End If
            Else
                'Cancel button is clicked
                InvoiceBindingSource.CancelEdit()
                AddingBoolean = False
                EditingBoolean = False
                SetControlsReadOnly(True)
                ResetButtonafterEdit()
            End If
        Catch ex As Exception
            MessageBox.Show("unable to complete the delete/cancel operation:" & ex.Message, "Delete/Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try
    End Sub

    Private Sub AddItemButton_Click(sender As System.Object, e As System.EventArgs) Handles AddItemButton.Click

        AccessoriesListBox.Items.Add(AccessoriesNameComboBox.Text)

        Dim UnitpriceDecimal, PriceDecimal As Decimal
        Dim QuantityInteger As Integer
        Try


            UnitpriceDecimal = Decimal.Parse(UnitPriceLabel3.Text)
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            PriceDecimal = UnitpriceDecimal * QuantityInteger
            SubTotaDecimal += PriceDecimal

            PriceTextBox.Text = SubTotaDecimal.ToString

            AccessoriesNameComboBox.SelectedIndex = -1
            QuantityTextBox.Clear()
            UnitPriceLabel3.Text = ""
            Me.AccessoriesTableAdapter.Fill(Me.XtraWindoorsDataSet.Accessories)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetControlsReadOnly(ByVal ValueBoolean As Boolean)
        InvoiceIDTextBox.ReadOnly = ValueBoolean
        LeaseIDTextBox.ReadOnly = ValueBoolean
        QuantityTextBox.ReadOnly = ValueBoolean
        PaymentMethodComboBox.Enabled = True
        InvoiceDateDateTimePicker.Enabled = True
        SubAmountTextBox.ReadOnly = ValueBoolean
        TaxTextBox.ReadOnly = ValueBoolean
        AccessoriesListBox.Enabled = True
        AccessoriesNameComboBox.Enabled = True

    End Sub

    Private Sub DeleteItemButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteItemButton.Click
        SubTotaDecimal = 0
        PriceTextBox.Clear()
        AccessoriesListBox.Items.Clear()
    End Sub

    Private Sub SearchButton_Click(sender As System.Object, e As System.EventArgs) Handles SearchButton.Click
        Try
            InvoiceDataGridView.DataSource = InvoiceBindingSource
            Me.InvoiceTableAdapter.FillByInvoiceID(Me.XtraWindoorsDataSet.Invoice, InvoiceTextBox.Text)
            SetControlsReadOnly(True)
        Catch ex As System.Exception
            MessageBox.Show(" There is no record exist !!")
        End Try

    End Sub

    Private Sub HomeButton_Click(sender As System.Object, e As System.EventArgs) Handles HomeButton.Click
        Me.Hide()
        HomePageScreen.Show()
    End Sub

    Private Sub BookingForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        HomePageScreen.Show()
    End Sub
End Class