Imports System.IO
Public Class FrmPregunta
    Dim duracionTransicion As Integer = 0.5
    Dim duracionVideo As Integer = 10.31
    Dim tiempoTranscurrido As Integer = 0

    Private Sub TemporizadorVideo_Tick(sender As Object, e As EventArgs) Handles TemporizadorVideo.Tick
        tiempoTranscurrido += 1

        ' Si el tiempo transcurrido es mayor o igual a la duración del video entonces se oculta la ventana actual del video, se abre el siguiente FORM y luego se cierra la actual por completo.
        If tiempoTranscurrido >= duracionVideo Then
            ' Detener el temporizador
            TemporizadorVideo.Stop()
        End If
    End Sub

    Private Sub MediaPlayer_Enter(sender As Object, e As EventArgs) Handles MediaPlayer.Enter
        MediaPlayer.uiMode = "none"
        MediaPlayer.enableContextMenu = False
    End Sub
    Private Sub FrmPregunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el máximo valor del temporizador para que coincida con la duración del video
        TemporizadorVideo.Interval = 1000 ' Intervalo en milisegundos
        TemporizadorVideo.Start()

        ' Asigna la imagen deseada a cada botón (reemplaza MyImage1, MyImage2, MyImage3, MyImage4)
        BTNopcionUno.Image = My.Resources.long_button
        BTNopcionDos.Image = My.Resources.long_button
        BTNopcionTres.Image = My.Resources.long_button
        BTNopcionCuatro.Image = My.Resources.long_button

    End Sub

    Private Sub BTN_VideoInsert_Click(sender As Object, e As EventArgs) Handles BTN_VideoInsert.Click
        Try
            OpenFileDialog1.Filter = "Archivos de video|*.webm;*.avi;*.mp4|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaVideo As String = OpenFileDialog1.FileName

                ' Leer los bytes del archivo de video
                Dim videoBytes As Byte() = File.ReadAllBytes(rutaVideo)

                BASEDATOS.InsertarVideo(videoBytes)

                MessageBox.Show("Video insertado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar el video: " & ex.Message)
            MessageBox.Show("Ocurrió un error al insertar el video en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MostrarVideo()
        Dim videoBytes As Byte() = ObtenerVideo()

        If videoBytes IsNot Nothing AndAlso videoBytes.Length > 0 Then
            Try
                Dim tempFilePath As String = Path.GetTempFileName()
                tempFilePath = Path.ChangeExtension(tempFilePath, ".mp4")
                File.WriteAllBytes(tempFilePath, videoBytes)
                MediaPlayer.URL = tempFilePath
                MediaPlayer.Ctlcontrols.play()
            Catch ex As Exception
                Console.WriteLine("Error al mostrar el video: " & ex.Message)
            End Try
        Else
            Console.WriteLine("No se encontró el video en la base de datos.")
        End If
    End Sub

    Private Sub BTNMostrarVideo_Click(sender As Object, e As EventArgs) Handles BTNMostrarVideo.Click
        MostrarVideo()
    End Sub

    Private Sub BTNIMGInsert_Click(sender As Object, e As EventArgs) Handles BTNIMGInsert.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)

                BASEDATOS.InsertarImagen(imagenBytes)

                MessageBox.Show("Imagen insertada correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
            MessageBox.Show("Ocurrió un error al insertar la imagen en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MostrarImagen()
        Dim imagenBytes As Byte() = ObtenerImagen()

        If imagenBytes IsNot Nothing AndAlso imagenBytes.Length > 0 Then
            Try
                Dim tempFilePath As String = Path.GetTempFileName()
                tempFilePath = Path.ChangeExtension(tempFilePath, ".jpg")
                File.WriteAllBytes(tempFilePath, imagenBytes)

                MediaPlayer.URL = tempFilePath
                MediaPlayer.Ctlcontrols.play()
            Catch ex As Exception
                Console.WriteLine("Error al mostrar la imagen: " & ex.Message)
            End Try
        Else
            Console.WriteLine("No se encontró la imagen en la base de datos.")
        End If
    End Sub

    Private Sub BTNMostrarIMG_Click(sender As Object, e As EventArgs) Handles BTNMostrarIMG.Click
        MostrarImagen()
    End Sub
End Class