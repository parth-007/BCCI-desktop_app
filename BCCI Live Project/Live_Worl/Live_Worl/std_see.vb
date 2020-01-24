Imports System.Data.SqlClient


Public Class std_see
    Dim sql As String
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As SqlCommand
    Dim x As Integer
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim cmd1 As SqlCommand
    Private Sub std_see_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.AliceBlue
        DataGridView1.BackgroundColor = Color.CadetBlue

        fill1()

    End Sub
    Public Sub fill1()
        ds.Tables.Clear()
        sql = "select s.sno,s.name,s.dateaug,st.statename,s.maxlen,s.press_facility,s.owner from stadium s,state st where s.stateid=st.stateid"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
     
End Class