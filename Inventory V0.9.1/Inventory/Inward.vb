Imports System.Data.SqlClient
Public Class Inward


    Private Sub Inward_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Me.Close()
        Home.Show()
        Home.Enabled = True
    End Sub

    Private Sub Inward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)

        PNameTB.Enabled = False

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

    End Sub

    Private Sub BCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BCBox.SelectionChangeCommitted
        If ProductSTB.Text = "" Then
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select Pid,Pname from Product Where PBid = '" & BCBox.SelectedValue & "'", conn)
            Dim adapter As New SqlDataAdapter(cmd)
            Dim ptable As New DataTable
            adapter.Fill(ptable)
            Dim row As DataRow = ptable.NewRow()
            'Insert the Default Item to DataTable.
            row(0) = 0
            row(1) = "Please select"
            ptable.Rows.InsertAt(row, 0)
            PCBox.ValueMember = "Pid"
            PCBox.DisplayMember = "Pname"
            PCBox.DataSource = ptable
        End If
    End Sub

    Public Sub Idatagridrefresh()
        Dim cmd As New SqlCommand

        cmd = New SqlCommand("  Select Stock.Sid,Brand.Bname,Product.Pname,Stock.Qty,Stock.Date,Stock.Buyer,Stock.Greturn,Product.Pid from Stock INNER JOIN Product ON Product.Pid=Stock.Pid INNER JOIN Brand ON Product.PBid=Brand.Bid ", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        IDataGridView.DataSource = table
        'With BDataGridView
        IDataGridView.RowHeadersVisible = False
        IDataGridView.Columns(0).HeaderText = "Stock ID"
        IDataGridView.Columns(1).HeaderText = "Brand Name"
        IDataGridView.Columns(2).HeaderText = "Product Name"
        IDataGridView.Columns(3).HeaderText = "Qty"
        IDataGridView.Columns(4).HeaderText = "Date"
        IDataGridView.Columns(5).HeaderText = "Buyer Name"
        IDataGridView.Columns(6).HeaderText = "Goods Return"
        IDataGridView.Columns(7).Visible = True
        'End With
        IDataGridView.ClearSelection()
    End Sub

    Private Sub IAddBT_Click(sender As Object, e As EventArgs) Handles IAddBT.Click

        If PNameTB.Text = "" Then
            MessageBox.Show("Select Product Name")
        ElseIf BCBox.Text = "Please select" Then
            MessageBox.Show("Select the Brand Name")
        ElseIf BuyerTB.Text = "" Then
            MessageBox.Show("Enter Buyer Name Or Bill No")
        ElseIf QtyTB.Text = "" Then
            MessageBox.Show("Enter Qty")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("insert into Stock (Pid,Qty,Date,Buyer,Greturn) values (@productid,@qty,@date,@buyer,@Gr)", conn)
                cmd.Parameters.AddWithValue("@productid", PCBselectedvalueTB.Text)
                cmd.Parameters.AddWithValue("@buyer", BuyerTB.Text)
                cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value.Date)
                If PReturnCB.Checked = True Then
                    cmd.Parameters.AddWithValue("@qty", ((QtyTB.Text) * -1))
                    cmd.Parameters.AddWithValue("@Gr", "PR")
                ElseIf SReturnCB.Checked = True Then
                    cmd.Parameters.AddWithValue("@qty", QtyTB.Text)
                    cmd.Parameters.AddWithValue("@Gr", "SR")
                Else
                    cmd.Parameters.AddWithValue("@qty", QtyTB.Text)
                    cmd.Parameters.AddWithValue("@Gr", "None")
                End If
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()

                Dim cmd2 As New SqlCommand
                cmd2.Connection = conn
                cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid]", conn)
                conn.Open()
                cmd2.ExecuteNonQuery()
                cmd2 = New SqlCommand("UPDATE [Product] SET [Product].[Qty] = t2.field2Sum - t3.field3Sum FROM [Product] t1 INNER JOIN (select [Pid], sum([Qty]) as field2Sum from [Stock] group by [Pid]) as t2 on t2.[Pid] = t1.[Pid] INNER JOIN (select [Pid], sum([Qty]) as field3Sum from [Sales_gst] group by [Pid]) as t3 on t3.[Pid] = t1.[Pid]", conn)
                cmd2.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Record saved!")
                Idatagridrefresh()
                BuyerTB.Text = ""
                QtyTB.Text = ""

            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Function IPopulateDataGridView() As DataTable
        conn = GetConnect()
        Dim cmd As New SqlCommand
        cmd.Connection = conn
        cmd = New SqlCommand("Select Stock.Sid,Brand.Bname,Product.Pname,Stock.Qty,Stock.Date,Stock.Buyer,Stock.Greturn,Product.Pid from Stock INNER JOIN Product ON Product.Pid=Stock.Pid INNER JOIN Brand ON Product.PBid=Brand.Bid WHERE Product.Pname LIKE '%' + @productname + '%' OR @productname = '' ", conn)
        cmd.Parameters.AddWithValue("@productname", ProductSTB.Text.Trim())
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Ptable As New DataTable()
        adapter.Fill(Ptable)
        Return Ptable

    End Function

    Private Sub ProductSTB_KeyUp(sender As Object, e As KeyEventArgs) Handles ProductSTB.KeyUp
        IDataGridView.DataSource = Me.IPopulateDataGridView()
        IDataGridView.RowHeadersVisible = False
        IDataGridView.Columns(0).HeaderText = "Stock ID"
        IDataGridView.Columns(1).HeaderText = "Brand Name"
        IDataGridView.Columns(2).HeaderText = "Product Name"
        IDataGridView.Columns(3).HeaderText = "Qty"
        IDataGridView.Columns(4).HeaderText = "Date"
        IDataGridView.Columns(5).HeaderText = "Buyer Name"
        IDataGridView.Columns(6).HeaderText = "Goods Return"
        IDataGridView.Columns(7).Visible = True
        'IDataGridView.Columns(7).HeaderText = "Product Id"
    End Sub

    Private Sub IDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles IDataGridView.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = IDataGridView.Rows(index)
        SidTB.Text = selectedRow.Cells(0).Value.ToString()
        BCBox.Text = selectedRow.Cells(1).Value.ToString()
        PNameTB.Text = selectedRow.Cells(2).Value.ToString()
        QtyTB.Text = selectedRow.Cells(3).Value.ToString()
        BuyerTB.Text = selectedRow.Cells(5).Value.ToString()
        PCBselectedvalueTB.Text = selectedRow.Cells(7).Value.ToString()
        If selectedRow.Cells(6).Value.ToString() = "1" Then
            PReturnCB.Select()
        End If
    End Sub

    Private Sub PCBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PCBox.SelectedIndexChanged

        If PCBox.Text <> "Please select" And PCBox.Text <> "" Then
            PNameTB.Text = PCBox.Text
            PCBselectedvalueTB.Text = PCBox.SelectedValue
        End If
    End Sub


    Private Sub IUpdateBT_Click(sender As Object, e As EventArgs) Handles IUpdateBT.Click
        If SidTB.Text = "" Then
            MessageBox.Show("Select Product Name")
        ElseIf BCBox.Text = "Please select" Then
            MessageBox.Show("Select the Brand Name")
        ElseIf BuyerTB.Text = "" Then
            MessageBox.Show("Enter Buyer Name Or Bill No")
        ElseIf QtyTB.Text = "" Then
            MessageBox.Show("Enter Qty")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Stock WHERE Sid='" & SidTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim Ptable As New DataTable()
                adapter.Fill(Ptable)
                If Ptable.Rows.Count() = 0 Then
                    MessageBox.Show("Product Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("Update Stock set Pid=@productid,Qty=@qty,Date=@date,Buyer=@buyer,Greturn=@Gr Where Sid=@Sid", conn)
                    cmd.Parameters.AddWithValue("@productid", PCBselectedvalueTB.Text)
                    cmd.Parameters.AddWithValue("@buyer", BuyerTB.Text)
                    cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value.Date)
                    cmd.Parameters.AddWithValue("@qty", QtyTB.Text)
                    cmd.Parameters.AddWithValue("@Sid", SidTB.Text)
                    If PReturnCB.Checked = True Then
                        cmd.Parameters.AddWithValue("@Gr", 1)
                    Else
                        cmd.Parameters.AddWithValue("@Gr", 0)
                    End If
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Updated!")
                    Idatagridrefresh()
                    PCBselectedvalueTB.Text = ""
                    BuyerTB.Text = ""
                    QtyTB.Text = ""

                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

    Private Sub IDeleteBT_Click(sender As Object, e As EventArgs) Handles IDeleteBT.Click
        If SidTB.Text = "" Then
            MessageBox.Show("Select Product to be Deleted")
        Else
            Try
                conn = GetConnect()
                Dim cmd As New SqlCommand
                cmd.Connection = conn
                cmd = New SqlCommand("SELECT * FROM Stock WHERE Sid='" & SidTB.Text & "'", conn)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim table1 As New DataTable()
                adapter.Fill(table1)
                If table1.Rows.Count() = 0 Then
                    MessageBox.Show("Product Not Available!")
                Else
                    conn = GetConnect()
                    cmd = New SqlCommand("Delete from Stock Where Sid=@Sid", conn)
                    cmd.Parameters.AddWithValue("@Sid", SidTB.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Record Deleted!")
                    Idatagridrefresh()
              PCBselectedvalueTB.Text = ""
                    BuyerTB.Text = ""
                    QtyTB.Text = ""
                    PNameTB.Text = ""
                End If
            Catch ex As Exception
                MessageBox.Show("Invalid" & ex.Message)

            End Try
        End If
    End Sub

End Class