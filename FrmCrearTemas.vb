Imports System.IO
Public Class FrmCrearTemas
    Private Sub BTNcrearTema_Click(sender As Object, e As EventArgs) Handles BTNcrearTema.Click
        Try
            If String.IsNullOrWhiteSpace(TXTtema.Text) OrElse
                String.IsNullOrWhiteSpace(CMBgradoTemas.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay campos vacíos
            End If
            Dim imagenBytes As Byte() = ObtenerBytesDeImagen(BTNimgEstaticaTema.Image)
            Dim Comando As String = "INSERT INTO TEMA (ID_TEMA, NOMBRE_TEMA, IMAGEN_ESTATICA, IMAGEN_ANIMADA, SONIDO_TEMA, AUDIO_VOZ_TEMA, VIDEO_TEMA, NIVEL) VALUES ('" & PK("TEMA", "ID_TEMA") & "', '" & TXTtema.Text & "', ? , ? , ? , ? , ? , '" & CMBgradoTemas.Text & "')"

            EJECUTAR(Comando, imagenBytes)
            MsgBox("Tema creado exitosamente.")
            Me.Hide()
            Me.Close()
        Catch ex As Exception
            Console.WriteLine("Error al crear usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNimgEstaticaTema_Click(sender As Object, e As EventArgs) Handles BTNimgEstaticaTema.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub
    Private Function ObtenerBytesDeImagen(ByVal imagen As Image) As Byte()
        Using ms As New MemoryStream()
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub MostrarImagen(imagenBytes As Byte())
        Try
            Dim tempFilePath As String = Path.GetTempFileName()
            tempFilePath = Path.ChangeExtension(tempFilePath, ".jpg")
            File.WriteAllBytes(tempFilePath, imagenBytes)

            BTNimgEstaticaTema.Image = Image.FromFile(tempFilePath)
        Catch ex As Exception
            Console.WriteLine("Error al mostrar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNimgAnimadaTema_Click(sender As Object, e As EventArgs) Handles BTNimgAnimadaTema.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.gif*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNsonidoTema_Click(sender As Object, e As EventArgs) Handles BTNsonidoTema.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp3*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNAudioVozTema_Click(sender As Object, e As EventArgs) Handles BTNAudioVozTema.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp3*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNvideoTema_Click(sender As Object, e As EventArgs) Handles BTNvideoTema.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp4*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub
End Class