Public Class Form1

    Dim shoLength As Short
    Dim shoWidth As Short
    Dim shoPerim As Short

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        shoLength = txtLength.Text
        shoWidth = txtWidth.Text
        shoPerim = 2 * (shoLength + shoWidth)
        lblResults.Text = shoPerim.ToString
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
