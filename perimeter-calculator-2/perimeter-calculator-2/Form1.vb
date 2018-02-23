Public Class frmPeriCalc
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declarations
        Dim shoLength As Short
        Dim shoWidth As Short
        Dim shoPerim As Short
        'shoLength/shoWidth gets input
        shoLength = txtLength.Text
        shoWidth = txtWidth.Text
        'shoPerim gets output after processing
        shoPerim = 2 * (shoLength + shoWidth)
        'lblTotal gets shoPerim as string
        lblTotal.Text = shoPerim.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'button click exits
        End
    End Sub
End Class
