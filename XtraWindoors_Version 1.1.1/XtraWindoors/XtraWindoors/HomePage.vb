
'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Home Page Screen Form

Imports System.Data.OleDb

Public Class HomePageScreen
    Dim cn As New OleDb.OleDbConnection
    Dim cmd As New OleDb.OleDbCommand
    Dim str As String
    Dim EmployeeID As Integer

    Public Sub SetUserData(EmpID As Integer, myUserName As String, myUserDesig As String)
        LblUserName.Text = String.Format("Welcome {0}", myUserName)
        LblUserDesig.Text = String.Format("You Logged In as {0}", myUserDesig)
        EmployeeID = EmpID
    End Sub

    Private Sub HelpLabel_Click(sender As System.Object, e As System.EventArgs) Handles HelpLabel.Click
        MessageBox.Show("Please Contact GalaxySoft Group Admin Team(xtrawindoors@gmail.com)")
    End Sub

    Private Sub ReportsLabel_Click(sender As System.Object, e As System.EventArgs) Handles ReportsLabel.Click

        Me.Hide()
        ReportForm.Show()
    End Sub

    Private Sub ReportsPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles ReportsPictureBox.Click

        Me.Hide()
        ReportForm.Show()
    End Sub

    Private Sub EmployeePictureBox_Click(sender As System.Object, e As System.EventArgs) Handles EmployeePictureBox.Click
        Me.Hide()
        EmployeeForm.Show()
    End Sub

    Private Sub EmployeeMasterLabel_Click(sender As System.Object, e As System.EventArgs) Handles EmployeeMasterLabel.Click
        Me.Hide()
        EmployeeForm.Show()
    End Sub

    Private Sub CustomersPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles CustomersPictureBox.Click
        Me.Hide()
        CustomerForm.Show()
    End Sub

    Private Sub CustomerMasterLabel_Click(sender As System.Object, e As System.EventArgs) Handles CustomerMasterLabel.Click
        Me.Hide()
        CustomerForm.Show()
    End Sub

    Private Sub ReservationsHover(sender As System.Object, e As System.EventArgs) Handles ReservationsPictureBox.MouseHover
        Dim Tooltip As ToolTip = New ToolTip()
        Tooltip.SetToolTip(ReservationsPictureBox, "Reservations")
    End Sub

    Private Sub ReportsHover(sender As System.Object, e As System.EventArgs) Handles ReportsPictureBox.MouseHover
        Dim Tooltip As ToolTip = New ToolTip()
        Tooltip.SetToolTip(ReportsPictureBox, "Reports")
    End Sub

    Private Sub EmployeeHover(sender As System.Object, e As System.EventArgs) Handles EmployeePictureBox.MouseHover
        Dim Tooltip As ToolTip = New ToolTip()
        Tooltip.SetToolTip(EmployeePictureBox, "Employees")
    End Sub

    Private Sub CustomersHover(sender As System.Object, e As System.EventArgs) Handles CustomersPictureBox.MouseHover
        Dim Tooltip As ToolTip = New ToolTip()
        Tooltip.SetToolTip(CustomersPictureBox, "Customers")
    End Sub

    Private Sub HomePageScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer.Start()
    End Sub

    Private Sub AboutLabel_Click(sender As System.Object, e As System.EventArgs) Handles AboutLabel.Click
        About.Show()
    End Sub

    Private Sub FillRomStatus()
        Dim AL As New Collection
        AL.Add(StatusTextBox1, "1")
        AL.Add(StatusTextBox2, "2")
        AL.Add(StatusTextBox3, "3")
        AL.Add(StatusTextBox4, "4")
        AL.Add(StatusTextBox5, "5")
        AL.Add(StatusTextBox6, "6")
        AL.Add(StatusTextBox7, "7")

        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\XtraWindoors.accdb"
        cn = New OleDb.OleDbConnection(str)
        cn.Open()

        Dim dt As New DataTable("Storage")
        Dim cmd As New OleDb.OleDbCommand("Select StorageTypeID, COUNT(StorageID) from [Storage]  where StorageTypeID is not null and [StorageAvaiablity] = Yes group by StorageTypeID", cn)
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader

        While dr.Read()
            AL(dr(0)).Text = dr(1).ToString
        End While
        cn.Close()
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        FillRomStatus()
    End Sub

    Public Sub ChangePasswordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.GetEmpID(EmployeeID)
        ChangePassword.Show()
    End Sub

    Private Sub HomePageScreen_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ExitLabel_Click_1(sender As System.Object, e As System.EventArgs) Handles ExitLabel.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ReservationLabel_Click(sender As System.Object, e As System.EventArgs) Handles ReservationLabel.Click
        Me.Hide()
        BookingForm.Show()
    End Sub

    Private Sub ReservationsPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles ReservationsPictureBox.Click
        Me.Hide()
        BookingForm.Show()
    End Sub

    Private Sub HomeButton_Click(sender As System.Object, e As System.EventArgs) Handles HomeButton.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As System.Object, e As System.EventArgs) Handles InvoiceToolStripLabel.Click
        Me.Hide()
        SaleInvoiceForm.Show()
    End Sub
End Class

