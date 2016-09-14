'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Change Password Form

Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class ChangePassword

    Public EmployeeID As Integer
    Public Password As String
    Dim str1 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\XtraWindoors.accdb"
    Dim cn1 As New OleDb.OleDbConnection(str1)

    Public Sub GetEmpID(EmpID As Integer)
        EmployeeID = EmpID
    End Sub

    Private Sub ChangePassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'ChangePassword_user()
        EmpIDlabel.Text = EmployeeID
    End Sub

    Public Sub ChangePassword_user()

        cn1.Open()
        If TxtPass.TextLength < 6 Then
            MsgBox("The New Password Should be of Atleast 6-10 Characters Length", MsgBoxStyle.Information, "Note")
            TxtPass.Text = ""
            TxtRePass.Text = ""
            TxtCPass.Text = ""
        ElseIf TxtPass.Text = TxtRePass.Text Then
            Dim dt As New DataTable("Storage")
            Dim cmd As New OleDb.OleDbCommand("Select * from Employee where EmpID=" & Trim(EmployeeID) & " and Password='" & Trim(TxtCPass.Text) & "'", cn1)
            Password = TxtPass.Text
            Dim dr As OleDb.OleDbDataReader
            dr = cmd.ExecuteReader
            Dim intstatus As Integer

            If dr.HasRows() Then
                Dim cmd2 As New OleDb.OleDbCommand(String.Format("Update Employee set [Password] ='{0}' where [EmpID] = {1}", Trim(TxtPass.Text), Trim(EmployeeID)), cn1)
                intstatus = cmd2.ExecuteNonQuery()
                MessageBox.Show("Password changed Successfully", "Information")
                Me.Hide()
            End If
        End If
        cn1.Close()
    End Sub

    Private Sub BtnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles BtnSubmit.Click
        ChangePassword_user()
    End Sub

    Private Sub ChangePassword_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        HomePageScreen.Show()
    End Sub

    Private Sub TxtCPass_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TxtCPass.Validating
        If TxtCPass.Text.Trim().Length = 0 Then
            MessageBox.Show("Current password should not be empty", "Note")
        End If
        If TxtCPass.Text <> Password Then
            MessageBox.Show("Invalid Current Password", "Error")
        End If

    End Sub


    Private Sub TxtPass_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TxtPass.Validating
        Dim MatchNumberPattern As String = "(?=^.{6,10}$)(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$"
        If TxtPass.Text.Trim <> "" Then
            If Not Regex.IsMatch(TxtPass.Text, MatchNumberPattern) Then
                MessageBox.Show("Password should contain atleast 1 Capital Letter, 1 small letter, 1 number and 1 Special Character", "Information")
                TxtPass.Text = ""
            End If
        End If

        If TxtPass.Text.Trim().Length = 0 Then
            MessageBox.Show("New password should not be empty", "Note")
        End If

        If TxtPass.Text = TxtCPass.Text Then
            MsgBox("The New Password is Same As Current Password", MsgBoxStyle.Critical, "Error")
            TxtPass.Text = ""
        End If
    End Sub

    Private Sub TxtRePass_Validating(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles TxtRePass.Validating
        If TxtRePass.Text.Trim().Length = 0 Then
            MessageBox.Show("Re-enter password should not be empty", "Note")
        End If

        If TxtPass.Text <> TxtRePass.Text Then
            MsgBox("New Password is not matching with re-enter password", MsgBoxStyle.Exclamation, "Error")
            TxtRePass.Text = ""
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As System.Object, e As System.EventArgs) Handles BtnCancel.Click
        Me.Hide()
    End Sub
End Class