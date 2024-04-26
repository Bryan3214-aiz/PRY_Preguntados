Public Class FrmMusicaJuego
    Private Sub FrmMusicaJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Musica()
    End Sub
    Friend Sub Musica()
        Dim MusicaActual = My.Resources.sonidoJuego2
        reproductor = New System.Media.SoundPlayer(MusicaActual)
        reproductor.PlayLooping()
    End Sub
End Class

