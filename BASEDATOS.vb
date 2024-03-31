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


    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal comando As String)
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(comando, miconexion)
        Consulta.Fill(Tabla_Temporal)
        DESCONECTAR()
    End Sub

    Friend Sub EJECUTAR(ByVal Sql As String)
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, miconexion)
        Comando.ExecuteNonQuery()
        DESCONECTAR()
    End Sub

    Function PK(ByVal TABLA As String, ByVal ID As String) As Integer
        ds.Tables.Clear()
        comando = "SELECT " & ID & " FROM " & TABLA
        CARGAR_TABLA(ds, comando)
        If ds.Tables(0).Rows.Count > 0 Then
            ds.Tables.Clear()
            comando = "SELECT MAX(ID_USUARIO) FROM " & TABLA
            CARGAR_TABLA(ds, comando)
            PK = ds.Tables(0).Rows(0).ItemArray(0) + 1
        Else
            PK = 1
        End If
    End Function

    Friend Sub InsertarVideo(ByVal videoBytes As Byte())
        Try
            CONECTAR()
            Dim query As String = "INSERT INTO Imagenes (Fotos) VALUES (?)"
            Using cmd As New OleDbCommand(query, miconexion)
                Dim param As New OleDbParameter("@video", OleDbType.LongVarBinary, videoBytes.Length)
                param.Value = videoBytes
                cmd.Parameters.Add(param)
                cmd.ExecuteNonQuery()
            End Using

            Console.WriteLine("Video insertado exitosamente en la base de datos.")
        Catch ex As Exception
            Console.WriteLine("Error al insertar el video en la base de datos: " & ex.Message)
        Finally
            DESCONECTAR()
        End Try
    End Sub

    Friend Function ObtenerVideo() As Byte()
        Dim videoBytes As Byte() = Nothing
        Try
            CONECTAR()
            Dim query As String = "SELECT Fotos FROM Imagenes WHERE ID = 0"
            Using cmd As New OleDbCommand(query, miconexion)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    videoBytes = DirectCast(result, Byte())
                End If
            End Using

            Console.WriteLine("Video recuperado exitosamente de la base de datos.")
        Catch ex As Exception
            Console.WriteLine("Error al recuperar el video de la base de datos: " & ex.Message)
        Finally
            DESCONECTAR()
        End Try

        Return videoBytes
    End Function

    Friend Sub InsertarImagen(ByVal imagenBytes As Byte())
        Try
            CONECTAR()
            Dim query As String = "INSERT INTO Imagenes (Fotos) VALUES (?)"
            Using cmd As New OleDbCommand(query, miconexion)
                Dim param As New OleDbParameter("@imagen", OleDbType.LongVarBinary, imagenBytes.Length)
                param.Value = imagenBytes
                cmd.Parameters.Add(param)
                cmd.ExecuteNonQuery()
            End Using

            Console.WriteLine("Imagen insertada exitosamente en la base de datos.")
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen en la base de datos: " & ex.Message)
        Finally
            DESCONECTAR()
        End Try
    End Sub
    Public Function ObtenerImagen() As Byte()
        Dim imagenBytes As Byte() = Nothing
        Try
            CONECTAR()
            Dim query As String = "SELECT Fotos FROM Imagenes WHERE ID = 3"
            Using cmd As New OleDbCommand(query, miconexion)
                Dim dataReader As OleDbDataReader = cmd.ExecuteReader()
                If dataReader.Read() Then
                    Dim columnIndex As Integer = dataReader.GetOrdinal("Fotos")
                    Using memoryStream As New MemoryStream()
                        Dim bufferSize As Integer = 4096
                        Dim buffer(bufferSize - 1) As Byte
                        Dim bytesRead As Integer
                        Dim offset As Long = 0
                        Do
                            bytesRead = dataReader.GetBytes(columnIndex, offset, buffer, 0, bufferSize)
                            If bytesRead > 0 Then
                                memoryStream.Write(buffer, 0, bytesRead)
                                offset += bytesRead
                            End If
                        Loop While bytesRead > 0
                        imagenBytes = memoryStream.ToArray()
                    End Using
                End If
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al obtener la imagen desde la base de datos: " & ex.Message)
        Finally
            DESCONECTAR()
        End Try

        Return imagenBytes
    End Function




End Module
