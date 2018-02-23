Public Class frmRottenPotatoes
    'declarations
    Dim mshoTotalRating As Short
    Dim mshoTotalSubmits As Short
    Dim mdecAverageRating As Decimal

    Private Sub btnRate_Click(sender As Object, e As EventArgs) Handles btnRate.Click
        'input rating
        mshoTotalRating = mshoTotalRating + nudRating.Value
        mshoTotalSubmits = mshoTotalSubmits + 1

        'input description, output review
        lblReview.Text = "Thank you for rating this movie " & txtDescription.Text.ToUpper _
            & " with " & nudRating.Value & " stars!"

    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        'processing ratings, output rating average
        lblAverage.Text = "The average rating for this movie is " &
            (mshoTotalRating / mshoTotalSubmits).ToString("n2")

    End Sub
End Class
