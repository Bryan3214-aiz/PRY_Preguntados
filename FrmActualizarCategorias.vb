Imports System.IO
Public Class FrmActualizarCategorias
    Dim ID As Integer = 0
    Private imagenBytesEstTemp As Byte()
    Private imagenBytesAniTemp As Byte()
    Private audioBytesTemp As Byte()
    Private sonidoBytesTemp As Byte()
    Private videoBytesTemp As Byte()

    Private Sub TXTfiltrarNombreTema_TextChanged(sender As Object, e As EventArgs) Handles TXTfiltrarNombreCat.TextChanged
        comando = "SELECT CATEGORIA.ID_CATEGORIA,CATEGORIA.NOMBRE_CATEGORIA, TEMA.NOMBRE_TEMA, TEMA.NIVEL FROM CATEGORIA INNER JOIN TEMA ON TEMA.ID_TEMA = CATEGORIA.ID_TEMA WHERE NOMBRE_CATEGORIA LIKE '%" & TXTfiltrarNombreCat.Text & "%'"
        BUSCAR(comando)
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
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(3))
            Next
        End If
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

    Private Sub FrmActualizarCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
        INICIALIZARCOMBO()
    End Sub

    Friend Sub reiniciar()
        BTNseleccionarCategoria.Enabled = False
        BTNactualizarCategoria.Enabled = False
        BTNimgEstaticaTema.Enabled = False
        BTNimgAnimadaTema.Enabled = False
        BTNsonidoTema.Enabled = False
        BTNAudioVozTema.Enabled = False
        BTNvideoTema.Enabled = False
        TXTcategoria.Enabled = False
        CMBseleccionarTemaC.Enabled = False
        TXTcategoria.Text = ""
        TXTfiltrarNombreCat.Text = ""
        CMBseleccionarTemaC.SelectedItem = Nothing
    End Sub

    Friend Sub inicializar()
        comando = "SELECT CATEGORIA.ID_CATEGORIA,CATEGORIA.NOMBRE_CATEGORIA, TEMA.NOMBRE_TEMA, TEMA.NIVEL FROM CATEGORIA INNER JOIN TEMA ON TEMA.ID_TEMA = CATEGORIA.ID_TEMA"
        reiniciar()
        BUSCAR(comando)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs)
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToString(L.SelectedItems(0).Text)
            BTNseleccionarCategoria.Enabled = True
        End If
    End Sub

    Private Sub BTNseleccionarCategoria_Click(sender As Object, e As EventArgs) Handles BTNseleccionarCategoria.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Desea actualizar los datos sobre la categoría?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            BTNactualizarCategoria.Enabled = True
            BTNimgEstaticaTema.Enabled = True
            BTNimgAnimadaTema.Enabled = True
            BTNsonidoTema.Enabled = True
            BTNAudioVozTema.Enabled = True
            BTNvideoTema.Enabled = True
            TXTcategoria.Enabled = True
            CMBseleccionarTemaC.Enabled = True

            If ID <> 0 Then
                BTNseleccionarCategoria.Enabled = False
                comando = "SELECT ID_Categoria,  Nombre_Categoria,ID_Tema, Imagen_Estatica, Imagen_Animada, Sonido_Categoria, Audio_Voz, Video_Categoria FROM CATEGORIA WHERE ID_Categoria = " & ID & ""
                ds.Tables.Clear()
                L.Items.Clear()
                CARGAR_TABLA(ds, comando)
                If ds.Tables(0).Rows.Count > 0 Then
                    For I = 0 To ds.Tables(0).Rows.Count - 1
                        L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
                        imagenBytesEstTemp = CType(ds.Tables(0).Rows(I).Item(3), Byte())
                        imagenBytesAniTemp = CType(ds.Tables(0).Rows(I).Item(4), Byte())
                        sonidoBytesTemp = CType(ds.Tables(0).Rows(I).Item(5), Byte())
                        audioBytesTemp = CType(ds.Tables(0).Rows(I).Item(6), Byte())
                        videoBytesTemp = CType(ds.Tables(0).Rows(I).Item(7), Byte())
                    Next
                End If
                TXTcategoria.Text = L.Items(L.Items.Count - 1).SubItems(1).Text
                Dim idTema As Integer = Convert.ToInt32(ds.Tables(0).Rows(0).Item(2))
                CMBseleccionarTemaC.SelectedIndex = idTema - 1
            End If
        End If
    End Sub

    Private Sub L_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToString(L.SelectedItems(0).Text)
            BTNseleccionarCategoria.Enabled = True
        End If
    End Sub

    Private Sub BTNactualizarCategoria_Click(sender As Object, e As EventArgs) Handles BTNactualizarCategoria.Click
        Try
            Dim imagenEstBytes As Byte() = imagenBytesEstTemp
            Dim imagenAniBytes As Byte() = imagenBytesAniTemp
            Dim sonidoBytes As Byte() = sonidoBytesTemp
            Dim audioBytes As Byte() = audioBytesTemp
            Dim videoBytes As Byte() = videoBytesTemp
            Dim index As Integer = CMBseleccionarTemaC.SelectedIndex + 1

            comando = "UPDATE CATEGORIA SET NOMBRE_CATEGORIA = '" & TXTcategoria.Text & "', ID_TEMA = " & index & ", IMAGEN_ESTATICA = ?, IMAGEN_ANIMADA = ?, SONIDO_CATEGORIA = ?, AUDIO_VOZ = ?,  VIDEO_CATEGORIA = ? where id_CATEGORIA = " & ID & " "
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