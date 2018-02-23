Public Class frmFunForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        'blue background
        Me.BackColor = Color.Blue
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        'red background
        Me.BackColor = Color.Red
    End Sub

    Private Sub btnGrow_Click(sender As Object, e As EventArgs) Handles btnGrow.Click
        'grow size
        Me.Width = Me.Width + 25
        Me.Height = Me.Height + 25
    End Sub

    Private Sub btnShrink_Click(sender As Object, e As EventArgs) Handles btnShrink.Click
        'shrink size
        Me.Width = Me.Width - 25
        Me.Height = Me.Height - 25
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        'hide buttons/show show buttons
        btnRed.Visible = False
        btnBlue.Visible = False
        btnGrow.Visible = False
        btnShrink.Visible = False
        btnHide.Visible = False
        btnShow.Visible = True
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'show buttons/hide show button
        btnRed.Visible = True
        btnBlue.Visible = True
        btnGrow.Visible = True
        btnShrink.Visible = True
        btnHide.Visible = True
        btnShow.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit
        End

    End Sub
End Class
