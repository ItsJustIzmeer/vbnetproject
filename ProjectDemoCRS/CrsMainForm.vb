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

    Private Sub LogOutButton_Click(sender As Object, e As EventArgs) Handles LogOutButton.Click
        Dim logoutResult As DialogResult

        logoutResult = MessageBox.Show("Are you sure to Log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logoutResult = DialogResult.Yes Then
            LoginForm.Show()
            LoginForm.UsernameTextBox.Clear()
            LoginForm.PasswordTextBox.Clear()
            Me.Hide()
        End If
    End Sub

    Private Sub StudentListButton_Click(sender As Object, e As EventArgs) Handles StudentListButton.Click
        StudentListForm.ShowDialog()
    End Sub
    Private Sub TeacherListButton_Click(sender As Object, e As EventArgs) Handles TeacherListButton.Click
        TeacherListForm.ShowDialog()
    End Sub
    Private Sub ClassListButton_Click(sender As Object, e As EventArgs) Handles ClassListButton.Click
        StudentGroupListForm.ShowDialog()
    End Sub

    Private Sub RegisterSubjectButton_Click(sender As Object, e As EventArgs) Handles RegisterSubjectButton.Click
        StudentInformationForm.ShowDialog()
    End Sub

    Private Sub UserListButton_Click(sender As Object, e As EventArgs) Handles UserListButton.Click
        UserFormList.ShowDialog()
    End Sub
    Private Sub ViewStudentListButton_Click(sender As Object, e As EventArgs) Handles ViewStudentListButton.Click
        StudentViewListForm.ShowDialog()
    End Sub

    Private Sub SubjectListButton_Click(sender As Object, e As EventArgs) Handles SubjectListButton.Click
        SubjectListForm.ShowDialog()
    End Sub
End Class
