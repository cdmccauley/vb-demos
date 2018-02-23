'add days and hours to date to find future date and hour
'by chris mccauley

Public Class frmDateAdd
    'module declaration
    Dim mbytMonthDays() As Byte = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'declarations
        Dim lonAddDays As Long
        Dim lonAddHours As Long
        Dim lonHours As Long
        Dim lonDay As Long
        Dim bytMonth As Long
        Dim lonYear As Long
        Dim blnValidInput = True

        Try
            'assume blanks are 0 where 0 can be valid
            If txtStartHour.Text = "" Then
                txtStartHour.Text = 0
            End If

            If txtEndDay.Text = "" Then
                txtEndDay.Text = 0
            End If

            If txtEndHour.Text = "" Then
                txtEndHour.Text = 0
            End If

            'input
            lonYear = Convert.ToInt64(txtStartYear.Text)
            bytMonth = Convert.ToInt64(txtStartMonth.Text)
            lonDay = Convert.ToInt64(txtStartDay.Text)
            lonHours = Convert.ToInt64(txtStartHour.Text)
            lonAddHours = Convert.ToInt64(txtEndHour.Text)
            lonAddDays = Convert.ToInt64(txtEndDay.Text)

            'set days for starting year
            Call SetDaysInYear(lonYear)

            'test for invalid start month
            If bytMonth < 1 Or bytMonth > 12 Then
                'flag invalid
                blnValidInput = False
                'avoid exception caused by calling invalid array index on line 56 (cont.)
                'the user recieves this error but will not receive an exception error afterward
                bytMonth = 1 'can be 1-13
                'error message
                MessageBox.Show("Starting month must be in the range of 1-12.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'test for invalid start day
            If lonDay < 1 Or lonDay > mbytMonthDays(bytMonth - 1) Then
                'flag invalid
                blnValidInput = False
                'error message
                MessageBox.Show("Starting days in specified month must be in the range of 1-" _
                                & mbytMonthDays(bytMonth - 1) & ".", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'test for invalid start hour
            If lonHours < 0 Or lonHours > 23 Then
                'flag invalid
                blnValidInput = False
                'error message
                MessageBox.Show("Starting hour must be in the range of 0-23.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'test for positive add values
            If lonAddDays < 0 Or lonAddHours < 0 Then
                'flag invalid
                blnValidInput = False
                'error message
                MessageBox.Show("Days and Hours to add must be positive values.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'test if before current calendar start
            If lonYear < 1753 And bytMonth < 10 And lonDay < 14 Or lonYear < 1752 Then
                'flag invalid
                blnValidInput = False
                'error message
                MessageBox.Show("The current calendar was introduced 9/14/1752." &
                                vbNewLine & "Please use a time that is after 9/13/1752.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            'processing
            If blnValidInput = True Then
                'fully load hours
                lonHours += lonAddHours

                'derive days from hours
                Do While lonHours >= 24
                    lonHours -= 24
                    lonDay += 1
                Loop

                'fully load days
                lonDay += lonAddDays

                'derive years from months
                Do While lonDay > mbytMonthDays(bytMonth - 1)
                    lonDay -= mbytMonthDays(bytMonth - 1)
                    bytMonth += 1
                    If bytMonth > 12 Then
                        bytMonth = 1
                        lonYear += 1
                        SetDaysInYear(lonYear)
                    End If
                Loop

                'output result
                txtOutput.Text = bytMonth.ToString & "/" & lonDay.ToString & "/" &
                    lonYear.ToString & " " & lonHours.ToString.PadLeft(2, "0") & ":00"
            End If

        Catch ex As Exception
            MessageBox.Show("Input was not in correct format. Please use only positive integers.",
                            "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'procedure
    Private Sub SetDaysInYear(ByVal lonTestYear As Long)
        'leap year test, sets value for february
        If lonTestYear Mod 4 = 0 Then
            mbytMonthDays(1) = 29
            If lonTestYear / 100 = Int(lonTestYear / 100) Then
                mbytMonthDays(1) = 28
                If lonTestYear / 400 = Int(lonTestYear / 400) Then
                    mbytMonthDays(1) = 29
                End If
            End If
        Else
            mbytMonthDays(1) = 28
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear textboxes
        txtStartYear.Clear()
        txtStartMonth.Clear()
        txtStartDay.Clear()
        txtStartHour.Clear()
        txtEndDay.Clear()
        txtEndHour.Clear()
        txtOutput.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        End
    End Sub
End Class