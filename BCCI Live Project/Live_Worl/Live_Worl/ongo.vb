Imports System.Data.SqlClient

Public Class ongo
    Dim match As New Collection
    'Friend x As Integer = 2
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim adp As New SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim sql As String
    Dim x As Integer

    Private Sub ongo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Lavender
        GroupBox1.BackColor = Color.BlueViolet
        GroupBox2.BackColor = Color.Gold

        MessageBox.Show("IND vs Aus" & vbCrLf & "Ind Won the toss and Field first" & vbCrLf & "Aus_Score" & score.Label18.Text & "/" & score.Label20.Text, "Current Match going on :- Match 1st", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' addit()


        PictureBox1.Load("D:\Main Project of BCCI\BCCI Live Project\Live_Worl\Live_Worl\image\test.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage



        PictureBox2.Load("D:\Main Project of BCCI\BCCI Live Project\Live_Worl\Live_Worl\image\odi.jpg")
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage



        mee()
    End Sub
    Public Sub mee()
        ds.Tables.Clear()
        sql = "select * from bti"
        'cmd = New SqlCommand(sql, con)
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)

        con.Close()
        ListBox1.DisplayMember = "name"
        ListBox1.ValueMember = "name"
        ListBox1.DataSource = ds.Tables(0)
        ListBox1.Text = "See"

    End Sub
    'Public Sub addit()
    '    For i = 2 To 7
    '        Dim m1(i) As mtc1
    '        m1(i).get_no = Str(i)
    '        m1(i).get_in = "IND Vs Aus ODI" & Str(i)


    '        'm1(i).get_dt = Date.Now.AddDays(i)
    '        Dim xa As Date = Date.Now.AddDays(i)
    '        i = 0

    '        xa.AddDays(i + 3)
    '        m1(i).get_dt = xa.AddDays(i + 3)

    '        'x = x + 2

    '        match.Add(m1(i))
    '        ListBox1.Items.Add(m1(i).get_in)
    '    Next



    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim m1 As mtc1 = CType(match.Item(ListBox1.SelectedIndex + 1), mtc1)
    '    MessageBox.Show("NO:" + m1.get_no & vbCrLf & "Info:" + m1.get_in & vbCrLf & "Date:" + m1.get_dt)

    'End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        score.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class