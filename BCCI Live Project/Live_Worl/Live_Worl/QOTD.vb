Public Class QOTD
    Dim t1 As Integer
    Private Sub QOTD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BackColor = Color.DeepPink

        'MsgBox(Date.Now)
        getque()
        quees()

    End Sub
    Public Function weekday(ByVal dt As Date)
        Dim t = dt.DayOfWeek
        Return t

    End Function
    Public Function checkme()
        If (t1 = 1 And RadioButton2.Checked = True) Then Return True
        If (t1 = 2 And RadioButton2.Checked = True) Then Return True
        If (t1 = 6 And RadioButton1.Checked = True) Then Return True
        If (t1 = 3 And RadioButton4.Checked = True) Then Return True
        If (t1 = 4 And RadioButton2.Checked = True) Then Return True
        If (t1 = 5 And RadioButton1.Checked = True) Then Return True
        If (t1 = 0 And RadioButton1.Checked = True) Then Return True
        Return False
    End Function
    Public Sub getque()
        t1 = weekday(Date.Now)
        '   MsgBox(t1)
    End Sub
    Public Sub quees()
        If (t1 = 6) Then
            qtlbl.Text = "Who is Highest Rungetter in tests?"
            RadioButton1.Text = "Sachin"
            RadioButton2.Text = "Ganguly"
            RadioButton3.Text = "Ponting"
            RadioButton4.Text = "Bradman"
        ElseIf (t1 = 0) Then
            qtlbl.Text = "Who is Highest wicket in tests?"
            RadioButton1.Text = "Murli"
            RadioButton2.Text = "Warne"
            RadioButton3.Text = "Macgrath"
            RadioButton4.Text = "Kumble"
        ElseIf (t1 = 2) Then
            qtlbl.Text = "Whose is Highest score in tests?"
            RadioButton1.Text = "Sachin"
            RadioButton2.Text = "Lara"
            RadioButton3.Text = "Ponting"
            RadioButton4.Text = "Bradman"
        ElseIf (t1 = 3) Then
            qtlbl.Text = "Who has played highest balls in tests?"
            RadioButton1.Text = "Sachin"
            RadioButton2.Text = "Kallis"
            RadioButton3.Text = "Ponting"
            RadioButton4.Text = "Dravid"
        ElseIf (t1 = 4) Then
            qtlbl.Text = "Who has maximum average in odis?"
            RadioButton1.Text = "Willaimson"
            RadioButton2.Text = "Kohli"
            RadioButton3.Text = "Root"
            RadioButton4.Text = "Smith"
        ElseIf (t1 = 5) Then
            qtlbl.Text = "Who is not a bowler?"
            RadioButton1.Text = "Gayle"
            RadioButton2.Text = "Lee"
            RadioButton3.Text = "Steyn"
            RadioButton4.Text = "Stokes"
        ElseIf (t1 = 1) Then
            qtlbl.Text = "What is size of cricket pitch?"
            RadioButton1.Text = "30 yard"
            RadioButton2.Text = "22 yard"
            RadioButton3.Text = "17 yard"
            RadioButton4.Text = "20 yard"

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (checkme()) Then
            MsgBox("Right Answer")
        Else
            MsgBox("Sorry! wrong Answer")
        End If
        MsgBox("Completed")
        MsgBox("Redirecting you to the main page")

        Me.Hide()
        main.Show()

    End Sub
End Class