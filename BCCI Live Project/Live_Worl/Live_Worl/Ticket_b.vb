Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Ticket_b
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As New SqlCommand
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql As String
    Dim sql1 As String
    Dim cmd1 As New SqlCommand
    Dim flag As Integer = 0

    Dim x As Integer

    Private Sub Ticket_b_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure
        Panel1.BackColor = Color.LightSkyBlue


        fillmatch()
        Dim temp1 = login.usernametext.Text

        sbox.Items.Add("East Stand")
        sbox.Items.Add("North Stand")
        sbox.Items.Add("South Stand")
        sbox.Items.Add("West Stand")
        sbox.Items.Add("Corporate Stand")
        sbox.Items.Add("Media Box")

        ds.Tables.Clear()
        Dim t1, t2 As String
        sql = "select firstname from visitor where username='" & temp1 & "'"
        sql1 = "select email from visitor where username='" & temp1 & "'"
        cmd = New SqlCommand(sql, con)
        cmd1 = New SqlCommand(sql1, con)
        con.Open()
        t1 = cmd.ExecuteScalar
        t2 = cmd1.ExecuteScalar

        con.Close()
        txtemail.Text = t2
        txtname.Text = t1
        fill1()

    End Sub
    Public Sub fillmatch()
        ds.Tables.Clear()
        sql = "select * from bti"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        mbox.DisplayMember = "name"
        mbox.ValueMember = "mid"
        mbox.DataSource = ds.Tables(0)
        mbox.Text = "Select Match"

    End Sub

    Private Sub sbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbox.SelectedIndexChanged
        If (sbox.SelectedIndex = 0) Then
            txtprice.Text = 500
        ElseIf (sbox.SelectedIndex = 1) Then
            txtprice.Text = 550
        ElseIf (sbox.SelectedIndex = 2) Then
            txtprice.Text = 350
        ElseIf (sbox.SelectedIndex = 3) Then
            txtprice.Text = 400
        ElseIf (sbox.SelectedIndex = 4) Then
            txtprice.Text = 5000
        ElseIf (sbox.SelectedIndex = 5) Then
            txtprice.Text = 10000

        End If
    End Sub

    Private Sub txtqty_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtqty.Leave
        txtcost.Text = Val(txtqty.Text) * Val(txtprice.Text)

    End Sub

    Private Sub txtqty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtqty.TextChanged
        If (Val(txtqty.Text) > 10) Then
            MsgBox("Can't Book more than 10 tickets")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtname.ReadOnly = False
        txtemail.ReadOnly = False
        txtname.Clear()
        txtemail.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ds.Tables.Clear()
        Dim no1 As Integer
        no1 = Val(txtqty.Text)

        sql = "insert into book(name,email,match,stand,price,quantity,cost) values ('" & txtname.Text & "','" & txtemail.Text & "'," & Val(mbox.SelectedValue.ToString) & ",'" & sbox.SelectedItem.ToString & "'," & txtprice.Text & "," & txtqty.Text & "," & txtcost.Text & ")"
        Dim sql1 As String
        sql1 = "update bti set total=total-" & no1 & " where mid=" & mbox.SelectedValue.ToString & ""

        cmd = New SqlCommand(sql, con)
        cmd1 = New SqlCommand(sql1, con)

        con.Open()
        x = cmd.ExecuteNonQuery
        cmd1.ExecuteScalar()
        Dim y1 = cmd1.ExecuteNonQuery

        con.Close()

        If (x = 1) Then
            MsgBox("Ticket Booked")

        End If
        If (y1 = 1) Then
            MsgBox("Tickets Recorded")

        End If
        Button2.Enabled = False

        flag = 1

        fill1()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        fill1()


    End Sub
    Public Sub fill1()
        ds.Tables.Clear()
        sql = "select b1.userid,b1.name,b1.email,b2.name As Match,b1.stand,b1.price,b1.quantity,b1.cost from book b1,bti b2 where b1.match=b2.mid"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()
        DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (flag = 0) Then
            MsgBox("First Book Tickets then Go to Checkout")
        Else
            payment.Show()

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        main.Show()

        Me.Hide()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txtqty.Clear()
        txtprice.Clear()
        txtemail.Clear()
        txtcost.Clear()
        txtname.Clear()
        txtemail.Clear()
        mbox.Text = "Select"
        sbox.Text = "Select"

    End Sub

    Private Sub txtqty_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtqty.Validating
        Dim p1 As New Regex("^[0-9]+$")
        If (p1.IsMatch(sender.text) = True) Then
            ErrorProvider1.Dispose()
        Else
            MsgBox("Wrong Input")

            ErrorProvider1.SetError(sender, "Please Enter less than or equal to 10")
            sender.focus()

        End If
    End Sub
End Class