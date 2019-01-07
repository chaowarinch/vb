Public Class frmSecond

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       
        Dim Vistra As Integer
        Dim Frista As Integer
        Dim Result As Integer

        Dim Comvistra As Integer
        Dim Comfrist As Integer
        Dim Commit As Integer

        Vistra = Val(txtVistra.Text)
        Frista = Val(txtFristra.Text)
        Result = Vistra + Frista

        lblResult.Text = result

        Comvistra = Vistra * 5 / 100
        ComFrist = Frista * 10 / 100
        Commit = Comvistra + Comfrist

        lblComFristra.Text = Comfrist
        blComVistra.Text = Comvistra
        lblSumCom.Text = Commit


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class