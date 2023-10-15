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
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.txtNumSold = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsedCar = New System.Windows.Forms.TextBox()
        Me.txtNewCar = New System.Windows.Forms.TextBox()
        Me.txtPartTime = New System.Windows.Forms.TextBox()
        Me.txtFullTime = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEmpID
        '
        Me.txtEmpID.Location = New System.Drawing.Point(20, 50)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(72, 20)
        Me.txtEmpID.TabIndex = 0
        '
        'txtNumSold
        '
        Me.txtNumSold.Location = New System.Drawing.Point(115, 50)
        Me.txtNumSold.Name = "txtNumSold"
        Me.txtNumSold.Size = New System.Drawing.Size(38, 20)
        Me.txtNumSold.TabIndex = 1
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(208, 20)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(208, 51)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUsedCar)
        Me.GroupBox1.Controls.Add(Me.txtNewCar)
        Me.GroupBox1.Controls.Add(Me.txtPartTime)
        Me.GroupBox1.Controls.Add(Me.txtFullTime)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 170)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cars sold by"
        '
        'txtUsedCar
        '
        Me.txtUsedCar.Location = New System.Drawing.Point(128, 126)
        Me.txtUsedCar.Name = "txtUsedCar"
        Me.txtUsedCar.ReadOnly = True
        Me.txtUsedCar.Size = New System.Drawing.Size(100, 20)
        Me.txtUsedCar.TabIndex = 7
        '
        'txtNewCar
        '
        Me.txtNewCar.Location = New System.Drawing.Point(128, 93)
        Me.txtNewCar.Name = "txtNewCar"
        Me.txtNewCar.ReadOnly = True
        Me.txtNewCar.Size = New System.Drawing.Size(100, 20)
        Me.txtNewCar.TabIndex = 6
        '
        'txtPartTime
        '
        Me.txtPartTime.Location = New System.Drawing.Point(128, 60)
        Me.txtPartTime.Name = "txtPartTime"
        Me.txtPartTime.ReadOnly = True
        Me.txtPartTime.Size = New System.Drawing.Size(100, 20)
        Me.txtPartTime.TabIndex = 5
        '
        'txtFullTime
        '
        Me.txtFullTime.Location = New System.Drawing.Point(128, 27)
        Me.txtFullTime.Name = "txtFullTime"
        Me.txtFullTime.ReadOnly = True
        Me.txtFullTime.Size = New System.Drawing.Size(100, 20)
        Me.txtFullTime.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Used car employees:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "New car employees:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Part-time employees:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Full-time employees:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "&ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "&Number sold:"
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 281)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtNumSold)
        Me.Controls.Add(Me.txtEmpID)
        Me.Name = "Form1"
        Me.Text = "Rembrandt Auto-Mart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents txtNumSold As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUsedCar As TextBox
    Friend WithEvents txtNewCar As TextBox
    Friend WithEvents txtPartTime As TextBox
    Friend WithEvents txtFullTime As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
