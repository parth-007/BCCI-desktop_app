Imports System.Data.SqlClient

Public Class pass
    Dim sql As String
    Dim con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ADMIN\Documents\database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
    Dim cmd As New SqlCommand
    Dim ds As New DataSet
    Dim x, r As Integer

    Private Sub pass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gold
        GroupBox1.BackColor = Color.Azure

        TextBox1.Text = login.usernametext.Text
        TextBox2.Clear()

        Label6.Visible = False
        passtext1.Visible = False
        Button2.Visible = False





    End Sub

    

    Public Sub ee()
        Me.Hide()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim h1 As String
        h1 = TextBox1.Text
        Dim h2 = TextBox2.Text
        ds.Tables.Clear()
        sql = "select email from visitor where username='" & h1 & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim l1 = cmd.ExecuteScalar
        con.Close()
        If (l1 = h2) Then
            MsgBox("Yes ,Found")
            passtext1.Visible = True
            Label6.Visible = True
            Button2.Visible = True

            Button1.Enabled = False

        Else
            Dim yn As Integer

            yn = MessageBox.Show("Sorry, Wrong Email" & vbNewLine & "probably you are trying to access the account which is not yours.." & vbNewLine & "Our Advice is create a new 1", "Caution", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If (yn = DialogResult.OK) Then
                ee()


                register.Show()
                '
            ElseIf (yn = vbCancel) Then

                MsgBox("Please Try Again")
                TextBox2.Focus()

            End If


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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sql = "update visitor set password='" & passtext1.Text & "' where username='" & TextBox1.Text & "'"
        cmd = New SqlCommand(sql, con)
        con.Open()
        Dim l = cmd.ExecuteNonQuery

        con.Close()
        If (l > 0) Then
            MsgBox("Password Updated Successfully")
            MsgBox("Now you can return to the login page")
            Me.Hide()

        End If
    End Sub
End Class