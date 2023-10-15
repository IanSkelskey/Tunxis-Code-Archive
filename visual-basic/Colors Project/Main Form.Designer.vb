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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSpanish = New System.Windows.Forms.Label()
        Me.btnGreen = New System.Windows.Forms.Button()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.imgColor = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radEspanol = New System.Windows.Forms.RadioButton()
        CType(Me.imgColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBlue
        '
        Me.btnBlue.Location = New System.Drawing.Point(7, 156)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(75, 23)
        Me.btnBlue.TabIndex = 0
        Me.btnBlue.Text = "&Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(323, 156)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSpanish
        '
        Me.lblSpanish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSpanish.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpanish.Location = New System.Drawing.Point(274, 91)
        Me.lblSpanish.Name = "lblSpanish"
        Me.lblSpanish.Size = New System.Drawing.Size(126, 44)
        Me.lblSpanish.TabIndex = 4
        Me.lblSpanish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGreen
        '
        Me.btnGreen.Location = New System.Drawing.Point(88, 156)
        Me.btnGreen.Name = "btnGreen"
        Me.btnGreen.Size = New System.Drawing.Size(75, 23)
        Me.btnGreen.TabIndex = 5
        Me.btnGreen.Text = "&Green"
        Me.btnGreen.UseVisualStyleBackColor = True
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(169, 156)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(75, 23)
        Me.btnRed.TabIndex = 6
        Me.btnRed.Text = "&Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'imgColor
        '
        Me.imgColor.Location = New System.Drawing.Point(9, 94)
        Me.imgColor.Name = "imgColor"
        Me.imgColor.Size = New System.Drawing.Size(237, 41)
        Me.imgColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgColor.TabIndex = 7
        Me.imgColor.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(413, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radEspanol)
        Me.GroupBox1.Controls.Add(Me.radEnglish)
        Me.GroupBox1.Controls.Add(Me.imgColor)
        Me.GroupBox1.Controls.Add(Me.btnBlue)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnRed)
        Me.GroupBox1.Controls.Add(Me.lblSpanish)
        Me.GroupBox1.Controls.Add(Me.btnGreen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 191)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select your language/ Elige tu idioma"
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Checked = True
        Me.radEnglish.Location = New System.Drawing.Point(19, 43)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(63, 19)
        Me.radEnglish.TabIndex = 8
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radEspanol
        '
        Me.radEspanol.AutoSize = True
        Me.radEspanol.Location = New System.Drawing.Point(88, 43)
        Me.radEspanol.Name = "radEspanol"
        Me.radEspanol.Size = New System.Drawing.Size(66, 19)
        Me.radEspanol.TabIndex = 9
        Me.radEspanol.Text = "Espanol"
        Me.radEspanol.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(437, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Colors in Spanish"
        CType(Me.imgColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBlue As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSpanish As Label
    Friend WithEvents btnGreen As Button
    Friend WithEvents btnRed As Button
    Friend WithEvents imgColor As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radEspanol As RadioButton
    Friend WithEvents radEnglish As RadioButton
End Class
