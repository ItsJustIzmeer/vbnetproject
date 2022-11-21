Imports System.Data.OleDb
Friend Structure RegisterSubjectRecord
    Dim subjectCode, credit, matric As String
    ' Dim dob As Date
End Structure
Public Class RegisterSubject
    Private con As New OleDb.OleDbConnection
    Friend Function dropSubject(matric As String) As Boolean
        Try
            Dim sql As String
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb")
            con.Open()
            sql = "DELETE FROM subjectregister WHERE (subjectCode = '" & matric & "')"
            ' MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch e As Exception
            MessageBox.Show(e.ToString) 'data integrity error
            Return False
        End Try

    End Function

    Friend Function getAddSubjectRecord(matric) As RegisterSubjectRecord
        Dim dr As OleDbDataReader
        Dim RegisterSubjectRec As New RegisterSubjectRecord
        Try
            Dim sql As String
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb")

            'con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "select * FROM subjectregister WHERE (matricNumber = '" & matric & "')"

            'MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                RegisterSubjectRec.matric = dr("matricNumber").ToString
                RegisterSubjectRec.subjectCode = dr("subjectCode").ToString
                RegisterSubjectRec.credit = dr("credit").ToString
                con.Close()
                Return RegisterSubjectRec
            End If
        Catch
            MessageBox.Show("Error accessing student record for subject register with matric number :" & matric)
            con.Close()
            Return RegisterSubjectRec
        End Try
        Return RegisterSubjectRec
    End Function
    Friend Function addRegisterSubject(newRegisterSubjectRec As RegisterSubjectRecord) As Boolean
        Try
            Dim sql As String
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb")
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            If con.State = ConnectionState.Open Then
                '  MsgBox("MS Database Connected!")
            Else
                ' MsgBox("error connecting to database")
                Exit Function
            End If
            sql = "insert into subjectregister(matricNumber,subjectCode,credit)"
            sql = sql & " values('" & newRegisterSubjectRec.matric & "','" & newRegisterSubjectRec.subjectCode & "','" & newRegisterSubjectRec.credit & "')"
            'insert into subject(matricNumber,icNumber,name,dateOfBirth,groupId) values('M1002','','Ahmad','1/9/2021 4:29:14 PM','P1_MERAH')
            ' MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception

            MessageBox.Show("Error adding new add subject student record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try
        Return True

    End Function
End Class
