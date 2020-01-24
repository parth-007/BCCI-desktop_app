Imports System.Data.SqlClient

Public Class ipl
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim sql As String
    Dim adp As SqlDataAdapter
    Dim sql1 As String
    Dim cmd1 As New SqlCommand

    Dim ds As New DataSet
    Dim x As Integer
    Private Sub ipl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePicker2.Enabled = False

        MsgBox("Welcome Admin" & vbCrLf & "It's Been a very long time since you are here" & vbCr & "I warmly welcome you")
        Panel4.BackColor = Color.Gold
        Me.BackColor = Color.Azure
        Panel1.BackColor = Color.Orange
        Panel2.BackColor = Color.Orange
        TextBox1.BackColor = Color.MediumPurple
        TextBox6.BackColor = Color.DeepPink
        Panel3.BackColor = Color.Ivory

        cfo()
        cfo1()
        ts()
        ComboBox1.Items.Add("4")
        ComboBox1.Items.Add("5")
        ComboBox1.Items.Add("6")
        ComboBox1.Items.Add("7")
        ComboBox1.Items.Add("8")
        ComboBox1.Items.Add("9")
        ComboBox1.Items.Add("10")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Whoa!!!! IPL is starting...." & vbCrLf & "It Will be Blast")
        MsgBox("GET READY ALL THE " & (ComboBox1.SelectedItem.ToString) & " TEAMS ")




    End Sub
    Public Sub ts()
        sql = "select fname from management where mid=353"
        sql1 = "select phoneno from management where mid=352"
        cmd = New SqlCommand(sql, con)
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        Dim s1 = cmd.ExecuteScalar
        Dim s2 = cmd1.ExecuteScalar

        con.Close()
        TextBox8.Text = s1
        TextBox7.Text = s2
    End Sub
    Public Sub cfo()
        ds.Tables.Clear()
        sql = "select fname from management where mid=352"
        sql1 = "select phoneno from management where mid=352"
        cmd = New SqlCommand(sql, con)
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        Dim s1 = cmd.ExecuteScalar
        Dim s2 = cmd1.ExecuteScalar

        con.Close()
        TextBox2.Text = s1
        TextBox3.Text = s2
    End Sub
    Public Sub cfo1()
        ds.Tables.Clear()
        sql = "select fname from management where mid=360"
        sql1 = "select phoneno from management where mid=360"
        cmd = New SqlCommand(sql, con)
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        Dim s1 = cmd.ExecuteScalar
        Dim s2 = cmd1.ExecuteScalar

        con.Close()
        TextBox4.Text = s1
        TextBox5.Text = s2
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        main.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ComboBox1.Text = ""
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox15.Clear()
        TextBox14.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Sorry, I M in a Meeting", "Pankil")
        MessageBox.Show("Sir, IPL is going to start", "Admin")
        MessageBox.Show("Call parth, whatever he says i m ok", "Pankil")
        MessageBox.Show("Sir,ok then", "Admin")

        sender.enabled = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Yes It Will be Great", "Parth")
        MessageBox.Show("Sir From when??", "Admin")
        MessageBox.Show("Somewhere around 10 April..", "Parth")
        MessageBox.Show("Sir Team has finalized 7 april..", "Admin")
        MessageBox.Show("Good Go Ahead", "Parth")
        MessageBox.Show("Have a good day , Sir!", "Admin")

        sender.enabled = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Yes I got a call from CFO", "Treasurere")
        MessageBox.Show("We need your official statement", "Admin")
        MessageBox.Show("Yeah today i will give the statement", "Treasurere")
        MessageBox.Show("Thanks a lot", "Admin")

        sender.enabled = False

    End Sub

    Private Sub TextBox11_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox11.LostFocus
        TextBox12.Text = Val(TextBox11.Text) - ((Val(TextBox10.Text) + Val(TextBox14.Text) + Val(TextBox15.Text)))

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        DateTimePicker2.Enabled = True

    End Sub
End Class