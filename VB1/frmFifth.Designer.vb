<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab5
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
        Me.gpbPaid = New System.Windows.Forms.GroupBox()
        Me.redCredit = New System.Windows.Forms.RadioButton()
        Me.redPaid = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.redOther = New System.Windows.Forms.RadioButton()
        Me.redMember = New System.Windows.Forms.RadioButton()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.gpbPaid.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(137, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(50, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(50, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ราคาขาย"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(50, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "จำนวนซื้อ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(50, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "เป็นเงิน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(50, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ส่วนลด"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(50, 362)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ยอดค้างชำระ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(50, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 18)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "จำนวนเงินต้องชำระ"
        '
        'gpbPaid
        '
        Me.gpbPaid.Controls.Add(Me.redCredit)
        Me.gpbPaid.Controls.Add(Me.redPaid)
        Me.gpbPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbPaid.ForeColor = System.Drawing.Color.Blue
        Me.gpbPaid.Location = New System.Drawing.Point(261, 237)
        Me.gpbPaid.Name = "gpbPaid"
        Me.gpbPaid.Size = New System.Drawing.Size(148, 37)
        Me.gpbPaid.TabIndex = 1
        Me.gpbPaid.TabStop = False
        Me.gpbPaid.Text = "การชำระเงิน"
        '
        'redCredit
        '
        Me.redCredit.AutoSize = True
        Me.redCredit.ForeColor = System.Drawing.Color.Red
        Me.redCredit.Location = New System.Drawing.Point(84, 14)
        Me.redCredit.Name = "redCredit"
        Me.redCredit.Size = New System.Drawing.Size(46, 22)
        Me.redCredit.TabIndex = 0
        Me.redCredit.TabStop = True
        Me.redCredit.Text = "เชื่อ"
        Me.redCredit.UseVisualStyleBackColor = True
        '
        'redPaid
        '
        Me.redPaid.AutoSize = True
        Me.redPaid.ForeColor = System.Drawing.Color.Red
        Me.redPaid.Location = New System.Drawing.Point(6, 14)
        Me.redPaid.Name = "redPaid"
        Me.redPaid.Size = New System.Drawing.Size(42, 22)
        Me.redPaid.TabIndex = 0
        Me.redPaid.TabStop = True
        Me.redPaid.Text = "สด"
        Me.redPaid.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.redOther)
        Me.GroupBox2.Controls.Add(Me.redMember)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(33, 237)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(175, 37)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ประเภทลูกค้า"
        '
        'redOther
        '
        Me.redOther.AutoSize = True
        Me.redOther.ForeColor = System.Drawing.Color.Red
        Me.redOther.Location = New System.Drawing.Point(87, 14)
        Me.redOther.Name = "redOther"
        Me.redOther.Size = New System.Drawing.Size(87, 22)
        Me.redOther.TabIndex = 0
        Me.redOther.TabStop = True
        Me.redOther.Text = "ลูกค้าทั่วไป"
        Me.redOther.UseVisualStyleBackColor = True
        '
        'redMember
        '
        Me.redMember.AutoSize = True
        Me.redMember.ForeColor = System.Drawing.Color.Red
        Me.redMember.Location = New System.Drawing.Point(7, 14)
        Me.redMember.Name = "redMember"
        Me.redMember.Size = New System.Drawing.Size(65, 22)
        Me.redMember.TabIndex = 0
        Me.redMember.TabStop = True
        Me.redMember.Text = "สมาชิก"
        Me.redMember.UseVisualStyleBackColor = True
        '
        'txtProduct
        '
        Me.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Location = New System.Drawing.Point(174, 88)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtProduct.Size = New System.Drawing.Size(161, 24)
        Me.txtProduct.TabIndex = 2
        '
        'txtPrice
        '
        Me.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(174, 126)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrice.Size = New System.Drawing.Size(161, 24)
        Me.txtPrice.TabIndex = 2
        '
        'txtUnit
        '
        Me.txtUnit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(174, 164)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtUnit.Size = New System.Drawing.Size(161, 24)
        Me.txtUnit.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Blue
        Me.btnCalculate.Location = New System.Drawing.Point(174, 393)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 23)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCredit
        '
        Me.lblCredit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblCredit.BackColor = System.Drawing.Color.White
        Me.lblCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredit.Location = New System.Drawing.Point(171, 356)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCredit.Size = New System.Drawing.Size(164, 19)
        Me.lblCredit.TabIndex = 4
        '
        'lblPaid
        '
        Me.lblPaid.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPaid.BackColor = System.Drawing.Color.White
        Me.lblPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.Location = New System.Drawing.Point(171, 318)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPaid.Size = New System.Drawing.Size(164, 19)
        Me.lblPaid.TabIndex = 4
        '
        'lblDiscount
        '
        Me.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblDiscount.BackColor = System.Drawing.Color.White
        Me.lblDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(171, 282)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDiscount.Size = New System.Drawing.Size(164, 19)
        Me.lblDiscount.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(171, 200)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotal.Size = New System.Drawing.Size(164, 19)
        Me.lblTotal.TabIndex = 4
        '
        'frmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(439, 439)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpbPaid)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab5"
        Me.Text = "frmLab5"
        Me.gpbPaid.ResumeLayout(False)
        Me.gpbPaid.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents gpbPaid As System.Windows.Forms.GroupBox
    Friend WithEvents redCredit As System.Windows.Forms.RadioButton
    Friend WithEvents redPaid As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents redOther As System.Windows.Forms.RadioButton
    Friend WithEvents redMember As System.Windows.Forms.RadioButton
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
End Class
