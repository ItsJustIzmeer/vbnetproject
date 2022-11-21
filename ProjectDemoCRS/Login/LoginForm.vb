Public Class LoginForm
    Dim user As UserClass
    Dim loginModel As LoginModel
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        user.setUserData(UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Dim valid = loginModel.checkLogin(user)
        If (valid) Then
            CrsMainForm.Show()
            Me.Hide()
        Else
            If user.userName = "" Or user.password = "" Then
                MessageBox.Show("Username or Password is Empty")
            Else
                MessageBox.Show("Username or Password is Incorrect")
            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        user = New UserClass()
        loginModel = New LoginModel
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub
End Class
