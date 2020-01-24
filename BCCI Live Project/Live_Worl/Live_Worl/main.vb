Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

'Imports Microsoft.office.interorp.word

Public Class main
    Dim sql As String
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As SqlCommand
    Dim x As Integer
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim cmd1 As SqlCommand

    Dim str1 As String
    Dim obj As New login
    Dim flag As Integer = 0
    Dim f1 = 0
    Dim f2 = 0

    Public Sub getme()
        Dim e1 As String = register.usernametext.Text
        sql = "select firstname from visitor where username='" & e1 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim t1 = cmd.ExecuteScalar

        con.Close()

        lbl1.Text = t1

    End Sub
    Public Sub getme1()
        Dim e1 As String = login.usernametext.Text
        sql = "select firstname from visitor where username='" & e1 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim t1 = cmd.ExecuteScalar

        con.Close()

        lbl1.Text = t1

    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Me.BackgroundImage = New Bitmap("D:\Main Project of BCCI\BCCI Live Project\Live_Worl\Live_Worl\35.jpg")
        Me.BackColor = Color.HotPink

        Panel1.BackColor = Color.Azure
        Dim myfont As New Font("Sans Serif", 12, FontStyle.Regular)
        Label3.Text = "Welcome TO BCCI"
        Label3.Font = myfont
        Timer2.Enabled = True

        getme()
        getme1()
        Timer1.Enabled = True


        lbl1.Visible = False


        adminloggrp.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage

        PictureBox1.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\gg.jpg")
        PictureBox2.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\lol.jpg")

        PictureBox3.Load("D:\Main Project of BCCI\BCCI Live Project\Live_Worl\Live_Worl\37.jpg")
        'sql = "alter table visitor add (phoneno numeric(18,0))"
        'cmd = New SqlCommand(sql, con)
        'con.Open()
        'con.Close()

    End Sub

  


    Private Sub DisplayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToolStripMenuItem.Click
        manage_see.Show()

    End Sub

   
    Private Sub AdminLoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminLoginToolStripMenuItem.Click
     

    End Sub

    Private Sub loginbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginbtn.Click
        Dim t1, t2 As String
        Dim x As String
        t1 = usertext.Text
        t2 = "heybro123"
        sql = "select username from visitor where username='" & usertext.Text & "'"
        sql1 = "select password from visitor where password=' " & passtext.Text & "' "
        Dim sql2 As String
        sql2 = "select firstname from visitor where username='" & usertext.Text & "'"

        cmd = New SqlCommand(sql, con)
        cmd1 = New SqlCommand(sql1, con)
        Dim cmd2 As New SqlCommand
        cmd2 = New SqlCommand(sql2, con)

        con.Open()
        x = cmd.ExecuteScalar()
        Dim z = cmd2.ExecuteScalar

        ' MsgBox(x)
        con.Close()
        If (t1 = "admin" And passtext.Text = t2) Then
            lbl1.Visible = True

            lbl1.Text = "Welcome" & " " & z
            MsgBox("Welcome" & " " & z)
            '   lbl1.Text = "Welcome" & " " & z

            flag = 1
            adminloggrp.Visible = False
            AddNewToolStripMenuItem.Enabled = True
            AddNewToolStripMenuItem1.Enabled = True
            AddNewToolStripMenuItem2.Enabled = True
        Else
            MsgBox("Wrong Password or Username")
            flag = 0
            lbl1.Visible = False
            passtext.Focus()
            AddNewToolStripMenuItem.Enabled = False
            AddNewToolStripMenuItem1.Enabled = False
            AddNewToolStripMenuItem2.Enabled = False
        End If
        'adminloggrp.Visible = False

    End Sub

    Private Sub rsrbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rsrbtn.Click
        usertext.Clear()
        passtext.Clear()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        login.Show()


        Me.Hide()




    End Sub

    Private Sub adminloggrp_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adminloggrp.Enter

    End Sub

    Private Sub ManagementToolStripMenuItem_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagementToolStripMenuItem.MouseUp


        If (flag = 0) Then
            MsgBox("You can add new management but you must be admin to do it..otherwise you just can see")
            AddNewToolStripMenuItem.Enabled = False

        Else
            AddNewToolStripMenuItem.Enabled = True

        End If
    End Sub
    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        management.Show()

    End Sub

    Private Sub DisplayStadiumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayStadiumsToolStripMenuItem.Click
        std_see.Show()


    End Sub

  

    Private Sub StadiumsToolStripMenuItem_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StadiumsToolStripMenuItem.MouseUp


        If (flag = 0) Then
            MsgBox("You can add new stadium details but you must be admin to do it..otherwise you just can see")
            AddNewToolStripMenuItem1.Enabled = False
        Else
            AddNewToolStripMenuItem1.Enabled = True

        End If
    End Sub

    Private Sub AddNewToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem1.Click
        stadium.Show()

    End Sub

    Private Sub ICCReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ICCReportToolStripMenuItem.Click
        Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\icc.docx")

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    'Public Sub OpenWordDocument()
    '    Dim objWord As Microsoft.
    '    Dim objDoc As Word.Document
    '    objWord = CreateObject("Word.Application")
    '    objDoc = objWord.Documents.Open("D:\Test.docx")
    '    objWord.Visible = True
    'End Sub

    Private Sub PhotoGalleryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoGalleryToolStripMenuItem.Click
        Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\gallery.html")
    End Sub

    Private Sub QuestionOfTheDayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestionOfTheDayToolStripMenuItem.Click
        QOTD.Show()

    End Sub

    Private Sub RegularQuestionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegularQuestionsToolStripMenuItem.Click
        regq.Show()

    End Sub

    Private Sub NewsletterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsletterToolStripMenuItem.Click
        If (f1 = 1) Then
            MsgBox("Alterdy Registered")
        Else
            Panel2.Visible = True
            str1 = login.usernametext.Text


            Dim t1 As String
            ds.Tables.Clear()
            sql = "select email from visitor where username='" & str1 & "' "
            cmd = New SqlCommand(sql, con)
            con.Open()
            t1 = cmd.ExecuteScalar

            con.Close()

            emailtext.Text = t1
            emailtext.ReadOnly = True
        End If
       

    End Sub

    Private Sub Panel2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.GotFocus
       


    End Sub

    Private Sub Panel2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseEnter
        '  MsgBox(str1)

       
    End Sub

    Private Sub Panel2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover
      

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub adddfbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adddfbtn.Click
        emailtext.Clear()
        emailtext.ReadOnly = False

    End Sub

    Private Sub clrbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrbtn.Click
        emailtext.Clear()

    End Sub

    Private Sub okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn.Click
        If (emailtext.Text = "") Then
            MsgBox("Please Enter Email:")
        Else
            MsgBox("Regular mails will be dilivered to " & emailtext.Text)
            f1 = 1

            Panel2.Visible = False

        End If



    End Sub

    Private Sub MessagesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessagesToolStripMenuItem.Click
        Panel3.Visible = True

    End Sub

    Private Sub TextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        Dim ckp As New Regex("^[0-9]+$")
        If (ckp.IsMatch(TextBox1.Text) = True) Then
            ErrorProvider3.Dispose()
        Else
            ErrorProvider3.SetError(TextBox1, "Enter Numers Only")

        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If (TextBox1.Text.Length > 10) Then
            ErrorProvider1.SetError(TextBox1, "Cannot Exceed more than 10")
        Else
            ErrorProvider1.Dispose()

        End If
    End Sub

    Private Sub okkbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okkbtn.Click
        If (TextBox1.Text = "") Then
            ErrorProvider1.SetError(TextBox1, "Cant be empty")
        Else
            Dim str2 As String

            str2 = login.usernametext.Text

            Dim str3 As String
            str3 = TextBox1.Text

            Dim t1 As String
            ds.Tables.Clear()
            sql = "update visitor set phoneno='" & str3 & "' where username='" & str2 & "' "

            '  sql = "select email from visitor where username='" & str1 & "' "
            cmd = New SqlCommand(sql, con)
            con.Open()
            t1 = cmd.ExecuteNonQuery
            con.Close()

            MsgBox("Messages will be dilivered to your number" & str3)
            Panel3.Visible = False


        End If
    End Sub

    Private Sub WEbsiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WEbsiteToolStripMenuItem.Click
        Process.Start("https://www.icc-cricket.com/")
    End Sub

    Private Sub FixturesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FixturesToolStripMenuItem.Click
        Process.Start("https://www.icc-cricket.com/mens-schedule/calendar")
    End Sub

    Private Sub RelationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelationsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\relations.docx")

    End Sub

    Private Sub InternationalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        int_players.Show()

    End Sub

    Private Sub CricektToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CricektToolStripMenuItem.Click
        cricket_news.Show()

    End Sub

    Private Sub DisplayToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayToolStripMenuItem1.Click
        disp_p.show()

    End Sub

    Private Sub AddNewToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem2.Click
        int_players.Show()

    End Sub

    Private Sub PlayersToolStripMenuItem_MouseUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayersToolStripMenuItem.MouseUp

        If (flag = 0) Then
            MsgBox("You can add new record of player but you must be admin to do it..otherwise you just can see")
            AddNewToolStripMenuItem2.Enabled = False

        Else
            AddNewToolStripMenuItem2.Enabled = True

        End If
    End Sub

   
    Private Sub InterviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterviewToolStripMenuItem.Click
        videos.Show()

    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeedbackToolStripMenuItem.Click
        feed.Show()

    End Sub

    Private Sub GotoCricbuzzcomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GotoCricbuzzcomToolStripMenuItem.Click
        Process.Start("http://www.cricbuzz.com/")

    End Sub

    Private Sub SeeInAppToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeeInAppToolStripMenuItem.Click
        score.Show()

    End Sub

    
    Private Sub BookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BookToolStripMenuItem.Click
        Ticket_b.show()

    End Sub

    Private Sub DisplayOngoingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayOngoingToolStripMenuItem.Click
        ongo.Show()

    End Sub

    Private Sub IPLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPLToolStripMenuItem.Click
        ipl.Show()

    End Sub

    Private Sub SeriesHomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeriesHomeToolStripMenuItem.Click

    End Sub

    Private Sub SeriesHomeToolStripMenuItem_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SeriesHomeToolStripMenuItem.MouseUp
        If (flag = 0) Then
            MsgBox("You can commence the IPL but you must be admin to do it..otherwise you just can see the ongoing series")
            'AddNewToolStripMenuItem2.Enabled = False
            StartANewToolStripMenuItem.Enabled = False

        Else
            'AddNewToolStripMenuItem2.Enabled = True
            StartANewToolStripMenuItem.Enabled = True

        End If
    End Sub

    Private Sub StartANewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartANewToolStripMenuItem.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
      
        Timer1.Interval = NumericUpDown1.Value
        Label3.Left = Label3.Left - 10
        If Label3.Left < 0 - Label3.Width Then
            Label3.Left = Me.Width
        End If
    End Sub

    Private Sub emailtext_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles emailtext.Leave
        Dim pattern1 As New Regex("^([a-zA-Z]){1,}([a-zA-Z0-9_\-\.]){1,}\@([A-Za-z0-9_\-\.]){1,}\.([a-zA-Z]{2,4})$")
        If (pattern1.IsMatch(emailtext.Text) = False) Then
            ErrorProvider2.SetError(emailtext, "Enter A Valid Email")
            MsgBox("Enter A Valid Email")

            emailtext.Focus()
        Else
            ErrorProvider2.Dispose()
        End If

    End Sub

    Private Sub emailtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtext.TextChanged

    End Sub

    Private Sub StadiumsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StadiumsToolStripMenuItem.Click

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label7.Visible = Not Label7.Visible
        Label7.ForeColor = Color.Blue

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        If (flag = 1) Then
            MsgBox("You are already signed in")
        Else
            adminloggrp.Visible = True
        End If

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        If (flag = 1) Then
            flag = 0

            MsgBox("You have been logout")
            usertext.Clear()
            passtext.Clear()
            lbl1.Visible = False
            register.Close()
            '    login.Show()
        Else
            flag = 0
            MsgBox("You have not logged in")

        End If

    End Sub
End Class