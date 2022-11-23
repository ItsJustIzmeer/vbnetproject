Public Class UserClass
    Friend userName As String
    Friend password As String
    Friend userLevel As String
    Public Sub setUserData(userName As String, password As String)
        Me.userName = userName
        Me.password = password
    End Sub
    Public Sub setUserData(userName As String, password As String, userLevel As String)
        Me.userName = userName
        Me.password = password
        Me.userLevel = userLevel
    End Sub
    Public Function getUser() As UserClass
        userName = Me.userName
        password = Me.password
        userLevel = Me.userLevel
        Return Me
    End Function
End Class
