Imports System.Data.SqlClient
Public Class Min_Qty


    Private Sub Min_Qty_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Me.Close()
        Home.Show()
        Home.Enabled = True
    End Sub


    Private Sub Min_Qty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd = New SqlCommand("select Product.Pid,Brand.Bname,Product.Pname,Product.Bprice,Product.Pdetails,Product.Uprice,Product.Pcom,Product.Pmrp,Product.Pgst,Product.Min,Product.Qty from Product INNER JOIN Brand ON Product.PBid=Brand.Bid WHERE (Qty<=Min)", conn)
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