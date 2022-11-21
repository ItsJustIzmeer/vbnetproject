Imports System.Data.OleDb
Public Class RegistrationFormPrint
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

    Dim mySubject As New RegisterSubject
    Public Sub showStudentInformation(matricString As String)
        displayStudentRecord(matricString)
        mId = matricString
    End Sub
    Private Sub openConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb"
        Try
            'opens the connection
            conn.Open()
            If conn.State = ConnectionState.Open Then
                '  MsgBox("MS Database Connected!")
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
        'close the connection
        conn.Close()
    End Sub

    Private Sub displayStudentRecord(matricString As String)
        ' Dim curStudentRec As 
        openConnection()
        Dim str As String
        'str = "SELECT * FROM student WHERE (matricNumber = '" & matricString & "')"
        str = "SELECT * FROM student WHERE (matricNumber = '" & matricString & "')"
        '  MessageBox.Show(str)
        Dim cmd As OleDbCommand = New OleDbCommand(str, conn)
        dr = cmd.ExecuteReader
        While dr.Read()
            With Me
                .matricNumberLabel.Text = dr("matricNumber").ToString
                .IClabel.Text = dr("icNumber").ToString
                .nameLabel.Text = dr("name").ToString
                .phoneNumberLabel.Text = dr("phoneNumber").ToString
                .classLabel.Text = dr("groupId").ToString
            End With
        End While
        conn.Close()
    End Sub
    Private Sub displaySubjectRegister(matricString As String)
        clearSubjectRegisterGrid()
        sql = "Select r.subjectCode,s.subjectName,s.credit"
        sql &= " from subjectregister r, student stu, subject s"
        sql &= " where r.matricNumber = stu.matricNumber"
        sql &= " and r.matricNumber = '" & matricString & "'"
        sql &= " and r.subjectCode = s.subjectCode"
        sql &= " and r.credit = s.credit"
        'MessageBox.Show(sql)
        Debug.WriteLine(sql)
        dataAdapter = New OleDb.OleDbDataAdapter(sql, conn)
        dataAdapter.Fill(ds, "ihsanTuitionCenterDb")
        Me.SubjectRegisterDataGridView.DataMember = "ihsanTuitionCenterDb"
        SubjectRegisterDataGridView.DataSource = ds
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintPreviewDialog1.ShowDialog = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub DisplaySubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplaySubjectToolStripMenuItem.Click
        displaySubjectRegister(mId)
        Dim totalCreditDouble As Double
        If SubjectRegisterDataGridView.RowCount > 1 Then
            Dim totalCredit As Decimal = 0
            For index As Integer = 0 To SubjectRegisterDataGridView.RowCount - 1
                totalCredit += Convert.ToDecimal(SubjectRegisterDataGridView.Rows(index).Cells(2).Value)

            Next
            TotalCreditLabel.Text = totalCredit
            totalCreditDouble = 50 * totalCredit
            AmountFeeLabel.Text = totalCreditDouble.ToString("C")
        End If
    End Sub

    Private Sub clearSubjectRegisterGrid()
        Me.ds.Clear() 'clear the original data
    End Sub
End Class