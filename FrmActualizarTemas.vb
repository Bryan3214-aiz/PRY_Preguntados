Imports System.IO
Public Class FrmActualizarTemas
    Dim ID As Integer = 0
    Private fotoCambiadaEST As Boolean = False
    Private fotoCambiadaANI As Boolean = False
    Private SonidoTemaB As Boolean = False
    Private AudioTemaB As Boolean = False
    Private VideoTemaB As Boolean = False
    Private TodosCampos As Boolean = False


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
        Dim resultado As DialogResult = MessageBox.Show("¿Desea actualizar su información personal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            BTNactualizarTema.Enabled = True
            If ID <> 0 Then
                BTNseleccionarTema.Enabled = False
                comando = "SELECT ID_TEMA, NOMBRE_TEMA, NIVEL FROM TEMA where ID_tema = " & ID & ""
                ds.Tables.Clear()
                L.Items.Clear()
                CARGAR_TABLA(ds, comando)
                If ds.Tables(0).Rows.Count > 0 Then
                    For I = 0 To ds.Tables(0).Rows.Count - 1
                        L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
                    Next
                End If
                TXTtema.Text = L.Items(L.Items.Count - 1).SubItems(1).Text
                CMBgradoTemas.Text = L.Items(L.Items.Count - 1).SubItems(2).Text
            End If
        End If
    End Sub

    Private Sub BTNactualizarTema_Click(sender As Object, e As EventArgs) Handles BTNactualizarTema.Click
        Try

            If fotoCambiadaEST = True Then

                Dim imagenEstBytes As Byte() = imagenBytesEstTemp
                comando = "UPDATE TEMA SET IMAGEN_ESTATICA = ?"
                inicializar()
                MsgBox("Datos actualizados solo img estatica")
            ElseIf fotoCambiadaANI = True Then

                Dim imagenAniBytes As Byte() = imagenBytesAniTemp
                comando = "UPDATE TEMA SET IMAGEN_ANIMADA = ?"
                inicializar()
                MsgBox("Datos actualizados solo img animada")
            ElseIf SonidoTemaB = True Then

                Dim sonidoBytes As Byte() = sonidoBytesTemp
                comando = "UPDATE TEMA SET SONIDO_TEMA = ?"
                inicializar()
                MsgBox("Datos actualizados")

            ElseIf AudioTemaB = True Then

                Dim audioBytes As Byte() = audioBytesTemp
                comando = "UPDATE TEMA SET AUDIO_VOZ = ?"
                inicializar()
                MsgBox("Datos actualizados")

            ElseIf VideoTemaB = True Then
                Dim videoBytes As Byte() = videoBytesTemp
                comando = "UPDATE TEMA SET VIDEO_TEMA = ?"
                inicializar()
                MsgBox("Datos actualizados")

            ElseIf TodosCampos = True Then

                Dim imagenEstBytes As Byte() = imagenBytesEstTemp

                Dim imagenAniBytes As Byte() = imagenBytesAniTemp

                Dim sonidoBytes As Byte() = sonidoBytesTemp

                Dim audioBytes As Byte() = audioBytesTemp

                Dim videoBytes As Byte() = videoBytesTemp
                comando = "UPDATE TEMA SET VIDEO_TEMA = ?"
                inicializar()
                MsgBox("Datos actualizados")
            Else

            End If
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
                fotoCambiadaEST = True
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
                fotoCambiadaANI = True
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