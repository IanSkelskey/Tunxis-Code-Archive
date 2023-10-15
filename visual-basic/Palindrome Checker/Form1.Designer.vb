<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtPalindrome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPalindrome
        '
        Me.txtPalindrome.Location = New System.Drawing.Point(30, 61)
        Me.txtPalindrome.Name = "txtPalindrome"
        Me.txtPalindrome.Size = New System.Drawing.Size(500, 31)
        Me.txtPalindrome.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter a string to test:"
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(175, 116)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(88, 37)
        Me.btnRun.TabIndex = 2
        Me.btnRun.Text = "&Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(278, 116)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 184)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPalindrome)
        Me.Name = "Form1"
        Me.Text = "Palindrome Checker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPalindrome As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRun As Button
    Friend WithEvents btnExit As Button
End Class
