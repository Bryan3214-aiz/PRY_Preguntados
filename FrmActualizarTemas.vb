Imports System.IO
Public Class FrmActualizarTemas
    Dim ID As Integer = 0
    Private imagenBytesEstTemp As Byte()
    Private imagenBytesAniTemp As Byte()
    Private audioBytesTemp As Byte()
    Private sonidoBytesTemp As Byte()
    Private videoBytesTemp As Byte()

    Private Sub FrmActualizarTemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub

    Friend Sub inicializar()
        comando = "SELECT * FROM TEMA"
        reiniciar()
        BUSCAR(comando)
    End Sub

    Friend Sub reiniciar()
        BTNseleccionarTema.Enabled = False
        BTNactualizarTema.Enabled = False
        BTNimgEstaticaTema.Enabled = False
        BTNimgAnimadaTema.Enabled = False
        BTNsonidoTema.Enabled = False
        BTNAudioVozTema.Enabled = False
        BTNvideoTema.Enabled = False
        TXTtema.Enabled = False
        CMBgradoTemas.Enabled = False
        TXTtema.Text = ""
        TXTfiltrarNombreTema.Text = ""
        CMBgradoTemas.SelectedItem = Nothing
    End Sub
    Friend Sub BUSCAR(ByVal SQL As String)
        ds.Tables.Clear()
        L.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
            Next
        End If
    End Sub

    Private Sub TXTNOMBRESUCURSAL_TextChanged(sender As Object, e As EventArgs) Handles TXTfiltrarNombreTema.TextChanged
        comando = "SELECT * FROM TEMA WHERE NOMBRE_TEMA Like '%" & TXTfiltrarNombreTema.Text & "%'"
        BUSCAR(comando)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToString(L.SelectedItems(0).Text)
            BTNseleccionarTema.Enabled = True
        End If
    End Sub

    Private Sub BTNseleccionarTema_Click(sender As Object, e As EventArgs) Handles BTNseleccionarTema.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Desea actualizar los datos sobre el tema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            BTNactualizarTema.Enabled = True
            BTNimgEstaticaTema.Enabled = True
            BTNimgAnimadaTema.Enabled = True
            BTNsonidoTema.Enabled = True
            BTNAudioVozTema.Enabled = True
            BTNvideoTema.Enabled = True
            TXTtema.Enabled = True
            CMBgradoTemas.Enabled = True

            If ID <> 0 Then
                BTNseleccionarTema.Enabled = False
                comando = "SELECT ID_TEMA, NOMBRE_TEMA, NIVEL, IMAGEN_ESTATICA, IMAGEN_ANIMADA, SONIDO_TEMA, AUDIO_VOZ, VIDEO_TEMA FROM TEMA where ID_tema = " & ID & ""
                ds.Tables.Clear()
                L.Items.Clear()
                CARGAR_TABLA(ds, comando)
                If ds.Tables(0).Rows.Count > 0 Then
                    For I = 0 To ds.Tables(0).Rows.Count - 1
                        L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1)) 'nombre tema
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2)) ' nivel
                        imagenBytesEstTemp = CType(ds.Tables(0).Rows(I).Item(3), Byte())
                        imagenBytesAniTemp = CType(ds.Tables(0).Rows(I).Item(4), Byte())
                        sonidoBytesTemp = CType(ds.Tables(0).Rows(I).Item(5), Byte())
                        audioBytesTemp = CType(ds.Tables(0).Rows(I).Item(6), Byte())
                        videoBytesTemp = CType(ds.Tables(0).Rows(I).Item(7), Byte())
                    Next
                End If
                TXTtema.Text = L.Items(L.Items.Count - 1).SubItems(1).Text
                CMBgradoTemas.Text = L.Items(L.Items.Count - 1).SubItems(2).Text
            End If
        End If
    End Sub


    Private Sub BTNactualizarTema_Click(sender As Object, e As EventArgs) Handles BTNactualizarTema.Click
        Try

            Dim imagenEstBytes As Byte() = imagenBytesEstTemp
            Dim imagenAniBytes As Byte() = imagenBytesAniTemp
            Dim sonidoBytes As Byte() = sonidoBytesTemp
            Dim audioBytes As Byte() = audioBytesTemp
            Dim videoBytes As Byte() = videoBytesTemp

            comando = "UPDATE TEMA SET NOMBRE_TEMA = '" & TXTtema.Text & "', NIVEL = '" & CMBgradoTemas.Text & "', IMAGEN_ESTATICA = ?, IMAGEN_ANIMADA = ?, SONIDO_TEMA = ?, AUDIO_VOZ = ?,  VIDEO_TEMA = ? where id_tema = " & ID & " "
            EJECUTARTEMA(comando, imagenEstBytes, imagenAniBytes, audioBytes, sonidoBytes, videoBytes)
            MsgBox("Datos actualizados", vbOKOnly, "")
            inicializar()
        Catch ex As Exception
            Console.WriteLine("Error de actualización: " & ex.Message)
            MessageBox.Show("Ocurrió un error al ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNimgEstaticaTema_Click(sender As Object, e As EventArgs) Handles BTNimgEstaticaTema.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                imagenBytesEstTemp = File.ReadAllBytes(rutaImagen)

                MsgBox("Imagen estatica insertada correctamente.", vbOKOnly, "")
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
                MsgBox("Imagen animada insertada correctamente", vbOKOnly, "")
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
                MsgBox("Sonido del tema agregado correctamente.", vbOKOnly, "")
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
                MsgBox("Audio voz del tema agregado correctamente.", vbOKOnly, "")
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
                MsgBox("Video del tema agregado correctamente.", vbOKOnly, "")
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub
End Class