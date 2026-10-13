'NG ZHENG KAI - A25DW0669 (Section J1)
Module UserSession

    Public CurrentRole As String = String.Empty
    Public CurrentUserID As Integer = 0
    Public CurrentAdminID As Integer = 0
    Public CurrentUserName As String = String.Empty
    Public CurrentUserEmail As String = String.Empty

    Public Sub ClearSession()

        CurrentRole = String.Empty
        CurrentUserID = 0
        CurrentAdminID = 0
        CurrentUserName = String.Empty
        CurrentUserEmail = String.Empty

    End Sub

End Module