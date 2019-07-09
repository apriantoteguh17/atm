Imports System.Threading
Public Class Frm_PinCode
    Dim query As String
    Dim dr As SqlClient.SqlDataReader
    Dim id, code, balance, phone, cinic As Integer
    Dim name, address As String

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            query = "Select ID,Name,Phone,Address,CNIC,PinCode,Balance From Customer Where PinCode = '" & txt_code.Text & "'"
            dr = getDataReader(query)
            If (dr IsNot Nothing AndAlso dr.HasRows) Then
                dr.Read()
            End If
            id = dr("ID").ToString
            code = dr("PinCode").ToString
            name = dr("Name").ToString
            phone = dr("Phone").ToString
            address = dr("Address").ToString
            cinic = dr("CNIC").ToString
            balance = dr("Balance").ToString
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
        End Try

        If txt_code.Text = "" Then
            ErrorProvider1.SetError(txt_code, "Must Enter PinCode To Continue")
            Me.Enabled = True
        Else
            ErrorProvider1.SetError(txt_code, "")
            Me.Enabled = True
        End If

        Try
            If code = txt_code.Text Then

                'Thread.Sleep(500)
                Frm_MainMenu.Show()
                Frm_MainMenu.btnShowName.ControlText = name
                Frm_MainMenu.btnShowBalance.ControlText = balance
                Frm_Settings.txt_PinCode.Text = code
                Frm_Settings.txt_Name.Text = name
                Frm_Settings.txt_Address.Text = address
                Frm_Settings.txt_Phone.Text = phone
            ElseIf Not txt_code.Text = code Then
                MessageBox.Show(" Your Code Is Incorrect , Enter Again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_code.Clear()
                Return
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        Dim frm As New img_move.Form1
        frm.Show()
        'txt_code.Clear()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txt_code.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Sub values()
        Frm_Settings.txt_PinCode.Text = code
        Frm_Settings.txt_Name.Text = name
        Frm_Settings.txt_Address.Text = address
        Frm_Settings.txt_Phone.Text = phone
    End Sub

    Private Sub btnAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdmin.Click
        Me.Enabled = False
        Frm_Admin_Login.Show()
    End Sub

    Public Function idvalue()
        Return id
    End Function
    Public Function balancevalue()
        Return balance
    End Function


    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Frm_AboutBox.Show()
        Me.Enabled = False
    End Sub
End Class
