Public Class frmStringManipulator
    Private Sub btnToUpper_Click(sender As Object, e As EventArgs) Handles btnToUpper.Click
        'output string in uppercase
        txtOutput.Text = txtInput.Text.ToUpper

    End Sub

    Private Sub btnToLower_Click(sender As Object, e As EventArgs) Handles btnToLower.Click
        'output string in lowercase
        txtOutput.Text = txtInput.Text.ToLower

    End Sub

    Private Sub btnLength_Click(sender As Object, e As EventArgs) Handles btnLength.Click
        'output string length
        txtOutput.Text = txtInput.Text.Length

    End Sub

    Private Sub btnPadLeft_Click(sender As Object, e As EventArgs) Handles btnPadLeft.Click
        'pad left with space till string is 20 characters, add @ to start and end
        txtOutput.Text = "@" & txtInput.Text.PadLeft(20) & "@"

    End Sub

    Private Sub btnTrim_Click(sender As Object, e As EventArgs) Handles btnTrim.Click
        'trim spaces from beginning and end of string
        txtOutput.Text = txtInput.Text.Trim

    End Sub

    Private Sub btnPadRight_Click(sender As Object, e As EventArgs) Handles btnPadRight.Click
        'pad right with * till string is 20 characters, add @ to start and end
        txtOutput.Text = "@" & txtInput.Text.PadRight(20, "*") & "@"

    End Sub

    Private Sub btnSpaceIndex_Click(sender As Object, e As EventArgs) Handles btnSpaceIndex.Click
        'split string from before first space
        txtOutput.Text = txtInput.Text.Substring(txtInput.Text.IndexOf(" "))

    End Sub

    Private Sub btnSubstring_Click(sender As Object, e As EventArgs) Handles btnSubstring.Click
        'get 5 character substring from position 5 of string
        txtOutput.Text = txtInput.Text.Substring(5, 5)

    End Sub

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        'clear output
        txtOutput.Text = ""

        'reverse string
        For i = txtInput.Text.Length - 1 To 0 Step -1
            txtOutput.Text &= txtInput.Text.Substring(i, 1)

        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit program
        End

    End Sub
End Class
