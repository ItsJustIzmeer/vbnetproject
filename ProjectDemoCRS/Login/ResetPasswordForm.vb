Public Class ResetPasswordForm
    Dim myLoginGroup As New ResetPassword
    Dim oldLoginRec As LoginRecord
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If UsernameTextBox.Text = Nothing Or PasswordTextBox.Text = Nothing Then
            MsgBox("Please insert data in the box.", MsgBoxStyle.Exclamation)
        Else
            updateThisUser(oldLoginRec) 'update
        End If
    End Sub
    Private Sub updateThisUser(oldLoginRec As LoginRecord)
        Dim theNewLoginRec As New LoginRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewLoginRec.userName = UsernameTextBox.Text
        theNewLoginRec.passWord = PasswordTextBox.Text
        updateOk = myLoginGroup.updateThisLogin(oldLoginRec, theNewLoginRec)
        If updateOk Then
            messageString = "The Username : " & theNewLoginRec.userName & " has been updated!"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            ConfirmPasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        End
    End Sub
End Class