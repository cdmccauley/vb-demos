Public Class frmTotalAverage
    'declarations
    Dim i As Integer = 0
    Dim decArray(0) As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '
        Dim decTotal As Decimal
        Dim decAverage As Decimal

        '
        decArray(i) = txtInput.Text

        '
        rtbOutput.Clear()

        '
        For i = decArray.GetLowerBound(0) To decArray.GetUpperBound(0)
            decTotal += decArray(i)
            rtbOutput.AppendText(ControlChars.Tab & decArray(i).ToString & vbNewLine)
        Next i

        '
        decAverage = decTotal / i

        '
        rtbOutput.AppendText(vbNewLine & "Total:" & ControlChars.Tab & decTotal.ToString & vbNewLine _
                             & "Average:" & ControlChars.Tab & decAverage.ToString)

        '
        ReDim Preserve decArray(decArray.GetUpperBound(0) + 1)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        '
        i = 0

        '
        ReDim decArray(0)

        '
        rtbOutput.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '
        End

    End Sub
End Class
