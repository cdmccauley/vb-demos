Public Class frmSimpleCalculator
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'input, processing, output
        lblAnswer.Text = (Convert.ToDecimal(txtNum1.Text) + Convert.ToDecimal(txtNum2.Text)).ToString
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        'input, processing, output
        lblAnswer.Text = (Convert.ToDecimal(txtNum1.Text) - Convert.ToDecimal(txtNum2.Text)).ToString
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        'input, processing, output
        lblAnswer.Text = (Convert.ToDecimal(txtNum1.Text) * Convert.ToDecimal(txtNum2.Text)).ToString
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'input, processing, output
        lblAnswer.Text = (Convert.ToDecimal(txtNum1.Text) / Convert.ToDecimal(txtNum2.Text)).ToString
    End Sub

    Private Sub btnIntDivide_Click(sender As Object, e As EventArgs) Handles btnIntDivide.Click
        'input, processing, output
        lblAnswer.Text = (Convert.ToDecimal(txtNum1.Text) \ Convert.ToDecimal(txtNum2.Text)).ToString
    End Sub

    Private Sub btnModDivide_Click(sender As Object, e As EventArgs) Handles btnModDivide.Click
        'input, processing, output
        lblAnswer.Text = (Convert.ToDecimal(txtNum1.Text) Mod Convert.ToDecimal(txtNum2.Text)).ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit on click
        End
    End Sub
End Class
