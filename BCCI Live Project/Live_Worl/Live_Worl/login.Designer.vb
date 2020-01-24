<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.passwordtext = New System.Windows.Forms.TextBox()
        Me.usernametext = New System.Windows.Forms.TextBox()
        Me.passwordlbl = New System.Windows.Forms.Label()
        Me.usernmlbl = New System.Windows.Forms.Label()
        Me.signuplbl = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(165, 89)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(125, 51)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "BCCI"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(12, 218)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(470, 32)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Board Of Control For Cricket In India"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.resetbtn)
        Me.GroupBox1.Controls.Add(Me.loginbtn)
        Me.GroupBox1.Controls.Add(Me.passwordtext)
        Me.GroupBox1.Controls.Add(Me.usernametext)
        Me.GroupBox1.Controls.Add(Me.passwordlbl)
        Me.GroupBox1.Controls.Add(Me.usernmlbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(18, 278)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 288)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Login Credentials"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(108, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 47)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Forget Password?"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'resetbtn
        '
        Me.resetbtn.Location = New System.Drawing.Point(305, 140)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(102, 42)
        Me.resetbtn.TabIndex = 5
        Me.resetbtn.Text = "Reset"
        Me.resetbtn.UseVisualStyleBackColor = True
        '
        'loginbtn
        '
        Me.loginbtn.Location = New System.Drawing.Point(82, 140)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(102, 42)
        Me.loginbtn.TabIndex = 4
        Me.loginbtn.Text = "LogIn"
        Me.loginbtn.UseVisualStyleBackColor = True
        '
        'passwordtext
        '
        Me.passwordtext.Location = New System.Drawing.Point(173, 89)
        Me.passwordtext.Name = "passwordtext"
        Me.passwordtext.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtext.Size = New System.Drawing.Size(268, 30)
        Me.passwordtext.TabIndex = 3
        '
        'usernametext
        '
        Me.usernametext.Location = New System.Drawing.Point(173, 45)
        Me.usernametext.Name = "usernametext"
        Me.usernametext.Size = New System.Drawing.Size(268, 30)
        Me.usernametext.TabIndex = 2
        '
        'passwordlbl
        '
        Me.passwordlbl.AutoSize = True
        Me.passwordlbl.Location = New System.Drawing.Point(34, 89)
        Me.passwordlbl.Name = "passwordlbl"
        Me.passwordlbl.Size = New System.Drawing.Size(104, 25)
        Me.passwordlbl.TabIndex = 1
        Me.passwordlbl.Text = "Password:"
        '
        'usernmlbl
        '
        Me.usernmlbl.AutoSize = True
        Me.usernmlbl.Location = New System.Drawing.Point(27, 45)
        Me.usernmlbl.Name = "usernmlbl"
        Me.usernmlbl.Size = New System.Drawing.Size(111, 25)
        Me.usernmlbl.TabIndex = 0
        Me.usernmlbl.Text = "UserName:"
        '
        'signuplbl
        '
        Me.signuplbl.AutoSize = True
        Me.signuplbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signuplbl.Location = New System.Drawing.Point(22, 593)
        Me.signuplbl.Name = "signuplbl"
        Me.signuplbl.Size = New System.Drawing.Size(631, 32)
        Me.signuplbl.TabIndex = 3
        Me.signuplbl.Text = "Don't Have An Account ? .. Click Here To sign Up"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(298, 650)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 29)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Signup"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(425, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 207)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 729)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.signuplbl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "login"
        Me.Text = "Entry_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents passwordlbl As System.Windows.Forms.Label
    Friend WithEvents usernmlbl As System.Windows.Forms.Label
    Friend WithEvents passwordtext As System.Windows.Forms.TextBox
    Friend WithEvents usernametext As System.Windows.Forms.TextBox
    Friend WithEvents resetbtn As System.Windows.Forms.Button
    Friend WithEvents loginbtn As System.Windows.Forms.Button
    Friend WithEvents signuplbl As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
