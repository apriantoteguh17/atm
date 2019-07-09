Public Class Frm_Withdraw_Cash
    Dim query, query1 As String
    Dim dt As New DateTimePicker
    Dim id, balance As Integer

    Private Sub btnWthdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWthdraw.Click
        Try
            balance = Frm_PinCode.balancevalue
            id = Frm_PinCode.idvalue
            If txt_WithdrawCash.Text > balance Then
                MessageBox.Show("Withdraw Amount Is Greater Than Balance, Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            ElseIf txt_WithdrawCash.Text >= 500 Then
                query = "Update Customer Set Balance = Balance - '" & txt_WithdrawCash.Text & "' Where PinCode = '" & Frm_PinCode.txt_code.Text & "'"
                query1 = "Insert Into TransactionHistory(Customer_ID,Amount_Deposit,Amount_WithDraw,Date) Values('" & id & "','" & Frm_Deposit_Cash.txt_DepositCash.Text & "','" & txt_WithdrawCash.Text & "','" & Now & "')"
                executeQuery(query)
                executeQuery(query1)
            Else
                MessageBox.Show("Enter Amount Should Be Greater Than 500", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            txt_WithdrawCash.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Frm_MainMenu.Enabled = True
        Me.Close()
    End Sub

    Private Sub Frm_Withdraw_Cash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Settings.Close()
        Frm_Transfer_Cash.Close()
        Frm_Deposit_Cash.Close()
        Frm_MainMenu.Enabled = False
    End Sub
End Class