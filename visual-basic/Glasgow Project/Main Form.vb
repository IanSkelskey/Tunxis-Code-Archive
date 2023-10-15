Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain

    'Constants
    Const dblBASIC_SINGLE As Double = 50
    Const dblBASIC_FAMILY As Double = 90
    Const dblSINGLE_GOLF As Double = 25
    Const dblSINGLE_TENNIS As Double = 30
    Const dblSINGLE_RACQUETBALL As Double = 20
    Const dblFAMILY_GOLF As Double = 35
    Const dblFAMILY_TENNIS As Double = 50
    Const dblFAMILY_RACQUETBALL As Double = 30

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblBasicCharge, dblAdditionalCharge As Double

        If radSingle.Checked Then
            'If Single Then membership
            dblBasicCharge = dblBASIC_SINGLE
            If chkGolf.Checked Then
                dblAdditionalCharge += dblSINGLE_GOLF
            End If
            If chkTennis.Checked Then
                dblAdditionalCharge += dblSINGLE_TENNIS
            End If
            If chkRacquetball.Checked Then
                dblAdditionalCharge += dblSINGLE_RACQUETBALL
            End If

        Else
            'If family Then membership
            dblBasicCharge = dblBASIC_FAMILY
            If chkGolf.Checked Then
                dblAdditionalCharge += dblFAMILY_GOLF
            End If
            If chkTennis.Checked Then
                dblAdditionalCharge += dblFAMILY_TENNIS
            End If
            If chkRacquetball.Checked Then
                dblAdditionalCharge += dblFAMILY_RACQUETBALL
            End If

        End If
        Dim Member As New Dues(dblBasicCharge, dblAdditionalCharge)
        txtBasicFee.Text = Member.BasicCharge.ToString("C2")
        txtAdditional.Text = Member.AdditionalCharge.ToString("C2")
        txtMothlyDues.Text = Member.GetMonthlyDues.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radSingle_CheckedChanged(sender As Object, e As EventArgs) Handles radSingle.CheckedChanged, chkGolf.CheckedChanged, chkTennis.CheckedChanged, chkRacquetball.CheckedChanged
        txtBasicFee.Clear()
        txtAdditional.Clear()
        txtMothlyDues.Clear()
    End Sub
End Class
