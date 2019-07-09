Public NotInheritable Class Frm_AboutBox
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Frm_PinCode.Enabled = True
        Me.Close()
    End Sub
End Class
