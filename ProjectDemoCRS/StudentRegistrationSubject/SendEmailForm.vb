Imports System.Net.Mail
Public Class SendEmailForm
    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        If EmailTextBox.Text = "" Then
            MsgBox("Kindly enter your email address", MsgBoxStyle.RetryCancel, "Error")
            EmailTextBox.Focus()
        ElseIf PassTextBox.Text = "" Then
            MsgBox("Kindly enter your password", MsgBoxStyle.RetryCancel, "Error")
            PassTextBox.Focus()
        Else
            Try
                Dim emailString As String = EmailTextBox.Text
                Dim receiverString As String = ReceiverTextBox.Text
                Dim mail As New MailMessage()
                Dim SmtpServer As New SmtpClient("smtp.gmail.com")
                mail.From = New MailAddress("" & emailString & "")
                mail.To.Add("" & receiverString & "")
                mail.Subject = "" & TitleTextBox.Text & ""
                mail.Body = "" & BodyTextBox.Text & ""

                Dim attachment As System.Net.Mail.Attachment
                attachment = New System.Net.Mail.Attachment("" & FileTextBox.Text & "")
                mail.Attachments.Add(attachment)

                SmtpServer.Port = 587
                SmtpServer.Credentials = New System.Net.NetworkCredential("" & emailString & "", "" & PassTextBox.Text & "")
                SmtpServer.EnableSsl = True
                SmtpServer.Send(mail)

                MsgBox("Have successfully send !", MsgBoxStyle.Information, "Information")

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        FileTextBox.Text = OpenFileDialog1.FileName
    End Sub
End Class