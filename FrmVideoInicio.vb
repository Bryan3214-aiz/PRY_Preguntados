Public Class FrmVideoInicio

    Private duracionVideo As Double = 4.68 ' Duración del video en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente

    Private Sub FrmVideoInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el máximo valor del temporizador para que coincida con la duración del video
        TemporizadorVideo.Interval = 1000 ' Intervalo en milisegundos
        TemporizadorVideo.Start()
    End Sub
    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles MediaPlayer.Enter
        MediaPlayer.enableContextMenu = False
        MediaPlayer.uiMode = "none"
    End Sub

    Private Sub TemporizadorVideo_Tick(sender As Object, e As EventArgs) Handles TemporizadorVideo.Tick
        tiempoTranscurrido += 1

        ' Si el tiempo transcurrido es mayor o igual a la duración del video entonces se oculta la ventana actual del video, se abre el siguiente FORM y luego se cierra la actual por completo.
        If tiempoTranscurrido >= duracionVideo Then
            ' Detener el temporizador
            TemporizadorVideo.Stop()
            Me.Hide()
            FrmOPCIONES.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class
