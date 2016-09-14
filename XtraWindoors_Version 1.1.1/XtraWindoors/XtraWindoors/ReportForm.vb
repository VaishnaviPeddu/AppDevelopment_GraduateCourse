
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Report Form 

Public Class ReportForm

    Private Sub AccesoriesButton_Click(sender As System.Object, e As System.EventArgs) Handles AccesoriesButton.Click
        AccesoriesReportForm.Show()
    End Sub

    Private Sub RentedButton_Click(sender As System.Object, e As System.EventArgs) Handles RentedButton.Click
        RentedStorageForm.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        CustomerName.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        CustomerReportForm.Show()
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