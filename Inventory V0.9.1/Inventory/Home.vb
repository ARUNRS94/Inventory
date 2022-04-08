Imports System.Data.SqlClient
Imports System.Drawing.Printing
Public Class Home
    Public edittext1 As String
    Public edittext2 As String
    Public edittext3 As String
    Public edittext4 As String
    Public edittext5 As String
    Public edittext6 As String

    Private Function billnogenerate()

        Dim cmd3 As New SqlCommand
        Dim read As SqlDataReader
        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("yyyyMM")

        If EnablegstCB.Checked = False Then
            conn = GetConnect()
            cmd3 = New SqlCommand("  SELECT TOP 1 Sno,Date FROM Sales_gst Where GST='GST' ORDER BY Rowno DESC ", conn)
            conn.Open()
            read = cmd3.ExecuteReader(CommandBehavior.CloseConnection)
            read.Read()
            Dim lastDate As Date = (read("Date").ToString())
            Dim strlastDate As String = lastDate.ToString("yyyyMM")

            If strlastDate = strDate Then
                BSnoTB.Text = Format(((read("Sno").ToString()) + 1), "0000")
                BnoTB.Text = strDate & BSnoTB.Text

            Else
                BnoTB.Text = strDate & "0001"
                BSnoTB.Text = "0001"
            End If
            read.Close()
            conn.Close()
        Else
            conn = GetConnect()
            cmd3 = New SqlCommand("  SELECT TOP 1 Sno,Date FROM Sales_gst Where GST='NGST' ORDER BY Rowno DESC ", conn)
            conn.Open()
            read = cmd3.ExecuteReader(CommandBehavior.CloseConnection)
            read.Read()
            Dim lastDate As Date = (read("Date").ToString())
            Dim strlastDate As String = lastDate.ToString("yyyyMM")

            If strlastDate = strDate Then
                BSnoTB.Text = Format(((read("Sno").ToString()) + 1), "0000")
                BnoTB.Text = "N" & strDate & BSnoTB.Text

            Else
                BnoTB.Text = "N" & strDate & "0001"
                BSnoTB.Text = "0001"
            End If
            read.Close()
            conn.Close()
        End If
        Return BnoTB.Text
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tpriceTB.Enabled = False
        upriceTB.Enabled = False
        mrpTB.Enabled = False
        tpriceTB.Enabled = False
        gstTB.Enabled = False
        BnoTB.Enabled = False
        AqtyTB.Enabled = False
        gtotalTB.Enabled = False
        gsttotalTB.Enabled = False
        damounttotalTB.Enabled = False
        billnogenerate()

        conn = GetConnect()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("select Product.Pid,Product.Pname from Product INNER JOIN Brand ON Product.PBid=Brand.Bid", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim ptable As New DataTable
        adapter.Fill(ptable)
        Dim row As DataRow = ptable.NewRow()
        'Insert the Default Item to DataTable.
        row(0) = 0
        row(1) = "Please select"
        ptable.Rows.InsertAt(row, 0)
        pdetailsCB.ValueMember = "Pid"
        pdetailsCB.DisplayMember = "Pname"
        pdetailsCB.DataSource = ptable

        Dim cmd2 As New SqlCommand
        cmd2 = New SqlCommand("select Cid,Cname from Customer", conn)
        Dim adapter1 As New SqlDataAdapter(cmd2)
        Dim ctable As New DataTable
        adapter1.Fill(ctable)
        Dim row2 As DataRow = ctable.NewRow()
        'Insert the Default Item to DataTable.
        row2(0) = 0
        row2(1) = "Please select"
        ctable.Rows.InsertAt(row2, 0)
        CtypeCB.ValueMember = "Cid"
        CtypeCB.DisplayMember = "Cname"
        CtypeCB.DataSource = ctable
        damountTB.Text = 0

        Dim cmd3 As New SqlCommand
        cmd3.Connection = conn
        cmd3 = New SqlCommand("  select [Pid], [Qty],[Min] from [Product]  where ([Qty]<=[Min])", conn)
        Dim adapter3 As New SqlDataAdapter(cmd3)
        Dim table As New DataTable()
        adapter3.Fill(table)
        If table.Rows.Count() > 0 Then
            MqtyBT.Visible = True
        Else
            MqtyBT.Visible = False
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aqty As Integer
        Dim eqty As Integer
        If AqtyTB.Text <> "" Or qtyTB.Text <> "" Then
            aqty = AqtyTB.Text
            eqty = qtyTB.Text
        End If

        If upriceTB.Text = "" Or tpriceTB.Text = "" Or qtyTB.Text = "" Or mrpTB.Text = "" Then
            MessageBox.Show("Required fields are missing text")


        ElseIf aqty < eqty And IsNumeric(qtyTB.Text) Then
            MessageBox.Show("Entered qty is not avaliable")
        Else

            Dim rnum As Integer = DataGridView1.Rows.Add()

            DataGridView1.Rows.Item(rnum).Cells("pdetails").Value = pdetailsCB.Text
            DataGridView1.Rows.Item(rnum).Cells("brand").Value = brandCB.Text
            DataGridView1.Rows.Item(rnum).Cells("qty").Value = qtyTB.Text
            DataGridView1.Rows.Item(rnum).Cells("uprice").Value = upriceTB.Text
            DataGridView1.Rows.Item(rnum).Cells("mrp").Value = mrpTB.Text
            DataGridView1.Rows.Item(rnum).Cells("damount").Value = damountTB.Text
            DataGridView1.Rows.Item(rnum).Cells("gst").Value = ((tpriceTB.Text) * (gstTB.Text)) / 100
            DataGridView1.Rows.Item(rnum).Cells("pid").Value = PidTB.Text

            DataGridView1.CurrentCell = DataGridView1(0, DataGridView1.Rows.Count - 1)
            Dim gtotal As Decimal = 0
            Dim dtotal As Decimal = 0
            Dim gsttotal As Decimal = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                gtotal += row.Cells("tprice").Value
                gtotal = gtotal + row.Cells("gst").Value
                dtotal += row.Cells("damount").Value
                gsttotal += row.Cells("gst").Value

            Next
            gtotalTB.Text = gtotal.ToString("0.00")
            damounttotalTB.Text = dtotal.ToString("0.00")
            gsttotalTB.Text = gsttotal.ToString("0.00")
            ProductSTB.Text = ""
            pdetailsCB.SelectedIndex = 0
            brandCB.SelectedIndex = 0
            qtyTB.Text = ""
            upriceTB.Text = ""
            damountTB.Text = 0
            tpriceTB.Text = ""
            gstTB.Text = ""
            mrpTB.Text = ""
            AqtyTB.Text = ""
            ProductSTB.Focus()
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles qtyTB.TextChanged, damountTB.TextChanged

        If IsNumeric(qtyTB.Text) Then

        ElseIf qtyTB.Text = "" Then
        Else
            MessageBox.Show("Entered value is incorrect")
        End If

        If IsNumeric(damountTB.Text) Then
            If qtyTB.Text <> "" And damountTB.Text <> "" Then
                Dim qty As Double = qtyTB.Text
                Dim price As Double = upriceTB.Text
                Dim dprice As Double = damountTB.Text
                Dim total As Double = (qty * price) - dprice
                tpriceTB.Text = (FormatNumber(total))

            End If
        ElseIf damountTB.Text = "" Then

            If qtyTB.Text <> "" And damountTB.Text = "" Then
                Dim qty As Double = qtyTB.Text
                Dim price As Double = upriceTB.Text
                Dim total As Double = (qty * price)
                tpriceTB.Text = (FormatNumber(total))
            End If

        Else
                MessageBox.Show("Entered value is incorrect")
        End If

    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Hide()

        'Master.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles SavePrintBT.Click
        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("yyyy-MM-dd")
        If DataGridView1.Rows.Count <> 0 Then
            Try
                For Each row As DataGridViewRow In DataGridView1.Rows
                    conn = GetConnect()
                    Dim cmd As New SqlCommand
                    cmd.Connection = conn
                    cmd = New SqlCommand("insert into Sales_gst (Sno,Billno,Customername,Cid,Mobileno,Date,Pid,Qty,Discount,GST) values (@sno,@billno,@custname,@cid,@mobileno,@billdate,@pid,@qty,@discount,@gst)", conn)
                    cmd.Parameters.AddWithValue("@qty", row.Cells("qty").Value)
                    cmd.Parameters.AddWithValue("@discount", row.Cells("damount").Value)
                    cmd.Parameters.AddWithValue("@billno", BnoTB.Text)
                    cmd.Parameters.AddWithValue("@custname", CnameTB.Text)
                    cmd.Parameters.AddWithValue("@mobileno", MobilrTB.Text)
                    cmd.Parameters.AddWithValue("@billdate", strDate)
                    cmd.Parameters.AddWithValue("@pid", row.Cells("Pid").Value)
                    cmd.Parameters.AddWithValue("@sno", BSnoTB.Text)
                    cmd.Parameters.AddWithValue("@cid", CtypeCB.SelectedValue)
                    If EnablegstCB.Checked = False Then
                        cmd.Parameters.AddWithValue("@gst", "GST")
                    Else
                        cmd.Parameters.AddWithValue("@gst", "NGST")

                    End If
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    conn = GetConnect()
                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = conn
                    cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid]", conn)
                    conn.Open()
                    cmd2.ExecuteNonQuery()
                    cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum - t3.field3Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid] INNER JOIN (select [Pid], sum([Qty]) as field3Sum from [Sales_gst] group by [Pid]) as t3 on t3.[Pid] = t1.[Pid]", conn)
                    cmd2.ExecuteNonQuery()
                    conn.Close()

                    Dim cmd3 As New SqlCommand
                    cmd3.Connection = conn
                    cmd3 = New SqlCommand("  select [Pid], [Qty],[Min] from [Product]  where ([Qty]<=[Min])", conn)
                    Dim adapter3 As New SqlDataAdapter(cmd3)
                    Dim table As New DataTable()
                    adapter3.Fill(table)
                    If table.Rows.Count() > 0 Then
                        MqtyBT.Visible = True
                    Else
                        MqtyBT.Visible = False
                    End If

                Next

                MessageBox.Show("Records inserted.")
                changelongpaper()
                PPD.Document = PD
                PPD.ShowDialog()
                'PD.Print()  'Direct Print
                For Each ctl In Controls
                    If TypeOf ctl Is TextBox Then ctl.Text = ""
                Next ctl
                DataGridView1.Rows.Clear()
                SnoTB.Text = "0"
                gsttotalTB.Text = ""
                gtotalTB.Text = ""
                damounttotalTB.Text = ""
                MobilrTB.Text = ""
                CnameTB.Text = ""
                damountTB.Text = 0
                billnogenerate()
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Me.Enabled = False
        'SalesReport.Show()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)
        Try
            If ProductSTB.Text <> "" Then
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                'cmd = New SqlCommand("SELECT * FROM Product WHERE Item_code = @item_code ", conn)
                cmd = New SqlCommand("itemcodesearch", conn)
                cmd.Parameters.AddWithValue("@item_code", ProductSTB.Text.Trim())
                cmd.CommandType = CommandType.StoredProcedure
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                pdetailsCB.Enabled = False
                upriceTB.Enabled = False
                If table.Rows.Count > 0 Then
                    pdetailsCB.Text = table.Rows(0)(3).ToString() & "-" & table.Rows(0)(2).ToString()
                    upriceTB.Text = table.Rows(0)(6).ToString()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ClearBT.Click
        For Each ctl In Controls
            If TypeOf ctl Is TextBox Then ctl.Text = ""
        Next ctl
        DataGridView1.Rows.Clear()
        pdetailsCB.SelectedIndex = 0
    End Sub


    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim gtotal As Decimal = 0
        Dim dtotal As Decimal = 0
        Dim gsttotal As Decimal = 0
        Dim Rtotal As Decimal = 0
        SnoTB.Text = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            SnoTB.Text += 1
            gtotal += row.Cells("tprice").Value
            gtotal = gtotal + row.Cells("gst").Value
            Rtotal = (row.Cells("qty").Value) * (row.Cells("uprice").Value)
            dtotal += row.Cells("damount").Value
            gsttotal += row.Cells("gst").Value
            row.Cells("Sno").Value = SnoTB.Text
            row.Cells("tprice").Value = Rtotal.ToString("0.00")

        Next
        gtotalTB.Text = gtotal.ToString("0.00")
        damounttotalTB.Text = dtotal.ToString("0.00")
        gsttotalTB.Text = gsttotal.ToString("0.00")


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles EditBT.Click
        Dim row_index As Int16
        row_index = DataGridView1.CurrentCell.RowIndex
        DataGridView1.ReadOnly = False
        DataGridView1.Columns("Sno").ReadOnly = True
        DataGridView1.Columns("pdetails").ReadOnly = True
        DataGridView1.Columns("brand").ReadOnly = True
        DataGridView1.Columns("gst").ReadOnly = True
        DataGridView1.Columns("uprice").ReadOnly = True
        DataGridView1.Columns("mrp").ReadOnly = True
        DataGridView1.Columns("damount").ReadOnly = True
        DataGridView1.Columns("tprice").ReadOnly = True
        DataGridView1.Rows.Item(row_index).Cells("qty").ReadOnly = False

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click
        SnoTB.Text = 0
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim row_index As Int16
            row_index = DataGridView1.CurrentCell.RowIndex
            DataGridView1.Rows.RemoveAt(row_index)
            For Each row As DataGridViewRow In DataGridView1.Rows
                SnoTB.Text += 1
                row.Cells("Sno").Value = SnoTB.Text
            Next
        End If
    End Sub




    '''''Printer'''

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 200
    End Sub
    ' Private Sub BTPRINT_Click(sender As Object, e As EventArgs) Handles PrintBT.Click
    '   changelongpaper()
    '   PPD.Document = PD
    '    PPD.ShowDialog()
    'PD.Print()  'Direct Print

    '  End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Arial", 8, FontStyle.Regular)
        Dim f8b As New Font("Arial", 8, FontStyle.Bold)
        Dim f10 As New Font("Arial", 10, FontStyle.Regular)
        Dim f10b As New Font("Arial", 10, FontStyle.Bold)
        Dim f14 As New Font("Arial", 14, FontStyle.Bold)
        Dim line As New Pen(Brushes.Black, 1)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width


        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        If EnablegstCB.Checked = False Then
            'e.Graphics.DrawString((Print data), (font size,font name,etc), (font Colour-Brushes), X-axis, Y-axis)
            e.Graphics.DrawString("PALANIAPPA & CO", f14, Brushes.Black, centermargin, 5, center)
            e.Graphics.DrawString("17-C Rasipuram Mainroad", f8, Brushes.Black, centermargin, 25, center)
            e.Graphics.DrawString("Attayampatti,Salem - 637501", f8, Brushes.Black, centermargin, 37, center)
            e.Graphics.DrawString("GST : 33AGIP9304P3Z2", f8, Brushes.Black, centermargin, 50, center)
        Else

            e.Graphics.DrawString("ESTIMATION", f14, Brushes.Black, centermargin, 25, center)

        End If
        e.Graphics.DrawString("Invoice ID", f8b, Brushes.Black, 0, 67)
        e.Graphics.DrawString(":", f8b, Brushes.Black, 55, 64)
        e.Graphics.DrawString((BnoTB.Text), f8, Brushes.Black, 70, 67)


        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("dd-MM-yyyy hh/mm")

        e.Graphics.DrawString(strDate, f8, Brushes.Black, rightmargin, 67, right)

        'e.Graphics.DrawLine((Colour and width), (Line Starting pt x-axis),(Y-Axis), (Line Ending pt x-axis), (Y-Axis))
        e.Graphics.DrawLine(line, 20, 85, 230, 85)

        e.Graphics.DrawString("Item", f8b, Brushes.Black, 0, 95)
        'e.Graphics.DrawString("Qty", f8b, Brushes.Black, 100, 95)
        e.Graphics.DrawString("Qty", f8b, Brushes.Black, 160, 95)
        e.Graphics.DrawString("Price", f8b, Brushes.Black, rightmargin, 95, right)


        Dim height As Integer
        DataGridView1.AllowUserToAddRows = False

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString & " " & DataGridView1.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 0, 100 + height)
            ' e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 100, 100 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 160, 100 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(7).Value.ToString, f8, Brushes.Black, rightmargin, 100 + height, right)

        Next


        Dim height2 As Integer
        height2 = 114 + height
        e.Graphics.DrawLine(line, 20, 114 + height, 230, 114 + height)
        e.Graphics.DrawString("Total: " & (gtotalTB.Text), f10b, Brushes.Black, rightmargin, 10 + height2, right)

        If EnablegstCB.Checked = False Then
            e.Graphics.DrawString("For Palaniappa & CO ", f8, Brushes.Black, rightmargin, 24 + height2, right)
            e.Graphics.DrawString("Including GST", f10, Brushes.Black, 0, 10 + height2)
        Else
        End If
        e.Graphics.DrawString("~ Thanks for shopping ~", f10, Brushes.Black, centermargin, 35 + height2, center)
        e.Graphics.DrawString(" ", f10, Brushes.Black, centermargin, 50 + height2, center)
    End Sub


    Private Sub MasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        Me.Enabled = False
        Master.Show()
    End Sub

    Private Sub InwardGoodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InwardGoodsToolStripMenuItem.Click
        Me.Enabled = False
        Inward.Show()
    End Sub


    Private Sub ProductSTB_KeyUp(sender As Object, e As KeyEventArgs) Handles ProductSTB.KeyUp
        If ProductSTB.Text <> "" Then
            conn = GetConnect()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select Pid,Pname from Product WHERE Pname LIKE '%' + @productname + '%' OR @productname = '' ", conn)
            cmd.Parameters.AddWithValue("@productname", ProductSTB.Text.Trim())
            Dim adapter As New SqlDataAdapter(cmd)
            Dim ptable As New DataTable
            adapter.Fill(ptable)
            Dim row As DataRow = ptable.NewRow()
            pdetailsCB.ValueMember = "Pid"
            pdetailsCB.DisplayMember = "Pname"
            pdetailsCB.DataSource = ptable
        Else
            tpriceTB.Enabled = False
            conn = GetConnect()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select Pid,Pname from Product ", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim ptable As New DataTable
            adapter.Fill(ptable)
            Dim row As DataRow = ptable.NewRow()
            'Insert the Default Item to DataTable.
            row(0) = 0
            row(1) = "Please select"
            ptable.Rows.InsertAt(row, 0)
            pdetailsCB.ValueMember = "Pid"
            pdetailsCB.DisplayMember = "Pname"
            pdetailsCB.DataSource = ptable

        End If
    End Sub

    Private Sub pdetailsCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles pdetailsCB.SelectedIndexChanged
        conn = GetConnect()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("select Brand.Bid,Brand.Bname from Brand INNER JOIN Product ON Brand.Bid=Product.PBid Where Product.Pname = '" & pdetailsCB.Text & "'", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim btable As New DataTable
        adapter.Fill(btable)
        Dim row1 As DataRow = btable.NewRow()
        'Insert the Default Item to DataTable.
        row1(0) = 0
        row1(1) = "Please select"
        btable.Rows.InsertAt(row1, 0)
        brandCB.ValueMember = "Bid"
        brandCB.DisplayMember = "Bname"
        brandCB.DataSource = btable
    End Sub

    Private Sub brandCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles brandCB.SelectionChangeCommitted

        If brandCB.Text = "Please select" Then
            upriceTB.Text = ""
            mrpTB.Text = ""
            gstTB.Text = ""
            PidTB.Text = ""
            AqtyTB.Text = ""
        Else

            Dim cmd As New SqlCommand
            Dim read As SqlDataReader
            cmd = New SqlCommand("Select Uprice,Pmrp,Pgst,Qty from Product Where Pname = '" & pdetailsCB.Text & "' AND PBid = '" & brandCB.SelectedValue & "'", conn)
            conn.Open()
            read = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            read.Read()
            upriceTB.Text = read("Uprice").ToString()
            mrpTB.Text = read("Pmrp").ToString()
            gstTB.Text = read("Pgst").ToString()
            PidTB.Text = pdetailsCB.SelectedValue
            AqtyTB.Text = read("Qty").ToString()
            read.Close()
            conn.Close()
        End If
        For i = 0 To DataGridView1.Rows.Count - 1
            If pdetailsCB.Text = DataGridView1.Rows(i).Cells("pdetails").Value.ToString And brandCB.Text = DataGridView1.Rows(i).Cells("brand").Value.ToString Then
                MessageBox.Show("record already exist")
                ProductSTB.Text = ""
                pdetailsCB.SelectedIndex = 0
                brandCB.SelectedIndex = 0
                qtyTB.Text = ""
                upriceTB.Text = ""
                damountTB.Text = 0
                tpriceTB.Text = ""
                gstTB.Text = ""
                mrpTB.Text = ""
                AqtyTB.Text = ""
                ProductSTB.Focus()
            End If
        Next

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles MqtyBT.Click
        Me.Enabled = False
        Min_Qty.Show()
    End Sub

    Private Sub QtyCheckToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QtyCheckToolStripMenuItem.Click
        Me.Enabled = False
        Qty_Check.Show()
    End Sub

    Private Sub PrinterConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrinterConfigToolStripMenuItem.Click
        Dim dlg As New PrintDialog
        dlg.ShowDialog()
    End Sub

    Private Sub EnablegstCB_CheckedChanged(sender As Object, e As EventArgs) Handles EnablegstCB.CheckedChanged
        billnogenerate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RefreshBT.Click

        conn = GetConnect()
        Dim cmd2 As New SqlCommand
        cmd2.Connection = conn
        cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum - t3.field3Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid] INNER JOIN (select [Pid], sum([Qty]) as field3Sum from [Sales_gst] group by [Pid]) as t3 on t3.[Pid] = t1.[Pid]", conn)
        conn.Open()
        cmd2.ExecuteNonQuery()
        conn.Close()
        billnogenerate()
    End Sub

    Private Sub PrintBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("yyyy-MM-dd")
        If DataGridView1.Rows.Count <> 0 Then
            Try
                For Each row As DataGridViewRow In DataGridView1.Rows
                    conn = GetConnect()
                    Dim cmd As New SqlCommand
                    cmd.Connection = conn
                    cmd = New SqlCommand("insert into Sales_gst (Sno,Billno,Customername,Cid,Mobileno,Date,Pid,Qty,Discount,GST) values (@sno,@billno,@custname,@cid,@mobileno,@billdate,@pid,@qty,@discount,@gst)", conn)
                    cmd.Parameters.AddWithValue("@qty", row.Cells("qty").Value)
                    cmd.Parameters.AddWithValue("@discount", row.Cells("damount").Value)
                    cmd.Parameters.AddWithValue("@billno", BnoTB.Text)
                    cmd.Parameters.AddWithValue("@custname", CnameTB.Text)
                    cmd.Parameters.AddWithValue("@mobileno", MobilrTB.Text)
                    cmd.Parameters.AddWithValue("@billdate", strDate)
                    cmd.Parameters.AddWithValue("@pid", row.Cells("Pid").Value)
                    cmd.Parameters.AddWithValue("@sno", BSnoTB.Text)
                    cmd.Parameters.AddWithValue("@cid", CtypeCB.SelectedValue)
                    If EnablegstCB.Checked = False Then
                        cmd.Parameters.AddWithValue("@gst", "GST")
                    Else
                        cmd.Parameters.AddWithValue("@gst", "NGST")

                    End If
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    conn = GetConnect()
                    Dim cmd2 As New SqlCommand
                    cmd2.Connection = conn
                    cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid]", conn)
                    conn.Open()
                    cmd2.ExecuteNonQuery()
                    cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum - t3.field3Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid] INNER JOIN (select [Pid], sum([Qty]) as field3Sum from [Sales_gst] group by [Pid]) as t3 on t3.[Pid] = t1.[Pid]", conn)
                    cmd2.ExecuteNonQuery()
                    conn.Close()

                    Dim cmd3 As New SqlCommand
                    cmd3.Connection = conn
                    cmd3 = New SqlCommand("  select [Pid], [Qty],[Min] from [Product]  where ([Qty]<=[Min])", conn)
                    Dim adapter3 As New SqlDataAdapter(cmd3)
                    Dim table As New DataTable()
                    adapter3.Fill(table)
                    If table.Rows.Count() > 0 Then
                        MqtyBT.Visible = True
                    Else
                        MqtyBT.Visible = False
                    End If

                Next

                MessageBox.Show("Records inserted.")
                changelongpaper()
                PPD.Document = PD
                PPD.ShowDialog()
                'PD.Print()  'Direct Print
                For Each ctl In Controls
                    If TypeOf ctl Is TextBox Then ctl.Text = ""
                Next ctl
                DataGridView1.Rows.Clear()
                SnoTB.Text = "0"
                gsttotalTB.Text = ""
                gtotalTB.Text = ""
                damounttotalTB.Text = ""
                MobilrTB.Text = ""
                CnameTB.Text = ""
                damountTB.Text = 0
                billnogenerate()
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub
End Class
