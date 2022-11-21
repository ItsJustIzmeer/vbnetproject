Public Class StudentViewListForm
    Public conn As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dataAdapter As New OleDb.OleDbDataAdapter

    Dim sqlString As String
    Dim mMatricString As String
    Dim studentMdl As New Student
    Private Sub StudentViewListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb"
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                '  MsgBox("MS Database Connected!")
                displayAllStudent()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub displayAllStudent()
        clearStudentGrid()
        sqlString = "Select * from student"
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.StudentDataGridView.DataMember = "ihsanTuitionCenterDb"
        StudentDataGridView.DataSource = ds
    End Sub
    Private Sub clearStudentGrid()
        Me.ds.Clear() 'clear the original data
    End Sub

    Private Sub nameButton_Click(sender As Object, e As EventArgs) Handles nameButton.Click
        clearStudentGrid()

        sqlString = "Select * from student where name like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.StudentDataGridView.DataMember = "ihsanTuitionCenterDb"
        StudentDataGridView.DataSource = ds
    End Sub

    Private Sub displayAllButton_Click(sender As Object, e As EventArgs) Handles displayAllButton.Click
        displayAllStudent()
    End Sub

    Private Sub icButton_Click(sender As Object, e As EventArgs) Handles icButton.Click
        clearStudentGrid()
        sqlString = "Select * from student where icNumber like '%" & searchTextBox.Text & "%'"
        Debug.WriteLine(sqlString)
        dataAdapter = New OleDb.OleDbDataAdapter(sqlString, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.StudentDataGridView.DataMember = "ihsanTuitionCenterDb"
        StudentDataGridView.DataSource = ds
    End Sub
End Class