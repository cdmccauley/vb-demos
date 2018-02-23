'test a string for a palindrome by chris mccauley

Public Class frmPalindromeTester
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'declarations
        Dim strCleanString As String
        Dim strReverseClean As String

        'clean input
        For i = 0 To txtInput.Text.Length - 1
            Select Case txtInput.Text.ToUpper.Substring(i, 1)
                Case "A" To "Z"
                    'build clean string
                    strCleanString &= txtInput.Text.ToUpper.Substring(i, 1)
                Case Else
                    'ignore all other characters
            End Select

        Next

        'build reverse of clean string
        For j = strCleanString.Length - 1 To 0 Step -1
            strReverseClean &= strCleanString.Substring(j, 1)

        Next

        'compare clean to reverse clean and output result
        Select Case strCleanString
            Case = strReverseClean
                lblOutput.Text = "This is a palindrome."
            Case Else
                lblOutput.Text = "This is not a palindrome."

        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'exit program
        End

    End Sub
End Class
