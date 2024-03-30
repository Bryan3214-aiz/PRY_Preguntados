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

    Private Sub BTN_IMGINSERT_Click(sender As Object, e As EventArgs) Handles BTN_IMGINSERT.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|.png .jpg .jpeg |Todos los archivos|.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName

                BASEDATOS.InsertarImagen(rutaImagen)

                MessageBox.Show("Imagen insertada correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
            MessageBox.Show("Ocurrió un error al insertar la imagen en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class