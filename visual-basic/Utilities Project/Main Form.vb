' Name:         Utilities Project
' Purpose:      Display utility bills.
' Programmer:   Ian on 04/09/2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub BillsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BillsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.BillsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.UtilitiesDataSet)
            MessageBox.Show("Changes saved.", "Monthly Bills",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Monthly Bills",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UtilitiesDataSet.Bills' table. You can move, or remove it, as needed.
        Me.BillsTableAdapter.Fill(Me.UtilitiesDataSet.Bills)

    End Sub
End Class
