Public Class Frm_Deposit_Cash
    Dim query, query1 As String
    Dim id As Integer
    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        id = Frm_PinCode.idvalue
        Try
            query = "Update Customer Set Balance = Balance + '" & txt_DepositCash.Text & "' Where PinCode = '" & Frm_PinCode.txt_code.Text & "'"
            query1 = "Insert Into TransactionHistory(Customer_ID,Amount_Deposit,Amount_Withdraw,Date) Values('" & id & "','" & txt_DepositCash.Text & "','" & Frm_Withdraw_Cash.txt_WithdrawCash.Text & "','" & Now & "')"
            executeQuery(query)
            executeQuery(query1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        txt_DepositCash.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Frm_MainMenu.Enabled = True
        Me.Close()
    End Sub

    Private Sub Frm_Deposit_Cash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Settings.Close()
        Frm_Transaction_History.Close()
        Frm_Transfer_Cash.Close()
        Frm_Withdraw_Cash.Close()
        Frm_MainMenu.Enabled = False
    End Sub
End Class