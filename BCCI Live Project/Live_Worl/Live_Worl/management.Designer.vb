<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class management
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dispbtn = New System.Windows.Forms.Button()
        Me.sortbtn = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.updbtn = New System.Windows.Forms.Button()
        Me.insbtn = New System.Windows.Forms.Button()
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
        Me.manageview1 = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.manageview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dispbtn)
        Me.Panel1.Controls.Add(Me.sortbtn)
        Me.Panel1.Controls.Add(Me.delbtn)
        Me.Panel1.Controls.Add(Me.updbtn)
        Me.Panel1.Controls.Add(Me.insbtn)
        Me.Panel1.Controls.Add(Me.exptext)
        Me.Panel1.Controls.Add(Me.phonetext)
        Me.Panel1.Controls.Add(Me.statecombo)
        Me.Panel1.Controls.Add(Me.zonecombo)
        Me.Panel1.Controls.Add(Me.emailtext)
        Me.Panel1.Controls.Add(Me.rolecombo)
        Me.Panel1.Controls.Add(Me.lnametext)
        Me.Panel1.Controls.Add(Me.fnametext)
        Me.Panel1.Controls.Add(Me.textid)
        Me.Panel1.Controls.Add(Me.explbl)
        Me.Panel1.Controls.Add(Me.emilbl)
        Me.Panel1.Controls.Add(Me.phonelbl)
        Me.Panel1.Controls.Add(Me.statelbl)
        Me.Panel1.Controls.Add(Me.zonelbl)
        Me.Panel1.Controls.Add(Me.rolelbl)
        Me.Panel1.Controls.Add(Me.lnamelbl)
        Me.Panel1.Controls.Add(Me.fnamelbl)
        Me.Panel1.Controls.Add(Me.midlbl)
        Me.Panel1.Controls.Add(Me.manageview1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1115, 702)
        Me.Panel1.TabIndex = 0
        '
        'dispbtn
        '
        Me.dispbtn.Location = New System.Drawing.Point(692, 179)
        Me.dispbtn.Name = "dispbtn"
        Me.dispbtn.Size = New System.Drawing.Size(75, 25)
        Me.dispbtn.TabIndex = 23
        Me.dispbtn.Text = "Display"
        Me.dispbtn.UseVisualStyleBackColor = True
        '
        'sortbtn
        '
        Me.sortbtn.Location = New System.Drawing.Point(692, 142)
        Me.sortbtn.Name = "sortbtn"
        Me.sortbtn.Size = New System.Drawing.Size(75, 29)
        Me.sortbtn.TabIndex = 22
        Me.sortbtn.Text = "Sort"
        Me.sortbtn.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Location = New System.Drawing.Point(692, 106)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(75, 33)
        Me.delbtn.TabIndex = 21
        Me.delbtn.Text = "Delete"
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'updbtn
        '
        Me.updbtn.Location = New System.Drawing.Point(692, 71)
        Me.updbtn.Name = "updbtn"
        Me.updbtn.Size = New System.Drawing.Size(75, 29)
        Me.updbtn.TabIndex = 20
        Me.updbtn.Text = "Update"
        Me.updbtn.UseVisualStyleBackColor = True
        '
        'insbtn
        '
        Me.insbtn.Location = New System.Drawing.Point(692, 31)
        Me.insbtn.Name = "insbtn"
        Me.insbtn.Size = New System.Drawing.Size(75, 34)
        Me.insbtn.TabIndex = 19
        Me.insbtn.Text = "Insert"
        Me.insbtn.UseVisualStyleBackColor = True
        '
        'exptext
        '
        Me.exptext.Location = New System.Drawing.Point(461, 142)
        Me.exptext.Name = "exptext"
        Me.exptext.Size = New System.Drawing.Size(100, 22)
        Me.exptext.TabIndex = 18
        '
        'phonetext
        '
        Me.phonetext.Location = New System.Drawing.Point(461, 104)
        Me.phonetext.Name = "phonetext"
        Me.phonetext.Size = New System.Drawing.Size(198, 22)
        Me.phonetext.TabIndex = 17
        '
        'statecombo
        '
        Me.statecombo.FormattingEnabled = True
        Me.statecombo.Location = New System.Drawing.Point(461, 65)
        Me.statecombo.Name = "statecombo"
        Me.statecombo.Size = New System.Drawing.Size(181, 24)
        Me.statecombo.TabIndex = 16
        '
        'zonecombo
        '
        Me.zonecombo.FormattingEnabled = True
        Me.zonecombo.Location = New System.Drawing.Point(461, 23)
        Me.zonecombo.Name = "zonecombo"
        Me.zonecombo.Size = New System.Drawing.Size(181, 24)
        Me.zonecombo.TabIndex = 15
        '
        'emailtext
        '
        Me.emailtext.Location = New System.Drawing.Point(110, 182)
        Me.emailtext.Name = "emailtext"
        Me.emailtext.Size = New System.Drawing.Size(302, 22)
        Me.emailtext.TabIndex = 14
        '
        'rolecombo
        '
        Me.rolecombo.FormattingEnabled = True
        Me.rolecombo.Location = New System.Drawing.Point(110, 147)
        Me.rolecombo.Name = "rolecombo"
        Me.rolecombo.Size = New System.Drawing.Size(181, 24)
        Me.rolecombo.TabIndex = 13
        '
        'lnametext
        '
        Me.lnametext.Location = New System.Drawing.Point(110, 104)
        Me.lnametext.Name = "lnametext"
        Me.lnametext.Size = New System.Drawing.Size(198, 22)
        Me.lnametext.TabIndex = 12
        '
        'fnametext
        '
        Me.fnametext.Location = New System.Drawing.Point(107, 68)
        Me.fnametext.Name = "fnametext"
        Me.fnametext.Size = New System.Drawing.Size(201, 22)
        Me.fnametext.TabIndex = 11
        '
        'textid
        '
        Me.textid.Location = New System.Drawing.Point(107, 26)
        Me.textid.Name = "textid"
        Me.textid.Size = New System.Drawing.Size(100, 22)
        Me.textid.TabIndex = 10
        '
        'explbl
        '
        Me.explbl.AutoSize = True
        Me.explbl.Location = New System.Drawing.Point(376, 147)
        Me.explbl.Name = "explbl"
        Me.explbl.Size = New System.Drawing.Size(82, 17)
        Me.explbl.TabIndex = 9
        Me.explbl.Text = "Experience:"
        '
        'emilbl
        '
        Me.emilbl.AutoSize = True
        Me.emilbl.Location = New System.Drawing.Point(30, 182)
        Me.emilbl.Name = "emilbl"
        Me.emilbl.Size = New System.Drawing.Size(51, 17)
        Me.emilbl.TabIndex = 8
        Me.emilbl.Text = "E-Mail:"
        '
        'phonelbl
        '
        Me.phonelbl.AutoSize = True
        Me.phonelbl.Location = New System.Drawing.Point(389, 109)
        Me.phonelbl.Name = "phonelbl"
        Me.phonelbl.Size = New System.Drawing.Size(69, 17)
        Me.phonelbl.TabIndex = 7
        Me.phonelbl.Text = "Phoneno:"
        '
        'statelbl
        '
        Me.statelbl.AutoSize = True
        Me.statelbl.Location = New System.Drawing.Point(389, 68)
        Me.statelbl.Name = "statelbl"
        Me.statelbl.Size = New System.Drawing.Size(45, 17)
        Me.statelbl.TabIndex = 6
        Me.statelbl.Text = "State:"
        '
        'zonelbl
        '
        Me.zonelbl.AutoSize = True
        Me.zonelbl.Location = New System.Drawing.Point(389, 26)
        Me.zonelbl.Name = "zonelbl"
        Me.zonelbl.Size = New System.Drawing.Size(45, 17)
        Me.zonelbl.TabIndex = 5
        Me.zonelbl.Text = "Zone:"
        '
        'rolelbl
        '
        Me.rolelbl.AutoSize = True
        Me.rolelbl.Location = New System.Drawing.Point(30, 147)
        Me.rolelbl.Name = "rolelbl"
        Me.rolelbl.Size = New System.Drawing.Size(41, 17)
        Me.rolelbl.TabIndex = 4
        Me.rolelbl.Text = "Role:"
        '
        'lnamelbl
        '
        Me.lnamelbl.AutoSize = True
        Me.lnamelbl.Location = New System.Drawing.Point(30, 109)
        Me.lnamelbl.Name = "lnamelbl"
        Me.lnamelbl.Size = New System.Drawing.Size(74, 17)
        Me.lnamelbl.TabIndex = 3
        Me.lnamelbl.Text = "Lastname:"
        '
        'fnamelbl
        '
        Me.fnamelbl.AutoSize = True
        Me.fnamelbl.Location = New System.Drawing.Point(30, 68)
        Me.fnamelbl.Name = "fnamelbl"
        Me.fnamelbl.Size = New System.Drawing.Size(74, 17)
        Me.fnamelbl.TabIndex = 2
        Me.fnamelbl.Text = "Firstname:"
        '
        'midlbl
        '
        Me.midlbl.AutoSize = True
        Me.midlbl.Location = New System.Drawing.Point(30, 26)
        Me.midlbl.Name = "midlbl"
        Me.midlbl.Size = New System.Drawing.Size(25, 17)
        Me.midlbl.TabIndex = 1
        Me.midlbl.Text = "ID:"
        '
        'manageview1
        '
        Me.manageview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.manageview1.Location = New System.Drawing.Point(0, 210)
        Me.manageview1.Name = "manageview1"
        Me.manageview1.RowTemplate.Height = 24
        Me.manageview1.Size = New System.Drawing.Size(1109, 497)
        Me.manageview1.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 726)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "management"
        Me.Text = "management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.manageview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents explbl As System.Windows.Forms.Label
    Friend WithEvents emilbl As System.Windows.Forms.Label
    Friend WithEvents phonelbl As System.Windows.Forms.Label
    Friend WithEvents statelbl As System.Windows.Forms.Label
    Friend WithEvents zonelbl As System.Windows.Forms.Label
    Friend WithEvents rolelbl As System.Windows.Forms.Label
    Friend WithEvents lnamelbl As System.Windows.Forms.Label
    Friend WithEvents fnamelbl As System.Windows.Forms.Label
    Friend WithEvents midlbl As System.Windows.Forms.Label
    Friend WithEvents manageview1 As System.Windows.Forms.DataGridView
    Friend WithEvents sortbtn As System.Windows.Forms.Button
    Friend WithEvents delbtn As System.Windows.Forms.Button
    Friend WithEvents updbtn As System.Windows.Forms.Button
    Friend WithEvents insbtn As System.Windows.Forms.Button
    Friend WithEvents exptext As System.Windows.Forms.TextBox
    Friend WithEvents phonetext As System.Windows.Forms.TextBox
    Friend WithEvents statecombo As System.Windows.Forms.ComboBox
    Friend WithEvents zonecombo As System.Windows.Forms.ComboBox
    Friend WithEvents emailtext As System.Windows.Forms.TextBox
    Friend WithEvents rolecombo As System.Windows.Forms.ComboBox
    Friend WithEvents lnametext As System.Windows.Forms.TextBox
    Friend WithEvents fnametext As System.Windows.Forms.TextBox
    Friend WithEvents textid As System.Windows.Forms.TextBox
    Friend WithEvents dispbtn As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
End Class
