Public Class Form1
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        Dim strReversed As String
        strReversed = StrReverse(txtPalindrome.Text)
        If strReversed.ToLower = txtPalindrome.Text.ToLower Then
            MessageBox.Show("Yes!")
        Else
            MessageBox.Show("No!")
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
