Public Class Frm_Transaction_History
    Dim query As String
    Dim id As Integer

    Private Sub reload()
        Dim dt As DataTable
        id = Frm_PinCode.idvalue
        query = "Select Amount_Deposit,Amount_Withdraw,Date From TransactionHistory Where Customer_ID = '" & id & "'"
        dt = getDataTable(query)
        dgv_NewUsers.Rows.Clear()
        For Each row As DataRow In dt.Rows
            dgv_NewUsers.Rows.Add()
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Deposit").Value = row("Amount_Deposit")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Withdraw").Value = row("Amount_Withdraw")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("TDate").Value = row("Date")
        Next
    End Sub
    Private Sub Frm_Transaction_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reload()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Frm_MainMenu.GroupBox1.Visible = False
        Frm_Deposit_Cash.Close()
        Frm_Withdraw_Cash.Close()
        Frm_Settings.Close()
        Frm_Transfer_Cash.Close()
        Frm_MainMenu.Enabled = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Frm_MainMenu.Enabled = True
        Me.Close()
    End Sub
End Class