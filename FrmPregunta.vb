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

End Class