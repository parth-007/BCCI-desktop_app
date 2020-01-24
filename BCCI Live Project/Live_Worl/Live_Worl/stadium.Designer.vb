<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stadium
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dispbtn = New System.Windows.Forms.Button()
        Me.insbtn = New System.Windows.Forms.Button()
        Me.ownertext = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.maxtext = New System.Windows.Forms.TextBox()
        Me.statecombo = New System.Windows.Forms.ComboBox()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.nametext = New System.Windows.Forms.TextBox()
        Me.stno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stadiumview1 = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stadiumview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.dispbtn)
        Me.Panel1.Controls.Add(Me.insbtn)
        Me.Panel1.Controls.Add(Me.ownertext)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.maxtext)
        Me.Panel1.Controls.Add(Me.statecombo)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.nametext)
        Me.Panel1.Controls.Add(Me.stno)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 242)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(501, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 221)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'dispbtn
        '
        Me.dispbtn.Location = New System.Drawing.Point(397, 55)
        Me.dispbtn.Name = "dispbtn"
        Me.dispbtn.Size = New System.Drawing.Size(75, 30)
        Me.dispbtn.TabIndex = 17
        Me.dispbtn.Text = "Display"
        Me.dispbtn.UseVisualStyleBackColor = True
        '
        'insbtn
        '
        Me.insbtn.Location = New System.Drawing.Point(397, 18)
        Me.insbtn.Name = "insbtn"
        Me.insbtn.Size = New System.Drawing.Size(75, 30)
        Me.insbtn.TabIndex = 16
        Me.insbtn.Text = "Insert"
        Me.insbtn.UseVisualStyleBackColor = True
        '
        'ownertext
        '
        Me.ownertext.Location = New System.Drawing.Point(110, 211)
        Me.ownertext.Name = "ownertext"
        Me.ownertext.Size = New System.Drawing.Size(203, 22)
        Me.ownertext.TabIndex = 15
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(193, 184)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton2.Size = New System.Drawing.Size(47, 21)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(132, 184)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(53, 21)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yes"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'maxtext
        '
        Me.maxtext.Location = New System.Drawing.Point(129, 154)
        Me.maxtext.Name = "maxtext"
        Me.maxtext.Size = New System.Drawing.Size(154, 22)
        Me.maxtext.TabIndex = 12
        '
        'statecombo
        '
        Me.statecombo.FormattingEnabled = True
        Me.statecombo.Location = New System.Drawing.Point(71, 116)
        Me.statecombo.Name = "statecombo"
        Me.statecombo.Size = New System.Drawing.Size(169, 24)
        Me.statecombo.TabIndex = 11
        '
        'dtp1
        '
        Me.dtp1.Location = New System.Drawing.Point(71, 83)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(242, 22)
        Me.dtp1.TabIndex = 10
        '
        'nametext
        '
        Me.nametext.Location = New System.Drawing.Point(71, 55)
        Me.nametext.Name = "nametext"
        Me.nametext.Size = New System.Drawing.Size(242, 22)
        Me.nametext.TabIndex = 8
        '
        'stno
        '
        Me.stno.Location = New System.Drawing.Point(71, 26)
        Me.stno.Name = "stno"
        Me.stno.ReadOnly = True
        Me.stno.Size = New System.Drawing.Size(100, 22)
        Me.stno.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Owner_name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Press-box facility"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Max Strength:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "State:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SNO:"
        '
        'stadiumview1
        '
        Me.stadiumview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stadiumview1.Location = New System.Drawing.Point(6, 255)
        Me.stadiumview1.Name = "stadiumview1"
        Me.stadiumview1.RowTemplate.Height = 24
        Me.stadiumview1.Size = New System.Drawing.Size(953, 471)
        Me.stadiumview1.TabIndex = 1
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'stadium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 733)
        Me.Controls.Add(Me.stadiumview1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "stadium"
        Me.Text = "stadium"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stadiumview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dispbtn As System.Windows.Forms.Button
    Friend WithEvents insbtn As System.Windows.Forms.Button
    Friend WithEvents ownertext As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents maxtext As System.Windows.Forms.TextBox
    Friend WithEvents statecombo As System.Windows.Forms.ComboBox
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents nametext As System.Windows.Forms.TextBox
    Friend WithEvents stno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stadiumview1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
