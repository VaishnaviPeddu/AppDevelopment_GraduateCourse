
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Login Form

Imports System.Data.OleDb
Imports System.Net.Mail

Public Class LoginForm

    ' Dim cn As New OleDb.OleDbConnection
    ' Dim cmd As New OleDb.OleDbCommand
    ' Dim str As String
    Dim EmpID As String


    Dim path = System.Windows.Forms.Application.StartupPath

    Private Sub SignInButton_Click(sender As System.Object, e As System.EventArgs) Handles SignInButton.Click

        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\XtraWindoors.accdb")

        Dim command As New OleDbCommand("SELECT [EmpID], [FirstName], [LastName], [Position] FROM [Employee] WHERE [EmpID] = ? AND [password] = ?", connection)

        Dim usernameParam As New OleDbParameter("username", Me.EmployeeID.Text)

        Dim passwordParam As New OleDbParameter("password", Me.UserPass.Text)

        command.Parameters.Add(usernameParam)

        command.Parameters.Add(passwordParam)

        command.Connection.Open()

        Dim reader As OleDbDataReader = command.ExecuteReader()

        'If (reader.Read() = True) Then
        If reader.HasRows Then

            MessageBox.Show("You are Authenticated")

            reader.Read()

            

            Dim HomePageScreen As New HomePageScreen
            'Dim Strin As String
            'Strin = reader.GetString(0)
            ''reader.GetString(0)
            EmpID = Me.EmployeeID.Text
            HomePageScreen.SetUserData(EmpID, reader.GetString(1) + " " + reader.GetString(2), reader.GetString(3))
            HomePageScreen.Show()

            EmployeeID.Text = ""
            UserPass.Text = ""
            Me.Hide()


        ElseIf String.IsNullOrEmpty(EmployeeID.Text) And String.IsNullOrEmpty(UserPass.Text) Then

            MsgBox("Please enter Username and Password", MsgBoxStyle.Critical, "Error")

        ElseIf String.IsNullOrEmpty(EmployeeID.Text) Then

            MsgBox("Please enter Username", MsgBoxStyle.Critical, "Error")
            EmployeeID.Text = ""

        ElseIf String.IsNullOrEmpty(UserPass.Text) Then

            MsgBox("Please enter Password", MsgBoxStyle.Critical, "Error")
            UserPass.Text = ""
        Else
            MsgBox("Invalid Username or Password. Please Try again", MsgBoxStyle.Critical, "Error")
            EmployeeID.Text = ""
            UserPass.Text = ""

        End If
        command.Connection.Close()

    End Sub

    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub ContactUsLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ContactUsLink.LinkClicked
        Contact_Us.Show()
    End Sub

    Private Sub ForgotPasswordLink_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLink.LinkClicked
        Me.Hide()
        ForgotPassword.Show()
    End Sub

    Private Sub LoginForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub
End Class
