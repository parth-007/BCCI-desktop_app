Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class stadium
    Dim sql As String
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As SqlCommand
    Dim x As Integer
    Dim adp As SqlDataAdapter
    Dim ds As New DataSet
    Dim sql1 As String
    Dim cmd1 As SqlCommand
    Public Sub fillstate()
        ds.Tables.Clear()
        sql = "select * from state"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()

        statecombo.DisplayMember = "statename"
        statecombo.ValueMember = "stateid"

        statecombo.DataSource = ds.Tables(0)

        statecombo.Text = "Select State"
    End Sub
    Private Sub insbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insbtn.Click
        Dim fac As String
        If RadioButton1.Checked = True Then
            fac = RadioButton1.Text
        Else
            fac = RadioButton2.Text

        End If
        ds.Tables.Clear()

        sql = "insert into stadium (name,dateaug,stateid,maxlen,press_facility,owner) values ('" & nametext.Text & "','" & dtp1.Value & " ', " & Val(statecombo.SelectedValue) & " ," & maxtext.Text & ",'" & fac & "','" & ownertext.Text & "')"
        cmd = New SqlCommand(sql, con)
        con.Open()
        x = cmd.ExecuteNonQuery

        con.Close()
        If (x > 0) Then
            MsgBox("Record Inserted")
        End If
        ss()
    End Sub
    Public Sub ss()
        ds.Tables.Clear()
        sql = "select s.sno,s.name,s.dateaug,st.statename,s.maxlen,s.press_facility,s.owner from stadium s,state st where s.stateid=st.stateid"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()
        stadiumview1.DataSource = ds.Tables(0)
    End Sub
    Private Sub dispbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dispbtn.Click
        ds.Tables.Clear()
        sql = "select s.sno,s.name,s.dateaug,st.statename,s.maxlen,s.press_facility,s.owner from stadium s,state st where s.stateid=st.stateid"
        adp = New SqlDataAdapter(sql, con)
        con.Open()
        adp.Fill(ds)
        con.Close()
        stadiumview1.DataSource = ds.Tables(0)
    End Sub

    Private Sub d_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.BlanchedAlmond
        stadiumview1.BackgroundColor = Color.Cyan
        PictureBox1.Load("D:\Main Project of BCCI\BCCI Live Project\Live_Worl\Live_Worl\res.jpg")
        fillstate()
        Label1.Enabled = False
        stno.Enabled = False

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub maxtext_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles maxtext.TextChanged

    End Sub

    Private Sub maxtext_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles maxtext.Validating
        Dim ckp1 As New Regex("^[0-9]+$")
        If (ckp1.IsMatch(sender.text) = False) Then
            ErrorProvider1.SetError(sender, "Enter Only Numbers")
        Else
            ErrorProvider1.Dispose()

        End If
    End Sub
End Class