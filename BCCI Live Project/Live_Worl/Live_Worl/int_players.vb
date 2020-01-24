Imports System.Data.SqlClient

Public Class int_players
    Dim flag As Integer = 0
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim x As Integer
    Dim i As Integer

    Public Sub fillme()
        ds.Tables.Clear()

        sql = "select * from bowler"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        bowlcombo.DisplayMember = "type"
        bowlcombo.ValueMember = "bowl_id"
        bowlcombo.DataSource = ds.Tables(0)
        bowlcombo.Text = "Select Bowler Type"

    End Sub
    'Public Sub check()
    '    Dim yn As Integer
    '    yn = MessageBox.Show("Are You an Admin?", "Secutiry", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '    If (yn = DialogResult.OK) Then
    '        Panel1.Visible = True

    '    Else
    '        MsgBox("You can just see")
    '        flag = 0
    '        '            fillgrid()

    '    End If
    'End Sub

    Private Sub int_players_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure
        Panel2.BackColor = Color.Orange
        player.BackColor = Color.Gold



        'Panel1.Visible = False
        'player.Visible = True



        'check()
        fillme()
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
    'Private Sub okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn.Click
    '    If (passwordtext.Text <> "heybro123") Then
    '        MsgBox("Wrong password")
    '        MsgBox("You can just see")
    '        flag = 0
    '        '  fillgrid()

    '    Else
    '        MsgBox("Welcome Admin")
    '        player.Visible = True
    '        Panel1.Visible = False

    '        flag = 1
    '    End If
    'End Sub

    Private Sub upldbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upldbtn.Click
        If (OpenFileDialog1.ShowDialog) Then
            PictureBox1.Load(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            Dim src = OpenFileDialog1.FileName
            '         MsgBox(src)

        End If

        Dim strpath = OpenFileDialog1.SafeFileName
        MsgBox(strpath)

        '  MsgBox("image\" & strpath)
        Dim filesrc = Application.ExecutablePath & "\image\"
        'MsgBox(filesrc)

        'PictureBox1.Image.Save("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\" & strpath)
        PictureBox1.Image.Save("D:\Main Project of BCCI\BCCI Live Project\Live_Worl\Live_Worl\bin\Debug\image\" & strpath)







    End Sub

    Private Sub insertbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertbtn.Click
        Dim strpath = OpenFileDialog1.SafeFileName
        MsgBox(strpath)
        Dim spc As String
        If (RadioButton1.Checked = True) Then
            spc = RadioButton1.Text
        ElseIf (RadioButton2.Checked = True) Then
            spc = RadioButton2.Text
        Else
            spc = RadioButton3.Text

        End If

        Dim hn As String
        If (RadioButton4.Checked = True) Then
            hn = RadioButton4.Text
        Else
            hn = RadioButton5.Text

        End If

        ds.Tables.Clear()
        sql = "insert into player (fname,lname,birthdate,speciality,[right/left],match,runs,bat_avg,bat_sr,[50],[100],best,wickets,bowl_avg,economy,bowl_id,catches,photo) values('" & fnametext.Text & "','" & lnametext.Text & "','" & dtp1.Value & "','" & spc & "','" & hn & "'," & matchtext.Text & "," & runstext.Text & "," & battext.Text & "," & srtext.Text & "," & fiftext.Text & "," & huntext.Text & ",'" & besttext.Text & "'," & wicktext.Text & "," & bowlavgtext.Text & "," & econtext.Text & "," & Val(bowlcombo.SelectedValue) & "," & catchestext.Text & ",'image/" & strpath & "')"

        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteNonQuery
        con.Close()
        If (x > 0) Then
            MsgBox("REcord Inserted")

        End If
        fillgrid()


    End Sub

    Private Sub dispbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dispbtn.Click
        fillgrid()

    End Sub
    Public Sub clear_me()
        fnametext.Clear()
        lnametext.Clear()
        dtp1.Value = Date.Now
        matchtext.Clear()
        runstext.Clear()
        wicktext.Clear()
        battext.Clear()
        srtext.Clear()
        econtext.Clear()
        econtext.Clear()
        catchestext.Clear()
        PictureBox1.Image = Nothing

        bowlavgtext.Clear()
        bowlcombo.Text = ""
        battext.Clear()
        fiftext.Clear()
        huntext.Clear()
        besttext.Clear()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        clear_me()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        i = DataGridView1.CurrentRow.Index
        If (DataGridView1.Rows(i).Cells(4).Value.ToString = "Allrounder") Then
            RadioButton3.Checked = True
        ElseIf (DataGridView1.Rows(i).Cells(4).Value.ToString = "Bowler") Then
            RadioButton2.Checked = True
        ElseIf (DataGridView1.Rows(i).Cells(4).Value.ToString = "Batsman") Then
            RadioButton1.Checked = True
        End If
        If (DataGridView1.Rows(i).Cells(5).Value.ToString = "Left") Then
            RadioButton5.Checked = True

        ElseIf (DataGridView1.Rows(i).Cells(5).Value.ToString = "Right") Then
            RadioButton4.Checked = True

        End If
        idtext.Text = DataGridView1.Rows(i).Cells(0).Value.ToString

        fnametext.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        lnametext.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        dtp1.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        matchtext.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        runstext.Text = DataGridView1.Rows(i).Cells(7).Value.ToString
        battext.Text = DataGridView1.Rows(i).Cells(8).Value.ToString()
        srtext.Text = DataGridView1.Rows(i).Cells(9).Value.ToString
        fiftext.Text = DataGridView1.Rows(i).Cells(10).Value.ToString
        huntext.Text = DataGridView1.Rows(i).Cells(11).Value.ToString
        besttext.Text = DataGridView1.Rows(i).Cells(12).Value.ToString
        wicktext.Text = DataGridView1.Rows(i).Cells(13).Value.ToString
        bowlcombo.Text = DataGridView1.Rows(i).Cells(16).Value.ToString
        bowlavgtext.Text = DataGridView1.Rows(i).Cells(14).Value.ToString
        econtext.Text = DataGridView1.Rows(i).Cells(13 + 2).Value.ToString
        catchestext.Text = DataGridView1.Rows(i).Cells(17).Value.ToString
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox1.Load(DataGridView1.Rows(i).Cells(18).Value.ToString)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class