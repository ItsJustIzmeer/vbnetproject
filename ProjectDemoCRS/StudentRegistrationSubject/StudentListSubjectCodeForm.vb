Public Class StudentListSubjectCodeForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mMatricString As String
    Dim studentMdl As New Student

    Private Sub StudentListSubjectCodeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                '     MsgBox("MS Database Connected!")
                displayAllStudent()
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub displayAllStudent()
        clearStudentGrid()
        sqlString = "Select * from subjectregister"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.studentDataGridView.DataMember = "ihsanTuitionCenterDb"
        studentDataGridView.DataSource = ds
    End Sub
    Private Sub clearStudentGrid()
        Me.ds.Clear() 'clear the original data
    End Sub

    Private Sub subjectCodeButton_Click(sender As Object, e As EventArgs) Handles subjectCodeButton.Click
        clearStudentGrid()

        sqlString = "Select * from subjectregister where subjectCode like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.studentDataGridView.DataMember = "ihsanTuitionCenterDb"
        studentDataGridView.DataSource = ds
    End Sub
    Private Sub AllButton_Click(sender As Object, e As EventArgs) Handles AllButton.Click
        displayAllStudent()
    End Sub
End Class