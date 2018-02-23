Public Class Form1

    Dim intCountDown As Integer = 11

    Private Sub tmrCountDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCountDown.Tick
        If intCountDown <= 0 Then
            lblCountDown.Text = "Blast Off!"
            tmrCountDown.Enabled = False
            tmrBlastOff.Enabled = True
        Else
            intCountDown -= 1
            lblCountDown.Text = "Count Down: " & intCountDown
        End If
    End Sub

    Private Sub tmrBlastOff_Tick(sender As Object, e As EventArgs) Handles tmrBlastOff.Tick
        If picRocket.Top > -110 Then
            picRocket.Top -= 10
        ElseIf picRocket.Top <= -110 Then
            tmrBlastOff.Enabled = False
        End If

    End Sub
End Class
