Public Class frmFlying

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End

    End Sub

    Private Sub btnBiplane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBiplane.Click
        'hide status
        lblDone.Visible = False

        'Fly the biplane from left to right
        Dim i As Double
        For i = 1 To 1.01 Step 0.00001
            picBiplane.Left += i
        Next i

        'disable button, show status
        btnBiplane.Enabled = False
        lblDone.Visible = True

    End Sub

    Private Sub btnPlaneII_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaneII.Click
        'hide status
        lblDone.Visible = False

        'Fly the plane from right to left
        Dim i As Double
        For i = 1 To 1.01 Step 0.00001
            picPlaneII.Left -= i
        Next i

        'disable button, show status
        btnPlaneII.Enabled = False
        lblDone.Visible = True

    End Sub

    Private Sub btnBalloon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBalloon.Click
        'hide status
        lblDone.Visible = False

        'Make the balloon fly up
        Dim i As Double
        For i = 1 To 1.01 Step 0.00001
            picBalloon.Top -= i
        Next i

        'disable button, show status
        btnBalloon.Enabled = False
        lblDone.Visible = True

    End Sub

    Private Sub btnParachute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParachute.Click
        'hide status
        lblDone.Visible = False

        'Make the skydiver descend
        Dim i As Double
        For i = 1 To 1.01 Step 0.00001
            picParachute.Top += i
        Next i

        'disable button, show status
        btnParachute.Enabled = False
        lblDone.Visible = True

    End Sub

    Private Sub btnKite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKite.Click
        'hide status
        lblDone.Visible = False

        'Make the kite start near the bottom right and travel toward the top left
        Dim i As Double
        For i = 1 To 1.01 Step 0.00001
            picKite.Top -= i
            picKite.Left -= i
        Next i

        'disable button, show status
        btnKite.Enabled = False
        lblDone.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAirshow.Click
        'hide status
        lblDone.Visible = False

        'put on an airshow
        Dim i As Double
        For i = 1 To 1.01 Step 0.00001
            picBiplane.Left += i
            picPlaneII.Left -= i
            picBalloon.Top -= i
            picParachute.Top += i
            picKite.Top -= i
            picKite.Left -= i
        Next i

        'disable buttons, show status
        btnAirshow.Enabled = False
        btnBiplane.Enabled = False
        btnPlaneII.Enabled = False
        btnBalloon.Enabled = False
        btnParachute.Enabled = False
        btnKite.Enabled = False
        lblDone.Visible = True

    End Sub
End Class
