Imports System.Data.OleDb
Friend Structure UserRecord
    Dim username, password, userlevel As String
End Structure
Public Class User
    Private con As New OleDb.OleDbConnection

    Friend Function getUserRecord(username) As UserRecord
        Dim dr As OleDbDataReader
        Dim userRec As New UserRecord
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "select * FROM userTbl WHERE (userName = '" & username & "')"

            Dim cmd As New OleDbCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                userRec.username = dr("userName").ToString
                userRec.password = dr("password").ToString
                userRec.userlevel = dr("userLevel").ToString
                con.Close()
                Return userRec
            End If
        Catch
            MessageBox.Show("Error accessing user record for user with username :" & username)
            con.Close()
            Return userRec
        End Try
        Return userRec
    End Function

    Friend Function addUser(newUserRec As UserRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            If con.State = ConnectionState.Open Then
                MsgBox("MS Database Connected!")
            Else
                MsgBox("error connecting to database")
                Exit Function
            End If
            sql = "insert into userTbl(userName,[password],userLevel)"
            sql = sql & " values('" & newUserRec.username & "','" & newUserRec.password & "','" & newUserRec.userlevel & "')"
            'insert into student(matricNumber,icNumber,name,dateOfBirth,groupId) values('M1002','','Ahmad','1/9/2021 4:29:14 PM','P1_MERAH')
            MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch ex As Exception

            MessageBox.Show("Error adding new user record. Message:" & ex.ToString)
            con.Close()
            Return False
        End Try
        Return True

    End Function

    Friend Function updateThisUser(oldUSerRec As UserRecord, newUserRec As UserRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sql = "update userTbl set userName ='" & newUserRec.username & "',"
            sql = sql & " password ='" & newUserRec.password & "',"
            sql = sql & " where userName ='" & newUserRec.username & "'"
            'MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error updating group record. Message:" & ex.ToString)
            Return False
        End Try


    End Function

    Friend Function deleteUserRecord(username As String) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()
            sql = "DELETE FROM userTbl WHERE (userName = '" & username & "')"
            MessageBox.Show(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True
        Catch e As Exception
            MessageBox.Show(e.ToString) 'data integrity error
            Return False
        End Try

    End Function
End Class
