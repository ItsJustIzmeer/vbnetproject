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
            LoginForm.UsernameTextBox.Focus()
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
            Debug.WriteLine(userLevel)
            displaystaffmenu()
        ElseIf userLevel = "Registrar" Then
            Debug.WriteLine(userLevel)
            displayregistrarmenu()
        ElseIf userLevel = "Teacher" Then
            Debug.WriteLine(userLevel)
            displayteachermenu()
        Else
            MessageBox.Show("error")
        End If
    End Sub
    Private Sub hideallmenu()
        Me.ResetPasswordToolStripMenuItem.Enabled = False
        Me.ApplicationToolStripMenuItem.Enabled = False
        Me.RegistrarToolStripMenuItem.Enabled = False
        Me.UserInfoToolStripMenuItem.Enabled = False
        Me.TeacherInformationToolStripMenuItem.Enabled = False
        Me.RegisterStudentToolStripMenuItem.Enabled = False
        Me.SubjectInfoToolStripMenuItem.Enabled = False

        Me.RegisterStudentToolStripMenuItem.Enabled = False
        Me.StudentListToolStripMenuItem.Enabled = False
        Me.TeacherInfoToolStripMenuItem.Enabled = False
        Me.TeacherListToolStripMenuItem.Enabled = False

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
        Me.ResetPasswordToolStripMenuItem.Enabled = True
        Me.ApplicationToolStripMenuItem.Enabled = True
        Me.RegistrarToolStripMenuItem.Enabled = True
        Me.UserInfoToolStripMenuItem.Enabled = True
        Me.TeacherInformationToolStripMenuItem.Enabled = True
        Me.RegisterStudentToolStripMenuItem.Enabled = True
        Me.SubjectInfoToolStripMenuItem.Enabled = True
        Me.ResetPasswordToolStripMenuItem.Enabled = True
        Me.StudentListToolStripMenuItem.Enabled = True
        Me.TeacherInfoToolStripMenuItem.Enabled = True
        Me.TeacherListToolStripMenuItem.Enabled = True

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
        Me.UserInfoToolStripMenuItem.Enabled = False
        Me.RegisterStudentToolStripMenuItem.Enabled = True
        Me.TeacherInfoToolStripMenuItem.Enabled = True
        Me.TeacherListToolStripMenuItem.Enabled = True
        Me.StudentListToolStripMenuItem.Enabled = True
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

    Private Sub ViewStudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentListToolStripMenuItem.Click
        StudentViewListForm.ShowDialog()
    End Sub

    Private Sub RegisterStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterStudentToolStripMenuItem.Click
        StudentInformationForm.ShowDialog()
    End Sub

    Private Sub UserListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserListToolStripMenuItem.Click
        UserFormList.ShowDialog()
    End Sub

    Private Sub SubjectListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubjectListToolStripMenuItem.Click
        SubjectListForm.ShowDialog()
    End Sub
End Class
