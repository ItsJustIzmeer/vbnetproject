Public Class UserForm
    Dim myUser As New User

    Dim OldUserRec As UserRecord

    Friend Sub prepareToResetPassword(userName As String)
        'MessageBox.Show("to update student with matric" & studentMatric)
        With Me
            .AddResetButton.Text = "Reset"
        End With
        displayExistingUserInfo(userName)
    End Sub

    Private Sub displayExistingUserInfo(userName As String)
        Try
            OldUserRec = myUser.getUserRecord(userName)
            With Me
                .userNameTextBox.Text = OldUserRec.username
                .userNameTextBox.Enabled = True
                .passwordTextBox.Text = OldUserRec.password
                .userLevelTextBox.Text = OldUserRec.userlevel

            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Friend Sub prepareToAddNewUser()
        clearUserForm()

        With Me
            .AddResetButton.Text = "Add"
        End With
    End Sub

    Private Sub AddResetButton_Click(sender As Object, e As EventArgs) Handles AddResetButton.Click
        If AddResetButton.Text = "Add" Then
            addThisUser() 'add new user
        Else 'delete
            resetThisUser(OldUserRec)
        End If
    End Sub

    Private Sub addThisUser()
        Dim theNewUserRec As New UserRecord
        Dim addOk As Boolean
        Dim messageString As String
        With theNewUserRec
            .username = userNameTextBox.Text
            .password = passwordTextBox.Text
            .userlevel = userLevelTextBox.Text
        End With

        addOk = myUser.addUser(theNewUserRec)
        If addOk Then
            messageString = "New user with username : " & theNewUserRec.username & " has been added"
            MessageBox.Show(messageString, "Add New User ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub clearUserForm()
        With Me
            .userNameTextBox.Clear()
            .passwordTextBox.Clear()
            .userLevelTextBox.Clear()

        End With
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub resetThisUser(oldUserRec As UserRecord)
        Dim theNewUserRec As New UserRecord
        Dim updateOk As Boolean
        Dim messageString As String
        theNewUserRec.username = userNameTextBox.Text
        theNewUserRec.password = passwordTextBox.Text
        theNewUserRec.userlevel = userLevelTextBox.Text
        updateOk = myUser.updateThisUser(oldUserRec, theNewUserRec)
        If updateOk Then
            messageString = "User with username : " & theNewUserRec.username & " has been updated"
            MessageBox.Show(messageString, "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class