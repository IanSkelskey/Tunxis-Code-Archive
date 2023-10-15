' Name:         Colors Project
' Purpose:      Display the Spanish names for the colors.
' Programmer:   Ian Skelskey on 02/01/2021
Public Class frmMain
    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        ' Display the Spanish word for blue.
        ' Comments are started with a single quote.
        If radEnglish.Checked Then
            lblSpanish.Text = "Azul"
        Else
            lblSpanish.Text = "Blue"
        End If

        imgColor.Image = Image.FromFile("C:\Users\Ian A Skelskey\Desktop\Colors Solution\Colors Project\azul.png")

    End Sub

    Private Sub btnGreen_Click(sender As Object, e As EventArgs) Handles btnGreen.Click
        ' Display the Spanish word for green.

        lblSpanish.Text = "Verde"
        imgColor.Image = Image.FromFile("C:\Users\Ian A Skelskey\Desktop\Colors Solution\Colors Project\verde.png")
    End Sub

    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        ' Display the Spanish word for red.

        lblSpanish.Text = "Rojo"  ' Double quotes are for string literals (which are sets of characters)
        imgColor.Image = Image.FromFile("C:\Users\Ian A Skelskey\Desktop\Colors Solution\Colors Project\rojo.png")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radEspanol_CheckedChanged(sender As Object, e As EventArgs) Handles radEspanol.CheckedChanged
        If radEspanol.Checked Then
            btnBlue.Text = "&Azul"
            btnGreen.Text = "&Verde"
            btnRed.Text = "&Rojo"
        Else
            btnBlue.Text = "&Blue"
            btnGreen.Text = "&Green"
            btnRed.Text = "&Red"
        End If


    End Sub
End Class
