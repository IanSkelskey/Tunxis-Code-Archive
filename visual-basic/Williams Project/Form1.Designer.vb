<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radDiamond = New System.Windows.Forms.RadioButton()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.radSilver = New System.Windows.Forms.RadioButton()
        Me.radBasic = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkShow = New System.Windows.Forms.CheckBox()
        Me.chkHBI = New System.Windows.Forms.CheckBox()
        Me.chkCinema = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkLocal = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDiamond)
        Me.GroupBox1.Controls.Add(Me.radGold)
        Me.GroupBox1.Controls.Add(Me.radSilver)
        Me.GroupBox1.Controls.Add(Me.radBasic)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Packages"
        '
        'radDiamond
        '
        Me.radDiamond.AutoSize = True
        Me.radDiamond.Location = New System.Drawing.Point(6, 97)
        Me.radDiamond.Name = "radDiamond"
        Me.radDiamond.Size = New System.Drawing.Size(109, 17)
        Me.radDiamond.TabIndex = 3
        Me.radDiamond.TabStop = True
        Me.radDiamond.Text = "Diamond ($99.99)"
        Me.radDiamond.UseVisualStyleBackColor = True
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(6, 74)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(89, 17)
        Me.radGold.TabIndex = 2
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold ($84.99)"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'radSilver
        '
        Me.radSilver.AutoSize = True
        Me.radSilver.Location = New System.Drawing.Point(6, 51)
        Me.radSilver.Name = "radSilver"
        Me.radSilver.Size = New System.Drawing.Size(93, 17)
        Me.radSilver.TabIndex = 1
        Me.radSilver.TabStop = True
        Me.radSilver.Text = "Silver ($42.99)"
        Me.radSilver.UseVisualStyleBackColor = True
        '
        'radBasic
        '
        Me.radBasic.AutoSize = True
        Me.radBasic.Location = New System.Drawing.Point(6, 28)
        Me.radBasic.Name = "radBasic"
        Me.radBasic.Size = New System.Drawing.Size(93, 17)
        Me.radBasic.TabIndex = 0
        Me.radBasic.TabStop = True
        Me.radBasic.Text = "Basic ($24.99)"
        Me.radBasic.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkLocal)
        Me.GroupBox2.Controls.Add(Me.chkShow)
        Me.GroupBox2.Controls.Add(Me.chkHBI)
        Me.GroupBox2.Controls.Add(Me.chkCinema)
        Me.GroupBox2.Location = New System.Drawing.Point(156, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional features"
        '
        'chkShow
        '
        Me.chkShow.AutoSize = True
        Me.chkShow.Location = New System.Drawing.Point(6, 75)
        Me.chkShow.Name = "chkShow"
        Me.chkShow.Size = New System.Drawing.Size(117, 17)
        Me.chkShow.TabIndex = 6
        Me.chkShow.Text = "Showtimer ($10.50)"
        Me.chkShow.UseVisualStyleBackColor = True
        '
        'chkHBI
        '
        Me.chkHBI.AutoSize = True
        Me.chkHBI.Location = New System.Drawing.Point(6, 52)
        Me.chkHBI.Name = "chkHBI"
        Me.chkHBI.Size = New System.Drawing.Size(157, 17)
        Me.chkHBI.TabIndex = 5
        Me.chkHBI.Text = "HBI movie channels ($9.50)"
        Me.chkHBI.UseVisualStyleBackColor = True
        '
        'chkCinema
        '
        Me.chkCinema.AutoSize = True
        Me.chkCinema.Location = New System.Drawing.Point(6, 29)
        Me.chkCinema.Name = "chkCinema"
        Me.chkCinema.Size = New System.Drawing.Size(185, 17)
        Me.chkCinema.TabIndex = 4
        Me.chkCinema.Text = "Cinematic movie channels ($9.50)"
        Me.chkCinema.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(247, 149)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Monthly Charge:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(131, 150)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 5
        Me.txtTotal.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(298, 149)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(66, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkLocal
        '
        Me.chkLocal.AutoSize = True
        Me.chkLocal.Location = New System.Drawing.Point(6, 98)
        Me.chkLocal.Name = "chkLocal"
        Me.chkLocal.Size = New System.Drawing.Size(127, 17)
        Me.chkLocal.TabIndex = 7
        Me.chkLocal.Text = "Local stations ($6.00)"
        Me.chkLocal.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(386, 180)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Williams Cable Company"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radDiamond As RadioButton
    Friend WithEvents radGold As RadioButton
    Friend WithEvents radSilver As RadioButton
    Friend WithEvents radBasic As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkShow As CheckBox
    Friend WithEvents chkHBI As CheckBox
    Friend WithEvents chkCinema As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents chkLocal As CheckBox
End Class
