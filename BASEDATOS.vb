Imports System.Data.OleDb
Imports System.Data.SqlClient
Module BASEDATOS
    Public pro As String
    Public constring As String
    Public comando As String
    Public miconexion As OleDbConnection = New OleDbConnection
    Public ds As New DataSet
    Public dt As New DataTable

    Friend Sub CONECTAR()
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\PRY_PREGUNTADOS\proyecto_preguntas.mdb"
        constring = pro
        miconexion.ConnectionString = constring
        miconexion.Open()
        Exit Sub
    End Sub

    Friend Sub DESCONECTAR()
        miconexion.Close()
    End Sub
End Module
