Imports System.Data.SqlClient


Public Class login
    Dim t1 As String
    Dim adp As SqlDataAdapter
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim ds As New DataSet
    Dim sql, sql1 As String
    Dim cmd, cmd1 As New SqlCommand

    Dim obj1 As New register

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure
        usernametext.Clear()
        passwordtext.Clear()

        PictureBox1.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\29.jpg")
        score.Timer1.Start()
        score.Timer1.Interval = 1250000
        score.Timer2.Start()
        score.Timer2.Interval = 2450000
        score.Timer3.Start()
        score.Timer3.Interval = 45000
        score.Timer4.Start()
        score.Timer4.Interval = 130000
        score.Timer5.Start()
        score.Timer5.Interval = 127000

        score.Timer6.Start()
        score.Timer6.Interval = 1060000

        score.Timer7.Start()
        score.Timer7.Interval = 1210000

        score.Timer8.Start()
        score.Timer8.Interval = 270000

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'obj1.Show()
        register.Show()
    End Sub

    Private Sub resetbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetbtn.Click
        usernametext.Enabled = True
        passwordtext.Enabled = True

        usernametext.Clear()
        passwordtext.Clear()

    End Sub

    Private Sub loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbtn.Click
        If (usernametext.Text = "" Or passwordtext.Text = "") Then
            MsgBox("Enter Information .. can't live it blank")
        Else
            Dim t2 As String
            Dim x, y As String

            t1 = usernametext.Text
            t2 = passwordtext.Text

            sql = "select username from visitor where username='" & usernametext.Text & "' and password='" & passwordtext.Text & "'"
            sql1 = "select password from visitor where username='" & usernametext.Text & "' and password='" & passwordtext.Text & "'"

            cmd = New SqlCommand(sql, con)
            cmd1 = New SqlCommand(sql1, con)
            con.Open()
            x = cmd.ExecuteScalar
            y = cmd1.ExecuteScalar

            'MsgBox(x)
            'MsgBox(y)

            con.Close()

            If (x = t1 And y = t2) Then
                MsgBox("Found..Redirecting you to the main page...")
                main.Show()
                Me.Hide()

            Else
                MsgBox("Account Not Found")

            End If
        End If
       
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        GroupBox1.BackColor = Color.Lime

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    If (usernametext.Text = "") Then
    '        MsgBox("First Fill the Username")
    '        usernametext.focus
    '    Else

    '    End If
    '    usernametext.Enabled = False
    '    MsgBox("Ok Set THe new Password")
    '    passwordtext.Focus()
    '    sql = "update visitor set password='" & passwordtext.Text & "' where username='" & usernametext.Text & "'"
    '    cmd = New SqlCommand(sql, con)
    '    con.Open()
    '    Dim l1 = cmd.ExecuteNonQuery

    '    con.Close()
    '    If (l1 > 0) Then
    '        MsgBox("Password Updated")

    '    End If
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (usernametext.Text = "") Then
            MsgBox("First Popularize the username")
            usernametext.Focus()
        Else
            passwordtext.Clear()

            usernametext.Enabled = False
            Dim str1 = usernametext.Text

            sql = "update visitor set password=null where username='" & str1 & "'"
            cmd = New SqlCommand(sql, con)
            con.Open()
            Dim k1 = cmd.ExecuteNonQuery

            con.Close()
            'If (k1 > 0) Then
            '    MsgBox("yeah")
            'End If
            MsgBox("Now Set New Password For " & usernametext.Text + " " + "On a New PAge")
            pass.Show()



        End If
    End Sub
End Class
