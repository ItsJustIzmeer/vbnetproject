Public Class UserFormList
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlstring As String
    Dim mUserString As String
    Dim userMdl As New User

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButton()

        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                'MsgBox("MS Database Connected!")
                displayAllUser()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub displayAllUser()
        clearUserGrid()
        sqlstring = "Select * from userTbl"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlstring, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.UserDataGridView.DataMember = "ihsanTuitionCenterDb"
        UserDataGridView.DataSource = ds
    End Sub
    Private Sub clearUserGrid()
        Me.ds.Clear() 'clear the original data
    End Sub

    Private Sub disableButton()
        With Me
            .AddUserButton.Enabled = False
            .DeleteUserButton.Enabled = False
            .ResetPasswordButton.Enabled = False
        End With
    End Sub
    Private Sub enableButton()
        With Me
            .AddUserButton.Enabled = True
            .DeleteUserButton.Enabled = True
            .ResetPasswordButton.Enabled = True
        End With
    End Sub

    Private Sub UserDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer

        Try
            col = UserDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then 'ignore if not click on primary key - groupId
                disableButton()
                Exit Sub
            End If
            inc = UserDataGridView.CurrentCell.RowIndex
            'store the selected studentGroupId from the cell selection
            mUserString = UserDataGridView.CurrentCell.Value
            If (mUserString <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles AddUserButton.Click
        UserForm.prepareToAddNewUser()
        UserForm.ShowDialog()
        displayAllUser()
    End Sub

    Private Sub ResetPasswordButton_Click(sender As Object, e As EventArgs) Handles ResetPasswordButton.Click
        If mUserString <> "" Then
            UserForm.prepareToResetPassword(mUserString)
            UserForm.ShowDialog()
            displayAllUser()
        End If
    End Sub

    Private Sub DeleteUserButton_Click(sender As Object, e As EventArgs) Handles DeleteUserButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Delete User  :" & mUserString
        If mUserString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOK = userMdl.deleteUserRecord(mUserString)
                displayAllUser()
            End If
        End If
    End Sub
End Class