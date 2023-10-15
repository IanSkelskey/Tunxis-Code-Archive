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
        Me.radFamily = New System.Windows.Forms.RadioButton()
        Me.radSingle = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkRacquetball = New System.Windows.Forms.CheckBox()
        Me.chkTennis = New System.Windows.Forms.CheckBox()
        Me.chkGolf = New System.Windows.Forms.CheckBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBasicFee = New System.Windows.Forms.TextBox()
        Me.txtAdditional = New System.Windows.Forms.TextBox()
        Me.txtMothlyDues = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFamily)
        Me.GroupBox1.Controls.Add(Me.radSingle)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(204, 225)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Membership"
        '
        'radFamily
        '
        Me.radFamily.AutoSize = True
        Me.radFamily.Location = New System.Drawing.Point(28, 100)
        Me.radFamily.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.radFamily.Name = "radFamily"
        Me.radFamily.Size = New System.Drawing.Size(106, 29)
        Me.radFamily.TabIndex = 1
        Me.radFamily.TabStop = True
        Me.radFamily.Text = "&Family"
        Me.radFamily.UseVisualStyleBackColor = True
        '
        'radSingle
        '
        Me.radSingle.AutoSize = True
        Me.radSingle.Location = New System.Drawing.Point(28, 56)
        Me.radSingle.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.radSingle.Name = "radSingle"
        Me.radSingle.Size = New System.Drawing.Size(103, 29)
        Me.radSingle.TabIndex = 0
        Me.radSingle.TabStop = True
        Me.radSingle.Text = "&Single"
        Me.radSingle.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkRacquetball)
        Me.GroupBox2.Controls.Add(Me.chkTennis)
        Me.GroupBox2.Controls.Add(Me.chkGolf)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 35)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(230, 225)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Additional"
        '
        'chkRacquetball
        '
        Me.chkRacquetball.AutoSize = True
        Me.chkRacquetball.Location = New System.Drawing.Point(28, 144)
        Me.chkRacquetball.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkRacquetball.Name = "chkRacquetball"
        Me.chkRacquetball.Size = New System.Drawing.Size(158, 29)
        Me.chkRacquetball.TabIndex = 2
        Me.chkRacquetball.Text = "&Racquetball"
        Me.chkRacquetball.UseVisualStyleBackColor = True
        '
        'chkTennis
        '
        Me.chkTennis.AutoSize = True
        Me.chkTennis.Location = New System.Drawing.Point(28, 100)
        Me.chkTennis.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkTennis.Name = "chkTennis"
        Me.chkTennis.Size = New System.Drawing.Size(109, 29)
        Me.chkTennis.TabIndex = 1
        Me.chkTennis.Text = "&Tennis"
        Me.chkTennis.UseVisualStyleBackColor = True
        '
        'chkGolf
        '
        Me.chkGolf.AutoSize = True
        Me.chkGolf.Location = New System.Drawing.Point(28, 56)
        Me.chkGolf.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkGolf.Name = "chkGolf"
        Me.chkGolf.Size = New System.Drawing.Size(83, 29)
        Me.chkGolf.TabIndex = 0
        Me.chkGolf.Text = "&Golf"
        Me.chkGolf.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(438, 421)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 44)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalc.Location = New System.Drawing.Point(276, 421)
        Me.btnCalc.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(150, 44)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 290)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Basic fee:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(314, 290)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Additional:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 394)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monthly dues:"
        '
        'txtBasicFee
        '
        Me.txtBasicFee.Location = New System.Drawing.Point(24, 321)
        Me.txtBasicFee.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtBasicFee.Name = "txtBasicFee"
        Me.txtBasicFee.ReadOnly = True
        Me.txtBasicFee.Size = New System.Drawing.Size(196, 31)
        Me.txtBasicFee.TabIndex = 7
        Me.txtBasicFee.TabStop = False
        '
        'txtAdditional
        '
        Me.txtAdditional.Location = New System.Drawing.Point(320, 321)
        Me.txtAdditional.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtAdditional.Name = "txtAdditional"
        Me.txtAdditional.ReadOnly = True
        Me.txtAdditional.Size = New System.Drawing.Size(196, 31)
        Me.txtAdditional.TabIndex = 8
        Me.txtAdditional.TabStop = False
        '
        'txtMothlyDues
        '
        Me.txtMothlyDues.Location = New System.Drawing.Point(24, 425)
        Me.txtMothlyDues.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtMothlyDues.Name = "txtMothlyDues"
        Me.txtMothlyDues.ReadOnly = True
        Me.txtMothlyDues.Size = New System.Drawing.Size(196, 31)
        Me.txtMothlyDues.TabIndex = 9
        Me.txtMothlyDues.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(572, 494)
        Me.Controls.Add(Me.txtMothlyDues)
        Me.Controls.Add(Me.txtAdditional)
        Me.Controls.Add(Me.txtBasicFee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "frmMain"
        Me.Text = "Glasgow Health Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radFamily As RadioButton
    Friend WithEvents radSingle As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkRacquetball As CheckBox
    Friend WithEvents chkTennis As CheckBox
    Friend WithEvents chkGolf As CheckBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBasicFee As TextBox
    Friend WithEvents txtAdditional As TextBox
    Friend WithEvents txtMothlyDues As TextBox
End Class
