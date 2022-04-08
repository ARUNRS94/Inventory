Imports System.Data.SqlClient
Public Class Qty_Check


    Private Sub Inward_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Me.Close()
        Home.Show()
        Home.Enabled = True
    End Sub

    Private Function IPopulateDataGridView() As DataTable
        conn = GetConnect()

        Dim cmd2 As New SqlCommand
        cmd2.Connection = conn
        cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum - t3.field3Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid] INNER JOIN (select [Pid], sum([Qty]) as field3Sum from [Sales_gst] group by [Pid]) as t3 on t3.[Pid] = t1.[Pid]", conn)
        conn.Open()
        cmd2.ExecuteNonQuery()
        conn.Close()

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd = New SqlCommand("select Product.Pid,Brand.Bname,Product.Pname,Product.Bprice,Product.Pdetails,Product.Uprice,Product.Pcom,Product.Pmrp,Product.Pgst,Product.Min,Product.Qty from Product INNER JOIN Brand ON Product.PBid=Brand.Bid WHERE Pname LIKE '%' + @productname + '%' OR @productname = '' ", conn)
        cmd.Parameters.AddWithValue("@productname", ProductSTB.Text.Trim())
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Ptable As New DataTable()
        adapter.Fill(Ptable)
        Return Ptable

    End Function

    Private Sub ProductSTB_KeyUp(sender As Object, e As KeyEventArgs) Handles ProductSTB.KeyUp
        IDataGridView.DataSource = Me.IPopulateDataGridView()
        IDataGridView.RowHeadersVisible = False
        IDataGridView.Columns(0).HeaderText = "Product ID"
        IDataGridView.Columns(1).HeaderText = "Brand Name"
        IDataGridView.Columns(2).HeaderText = "Product Name"
        IDataGridView.Columns(3).HeaderText = "Buy Price"
        IDataGridView.Columns(4).HeaderText = "Product Details"
        IDataGridView.Columns(5).HeaderText = "Sell Price"
        IDataGridView.Columns(6).HeaderText = "Comission"
        IDataGridView.Columns(7).HeaderText = "MRP"
        IDataGridView.Columns(8).HeaderText = "GST"
        IDataGridView.Columns(9).HeaderText = "Min"
        IDataGridView.Columns(10).HeaderText = "Qty"
    End Sub


    Private Sub Qty_Check_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd = New SqlCommand("select Product.Pid,Brand.Bname,Product.Pname,Product.Bprice,Product.Pdetails,Product.Uprice,Product.Pcom,Product.Pmrp,Product.Pgst,Product.Min,Product.Qty from Product INNER JOIN Brand ON Product.PBid=Brand.Bid", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Ptable As New DataTable()
        adapter.Fill(Ptable)
        IDataGridView.DataSource = Ptable
        IDataGridView.RowHeadersVisible = False
        IDataGridView.Columns(0).HeaderText = "Product ID"
        IDataGridView.Columns(1).HeaderText = "Brand Name"
        IDataGridView.Columns(2).HeaderText = "Product Name"
        IDataGridView.Columns(3).HeaderText = "Buy Price"
        IDataGridView.Columns(4).HeaderText = "Product Details"
        IDataGridView.Columns(5).HeaderText = "Sell Price"
        IDataGridView.Columns(6).HeaderText = "Comission"
        IDataGridView.Columns(7).HeaderText = "MRP"
        IDataGridView.Columns(8).HeaderText = "GST"
        IDataGridView.Columns(9).HeaderText = "Min"
        IDataGridView.Columns(10).HeaderText = "Qty"
    End Sub
End Class