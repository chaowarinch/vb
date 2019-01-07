Public Class frmAssign3

    Private Sub CboSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSelect.SelectedIndexChanged
        Dim size As Integer = Val(CboSelect.Text)
        TxtDigit.Font = New Font(TxtDigit.Font.Name, size, FontStyle.Regular)
    End Sub

    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        TxtDigit.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        TxtDigit.ForeColor = Color.Blue
    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        TxtDigit.ForeColor = Color.Green
    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        TxtDigit.ForeColor = Color.Violet
    End Sub

    Private Sub lblFBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlack.Click
        TxtDigit.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        TxtDigit.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        TxtDigit.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        TxtDigit.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWhite.Click
        TxtDigit.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFSky.Click
        TxtDigit.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblBRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBRed.Click
        TxtDigit.BackColor = Color.Red
    End Sub

    Private Sub lblBBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlue.Click
        TxtDigit.BackColor = Color.Blue
    End Sub

    Private Sub lblBGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBGreen.Click
        TxtDigit.BackColor = Color.Green
    End Sub

    Private Sub lblBViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBViolet.Click
        TxtDigit.BackColor = Color.Violet
    End Sub

    Private Sub lblBBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBlack.Click
        TxtDigit.BackColor = Color.Black
    End Sub

    Private Sub lblBOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBOrange.Click
        TxtDigit.BackColor = Color.Orange
    End Sub

    Private Sub lblBYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBYellow.Click
        TxtDigit.BackColor = Color.Yellow
    End Sub

    Private Sub lblBBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBBrown.Click
        TxtDigit.BackColor = Color.Brown
    End Sub

    Private Sub lblBWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBWhite.Click
        TxtDigit.BackColor = Color.White
    End Sub

    Private Sub lblBSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBSky.Click
        TxtDigit.BackColor = Color.SkyBlue
    End Sub

    Private Sub btnHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        Dim Num As Integer
        Num = TxtDigit.Text
        TxtDigit.Text = Num + 3

    End Sub

    Private Sub btnLow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLow.Click
        Dim Num As Integer
        Num = TxtDigit.Text
        TxtDigit.Text = Num - 3
    End Sub
End Class