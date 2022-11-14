Public Class CrsMainForm
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        LoginForm.Show()
        LoginForm.UsernameTextBox.Clear()
        LoginForm.PasswordTextBox.Clear()
        Me.Hide()
    End Sub

    Private Sub CrsMainForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub TeacherInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherInformationToolStripMenuItem.Click
        StudentGroupListForm.ShowDialog()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        StudentListForm.ShowDialog()
    End Sub

    Private Sub TeacherListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherListToolStripMenuItem.Click
        TeacherListForm.ShowDialog()
    End Sub

    Private Sub AbutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim logoutResult As DialogResult

        logoutResult = MessageBox.Show("Are you sure to Log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logoutResult = DialogResult.Yes Then
            LoginForm.Show()
            LoginForm.UsernameTextBox.Clear()
            LoginForm.PasswordTextBox.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UserFormList.ShowDialog()
    End Sub
End Class
