Public Class frmStudentScores
    'declarations
    Dim strStudent() As String = {"Jon", "Sansa", "Arya", "Bran", "Chris"}
    Dim decScore() As Decimal = {99.3, 89.1, 98.5, 92.1, 98.57}
    Dim strSwap As String
    Dim decSwap As Decimal

    Private Sub btnStudentAsc_Click(sender As Object, e As EventArgs) Handles btnStudentAsc.Click
        'prep rtbs
        ClearRTBs()

        'start loops for counters and pass comparison values to procedure for sorting
        For i = strStudent.GetLowerBound(0) To strStudent.GetUpperBound(0) - 1
            For j = strStudent.GetLowerBound(0) To strStudent.GetUpperBound(0) - 1
                SortStudent(strStudent(j), strStudent(j + 1), j)
            Next j
        Next i

        'display output
        UpdateRTBs()

    End Sub

    Private Sub btnScoreAsc_Click(sender As Object, e As EventArgs) Handles btnScoreAsc.Click
        'prep rtbs
        ClearRTBs()

        For i = decScore.GetLowerBound(0) To decScore.GetUpperBound(0) - 1
            For j = decScore.GetLowerBound(0) To decScore.GetUpperBound(0) - 1
                SortScore(decScore(j), decScore(j + 1), j)
            Next j
        Next i

        'display output
        UpdateRTBs()

    End Sub

    Private Sub btnStudentDes_Click(sender As Object, e As EventArgs) Handles btnStudentDes.Click
        'prep rtbs
        ClearRTBs()

        For i = strStudent.GetLowerBound(0) To strStudent.GetUpperBound(0) - 1
            For j = strStudent.GetLowerBound(0) To strStudent.GetUpperBound(0) - 1
                SortStudent(strStudent(j + 1), strStudent(j), j)
            Next j
        Next i

        'display output
        UpdateRTBs()

    End Sub

    Private Sub btnScoreDes_Click(sender As Object, e As EventArgs) Handles btnScoreDes.Click
        'prep rtbs
        ClearRTBs()

        For i = decScore.GetLowerBound(0) To decScore.GetUpperBound(0) - 1
            For j = decScore.GetLowerBound(0) To decScore.GetUpperBound(0) - 1
                SortScore(decScore(j + 1), decScore(j), j)
            Next j
        Next i

        'display output
        UpdateRTBs()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        End

    End Sub

    'procedures
    Private Sub ClearRTBs()
        rtbStudents.Clear()
        rtbScores.Clear()

    End Sub

    Private Sub SortStudent(ByVal strFirst As String, ByVal strSecond As String, ByVal j As Byte)
        If strFirst > strSecond Then
            'swap student1 with student2 and then student1 score with student2 score
            strSwap = strStudent(j)
            strStudent(j) = strStudent(j + 1)
            strStudent(j + 1) = strSwap
            decSwap = decScore(j)
            decScore(j) = decScore(j + 1)
            decScore(j + 1) = decSwap
        End If

    End Sub

    Private Sub SortScore(ByVal decFirst As Decimal, ByVal decSecond As Decimal, ByVal j As Byte)
        If decFirst > decSecond Then
            'swap student1 score with student2 score and then student1 with student2
            decSwap = decScore(j)
            decScore(j) = decScore(j + 1)
            decScore(j + 1) = decSwap
            strSwap = strStudent(j)
            strStudent(j) = strStudent(j + 1)
            strStudent(j + 1) = strSwap
        End If

    End Sub

    Private Sub UpdateRTBs()
        For i = strStudent.GetLowerBound(0) To strStudent.GetUpperBound(0)
            rtbStudents.AppendText(strStudent(i) & vbNewLine)
            rtbScores.AppendText(decScore(i) & vbNewLine)
        Next i

    End Sub

End Class
