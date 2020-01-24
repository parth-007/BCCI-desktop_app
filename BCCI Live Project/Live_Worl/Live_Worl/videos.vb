Public Class videos

    Private Sub videos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Lavender

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.URL = "E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\AB de Villiers Sings Hindi Song CricViDeos.in HD.mp4"

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'AxWindowsMediaPlayer1.Ctlcontrols.stop()
        AxWindowsMediaPlayer1.Ctlcontrols.pause()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer2.URL = "D:\Main Project of BCCI\BCCI Live Project\Live_Worl\Live_Worl\AB de Villiers 41 From 11 Balls Vs MI - IPL 2015(videoming).mp4"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        AxWindowsMediaPlayer2.Ctlcontrols.pause()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        AxWindowsMediaPlayer3.URL = "E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\ICC-WT20---India-vs-Australia-Highlights.mp4"
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer3.Ctlcontrols.pause()


    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer4.URL = "E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\CricViDeos.in India Need 15 off 5, Dhoni ON.mp4"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer4.Ctlcontrols.pause()

    End Sub
End Class