Public Class frmAmusementTickets
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declarations
        Const sngChildPrice As Single = 6.0
        Const sngAdultPrice As Single = 12.0
        Const sngSeniorPrice As Single = 9.0

        Dim decChildSubtotal As Decimal
        Dim decAdultSubtotal As Decimal
        Dim decSeniorSubtotal As Decimal

        'subtotals input, processing
        decChildSubtotal = Convert.ToInt16(txtTotalChild.Text) * sngChildPrice
        decAdultSubtotal = Convert.ToInt16(txtTotalAdult.Text) * sngAdultPrice
        decSeniorSubtotal = Convert.ToInt16(txtTotalSenior.Text) * sngSeniorPrice

        'subtotals output
        lblChildSubtotal.Text = decChildSubtotal.ToString("c")
        lblAdultSubtotal.Text = decAdultSubtotal.ToString("c")
        lblSeniorSubtotal.Text = decSeniorSubtotal.ToString("c")

        'totals input, processing, output
        lblTicketTotal.Text = (Convert.ToInt16(txtTotalChild.Text) +
            Convert.ToInt16(txtTotalAdult.Text) + Convert.ToInt16(txtTotalSenior.Text)).ToString
        lblTotal.Text = (decChildSubtotal + decAdultSubtotal + decSeniorSubtotal).ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit on click
        End
    End Sub
End Class
