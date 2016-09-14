
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Customer Name for Invoice Report

Public Class CustomerName

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If LeaseIDComboBox.SelectedIndex = -1 And LastNameComboBox.SelectedIndex = -1 Then
            MessageBox.Show("Please select customer last name or Lease ID", "Select Customer", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            InvoiceReportForm.InvoiceReportTableAdapter.FillBy(InvoiceReportForm.XtraWindoorsDataSet.InvoiceReport, LastNameComboBox.Text, LeaseIDComboBox.Text)

            InvoiceReportForm.ReportViewer1.RefreshReport()
            InvoiceReportForm.Show()
            LastNameComboBox.SelectedIndex = -1
            LeaseIDComboBox.SelectedIndex = -1
            Me.Hide()
        End If
    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub CustomerName_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'XtraWindoorsDataSet.InvoiceReport' table. You can move, or remove it, as needed.
        Me.InvoiceReportTableAdapter.Fill(Me.XtraWindoorsDataSet.InvoiceReport)

        LastNameComboBox.SelectedIndex = -1
        LeaseIDComboBox.SelectedIndex = -1
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