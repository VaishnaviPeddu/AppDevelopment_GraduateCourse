
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Forgot Password Form

Imports System.Net.Mail
Imports System.Data.OleDb

Public Class ForgotPassword
    Dim str1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\XtraWindoors.accdb"
    Dim cn1 As New OleDb.OleDbConnection(str1)
    Dim empID As String
    Dim empMailID As String

    Private Function GetNewPassword() As String
        Try
            Dim empID = Trim(TxtEmpID.Text)
            Dim newPswd = String.Format("NXT{0}QO", Convert.ToInt32(empID) + 1895)

            Dim cmd2 As New OleDb.OleDbCommand(String.Format("Update Employee set [Password] ='{0}' where [EmpID] = {1}", newPswd, empID), cn1)
            cmd2.ExecuteNonQuery()
            Return newPswd
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return String.Empty
        End Try
    End Function

    Private Sub SendMail()
        Try
            Dim SmtpServer As New SmtpClient()
            Dim mail As New MailMessage()
            SmtpServer.Credentials = New Net.NetworkCredential("xtrawindoors@gmail.com", "GalaxySoft")
            SmtpServer.Port = 587
            SmtpServer.EnableSsl = True
            SmtpServer.Host = "smtp.gmail.com"
            mail = New MailMessage()
            mail.From = New MailAddress("xtrawindoors@gmail.com")
            mail.To.Add(empMailID)
            mail.Subject = "Reset Password from XTRAWINDOORS"
            mail.Body = String.Format("Your new Password is {0} SMTP mail from GMAIL", GetNewPassword())
            SmtpServer.Send(mail)
            MsgBox("New password as been sent your mail", MsgBoxStyle.Information, "Note")
            Me.Hide()
            LoginForm.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles BtnSubmit.Click

        If String.IsNullOrEmpty(TxtEmpID.Text) And String.IsNullOrEmpty(Txtemailadd.Text) Then

            MsgBox("Please enter Employee ID and Email ID", MsgBoxStyle.Critical, "Error")

        ElseIf String.IsNullOrEmpty(TxtEmpID.Text) Then

            MsgBox("Please enter Employee ID", MsgBoxStyle.Critical, "Error")

        ElseIf String.IsNullOrEmpty(Txtemailadd.Text) Then

            MsgBox("Please enter Email ID", MsgBoxStyle.Critical, "Error")
        Else
            empID = Trim(TxtEmpID.Text)
            empMailID = Trim(Txtemailadd.Text)
            Dim command As New OleDbCommand("Select * from Employee where EmpID=" & empID & " and EmailID='" & empMailID & "'", cn1)
            command.Connection.Open()
            Dim reader As OleDbDataReader = command.ExecuteReader()

            If reader.HasRows Then
                SendMail()
            Else
                MsgBox("Invalid Employee ID or Email ID", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub BookingForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        LoginForm.Show()
    End Sub

End Class