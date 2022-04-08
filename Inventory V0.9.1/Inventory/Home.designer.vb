<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.BnoTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CnameTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MobilrTB = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pdetailsCB = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Sno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pdetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mrp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.damount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.damounttotalTB = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gtotalTB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.gsttotalTB = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SavePrintBT = New System.Windows.Forms.Button()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.EditBT = New System.Windows.Forms.Button()
        Me.MqtyBT = New System.Windows.Forms.Button()
        Me.ClearBT = New System.Windows.Forms.Button()
        Me.SnoTB = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CtypeCB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProductSTB = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InwardGoodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QtyCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrinterConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.BSnoTB = New System.Windows.Forms.TextBox()
        Me.PidTB = New System.Windows.Forms.TextBox()
        Me.EnablegstCB = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.RefreshBT = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.brandCB = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gstTB = New System.Windows.Forms.TextBox()
        Me.tpriceTB = New System.Windows.Forms.TextBox()
        Me.damountTB = New System.Windows.Forms.TextBox()
        Me.mrpTB = New System.Windows.Forms.TextBox()
        Me.upriceTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AqtyTB = New System.Windows.Forms.TextBox()
        Me.qtyTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.DeleteBT = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'BnoTB
        '
        Me.BnoTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BnoTB.Location = New System.Drawing.Point(351, 3)
        Me.BnoTB.Name = "BnoTB"
        Me.BnoTB.Size = New System.Drawing.Size(295, 21)
        Me.BnoTB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bill No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(679, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Name"
        '
        'CnameTB
        '
        Me.CnameTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CnameTB.Location = New System.Drawing.Point(1007, 3)
        Me.CnameTB.Name = "CnameTB"
        Me.CnameTB.Size = New System.Drawing.Size(295, 21)
        Me.CnameTB.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mobile No"
        '
        'MobilrTB
        '
        Me.MobilrTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobilrTB.Location = New System.Drawing.Point(351, 49)
        Me.MobilrTB.Name = "MobilrTB"
        Me.MobilrTB.Size = New System.Drawing.Size(295, 21)
        Me.MobilrTB.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(1139, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 36)
        Me.Label18.TabIndex = 54
        Me.Label18.Text = "GST %"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(864, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 18)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "MRP"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(458, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 18)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Brand"
        '
        'pdetailsCB
        '
        Me.pdetailsCB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pdetailsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pdetailsCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdetailsCB.FormattingEnabled = True
        Me.pdetailsCB.Location = New System.Drawing.Point(21, 41)
        Me.pdetailsCB.Name = "pdetailsCB"
        Me.pdetailsCB.Size = New System.Drawing.Size(346, 23)
        Me.pdetailsCB.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(1074, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 36)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Total Price"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(962, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 36)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Discount Amount"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(751, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Unit Price"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(135, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Product Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sno, Me.pdetails, Me.brand, Me.qty, Me.uprice, Me.mrp, Me.damount, Me.tprice, Me.gst, Me.Pid})
        Me.DataGridView1.Location = New System.Drawing.Point(20, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1311, 298)
        Me.DataGridView1.TabIndex = 11
        '
        'Sno
        '
        Me.Sno.HeaderText = "S.No"
        Me.Sno.Name = "Sno"
        Me.Sno.ReadOnly = True
        '
        'pdetails
        '
        Me.pdetails.HeaderText = "Product Details"
        Me.pdetails.Name = "pdetails"
        Me.pdetails.ReadOnly = True
        '
        'brand
        '
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'uprice
        '
        Me.uprice.HeaderText = "Unit Price"
        Me.uprice.Name = "uprice"
        Me.uprice.ReadOnly = True
        '
        'mrp
        '
        Me.mrp.HeaderText = "MRP"
        Me.mrp.Name = "mrp"
        Me.mrp.ReadOnly = True
        '
        'damount
        '
        Me.damount.HeaderText = "Discount Amount"
        Me.damount.Name = "damount"
        Me.damount.ReadOnly = True
        '
        'tprice
        '
        Me.tprice.HeaderText = "Total Price"
        Me.tprice.Name = "tprice"
        Me.tprice.ReadOnly = True
        '
        'gst
        '
        Me.gst.HeaderText = "GST"
        Me.gst.Name = "gst"
        Me.gst.ReadOnly = True
        '
        'Pid
        '
        Me.Pid.HeaderText = "Pid"
        Me.Pid.Name = "Pid"
        Me.Pid.ReadOnly = True
        Me.Pid.Visible = False
        '
        'damounttotalTB
        '
        Me.damounttotalTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.damounttotalTB.Location = New System.Drawing.Point(351, 3)
        Me.damounttotalTB.Name = "damounttotalTB"
        Me.damounttotalTB.Size = New System.Drawing.Size(170, 21)
        Me.damounttotalTB.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(218, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 18)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Discount Amount"
        '
        'gtotalTB
        '
        Me.gtotalTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gtotalTB.Location = New System.Drawing.Point(1009, 42)
        Me.gtotalTB.Name = "gtotalTB"
        Me.gtotalTB.Size = New System.Drawing.Size(146, 21)
        Me.gtotalTB.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(912, 39)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 18)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Grand Total"
        '
        'gsttotalTB
        '
        Me.gsttotalTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gsttotalTB.Location = New System.Drawing.Point(1009, 3)
        Me.gsttotalTB.Name = "gsttotalTB"
        Me.gsttotalTB.Size = New System.Drawing.Size(146, 21)
        Me.gsttotalTB.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(907, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 18)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "GST Amount"
        '
        'SavePrintBT
        '
        Me.SavePrintBT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SavePrintBT.BackColor = System.Drawing.Color.Navy
        Me.SavePrintBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SavePrintBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SavePrintBT.Location = New System.Drawing.Point(134, 3)
        Me.SavePrintBT.Name = "SavePrintBT"
        Me.SavePrintBT.Size = New System.Drawing.Size(98, 34)
        Me.SavePrintBT.TabIndex = 35
        Me.SavePrintBT.Text = "Print"
        Me.SavePrintBT.UseVisualStyleBackColor = False
        '
        'SaveBT
        '
        Me.SaveBT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.SaveBT.BackColor = System.Drawing.Color.Navy
        Me.SaveBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaveBT.Location = New System.Drawing.Point(464, 3)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(98, 33)
        Me.SaveBT.TabIndex = 36
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = False
        '
        'EditBT
        '
        Me.EditBT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EditBT.BackColor = System.Drawing.Color.Navy
        Me.EditBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EditBT.Location = New System.Drawing.Point(463, 42)
        Me.EditBT.Name = "EditBT"
        Me.EditBT.Size = New System.Drawing.Size(98, 33)
        Me.EditBT.TabIndex = 37
        Me.EditBT.Text = "Edit"
        Me.EditBT.UseVisualStyleBackColor = False
        Me.EditBT.Visible = False
        '
        'MqtyBT
        '
        Me.MqtyBT.BackColor = System.Drawing.Color.Red
        Me.MqtyBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MqtyBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MqtyBT.Location = New System.Drawing.Point(999, 3)
        Me.MqtyBT.Name = "MqtyBT"
        Me.MqtyBT.Size = New System.Drawing.Size(132, 43)
        Me.MqtyBT.TabIndex = 39
        Me.MqtyBT.Text = "Min Qty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alert"
        Me.MqtyBT.UseVisualStyleBackColor = False
        Me.MqtyBT.Visible = False
        '
        'ClearBT
        '
        Me.ClearBT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ClearBT.BackColor = System.Drawing.Color.Navy
        Me.ClearBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClearBT.Location = New System.Drawing.Point(1120, 3)
        Me.ClearBT.Name = "ClearBT"
        Me.ClearBT.Size = New System.Drawing.Size(98, 34)
        Me.ClearBT.TabIndex = 41
        Me.ClearBT.Text = "Clear"
        Me.ClearBT.UseVisualStyleBackColor = False
        '
        'SnoTB
        '
        Me.SnoTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SnoTB.Location = New System.Drawing.Point(1335, 49)
        Me.SnoTB.Name = "SnoTB"
        Me.SnoTB.ReadOnly = True
        Me.SnoTB.Size = New System.Drawing.Size(18, 20)
        Me.SnoTB.TabIndex = 26
        Me.SnoTB.Text = "0"
        Me.SnoTB.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(679, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 18)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Customer Category"
        '
        'CtypeCB
        '
        Me.CtypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CtypeCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CtypeCB.FormattingEnabled = True
        Me.CtypeCB.Location = New System.Drawing.Point(1007, 49)
        Me.CtypeCB.Name = "CtypeCB"
        Me.CtypeCB.Size = New System.Drawing.Size(295, 23)
        Me.CtypeCB.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(328, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 18)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Product Search"
        '
        'ProductSTB
        '
        Me.ProductSTB.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProductSTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductSTB.Location = New System.Drawing.Point(452, 14)
        Me.ProductSTB.Name = "ProductSTB"
        Me.ProductSTB.Size = New System.Drawing.Size(379, 21)
        Me.ProductSTB.TabIndex = 25
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.5625!))
        Me.TableLayoutPanel1.Controls.Add(Me.MenuStrip1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1356, 38)
        Me.TableLayoutPanel1.TabIndex = 49
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.InwardGoodsToolStripMenuItem, Me.ReportToolStripMenuItem, Me.QtyCheckToolStripMenuItem, Me.PrinterConfigToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1356, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'InwardGoodsToolStripMenuItem
        '
        Me.InwardGoodsToolStripMenuItem.Name = "InwardGoodsToolStripMenuItem"
        Me.InwardGoodsToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.InwardGoodsToolStripMenuItem.Text = "Inward Goods"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'QtyCheckToolStripMenuItem
        '
        Me.QtyCheckToolStripMenuItem.Name = "QtyCheckToolStripMenuItem"
        Me.QtyCheckToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.QtyCheckToolStripMenuItem.Text = "Qty Check"
        '
        'PrinterConfigToolStripMenuItem
        '
        Me.PrinterConfigToolStripMenuItem.Name = "PrinterConfigToolStripMenuItem"
        Me.PrinterConfigToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.PrinterConfigToolStripMenuItem.Text = "Printer Config"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.499114!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.25044!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.25044!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.25044!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.25044!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.499114!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BnoTB, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.BSnoTB, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.SnoTB, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.PidTB, 5, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.CnameTB, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.CtypeCB, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MobilrTB, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.EnablegstCB, 4, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.27273!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.30303!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1356, 108)
        Me.TableLayoutPanel2.TabIndex = 50
        '
        'BSnoTB
        '
        Me.BSnoTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSnoTB.Location = New System.Drawing.Point(1335, 3)
        Me.BSnoTB.Name = "BSnoTB"
        Me.BSnoTB.ReadOnly = True
        Me.BSnoTB.Size = New System.Drawing.Size(18, 20)
        Me.BSnoTB.TabIndex = 26
        Me.BSnoTB.Text = "0"
        Me.BSnoTB.Visible = False
        '
        'PidTB
        '
        Me.PidTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PidTB.Location = New System.Drawing.Point(1335, 78)
        Me.PidTB.Name = "PidTB"
        Me.PidTB.Size = New System.Drawing.Size(18, 20)
        Me.PidTB.TabIndex = 47
        Me.PidTB.Text = "0"
        Me.PidTB.Visible = False
        '
        'EnablegstCB
        '
        Me.EnablegstCB.AutoSize = True
        Me.EnablegstCB.Checked = True
        Me.EnablegstCB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnablegstCB.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.EnablegstCB.Location = New System.Drawing.Point(1007, 78)
        Me.EnablegstCB.Name = "EnablegstCB"
        Me.EnablegstCB.Size = New System.Drawing.Size(101, 22)
        Me.EnablegstCB.TabIndex = 48
        Me.EnablegstCB.Text = "Estimation"
        Me.EnablegstCB.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 6
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.465735!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35617!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35617!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.845577!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.96252!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ProductSTB, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.RefreshBT, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.MqtyBT, 4, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 146)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1356, 49)
        Me.TableLayoutPanel3.TabIndex = 51
        '
        'RefreshBT
        '
        Me.RefreshBT.BackColor = System.Drawing.Color.Navy
        Me.RefreshBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RefreshBT.Location = New System.Drawing.Point(882, 3)
        Me.RefreshBT.Name = "RefreshBT"
        Me.RefreshBT.Size = New System.Drawing.Size(98, 29)
        Me.RefreshBT.TabIndex = 48
        Me.RefreshBT.Text = "Refresh"
        Me.RefreshBT.UseVisualStyleBackColor = False
        Me.RefreshBT.Visible = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 12
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.456112!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.1203!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.19549!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.150342!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.618831!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.276819!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.872824!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52233!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.176294!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.951238!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.576144!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.brandCB, 2, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.pdetailsCB, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button1, 10, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.gstTB, 9, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label18, 9, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.tpriceTB, 8, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 8, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.damountTB, 7, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 7, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.mrpTB, 6, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 6, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.upriceTB, 5, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 5, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.AqtyTB, 3, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.qtyTB, 4, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 4, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 195)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1356, 79)
        Me.TableLayoutPanel4.TabIndex = 52
        '
        'brandCB
        '
        Me.brandCB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.brandCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.brandCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.brandCB.FormattingEnabled = True
        Me.brandCB.Location = New System.Drawing.Point(373, 41)
        Me.brandCB.Name = "brandCB"
        Me.brandCB.Size = New System.Drawing.Size(222, 23)
        Me.brandCB.TabIndex = 49
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Navy
        Me.Button1.Font = New System.Drawing.Font("Arial", 15.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(1195, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 29)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'gstTB
        '
        Me.gstTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gstTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gstTB.Location = New System.Drawing.Point(1133, 41)
        Me.gstTB.Name = "gstTB"
        Me.gstTB.Size = New System.Drawing.Size(56, 21)
        Me.gstTB.TabIndex = 53
        '
        'tpriceTB
        '
        Me.tpriceTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tpriceTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpriceTB.Location = New System.Drawing.Point(1069, 41)
        Me.tpriceTB.Name = "tpriceTB"
        Me.tpriceTB.Size = New System.Drawing.Size(58, 21)
        Me.tpriceTB.TabIndex = 22
        '
        'damountTB
        '
        Me.damountTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.damountTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.damountTB.Location = New System.Drawing.Point(954, 41)
        Me.damountTB.Name = "damountTB"
        Me.damountTB.Size = New System.Drawing.Size(92, 21)
        Me.damountTB.TabIndex = 18
        '
        'mrpTB
        '
        Me.mrpTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.mrpTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrpTB.Location = New System.Drawing.Point(839, 41)
        Me.mrpTB.Name = "mrpTB"
        Me.mrpTB.Size = New System.Drawing.Size(91, 21)
        Me.mrpTB.TabIndex = 51
        '
        'upriceTB
        '
        Me.upriceTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.upriceTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upriceTB.Location = New System.Drawing.Point(748, 41)
        Me.upriceTB.Name = "upriceTB"
        Me.upriceTB.Size = New System.Drawing.Size(85, 21)
        Me.upriceTB.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(601, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 36)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Avaliable Qty"
        '
        'AqtyTB
        '
        Me.AqtyTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AqtyTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AqtyTB.Location = New System.Drawing.Point(607, 41)
        Me.AqtyTB.Name = "AqtyTB"
        Me.AqtyTB.Size = New System.Drawing.Size(59, 21)
        Me.AqtyTB.TabIndex = 14
        '
        'qtyTB
        '
        Me.qtyTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.qtyTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTB.Location = New System.Drawing.Point(680, 41)
        Me.qtyTB.Name = "qtyTB"
        Me.qtyTB.Size = New System.Drawing.Size(59, 21)
        Me.qtyTB.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(694, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Qty"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.327434!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.19764!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.548673!))
        Me.TableLayoutPanel5.Controls.Add(Me.DataGridView1, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 274)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1356, 304)
        Me.TableLayoutPanel5.TabIndex = 53
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 6
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.466913!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26654!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26654!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26654!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.26654!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.466913!))
        Me.TableLayoutPanel6.Controls.Add(Me.Label14, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.damounttotalTB, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.EditBT, 2, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label16, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.gsttotalTB, 4, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.Label15, 3, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.gtotalTB, 4, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(0, 578)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(1356, 78)
        Me.TableLayoutPanel6.TabIndex = 54
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 6
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.345291!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.90623!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68117!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.53113!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.60615!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.SavePrintBT, 1, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.DeleteBT, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.ClearBT, 4, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.SaveBT, 2, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(0, 656)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(1356, 61)
        Me.TableLayoutPanel7.TabIndex = 55
        '
        'DeleteBT
        '
        Me.DeleteBT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DeleteBT.BackColor = System.Drawing.Color.Navy
        Me.DeleteBT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DeleteBT.Location = New System.Drawing.Point(792, 3)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(98, 34)
        Me.DeleteBT.TabIndex = 38
        Me.DeleteBT.Text = "Delete"
        Me.DeleteBT.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1356, 698)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.TableLayoutPanel6)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BnoTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CnameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MobilrTB As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents damounttotalTB As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gtotalTB As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents gsttotalTB As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents SavePrintBT As System.Windows.Forms.Button
    Friend WithEvents SaveBT As System.Windows.Forms.Button
    Friend WithEvents EditBT As System.Windows.Forms.Button
    Friend WithEvents MqtyBT As System.Windows.Forms.Button
    Friend WithEvents ClearBT As System.Windows.Forms.Button
    Friend WithEvents SnoTB As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pdetailsCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CtypeCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProductSTB As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InwardGoodsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gstTB As System.Windows.Forms.TextBox
    Friend WithEvents mrpTB As System.Windows.Forms.TextBox
    Friend WithEvents tpriceTB As System.Windows.Forms.TextBox
    Friend WithEvents damountTB As System.Windows.Forms.TextBox
    Friend WithEvents brandCB As System.Windows.Forms.ComboBox
    Friend WithEvents upriceTB As System.Windows.Forms.TextBox
    Friend WithEvents qtyTB As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents QtyCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Sno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pdetails As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents brand As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mrp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents damount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tprice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PidTB As System.Windows.Forms.TextBox
    Friend WithEvents BSnoTB As System.Windows.Forms.TextBox
    Friend WithEvents AqtyTB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PrinterConfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteBT As System.Windows.Forms.Button
    Friend WithEvents EnablegstCB As System.Windows.Forms.CheckBox
    Friend WithEvents RefreshBT As System.Windows.Forms.Button

End Class
