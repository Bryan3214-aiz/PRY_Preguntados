Public Class FrmMusicaJuego


    Private Sub FrmMusicaJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musica()
        DetenerSonido()
    End Sub
    Friend Sub Musica()
        Dim MusicaActual = My.Resources.sonidoJuego2
        reproductor = New System.Media.SoundPlayer(MusicaActual)
        reproductor.PlayLooping()
    End Sub
    Private Sub DetenerSonido()
        If sonidoJuego.wmp IsNot Nothing Then
            sonidoJuego.wmp.controls.stop()
        End If
    End Sub
End Class
Module ModuloMusica
    Public reproductor As System.Media.SoundPlayer
End Module
