Public Class frmEchoChamber
    Private Sub btnGreetings_Click(sender As Object, e As EventArgs) Handles _
        btnGreetings.Click
        'declarations
        Dim strFirst As String
        Dim strLast As String

        'output, initial message
        rtbOutput.AppendText("Greetings!" & vbNewLine)

        'input, first and last name
        strFirst = InputBox("Please enter your first name.", "First Name")
        MessageBox.Show("Your first name is " & strFirst & "?", "First Name",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'chris mccauley: visual studio is removing some of the continuation _
        'characters that i am placing in my code.
        strLast = InputBox("Please enter your last name.", "Last Name")
        MessageBox.Show("Your last name is " & strLast & "?", "Last Name",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

        'output, first and last name
        rtbOutput.AppendText("Your full name is " & strFirst & " " & strLast _
                             & "." & vbNewLine)

    End Sub

    Private Sub btnHobby_Click(sender As Object, e As EventArgs) Handles _
        btnHobby.Click
        'declarations
        Dim strHobby As String

        'input, hobby
        strHobby = InputBox("Please enter your hobby.", "Hobby")
        MessageBox.Show("Your hobby is " & strHobby & "?", "Hobby",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Hand)

        'output, hobby
        rtbOutput.AppendText("Your hobby is " & strHobby & "." & vbNewLine)

    End Sub

    Private Sub btnFood_Click(sender As Object, e As EventArgs) Handles _
        btnFood.Click
        'declarations
        Dim strFood As String

        'input, favorite food
        strFood = InputBox("Please enter your favorite food.", "Favorite Food")
        MessageBox.Show("Your favorite food is " & strFood & "?", "Favorite Food",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

        'output, favorite food
        rtbOutput.AppendText("Your favorite food is " & strFood & "." & vbNewLine)

    End Sub

    Private Sub btnSeason_Click(sender As Object, e As EventArgs) Handles btnSeason.Click
        'declarations
        Dim strSeason As String

        'input, favorite season
        strSeason = InputBox("Please enter your favorite season.", "Season")
        MessageBox.Show("Your favorite season is " & strSeason & "?", "Season",
                        MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.None)

        'output, hobby
        rtbOutput.AppendText("Your favorite season is " & strSeason & "." & vbNewLine)

    End Sub
End Class
