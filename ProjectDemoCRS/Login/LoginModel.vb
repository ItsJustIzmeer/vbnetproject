Imports System.Data.OleDb
Public Class LoginModel
    Private con As New OleDb.OleDbConnection
    Dim user As UserClass
    Public Function checkLogin(user As UserClass) As Boolean
        Dim dr As OleDbDataReader

        Dim sql As String
        con.ConnectionString = My.Resources.databaseConnectionPath & Application.StartupPath & My.Resources.databaseName
        con.Open()

        sql = "Select * FROM userTbl WHERE userName='" & user.userName & "' AND password='" & user.password & "'"

        Dim cmd1 As New OleDbCommand(sql, con)
        dr = cmd1.ExecuteReader()
        If dr.Read Then
            con.Close()
            Return True
        End If
        con.Close()
        Return False
    End Function
End Class
