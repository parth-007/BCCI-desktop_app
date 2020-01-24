<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manage_see
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.exptext = New System.Windows.Forms.TextBox()
        Me.phonetext = New System.Windows.Forms.TextBox()
        Me.statecombo = New System.Windows.Forms.ComboBox()
        Me.zonecombo = New System.Windows.Forms.ComboBox()
        Me.emailtext = New System.Windows.Forms.TextBox()
        Me.rolecombo = New System.Windows.Forms.ComboBox()
        Me.lnametext = New System.Windows.Forms.TextBox()
        Me.fnametext = New System.Windows.Forms.TextBox()
        Me.textid = New System.Windows.Forms.TextBox()
        Me.explbl = New System.Windows.Forms.Label()
        Me.emilbl = New System.Windows.Forms.Label()
        Me.phonelbl = New System.Windows.Forms.Label()
        Me.statelbl = New System.Windows.Forms.Label()
        Me.zonelbl = New System.Windows.Forms.Label()
        Me.rolelbl = New System.Windows.Forms.Label()
        Me.lnamelbl = New System.Windows.Forms.Label()
        Me.fnamelbl = New System.Windows.Forms.Label()
        Me.midlbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(516, 23)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(248, 32)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Management Data"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1287, 336)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.exptext)
        Me.GroupBox1.Controls.Add(Me.phonetext)
        Me.GroupBox1.Controls.Add(Me.statecombo)
        Me.GroupBox1.Controls.Add(Me.zonecombo)
        Me.GroupBox1.Controls.Add(Me.emailtext)
        Me.GroupBox1.Controls.Add(Me.rolecombo)
        Me.GroupBox1.Controls.Add(Me.lnametext)
        Me.GroupBox1.Controls.Add(Me.fnametext)
        Me.GroupBox1.Controls.Add(Me.textid)
        Me.GroupBox1.Controls.Add(Me.explbl)
        Me.GroupBox1.Controls.Add(Me.emilbl)
        Me.GroupBox1.Controls.Add(Me.phonelbl)
        Me.GroupBox1.Controls.Add(Me.statelbl)
        Me.GroupBox1.Controls.Add(Me.zonelbl)
        Me.GroupBox1.Controls.Add(Me.rolelbl)
        Me.GroupBox1.Controls.Add(Me.lnamelbl)
        Me.GroupBox1.Controls.Add(Me.fnamelbl)
        Me.GroupBox1.Controls.Add(Me.midlbl)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 438)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(991, 307)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'exptext
        '
        Me.exptext.Location = New System.Drawing.Point(459, 157)
        Me.exptext.Name = "exptext"
        Me.exptext.ReadOnly = True
        Me.exptext.Size = New System.Drawing.Size(100, 22)
        Me.exptext.TabIndex = 36
        '
        'phonetext
        '
        Me.phonetext.Location = New System.Drawing.Point(459, 119)
        Me.phonetext.Name = "phonetext"
        Me.phonetext.ReadOnly = True
        Me.phonetext.Size = New System.Drawing.Size(198, 22)
        Me.phonetext.TabIndex = 35
        '
        'statecombo
        '
        Me.statecombo.FormattingEnabled = True
        Me.statecombo.Location = New System.Drawing.Point(459, 80)
        Me.statecombo.Name = "statecombo"
        Me.statecombo.Size = New System.Drawing.Size(181, 24)
        Me.statecombo.TabIndex = 34
        '
        'zonecombo
        '
        Me.zonecombo.FormattingEnabled = True
        Me.zonecombo.Location = New System.Drawing.Point(459, 38)
        Me.zonecombo.Name = "zonecombo"
        Me.zonecombo.Size = New System.Drawing.Size(181, 24)
        Me.zonecombo.TabIndex = 33
        '
        'emailtext
        '
        Me.emailtext.Location = New System.Drawing.Point(108, 197)
        Me.emailtext.Name = "emailtext"
        Me.emailtext.ReadOnly = True
        Me.emailtext.Size = New System.Drawing.Size(303, 22)
        Me.emailtext.TabIndex = 32
        '
        'rolecombo
        '
        Me.rolecombo.FormattingEnabled = True
        Me.rolecombo.Location = New System.Drawing.Point(108, 162)
        Me.rolecombo.Name = "rolecombo"
        Me.rolecombo.Size = New System.Drawing.Size(181, 24)
        Me.rolecombo.TabIndex = 31
        '
        'lnametext
        '
        Me.lnametext.Location = New System.Drawing.Point(108, 119)
        Me.lnametext.Name = "lnametext"
        Me.lnametext.ReadOnly = True
        Me.lnametext.Size = New System.Drawing.Size(198, 22)
        Me.lnametext.TabIndex = 30
        '
        'fnametext
        '
        Me.fnametext.Location = New System.Drawing.Point(105, 83)
        Me.fnametext.Name = "fnametext"
        Me.fnametext.ReadOnly = True
        Me.fnametext.Size = New System.Drawing.Size(201, 22)
        Me.fnametext.TabIndex = 29
        '
        'textid
        '
        Me.textid.Location = New System.Drawing.Point(105, 41)
        Me.textid.Name = "textid"
        Me.textid.ReadOnly = True
        Me.textid.Size = New System.Drawing.Size(100, 22)
        Me.textid.TabIndex = 28
        '
        'explbl
        '
        Me.explbl.AutoSize = True
        Me.explbl.Location = New System.Drawing.Point(374, 162)
        Me.explbl.Name = "explbl"
        Me.explbl.Size = New System.Drawing.Size(82, 17)
        Me.explbl.TabIndex = 27
        Me.explbl.Text = "Experience:"
        '
        'emilbl
        '
        Me.emilbl.AutoSize = True
        Me.emilbl.Location = New System.Drawing.Point(28, 197)
        Me.emilbl.Name = "emilbl"
        Me.emilbl.Size = New System.Drawing.Size(51, 17)
        Me.emilbl.TabIndex = 26
        Me.emilbl.Text = "E-Mail:"
        '
        'phonelbl
        '
        Me.phonelbl.AutoSize = True
        Me.phonelbl.Location = New System.Drawing.Point(387, 124)
        Me.phonelbl.Name = "phonelbl"
        Me.phonelbl.Size = New System.Drawing.Size(69, 17)
        Me.phonelbl.TabIndex = 25
        Me.phonelbl.Text = "Phoneno:"
        '
        'statelbl
        '
        Me.statelbl.AutoSize = True
        Me.statelbl.Location = New System.Drawing.Point(387, 83)
        Me.statelbl.Name = "statelbl"
        Me.statelbl.Size = New System.Drawing.Size(45, 17)
        Me.statelbl.TabIndex = 24
        Me.statelbl.Text = "State:"
        '
        'zonelbl
        '
        Me.zonelbl.AutoSize = True
        Me.zonelbl.Location = New System.Drawing.Point(387, 41)
        Me.zonelbl.Name = "zonelbl"
        Me.zonelbl.Size = New System.Drawing.Size(45, 17)
        Me.zonelbl.TabIndex = 23
        Me.zonelbl.Text = "Zone:"
        '
        'rolelbl
        '
        Me.rolelbl.AutoSize = True
        Me.rolelbl.Location = New System.Drawing.Point(28, 162)
        Me.rolelbl.Name = "rolelbl"
        Me.rolelbl.Size = New System.Drawing.Size(41, 17)
        Me.rolelbl.TabIndex = 22
        Me.rolelbl.Text = "Role:"
        '
        'lnamelbl
        '
        Me.lnamelbl.AutoSize = True
        Me.lnamelbl.Location = New System.Drawing.Point(28, 124)
        Me.lnamelbl.Name = "lnamelbl"
        Me.lnamelbl.Size = New System.Drawing.Size(74, 17)
        Me.lnamelbl.TabIndex = 21
        Me.lnamelbl.Text = "Lastname:"
        '
        'fnamelbl
        '
        Me.fnamelbl.AutoSize = True
        Me.fnamelbl.Location = New System.Drawing.Point(28, 83)
        Me.fnamelbl.Name = "fnamelbl"
        Me.fnamelbl.Size = New System.Drawing.Size(74, 17)
        Me.fnamelbl.TabIndex = 20
        Me.fnamelbl.Text = "Firstname:"
        '
        'midlbl
        '
        Me.midlbl.AutoSize = True
        Me.midlbl.Location = New System.Drawing.Point(28, 41)
        Me.midlbl.Name = "midlbl"
        Me.midlbl.Size = New System.Drawing.Size(25, 17)
        Me.midlbl.TabIndex = 19
        Me.midlbl.Text = "ID:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(702, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Sort"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(811, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(106, 206)
        Me.Panel1.TabIndex = 3
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(59, 36)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(23, 70)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 36)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(23, 120)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(55, 29)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "<<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(23, 163)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(57, 40)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = ">>"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'manage_see
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 738)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "manage_see"
        Me.Text = "manage_see"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents exptext As System.Windows.Forms.TextBox
    Friend WithEvents phonetext As System.Windows.Forms.TextBox
    Friend WithEvents statecombo As System.Windows.Forms.ComboBox
    Friend WithEvents zonecombo As System.Windows.Forms.ComboBox
    Friend WithEvents emailtext As System.Windows.Forms.TextBox
    Friend WithEvents rolecombo As System.Windows.Forms.ComboBox
    Friend WithEvents lnametext As System.Windows.Forms.TextBox
    Friend WithEvents fnametext As System.Windows.Forms.TextBox
    Friend WithEvents textid As System.Windows.Forms.TextBox
    Friend WithEvents explbl As System.Windows.Forms.Label
    Friend WithEvents emilbl As System.Windows.Forms.Label
    Friend WithEvents phonelbl As System.Windows.Forms.Label
    Friend WithEvents statelbl As System.Windows.Forms.Label
    Friend WithEvents zonelbl As System.Windows.Forms.Label
    Friend WithEvents rolelbl As System.Windows.Forms.Label
    Friend WithEvents lnamelbl As System.Windows.Forms.Label
    Friend WithEvents fnamelbl As System.Windows.Forms.Label
    Friend WithEvents midlbl As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
