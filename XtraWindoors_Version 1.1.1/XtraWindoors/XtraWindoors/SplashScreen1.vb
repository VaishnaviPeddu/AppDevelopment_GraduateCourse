
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Splash Screen Form


Public Class SplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Timer1.Start()
        ProgressBar.Increment(1)

        If ProgressBar.Value = 25 Then
            Status.Text = "Retrieving Records..."
        End If
        If ProgressBar.Value = 50 Then
            Status.Text = "Updating Records..."
        End If
        If ProgressBar.Value = 96 Then
            Status.Text = "Completed!!"
        End If
        If ProgressBar.Value = 100 Then

            Timer1.Stop()
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Private Sub SplashScreen1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Status.Text = "Loading Details..."
    End Sub
End Class
