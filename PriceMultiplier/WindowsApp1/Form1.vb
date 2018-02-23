Public Class frmPriceMultiplier

    Dim decPrice As Decimal
    Dim shoQty As Short
    Dim decTotal As Decimal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        decPrice = txtPrice.Text
        shoQty = txtQty.Text
        decTotal = decPrice * shoQty
        lblTotal.Text = decTotal.ToString
    End Sub
End Class
