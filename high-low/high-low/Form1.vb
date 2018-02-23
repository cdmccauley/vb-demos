'the high-low game
'coded by chris mccauley
'program idea given as an assignment, davis applied technology college, software development
'guess if a randomly generated number in the range of 1-14 will be higher or lower than 7
'7 always loses double points

Public Class frmHighLow
    'declarations
    Dim mlonScore As Long = 1000

    Private Sub frmHighLow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get random seed
        Randomize()

    End Sub

    Private Sub btnHigh_Click(sender As Object, e As EventArgs) Handles btnHigh.Click
        'declarations
        Dim lonRisk As Long
        Dim bytNumber As Byte

        'validate input
        'confirm input not string
        If IsNumeric(txtRisk.Text) = False Then
            MessageBox.Show("Risk must be a whole number.", "Invalid Entry", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)
            'confirm input is whole number
        ElseIf Int(txtRisk.Text) <> txtRisk.Text Then
            MessageBox.Show("Risk must be a whole number.", "Invalid Entry", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)
            'confirm input does not exceed score
        ElseIf Convert.ToInt16(txtRisk.Text) > mlonScore Or Convert.ToInt16(txtRisk.Text) < 0 Then
            MessageBox.Show("Risk must be a value greater than 0 and less than your current" _
                & " point total.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'get input
            lonRisk = Convert.ToInt16(txtRisk.Text)
            'generate number
            bytNumber = Int(Rnd() * 13 + 1)
            'display number
            lblSecret.Text = "The secret number is " & bytNumber.ToString & "!"
            'test prediction
            If bytNumber > 7 Then
                'grant points
                mlonScore = mlonScore + lonRisk
                'update message
                lblStatus.Text = "You win! You now have " & mlonScore.ToString & " points!"
            Else
                'test for double loss
                If bytNumber = 7 Then
                    'remove double points
                    mlonScore = mlonScore - (lonRisk * 2)
                Else
                    'remove points
                    mlonScore = mlonScore - lonRisk
                End If
                'test for ability to risk
                If mlonScore <= 0 Then
                    'update message
                    lblStatus.Text = "Game Over."
                    'disable game
                    btnHigh.Visible = False
                    btnLow.Visible = False
                    lblRules.Visible = False
                    txtRisk.Visible = False
                    lblChoice.Visible = False
                    lblSecret.Visible = False
                Else
                    'update message
                    lblStatus.Text = "You lose, you now have " & mlonScore.ToString & " points."
                End If
            End If
        End If

    End Sub

    Private Sub btnLow_Click(sender As Object, e As EventArgs) Handles btnLow.Click
        'declarations
        Dim lonRisk As Long
        Dim bytNumber As Byte

        'validate input
        'confirm input not string
        If IsNumeric(txtRisk.Text) = False Then
            MessageBox.Show("Risk must be a whole number.", "Invalid Entry", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)
            'confirm input is whole number
        ElseIf Int(txtRisk.Text) <> txtRisk.Text Then
            MessageBox.Show("Risk must be a whole number.", "Invalid Entry", MessageBoxButtons.OK,
                            MessageBoxIcon.Stop)
            'confirm input does not exceed score
        ElseIf Convert.ToInt16(txtRisk.Text) > mlonScore Or Convert.ToInt16(txtRisk.Text) < 0 Then
            MessageBox.Show("Risk must be a value greater than 0 and less than your current" _
                & " point total.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            'get input
            lonRisk = Convert.ToInt64(txtRisk.Text)
            'generate number
            bytNumber = Int(Rnd() * 13 + 1)
            'display number
            lblSecret.Text = "The secret number is " & bytNumber.ToString & "!"
            'test prediction
            If bytNumber < 7 Then
                'grant points
                mlonScore = mlonScore + lonRisk
                'update message
                lblStatus.Text = "You win! You now have " & mlonScore.ToString & " points!"
            Else
                'test for double loss
                If bytNumber = 7 Then
                    'remove double points
                    mlonScore = mlonScore - (lonRisk * 2)
                Else
                    'remove points
                    mlonScore = mlonScore - lonRisk
                End If
                'test for ability to risk
                If mlonScore <= 0 Then
                    'update message
                    lblStatus.Text = "Game Over."
                    'disable game
                    btnHigh.Visible = False
                    btnLow.Visible = False
                    lblRules.Visible = False
                    txtRisk.Visible = False
                    lblChoice.Visible = False
                    lblSecret.Visible = False
                Else
                    'update message
                    lblStatus.Text = "You lose, you now have " & mlonScore.ToString & " points."
                End If
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'end on click
        End

    End Sub

End Class
