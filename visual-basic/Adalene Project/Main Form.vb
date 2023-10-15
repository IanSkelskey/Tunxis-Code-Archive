' Name:         Adalene Project
' Purpose:      Select and view records.
' Programmer:   Ian Skelskey on 04/23/2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AdaleneDataSet.FranchiseSales' table. You can move, or remove it, as needed.
        Me.FranchiseSalesTableAdapter.Fill(Me.AdaleneDataSet.FranchiseSales)
        'TODO: This line of code loads data into the 'AdaleneDataSet.AllSales' table. You can move, or remove it, as needed.
        Me.AllSalesTableAdapter.Fill(Me.AdaleneDataSet.AllSales)
        'TODO: This line of code loads data into the 'AdaleneDataSet.CompanySales' table. You can move, or remove it, as needed.
        Me.CompanySalesTableAdapter.Fill(Me.AdaleneDataSet.CompanySales)
        'TODO: This line of code loads data into the 'AdaleneDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.AdaleneDataSet.Stores)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        If radCompany.Checked Then
            StoresTableAdapter.FillByOwnership(AdaleneDataSet.Stores, "C")
        ElseIf radFranchisee.Checked Then
            StoresTableAdapter.FillByOwnership(AdaleneDataSet.Stores, "F")
        Else
            StoresTableAdapter.Fill(AdaleneDataSet.Stores)
        End If
    End Sub
End Class
