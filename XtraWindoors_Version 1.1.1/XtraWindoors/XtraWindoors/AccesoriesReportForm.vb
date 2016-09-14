'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Accessories Report Form  

Public Class AccesoriesReportForm

    Private Sub AccesoriesReportForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'XtraWindoorsDataSet.AccessoriesReport' table. You can move, or remove it, as needed.
        Me.AccessoriesReportTableAdapter.Fill(Me.XtraWindoorsDataSet.AccessoriesReport)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.AccessoriesReportTableAdapter.FillBy(Me.XtraWindoorsDataSet.AccessoriesReport, DateTimePicker1.Text)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DateTextBox_TextChanged(sender As System.Object, e As System.EventArgs)

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