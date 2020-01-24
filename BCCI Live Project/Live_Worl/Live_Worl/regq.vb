Public Class regq
    Dim t1 As Integer
    Private Sub regq_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Gold
        GroupBox1.BackColor = Color.SkyBlue


        quescombo.Items.Add("Highest Wickets")
        quescombo.Items.Add("Highest Score")
        quescombo.Items.Add("Highest Balls")
        quescombo.Items.Add("Max Avg")
        quescombo.Items.Add("Not A Bowler")
        quescombo.Items.Add("Highest Runs")
        quescombo.Items.Add("Pitch Measure")

        qtlbl.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False


    End Sub
    Public Sub cll()
        qtlbl.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        quescombo.Text = ""

    End Sub
    Public Sub see()
        qtlbl.Visible = True
        RadioButton1.Visible = True
        RadioButton2.Visible = True
        RadioButton3.Visible = True
        RadioButton4.Visible = True

    End Sub

    Private Sub quescombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quescombo.SelectedIndexChanged
        see()
        If (quescombo.SelectedIndex = 0) Then
            qtlbl.Text = "Who is Highest wicket in tests?"
            RadioButton1.Text = "Murli"
            RadioButton2.Text = "Warne"
            RadioButton3.Text = "Macgrath"
            RadioButton4.Text = "Kumble"
        ElseIf (quescombo.SelectedIndex = 1) Then
            qtlbl.Text = "Whose is Highest score in tests?"
            RadioButton1.Text = "Sachin"
            RadioButton2.Text = "Lara"
            RadioButton3.Text = "Ponting"
            RadioButton4.Text = "Bradman"
        ElseIf (quescombo.SelectedIndex = 2) Then
            qtlbl.Text = "Who has played highest balls in tests?"
            RadioButton1.Text = "Sachin"
            RadioButton2.Text = "Kallis"
            RadioButton3.Text = "Ponting"
            RadioButton4.Text = "Dravid"
        ElseIf (quescombo.SelectedIndex = 3) Then
            qtlbl.Text = "Who has maximum average in odis?"
            RadioButton1.Text = "Willaimson"
            RadioButton2.Text = "Kohli"
            RadioButton3.Text = "Root"
            RadioButton4.Text = "Smith"
        ElseIf (quescombo.SelectedIndex = 4) Then
            qtlbl.Text = "Who is not a bowler?"
            RadioButton1.Text = "Gayle"
            RadioButton2.Text = "Lee"
            RadioButton3.Text = "Steyn"
            RadioButton4.Text = "Stokes"
        ElseIf (quescombo.SelectedIndex = 5) Then
            qtlbl.Text = "Who is Highest Rungetter in tests?"
            RadioButton1.Text = "Sachin"
            RadioButton2.Text = "Ganguly"
            RadioButton3.Text = "Ponting"
            RadioButton4.Text = "Bradman"
        Else
            qtlbl.Text = "What is size of cricket pitch?"
            RadioButton1.Text = "30 yard"
            RadioButton2.Text = "22 yard"
            RadioButton3.Text = "17 yard"
            RadioButton4.Text = "20 yard"
        End If

    End Sub
    Public Function win()
        If (quescombo.SelectedIndex = 0 And RadioButton1.Checked = True) Then Return True
        If (quescombo.SelectedIndex = 1 And RadioButton2.Checked = True) Then Return True
        If (quescombo.SelectedIndex = 2 And RadioButton4.Checked = True) Then Return True
        If (quescombo.SelectedIndex = 3 And RadioButton2.Checked = True) Then Return True
        If (quescombo.SelectedIndex = 4 And RadioButton1.Checked = True) Then Return True
        If (quescombo.SelectedIndex = 5 And RadioButton1.Checked = True) Then Return True
        If (quescombo.SelectedIndex = 6 And RadioButton2.Checked = True) Then Return True

        Return False


    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (win()) Then
            MsgBox("Right Answer")
            Dim yn = MessageBox.Show("Want A new ques?", "new Que", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (yn = DialogResult.OK) Then
                cll()
            Else
                MsgBox("Redirecting you to the main pagE")
                Me.Hide()

                main.Show()
            End If
        Else
            MsgBox("Wrong Answer")
            Dim yn = MessageBox.Show("Want A new ques?", "new Que", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (yn = DialogResult.OK) Then
                cll()
            Else
                MsgBox("Redirecting you to the main pagE")
                Me.Hide()

                main.Show()
            End If
            ' MsgBox("Redirecting you to the main pagE")
            Me.Hide()
            main.Show()

        End If
    End Sub
End Class