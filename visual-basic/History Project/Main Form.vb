Option Explicit On
Option Strict On
Option Infer Off
Public Class frmMain
    ' Independent Sub procedures.
    Private Function DisplayGrade101(ByVal intPoints As Integer) As String
        'Display the grade for History 101
        Integer.TryParse(txtPoints.Text, intPoints)
        Select Case intPoints
            Case Is >= 90
                lblGrade.Text = "A"
            Case Is >= 80
                lblGrade.Text = "B"
            Case Is >= 70
                lblGrade.Text = "C"
            Case Is >= 60
                lblGrade.Text = "D"
            Case Else
                lblGrade.Text = "F"
        End Select
        Return lblGrade.Text
    End Function
    Private Function DisplayGrade201(ByVal intPoints As Integer) As String
        'Display the grade for History 201
        Integer.TryParse(txtPoints.Text, intPoints)
        If intPoints >= 75 Then
            lblGrade.Text = "p"
        Else
            lblGrade.Text = "f"
        End If
        Return lblGrade.Text
    End Function
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Calls independent Sub procedures to display a grade.
        If radHis101.Checked Then
            lblGrade.Text = DisplayGrade101(Integer.Parse(txtPoints.Text))
        Else
            lblGrade.Text = DisplayGrade201(Integer.Parse(txtPoints.Text))
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes application
        Me.Close()
    End Sub
    Private Sub txtPoints_Enter(sender As Object, e As EventArgs) Handles txtPoints.Enter
        'Selects all text when entered
        txtPoints.SelectAll()
    End Sub
    Private Sub ClearGrade(sender As Object, e As EventArgs) Handles txtPoints.TextChanged, radHis101.CheckedChanged, radHis201.CheckedChanged
        'Clears lblGrade when different radio button selected
        lblGrade.Text = String.Empty
    End Sub
    Private Sub txtPoints_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPoints.KeyPress
        ' Accept only numbers and the Backspace key
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class