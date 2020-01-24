Imports System.Data.SqlClient

Public Class feed
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As New SqlCommand
    Dim sql As String
    Dim x As Integer
    Dim ds As New DataSet

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        main.Show()
        Me.Hide()

    End Sub

    Private Sub feed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure

        Dim str1 As String
        str1 = login.usernametext.Text

        sql = "select firstname from visitor where username='" & str1 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim t1 = cmd.ExecuteScalar
        con.Close()
        Me.TextBox1.Text = t1

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowColor = True
        If (FontDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color
        End If
    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.ForeColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st2 As String
        st2 = TextBox1.Text

        sql = "update visitor set feedback='" & RichTextBox1.Text & "' where firstname='" & st2 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim x = cmd.ExecuteNonQuery
        con.Close()
        If (x = 1) Then
            MsgBox("Feedback Recorded")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Clear()

    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()

    End Sub
End Class