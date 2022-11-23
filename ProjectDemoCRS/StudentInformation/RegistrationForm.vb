Imports System.Data.OleDb
Public Class RegistrationForm
    Public conn As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbsource As String
    Dim mydocfolder, theatabase As String
    Dim fullPath As String
    Dim dataAdapter As New OleDb.OleDbDataAdapter
    Dim sql As String
    Dim ds As New DataSet
    Dim mId As String
    Public dr As OleDbDataReader
    Dim msubjectCodeString As String

    Dim mySubject As New Subject
    Public Sub showStudentInformation(matricString As String)

        displayStudentRecord(matricString)
        mId = matricString
        displaySubjectRegister(mId)
    End Sub
    Private Sub displayStudentRecord(matricString As String)
        ' Dim curStudentRec As 
        openConnection()
        Dim str As String
        str = "SELECT * FROM student WHERE (matricNumber = '" & matricString & "')"
        'MessageBox.Show(str)
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        While dr.Read()
            With Me
                .matricNumberLabel.Text = dr("matricNumber").ToString
                .icLabel.Text = dr("icNumber").ToString
                .nameLabel.Text = dr("name").ToString
                .PhoneNumberLabel.Text = dr("phoneNumber").ToString
                '.statusLabel.Text = dr("status").ToString
                .classLabel.Text = dr("groupId").ToString
            End With
        End While
        conn.Close()
    End Sub
    Private Sub displaySubjectRegister(matricString As String)
        clearSubjectRegisterGrid()
        sql = "Select r.subjectCode,s.subjectName"
        sql &= " from subjectregister r, student stu, subject s"
        sql &= " where r.matricNumber = stu.matricNumber"
        sql &= " and r.matricNumber = '" & matricString & "'"
        sql &= " and r.subjectCode = s.subjectCode"
        'MessageBox.Show(sql)
        Debug.WriteLine(sql)
        dataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectRegisterDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectRegisterDataGridView.DataSource = ds
    End Sub
    Private Sub openConnection()
        conn.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                '      MsgBox("MS Database Connected!")
                Exit Sub
            End If
        Catch ex As Exception
            '   MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub
    Private Sub clearSubjectRegisterGrid()
        Me.ds.Clear() 'clear the original data
        Me.DropButton.Enabled = False
    End Sub

    Private Sub SubjectRegisterDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SubjectRegisterDataGridView.CellClick
        Dim cb As New OleDb.OleDbCommandBuilder(dataAdapter)
        Dim col, inc As Integer
        Try
            col = SubjectRegisterDataGridView.CurrentCell.ColumnIndex
            If col <> 0 Then
                Me.DropButton.Enabled = True
                Exit Sub
            End If
            inc = SubjectRegisterDataGridView.CurrentCell.RowIndex
            msubjectCodeString = SubjectRegisterDataGridView.CurrentCell.Value
            If (msubjectCodeString <> "") Then
                Me.DropButton.Enabled = True
            Else
                Me.DropButton.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        Dim dialogResult As MsgBoxResult
        Dim deletedOK As Boolean
        Dim messageString = "Drop " & msubjectCodeString & " subject"
        If msubjectCodeString <> "" Then
            dialogResult = MessageBox.Show(messageString, "Confirm Drop", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If dialogResult = MsgBoxResult.Ok Then
                'deletedOK = mySubject.dropStudentSubject(mId, msubjectCodeString)
                deletedOK = mySubject.dropSubject(mId, msubjectCodeString)
                MsgBox("Drop " & msubjectCodeString & " succesfully !")
                displaySubjectRegister(mId)
            End If
        End If
    End Sub

    Private Sub RegistrationForm_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        conn.Close()
    End Sub

    Private Sub AddSubjectButton_Click(sender As Object, e As EventArgs) Handles AddSubjectButton.Click
        'subjectCodeToRegister = SubjectCodeTextBox.Text
        AddSubjectStudentForm.prepareToAddNewSubject()
        AddSubjectStudentForm.ShowDialog()
        displaySubjectRegister(mId)
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

    End Sub
    Private Sub RefreshForm()
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub DisplaySubjectButton_Click(sender As Object, e As EventArgs) Handles DisplaySubjectButton.Click
        displaySubjectRegister(mId)
        Dim totalCreditDouble As Double
        If SubjectRegisterDataGridView.RowCount > 1 Then
            Dim totalCredit As Decimal = 0
            For index As Integer = 0 To SubjectRegisterDataGridView.RowCount - 1
                'totalCredit += Convert.ToDecimal(SubjectRegisterDataGridView.Rows(index).Cells(2).Value)
                totalCredit = 4 'Decimal.Parse(SubjectRegisterDataGridView.Rows(index).Cells(2).Value)

            Next
            TotalCreditLabel.Text = totalCredit
            totalCreditDouble = 50 * totalCredit
            AmountFeeLabel.Text = totalCreditDouble.ToString("C")
        End If
    End Sub

    Private Sub EmailButton_Click(sender As Object, e As EventArgs) Handles EmailButton.Click
        SendEmailForm.ShowDialog()
    End Sub

    Private Sub RegistrationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        openConnection()
    End Sub
End Class