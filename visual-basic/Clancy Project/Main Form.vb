Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClancyDataSet.Stores' table. You can move, or remove it, as needed.
        Me.StoresTableAdapter.Fill(Me.ClancyDataSet.Stores)

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblCompanySales, dblFranchiseeSales, dblTotalSales As Double
        For Each row As ClancyDataSet.StoresRow In ClancyDataSet.Stores.Rows
            If row.Ownership = "C" Then
                dblCompanySales += row.Sales
            Else
                dblFranchiseeSales += row.Sales
            End If
        Next
        dblTotalSales = dblCompanySales + dblFranchiseeSales
        lblCompanySales.Text = dblCompanySales.ToString("C0")
        lblFranchiseeSales.Text = dblFranchiseeSales.ToString("C0")
        lblTotalSales.Text = dblTotalSales.ToString("C0")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
