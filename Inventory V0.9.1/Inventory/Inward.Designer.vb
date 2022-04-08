<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inward
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.QtyTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BuyerTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BCBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.IExportBT = New System.Windows.Forms.Button()
        Me.ProductSTB = New System.Windows.Forms.TextBox()
        Me.IClearBT = New System.Windows.Forms.Button()
        Me.IAddBT = New System.Windows.Forms.Button()
        Me.IUpdateBT = New System.Windows.Forms.Button()
        Me.IDeleteBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDataGridView = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PReturnCB = New System.Windows.Forms.CheckBox()
        Me.SidTB = New System.Windows.Forms.TextBox()
        Me.PCBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PNameTB = New System.Windows.Forms.TextBox()
        Me.PCBselectedvalueTB = New System.Windows.Forms.TextBox()
        Me.SReturnCB = New System.Windows.Forms.CheckBox()
        CType(Me.IDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(505, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "Date"
        '
        'QtyTB
        '
        Me.QtyTB.Location = New System.Drawing.Point(580, 102)
        Me.QtyTB.Name = "QtyTB"
        Me.QtyTB.Size = New System.Drawing.Size(180, 20)
        Me.QtyTB.TabIndex = 144
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(514, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Qty"
        '
        'BuyerTB
        '
        Me.BuyerTB.Location = New System.Drawing.Point(161, 105)
        Me.BuyerTB.Name = "BuyerTB"
        Me.BuyerTB.Size = New System.Drawing.Size(251, 20)
        Me.BuyerTB.TabIndex = 136
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(20, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 32)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Buyer Name/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bill No"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(20, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 16)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Product Name"
        '
        'BCBox
        '
        Me.BCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BCBox.FormattingEnabled = True
        Me.BCBox.Location = New System.Drawing.Point(161, 11)
        Me.BCBox.Name = "BCBox"
        Me.BCBox.Size = New System.Drawing.Size(251, 22)
        Me.BCBox.TabIndex = 132
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(20, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Brand"
        '
        'IExportBT
        '
        Me.IExportBT.BackColor = System.Drawing.Color.DarkRed
        Me.IExportBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IExportBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IExportBT.Location = New System.Drawing.Point(739, 175)
        Me.IExportBT.Name = "IExportBT"
        Me.IExportBT.Size = New System.Drawing.Size(105, 46)
        Me.IExportBT.TabIndex = 130
        Me.IExportBT.Text = "Export to Excel"
        Me.IExportBT.UseVisualStyleBackColor = False
        '
        'ProductSTB
        '
        Me.ProductSTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductSTB.Location = New System.Drawing.Point(334, 226)
        Me.ProductSTB.Name = "ProductSTB"
        Me.ProductSTB.Size = New System.Drawing.Size(249, 20)
        Me.ProductSTB.TabIndex = 129
        '
        'IClearBT
        '
        Me.IClearBT.BackColor = System.Drawing.Color.DarkRed
        Me.IClearBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IClearBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IClearBT.Location = New System.Drawing.Point(567, 175)
        Me.IClearBT.Name = "IClearBT"
        Me.IClearBT.Size = New System.Drawing.Size(105, 30)
        Me.IClearBT.TabIndex = 128
        Me.IClearBT.Text = "Clear"
        Me.IClearBT.UseVisualStyleBackColor = False
        '
        'IAddBT
        '
        Me.IAddBT.BackColor = System.Drawing.Color.DarkRed
        Me.IAddBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IAddBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IAddBT.Location = New System.Drawing.Point(53, 175)
        Me.IAddBT.Name = "IAddBT"
        Me.IAddBT.Size = New System.Drawing.Size(105, 30)
        Me.IAddBT.TabIndex = 125
        Me.IAddBT.Text = "Add"
        Me.IAddBT.UseVisualStyleBackColor = False
        '
        'IUpdateBT
        '
        Me.IUpdateBT.BackColor = System.Drawing.Color.DarkRed
        Me.IUpdateBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IUpdateBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IUpdateBT.Location = New System.Drawing.Point(224, 175)
        Me.IUpdateBT.Name = "IUpdateBT"
        Me.IUpdateBT.Size = New System.Drawing.Size(105, 30)
        Me.IUpdateBT.TabIndex = 126
        Me.IUpdateBT.Text = "Update"
        Me.IUpdateBT.UseVisualStyleBackColor = False
        '
        'IDeleteBT
        '
        Me.IDeleteBT.BackColor = System.Drawing.Color.DarkRed
        Me.IDeleteBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDeleteBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IDeleteBT.Location = New System.Drawing.Point(396, 175)
        Me.IDeleteBT.Name = "IDeleteBT"
        Me.IDeleteBT.Size = New System.Drawing.Size(105, 30)
        Me.IDeleteBT.TabIndex = 127
        Me.IDeleteBT.Text = "Delete"
        Me.IDeleteBT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(400, 208)
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
        Me.IDataGridView.Location = New System.Drawing.Point(12, 252)
        Me.IDataGridView.Name = "IDataGridView"
        Me.IDataGridView.ReadOnly = True
        Me.IDataGridView.Size = New System.Drawing.Size(892, 195)
        Me.IDataGridView.TabIndex = 151
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(580, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(180, 21)
        Me.DateTimePicker1.TabIndex = 153
        Me.DateTimePicker1.Value = New Date(2022, 3, 8, 0, 0, 0, 0)
        '
        'PReturnCB
        '
        Me.PReturnCB.AutoSize = True
        Me.PReturnCB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PReturnCB.Location = New System.Drawing.Point(517, 138)
        Me.PReturnCB.Name = "PReturnCB"
        Me.PReturnCB.Size = New System.Drawing.Size(139, 22)
        Me.PReturnCB.TabIndex = 155
        Me.PReturnCB.Text = "Purches Return"
        Me.PReturnCB.UseVisualStyleBackColor = True
        '
        'SidTB
        '
        Me.SidTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SidTB.Location = New System.Drawing.Point(883, 11)
        Me.SidTB.Name = "SidTB"
        Me.SidTB.Size = New System.Drawing.Size(21, 20)
        Me.SidTB.TabIndex = 156
        Me.SidTB.Visible = False
        '
        'PCBox
        '
        Me.PCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PCBox.FormattingEnabled = True
        Me.PCBox.Location = New System.Drawing.Point(580, 12)
        Me.PCBox.Name = "PCBox"
        Me.PCBox.Size = New System.Drawing.Size(251, 22)
        Me.PCBox.TabIndex = 159
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(478, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Product "
        '
        'PNameTB
        '
        Me.PNameTB.Location = New System.Drawing.Point(161, 57)
        Me.PNameTB.Name = "PNameTB"
        Me.PNameTB.Size = New System.Drawing.Size(251, 20)
        Me.PNameTB.TabIndex = 160
        '
        'PCBselectedvalueTB
        '
        Me.PCBselectedvalueTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCBselectedvalueTB.Location = New System.Drawing.Point(883, 37)
        Me.PCBselectedvalueTB.Name = "PCBselectedvalueTB"
        Me.PCBselectedvalueTB.Size = New System.Drawing.Size(21, 20)
        Me.PCBselectedvalueTB.TabIndex = 161
        Me.PCBselectedvalueTB.Visible = False
        '
        'SReturnCB
        '
        Me.SReturnCB.AutoSize = True
        Me.SReturnCB.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SReturnCB.Location = New System.Drawing.Point(672, 138)
        Me.SReturnCB.Name = "SReturnCB"
        Me.SReturnCB.Size = New System.Drawing.Size(119, 22)
        Me.SReturnCB.TabIndex = 162
        Me.SReturnCB.Text = "Sales Return"
        Me.SReturnCB.UseVisualStyleBackColor = True
        '
        'Inward
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(916, 459)
        Me.Controls.Add(Me.SReturnCB)
        Me.Controls.Add(Me.PCBselectedvalueTB)
        Me.Controls.Add(Me.PNameTB)
        Me.Controls.Add(Me.PCBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SidTB)
        Me.Controls.Add(Me.PReturnCB)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.IDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.QtyTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BuyerTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BCBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.IExportBT)
        Me.Controls.Add(Me.ProductSTB)
        Me.Controls.Add(Me.IClearBT)
        Me.Controls.Add(Me.IAddBT)
        Me.Controls.Add(Me.IUpdateBT)
        Me.Controls.Add(Me.IDeleteBT)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Inward"
        Me.Text = "Inward"
        CType(Me.IDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents QtyTB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BuyerTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BCBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents IExportBT As System.Windows.Forms.Button
    Friend WithEvents ProductSTB As System.Windows.Forms.TextBox
    Friend WithEvents IClearBT As System.Windows.Forms.Button
    Friend WithEvents IAddBT As System.Windows.Forms.Button
    Friend WithEvents IUpdateBT As System.Windows.Forms.Button
    Friend WithEvents IDeleteBT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PReturnCB As System.Windows.Forms.CheckBox
    Friend WithEvents SidTB As System.Windows.Forms.TextBox
    Friend WithEvents PCBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PNameTB As System.Windows.Forms.TextBox
    Friend WithEvents PCBselectedvalueTB As System.Windows.Forms.TextBox
    Friend WithEvents SReturnCB As System.Windows.Forms.CheckBox
End Class
