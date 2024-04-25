Public Class FrmMusicaJuego
    Dim reproductor As System.Media.SoundPlayer

    Private Sub FrmMusicaJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musica()
    End Sub
    Private Sub Musica()
        Dim MusicaActual = My.Resources.sonidoJuego2
        reproductor = New System.Media.SoundPlayer(MusicaActual)
        reproductor.PlayLooping()
    End Sub
End Class