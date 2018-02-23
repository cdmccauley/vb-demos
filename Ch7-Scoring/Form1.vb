Public Class Form1
    'declarations
    Dim mintScore As Integer = 100

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        'declarations
        Dim intNewPoints As Integer
        'get the data
        intNewPoints = Convert.ToInt16(txtPoints.Text)
        'do the work and display results
        Call FixScore(intNewPoints, mintScore)
    End Sub

    Private Sub FixScore(ByVal intPoints As Integer, ByRef intTotal As Integer)
        'do the work
        intTotal += intPoints
        'display results
        lblScore.Text = intTotal.ToString
    End Sub
End Class
