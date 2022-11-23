Imports System.Data.OleDb
Friend Structure SubjectRecord
    Dim subjectCode, subjectName, credit As String
End Structure
Public Class Subject
    Private con As New OleDb.OleDbConnection
    Friend Function RegisterSubjectForThisStudent(subjectCode As String, matricNumber As String) As Boolean
        Try
            Dim sql As String
            Dim con As New OleDbConnection(My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName) '"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\registrationdb.accdb")
            con.Open()
            sql = "insert into subjectregister(subjectCode,matricNumber)"
            sql = sql & " values('" & subjectCode & "','" & matricNumber & "')"
            'MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error register " + subjectCode + " for student with matric:" + matricNumber)
            Debug.WriteLine(ex.ToString)
        End Try
        Return True

    End Function
    Friend Function addNewSubject(newSubjectRec As SubjectRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            If con.State = ConnectionState.Open Then
            Else
                MsgBox("An error occured during connecting to the database")
                Exit Function
            End If
            sql = "insert into subject (subjectCode,subjectName,credit)"
            sql = sql & " values('" & newSubjectRec.subjectCode & "','" & newSubjectRec.subjectName & "','" & newSubjectRec.credit & "')"
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception

            'MessageBox.Show("There was an error while adding new Subject record. Message:" & ex.ToString)
            MsgBox("There was an error while adding new Subject record. Message: " & ex.ToString, MsgBoxStyle.Exclamation)
            con.Close()
            Return False
        End Try
        Return True

    End Function
    Friend Function deleteSubjectRecord(subjectCode As String) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "DELETE FROM subject WHERE (subjectCode = '" & subjectCode & "')"
            'MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch e As Exception
            MessageBox.Show(e.ToString) 'data integrity error
            Return False
        End Try
    End Function
    Friend Function dropSubject(matricString As String, subjectCode As String) As Boolean
        Try
            Dim sql As String
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ihsanTuitionCenterDb.accdb")
            con.Open()
            sql = "DELETE FROM subject WHERE (matricNumber = '" & matricString & "' and subjectCode ='" & subjectCode & "')"

            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch
            'MessageBox.Show("There was an error while dropping Subject")
            MsgBox("There was an error while dropping Subject", MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function
    Friend Function getSubjectRecord(subjectCode As String) As SubjectRecord
        Dim dr As OleDbDataReader
        Dim subjectRec As New SubjectRecord
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "select * FROM subject WHERE (subjectCode = '" & subjectCode & "')"

            'MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                dr.Read()
                subjectRec.subjectCode = dr("subjectCode").ToString
                subjectRec.subjectName = dr("subjectName").ToString
                subjectRec.credit = dr("credit")
                con.Close()
                Return subjectRec
            End If
        Catch
            MsgBox("There was an error while accessing Subject record for Subject with Subject Code: " & subjectCode, MsgBoxStyle.Exclamation)
            con.Close()
            Return subjectRec
        End Try
        Return subjectRec
    End Function
    Friend Function updateThisSubject(oldSubjectRec As SubjectRecord, newSubjectRec As SubjectRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sql = "update subject set subjectCode ='" & newSubjectRec.subjectCode & "',"
            sql = sql & " subjectName ='" & newSubjectRec.subjectName & "',"
            sql = sql & " credit ='" & newSubjectRec.credit & "'"
            sql = sql & " where subjectCode ='" & oldSubjectRec.subjectCode & "'"
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            MsgBox("There was an error while updating Subject record. Message: " & ex.ToString, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function
End Class
