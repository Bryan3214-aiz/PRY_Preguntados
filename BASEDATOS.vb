Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Module BASEDATOS
    'Modulo para conexion a base de datos'
    Public pro As String
    Public constring As String
    Public comando As String
    Public miconexion As OleDbConnection = New OleDbConnection
    Public ds As New DataSet
    Public dt As New DataTable
    'Función conectar para obtener conexión al archivo udl que contiene la base de datos
    Friend Sub CONECTAR()
        ' pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\PRY_PREGUNTADOS\proyecto_preguntas.mdb"'
        pro = "File Name=" & Application.StartupPath & "\DB.udl"
        constring = pro
        miconexion.ConnectionString = constring
        miconexion.Open()
        Exit Sub
    End Sub
    'Función Desconectar'
    Friend Sub DESCONECTAR()
        miconexion.Close()
    End Sub

    Friend Sub InsertarImagen(ByVal rutaImagen As String)
        Try
            CONECTAR()
            Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)

            Dim tempFilePath As String = Path.Combine(Path.GetTempPath(), Path.GetFileName(rutaImagen))
            File.Copy(rutaImagen, tempFilePath, True)

            Dim query As String = "INSERT INTO Imagenes (Fotos) VALUES (?)"
            Using cmd As New OleDbCommand(query, miconexion)
                Dim param As New OleDbParameter("@imagen", OleDbType.Binary, imagenBytes.Length)
                param.Value = imagenBytes
                cmd.Parameters.Add(param)

                cmd.ExecuteNonQuery()
            End Using

            Console.WriteLine("Imagen insertada exitosamente.")
            File.Delete(tempFilePath)
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        Finally
            DESCONECTAR()
        End Try
    End Sub

End Module
