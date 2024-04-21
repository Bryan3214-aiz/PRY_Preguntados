Imports System.IO
Public Class FrmCrearCategorias
    Private imagenBytesEstTemp As Byte()
    Private imagenBytesAniTemp As Byte()
    Private audioBytesTemp As Byte()
    Private sonidoBytesTemp As Byte()
    Private videoBytesTemp As Byte()
    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub BTNcrearCategoria_Click(sender As Object, e As EventArgs) Handles BTNcrearCategoria.Click
        Try
            If String.IsNullOrWhiteSpace(TXTcategoria.Text) OrElse
                String.IsNullOrWhiteSpace(CMBseleccionarTemaC.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim imagenEstBytes As Byte() = imagenBytesEstTemp
            Dim imagenAniBytes As Byte() = imagenBytesAniTemp
            Dim audioBytes As Byte() = audioBytesTemp
            Dim sonidoBytes As Byte() = sonidoBytesTemp
            Dim videoBytes As Byte() = videoBytesTemp
            Dim index As Integer = CMBseleccionarTemaC.SelectedIndex + 1
            Dim comando As String = "INSERT INTO CATEGORIA (ID_CATEGORIA, NOMBRE_CATEGORIA, IMAGEN_ESTATICA, IMAGEN_ANIMADA, SONIDO_CATEGORIA, AUDIO_VOZ, VIDEO_CATEGORIA) VALUES ( '" & PK("CATEGORIA", "ID_CATEGORIA") & "','" & TXTcategoria.Text & "', '" & index & "',?, ?, ?, ?, ?)"
            EJECUTARTEMA(comando, imagenEstBytes, imagenAniBytes, audioBytes, sonidoBytes, videoBytes)
            MsgBox("Categoria creada exitosamente.")
        Catch ex As Exception
            Console.WriteLine("Error al crear usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al crear la categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNimgEstaticaCategoria_Click(sender As Object, e As EventArgs) Handles BTNimgEstaticaCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                imagenBytesEstTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Imagen estatica de la categoria insertada correctamente.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNimgAnimadaCategoria_Click(sender As Object, e As EventArgs) Handles BTNimgAnimadaCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.gif*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                imagenBytesAniTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Imagen animada de la categoria insertada correctamente")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNSonidoCategoria_Click(sender As Object, e As EventArgs) Handles BTNSonidoCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp3*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                sonidoBytesTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Sonido de la categoria agregado correctamente.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNAudioVozCategoria_Click(sender As Object, e As EventArgs) Handles BTNAudioVozCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp3*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                audioBytesTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Audio voz de la categoria agregado correctamente.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNvideoCategoria_Click(sender As Object, e As EventArgs) Handles BTNvideoCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp4*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                videoBytesTemp = File.ReadAllBytes(rutaImagen)
                MsgBox("Video de la categoria agregado correctamente.")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Friend Sub BUSCARcombo(ByVal SQL As String)
        ds.Tables.Clear()
        CMBseleccionarTemaC.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                CMBseleccionarTemaC.Items.Add(ds.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub

    Friend Sub INICIALIZARCOMBO()
        comando = "SELECT NOMBRE_TEMA FROM TEMA"
        BUSCARcombo(comando)
    End Sub

    Private Sub FrmCrearCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZARCOMBO()
    End Sub
End Class