Imports System.Data.OleDb
Public Class StudentInformationForm
    Public conn As New OleDb.OleDbConnection
    Public connTest As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbsource As String
    Dim mydocfolder, theatabase As String
    Dim fullPath As String
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim ds As New DataSet
    Dim mId As String 'store selected matric number
    Public dr As OleDbDataReader
    Dim myStudent As New Student
    Private Sub AllButton_Click(sender As Object, e As EventArgs) Handles AllButton.Click
        displayAllStudent()
    End Sub
    Private Sub StudentInformationForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        conn.Close()
    End Sub
    Private Sub displayAllStudent()
        clearStudentGrid()
        sql = "Select * from student"
        dataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.studentDataGridView.DataMember = "ihsanTuitionCenterDb"
        studentDataGridView.DataSource = ds
    End Sub
    Private Sub StudentInformationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableButton()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb"
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                ' MsgBox("MS Database Connected!")
                displayProgramListTree()
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try

        'close the connection
        conn.Close()
    End Sub
    Private Sub matricButton_Click(sender As Object, e As EventArgs) Handles matricButton.Click
        clearStudentGrid()
        sql = "Select * from student where matricNumber = '" & searchTextBox.Text & "'"
        dataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.studentDataGridView.DataMember = "ihsanTuitionCenterDb"
        studentDataGridView.DataSource = ds
    End Sub

    Private Sub nameButton_Click(sender As Object, e As EventArgs) Handles nameButton.Click
        clearStudentGrid()
        sql = "Select * from student where name like '%" & searchTextBox.Text & "%'"
        dataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.studentDataGridView.DataMember = "ihsanTuitionCenterDb"
        studentDataGridView.DataSource = ds
    End Sub
    Private Sub clearStudentGrid()
        Me.ds.Clear() 'clear the original data
    End Sub
    Private Sub disableButton()
        With Me
            .RegistrationButton.Enabled = False
            .DeleteStudentButton.Enabled = False
        End With
    End Sub
    Private Sub enableButton()
        With Me
            .RegistrationButton.Enabled = True
            .DeleteStudentButton.Enabled = True
        End With
    End Sub
    Private Sub studentDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer
        MessageBox.Show("You have select student with matric number " + studentDataGridView.CurrentCell.Value)
        Try
            col = studentDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then
                disableButton()
                Exit Sub
            End If
            inc = studentDataGridView.CurrentCell.RowIndex
            mId = studentDataGridView.CurrentCell.Value
            If (mId <> "") Then
                enableButton()
            Else
                disableButton()
            End If
        Catch ex As Exception
            '  MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub RegistrationButton_Click(sender As Object, e As EventArgs) Handles RegistrationButton.Click
        RegistrationForm.showStudentInformation(mId)
        RegistrationForm.ShowDialog()
    End Sub
    Private Sub DeleteStudentButton_Click(sender As Object, e As EventArgs) Handles DeleteStudentButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Delete student with matric number:" & mId
        If mId <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                deletedOK = myStudent.deleteStudentRecord(mId)
                displayAllStudent()
            End If
        End If
    End Sub
    Private Sub CourseTreeView_AfterSelect_1(sender As Object, e As TreeViewEventArgs) Handles CourseTreeView.AfterSelect
        Dim classlist = Me.CourseTreeView.SelectedNode.Text
        clearStudentGrid()

        sql = "Select * from student where groupId ='" & classlist & "'"
        dataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.studentDataGridView.DataMember = "ihsanTuitionCenterDb"
        studentDataGridView.DataSource = ds
    End Sub

    Private Sub ViewSubjectCodeButton_Click(sender As Object, e As EventArgs) Handles ViewSubjectCodeButton.Click
        StudentListSubjectCodeForm.ShowDialog()
    End Sub

    Private Sub displayProgramListTree()
        Dim str As String
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb")
        conn.Open()
        str = "SELECT groupId FROM studentGroupTbl order by groupId"
        'MessageBox.Show(str)
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        Me.CourseTreeView.Nodes.Clear() 'clear tree
        While dr.Read()
            With Me
                .CourseTreeView.Nodes.Add(dr("groupId").ToString())

            End With
        End While
    End Sub
End Class