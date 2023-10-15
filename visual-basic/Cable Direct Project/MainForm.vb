Public Class frmMaim
    'Residential Constants
    Const RES_PROC_FEE As Double = 4.5
    Const RES_SERV_FEE As Double = 30
    Const RES_PREM_FEE As Double = 5
    'Business Constants
    Const BUS_PROC_FEE As Double = 16.5
    Const BUS_SERV_FLAT_FEE As Double = 80       '$80 flat rate for 1st 10 connections
    Const BUS_SERV_ADD_FEE As Double = 4   '$4 per connection for each additional connection
    Const BUS_PREM_FEE As Double = 50



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Variable to store total
        Dim dblTotal As Double = 0

        Dim numChannels As Integer = CInt(lbPremiumchannels.SelectedItem)
        Dim numConnections As Integer = CInt(lbConnections.SelectedItem)

        If rbBuisness.Checked Then
            'Test number of at least 1 connection
            If CInt(numConnections) >= 1 Then
                'Function to calculate total bill for business customers:

                dblTotal += BUS_PROC_FEE        'All Business customers are charged this processing fee
                dblTotal += BUS_SERV_FLAT_FEE   '$80 flat rate for 1st 10 connections

                If CInt(numConnections) > 10 Then
                    'additional connections after 10
                    dblTotal += BUS_SERV_ADD_FEE * (numConnections - 10)
                End If

                'Add on $50 per channel for any number of connections
                dblTotal += BUS_PREM_FEE * numChannels

                txtTotal.Text = dblTotal.ToString("C2")
            Else
                'If no connection selected
                MessageBox.Show("Business customers must have at least one connection.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        ElseIf rbResidential.Checked Then
            'Function to calculate total bill for residential customers:
            dblTotal += RES_PROC_FEE + RES_SERV_FEE + RES_PREM_FEE * numChannels
            txtTotal.Text = dblTotal.ToString("C2")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you want to close the application?", "Close Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
