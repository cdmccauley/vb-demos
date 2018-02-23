Public Class frmMPGCalculator

    Dim decMiles As Decimal
    Dim decGal As Decimal
    Dim decMPG As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblMPGOutput.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        decMiles = txtMiles.Text
        decGal = txtGal.Text
        decMPG = decMiles / decGal
        decMPG = decMPG - (decMPG Mod 0.01)
        lblMPG.Text = decMPG.ToString
    End Sub
End Class
