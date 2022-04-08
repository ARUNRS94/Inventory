Imports System.Collections.Specialized
Imports System.Configuration
Imports System.IO
Imports System.Xml


Public Class GetDataFromXML
    Dim sString As NameValueCollection = ConfigurationManager.AppSettings
    Public sInstanceName As String = String.Empty
    Public sDBName As String = String.Empty
    Public sAuthentication As String = String.Empty
    Public sUserName As String = String.Empty
    Public sPassword As String = String.Empty

    Public Sub New()
        LoadValues()
    End Sub
    Public Function LoadValues()
        Try

            If File.Exists(Application.StartupPath & "\Login.xml") = True Then
                Dim reader As New XmlTextReader(Application.StartupPath & "\Login.xml")
                While reader.Read()
                    reader.ReadStartElement("Login")

                    If Not reader.IsEmptyElement Then
                        reader.ReadStartElement("Instance")
                        sInstanceName = reader.ReadString()
                        reader.ReadEndElement()

                        reader.ReadStartElement("Database")
                        sDBName = reader.ReadString()
                        reader.ReadEndElement()

                        reader.ReadStartElement("Authentication")
                        Dim sTmp = reader.ReadString()
                        sAuthentication = sTmp
                        reader.ReadEndElement()

                        If sTmp = "SQL Server Authentication" Then
                            reader.ReadStartElement("UserName")
                            sUserName = reader.ReadString()
                            reader.ReadEndElement()

                            reader.ReadStartElement("Password")
                            sPassword = reader.ReadString()
                            reader.ReadEndElement()
                        End If

                    End If
                    reader.ReadEndElement()
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Exception thrown at GetDataFromXML.LoadValues(). Exception is - " + ex.Message)
        End Try
        Return 0
    End Function



End Class