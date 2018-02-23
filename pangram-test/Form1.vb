'test a string to determine if it is a pangram by chris mccauley.
'
'assignment instructions require the use of: array with alphabet in 
'initialized list, another array that will be updated in parallel 
'With alphabet array, a flag variable, and a test using the variable 
'to determine output.

Public Class frmPangramTest
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'declarations
        Dim strAlphabet() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim intCounters(25) As Integer
        Dim blnIsPangram As Boolean = True
        Dim strMissing As String

        For i = 0 To txtInput.Text.Length - 1
            'get character of string
            Select Case txtInput.Text.ToUpper.Substring(i, 1)
                'test for letter
                Case "A" To "Z"
                    For j = strAlphabet.GetLowerBound(0) To strAlphabet.GetUpperBound(0)
                        If txtInput.Text.ToUpper.Substring(i, 1) = strAlphabet(j) Then
                            'is a letter then increment counter
                            intCounters(j) += 1
                        End If
                    Next j
                Case Else
                    'ignore all other characters
            End Select
        Next i

        'set required flag variable
        For k = intCounters.GetLowerBound(0) To intCounters.GetUpperBound(0)
            If intCounters(k) = 0 Then
                'record missing letters
                strMissing += strAlphabet(k)
                blnIsPangram = False
            End If
        Next k

        'output results using required flag variable
        If blnIsPangram = True Then
            lblOutput.Text = "This is a pangram!"
        Else
            lblOutput.Text = "This is not a pangram." & vbNewLine & "It is missing "
            For i = 0 To strMissing.Length - 1
                lblOutput.Text += strMissing(i) & " "
            Next i
            lblOutput.Refresh()

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        End

    End Sub
End Class
