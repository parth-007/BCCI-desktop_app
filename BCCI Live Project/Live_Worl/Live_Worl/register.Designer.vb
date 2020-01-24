<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.components = New System.ComponentModel.Container()
        Me.newfrm1lbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.emailtext = New System.Windows.Forms.TextBox()
        Me.emailbl = New System.Windows.Forms.Label()
        Me.signupbtn = New System.Windows.Forms.Button()
        Me.cbox1 = New System.Windows.Forms.ComboBox()
        Me.usernametext = New System.Windows.Forms.TextBox()
        Me.passtext2 = New System.Windows.Forms.TextBox()
        Me.passtext1 = New System.Windows.Forms.TextBox()
        Me.lastnametext = New System.Windows.Forms.TextBox()
        Me.firstnametext = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'newfrm1lbl
        '
        Me.newfrm1lbl.AutoSize = True
        Me.newfrm1lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newfrm1lbl.Location = New System.Drawing.Point(39, 43)
        Me.newfrm1lbl.Name = "newfrm1lbl"
        Me.newfrm1lbl.Size = New System.Drawing.Size(207, 32)
        Me.newfrm1lbl.TabIndex = 0
        Me.newfrm1lbl.Text = "Welcome User,"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.dtp1)
        Me.GroupBox1.Controls.Add(Me.emailtext)
        Me.GroupBox1.Controls.Add(Me.emailbl)
        Me.GroupBox1.Controls.Add(Me.signupbtn)
        Me.GroupBox1.Controls.Add(Me.cbox1)
        Me.GroupBox1.Controls.Add(Me.usernametext)
        Me.GroupBox1.Controls.Add(Me.passtext2)
        Me.GroupBox1.Controls.Add(Me.passtext1)
        Me.GroupBox1.Controls.Add(Me.lastnametext)
        Me.GroupBox1.Controls.Add(Me.firstnametext)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(45, 158)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(791, 559)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information:"
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(139, 401)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(430, 34)
        Me.dtp1.TabIndex = 9
        '
        'emailtext
        '
        Me.emailtext.Location = New System.Drawing.Point(191, 168)
        Me.emailtext.Name = "emailtext"
        Me.emailtext.Size = New System.Drawing.Size(368, 34)
        Me.emailtext.TabIndex = 2
        '
        'emailbl
        '
        Me.emailbl.AutoSize = True
        Me.emailbl.Location = New System.Drawing.Point(9, 171)
        Me.emailbl.Name = "emailbl"
        Me.emailbl.Size = New System.Drawing.Size(80, 29)
        Me.emailbl.TabIndex = 2
        Me.emailbl.Text = "Email:"
        '
        'signupbtn
        '
        Me.signupbtn.Location = New System.Drawing.Point(151, 480)
        Me.signupbtn.Name = "signupbtn"
        Me.signupbtn.Size = New System.Drawing.Size(282, 42)
        Me.signupbtn.TabIndex = 5
        Me.signupbtn.Text = "Create Account"
        Me.signupbtn.UseVisualStyleBackColor = True
        '
        'cbox1
        '
        Me.cbox1.FormattingEnabled = True
        Me.cbox1.Location = New System.Drawing.Point(191, 355)
        Me.cbox1.Name = "cbox1"
        Me.cbox1.Size = New System.Drawing.Size(254, 37)
        Me.cbox1.TabIndex = 6
        '
        'usernametext
        '
        Me.usernametext.Location = New System.Drawing.Point(191, 214)
        Me.usernametext.Name = "usernametext"
        Me.usernametext.ReadOnly = True
        Me.usernametext.Size = New System.Drawing.Size(368, 34)
        Me.usernametext.TabIndex = 3
        '
        'passtext2
        '
        Me.passtext2.Location = New System.Drawing.Point(228, 307)
        Me.passtext2.Name = "passtext2"
        Me.passtext2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtext2.Size = New System.Drawing.Size(341, 34)
        Me.passtext2.TabIndex = 5
        '
        'passtext1
        '
        Me.passtext1.Location = New System.Drawing.Point(191, 261)
        Me.passtext1.Name = "passtext1"
        Me.passtext1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtext1.Size = New System.Drawing.Size(368, 34)
        Me.passtext1.TabIndex = 4
        '
        'lastnametext
        '
        Me.lastnametext.Location = New System.Drawing.Point(191, 123)
        Me.lastnametext.Name = "lastnametext"
        Me.lastnametext.Size = New System.Drawing.Size(368, 34)
        Me.lastnametext.TabIndex = 1
        '
        'firstnametext
        '
        Me.firstnametext.Location = New System.Drawing.Point(191, 67)
        Me.firstnametext.Name = "firstnametext"
        Me.firstnametext.Size = New System.Drawing.Size(368, 34)
        Me.firstnametext.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 401)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 29)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Birthdate:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 355)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Country:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 29)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 29)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "UserName:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(313, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(534, 131)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(565, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 29)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = ".."
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 729)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.newfrm1lbl)
        Me.Name = "register"
        Me.Text = "Signup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents newfrm1lbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbox1 As System.Windows.Forms.ComboBox
    Friend WithEvents usernametext As System.Windows.Forms.TextBox
    Friend WithEvents passtext2 As System.Windows.Forms.TextBox
    Friend WithEvents passtext1 As System.Windows.Forms.TextBox
    Friend WithEvents lastnametext As System.Windows.Forms.TextBox
    Friend WithEvents firstnametext As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents signupbtn As System.Windows.Forms.Button
    Friend WithEvents emailtext As System.Windows.Forms.TextBox
    Friend WithEvents emailbl As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
End Class
