<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecond
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtVistra = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFristra = New System.Windows.Forms.TextBox()
        Me.blComVistra = New System.Windows.Forms.Label()
        Me.lblComFristra = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSumCom = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Vistra Gluta"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Fristra Gluta"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCoral
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(232, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtVistra
        '
        Me.txtVistra.Location = New System.Drawing.Point(170, 48)
        Me.txtVistra.Name = "txtVistra"
        Me.txtVistra.Size = New System.Drawing.Size(100, 20)
        Me.txtVistra.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(187, 92)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(83, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(362, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 33)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ค่าคอมมิชชั่น 5%"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 33)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ผลรวมยอดขาย "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(362, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 33)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ค่าคอมมิชชั่น 10%"
        '
        'txtFristra
        '
        Me.txtFristra.Location = New System.Drawing.Point(170, 92)
        Me.txtFristra.Name = "txtFristra"
        Me.txtFristra.Size = New System.Drawing.Size(100, 20)
        Me.txtFristra.TabIndex = 2
        '
        'blComVistra
        '
        Me.blComVistra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.blComVistra.Location = New System.Drawing.Point(487, 48)
        Me.blComVistra.Name = "blComVistra"
        Me.blComVistra.Size = New System.Drawing.Size(103, 20)
        Me.blComVistra.TabIndex = 0
        '
        'lblComFristra
        '
        Me.lblComFristra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblComFristra.Location = New System.Drawing.Point(489, 94)
        Me.lblComFristra.Name = "lblComFristra"
        Me.lblComFristra.Size = New System.Drawing.Size(101, 20)
        Me.lblComFristra.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(170, 138)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(100, 23)
        Me.lblResult.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(362, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 33)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ค่าคอมมิชชั่นรวม"
        '
        'lblSumCom
        '
        Me.lblSumCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSumCom.Location = New System.Drawing.Point(487, 138)
        Me.lblSumCom.Name = "lblSumCom"
        Me.lblSumCom.Size = New System.Drawing.Size(101, 20)
        Me.lblSumCom.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightCoral
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(365, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ปิด"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmSecond
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(656, 291)
        Me.Controls.Add(Me.txtFristra)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtVistra)
        Me.Controls.Add(Me.lblSumCom)
        Me.Controls.Add(Me.lblComFristra)
        Me.Controls.Add(Me.blComVistra)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSecond"
        Me.Text = "frmSecond"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtVistra As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFristra As System.Windows.Forms.TextBox
    Friend WithEvents blComVistra As System.Windows.Forms.Label
    Friend WithEvents lblComFristra As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSumCom As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
