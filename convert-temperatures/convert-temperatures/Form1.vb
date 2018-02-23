Public Class frmConvertTemp
    Private Sub btnFahToCel_Click(sender As Object, e As EventArgs) Handles btnFahToCel.Click
        'declarations
        Dim shoTemp As Decimal
        'shoTemp gets input
        shoTemp = Convert.ToDecimal(txtTemp.Text)
        'lblResult gets output as string
        lblResult.Text = ((shoTemp - 32) * 5 / 9).ToString("n2")
    End Sub

    Private Sub btnCelToFah_Click(sender As Object, e As EventArgs) Handles btnCelToFah.Click
        'declarations
        Dim shoTemp As Decimal
        'shoTemp gets input
        shoTemp = Convert.ToDecimal(txtTemp.Text)
        'lblResult gets output as string
        lblResult.Text = (shoTemp * 9 / 5 + 32).ToString("n2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'click to exit
        End
    End Sub
End Class
