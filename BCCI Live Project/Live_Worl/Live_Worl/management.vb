Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class management
    Dim sql As String
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As SqlCommand
    Dim x As Integer
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim cmd1 As SqlCommand
    Private Sub management_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure

        textid.Enabled = False
        midlbl.Enabled = False
        fillroll()
        fillzone()


    End Sub
    Public Sub fillroll()
        rolecombo.Items.Add("CEO")
        rolecombo.Items.Add("Trasurure")
        rolecombo.Items.Add("Secreatary")
        rolecombo.Items.Add("Sanet Member")
        rolecombo.Items.Add("CFO")
        rolecombo.Items.Add("Chairman")
        rolecombo.Items.Add("Joint Chief")
    End Sub
    Public Sub fillzone()
        ds.Tables.Clear()
        sql = "select * from zone"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        zonecombo.DisplayMember = "zonename"
        zonecombo.ValueMember = "zoneid"
        zonecombo.DataSource = ds.Tables(0)
        zonecombo.Text = "Select zone"
    End Sub
    Private Sub insbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insbtn.Click
        ds.Tables.Clear()

        sql = "insert into management (fname,lname,role,zoneid,stateid,phoneno,email,experience) values ('" & fnametext.Text & "','" & lnametext.Text & "','" & rolecombo.SelectedItem.ToString & "'," & Val(zonecombo.SelectedValue) & "," & Val(statecombo.SelectedValue) & ",'" & phonetext.Text & "',' " & emailtext.Text & "'," & exptext.Text & ")"
        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteNonQuery
        con.Close()
        If (x > 0) Then
            MsgBox("Record Inserted")
        End If
        allclear()
        fillgrid()

    End Sub
    Public Sub allclear()
        fnametext.Clear()
        lnametext.Clear()
        emailtext.Clear()
        rolecombo.Text = ""
        statecombo.Text = ""
        zonecombo.Text = ""
        exptext.Clear()
        phonetext.Clear()

    End Sub
    Private Sub zonecombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zonecombo.SelectedIndexChanged
        ds.Tables.Clear()
        Dim zid As Integer
        ' MsgBox(statecombo.SelectedValue)

        If (zonecombo.SelectedValue.ToString <> "") Then
            zid = Convert.ToInt32(zonecombo.SelectedValue)
            fillstates(zid)

            '    ' MsgBox(Val(zonecombo.SelectedValue.ToString))
        End If
    End Sub
    Public Sub fillstates(ByVal zid As Integer)
        ds.Tables.Clear()

        sql = "select * from state where zoneid=" & zid & ""
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()
        statecombo.DisplayMember = "statename"
        statecombo.ValueMember = "stateid"
        statecombo.DataSource = ds.Tables(0)
        statecombo.Text = "Select State"
    End Sub

    Public Sub fillgrid()
        ds.Tables.Clear()
        sql = "select m.mid,m.fname,m.lname,m.role,z.zonename,st.statename,m.phoneno,m.email,m.experience from management m,state st,zone z where m.stateid=st.stateid and m.zoneid=z.zoneid and st.zoneid=z.zoneid"
        '  sql = "select * from management"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        manageview1.DataSource = ds.Tables(0)

    End Sub

    Private Sub dispbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dispbtn.Click
        'ds.Tables.Clear()
        'sql = "select m.mid,m.fname,m.lname,m.role,z.zonename,st.statename,m.phoneno,m.email,m.experience from management m,state st,zone z where z.zoneid=m.zoneid and st.stateid=m.stateid and z.zoneid=st.stateid"
        'adp = New SqlDataAdapter(sql, con)
        'con.Open()
        'adp.Fill(ds)
        'con.Close()

        'manageview1.DataSource = ds.Tables(0)
        fillgrid()


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub sortbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sortbtn.Click
        ds.Tables.Clear()

        sql = "select m.mid,m.fname,m.lname,m.role,z.zonename,st.statename,m.phoneno,m.email,m.experience from management m,state st,zone z where m.stateid=st.stateid and m.zoneid=z.zoneid and st.zoneid=z.zoneid order by m.fname"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        manageview1.DataSource = ds.Tables(0)
    End Sub

    Private Sub updbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updbtn.Click
        ds.Tables.Clear()
        sql = "update management set fname='" & fnametext.Text & "',lname='" & lnametext.Text & "',role='" & rolecombo.SelectedItem.ToString & "',zoneid=" & Val(zonecombo.SelectedValue.ToString) & ",stateid=" & Val(statecombo.SelectedValue.ToString) & ",phoneno='" & phonetext.Text & "',email='" & emailtext.Text & "',experience='" & exptext.Text & "' where mid=" & textid.Text & ""
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim x1 = cmd.ExecuteNonQuery

        con.Close()
        If (x1 = 1) Then
            MsgBox("Record Updated")
        End If
        fillgrid()

    End Sub

    Private Sub manageview1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles manageview1.CellClick
        Dim i As Integer
        i = manageview1.CurrentRow.Index
        textid.Text = manageview1.Rows(i).Cells(0).Value.ToString
        fnametext.Text = manageview1.Rows(i).Cells(1).Value.ToString
        lnametext.Text = manageview1.Rows(i).Cells(2).Value.ToString
        rolecombo.Text = manageview1.Rows(i).Cells(3).Value.ToString
        emailtext.Text = manageview1.Rows(i).Cells(7).Value.ToString
        zonecombo.Text = manageview1.Rows(i).Cells(4).Value.ToString
        statecombo.Text = manageview1.Rows(i).Cells(5).Value.ToString
        phonetext.Text = manageview1.Rows(i).Cells(6).Value.ToString
        exptext.Text = manageview1.Rows(i).Cells(8).Value.ToString

    End Sub

    Private Sub manageview1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles manageview1.CellContentClick

    End Sub

    Private Sub delbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delbtn.Click
        ds.Tables.Clear()
        Dim yn As Integer = MessageBox.Show("Are You Sure You want To delete the REcord", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        If (yn = DialogResult.OK) Then
            sql = "delete from management where mid=" & textid.Text & ""
            cmd = New SqlCommand(sql, con)

            con.Open()
            Dim c1 = cmd.ExecuteNonQuery

            con.Close()
            If (c1 = 1) Then
                MsgBox("Record Deleted")

            End If
        Else
            MsgBox("good")
        End If
        fillgrid()

    End Sub

    Private Sub emailtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtext.TextChanged

    End Sub

    Private Sub emailtext_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles emailtext.Validating
        Dim pattern1 As New Regex("^([a-zA-Z]){1,}([a-zA-Z0-9_\-\.]){1,}\@([A-Za-z0-9_\-\.]){1,}\.([a-zA-Z]{2,4})$")
        If (pattern1.IsMatch(emailtext.Text) = False) Then
            ErrorProvider1.SetError(emailtext, "Enter A Valid Email")
            MsgBox("Enter A Valid Email")

            emailtext.Focus()
        Else
            ErrorProvider1.Dispose()

            't1 = emailtext.Text.Length
            ''  MsgBox(t1)
            'Dim st1 = t1 - 3

            'usernametext.Text = "PA1" & "_" & UCase(firstnametext.Text.Substring(1, 2)) & UCase(lastnametext.Text.Substring(1, 2)) & UCase(emailtext.Text.Substring(st1, 3))
        End If
    End Sub

    Private Sub phonetext_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles phonetext.Leave
        If (phonetext.Text.Length = 10) Then

        Else
            MsgBox("It should be exactly than 10 numbers")
            sender.focus()
            Dim d = 1

        End If
    End Sub

    Private Sub phonetext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles phonetext.TextChanged

    End Sub

    Private Sub phonetext_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles phonetext.Validating
        Dim ch1 As New Regex("^[0-9]+$")
        If (ch1.IsMatch(sender.text) = True) Then
            ErrorProvider2.Dispose()
        Else
            ErrorProvider2.SetError(sender,"Please Enter Numbers")
        End If
    End Sub
End Class