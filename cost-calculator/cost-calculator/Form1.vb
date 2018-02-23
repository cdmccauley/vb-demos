Public Class frmCostCalculator
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblSinglePrice.Click

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        'variables
        Dim shoQty As Short
        Const decPrice As Decimal = 3.5
        Dim shoTotal As Decimal

        'Chris McCauley: I know the following conversions aren't necessary 
        'for this assignment but I wanted to try and make them work.

        'shoQty gets input as short
        shoQty = Convert.ToInt16(txtQty.Text)

        'shoTotal gets processed output
        shoTotal = shoQty * decPrice

        'lblTotal gets converted shoTotal
        lblTotal.Text = shoTotal.ToString("c")

    End Sub
End Class
