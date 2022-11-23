Imports System.Data.OleDb
Public Class LoginForm
    Dim user As UserClass
    Dim loginModel As LoginModel
    Dim muserLevel As String
    Private con As New OleDb.OleDbConnection
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        user.setUserData(UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Dim valid = loginModel.checkLogin(user)

        If (valid) Then

            Dim dr As OleDbDataReader
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "Select * FROM userTbl WHERE luserName='" & user.userName & "' AND lpassword='" & user.password & "'"

            Dim cmd1 As New OleDbCommand(sql, con)
            dr = cmd1.ExecuteReader()

            dr.Read()
            muserLevel = dr("userlevel").ToString
            con.Close()


            'CrsMainForm.Show()
            CrsMainForm.displaymenu(muserLevel)
            Debug.WriteLine(muserLevel)
            CrsMainForm.Show()
            Me.Hide()
        Else
            If user.userName = "" Or user.password = "" Then
                MessageBox.Show("Username or Password is Empty")
            Else
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
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
End Class
