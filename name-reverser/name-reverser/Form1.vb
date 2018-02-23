'string manipulation demo coded by chris mccauley as a class assignment

Public Class frmNameReverser
    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        'declarations
        'get trimmed full name in lowercase
        Dim strFullName As String = txtNameIn.Text.Trim.ToLower
        'get full name length, simulate starting at 0 by subtracting 1
        Dim bytFullLength As Byte = strFullName.Length - 1
        'get first name length
        Dim bytFirstLength As Byte = strFullName.IndexOf(" ")
        'initialize result containers
        Dim strFirstReverse As String
        Dim strLastReverse As String

        'reverse and store first name
        For i = bytFirstLength To 0 Step -1
            strFirstReverse &= strFullName.Substring(i, 1)

        Next

        'reverse and store last name
        For i = bytFullLength To bytFirstLength Step -1
            strLastReverse &= strFullName.Substring(i, 1)

        Next

        'output in propercase
        lblNameOut.Text = StrConv(strFirstReverse & " " & strLastReverse, VbStrConv.ProperCase)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'click to exit
        End

    End Sub
End Class
