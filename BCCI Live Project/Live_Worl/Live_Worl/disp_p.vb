Imports System.Data.SqlClient

Public Class disp_p
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Private Sub disp_p_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure

        DataGridView1.BackgroundColor = Color.GreenYellow

        fillgrid()

    End Sub
    Public Sub fillgrid()
        ds.Tables.Clear()

        sql = "select p.pid,p.fname,p.lname,p.birthdate,p.speciality,p.[right/left],p.match,p.runs,p.bat_avg,p.bat_sr,p.[50],p.[100],p.best,p.wickets,p.bowl_avg,p.economy,b.type,p.catches,p.photo from player p,bowler b where p.bowl_id=b.bowl_id"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)

        con.Close()
        DataGridView1.DataSource = ds.Tables(0)

    End Sub
End Class