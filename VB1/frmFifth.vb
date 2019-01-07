Public Class frmLab5
    Dim decTotal As Integer
    Dim decDiscount As Integer
    Dim decNet As Integer
    Dim decCredit As Integer
    Private Sub redMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redMember.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        redCredit.Enabled = True

    End Sub

    Private Sub redOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redOther.CheckedChanged
        If redOther.Checked = True Then
            redPaid.Checked = True

        End If

        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        redCredit.Enabled = False


    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click



        If txtProduct.Text = "" Then
            MessageBox.Show("ป้อนข้อมูลไม่สมบูรณ์")
            Me.Close()
        End If

        If redMember.Checked = True And redPaid.Checked = True Then

            If decTotal < 1000 Then
                lblPaid.Text = decTotal
                If redCredit.Checked = False Then
                    lblCredit .Text ="0"
                End If

            ElseIf decTotal < 5000 Then
                decDiscount = decTotal * 0.05
                lblPaid.Text = decTotal - decDiscount
                lblDiscount.Text = decDiscount
                If redCredit.Checked = False Then
                    lblCredit.Text = "0"
                End If


            ElseIf decTotal < 10000 Then
                decDiscount = decTotal * 0.1
                lblPaid.Text = decTotal - decDiscount
                lblDiscount.Text = decDiscount
                If redCredit.Checked = False Then
                    lblCredit.Text = "0"
                End If


            ElseIf decTotal >= 10000 Then
                decDiscount = decTotal * 0.15
                lblPaid.Text = decTotal - decDiscount
                lblDiscount.Text = decDiscount

                If redCredit.Checked = False Then
                    lblCredit.Text = "0"
                End If

            End If

        End If
        If redCredit.Checked = True Then
            lblCredit.Text = decTotal

        ElseIf redOther.Checked = True Then
            lblPaid.Text = decTotal
        End If
    End Sub

   

   
    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged

        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged

        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal
    End Sub

    Private Sub redPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redPaid.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub redCredit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redCredit.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub
End Class