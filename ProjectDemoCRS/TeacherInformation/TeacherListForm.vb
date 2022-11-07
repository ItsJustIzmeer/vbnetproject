Public Class TeacherListForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlstring As String
    Dim mIDString As String
    Dim teacherMdl As New Teacher

    Private Sub TeacherListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButton()

        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName

        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                'MsgBox("MS Database Connected!")
                displayAllTeacher()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub displayAllTeacher()
        clearTeacherGrid()
        sqlstring = "Select * from teacher"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.TeacherDataGridView.DataMember = "ihsanTuitionCenterDb"
        TeacherDataGridView.DataSource = ds
    End Sub
    Private Sub clearTeacherGrid()
        Me.ds.Clear() 'clear the original data
    End Sub
    Private Sub disableButton()
        With Me
            .AddTeacherButton.Enabled = False
            .UpdateTeacherButton.Enabled = False
            .DeleteTeacherButton.Enabled = False
        End With
    End Sub
    Private Sub enableButton()
        With Me
            .AddTeacherButton.Enabled = True
            .UpdateTeacherButton.Enabled = True
            .DeleteTeacherButton.Enabled = True
        End With
    End Sub

    Private Sub AddTeacherButton_Click(sender As Object, e As EventArgs) Handles AddTeacherButton.Click
        TeacherForm.prepareToAddNewTeacher()
        TeacherForm.ShowDialog()
        displayAllTeacher()
    End Sub

    Private Sub TeacherDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TeacherDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer
        ' MessageBox.Show(StudentGroupDataGridView.CurrentCell.ColumnIndex)
        Try
            col = TeacherDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then 'ignore if not click on primary key - groupId
                disableButton()
                Exit Sub
            End If
            inc = TeacherDataGridView.CurrentCell.RowIndex
            'store the selected studentGroupId from the cell selection
            mIDString = TeacherDataGridView.CurrentCell.Value
            If (mIDString <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub updateTeacherButton_Click(sender As Object, e As EventArgs) Handles UpdateTeacherButton.Click
        If mIDString <> "" Then
            TeacherForm.prepareToUpdateTeacher(mIDString)
            TeacherForm.ShowDialog()
            displayAllTeacher()
        End If
    End Sub

    Private Sub DeleteTeacherButton_Click(sender As Object, e As EventArgs) Handles DeleteTeacherButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Delete Teacher  :" & mIDString
        If mIDString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOK = teacherMdl.deleteTeacherRecord(mIDString)
                displayAllTeacher()
            End If
        End If
    End Sub

    Private Sub nameButton_Click(sender As Object, e As EventArgs) Handles nameButton.Click
        clearTeacherGrid()

        sqlstring = "Select * from teacher where name like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlstring)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlstring, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.TeacherDataGridView.DataMember = "ihsanTuitionCenterDb"
        TeacherDataGridView.DataSource = ds
    End Sub

    Private Sub displayAllButton_Click(sender As Object, e As EventArgs) Handles displayAllButton.Click
        displayAllTeacher()
    End Sub

    Private Sub ICButton_Click(sender As Object, e As EventArgs) Handles ICButton.Click
        clearTeacherGrid()

        sqlstring = "Select * from teacher where icNumber like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlstring)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlstring, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.TeacherDataGridView.DataMember = "ihsanTuitionCenterDb"
        TeacherDataGridView.DataSource = ds
    End Sub
End Class