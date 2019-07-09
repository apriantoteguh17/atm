Imports img_move.Form1

Public Class Frm_Add_NewUsers
    Private Sub add()
        dgv_NewUsers.Rows.Add()
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("UserName").Value = txt_Name.Text
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Phone").Value = txt_Phone.Text
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Address").Value = txt_Address.Text
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("CNIC").Value = txt_CNIC.Text
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Accountno").Value = txt_AccountNo.Text
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Pincode").Value = txt_Pincode.Text
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Balance").Value = txt_Balance.Text
        dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            add()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub reload()

        Dim query As String
        query = "Select * From Customer"
        dgv_NewUsers.Rows.Clear()
        Dim dt As DataTable = getDataTable(query)
        For Each row As DataRow In dt.Rows
            dgv_NewUsers.Rows.Add()
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("UserID").Value = row("ID")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("UserName").Value = row("Name")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Phone").Value = row("Phone")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Address").Value = row("Address")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("CNIC").Value = row("CNIC")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Accountno").Value = row("AccountNo")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Pincode").Value = row("PinCode")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("Balance").Value = row("Balance")
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).DefaultCellStyle.ForeColor = Color.Blue
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).Cells("FromDB").Value = True
            dgv_NewUsers.Rows(dgv_NewUsers.RowCount - 1).DefaultCellStyle.ForeColor = Color.Black
        Next

    End Sub

    Private Sub Frm_Add_NewUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            reload()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub edit()

        If dgv_NewUsers.SelectedRows.Count = 0 Then
            Return
        End If

        If btnEdit.ButtonText = "Edit" Then

            txt_Name.Text = dgv_NewUsers.SelectedRows(0).Cells("UserName").Value
            txt_Phone.Text = dgv_NewUsers.SelectedRows(0).Cells("Phone").Value
            txt_Address.Text = dgv_NewUsers.SelectedRows(0).Cells("Address").Value
            txt_CNIC.Text = dgv_NewUsers.SelectedRows(0).Cells("CNIC").Value
            txt_AccountNo.Text = dgv_NewUsers.SelectedRows(0).Cells("Accountno").Value
            txt_Pincode.Text = dgv_NewUsers.SelectedRows(0).Cells("PinCode").Value
            txt_Balance.Text = dgv_NewUsers.SelectedRows(0).Cells("Balance").Value
            dgv_NewUsers.Enabled = False
            btnEdit.ButtonText = "Update"

        Else
            dgv_NewUsers.SelectedRows(0).Cells("UserName").Value = txt_Name.Text
            dgv_NewUsers.SelectedRows(0).Cells("Phone").Value = txt_Phone.Text
            dgv_NewUsers.SelectedRows(0).Cells("Address").Value = txt_Address.Text
            dgv_NewUsers.SelectedRows(0).Cells("CNIC").Value = txt_CNIC.Text
            dgv_NewUsers.SelectedRows(0).Cells("Accountno").Value = txt_AccountNo.Text
            dgv_NewUsers.SelectedRows(0).Cells("Pincode").Value = txt_Pincode.Text
            dgv_NewUsers.SelectedRows(0).Cells("Balance").Value = txt_Balance.Text
            dgv_NewUsers.Enabled = True
            btnEdit.ButtonText = "Edit"


        End If

        dgv_NewUsers.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Blue

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Try
            edit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_Balance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Balance.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Phone_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Phone.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Pincode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Pincode.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsLetter(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Name.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub apply()

        Dim query As String = String.Empty

        For Each row As DataGridViewRow In dgv_NewUsers.Rows

            If row.Cells("FromDB").Value = True Then

                If row.DefaultCellStyle.ForeColor = Color.Black Then

                    Continue For

                ElseIf row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Update Customer set Name = '" & row.Cells("UserName").Value & "', Phone = '" & row.Cells("Phone").Value & "',Address = '" & row.Cells("Address").Value & "',CNIC = '" & row.Cells("CNIC").Value & "',PinCode = '" & row.Cells("Pincode").Value & "',AccountNo = '" & row.Cells("Accountno").Value & "',Balance = '" & row.Cells("Balance").Value & "' Where ID = '" & row.Cells("UserID").Value & "'"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    query = "Delete From Customer Where ID= " & row.Cells("UserID").Value

                End If


            Else

                If row.DefaultCellStyle.ForeColor = Color.Blue Then

                    query = "Insert Into Customer (Name,Phone,Address,CNIC,AccountNo,PinCode,Balance) Values ('" & row.Cells("UserName").Value & "','" & row.Cells("Phone").Value & "','" & row.Cells("Address").Value & "','" & row.Cells("CNIC").Value & "','" & row.Cells("Accountno").Value & "','" & row.Cells("Pincode").Value & "','" & row.Cells("Balance").Value & "')"

                ElseIf row.DefaultCellStyle.ForeColor = Color.Red Then

                    dgv_NewUsers.Rows.Remove(row)

                    Continue For

                End If

            End If

            executeQuery(query)

        Next

        reload()

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Try
            apply()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub remove()
        If dgv_NewUsers.SelectedRows.Count = 0 Then
            Return
        End If
        dgv_NewUsers.SelectedRows(0).DefaultCellStyle.ForeColor = Color.Red
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        Try
            remove()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            apply()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Frm_PinCode.Enabled = True
        Me.Close()
    End Sub
End Class