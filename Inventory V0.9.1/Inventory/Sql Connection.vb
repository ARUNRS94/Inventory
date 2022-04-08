Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data

Module Sql_Connection
    Dim getDataFromXML As New GetDataFromXML
    Public ConnectionString As String = "Initial Catalog=" & getDataFromXML.sDBName & ";Data Source=" & getDataFromXML.sInstanceName & "; Integrated Security=True "
    Public conn As SqlConnection

    Public Function GetConnect()
        Try
            ' conn = New SqlConnection("Data Source=RAMESH\SQLEXPRESS; Initial Catalog=Inventory; Integrated Security=True")
            conn = New SqlConnection(ConnectionString)
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
        Return conn
    End Function
End Module
