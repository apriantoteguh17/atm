Imports System.Threading
Public Class Frm_MainMenu
    Dim id As Integer

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Frm_PinCode.txt_code.Clear()
        Frm_PinCode.Enabled = True
        Frm_PinCode.Show()
        Me.Close()
    End Sub

    Private Sub btnBalanceInquiry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalanceInquiry.Click
        Me.GroupBox1.Show()
    End Sub

    Private Sub Frm_MainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_PinCode.Enabled = False
        GroupBox1.Visible = False
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        GroupBox1.Visible = False
        Frm_PinCode.values()
        Frm_Settings.Show()
        GroupBox1.Visible = False
    End Sub

    Private Sub btnDepositCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepositCash.Click
        Frm_Deposit_Cash.Show()
        GroupBox1.Visible = False
    End Sub

    Private Sub btnGetCash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetCash.Click
        Frm_Withdraw_Cash.Show()
        GroupBox1.Visible = False
    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Frm_Transfer_Cash.Show()
        GroupBox1.Visible = False
    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        Frm_Transaction_History.Show()
        GroupBox1.Visible = False
    End Sub
End Class