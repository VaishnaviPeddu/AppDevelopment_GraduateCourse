'Program Name:  XtraWindoors Rental System
'Programmer:    Group 7 
'Date:          12/10/2015 
'Class:         Check Availability Form

Public Class CheckAvailability
    'Dim cn As New OleDb.OleDbConnection
    'Dim cmd As New OleDb.OleDbCommand
    'Dim str As String
    Dim StorageID As Integer

    Private Sub CheckAvailability_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub

    Public Sub GetStorageID(StorId As Integer)
        StorageID = StorId
    End Sub

    Private Sub StorageBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.StorageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.XtraWindoorsDataSet)

    End Sub

    Private Sub BookingForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        BookingForm.Show()
        Me.StorageBindingSource.Filter = Nothing
    End Sub

    Private Sub CheckAvailability_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StorageBindingSource.Filter = "StorageTypeID = '" & StorageID & "'"
        Me.StorageTableAdapter.FillByAvailability(Me.XtraWindoorsDataSet.Storage)
    End Sub

    Private Sub StorageDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StorageDataGridView.CellContentClick
        Me.Hide()
        Dim StorageID As String
        StorageID = StorageDataGridView.CurrentCell.Value
        BookingForm.StorageIDTextBox1.Text = StorageID
    End Sub
End Class