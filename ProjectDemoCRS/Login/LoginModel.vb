Imports System.Data.OleDb
Public Class LoginModel
    Private con As New OleDb.OleDbConnection
    Public Function checkLogin(user As UserClass) As Boolean
        Dim dr As OleDbDataReader
        Dim sql As String
        con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        con.Open()
        sql = "Select * FROM userTbl WHERE luserName='" & user.userName & "' AND lpassword='" & user.password & "'"

        Dim cmd1 As New OleDbCommand(sql, con)
        dr = cmd1.ExecuteReader()

        If dr.Read Then
            'userLevel = dr("userlevel").ToString
            'Debug.WriteLine(userLevel)
            Return True
        End If
        con.Close()
        Return False
    End Function
End Class
