Imports System.Data.OleDb
Friend Structure LoginRecord
    Dim userName, passWord As String
End Structure
Public Class ResetPassword
    Private con As New OleDb.OleDbConnection
    Friend Function updateThisLogin(oldLoginRec As LoginRecord, newLoginRec As LoginRecord) As Boolean
        Try
            Dim sql As String
            con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
            con.Open()

            sql = "update userTbl set luserName ='" & newLoginRec.userName & "',"
            sql = sql & " lpassword ='" & newLoginRec.passWord & "'"
            sql = sql & " where luserName ='" & newLoginRec.userName & "'"
            'MessageBox.Show(sql)
            Debug.WriteLine(sql)
            Dim cmd As New OleDbCommand(sql, con)
            cmd.ExecuteNonQuery()
            con.Close()
            Return True

        Catch ex As Exception
            'MessageBox.Show("Error updating user record. Message:" & ex.ToString)
            MsgBox("Error updating user record. Message: " & ex.ToString, MsgBoxStyle.Exclamation)
            Return False
        End Try

    End Function
End Class
