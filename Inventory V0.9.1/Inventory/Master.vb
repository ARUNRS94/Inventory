Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Master
    ''''''''''!!!!!!!!!!!!!!!!!!!!BRAND MASTER CODE!!!!!!!!!!!!!!!!!!!!!''''''''''''''''''''''''''''''''''''''

    Public Sub Bdatagridrefresh()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("select * from Brand", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim btable As New DataTable
        adapter.Fill(btable)
        BDataGridView.DataSource = btable
        'With BDataGridView
        BDataGridView.RowHeadersVisible = False
        BDataGridView.Columns(0).HeaderText = "Brand ID"
        BDataGridView.Columns(1).HeaderText = "Brand Name"
        'End With
        BDataGridView.ClearSelection()
    End Sub

    Private Sub Master_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Me.Close()
        Home.Show()
        Home.Enabled = True
    End Sub

    Private Sub BAddBT_Click(sender As Object, e As EventArgs) Handles BAddBT.Click
        If BrandTB.Text = "" Then
            MessageBox.Show("Enter Brand Name")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Brand WHERE Bname='" & BrandTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    MessageBox.Show("Brand Name Already Available!")
                Else
                    conn = GetConnect()

                    cmd = New SqlCommand("insert into Brand (Bname) values (@brandname)", conn)
                    cmd.Parameters.AddWithValue("@brandname", BrandTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record saved!")
                    Bdatagridrefresh()
                    BrandTB.Text = ""
                    BrandSTB.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Function BPopulateDataGridView() As DataTable
        conn = GetConnect()
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd = New SqlCommand("SELECT Bid,Bname FROM Brand WHERE Bname LIKE '%' + @brandname + '%' OR @brandname = '' ", conn)
        cmd.Parameters.AddWithValue("@brandname", BrandSTB.Text.Trim())
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        Return table

    End Function

    Private Sub BrandSTB_KeyUp(sender As Object, e As KeyEventArgs) Handles BrandSTB.KeyUp
        BDataGridView.DataSource = Me.BPopulateDataGridView()
        BDataGridView.RowHeadersVisible = False
        BDataGridView.Columns(0).HeaderText = "Brand ID"
        BDataGridView.Columns(1).HeaderText = "Brand Name"
    End Sub

    Private Sub BDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles BDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = BDataGridView.Rows(index)
        BrandTB.Text = selectedRow.Cells(1).Value.ToString()
        BidTB.Text = selectedRow.Cells(0).Value.ToString()

    End Sub

    Private Sub BClearBT_Click(sender As Object, e As EventArgs) Handles BClearBT.Click
        BrandTB.Text = ""
        BrandSTB.Text = ""
        Bdatagridrefresh()
    End Sub

    Private Sub BUpdateBT_Click(sender As Object, e As EventArgs) Handles BUpdateBT.Click
        If BrandTB.Text = "" Then
            MessageBox.Show("Select Brand Name to be updated")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Brand WHERE Bid='" & BidTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("Brand Name Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("update Brand set Bname=@brandname Where Bid=@B_id", conn)
                    cmd.Parameters.AddWithValue("@brandname", BrandTB.Text)
                    cmd.Parameters.AddWithValue("@B_id", BidTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Updated!")
                    Bdatagridrefresh()
                    BrandTB.Text = ""
                    BrandSTB.Text = ""

                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Sub BDeleteBT_Click(sender As Object, e As EventArgs) Handles BDeleteBT.Click
        If BrandTB.Text = "" Then
            MessageBox.Show("Select Brand Name to be Deleted")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Brand WHERE Bid='" & BidTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("Brand Name Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("Delete from Brand Where Bid=@B_id", conn)
                    cmd.Parameters.AddWithValue("@B_id", BidTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Deleted!")
                    Bdatagridrefresh()
                    BrandTB.Text = ""
                    BrandSTB.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    '''''''''''''''''!!!!!!!!!!!!!!!!CUSTOMER MASTER CODE!!!!!!!!!!!!!!''''''''''''''''''''''

    Public Sub Cdatagridrefresh()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("select * from Customer", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        CDataGridView.DataSource = table
        'With BDataGridView
        CDataGridView.RowHeadersVisible = False
        CDataGridView.Columns(0).HeaderText = "Customer ID"
        CDataGridView.Columns(1).HeaderText = "Customer Name"
        'End With
        CDataGridView.ClearSelection()
    End Sub

    Private Sub CAddBT_Click(sender As Object, e As EventArgs) Handles CAddBT.Click
        If CustomerTB.Text = "" Then
            MessageBox.Show("Enter Customer Type")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Customer WHERE Cname='" & CustomerTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    MessageBox.Show("Customer Type Already Available!")
                Else
                    conn = GetConnect()

                    cmd = New SqlCommand("insert into Customer (Cname) values (@customername)", conn)
                    cmd.Parameters.AddWithValue("@customername", CustomerTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record saved!")
                    Cdatagridrefresh()
                    CustomerTB.Text = ""
                    CustomerSTB.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Function CPopulateDataGridView() As DataTable
        conn = GetConnect()
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd = New SqlCommand("SELECT Cid,Cname FROM Customer WHERE Cname LIKE '%' + @customername + '%' OR @customername = '' ", conn)
        cmd.Parameters.AddWithValue("@customername", CustomerSTB.Text.Trim())
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Ctable As New DataTable()
        adapter.Fill(Ctable)
        Return Ctable

    End Function

    Private Sub CustomerSTB_KeyUp(sender As Object, e As KeyEventArgs) Handles CustomerSTB.KeyUp
        CDataGridView.DataSource = Me.CPopulateDataGridView()
        CDataGridView.RowHeadersVisible = False
        CDataGridView.Columns(0).HeaderText = "Customer ID"
        CDataGridView.Columns(1).HeaderText = "Customer Name"
    End Sub

    Private Sub CDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = CDataGridView.Rows(index)
        CustomerTB.Text = selectedRow.Cells(1).Value.ToString()
        CidTB.Text = selectedRow.Cells(0).Value.ToString()

    End Sub

    Private Sub CClearBT_Click(sender As Object, e As EventArgs) Handles CCleanBT.Click
        CustomerTB.Text = ""
        CustomerSTB.Text = ""
        Cdatagridrefresh()
    End Sub

    Private Sub CUpdateBT_Click(sender As Object, e As EventArgs) Handles CUpdateBT.Click
        If CustomerTB.Text = "" Then
            MessageBox.Show("Select Customer Type to be updated")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Customer WHERE Cid='" & CidTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("Customer Type Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("update Customer set Cname=@customername Where Cid=@C_id", conn)
                    cmd.Parameters.AddWithValue("@customername", CustomerTB.Text)
                    cmd.Parameters.AddWithValue("@C_id", CidTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Updated!")
                    Cdatagridrefresh()
                    CustomerTB.Text = ""
                    CustomerSTB.Text = ""

                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Sub CDeleteBT_Click(sender As Object, e As EventArgs) Handles CDeleteBT.Click
        If CustomerTB.Text = "" Then
            MessageBox.Show("Select Customer Type to be Deleted")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Customer WHERE Cid='" & CidTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("Customer Type Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("Delete from Customer Where Cid=@C_id", conn)
                    cmd.Parameters.AddWithValue("@C_id", CidTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Deleted!")
                    Cdatagridrefresh()
                    CustomerTB.Text = ""
                    CustomerSTB.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    '''''''''''''''''''''!!!!!!!!!!!!!!!!!!PRODUCT MASTER!!!!!!!!!!!!!!!!!!!!!!!'''''''''''''

    Private Sub Mastertab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Mastertab.SelectedIndexChanged
        Select Case Mastertab.SelectedIndex
            Case 2
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd = New SqlCommand("select * from Brand", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim btable As New DataTable
                adapter.Fill(btable)
                Dim row As DataRow = btable.NewRow()
                'Insert the Default Item to DataTable.
                row(0) = 0
                row(1) = "Please select"
                btable.Rows.InsertAt(row, 0)
                BCBox.ValueMember = "Bid"
                BCBox.DisplayMember = "Bname"
                BCBox.DataSource = btable

        End Select
    End Sub

    Public Sub Pdatagridrefresh()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("  select Product.Pid,Brand.Bname,Product.Pname,Product.Bprice,Product.Pdetails,Product.Uprice,Product.Pcom,Product.Pmrp,Product.Pgst,Product.Min from Product INNER JOIN Brand ON Product.PBid=Brand.Bid", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        PDataGridView.DataSource = table
        'With BDataGridView
        PDataGridView.RowHeadersVisible = False
        PDataGridView.Columns(0).HeaderText = "Product ID"
        PDataGridView.Columns(1).HeaderText = "Brand Name"
        PDataGridView.Columns(2).HeaderText = "Product Name"
        PDataGridView.Columns(3).HeaderText = "Buy Price"
        PDataGridView.Columns(4).HeaderText = "Product Details"
        PDataGridView.Columns(5).HeaderText = "Sell Price"
        PDataGridView.Columns(6).HeaderText = "Comission"
        PDataGridView.Columns(7).HeaderText = "MRP"
        PDataGridView.Columns(8).HeaderText = "GST"
        PDataGridView.Columns(9).HeaderText = "Min"
        'End With
        PDataGridView.ClearSelection()
    End Sub

    Private Sub PAddBT_Click(sender As Object, e As EventArgs) Handles PAddBT.Click
        If PNameTB.Text = "" Then
            MessageBox.Show("Enter Product Name")
        ElseIf BCBox.Text = "Please select" Then
            MessageBox.Show("Select the Brand Name")
        ElseIf BPriceTB.Text = "" Then
            MessageBox.Show("Enter Buy Price")
        ElseIf UPriceTB.Text = "" Then
            MessageBox.Show("Enter Sell Price")
        ElseIf GstTB.Text = "" Then
            MessageBox.Show("Enter Gst")
        ElseIf ComTB.Text = "" Then
            MessageBox.Show("Enter Comission")
        ElseIf MrpTB.Text = "" Then
            MessageBox.Show("Enter MRP")
        ElseIf PDetailsTB.Text = "" Then
            MessageBox.Show("Enter Product Details")
        ElseIf MinTB.Text = "" Then
            MessageBox.Show("Enter Min Qty")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Product WHERE Pname='" & PNameTB.Text & "' AND PBid = '" & BCBox.SelectedValue & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable
                adapter.Fill(table)
                If table.Rows.Count() > 0 Then
                    MessageBox.Show("Product Already Available!")
                Else
                    conn = GetConnect()

                    cmd = New SqlCommand("insert into Product (PBid,Pname,Bprice,Pdetails,Uprice,Pcom,Pmrp,Pgst,Min) values (@pbrandid,@pname,@bprice,@pdetails,@uprice,@pcom,@pmrp,@pgst,@pmin)", conn)
                    cmd.Parameters.AddWithValue("@pbrandid", BCBox.SelectedValue)
                    cmd.Parameters.AddWithValue("@pname", PNameTB.Text)
                    cmd.Parameters.AddWithValue("@bprice", BPriceTB.Text)
                    cmd.Parameters.AddWithValue("@pdetails", PDetailsTB.Text)
                    cmd.Parameters.AddWithValue("@uprice", UPriceTB.Text)
                    cmd.Parameters.AddWithValue("@pcom", ComTB.Text)
                    cmd.Parameters.AddWithValue("@pmrp", MrpTB.Text)
                    cmd.Parameters.AddWithValue("@pgst", GstTB.Text)
                    cmd.Parameters.AddWithValue("@pmin", MinTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record saved!")
                    Pdatagridrefresh()
                    CustomerTB.Text = ""
                    CustomerSTB.Text = ""
                    PidTB.Text = ""
                    BCBox.Text = ""
                    PNameTB.Text = ""
                    BPriceTB.Text = ""
                    PDetailsTB.Text = ""
                    UPriceTB.Text = ""
                    ComTB.Text = ""
                    MrpTB.Text = ""
                    GstTB.Text = ""
                    MinTB.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Function PPopulateDataGridView() As DataTable
        conn = GetConnect()
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd = New SqlCommand("select Product.Pid,Brand.Bname,Product.Pname,Product.Bprice,Product.Pdetails,Product.Uprice,Product.Pcom,Product.Pmrp,Product.Pgst,Product.Min from Product INNER JOIN Brand ON Product.PBid=Brand.Bid WHERE Pname LIKE '%' + @productname + '%' OR @productname = '' ", conn)
        cmd.Parameters.AddWithValue("@productname", PNameSTB.Text.Trim())
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Ptable As New DataTable()
        adapter.Fill(Ptable)
        Return Ptable

    End Function

    Private Sub PNameSTB_KeyUp(sender As Object, e As KeyEventArgs) Handles PNameSTB.KeyUp
        PDataGridView.DataSource = Me.PPopulateDataGridView()
        PDataGridView.RowHeadersVisible = False
        PDataGridView.Columns(0).HeaderText = "Product ID"
        PDataGridView.Columns(1).HeaderText = "Brand Name"
        PDataGridView.Columns(2).HeaderText = "Product Name"
        PDataGridView.Columns(3).HeaderText = "Buy Price"
        PDataGridView.Columns(4).HeaderText = "Product Details"
        PDataGridView.Columns(5).HeaderText = "Sell Price"
        PDataGridView.Columns(6).HeaderText = "Comission"
        PDataGridView.Columns(7).HeaderText = "MRP"
        PDataGridView.Columns(8).HeaderText = "GST"
        PDataGridView.Columns(8).HeaderText = "Min"
    End Sub

    Private Sub PDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles PDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = PDataGridView.Rows(index)
        PidTB.Text = selectedRow.Cells(0).Value.ToString()
        BCBox.Text = selectedRow.Cells(1).Value.ToString()
        PNameTB.Text = selectedRow.Cells(2).Value.ToString()
        BPriceTB.Text = selectedRow.Cells(3).Value.ToString()
        PDetailsTB.Text = selectedRow.Cells(4).Value.ToString()
        UPriceTB.Text = selectedRow.Cells(5).Value.ToString()
        ComTB.Text = selectedRow.Cells(6).Value.ToString()
        MrpTB.Text = selectedRow.Cells(7).Value.ToString()
        GstTB.Text = selectedRow.Cells(8).Value.ToString()
        MinTB.Text = selectedRow.Cells(9).Value.ToString()
    End Sub

    Private Sub PClearBT_Click(sender As Object, e As EventArgs) Handles CCleanBT.Click

        Pdatagridrefresh()
    End Sub

    Private Sub PUpdateBT_Click(sender As Object, e As EventArgs) Handles PUpdateBT.Click
        If PNameTB.Text = "" Then
            MessageBox.Show("Enter Product Name")
        ElseIf BCBox.Text = "Please select" Then
            MessageBox.Show("Select the Brand Name")
        ElseIf BPriceTB.Text = "" Then
            MessageBox.Show("Enter Buy Price")
        ElseIf UPriceTB.Text = "" Then
            MessageBox.Show("Enter Sell Price")
        ElseIf GstTB.Text = "" Then
            MessageBox.Show("Enter Gst")
        ElseIf ComTB.Text = "" Then
            MessageBox.Show("Enter Comission")
        ElseIf MrpTB.Text = "" Then
            MessageBox.Show("Enter MRP")
        ElseIf PDetailsTB.Text = "" Then
            MessageBox.Show("Enter Product Details")
        ElseIf MinTB.Text = "" Then
            MessageBox.Show("Enter Min Qty")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                Dim cmd2 As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Product WHERE Pid='" & PidTB.Text & "' AND PBid = '" & BCBox.SelectedValue & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim Ptable As New DataTable()
                adapter.Fill(Ptable)
                If Ptable.Rows.Count() = 0 Then
                    MessageBox.Show("Product Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("update Product set PBid=@pbrandid,Pname=@pname,Bprice=@bprice,Pdetails=@pdetails,Uprice=@uprice,Pcom=@pcom,Pmrp=@pmrp,Pgst=@pgst Where Pid=@P_id", conn)
                    cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum FROM [Product]  t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid]", conn)
                    cmd.Parameters.AddWithValue("@P_id", PidTB.Text)
                    cmd.Parameters.AddWithValue("@pbrandid", BCBox.SelectedValue)
                    cmd.Parameters.AddWithValue("@pname", PNameTB.Text)
                    cmd.Parameters.AddWithValue("@bprice", BPriceTB.Text)
                    cmd.Parameters.AddWithValue("@pdetails", PDetailsTB.Text)
                    cmd.Parameters.AddWithValue("@uprice", UPriceTB.Text)
                    cmd.Parameters.AddWithValue("@pcom", ComTB.Text)
                    cmd.Parameters.AddWithValue("@pmrp", MrpTB.Text)
                    cmd.Parameters.AddWithValue("@pgst", GstTB.Text)
                    cmd.Parameters.AddWithValue("@pmin", MinTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Updated!")
                    Pdatagridrefresh()
                    PidTB.Text = ""
                    BCBox.Text = ""
                    PNameTB.Text = ""
                    BPriceTB.Text = ""
                    PDetailsTB.Text = ""
                    UPriceTB.Text = ""
                    ComTB.Text = ""
                    MrpTB.Text = ""
                    GstTB.Text = ""
                    MinTB.Text = ""

                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Sub PDeleteBT_Click(sender As Object, e As EventArgs) Handles PDeleteBT.Click
        If PidTB.Text = "" Then
            MessageBox.Show("Select Product to be Deleted")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Product WHERE Pid='" & PidTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)
                If table.Rows.Count() = 0 Then
                    MessageBox.Show("Product Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("Delete from Product Where Pid=@P_id", conn)
                    cmd.Parameters.AddWithValue("@P_id", PidTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Deleted!")
                    Pdatagridrefresh()
                    PidTB.Text = ""
                    BCBox.Text = ""
                    PNameTB.Text = ""
                    BPriceTB.Text = ""
                    PDetailsTB.Text = ""
                    UPriceTB.Text = ""
                    ComTB.Text = ""
                    MrpTB.Text = ""
                    GstTB.Text = ""
                    MinTB.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Sub PCleanBT_Click(sender As Object, e As EventArgs) Handles PCleanBT.Click
        Pdatagridrefresh()
        CustomerTB.Text = ""
        CustomerSTB.Text = ""
        PidTB.Text = ""
        BCBox.Text = ""
        PNameTB.Text = ""
        BPriceTB.Text = ""
        PDetailsTB.Text = ""
        UPriceTB.Text = ""
        ComTB.Text = ""
        MrpTB.Text = ""
        GstTB.Text = ""
        MinTB.Text = ""
    End Sub

    Private Sub Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
    End Sub
End Class