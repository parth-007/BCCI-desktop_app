Public Class cricket_news


    Private Sub ll2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ll2.LinkClicked
        Panel2.BackColor = Color.Azure
        '   Panel2.
        Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\2.pdf")
    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        '   Panel2.


    End Sub

    Private Sub ll1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Dim pnl1 As New Panel
        pnl1.Size = New System.Drawing.Size(100, 150)
        pnl1.Location = New System.Drawing.Point(45, 45)
        pnl1.BackColor = Color.Azure
        Controls.Add(pnl1)

    End Sub

    Private Sub cricket_news_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.DeepPink
        Panel2.BackColor = Color.Gold

        GroupBox1.BackColor = Color.Aqua
        GroupBox2.BackColor = Color.Crimson
        GroupBox3.BackColor = Color.NavajoWhite
        GroupBox4.BackColor = Color.Indigo
        GroupBox5.BackColor = Color.Azure


        PictureBox1.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\1.png")
        PictureBox2.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\5.jpg")
        PictureBox3.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\6.jpg")
        PictureBox4.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\3.jpg")
        PictureBox5.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\2.jpg")
        PictureBox6.Load("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\image\4.png")

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\1.pdf")
    End Sub

    Private Sub ll3_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ll3.LinkClicked
        Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\3.pdf")

    End Sub

    Private Sub ll4_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ll4.LinkClicked
        Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\4.pdf")
    End Sub

    Private Sub ll5_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ll5.LinkClicked
        Process.Start("E:\4TH SEM PRACTICAL\VB.NET\BCCI Live Project\Live_Worl\Live_Worl\5.pdf")

    End Sub
End Class