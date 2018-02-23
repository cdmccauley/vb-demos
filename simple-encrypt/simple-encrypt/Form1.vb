'encrypt a string with "substitution" encryption and/or "transposition" encryption by chris mccauley
'assignment for software development fundamentals class

Public Class frmSimpleEncrypt

    Private Sub btnSubstitue_Click(sender As Object, e As EventArgs) Handles btnSubstitue.Click
        'declarations
        Dim strSubString As String

        For i = 0 To txtOriginal.Text.Length - 1
            'encrypt string
            EncryptString(i, strSubString)
        Next
        'display substitution encryption
        txtSubstitute.Text = strSubString

    End Sub

    Private Sub btnTranspose_Click(sender As Object, e As EventArgs) Handles btnTranspose.Click
        'declarations
        Dim strSubString As String
        Dim strFirst As String
        Dim strSecond As String

        For i = 0 To txtOriginal.Text.Length - 1
            'encrypt string
            EncryptString(i, strSubString)
            'split encrypted string
            If i Mod 2 = 0 Then
                strFirst &= strSubString.Substring(i, 1)
            Else
                strSecond &= strSubString.Substring(i, 1)
            End If
        Next
        'display transposition encryption
        txtTranspose.Text = strFirst & vbNewLine & strSecond

    End Sub

    Private Sub EncryptString(ByVal i As Integer, ByRef strSubString As String)
        Dim bytEncryptLevel As Byte = trbLevel.Value
        Dim bytOverflow As Byte = 26 - bytEncryptLevel

        'the following constants are ascii codes for a-z and A-Z
        Select Case Asc(txtOriginal.Text.Substring(i, 1))
            Case 97 To 97 + bytOverflow - 1, 65 To 65 + bytOverflow - 1
                'low range encrypt
                strSubString &= Chr(Asc(txtOriginal.Text.Substring(i, 1)) + bytEncryptLevel)
            Case 97 + bytOverflow To 122, 65 + bytOverflow To 90
                'high range encrypt
                strSubString &= Chr(Asc(txtOriginal.Text.Substring(i, 1)) - bytOverflow)
            Case Else
                'leave all other characters
                strSubString &= txtOriginal.Text.Substring(i, 1)
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close program
        End

    End Sub
End Class
