Imports System.Data.SqlClient

Public Class score
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim ds As New DataSet
    Dim sql As String
    Dim adp As SqlDataAdapter
    Dim cmd As New SqlCommand
    Dim dt As New DataTable

    Private Sub score_ContextMenuChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ContextMenuChanged

    End Sub

   

    Private Sub score_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure
        GroupBox1.BackColor = Color.Cyan
        infobox.BackColor = Color.Gainsboro

        GroupBox2.BackColor = Color.LightSalmon
        GroupBox3.BackColor = Color.LightSalmon

        Timer1.Start()
        Timer4.Start()
        Timer5.Start()
        Timer6.Start()
        Timer7.Start()

        Timer3.Start()
        Timer8.Start()

        Timer2.Start()

        TextBox1.Text = Date.Now.Day.ToString + "/" + Date.Now.Month.ToString + "/" & Date.Now.Year.ToString
        TextBox2.Text = "1:30 PM"
        findstadium()
        fillme()

        TextBox9.Text = "Warner" + " , " + "Finch" + " , " + "Smith(C)" + " , " + "Bailey" + ", " + " , " + "Maxwell" + " , " + "Wade(WK)" + " , " + "M.Marsh" + " , " + "Faulkner" + " , " + "Starc" + " , " + "Hazzlewood" + " , " + "Zampa"

        pl()
        Label18.Text = Val(TextBox11.Text) + Val(TextBox16.Text) + Val(Label22.Text) + 7


    End Sub
    Public Sub pl()
        sql = "select fname from player"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(dt)

        con.Close()
        For i = 0 To 10
            TextBox10.Text += dt.Rows(i)("fname").ToString + " , "

        Next


    End Sub
    Public Sub fillme()
        TextBox4.Text = "Ricchi Richardson"
        TextBox5.Text = "Richard KettleBorrough,Kumar Dharmsena"
        TextBox6.Text = "Nigel Long"
        TextBox7.Text = "Ind Won the Toss and Elected To Field"
        TextBox8.Text = "India vs Australiya PayTM trophy - Payback time"

    End Sub
    Public Sub findstadium()
        ds.Tables.Clear()
        sql = "select name from stadium where sno=" & 1001 & ""
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim x As String = cmd.ExecuteScalar

        con.Close()
        TextBox3.Text = x

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label22.Text = Val(Label22.Text) + 1

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox2.GotFocus
      


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label20.Text = (Val(Label20.Text)) + 1
        If (Val(Label20.Text) = 2) Then
            Label13.Text = "Bailey"
            TextBox11.Text = "0*"
            TextBox12.Text = "0"
            TextBox13.Text = "0"
            TextBox14.Text = "0"
            Label16.Text = "Smith B Shami " & Val(TextBox11.Text) + " " + Val(TextBox12.Text) + " " + Val(TextBox13.Text) + " " + Val(TextBox14.Text)
            TextBox21.Text = "Shami"
            TextBox24.Text = "1"


        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox3.GotFocus
      


    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        TextBox11.Text = Val(TextBox11.Text) + 1
        TextBox16.Text = Val(TextBox16.Text) + 1


    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        TextBox18.Text = Val(TextBox18.Text) + 1


    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        TextBox13.Text = Val(TextBox13.Text) + 1

    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        TextBox12.Text = Val(TextBox12.Text) + 1

    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        TextBox17.Text = Val(TextBox17.Text) + 1
    End Sub

    Private Sub Panel5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.GotFocus
        TextBox43.Text = Val(TextBox27.Text) + Val(TextBox37.Text) + Val(TextBox32.Text) + Val(TextBox42.Text)

    End Sub

    Private Sub Panel5_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.MouseHover
        TextBox43.Text = Val(TextBox27.Text) + Val(TextBox37.Text) + Val(TextBox32.Text) + Val(TextBox42.Text)
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        Dim flag As Integer = 0
        Dim t As Integer
        If (flag = 1) Then
            Dim q As Integer
            q = Val(TextBox27.Text)
            TextBox27.Text = Val(TextBox27.Text) + 1
            TextBox26.Text = "1"
            TextBox25.Text = Val(TextBox25.Text) + 5
            TextBox24.Text = Val(TextBox24.Text) + 0
            flag = 0

        Else
            t = Val(TextBox42.Text)

            TextBox42.Text = Val(TextBox42.Text) + 1
            TextBox43.Text = "0"
            TextBox40.Text = Val(TextBox40.Text) + 6
            TextBox39.Text = Val(TextBox39.Text) + 0

            flag = 1
        End If
        

    End Sub

    Private Sub GroupBox3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox3.MouseHover
        Label29.Text = Label18.Text

        Label27.Text = Label20.Text

        TextBox28.Text = Val(TextBox30.Text) / Val(TextBox32.Text)

        TextBox23.Text = Val(TextBox25.Text) / Val(TextBox27.Text)
        TextBox33.Text = Val(TextBox35.Text) / Val(TextBox37.Text)


        Label24.Text = Label22.Text
    End Sub

    Private Sub GroupBox2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles GroupBox2.MouseHover
        TextBox15.Text = Math.Round((Val(TextBox11.Text) * 100) / Val(TextBox12.Text), 2)


        TextBox20.Text = Math.Round((Val(TextBox16.Text) * 100) / Val(TextBox17.Text), 2)

    End Sub
End Class