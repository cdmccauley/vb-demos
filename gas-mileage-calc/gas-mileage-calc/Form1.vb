Public Class frmGasMileCalc
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declarations
        Dim decMiles As Decimal
        Dim decGas As Decimal
        Dim decMPG As Decimal
        'decMiles and decGas get input
        decMiles = Convert.ToDecimal(txtMiles.Text)
        decGas = Convert.ToDecimal(txtGas.Text)
        'decMPG gets processed output
        decMPG = decMiles / decGas
        'lblTotal gets decMPG as string
        lblTotal.Text = decMPG.ToString("n2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit on click
        End
    End Sub
End Class
