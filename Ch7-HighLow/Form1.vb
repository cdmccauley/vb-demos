Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    'declarations
    Dim intTotalPoints As Integer = 1000
    Dim intRisk As Integer
    Dim strCardType As String   'values can be "high", "low", or "seven"
    Dim strStatus As String     'values can be "win", "lose", or "seven"

    Private Sub btnHigh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHigh.Click
        'get number of points to risk, check if valid
        intRisk = Val(txtRisk.Text)
        If GoodRisk(intRisk) Then   'enough points so play
            'get type of new card, is it high, low, or seven?
            strCardType = GetCard()
            'check if card is in high range, as guessed
            If strCardType = "high" Then
                strStatus = "win"
            ElseIf strCardType = "low" Then
                strStatus = "lose"
            Else
                strStatus = strCardType   'strCardType was seven, same as strStatus
            End If
            'fix the points based on status and risk, and display the outcome
            FixPoints(intRisk, strStatus)
            'check if game is over
            IsGameOver()
        Else
            'not enough points to play, let user know
            lblResult.Text = "Check your risk, try again"
        End If
    End Sub

    Function GoodRisk(ByVal intRisk As Integer) As Boolean
        'check if the risk is within the bounds of 0 and the total points
        If intRisk >= 0 And intRisk <= intTotalPoints Then
            'if it is within the range, return "true", otherwise, return "false"
            Return True
        Else
            Return False
        End If

    End Function
    Function GetCard() As String
        'create the new card with random number and display it,
        'which simulates flipping the card over
        Dim bytNumber As Byte = Int(Rnd() * 13 + 1)
        lblCard.Text = bytNumber.ToString
        'determine if card is "high", "low", or "seven" and return that result
        If bytNumber < 7 Then
            Return "low"
        ElseIf bytNumber > 7 Then
            Return "high"
        Else
            Return "seven"
        End If

    End Function
    Sub FixPoints(ByVal intRisk As Integer, ByVal strStatus As String)
        'change total points based on status of "win", "lose", or "seven"
        'display new total points
        'display message about result: in lblResult, display:
        ' "You win!", or "You lose", or "Sorry, you lose double"
        If strStatus = "win" Then
            intTotalPoints = intTotalPoints + intRisk
            lblResult.Text = "You win!"
        ElseIf strStatus = "lose" Then
            intTotalPoints = intTotalPoints - intRisk
            lblResult.Text = "You lose"
        Else
            intTotalPoints = intTotalPoints - (intRisk * 2)
            lblResult.Text = "Sorry, you lose double"
        End If
        lblTotalPoints.Text = "Total Points: " & intTotalPoints.ToString

    End Sub
    Sub IsGameOver()
        'check if game is over
        If intTotalPoints <= 0 Then
            'if it is, disable buttons and display message
            btnHigh.Enabled = False
            btnLow.Enabled = False
            lblResult.Text = "Game Over."
        End If

    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        'get number of points to risk, check if valid
        intRisk = Val(txtRisk.Text)
        If GoodRisk(intRisk) Then   'enough points so play
            'get type of new card, is it high, low, or seven?
            strCardType = GetCard()
            'check if card is in high range, as guessed
            If strCardType = "low" Then
                strStatus = "win"
            ElseIf strCardType = "high" Then
                strStatus = "lose"
            Else
                strStatus = strCardType   'strCardType was seven, same as strStatus
            End If
            'fix the points based on status and risk, and display the outcome
            FixPoints(intRisk, strStatus)
            'check if game is over
            IsGameOver()
        Else
            'not enough points to play, let user know
            lblResult.Text = "Check your risk, try again"
        End If
    End Sub
End Class
