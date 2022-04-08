<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Qty_Check
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
        Me.IExportBT = New System.Windows.Forms.Button()
        Me.ProductSTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.IDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IExportBT
        '
        Me.IExportBT.BackColor = System.Drawing.Color.DarkRed
        Me.IExportBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IExportBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IExportBT.Location = New System.Drawing.Point(729, 3)
        Me.IExportBT.Name = "IExportBT"
        Me.IExportBT.Size = New System.Drawing.Size(105, 46)
        Me.IExportBT.TabIndex = 130
        Me.IExportBT.Text = "Export to Excel"
        Me.IExportBT.UseVisualStyleBackColor = False
        '
        'ProductSTB
        '
        Me.ProductSTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductSTB.Location = New System.Drawing.Point(302, 29)
        Me.ProductSTB.Name = "ProductSTB"
        Me.ProductSTB.Size = New System.Drawing.Size(249, 20)
        Me.ProductSTB.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(368, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Product Search"
        '
        'IDataGridView
        '
        Me.IDataGridView.AllowUserToAddRows = False
        Me.IDataGridView.AllowUserToDeleteRows = False
        Me.IDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.IDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IDataGridView.Location = New System.Drawing.Point(12, 88)
        Me.IDataGridView.Name = "IDataGridView"
        Me.IDataGridView.ReadOnly = True
        Me.IDataGridView.Size = New System.Drawing.Size(892, 359)
        Me.IDataGridView.TabIndex = 151
        '
        'Qty_Check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(916, 459)
        Me.Controls.Add(Me.IDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IExportBT)
        Me.Controls.Add(Me.ProductSTB)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Qty_Check"
        Me.Text = "Inward"
        CType(Me.IDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IExportBT As System.Windows.Forms.Button
    Friend WithEvents ProductSTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDataGridView As System.Windows.Forms.DataGridView
End Class
