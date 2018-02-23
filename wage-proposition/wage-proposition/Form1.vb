Public Class frmWageProp

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'declarations
        Dim decSalary As Decimal
        Dim decPenny As Decimal = 0.01

        'validate salary offer total
        If IsNumeric(txtSalaryOffer.Text) Then
            'clear rtb
            rtbOutput.Clear()
            'rewrite rtb headers
            rtbOutput.AppendText("Day:" & ControlChars.Tab & "Growth:")
            'calculate penny offer
            For i = 1 To 31
                decPenny = decPenny * 2
                'output penny offer growth
                rtbOutput.AppendText(vbNewLine & i.ToString & ControlChars.Tab & decPenny.ToString("c2"))
            Next
            'output penny offer total
            lblPennyTotal.Text = decPenny.ToString("c2")
            'get salary offer total
            decSalary = Convert.ToDecimal(txtSalaryOffer.Text)
            'compare salary offer to penny offer and output recommendation
            If decSalary < decPenny Then
                lblRecommend.Text = "The penny offer will earn you more money every month growing to a total of " & decPenny.ToString("c2") & "."
            ElseIf decSalary > decPenny Then
                lblRecommend.Text = "The " & decSalary.ToString("c2") & " salary will earn you more money every month."
            Else
                lblRecommend.Text = "Both salaries are the same."
            End If
        Else
            'display error
            MessageBox.Show("Input must be numerical.", "Input Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        End

    End Sub
End Class
