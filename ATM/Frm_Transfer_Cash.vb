Imports System.Data.SqlClient
Public Class Frm_Transfer_Cash
    Dim query, query2, query3 As String
    Dim dr, dr1 As SqlDataReader
    Dim accounno, balance As Integer

 Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        balance = Frm_PinCode.balancevalue 'Balance of person who is transfering to another account
        query = "Select AccountNo From Customer Where AccountNo = '" & txt_AccountNo.Text & "'"
        dr = getDataReader(query)
        Try
            If (dr IsNot Nothing AndAlso dr.HasRows) Then
                dr.Read()
            End If
            accounno = dr("AccountNo").ToString
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
        End Try

        If Not txt_AccountNo.Text = accounno AndAlso txt_AccountNo.Text = "" Then
            MessageBox.Show("Account Number Is Not Valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txt_TransferCash.Text > balance Then
            MessageBox.Show("You Dont Have Sufficient Cash To Transfer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        ElseIf accounno = txt_AccountNo.Text AndAlso txt_TransferCash.Text < balance Then
            query2 = "Update Customer Set Balance = Balance + '" & txt_TransferCash.Text & "' Where AccountNo = '" & txt_AccountNo.Text & "'"
            query3 = "Update Customer Set Balance = Balance - '" & txt_TransferCash.Text & "' Where Pincode = '" & Frm_PinCode.txt_code.Text & "'"
            executeQuery(query2)
            executeQuery(query3)
        End If
        txt_AccountNo.Clear()
        txt_TransferCash.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Frm_MainMenu.Enabled = True
        Me.Close()
    End Sub

    Private Sub Frm_Transfer_Cash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Transaction_History.Close()
        Frm_Deposit_Cash.Close()
        Frm_Withdraw_Cash.Close()
        Frm_Settings.Close()
        Frm_MainMenu.Enabled = False
    End Sub
End Class