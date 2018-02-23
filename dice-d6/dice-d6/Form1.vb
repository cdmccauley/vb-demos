'simulate the rolls of a six-sided die by Chris McCauley

Public Class frmD6

    Private Sub frmD6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'seed random numbers
        Randomize()

    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        'declarations
        Dim bytRolls As Byte
        Dim bytResult As Byte
        Dim bytOne As Byte
        Dim bytTwo As Byte
        Dim bytThree As Byte
        Dim bytFour As Byte
        Dim bytFive As Byte
        Dim bytSix As Byte

        'validation
        If Not IsNumeric(txtRoll.Text) Then
            'error message
            MessageBox.Show("Input must be a whole number between 1 and 255.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf txtRoll.Text = Int(txtRoll.Text) And txtRoll.Text > 0 And txtRoll.Text < 256 Then
            'clear rtb
            rtbRoll.Clear()
            'write rtb header
            rtbRoll.AppendText("Roll Result:" & ControlChars.Tab & "Times Rolled:" & vbNewLine)
            'get number of rolls
            bytRolls = Convert.ToByte(txtRoll.Text)
            'generate and count rolls
            For i = 1 To bytRolls
                'generate rolls
                bytResult = Int(Rnd() * 6 + 1)
                'count rolls
                'chris mccauley: if my thinking is correct this will only run up to _
                '4 tests no matter the value instead of up to 6 tests therefore _
                'reducing the number of tests overall
                If bytResult < 4 Then
                    If bytResult < 2 Then
                        bytOne += 1
                    ElseIf bytResult > 2 Then
                        bytThree += 1
                    Else
                        bytTwo += 1
                    End If
                ElseIf bytResult > 3 Then
                    If bytResult < 5 Then
                        bytFour += 1
                    ElseIf bytResult > 5 Then
                        bytSix += 1
                    Else
                        bytFive += 1
                    End If
                End If
            Next
            'output results
            rtbRoll.AppendText("1:" & ControlChars.Tab & ControlChars.Tab & bytOne.ToString & vbNewLine &
                               "2:" & ControlChars.Tab & ControlChars.Tab & bytTwo.ToString & vbNewLine &
                               "3:" & ControlChars.Tab & ControlChars.Tab & bytThree.ToString & vbNewLine &
                               "4:" & ControlChars.Tab & ControlChars.Tab & bytFour.ToString & vbNewLine &
                               "5:" & ControlChars.Tab & ControlChars.Tab & bytFive.ToString & vbNewLine &
                               "6:" & ControlChars.Tab & ControlChars.Tab & bytSix.ToString)
        Else
            'error message
            MessageBox.Show("Input must be a whole number between 1 and 255.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        End

    End Sub
End Class
