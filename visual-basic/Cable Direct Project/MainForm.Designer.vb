<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaim
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rbBuisness = New System.Windows.Forms.RadioButton()
        Me.rbResidential = New System.Windows.Forms.RadioButton()
        Me.lbPremiumchannels = New System.Windows.Forms.ListBox()
        Me.lblPremium = New System.Windows.Forms.Label()
        Me.lblConnections = New System.Windows.Forms.Label()
        Me.lbConnections = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rbBuisness
        '
        Me.rbBuisness.AutoSize = True
        Me.rbBuisness.Location = New System.Drawing.Point(12, 25)
        Me.rbBuisness.Name = "rbBuisness"
        Me.rbBuisness.Size = New System.Drawing.Size(79, 23)
        Me.rbBuisness.TabIndex = 0
        Me.rbBuisness.TabStop = True
        Me.rbBuisness.Text = "Buisness"
        Me.rbBuisness.UseVisualStyleBackColor = True
        '
        'rbResidential
        '
        Me.rbResidential.AutoSize = True
        Me.rbResidential.Location = New System.Drawing.Point(12, 58)
        Me.rbResidential.Name = "rbResidential"
        Me.rbResidential.Size = New System.Drawing.Size(89, 23)
        Me.rbResidential.TabIndex = 1
        Me.rbResidential.TabStop = True
        Me.rbResidential.Text = "Residental"
        Me.rbResidential.UseVisualStyleBackColor = True
        '
        'lbPremiumchannels
        '
        Me.lbPremiumchannels.FormattingEnabled = True
        Me.lbPremiumchannels.ItemHeight = 19
        Me.lbPremiumchannels.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.lbPremiumchannels.Location = New System.Drawing.Point(157, 56)
        Me.lbPremiumchannels.Name = "lbPremiumchannels"
        Me.lbPremiumchannels.Size = New System.Drawing.Size(45, 80)
        Me.lbPremiumchannels.TabIndex = 2
        '
        'lblPremium
        '
        Me.lblPremium.AutoSize = True
        Me.lblPremium.Location = New System.Drawing.Point(153, 27)
        Me.lblPremium.Name = "lblPremium"
        Me.lblPremium.Size = New System.Drawing.Size(127, 19)
        Me.lblPremium.TabIndex = 3
        Me.lblPremium.Text = "Premium Channels:"
        '
        'lblConnections
        '
        Me.lblConnections.AutoSize = True
        Me.lblConnections.Location = New System.Drawing.Point(286, 27)
        Me.lblConnections.Name = "lblConnections"
        Me.lblConnections.Size = New System.Drawing.Size(88, 19)
        Me.lblConnections.TabIndex = 4
        Me.lblConnections.Text = "Connections:"
        '
        'lbConnections
        '
        Me.lbConnections.FormattingEnabled = True
        Me.lbConnections.ItemHeight = 19
        Me.lbConnections.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.lbConnections.Location = New System.Drawing.Point(290, 56)
        Me.lbConnections.Name = "lbConnections"
        Me.lbConnections.Size = New System.Drawing.Size(45, 80)
        Me.lbConnections.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(290, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(157, 153)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(94, 33)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Khaki
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Location = New System.Drawing.Point(12, 159)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(107, 26)
        Me.txtTotal.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Total due: "
        '
        'frmMaim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 204)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lbConnections)
        Me.Controls.Add(Me.lblConnections)
        Me.Controls.Add(Me.lblPremium)
        Me.Controls.Add(Me.lbPremiumchannels)
        Me.Controls.Add(Me.rbResidential)
        Me.Controls.Add(Me.rbBuisness)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMaim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbBuisness As RadioButton
    Friend WithEvents rbResidential As RadioButton
    Friend WithEvents lbPremiumchannels As ListBox
    Friend WithEvents lblPremium As Label
    Friend WithEvents lblConnections As Label
    Friend WithEvents lbConnections As ListBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label1 As Label
End Class
