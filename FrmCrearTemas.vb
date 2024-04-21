Imports System.IO
Public Class FrmCrearTemas
    Private imagenBytesEstTemp As Byte()
    Private imagenBytesAniTemp As Byte()
    Private audioBytesTemp As Byte()
    Private sonidoBytesTemp As Byte()
    Private videoBytesTemp As Byte()

    Private Sub BTNcrearTema_Click(sender As Object, e As EventArgs) Handles BTNcrearTema.Click
        Try
            If String.IsNullOrWhiteSpace(TXTtema.Text) OrElse
                String.IsNullOrWhiteSpace(CMBgradoTemas.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim imagenEstBytes As Byte() = imagenBytesEstTemp
            Dim imagenAniBytes As Byte() = imagenBytesAniTemp
            Dim audioBytes As Byte() = audioBytesTemp
            Dim sonidoBytes As Byte() = sonidoBytesTemp
            Dim videoBytes As Byte() = videoBytesTemp

            Dim comando As String = "INSERT INTO TEMA (ID_TEMA, NOMBRE_TEMA, NIVEL, IMAGEN_ESTATICA, IMAGEN_ANIMADA, SONIDO_TEMA, AUDIO_VOZ_TEMA, VIDEO_TEMA) VALUES ( '" & TXTtema.Text & "', '" & CMBgradoTemas.Text & "',?, ?, ?, ?, ?, ?, ?, ?)"
            EJECUTARTEMA(comando, imagenEstBytes, imagenAniBytes, audioBytes, sonidoBytes, videoBytes)
            MsgBox("Tema creado exitosamente.")
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
                imagenBytesEstTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Imagen estatica insertada correctamente.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub


    Private Sub BTNimgAnimadaTema_Click(sender As Object, e As EventArgs) Handles BTNimgAnimadaTema.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.gif*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                imagenBytesAniTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Imagen animada insertada correctamente")
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
                sonidoBytesTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Sonido del tema agregado correctamente.")
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
                audioBytesTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Audio voz del tema agregado correctamente.")
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
                videoBytesTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Video del tema agregado correctamente.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

End Class