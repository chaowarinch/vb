Public Class frmJob4

    Private Sub redShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redShortDate.CheckedChanged
        lblDate.Text = Today
    End Sub

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim decR_BONUS = 0.2
        Dim decR_ALLOW = 0.01
        Dim decR_TAX = 0.07
        Dim dblYearSalary As Integer
        Dim dblBonus As Integer
        Dim dblAllIncome As Integer
        Dim dblAllowance As Integer
        Dim dblTax As Integer



        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX

        lblBonus.Text = dblBonus.ToString("##,###")
        lblAllIncome.Text = dblAllIncome.ToString("##,###")
        lblAllowance.Text = dblAllowance.ToString("##,###")
        lblYearSalary.Text = dblYearSalary.ToString("##,###")
        lblTax.Text = dblTax.ToString("##,###")

    End Sub

    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now
    End Sub

    Private Sub redGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redGenDate.CheckedChanged
        lblDate.Text = Date.Now
    End Sub

    Private Sub redLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles redLongDate.CheckedChanged
        lblDate.Text = Now.ToLongDateString


    End Sub
End Class