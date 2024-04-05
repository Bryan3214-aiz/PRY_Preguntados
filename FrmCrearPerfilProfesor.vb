Imports System.IO
Public Class FrmCrearPerfilProfesor
    Private Sub BTNcrearPerfilProfesor_Click(sender As Object, e As EventArgs) Handles BTNcrearPerfilProfesor.Click

        Try
            ' Validar si algún campo está vacío
            If String.IsNullOrWhiteSpace(TXTidentifacion.Text) OrElse
                String.IsNullOrWhiteSpace(TXTnombre.Text) OrElse
                String.IsNullOrWhiteSpace(TXTcorreo.Text) OrElse
                String.IsNullOrWhiteSpace(TXTpatron.Text) OrElse
                String.IsNullOrWhiteSpace(TXTcontrasena.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay campos vacíos
            End If

            ' Convertir la imagen a bytes
            Dim imagenBytes As Byte() = ObtenerBytesDeImagen(BTNfotoSeleccionar.Image)

            ' Construir el comando SQL con parámetros 
            Dim Comando As String = "INSERT INTO PROFESOR (ID_PROFESOR, NOMBRE_COMPLETO, CORREO_ELECTRONICO, IDENTIFICACION, CONTRASENA, PATRON, FOTOGRAFIA) VALUES ('" & PKF("PROFESOR", "ID_PROFESOR") & "', '" & TXTnombre.Text & "', '" & TXTcorreo.Text & "', '" & TXTidentifacion.Text & "','" & TXTcontrasena.Text & "', '" & TXTpatron.Text & "', ?)"

            ' Ejecutar el comando SQL
            EJECUTAR(Comando, imagenBytes)

            MsgBox("Usuario creado exitosamente.", "")

        Catch ex As Exception
            Console.WriteLine("Error al crear usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNfotoSeleccionar_Click(sender As Object, e As EventArgs) Handles BTNfotoSeleccionar.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub
    Private Sub MostrarImagen(imagenBytes As Byte())
        Try
            Dim tempFilePath As String = Path.GetTempFileName()
            tempFilePath = Path.ChangeExtension(tempFilePath, ".jpg")
            File.WriteAllBytes(tempFilePath, imagenBytes)

            BTNfotoSeleccionar.Image = Image.FromFile(tempFilePath)
        Catch ex As Exception
            Console.WriteLine("Error al mostrar la imagen: " & ex.Message)
        End Try
    End Sub
    Private Function ObtenerBytesDeImagen(ByVal imagen As Image) As Byte()
        Using ms As New MemoryStream()
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function


End Class