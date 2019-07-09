Public Class Frm_Admin_Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If UsernameTextBox.Text = "osama" AndAlso PasswordTextBox.Text = "maverick" Then
            Frm_Add_NewUsers.Show()
            Me.Close()
        Else
            MessageBox.Show("User Name And Password Is Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Frm_PinCode.Enabled = True
        Me.Close()
    End Sub
End Class
