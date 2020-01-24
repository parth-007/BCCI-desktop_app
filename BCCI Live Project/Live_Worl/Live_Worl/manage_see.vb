Imports System.Data.SqlClient

Public Class manage_see
    Dim sql As String
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As SqlCommand
    Dim x As Integer
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim cmd1 As SqlCommand
    Dim i, tot_rows As Integer

    Private Sub manage_see_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Chocolate
        GroupBox1.BackColor = Color.Yellow
        fillgrid()

    End Sub
    Public Sub navigate()
        ''Dim i As Integer

        'i = DataGridView1.CurrentRow.Index
        textid.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        fnametext.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        lnametext.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        rolecombo.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        emailtext.Text = DataGridView1.Rows(i).Cells(4).Value.ToString
        zonecombo.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        statecombo.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        phonetext.Text = DataGridView1.Rows(i).Cells(7).Value.ToString
        exptext.Text = DataGridView1.Rows(i).Cells(8).Value.ToString

        DataGridView1.Rows(i).Selected = True


    End Sub

    Public Sub fillgrid()
        ds.Tables.Clear()
        sql = "select m.mid,m.fname,m.lname,m.role,z.zonename,st.statename,m.phoneno,m.email,m.experience from management m,state st,zone z where m.zoneid=z.zoneid and m.stateid=st.stateid and st.zoneid=z.zoneid"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        DataGridView1.DataSource = ds.Tables(0)
        tot_rows = DataGridView1.DataSource.Rows.Count


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        '  Dim i As Integer
        Dim row = DataGridView1.CurrentRow.Index
        i = row

        textid.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        fnametext.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        lnametext.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        rolecombo.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        emailtext.Text = DataGridView1.Rows(i).Cells(7).Value.ToString
        zonecombo.Text = DataGridView1.Rows(i).Cells(4).Value.ToString
        statecombo.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        phonetext.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        exptext.Text = DataGridView1.Rows(i).Cells(8).Value.ToString

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ds.Tables.Clear()
        sql = "select m.mid,m.fname,m.lname,m.role,z.zonename,st.statename,m.phoneno,m.email,m.experience from management m,state st,zone z where m.zoneid=z.zoneid and m.stateid=st.stateid and st.zoneid=z.zoneid order by z.zonename"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView1.Rows(i).Selected = False
        i = 0
        navigate()
        MsgBox("1st Record")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView1.Rows(i).Selected = False
        i = tot_rows - 1
        navigate()
        MsgBox("LAst Record")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DataGridView1.Rows(i).Selected = False
        If (i = 0) Then
            MsgBox("1st Recorrd")
        Else
            i = i - 1
            navigate()

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        DataGridView1.Rows(i).Selected = False
        If (i = tot_rows - 1) Then
            MsgBox("Last Record")
        Else
            i = i + 1
            navigate()

        End If
    End Sub
End Class