Public Class SubjectListForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mSubjectCodeString As String
    Dim subjectMdl As New Subject
    Private Sub SubjectListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                'MsgBox("MS Database Connected!")
                displayAllSubject()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub displayAllSubject()
        clearSubjectGrid()
        sqlString = "Select * from subject"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectDataGridView.DataSource = ds
    End Sub
    Private Sub clearSubjectGrid()
        Me.ds.Clear() 'clear the original data
    End Sub
    Private Sub disableButton()
        With Me
            .AddSubjectButton.Enabled = False
            .updateSubjectButton.Enabled = False
            .DeleteSubjectButton.Enabled = False
        End With
    End Sub
    Private Sub enableButton()
        With Me
            .AddSubjectButton.Enabled = True
            .updateSubjectButton.Enabled = True
            .DeleteSubjectButton.Enabled = True
        End With
    End Sub

    Private Sub addSubjectButton_Click(sender As Object, e As EventArgs) Handles addSubjectButton.Click
        SubjectForm.prepareToAddNewSubject()
        SubjectForm.ShowDialog()
        displayAllSubject()
    End Sub
    Private Sub SubjectDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer
        Try
            col = SubjectDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then
                disableButton()
                Exit Sub
            End If
            inc = SubjectDataGridView.CurrentCell.RowIndex
            mSubjectCodeString = SubjectDataGridView.CurrentCell.Value
            If (mSubjectCodeString <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub updateSubjectButton_Click(sender As Object, e As EventArgs) Handles updateSubjectButton.Click
        If mSubjectCodeString <> "" Then
            SubjectForm.prepareToUpdateSubject(mSubjectCodeString)
            SubjectForm.ShowDialog()
            displayAllSubject()
        End If
    End Sub

    Private Sub deleteSubjectButton_Click(sender As Object, e As EventArgs) Handles deleteSubjectButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Delete Subject with Subject Code: " & mSubjectCodeString
        If mSubjectCodeString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOK = subjectMdl.deleteSubjectRecord(mSubjectCodeString)
                displayAllSubject()
            End If
        End If
    End Sub

    Private Sub nameButton_Click(sender As Object, e As EventArgs) Handles nameButton.Click
        clearSubjectGrid()
        sqlString = "Select * from subject where subjectName like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectDataGridView.DataSource = ds
    End Sub

    Private Sub displayAllButton_Click(sender As Object, e As EventArgs) Handles displayAllButton.Click
        displayAllSubject()
    End Sub

    Private Sub subjectCodeButton_Click(sender As Object, e As EventArgs) Handles subjectCodeButton.Click
        clearSubjectGrid()
        sqlString = "Select * from subject where subjectCode like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectDataGridView.DataSource = ds
    End Sub

    Private Sub printButton_Click(sender As Object, e As EventArgs) Handles printButton.Click

        If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
        'If PrintDialog1.ShowDialog = DialogResult.OK Then
        'PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        'PrintDocument1.Print()
        'End If
    End Sub
End Class