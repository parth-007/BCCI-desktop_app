Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class register
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim sql As String
    Dim ds As New DataSet
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim x As Integer
    'Dim obj1 As New login
    Dim flag=0

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.GhostWhite



        GroupBox1.BackColor = Color.Gold








        fillcountry()
        PictureBox1.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\virat.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub
    Public Sub fillcountry()
        cbox1.Items.Add("India")
        cbox1.Items.Add("Australiya")
        cbox1.Items.Add("USA")
        cbox1.Items.Add("UK")
        cbox1.Items.Add("Switzerland")
        cbox1.Items.Add("Canada")
        cbox1.Items.Add("Germany")
        cbox1.Items.Add("Poland")
        cbox1.Items.Add("Norway")
        cbox1.Items.Add("South Africa")
        cbox1.Items.Add("Papua New Guinea")

    End Sub

    Private Sub signupbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signupbtn.Click
        'ds.Tables.Clear()

        'sql = "insert into viewer (firstname,lastname,password,country,username) values ('" & firstnametext.Text & "','" & lastnametext.Text & "','" & passtext1.Text & "'," & Val(cbox1.SelectedValue) & ",'" & usernametext.Text & "')"
        'cmd = New OleDbCommand(sql, con)
        'con.Open()
        'cmd.ExecuteNonQuery()
        'con.Close()

        ds.Tables.Clear()
        sql = "insert into visitor (firstname,lastname,email,username,password,country,birthdate) values ('" & firstnametext.Text & "','" & lastnametext.Text & "','" & emailtext.Text & "','" & usernametext.Text & "','" & passtext2.Text & "','" & cbox1.SelectedItem.ToString & "','" & dtp1.Value & "')"
        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteNonQuery()
        con.Close()
        If (x > 0) Then
            'MsgBox("Successful")
            Dim yn = MessageBox.Show("Account Created Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.None)
            MsgBox("Redirecting You to the Login Page...")

            Me.Hide()

        End If
    End Sub

    Private Sub passtext1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles passtext1.Leave
        If (passtext1.Text.Length < 8) Then
            MsgBox("Please choose more than 8 or 8 characters")
            sender.focus()

        Else
            Dim p = 1

        End If

    End Sub

    'Private Sub firstnametext_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles firstnametext.Leave


    'End Sub


    Private Sub firstnametext_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstnametext.Leave
        If (firstnametext.Text = "") Then
            ErrorProvider2.SetError(firstnametext, "Can't Leave it Empty")
        Else
            ErrorProvider2.Dispose()
            newfrm1lbl.Text = "Welcome" & " " & firstnametext.Text & ","
        End If
    End Sub

    Private Sub passtext2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles passtext2.Leave
        If (passtext1.Text <> passtext2.Text) Then
            ErrorProvider1.SetError(passtext2, "Passwords Do not Match")
        Else
            ErrorProvider1.Dispose()

        End If
    End Sub

   
    Private Sub passtext2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passtext2.TextChanged

    End Sub

    'Private Sub emailtext_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles emailtext.Leave
    '    Dim t1 As Integer
    '    t1 = emailtext.Text.Length
    '    MsgBox(t1)
    '    Dim st1 = t1 - 3

    '    usernametext.Text = "PA1" & "_" & UCase(firstnametext.Text.Substring(1, 2)) & UCase(lastnametext.Text.Substring(1, 2)) & UCase(emailtext.Text.Substring(st1, 3))
    'End Sub

    Private Sub emailtext_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtext.Leave
        If (sender.text = "") Then
            ErrorProvider2.SetError(sender, "Can't Leave it empty")
        Else
            ErrorProvider2.Dispose()
            Dim pattern1 As New Regex("^([a-zA-Z]){1,}([a-zA-Z0-9_\-\.]){1,}\@([A-Za-z0-9_\-\.]){1,}\.([a-zA-Z]{2,4})$")
            If (pattern1.IsMatch(emailtext.Text) = False) Then
                ErrorProvider3.SetError(emailtext, "Enter A Valid Email")
                MsgBox("Enter A Valid Email")

                emailtext.Focus()
            Else
                ErrorProvider3.Dispose()
                Dim t1 As Integer
                t1 = emailtext.Text.Length
                '  MsgBox(t1)
                Dim st1 = t1 - 3

                usernametext.Text = "PA1" & "_" & UCase(firstnametext.Text.Substring(1, 2)) & UCase(lastnametext.Text.Substring(1, 2)) & UCase(emailtext.Text.Substring(st1, 3))
            End If

           
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lastnametext_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lastnametext.Leave

        If (lastnametext.Text = "") Then
            ErrorProvider2.SetError(lastnametext, "Can't Leave it Empty")
        Else
            ErrorProvider2.Dispose()

        End If
    End Sub

    Private Sub usernametext_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles usernametext.Leave
        Dim str1 As String
        str1 = firstnametext.Text

        sql = "select username from visitor where firstname='" & str1 & "' "
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim pl = cmd.ExecuteScalar

        con.Close()

        If (pl = usernametext.Text) Then
            MsgBox("It's already taken..take a new 1")
            usernametext.Focus()

        Else
            Label8.Text = "Available"

        End If
    End Sub

    Private Sub usernametext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usernametext.TextChanged

    End Sub

    Private Sub passtext1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passtext1.TextChanged
      
    End Sub

    Private Sub emailtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtext.TextChanged

    End Sub
End Class