Public Class frmBugSpray
    Private Sub txtCans_TextChanged(sender As Object, e As EventArgs) Handles txtCans.TextChanged
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declarations
        Dim shoCans As Short
        Const decPrice As Decimal = 3.25
        Dim decTotal As Decimal
        'shoCans gets input
        shoCans = txtCans.Text
        'decTotal gets processed output
        decTotal = shoCans * decPrice
        'lblPrice gets decTotal as string
        lblPrice.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit on click
        End
    End Sub
End Class
