Imports System.IO

Public Class payment

    Private Sub payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Azure
        fille()

    End Sub
    Public Sub fille()
        GroupBox1.BackColor = Color.Lavender

        txtname.Text = Ticket_b.txtname.Text
        txtemail.Text = Ticket_b.txtemail.Text
        txtcost.Text = Ticket_b.txtcost.Text
        txtprice.Text = Ticket_b.txtprice.Text
        txtqty.Text = Ticket_b.txtqty.Text
        TextBox1.Text = Val(Ticket_b.mbox.SelectedValue.ToString)

        TextBox2.Text = Ticket_b.sbox.SelectedItem.ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s1 As Integer = CInt(InputBox("Enter Amount..?", "Caution"))


        Dim s2 = Val(txtcost.Text)
        If (s1 < s2) Then
            MsgBox("Please Enter Valid Amount")

        Else
            Dim temp1 = s1 - s2
            MsgBox("Take Change Back" & temp1)
            MsgBox("Payment Recieved")
            MsgBox("You can Print the slip")
        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PrintDialog1.AllowSomePages = True
        PrintDialog1.AllowCurrentPage = True
        PrintDialog1.AllowSelection = True
        If (PrintDialog1.ShowDialog = DialogResult.OK) Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ticket_b.Show()

        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'mycomputer.filesystem.writealltext()
        Dim isave As New SaveFileDialog
        isave.Filter = "TXT Files(*.txt*)|*.txt|All Files(*.*)|*.*"
        isave.RestoreDirectory = False

        If (isave.ShowDialog = DialogResult.OK) Then
            IO.File.WriteAllText(isave.FileName, RichTextBox1.Text)

        End If
        MsgBox("File saved as .txt File")

    End Sub

    Private Sub ColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
            RichTextBox1.ForeColor = FontDialog1.Color

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '   RichTextBox1.AppendText(" " + vbNewLine)
        '  RichTextBox1.AppendText(vbTab + "Date:" & Date.Now)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab & Label3.Text + ":" + txtname.Text)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab & Label4.Text + ":" + txtemail.Text)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab & Label5.Text + ":" + TextBox1.Text)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab & Label6.Text + ":" + TextBox2.Text)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab & Label7.Text + ":" + txtprice.Text)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab & Label8.Text + ":" + txtqty.Text)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab & Label9.Text + ":" + txtcost.Text)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText("==========================================")
        RichTextBox1.AppendText(vbNewLine + Today & "" & TimeOfDay & vbNewLine)
        RichTextBox1.AppendText("==========================================")

        Button5.Enabled = False

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class