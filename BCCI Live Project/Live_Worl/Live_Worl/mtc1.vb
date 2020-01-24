Public Class mtc1
    Private no As String
    Private info As String
    Private date1 As Date
    Public Property get_no As String
        Get
            Return no
        End Get
        Set(ByVal value As String)
            no = value
        End Set
    End Property
    Public Property get_in As String
        Get
            Return info
        End Get
        Set(ByVal value As String)
            info = value
        End Set
    End Property
    Public Property get_dt As Date
        Get
            Return date1
        End Get
        Set(ByVal value As Date)
            date1 = value
        End Set
    End Property
End Class
