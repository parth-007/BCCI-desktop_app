Imports System.Data.SqlClient
Imports System.Configuration

Public Class tryconfig
    '    Dim con As New SqlConnection

    Dim strcon As String = ConfigurationManager.ConnectionStrings("con1").ConnectionString
    Dim con As New SqlConnection(strcon)
    Private Sub tryconfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        MsgBox("Connection Established")

        con.Close()

    End Sub
End Class