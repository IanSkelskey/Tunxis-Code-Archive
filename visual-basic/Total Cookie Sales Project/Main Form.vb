' Name:         Total Cookie Sales Project
' Purpose:      Display the total number of boxes of each cookie type sold.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CookieSalesDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.CookieSalesDataSet.Sales)

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intChocolateTotal As Integer
        Dim intPeanutTotal As Integer
        Dim intPecanTotal As Integer
        For Each row As CookieSalesDataSet.SalesRow In CookieSalesDataSet.Sales
            intChocolateTotal += row.Chocolate_Chip
            intPeanutTotal += row.Peanut_Butter
            intPecanTotal += row.Pecan_Sandies
        Next row
        lblChocolate.Text = intChocolateTotal.ToString
        lblPeanut.Text = intPecanTotal.ToString
        lblPecan.Text = intPecanTotal.ToString
    End Sub
End Class
