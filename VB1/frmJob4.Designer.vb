<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJob4
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSale = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblYearSalary = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblAllIncome = New System.Windows.Forms.Label()
        Me.lblAllowance = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.redLongDate = New System.Windows.Forms.RadioButton()
        Me.redGenDate = New System.Windows.Forms.RadioButton()
        Me.redShortDate = New System.Windows.Forms.RadioButton()
        Me.btnCalTax = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "วันที่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เงินเดือน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เงินเดือนทั้งปี"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "รับเงินโบนัส"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "รวมรายได้"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "หักค่าลดหย่อน"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 264)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ภาษีที่ต้องชำระ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(158, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(313, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "โปรแกรมคำนวณภาษี (อย่างหยาบ)"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(149, 72)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 1
        '
        'txtSale
        '
        Me.txtSale.Location = New System.Drawing.Point(149, 104)
        Me.txtSale.Name = "txtSale"
        Me.txtSale.Size = New System.Drawing.Size(100, 20)
        Me.txtSale.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ยอดขายทั้งปี"
        '
        'lblYearSalary
        '
        Me.lblYearSalary.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblYearSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYearSalary.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblYearSalary.Location = New System.Drawing.Point(149, 143)
        Me.lblYearSalary.Name = "lblYearSalary"
        Me.lblYearSalary.Size = New System.Drawing.Size(100, 19)
        Me.lblYearSalary.TabIndex = 0
        Me.lblYearSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBonus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblBonus.Location = New System.Drawing.Point(149, 176)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(100, 19)
        Me.lblBonus.TabIndex = 0
        Me.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllIncome
        '
        Me.lblAllIncome.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblAllIncome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllIncome.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblAllIncome.Location = New System.Drawing.Point(149, 205)
        Me.lblAllIncome.Name = "lblAllIncome"
        Me.lblAllIncome.Size = New System.Drawing.Size(100, 19)
        Me.lblAllIncome.TabIndex = 0
        Me.lblAllIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAllowance
        '
        Me.lblAllowance.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblAllowance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAllowance.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblAllowance.Location = New System.Drawing.Point(149, 233)
        Me.lblAllowance.Name = "lblAllowance"
        Me.lblAllowance.Size = New System.Drawing.Size(100, 19)
        Me.lblAllowance.TabIndex = 0
        Me.lblAllowance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblTax.Location = New System.Drawing.Point(149, 264)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 19)
        Me.lblTax.TabIndex = 0
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.redLongDate)
        Me.GroupBox1.Controls.Add(Me.redGenDate)
        Me.GroupBox1.Controls.Add(Me.redShortDate)
        Me.GroupBox1.Location = New System.Drawing.Point(312, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 110)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รูปแบบวันที่"
        '
        'redLongDate
        '
        Me.redLongDate.AutoSize = True
        Me.redLongDate.Location = New System.Drawing.Point(25, 71)
        Me.redLongDate.Name = "redLongDate"
        Me.redLongDate.Size = New System.Drawing.Size(121, 17)
        Me.redLongDate.TabIndex = 0
        Me.redLongDate.TabStop = True
        Me.redLongDate.Text = "วันที่แบบ Long Date"
        Me.redLongDate.UseVisualStyleBackColor = True
        '
        'redGenDate
        '
        Me.redGenDate.AutoSize = True
        Me.redGenDate.Location = New System.Drawing.Point(25, 48)
        Me.redGenDate.Name = "redGenDate"
        Me.redGenDate.Size = New System.Drawing.Size(134, 17)
        Me.redGenDate.TabIndex = 0
        Me.redGenDate.TabStop = True
        Me.redGenDate.Text = "วันที่แบบ General Date"
        Me.redGenDate.UseVisualStyleBackColor = True
        '
        'redShortDate
        '
        Me.redShortDate.AutoSize = True
        Me.redShortDate.Location = New System.Drawing.Point(25, 25)
        Me.redShortDate.Name = "redShortDate"
        Me.redShortDate.Size = New System.Drawing.Size(122, 17)
        Me.redShortDate.TabIndex = 0
        Me.redShortDate.TabStop = True
        Me.redShortDate.Text = "วันที่แบบ Short Date"
        Me.redShortDate.UseVisualStyleBackColor = True
        '
        'btnCalTax
        '
        Me.btnCalTax.BackColor = System.Drawing.Color.Chocolate
        Me.btnCalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalTax.Location = New System.Drawing.Point(337, 209)
        Me.btnCalTax.Name = "btnCalTax"
        Me.btnCalTax.Size = New System.Drawing.Size(144, 68)
        Me.btnCalTax.TabIndex = 3
        Me.btnCalTax.Text = "คำนวณ"
        Me.btnCalTax.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lblDate.Location = New System.Drawing.Point(149, 42)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(158, 19)
        Me.lblDate.TabIndex = 0
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmJob4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(621, 352)
        Me.Controls.Add(Me.btnCalTax)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSale)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblAllowance)
        Me.Controls.Add(Me.lblAllIncome)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblYearSalary)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmJob4"
        Me.Text = "Calculate of Taxation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtSale As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblYearSalary As System.Windows.Forms.Label
    Friend WithEvents lblBonus As System.Windows.Forms.Label
    Friend WithEvents lblAllIncome As System.Windows.Forms.Label
    Friend WithEvents lblAllowance As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents redLongDate As System.Windows.Forms.RadioButton
    Friend WithEvents redGenDate As System.Windows.Forms.RadioButton
    Friend WithEvents redShortDate As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalTax As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
End Class
