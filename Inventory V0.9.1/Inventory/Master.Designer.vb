<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Master
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Mastertab = New System.Windows.Forms.TabControl()
        Me.Brand = New System.Windows.Forms.TabPage()
        Me.BidTB = New System.Windows.Forms.TextBox()
        Me.BDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BExportBT = New System.Windows.Forms.Button()
        Me.BrandSTB = New System.Windows.Forms.TextBox()
        Me.BClearBT = New System.Windows.Forms.Button()
        Me.BAddBT = New System.Windows.Forms.Button()
        Me.BUpdateBT = New System.Windows.Forms.Button()
        Me.BDeleteBT = New System.Windows.Forms.Button()
        Me.BrandTB = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CidTB = New System.Windows.Forms.TextBox()
        Me.CDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CExportBT = New System.Windows.Forms.Button()
        Me.CustomerSTB = New System.Windows.Forms.TextBox()
        Me.CCleanBT = New System.Windows.Forms.Button()
        Me.CAddBT = New System.Windows.Forms.Button()
        Me.CUpdateBT = New System.Windows.Forms.Button()
        Me.CDeleteBT = New System.Windows.Forms.Button()
        Me.CustomerTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MinTB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PidTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PDataGridView = New System.Windows.Forms.DataGridView()
        Me.GstTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MrpTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PDetailsTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UPriceTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BPriceTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PNameTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BCBox = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PExportBT = New System.Windows.Forms.Button()
        Me.PNameSTB = New System.Windows.Forms.TextBox()
        Me.PCleanBT = New System.Windows.Forms.Button()
        Me.PAddBT = New System.Windows.Forms.Button()
        Me.PUpdateBT = New System.Windows.Forms.Button()
        Me.PDeleteBT = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Mastertab.SuspendLayout()
        Me.Brand.SuspendLayout()
        CType(Me.BDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.PDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.12782!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.87218!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Mastertab, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.860465!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.13953!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(809, 448)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Mastertab
        '
        Me.Mastertab.Controls.Add(Me.Brand)
        Me.Mastertab.Controls.Add(Me.TabPage2)
        Me.Mastertab.Controls.Add(Me.TabPage1)
        Me.Mastertab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Mastertab.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mastertab.Location = New System.Drawing.Point(12, 11)
        Me.Mastertab.Name = "Mastertab"
        Me.Mastertab.SelectedIndex = 0
        Me.Mastertab.Size = New System.Drawing.Size(785, 434)
        Me.Mastertab.TabIndex = 0
        '
        'Brand
        '
        Me.Brand.BackColor = System.Drawing.Color.Goldenrod
        Me.Brand.Controls.Add(Me.BidTB)
        Me.Brand.Controls.Add(Me.BDataGridView)
        Me.Brand.Controls.Add(Me.Label1)
        Me.Brand.Controls.Add(Me.BExportBT)
        Me.Brand.Controls.Add(Me.BrandSTB)
        Me.Brand.Controls.Add(Me.BClearBT)
        Me.Brand.Controls.Add(Me.BAddBT)
        Me.Brand.Controls.Add(Me.BUpdateBT)
        Me.Brand.Controls.Add(Me.BDeleteBT)
        Me.Brand.Controls.Add(Me.BrandTB)
        Me.Brand.Controls.Add(Me.Label19)
        Me.Brand.Location = New System.Drawing.Point(4, 25)
        Me.Brand.Name = "Brand"
        Me.Brand.Padding = New System.Windows.Forms.Padding(3)
        Me.Brand.Size = New System.Drawing.Size(777, 405)
        Me.Brand.TabIndex = 0
        Me.Brand.Text = "Brand"
        '
        'BidTB
        '
        Me.BidTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BidTB.Location = New System.Drawing.Point(731, 13)
        Me.BidTB.Name = "BidTB"
        Me.BidTB.Size = New System.Drawing.Size(21, 20)
        Me.BidTB.TabIndex = 88
        Me.BidTB.Visible = False
        '
        'BDataGridView
        '
        Me.BDataGridView.AllowUserToAddRows = False
        Me.BDataGridView.AllowUserToDeleteRows = False
        Me.BDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BDataGridView.Location = New System.Drawing.Point(6, 199)
        Me.BDataGridView.Name = "BDataGridView"
        Me.BDataGridView.ReadOnly = True
        Me.BDataGridView.Size = New System.Drawing.Size(755, 182)
        Me.BDataGridView.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Search Brand"
        '
        'BExportBT
        '
        Me.BExportBT.BackColor = System.Drawing.Color.DarkRed
        Me.BExportBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BExportBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BExportBT.Location = New System.Drawing.Point(571, 97)
        Me.BExportBT.Name = "BExportBT"
        Me.BExportBT.Size = New System.Drawing.Size(90, 41)
        Me.BExportBT.TabIndex = 85
        Me.BExportBT.Text = "Export to Excel"
        Me.BExportBT.UseVisualStyleBackColor = False
        '
        'BrandSTB
        '
        Me.BrandSTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandSTB.Location = New System.Drawing.Point(270, 173)
        Me.BrandSTB.Name = "BrandSTB"
        Me.BrandSTB.Size = New System.Drawing.Size(214, 20)
        Me.BrandSTB.TabIndex = 84
        '
        'BClearBT
        '
        Me.BClearBT.BackColor = System.Drawing.Color.DarkRed
        Me.BClearBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BClearBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BClearBT.Location = New System.Drawing.Point(459, 97)
        Me.BClearBT.Name = "BClearBT"
        Me.BClearBT.Size = New System.Drawing.Size(90, 28)
        Me.BClearBT.TabIndex = 83
        Me.BClearBT.Text = "Clear"
        Me.BClearBT.UseVisualStyleBackColor = False
        '
        'BAddBT
        '
        Me.BAddBT.BackColor = System.Drawing.Color.DarkRed
        Me.BAddBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAddBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BAddBT.Location = New System.Drawing.Point(90, 97)
        Me.BAddBT.Name = "BAddBT"
        Me.BAddBT.Size = New System.Drawing.Size(90, 28)
        Me.BAddBT.TabIndex = 78
        Me.BAddBT.Text = "Add"
        Me.BAddBT.UseVisualStyleBackColor = False
        '
        'BUpdateBT
        '
        Me.BUpdateBT.BackColor = System.Drawing.Color.DarkRed
        Me.BUpdateBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BUpdateBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BUpdateBT.Location = New System.Drawing.Point(216, 97)
        Me.BUpdateBT.Name = "BUpdateBT"
        Me.BUpdateBT.Size = New System.Drawing.Size(90, 28)
        Me.BUpdateBT.TabIndex = 79
        Me.BUpdateBT.Text = "Update"
        Me.BUpdateBT.UseVisualStyleBackColor = False
        '
        'BDeleteBT
        '
        Me.BDeleteBT.BackColor = System.Drawing.Color.DarkRed
        Me.BDeleteBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDeleteBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BDeleteBT.Location = New System.Drawing.Point(334, 97)
        Me.BDeleteBT.Name = "BDeleteBT"
        Me.BDeleteBT.Size = New System.Drawing.Size(90, 28)
        Me.BDeleteBT.TabIndex = 80
        Me.BDeleteBT.Text = "Delete"
        Me.BDeleteBT.UseVisualStyleBackColor = False
        Me.BDeleteBT.Visible = False
        '
        'BrandTB
        '
        Me.BrandTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTB.Location = New System.Drawing.Point(290, 43)
        Me.BrandTB.Name = "BrandTB"
        Me.BrandTB.Size = New System.Drawing.Size(175, 20)
        Me.BrandTB.TabIndex = 81
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(325, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 19)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Brand Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Goldenrod
        Me.TabPage2.Controls.Add(Me.CidTB)
        Me.TabPage2.Controls.Add(Me.CDataGridView)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.CExportBT)
        Me.TabPage2.Controls.Add(Me.CustomerSTB)
        Me.TabPage2.Controls.Add(Me.CCleanBT)
        Me.TabPage2.Controls.Add(Me.CAddBT)
        Me.TabPage2.Controls.Add(Me.CUpdateBT)
        Me.TabPage2.Controls.Add(Me.CDeleteBT)
        Me.TabPage2.Controls.Add(Me.CustomerTB)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(777, 405)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Customer"
        '
        'CidTB
        '
        Me.CidTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CidTB.Location = New System.Drawing.Point(739, 9)
        Me.CidTB.Name = "CidTB"
        Me.CidTB.Size = New System.Drawing.Size(21, 20)
        Me.CidTB.TabIndex = 97
        Me.CidTB.Visible = False
        '
        'CDataGridView
        '
        Me.CDataGridView.AllowUserToAddRows = False
        Me.CDataGridView.AllowUserToDeleteRows = False
        Me.CDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CDataGridView.Location = New System.Drawing.Point(16, 195)
        Me.CDataGridView.Name = "CDataGridView"
        Me.CDataGridView.ReadOnly = True
        Me.CDataGridView.Size = New System.Drawing.Size(755, 182)
        Me.CDataGridView.TabIndex = 96
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 19)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Search Customer Type"
        '
        'CExportBT
        '
        Me.CExportBT.BackColor = System.Drawing.Color.DarkRed
        Me.CExportBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CExportBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CExportBT.Location = New System.Drawing.Point(584, 93)
        Me.CExportBT.Name = "CExportBT"
        Me.CExportBT.Size = New System.Drawing.Size(90, 41)
        Me.CExportBT.TabIndex = 94
        Me.CExportBT.Text = "Export to Excel"
        Me.CExportBT.UseVisualStyleBackColor = False
        '
        'CustomerSTB
        '
        Me.CustomerSTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerSTB.Location = New System.Drawing.Point(281, 169)
        Me.CustomerSTB.Name = "CustomerSTB"
        Me.CustomerSTB.Size = New System.Drawing.Size(214, 20)
        Me.CustomerSTB.TabIndex = 93
        '
        'CCleanBT
        '
        Me.CCleanBT.BackColor = System.Drawing.Color.DarkRed
        Me.CCleanBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CCleanBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CCleanBT.Location = New System.Drawing.Point(472, 93)
        Me.CCleanBT.Name = "CCleanBT"
        Me.CCleanBT.Size = New System.Drawing.Size(90, 28)
        Me.CCleanBT.TabIndex = 92
        Me.CCleanBT.Text = "Clear"
        Me.CCleanBT.UseVisualStyleBackColor = False
        '
        'CAddBT
        '
        Me.CAddBT.BackColor = System.Drawing.Color.DarkRed
        Me.CAddBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAddBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CAddBT.Location = New System.Drawing.Point(103, 93)
        Me.CAddBT.Name = "CAddBT"
        Me.CAddBT.Size = New System.Drawing.Size(90, 28)
        Me.CAddBT.TabIndex = 87
        Me.CAddBT.Text = "Add"
        Me.CAddBT.UseVisualStyleBackColor = False
        '
        'CUpdateBT
        '
        Me.CUpdateBT.BackColor = System.Drawing.Color.DarkRed
        Me.CUpdateBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUpdateBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CUpdateBT.Location = New System.Drawing.Point(229, 93)
        Me.CUpdateBT.Name = "CUpdateBT"
        Me.CUpdateBT.Size = New System.Drawing.Size(90, 28)
        Me.CUpdateBT.TabIndex = 88
        Me.CUpdateBT.Text = "Update"
        Me.CUpdateBT.UseVisualStyleBackColor = False
        '
        'CDeleteBT
        '
        Me.CDeleteBT.BackColor = System.Drawing.Color.DarkRed
        Me.CDeleteBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CDeleteBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CDeleteBT.Location = New System.Drawing.Point(347, 93)
        Me.CDeleteBT.Name = "CDeleteBT"
        Me.CDeleteBT.Size = New System.Drawing.Size(90, 28)
        Me.CDeleteBT.TabIndex = 89
        Me.CDeleteBT.Text = "Delete"
        Me.CDeleteBT.UseVisualStyleBackColor = False
        '
        'CustomerTB
        '
        Me.CustomerTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerTB.Location = New System.Drawing.Point(301, 39)
        Me.CustomerTB.Name = "CustomerTB"
        Me.CustomerTB.Size = New System.Drawing.Size(175, 20)
        Me.CustomerTB.TabIndex = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 19)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Customer Type"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Goldenrod
        Me.TabPage1.Controls.Add(Me.MinTB)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.PidTB)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.PDataGridView)
        Me.TabPage1.Controls.Add(Me.GstTB)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.ComTB)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.MrpTB)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.PDetailsTB)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.UPriceTB)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.BPriceTB)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.PNameTB)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.BCBox)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.PExportBT)
        Me.TabPage1.Controls.Add(Me.PNameSTB)
        Me.TabPage1.Controls.Add(Me.PCleanBT)
        Me.TabPage1.Controls.Add(Me.PAddBT)
        Me.TabPage1.Controls.Add(Me.PUpdateBT)
        Me.TabPage1.Controls.Add(Me.PDeleteBT)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(777, 405)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Product"
        '
        'MinTB
        '
        Me.MinTB.Location = New System.Drawing.Point(157, 129)
        Me.MinTB.Name = "MinTB"
        Me.MinTB.Size = New System.Drawing.Size(182, 22)
        Me.MinTB.TabIndex = 129
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(36, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Min Qty"
        '
        'PidTB
        '
        Me.PidTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PidTB.Location = New System.Drawing.Point(753, 3)
        Me.PidTB.Name = "PidTB"
        Me.PidTB.Size = New System.Drawing.Size(21, 20)
        Me.PidTB.TabIndex = 127
        Me.PidTB.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(164, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 16)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Search Product"
        '
        'PDataGridView
        '
        Me.PDataGridView.AllowUserToAddRows = False
        Me.PDataGridView.AllowUserToDeleteRows = False
        Me.PDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PDataGridView.Location = New System.Drawing.Point(6, 220)
        Me.PDataGridView.Name = "PDataGridView"
        Me.PDataGridView.ReadOnly = True
        Me.PDataGridView.Size = New System.Drawing.Size(755, 182)
        Me.PDataGridView.TabIndex = 125
        '
        'GstTB
        '
        Me.GstTB.Location = New System.Drawing.Point(516, 4)
        Me.GstTB.Name = "GstTB"
        Me.GstTB.Size = New System.Drawing.Size(182, 22)
        Me.GstTB.TabIndex = 124
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(395, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 16)
        Me.Label9.TabIndex = 123
        Me.Label9.Text = "GST%"
        '
        'ComTB
        '
        Me.ComTB.Location = New System.Drawing.Point(516, 32)
        Me.ComTB.Name = "ComTB"
        Me.ComTB.Size = New System.Drawing.Size(182, 22)
        Me.ComTB.TabIndex = 122
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(395, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Commission"
        '
        'MrpTB
        '
        Me.MrpTB.Location = New System.Drawing.Point(516, 64)
        Me.MrpTB.Name = "MrpTB"
        Me.MrpTB.Size = New System.Drawing.Size(182, 22)
        Me.MrpTB.TabIndex = 120
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(395, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 16)
        Me.Label7.TabIndex = 119
        Me.Label7.Text = "MRP"
        '
        'PDetailsTB
        '
        Me.PDetailsTB.Location = New System.Drawing.Point(516, 93)
        Me.PDetailsTB.Multiline = True
        Me.PDetailsTB.Name = "PDetailsTB"
        Me.PDetailsTB.Size = New System.Drawing.Size(182, 44)
        Me.PDetailsTB.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Product Details"
        '
        'UPriceTB
        '
        Me.UPriceTB.Location = New System.Drawing.Point(157, 101)
        Me.UPriceTB.Name = "UPriceTB"
        Me.UPriceTB.Size = New System.Drawing.Size(182, 22)
        Me.UPriceTB.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 16)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Unit Selling Price"
        '
        'BPriceTB
        '
        Me.BPriceTB.Location = New System.Drawing.Point(157, 72)
        Me.BPriceTB.Name = "BPriceTB"
        Me.BPriceTB.Size = New System.Drawing.Size(182, 22)
        Me.BPriceTB.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Buy Price"
        '
        'PNameTB
        '
        Me.PNameTB.Location = New System.Drawing.Point(157, 40)
        Me.PNameTB.Name = "PNameTB"
        Me.PNameTB.Size = New System.Drawing.Size(182, 22)
        Me.PNameTB.TabIndex = 112
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 16)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "Product Name"
        '
        'BCBox
        '
        Me.BCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BCBox.FormattingEnabled = True
        Me.BCBox.Location = New System.Drawing.Point(157, 6)
        Me.BCBox.Name = "BCBox"
        Me.BCBox.Size = New System.Drawing.Size(182, 24)
        Me.BCBox.TabIndex = 110
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(36, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 109
        Me.Label11.Text = "Brand Name"
        '
        'PExportBT
        '
        Me.PExportBT.BackColor = System.Drawing.Color.DarkRed
        Me.PExportBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PExportBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PExportBT.Location = New System.Drawing.Point(650, 165)
        Me.PExportBT.Name = "PExportBT"
        Me.PExportBT.Size = New System.Drawing.Size(90, 43)
        Me.PExportBT.TabIndex = 108
        Me.PExportBT.Text = "Export to Excel"
        Me.PExportBT.UseVisualStyleBackColor = False
        '
        'PNameSTB
        '
        Me.PNameSTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PNameSTB.Location = New System.Drawing.Point(281, 197)
        Me.PNameSTB.Name = "PNameSTB"
        Me.PNameSTB.Size = New System.Drawing.Size(214, 20)
        Me.PNameSTB.TabIndex = 107
        '
        'PCleanBT
        '
        Me.PCleanBT.BackColor = System.Drawing.Color.DarkRed
        Me.PCleanBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PCleanBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PCleanBT.Location = New System.Drawing.Point(503, 165)
        Me.PCleanBT.Name = "PCleanBT"
        Me.PCleanBT.Size = New System.Drawing.Size(90, 28)
        Me.PCleanBT.TabIndex = 106
        Me.PCleanBT.Text = "Clear"
        Me.PCleanBT.UseVisualStyleBackColor = False
        '
        'PAddBT
        '
        Me.PAddBT.BackColor = System.Drawing.Color.DarkRed
        Me.PAddBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PAddBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PAddBT.Location = New System.Drawing.Point(62, 165)
        Me.PAddBT.Name = "PAddBT"
        Me.PAddBT.Size = New System.Drawing.Size(90, 28)
        Me.PAddBT.TabIndex = 103
        Me.PAddBT.Text = "Add"
        Me.PAddBT.UseVisualStyleBackColor = False
        '
        'PUpdateBT
        '
        Me.PUpdateBT.BackColor = System.Drawing.Color.DarkRed
        Me.PUpdateBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PUpdateBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PUpdateBT.Location = New System.Drawing.Point(209, 165)
        Me.PUpdateBT.Name = "PUpdateBT"
        Me.PUpdateBT.Size = New System.Drawing.Size(90, 28)
        Me.PUpdateBT.TabIndex = 104
        Me.PUpdateBT.Text = "Update"
        Me.PUpdateBT.UseVisualStyleBackColor = False
        '
        'PDeleteBT
        '
        Me.PDeleteBT.BackColor = System.Drawing.Color.DarkRed
        Me.PDeleteBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PDeleteBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PDeleteBT.Location = New System.Drawing.Point(356, 165)
        Me.PDeleteBT.Name = "PDeleteBT"
        Me.PDeleteBT.Size = New System.Drawing.Size(90, 28)
        Me.PDeleteBT.TabIndex = 105
        Me.PDeleteBT.Text = "Delete"
        Me.PDeleteBT.UseVisualStyleBackColor = False
        Me.PDeleteBT.Visible = False
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(809, 448)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Master"
        Me.Text = "Master"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Mastertab.ResumeLayout(False)
        Me.Brand.ResumeLayout(False)
        Me.Brand.PerformLayout()
        CType(Me.BDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.CDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Mastertab As System.Windows.Forms.TabControl
    Friend WithEvents Brand As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BExportBT As System.Windows.Forms.Button
    Friend WithEvents BrandSTB As System.Windows.Forms.TextBox
    Friend WithEvents BClearBT As System.Windows.Forms.Button
    Friend WithEvents BAddBT As System.Windows.Forms.Button
    Friend WithEvents BUpdateBT As System.Windows.Forms.Button
    Friend WithEvents BDeleteBT As System.Windows.Forms.Button
    Friend WithEvents BrandTB As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CExportBT As System.Windows.Forms.Button
    Friend WithEvents CustomerSTB As System.Windows.Forms.TextBox
    Friend WithEvents CCleanBT As System.Windows.Forms.Button
    Friend WithEvents CAddBT As System.Windows.Forms.Button
    Friend WithEvents CUpdateBT As System.Windows.Forms.Button
    Friend WithEvents CDeleteBT As System.Windows.Forms.Button
    Friend WithEvents CustomerTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GstTB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComTB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MrpTB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PDetailsTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents UPriceTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BPriceTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PNameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BCBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PExportBT As System.Windows.Forms.Button
    Friend WithEvents PNameSTB As System.Windows.Forms.TextBox
    Friend WithEvents PCleanBT As System.Windows.Forms.Button
    Friend WithEvents PAddBT As System.Windows.Forms.Button
    Friend WithEvents PUpdateBT As System.Windows.Forms.Button
    Friend WithEvents PDeleteBT As System.Windows.Forms.Button
    Friend WithEvents BDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BidTB As System.Windows.Forms.TextBox
    Friend WithEvents CDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CidTB As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PidTB As System.Windows.Forms.TextBox
    Friend WithEvents MinTB As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
