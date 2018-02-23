'simulate rolling a six-sided die until it results in a specified number

Public Class frmRollUntil
    Private Sub frmRollUntil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'seed rnd
        Randomize()

    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'declarations
        Dim bytNum As Byte
        Dim lonNum As Long
        Dim bytRoll As Byte

        'validate input as numeric
        If Not IsNumeric(txtNumber.Text) Then
            'error message
            MessageBox.Show("Input must be a whole number in the range of 1 to 6", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            'validate input as integer and within range
        ElseIf txtNumber.Text = Int(txtNumber.Text) And txtNumber.Text >= 1 And txtNumber.Text <= 6 Then
            'clear rtb
            rtbOutput.Clear()
            'write rtb headers
            rtbOutput.AppendText("Roll:" & ControlChars.Tab & "Result:")
            'get input
            bytNum = Convert.ToByte(txtNumber.Text)
            'roll until match
            Do
                'count rolls
                lonNum = lonNum + 1
                'roll die
                bytRoll = Int(Rnd() * 6 + 1)
                'display results
                rtbOutput.AppendText(vbNewLine & lonNum & ControlChars.Tab & bytRoll)
                'test roll
            Loop Until bytRoll = bytNum
            'display total rolls
            lblRollTotal.Text = "It took " & lonNum.ToString & " rolls to roll a " & bytNum.ToString & "."
        Else
            'error message
            MessageBox.Show("Input must be a whole number in the range of 1 to 6", "Input Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        End

    End Sub
End Class
