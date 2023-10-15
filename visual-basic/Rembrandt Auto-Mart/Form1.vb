Option Strict On
Option Explicit On
Option Infer Off


Public Class Form1

    Dim strEmpID As String
    Dim intNumSold As Integer = 0
    Dim intFullTime As Integer = 0
    Dim intPartTime As Integer = 0
    Dim intNewCar As Integer = 0
    Dim intUsedCar As Integer = 0

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim blnIsFullTime As Boolean = False
        Dim blnSellsNew As Boolean = False
        strEmpID = txtEmpID.Text
        Dim blnNumTest As Boolean ' = IsNumeric(txtNumSold.Text)

        blnNumTest = Integer.TryParse(txtNumSold.Text, intNumSold)
        If blnNumTest <> True Then
            MessageBox.Show("Please enter number sold as an integer value.")
        Else

            If strEmpID Like "###[Nn|Uu][Ff|Pp]" Then
                If strEmpID(3) = "N" Or strEmpID(3) = "n" Then
                    blnSellsNew = True
                End If
                If strEmpID(4) = "F" Or strEmpID(4) = "f" Then
                    blnIsFullTime = True
                End If

                If blnSellsNew Then
                    intNewCar += intNumSold
                Else
                    intUsedCar += intNumSold
                End If
                If blnIsFullTime Then
                    intFullTime += intNumSold
                Else
                    intPartTime += intNumSold
                End If

            Else
                MessageBox.Show("Please enter a valid employee ID.")
            End If

            txtNewCar.Text = intNewCar.ToString
            txtUsedCar.Text = intUsedCar.ToString
            txtFullTime.Text = intFullTime.ToString
            txtPartTime.Text = intPartTime.ToString

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
