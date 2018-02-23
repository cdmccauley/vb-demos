Public Class frmJimSoxxSports
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declarations
        Dim shoFootBQty As Short
        Dim shoBasketBQty As Short
        Dim shoVolleyBQty As Short
        Const decFootBPrice As Decimal = 44.95
        Const decBasketBPrice As Decimal = 49.95
        Const decVolleyBPrice As Decimal = 39.95
        Dim decFootBTotal As Decimal
        Dim decBasketBTotal As Decimal
        Dim decVolleyBTotal As Decimal
        Dim decSubtotal As Decimal
        Const decTaxRate As Decimal = 0.05
        Dim decTaxTotal As Decimal
        'sho*BQty gets inputs
        shoFootBQty = Convert.ToInt16(txtFootBQty.Text)
        shoBasketBQty = Convert.ToInt16(txtBasketBQty.Text)
        shoVolleyBQty = Convert.ToInt16(txtVolleyBQty.Text)
        'dec*BTotal gets processed outputs
        decFootBTotal = shoFootBQty * decFootBPrice
        decBasketBTotal = shoBasketBQty * decBasketBPrice
        decVolleyBTotal = shoVolleyBQty * decVolleyBPrice
        'lbl*BTotal.Text gets outputs
        lblFootBTotal.Text = decFootBTotal.ToString("c2")
        lblBasketBTotal.Text = decBasketBTotal.ToString("c2")
        lblVolleyBTotal.Text = decVolleyBTotal.ToString("c2")
        'lblItemQty.Text gets processed output
        lblItemQty.Text = (Convert.ToInt16(shoFootBQty) + Convert.ToInt16(shoBasketBQty) + Convert.ToInt16(shoVolleyBQty)).ToString
        'decSubtotal gets processed outputs
        decSubtotal = decFootBTotal + decBasketBTotal + decVolleyBTotal
        'lblSubtotal.Text gets output
        lblSubtotal.Text = decSubtotal.ToString("c2")
        'decTaxTotal gets processed output
        decTaxTotal = (decFootBTotal + decBasketBTotal + decVolleyBTotal) * decTaxRate
        'lblTaxTotal.Text gets decTaxTotal
        lblTaxTotal.Text = decTaxTotal.ToString("c2")
        'lblTotal.Text gets processed output
        lblTotal.Text = (decSubtotal + decTaxTotal).ToString("c2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit on click
        End
    End Sub
End Class
