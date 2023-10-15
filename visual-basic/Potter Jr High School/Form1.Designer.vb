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
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstNames = New System.Windows.Forms.ListBox()
        Me.lstGrades = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(238, 99)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(319, 99)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(238, 40)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.ReadOnly = True
        Me.txtNumber.Size = New System.Drawing.Size(55, 20)
        Me.txtNumber.TabIndex = 2
        Me.txtNumber.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Number of Students:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Grade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "&Students:"
        '
        'lstNames
        '
        Me.lstNames.FormattingEnabled = True
        Me.lstNames.Location = New System.Drawing.Point(79, 40)
        Me.lstNames.Name = "lstNames"
        Me.lstNames.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstNames.Size = New System.Drawing.Size(120, 95)
        Me.lstNames.Sorted = True
        Me.lstNames.TabIndex = 1
        '
        'lstGrades
        '
        Me.lstGrades.FormattingEnabled = True
        Me.lstGrades.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.lstGrades.Location = New System.Drawing.Point(15, 40)
        Me.lstGrades.Name = "lstGrades"
        Me.lstGrades.Size = New System.Drawing.Size(21, 69)
        Me.lstGrades.TabIndex = 0
        '
        'Form1
        '
        Me.AcceptButton = Me.btnDisplay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(411, 155)
        Me.Controls.Add(Me.lstGrades)
        Me.Controls.Add(Me.lstNames)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Name = "Form1"
        Me.Text = "Potter Jr High School"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstNames As ListBox
    Friend WithEvents lstGrades As ListBox
End Class
