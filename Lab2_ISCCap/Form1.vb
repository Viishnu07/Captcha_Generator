Public Class Form1
    Private Sub CaptchaBox1_Click(sender As Object, e As EventArgs) Handles CaptchaBox1.Click
        CaptchaBox1.RandomCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmopqrstuvwxyz1234567890"
        CaptchaBox1.CaptchaTextLength = 5
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        CaptchaBox1.Refresh()
    End Sub

    Private Sub btnSound_Click(sender As Object, e As EventArgs) Handles btnSound.Click
        Dim SAPI
        Dim captchaChar(CaptchaBox1.CaptchaTextLength - 1) As Char
        Dim captchaText As String = CaptchaBox1.CaptchaText
        Dim count As Integer
        For count = 0 To captchaText.Length - 1
            captchaChar(count) = Convert.ToChar(captchaText(count))
        Next
        Try
            SAPI = CreateObject("SAPI.spvoice")
            For count = 0 To captchaText.Length - 1
                SAPI.speak(captchaChar(count).ToString)
            Next
        Catch exc As Exception
            MessageBox.Show("An error has occurred: " & exc.Message)
        Finally
        End Try
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If txtInp.Text.ToUpper.Equals(CaptchaBox1.CaptchaText.ToUpper) Then
            MessageBox.Show("Correct!")
        Else
            MessageBox.Show("Incorrect!")
        End If
    End Sub
End Class

