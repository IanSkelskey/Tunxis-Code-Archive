Public Class frmMain
    'Defined constants to store the cost of each cable package and additional feature.
    'Constants are helpful when a value could change. 
    Const BASIC_CHARGE As Double = 24.99
    Const SILVER_CHARGE As Double = 42.99
    Const GOLD_CHARGE As Double = 84.99
    Const DIAMOND_CHARGE As Double = 99.99
    'If the cost of any package or feature is changed you only need to change 
    'it here instead of everywhere in your code.
    Const CINEMA_CHARGE As Double = 9.5
    Const HBI_CHARGE As Double = 9.5
    Const SHOW_CHARGE As Double = 10.5
    Const LOCAL_CHARGE As Double = 6.0

    'Variable to store the total.
    Dim dblTotal As Double = 0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Stuff to do when the form loads. Perhaps a welcome message?
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotal.Text = BASIC_CHARGE.ToString("C2")
        radBasic.Checked = True
        chkCinema.Checked = False
        chkHBI.Checked = False
        chkShow.Checked = False
        chkLocal.Checked = False

    End Sub

    'Implement CheckedChanged
    'Most of this program will be written here.
    Dim strActive As String

    Private Sub radBasic_CheckedChanged(sender As Object, e As EventArgs) Handles radBasic.CheckedChanged
        If radBasic.Checked = True Then
            dblTotal += BASIC_CHARGE
        Else
            dblTotal -= BASIC_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub radSilver_CheckedChanged(sender As Object, e As EventArgs) Handles radSilver.CheckedChanged
        If radSilver.Checked = True Then
            dblTotal += SILVER_CHARGE
        Else
            dblTotal -= SILVER_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub radGold_CheckedChanged(sender As Object, e As EventArgs) Handles radGold.CheckedChanged
        If radGold.Checked = True Then
            dblTotal += GOLD_CHARGE
        Else
            dblTotal -= GOLD_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub radDiamond_CheckedChanged(sender As Object, e As EventArgs) Handles radDiamond.CheckedChanged
        If radDiamond.Checked = True Then
            dblTotal += DIAMOND_CHARGE
        Else
            dblTotal -= DIAMOND_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub chkCinema_CheckedChanged(sender As Object, e As EventArgs) Handles chkCinema.CheckedChanged
        If chkCinema.Checked = True Then
            dblTotal += CINEMA_CHARGE
        Else
            dblTotal -= CINEMA_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub chkHBI_CheckedChanged(sender As Object, e As EventArgs) Handles chkHBI.CheckedChanged
        If chkHBI.Checked = True Then
            dblTotal += HBI_CHARGE
        Else
            dblTotal -= HBI_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked = True Then
            dblTotal += SHOW_CHARGE
        Else
            dblTotal -= SHOW_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub chkLocal_CheckedChanged(sender As Object, e As EventArgs) Handles chkLocal.CheckedChanged
        If chkLocal.Checked = True Then
            dblTotal += LOCAL_CHARGE
        Else
            dblTotal -= LOCAL_CHARGE
        End If
        txtTotal.Text = dblTotal.ToString("C2")
    End Sub
End Class
