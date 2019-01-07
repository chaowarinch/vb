<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeventh
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
        Me.cboOutput = New System.Windows.Forms.ComboBox()
        Me.lstAdd = New System.Windows.Forms.ListBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnMoveAll = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnBackAll = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมควบคุม ListBox - ComboBox"
        '
        'cboOutput
        '
        Me.cboOutput.FormattingEnabled = True
        Me.cboOutput.Location = New System.Drawing.Point(305, 73)
        Me.cboOutput.Name = "cboOutput"
        Me.cboOutput.Size = New System.Drawing.Size(121, 21)
        Me.cboOutput.TabIndex = 1
        '
        'lstAdd
        '
        Me.lstAdd.FormattingEnabled = True
        Me.lstAdd.Location = New System.Drawing.Point(57, 73)
        Me.lstAdd.Name = "lstAdd"
        Me.lstAdd.Size = New System.Drawing.Size(148, 212)
        Me.lstAdd.TabIndex = 2
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(228, 107)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(38, 34)
        Me.btnMove.TabIndex = 3
        Me.btnMove.Text = ">"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnMoveAll
        '
        Me.btnMoveAll.Location = New System.Drawing.Point(228, 147)
        Me.btnMoveAll.Name = "btnMoveAll"
        Me.btnMoveAll.Size = New System.Drawing.Size(38, 34)
        Me.btnMoveAll.TabIndex = 3
        Me.btnMoveAll.Text = ">>"
        Me.btnMoveAll.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(228, 187)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(38, 34)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "<"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnBackAll
        '
        Me.btnBackAll.Location = New System.Drawing.Point(228, 227)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(38, 34)
        Me.btnBackAll.TabIndex = 3
        Me.btnBackAll.Text = "<<"
        Me.btnBackAll.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(75, 313)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(116, 34)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(310, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 34)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(192, 391)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 34)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "ปิดหน้าต่าง"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.White
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOutput.Location = New System.Drawing.Point(310, 358)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(116, 25)
        Me.lblOutput.TabIndex = 0
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(75, 358)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(116, 25)
        Me.txtAdd.TabIndex = 4
        '
        'frmSeventh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 456)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnMoveAll)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.lstAdd)
        Me.Controls.Add(Me.cboOutput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSeventh"
        Me.Text = "Week 7 Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboOutput As System.Windows.Forms.ComboBox
    Friend WithEvents lstAdd As System.Windows.Forms.ListBox
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents btnMoveAll As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnBackAll As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
End Class
