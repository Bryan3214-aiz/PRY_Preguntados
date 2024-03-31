﻿Imports System.Data.OleDb
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
    ' Esta subrutina se encarga de cargar datos desde la base de datos en un DataSet.
    ' Recibe un DataSet por referencia para almacenar los datos y una cadena de comando SQL para la consulta.
    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal comando As String)
        ' Establece una conexión con la base de datos.
        CONECTAR()

        ' Crea un objeto DataAdapter para ejecutar la consulta SQL y llenar el DataSet con los resultados.
        Dim Consulta As New OleDb.OleDbDataAdapter(comando, miconexion)
        Consulta.Fill(Tabla_Temporal)

        ' Cierra la conexión con la base de datos.
        DESCONECTAR()
    End Sub

    ' Esta subrutina se encarga de ejecutar una instrucción SQL que no devuelve datos.
    ' Recibe una cadena de comando SQL como argumento.
    Friend Sub EJECUTAR(ByVal comando As String)
        ' Establece una conexión con la base de datos.
        CONECTAR()

        ' Crea un objeto Command para ejecutar la instrucción SQL.
        Dim sql As New OleDb.OleDbCommand(comando, miconexion)
        sql.ExecuteNonQuery()

        ' Cierra la conexión con la base de datos.
        DESCONECTAR()
    End Sub

    ' Esta función se utiliza para obtener el siguiente valor de una clave primaria (PK) en una tabla específica.
    ' Recibe el nombre de la tabla y el nombre del campo de la clave primaria como argumentos.
    ' Devuelve el siguiente valor disponible para la clave primaria.
    Function PK(ByVal TABLA As String, ByVal ID As String) As Integer
        ' Borra cualquier tabla existente en el DataSet para evitar datos antiguos.
        ds.Tables.Clear()

        ' Construye una consulta para obtener el máximo valor de la clave primaria en la tabla especificada.
        comando = "SELECT " & ID & " FROM " & TABLA
        ' Carga los datos en el DataSet utilizando la función CARGAR_TABLA.
        CARGAR_TABLA(ds, comando)

        ' Verifica si hay filas en el DataSet.
        If ds.Tables(0).Rows.Count > 0 Then
            ' Borra cualquier tabla existente en el DataSet antes de realizar la siguiente consulta.
            ds.Tables.Clear()
            ' Construye una consulta para obtener el máximo valor de la clave primaria en la tabla especificada.
            comando = "SELECT MAX(ID_USUARIO) FROM " & TABLA
            ' Carga los datos en el DataSet utilizando la función CARGAR_TABLA.
            CARGAR_TABLA(ds, comando)
            ' Devuelve el siguiente valor disponible para la clave primaria sumando 1 al máximo valor encontrado.
            PK = ds.Tables(0).Rows(0).ItemArray(0) + 1
        Else
            ' Si no hay filas en la tabla, devuelve 1 como el primer valor para la clave primaria.
            PK = 1
        End If
    End Function

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
