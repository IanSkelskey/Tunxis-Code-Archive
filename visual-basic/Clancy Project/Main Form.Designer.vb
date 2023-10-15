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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnershipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClancyDataSet = New Clancy_Project.ClancyDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblFranchiseeSales = New System.Windows.Forms.Label()
        Me.lblCompanySales = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StoresTableAdapter = New Clancy_Project.ClancyDataSetTableAdapters.StoresTableAdapter()
        Me.TableAdapterManager = New Clancy_Project.ClancyDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClancyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StoreDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.SalesDataGridViewTextBoxColumn, Me.OwnershipDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(1090, 365)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.TabStop = False
        '
        'StoreDataGridViewTextBoxColumn
        '
        Me.StoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StoreDataGridViewTextBoxColumn.DataPropertyName = "Store"
        Me.StoreDataGridViewTextBoxColumn.HeaderText = "Store"
        Me.StoreDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.StoreDataGridViewTextBoxColumn.Name = "StoreDataGridViewTextBoxColumn"
        Me.StoreDataGridViewTextBoxColumn.ReadOnly = True
        Me.StoreDataGridViewTextBoxColumn.Width = 108
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        Me.CityDataGridViewTextBoxColumn.Width = 94
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        Me.StateDataGridViewTextBoxColumn.Width = 107
        '
        'SalesDataGridViewTextBoxColumn
        '
        Me.SalesDataGridViewTextBoxColumn.DataPropertyName = "Sales"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.SalesDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.SalesDataGridViewTextBoxColumn.HeaderText = "Sales"
        Me.SalesDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SalesDataGridViewTextBoxColumn.Name = "SalesDataGridViewTextBoxColumn"
        Me.SalesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OwnershipDataGridViewTextBoxColumn
        '
        Me.OwnershipDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.OwnershipDataGridViewTextBoxColumn.DataPropertyName = "Ownership"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OwnershipDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.OwnershipDataGridViewTextBoxColumn.HeaderText = "Ownership"
        Me.OwnershipDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.OwnershipDataGridViewTextBoxColumn.Name = "OwnershipDataGridViewTextBoxColumn"
        Me.OwnershipDataGridViewTextBoxColumn.ReadOnly = True
        Me.OwnershipDataGridViewTextBoxColumn.Width = 159
        '
        'StoresBindingSource
        '
        Me.StoresBindingSource.DataMember = "Stores"
        Me.StoresBindingSource.DataSource = Me.ClancyDataSet
        '
        'ClancyDataSet
        '
        Me.ClancyDataSet.DataSetName = "ClancyDataSet"
        Me.ClancyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnCalc)
        Me.GroupBox1.Controls.Add(Me.lblTotalSales)
        Me.GroupBox1.Controls.Add(Me.lblFranchiseeSales)
        Me.GroupBox1.Controls.Add(Me.lblCompanySales)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 418)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1005, 270)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(705, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 40)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(537, 195)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(150, 40)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblTotalSales
        '
        Me.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalSales.Location = New System.Drawing.Point(705, 109)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(150, 35)
        Me.lblTotalSales.TabIndex = 2
        '
        'lblFranchiseeSales
        '
        Me.lblFranchiseeSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFranchiseeSales.Location = New System.Drawing.Point(457, 109)
        Me.lblFranchiseeSales.Name = "lblFranchiseeSales"
        Me.lblFranchiseeSales.Size = New System.Drawing.Size(150, 35)
        Me.lblFranchiseeSales.TabIndex = 1
        '
        'lblCompanySales
        '
        Me.lblCompanySales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCompanySales.Location = New System.Drawing.Point(180, 109)
        Me.lblCompanySales.Name = "lblCompanySales"
        Me.lblCompanySales.Size = New System.Drawing.Size(150, 35)
        Me.lblCompanySales.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(700, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(452, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Franchisee:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Company-owned:"
        '
        'StoresTableAdapter
        '
        Me.StoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StoresTableAdapter = Me.StoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Clancy_Project.ClancyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 731)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmMain"
        Me.Text = "Clancy Boutique"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClancyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents lblFranchiseeSales As Label
    Friend WithEvents lblCompanySales As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents ClancyDataSet As ClancyDataSet
    Friend WithEvents StoresBindingSource As BindingSource
    Friend WithEvents StoresTableAdapter As ClancyDataSetTableAdapters.StoresTableAdapter
    Friend WithEvents TableAdapterManager As ClancyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OwnershipDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
