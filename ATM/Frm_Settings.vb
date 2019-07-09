Public Class Frm_Settings
    Dim query As String
    Private Sub formclear()
        txt_NewName.Clear()
        txt_NewPhone.Clear()
        txt_NewAddress.Clear()
        txt_NewCode.Clear()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        formclear()
    End Sub

    Private Sub txt_NewName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NewName.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then   'Ristricting TxtName To Input Only Characters
            e.Handled = True
        End If
    End Sub

    Private Sub txt_NewCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NewCode.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting TxtPhone To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub

    Private Sub txt_NewPhone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_NewPhone.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then   'Ristricting TxtCode To Input Only Digits(any number)
            e.Handled = True
        End If
    End Sub

    Private Sub updatedata()

        If txt_NewName.Text = "" Then
            txt_NewName.Text = txt_Name.Text
        End If

        If txt_NewAddress.Text = "" Then
            txt_NewAddress.Text = txt_Address.Text
        End If

        If txt_NewPhone.Text = "" Then
            txt_NewPhone.Text = txt_Phone.Text
        End If

        If txt_NewCode.Text = "" Then
            txt_NewCode.Text = Frm_PinCode.txt_code.Text
        End If

        query = "Update Customer Set Name = '" & txt_NewName.Text & "', Phone = '" & txt_NewPhone.Text & "', Address = '" & txt_NewAddress.Text & "', PinCode = '" & txt_NewCode.Text & "' Where PinCode = '" & Frm_PinCode.txt_code.Text & "'"
        executeQuery(query)
        formclear()
    End Sub


    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        Try
            updatedata()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Frm_MainMenu.Enabled = True
        Me.Close()
    End Sub

    Private Sub Frm_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Frm_Deposit_Cash.Close()
        Frm_Transfer_Cash.Close()
        Frm_Withdraw_Cash.Close()
        Frm_MainMenu.Enabled = False
    End Sub
End Class