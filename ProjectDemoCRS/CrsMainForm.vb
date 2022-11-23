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
    Public Sub displaymenu(userLevel As String)
        If userLevel = "Staff" Then
            displaystaffmenu()
        ElseIf userLevel = "Registrar" Then
            displayregistrarmenu()
        ElseIf userLevel = "Teacher" Then
            displayteachermenu()
        Else
            MessageBox.Show("error")
        End If
    End Sub
    Private Sub hideallmenu()
        Me.ApplicationToolStripMenuItem.Enabled = False
        Me.RegistrarToolStripMenuItem.Enabled = False
        Me.UserInfoToolStripMenuItem.Enabled = False
        Me.TeacherInformationToolStripMenuItem.Enabled = False
        Me.StafInformationToolStripMenuItem.Enabled = False
        Me.SubjectInfoToolStripMenuItem.Enabled = False

        Me.ClassListButton.Enabled = False
        Me.RegisterSubjectButton.Enabled = False
        Me.UserListButton.Enabled = False
        Me.TeacherListButton.Enabled = False
        Me.StudentListButton.Enabled = False
        Me.SubjectListButton.Enabled = False
        Me.ViewStudentListButton.Enabled = False
    End Sub
    Private Sub displaystaffmenu()
        hideallmenu()
        Me.ApplicationToolStripMenuItem.Enabled = True
        Me.RegistrarToolStripMenuItem.Enabled = True
        Me.UserInfoToolStripMenuItem.Enabled = True
        Me.TeacherInformationToolStripMenuItem.Enabled = True
        Me.StafInformationToolStripMenuItem.Enabled = True
        Me.SubjectInfoToolStripMenuItem.Enabled = True
        Me.ResetPasswordToolStripMenuItem.Enabled = True

        Me.ClassListButton.Enabled = True
        Me.RegisterSubjectButton.Enabled = True
        Me.UserListButton.Enabled = True
        Me.TeacherListButton.Enabled = True
        Me.StudentListButton.Enabled = True
        Me.SubjectListButton.Enabled = True
        Me.ViewStudentListButton.Enabled = True
    End Sub
    Private Sub displayregistrarmenu()
        hideallmenu()
        Me.ApplicationToolStripMenuItem.Enabled = True
        Me.RegistrarToolStripMenuItem.Enabled = True
        Me.UserInfoToolStripMenuItem.Enabled = True
        Me.TeacherInformationToolStripMenuItem.Enabled = True
        Me.SubjectInfoToolStripMenuItem.Enabled = True

        Me.ClassListButton.Enabled = True
        Me.RegisterSubjectButton.Enabled = True
        Me.TeacherListButton.Enabled = True
        Me.StudentListButton.Enabled = True
        Me.SubjectListButton.Enabled = True
        Me.ViewStudentListButton.Enabled = True

    End Sub
    Private Sub displayteachermenu()
        hideallmenu()
        Me.ViewStudentListButton.Enabled = True
        Me.ApplicationToolStripMenuItem.Enabled = True
    End Sub

    Private Sub ResetPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPasswordToolStripMenuItem.Click
        ResetPasswordForm.ShowDialog()
    End Sub
End Class
