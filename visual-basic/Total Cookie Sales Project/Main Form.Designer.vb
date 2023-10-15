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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WeekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChocolateChipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeanutButterDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PecanSandiesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CookieSalesDataSet = New Total_Cookie_Sales_Project.CookieSalesDataSet()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPecan = New System.Windows.Forms.Label()
        Me.lblPeanut = New System.Windows.Forms.Label()
        Me.lblChocolate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SalesTableAdapter = New Total_Cookie_Sales_Project.CookieSalesDataSetTableAdapters.SalesTableAdapter()
        Me.TableAdapterManager = New Total_Cookie_Sales_Project.CookieSalesDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CookieSalesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WeekDataGridViewTextBoxColumn, Me.ChocolateChipDataGridViewTextBoxColumn, Me.PeanutButterDataGridViewTextBoxColumn, Me.PecanSandiesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(-2, -2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.Size = New System.Drawing.Size(320, 172)
        Me.DataGridView1.TabIndex = 2
        '
        'WeekDataGridViewTextBoxColumn
        '
        Me.WeekDataGridViewTextBoxColumn.DataPropertyName = "Week"
        Me.WeekDataGridViewTextBoxColumn.HeaderText = "Week"
        Me.WeekDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.WeekDataGridViewTextBoxColumn.Name = "WeekDataGridViewTextBoxColumn"
        Me.WeekDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChocolateChipDataGridViewTextBoxColumn
        '
        Me.ChocolateChipDataGridViewTextBoxColumn.DataPropertyName = "Chocolate Chip"
        Me.ChocolateChipDataGridViewTextBoxColumn.HeaderText = "Chocolate Chip"
        Me.ChocolateChipDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.ChocolateChipDataGridViewTextBoxColumn.Name = "ChocolateChipDataGridViewTextBoxColumn"
        Me.ChocolateChipDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeanutButterDataGridViewTextBoxColumn
        '
        Me.PeanutButterDataGridViewTextBoxColumn.DataPropertyName = "Peanut Butter"
        Me.PeanutButterDataGridViewTextBoxColumn.HeaderText = "Peanut Butter"
        Me.PeanutButterDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.PeanutButterDataGridViewTextBoxColumn.Name = "PeanutButterDataGridViewTextBoxColumn"
        Me.PeanutButterDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PecanSandiesDataGridViewTextBoxColumn
        '
        Me.PecanSandiesDataGridViewTextBoxColumn.DataPropertyName = "Pecan Sandies"
        Me.PecanSandiesDataGridViewTextBoxColumn.HeaderText = "Pecan Sandies"
        Me.PecanSandiesDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.PecanSandiesDataGridViewTextBoxColumn.Name = "PecanSandiesDataGridViewTextBoxColumn"
        Me.PecanSandiesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.CookieSalesDataSet
        '
        'CookieSalesDataSet
        '
        Me.CookieSalesDataSet.DataSetName = "CookieSalesDataSet"
        Me.CookieSalesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(213, 190)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Chocolate Chip:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPecan)
        Me.GroupBox1.Controls.Add(Me.lblPeanut)
        Me.GroupBox1.Controls.Add(Me.lblChocolate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(162, 116)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals"
        '
        'lblPecan
        '
        Me.lblPecan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPecan.Location = New System.Drawing.Point(108, 78)
        Me.lblPecan.Name = "lblPecan"
        Me.lblPecan.Size = New System.Drawing.Size(39, 24)
        Me.lblPecan.TabIndex = 5
        Me.lblPecan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPeanut
        '
        Me.lblPeanut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPeanut.Location = New System.Drawing.Point(108, 44)
        Me.lblPeanut.Name = "lblPeanut"
        Me.lblPeanut.Size = New System.Drawing.Size(39, 24)
        Me.lblPeanut.TabIndex = 4
        Me.lblPeanut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblChocolate
        '
        Me.lblChocolate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChocolate.Location = New System.Drawing.Point(108, 14)
        Me.lblChocolate.Name = "lblChocolate"
        Me.lblChocolate.Size = New System.Drawing.Size(39, 24)
        Me.lblChocolate.TabIndex = 3
        Me.lblChocolate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pecan Sandies:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Peanut Butter:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(213, 219)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Total_Cookie_Sales_Project.CookieSalesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 313)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cookie Sales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CookieSalesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblPecan As Label
    Friend WithEvents lblPeanut As Label
    Friend WithEvents lblChocolate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents CookieSalesDataSet As CookieSalesDataSet
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As CookieSalesDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TableAdapterManager As CookieSalesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WeekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ChocolateChipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PeanutButterDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PecanSandiesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
