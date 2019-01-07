<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssign3))
        Me.TxtDigit = New System.Windows.Forms.TextBox()
        Me.btnHigh = New System.Windows.Forms.Button()
        Me.btnLow = New System.Windows.Forms.Button()
        Me.CboSelect = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtDigit
        '
        Me.TxtDigit.Location = New System.Drawing.Point(122, 62)
        Me.TxtDigit.Multiline = True
        Me.TxtDigit.Name = "TxtDigit"
        Me.TxtDigit.Size = New System.Drawing.Size(222, 52)
        Me.TxtDigit.TabIndex = 0
        '
        'btnHigh
        '
        Me.btnHigh.Location = New System.Drawing.Point(350, 62)
        Me.btnHigh.Name = "btnHigh"
        Me.btnHigh.Size = New System.Drawing.Size(45, 23)
        Me.btnHigh.TabIndex = 1
        Me.btnHigh.Text = "+"
        Me.btnHigh.UseVisualStyleBackColor = True
        '
        'btnLow
        '
        Me.btnLow.Location = New System.Drawing.Point(351, 91)
        Me.btnLow.Name = "btnLow"
        Me.btnLow.Size = New System.Drawing.Size(44, 23)
        Me.btnLow.TabIndex = 1
        Me.btnLow.Text = "-"
        Me.btnLow.UseVisualStyleBackColor = True
        '
        'CboSelect
        '
        Me.CboSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSelect.FormattingEnabled = True
        Me.CboSelect.Items.AddRange(New Object() {"10", "14", "18", "22", "26", "30", "34", "38", "42", "46", "50", "54", "58", "62", "68", "70"})
        Me.CboSelect.Location = New System.Drawing.Point(223, 129)
        Me.CboSelect.Name = "CboSelect"
        Me.CboSelect.Size = New System.Drawing.Size(121, 21)
        Me.CboSelect.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ขนาดฟอนต์"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Location = New System.Drawing.Point(69, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 89)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(19, 16)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(25, 23)
        Me.lblFRed.TabIndex = 0
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(49, 16)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(25, 23)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Green
        Me.lblFGreen.Location = New System.Drawing.Point(80, 16)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(25, 23)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Violet
        Me.lblFViolet.Location = New System.Drawing.Point(111, 16)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(25, 23)
        Me.lblFViolet.TabIndex = 0
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(142, 16)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(25, 23)
        Me.lblFBlack.TabIndex = 0
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.Orange
        Me.lblFOrange.Location = New System.Drawing.Point(19, 51)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(25, 23)
        Me.lblFOrange.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(49, 51)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(25, 23)
        Me.lblFYellow.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.Brown
        Me.lblFBrown.Location = New System.Drawing.Point(80, 51)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(25, 23)
        Me.lblFBrown.TabIndex = 0
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Location = New System.Drawing.Point(111, 51)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(25, 23)
        Me.lblFWhite.TabIndex = 0
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblFSky.Location = New System.Drawing.Point(142, 51)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(25, 23)
        Me.lblFSky.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblBSky)
        Me.GroupBox2.Controls.Add(Me.lblBBlack)
        Me.GroupBox2.Controls.Add(Me.lblBWhite)
        Me.GroupBox2.Controls.Add(Me.lblBViolet)
        Me.GroupBox2.Controls.Add(Me.lblBBrown)
        Me.GroupBox2.Controls.Add(Me.lblBYellow)
        Me.GroupBox2.Controls.Add(Me.lblBGreen)
        Me.GroupBox2.Controls.Add(Me.lblBOrange)
        Me.GroupBox2.Controls.Add(Me.lblBBlue)
        Me.GroupBox2.Controls.Add(Me.lblBRed)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 89)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BgColor"
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.SkyBlue
        Me.lblBSky.Location = New System.Drawing.Point(142, 51)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(25, 23)
        Me.lblBSky.TabIndex = 0
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(142, 16)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(25, 23)
        Me.lblBBlack.TabIndex = 0
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.Location = New System.Drawing.Point(111, 51)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(25, 23)
        Me.lblBWhite.TabIndex = 0
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Violet
        Me.lblBViolet.Location = New System.Drawing.Point(111, 16)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(25, 23)
        Me.lblBViolet.TabIndex = 0
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.Brown
        Me.lblBBrown.Location = New System.Drawing.Point(80, 51)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(25, 23)
        Me.lblBBrown.TabIndex = 0
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(49, 51)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(25, 23)
        Me.lblBYellow.TabIndex = 0
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.Green
        Me.lblBGreen.Location = New System.Drawing.Point(80, 16)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(25, 23)
        Me.lblBGreen.TabIndex = 0
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.Orange
        Me.lblBOrange.Location = New System.Drawing.Point(19, 51)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(25, 23)
        Me.lblBOrange.TabIndex = 0
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(49, 16)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(25, 23)
        Me.lblBBlue.TabIndex = 0
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(19, 16)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(25, 23)
        Me.lblBRed.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "กำหนดตัวเลข"
        '
        'frmAssign3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 351)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CboSelect)
        Me.Controls.Add(Me.btnLow)
        Me.Controls.Add(Me.btnHigh)
        Me.Controls.Add(Me.TxtDigit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAssign3"
        Me.Text = "FrmColor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDigit As System.Windows.Forms.TextBox
    Friend WithEvents btnHigh As System.Windows.Forms.Button
    Friend WithEvents btnLow As System.Windows.Forms.Button
    Friend WithEvents CboSelect As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFSky As System.Windows.Forms.Label
    Friend WithEvents lblFBlack As System.Windows.Forms.Label
    Friend WithEvents lblFWhite As System.Windows.Forms.Label
    Friend WithEvents lblFViolet As System.Windows.Forms.Label
    Friend WithEvents lblFBrown As System.Windows.Forms.Label
    Friend WithEvents lblFYellow As System.Windows.Forms.Label
    Friend WithEvents lblFGreen As System.Windows.Forms.Label
    Friend WithEvents lblFOrange As System.Windows.Forms.Label
    Friend WithEvents lblFBlue As System.Windows.Forms.Label
    Friend WithEvents lblFRed As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblBSky As System.Windows.Forms.Label
    Friend WithEvents lblBBlack As System.Windows.Forms.Label
    Friend WithEvents lblBWhite As System.Windows.Forms.Label
    Friend WithEvents lblBViolet As System.Windows.Forms.Label
    Friend WithEvents lblBBrown As System.Windows.Forms.Label
    Friend WithEvents lblBYellow As System.Windows.Forms.Label
    Friend WithEvents lblBGreen As System.Windows.Forms.Label
    Friend WithEvents lblBOrange As System.Windows.Forms.Label
    Friend WithEvents lblBBlue As System.Windows.Forms.Label
    Friend WithEvents lblBRed As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
