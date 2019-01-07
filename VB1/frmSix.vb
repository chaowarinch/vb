Public Class frmSix
    Dim paidPrice As Integer
    Dim free1 As Integer = 25000
    Dim free2 As Integer = 15000
    Dim free3 As Integer = 35000
    Dim price1 As Integer = 40000
    Dim price2 As Integer = 50000
    Dim price3 As Integer = 20000
    Dim price4 As Integer = 30000
    Dim srtPrice As Integer = 1250000
    Dim result As Integer

    Private Sub frmSix_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
    End Sub

    Private Sub chkCarForMe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.Click
        If chkCarForMe.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True

            lblStratPrice.Text = srtPrice
            paidPrice = srtPrice + free1 + free2 + free3
            lblPaidPrice.Text = paidPrice

        ElseIf chkCarForMe.Checked = False Then
            GroupBox1.Enabled = False
            GroupBox2.Enabled = False

            Dim result As Integer = MessageBox.Show("ต้องการยกเลิกการซื้อรถใช่หรือไม่", "ยกเลิก", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                lblPaidPrice.Text = ""
            End If
            If result = DialogResult.No Then
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                chkCarForMe.Checked = True
            End If

        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text - free1
        ElseIf chkFree1.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text + free1
        End If

    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text - free2
        ElseIf chkFree2.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text + free2
        End If

    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text - free3
        ElseIf chkFree3.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text + free3
        End If
    End Sub

   

   
    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + price1
        ElseIf chkItemsAdd1.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - price1
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + price2
        ElseIf chkItemsAdd2.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - price2
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + price3
        ElseIf chkItemsAdd3.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - price3
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked = True Then
            lblPaidPrice.Text = lblPaidPrice.Text + price4
        ElseIf chkItemsAdd4.Checked = False Then
            lblPaidPrice.Text = lblPaidPrice.Text - price4
        End If
    End Sub
End Class