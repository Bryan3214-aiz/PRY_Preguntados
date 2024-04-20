Imports System.IO

Public Class FrmVerDatosRegistradosEstudiante
    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0
    Dim ID As Integer = 0
    Private fotoCambiada As Boolean = False

    Private Sub FrmVerDatosRegistradosEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR()

        Me.DoubleBuffered = True

        Me.Opacity = 0

        Temporizado.Interval = 20
        Temporizado.Start()
        panel1.BackColor = Color.FromArgb(70, Color.Black)
        Label23.BackColor = Color.FromArgb(90, Color.Black)
    End Sub

    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000 ' Convertir el intervalo a segundos

        ' Calcular la opacidad del formulario en función del tiempo transcurrido y la duración de la transición
        Me.Opacity = Math.Min(tiempoTranscurrido / duracionTransicion, 1)

        ' Si el tiempo transcurrido supera la duración de la transición, detener el temporizador
        If tiempoTranscurrido >= duracionTransicion Then
            Temporizado.Stop()
        End If
    End Sub

    Private Sub BTNjuego_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FrmMenuEstudiante.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToInt32(L.SelectedItems(0).Text)
            BTNeditarInfo.Enabled = True
        End If
    End Sub

    Friend Sub INICIALIZAR()
        comando = "SELECT TOP 1 ID_usuario, Curso_Lectivo, Nivel, Asignatura, periodo, seccion, identificacion, nombre_completo, correo_electronico, contrasena,fotografia FROM estudiante ORDER BY ID_usuario DESC"
        BUSCAR(comando)
        reiniciar()
        ID = 0
    End Sub
    Friend Sub reiniciar()
        BTNguardarCambios.Enabled = False
        BTNeditarInfo.Enabled = False
        CMBasignatura.Enabled = False
        CMBcursolectivo.Enabled = False
        CMBgrado.Enabled = False
        CMBperiodo.Enabled = False
        CMBseccion.Enabled = False
        TXTnombre.Enabled = False
        TXTcontrasena.Enabled = False
        TXTcorreo.Enabled = False
        TXTidentifacion.Enabled = False
        BTNfotoSeleccionar.Enabled = False

        CMBcursolectivo.SelectedText = ""
        CMBasignatura.SelectedText = ""
        CMBgrado.SelectedText = ""
        CMBperiodo.SelectedText = ""
        CMBseccion.SelectedText = ""

        TXTnombre.Text = ""
        TXTcorreo.Text = ""
        TXTidentifacion.Text = ""
        TXTcontrasena.Text = ""
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
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(4))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(5))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(6))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(7))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(8))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(9))
                ' Recuperar la fotografía (asumiendo que está en la última columna de la tabla)
                Dim fotoBytes As Byte() = CType(ds.Tables(0).Rows(I).Item(10), Byte())
                If fotoBytes IsNot Nothing Then
                    Using ms As New MemoryStream(fotoBytes)
                        Dim imagen As Image = Image.FromStream(ms)
                        BTNfotoSeleccionar.Image = imagen
                    End Using
                End If
            Next

        End If
    End Sub

    Private Sub BTNeditarInfo_Click(sender As Object, e As EventArgs) Handles BTNeditarInfo.Click

        Dim resultado As DialogResult = MessageBox.Show("¿Deseas editar tu información personal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            BTNcomenzarJuego.Enabled = False
            BTNguardarCambios.Enabled = True
            BTNeditarInfo.Enabled = True
            CMBasignatura.Enabled = True
            CMBcursolectivo.Enabled = True
            CMBgrado.Enabled = True
            CMBperiodo.Enabled = True
            CMBseccion.Enabled = True
            TXTnombre.Enabled = True
            TXTcontrasena.Enabled = True
            TXTcorreo.Enabled = True
            TXTidentifacion.Enabled = True
            BTNfotoSeleccionar.Enabled = True

            If ID <> 0 Then
                comando = "SELECT id_usuario,Curso_Lectivo,Nivel,Asignatura,periodo,seccion,identificacion,nombre_completo,correo_electronico,contrasena from estudiante where ID_usuario = " & ID & ""
                ds.Tables.Clear()
                L.Items.Clear()
                CARGAR_TABLA(ds, comando)
                If ds.Tables(0).Rows.Count > 0 Then
                    For I = 0 To ds.Tables(0).Rows.Count - 1
                        L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(3))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(4))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(5))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(6))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(7))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(8))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(9))
                    Next
                End If
                CMBcursolectivo.Text = L.Items(L.Items.Count - 1).SubItems(1).Text
                CMBgrado.Text = L.Items(L.Items.Count - 1).SubItems(2).Text
                CMBasignatura.Text = L.Items(L.Items.Count - 1).SubItems(3).Text
                CMBperiodo.Text = L.Items(L.Items.Count - 1).SubItems(4).Text
                CMBseccion.Text = L.Items(L.Items.Count - 1).SubItems(5).Text
                TXTidentifacion.Text = L.Items(L.Items.Count - 1).SubItems(6).Text
                TXTnombre.Text = L.Items(L.Items.Count - 1).SubItems(7).Text
                TXTcorreo.Text = L.Items(L.Items.Count - 1).SubItems(8).Text
                TXTcontrasena.Text = L.Items(L.Items.Count - 1).SubItems(9).Text
            End If
        End If
    End Sub

    Private Function ObtenerBytesDeImagen(ByVal imagen As Image) As Byte()
        Using ms As New MemoryStream()
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub BTNfotoSeleccionar_Click(sender As Object, e As EventArgs) Handles BTNfotoSeleccionar.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                fotoCambiada = True
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub MostrarImagen(imagenBytes As Byte())
        Try
            Dim tempFilePath As String = Path.GetTempFileName()
            tempFilePath = Path.ChangeExtension(tempFilePath, ".jpg")
            File.WriteAllBytes(tempFilePath, imagenBytes)

            BTNfotoSeleccionar.Image = Image.FromFile(tempFilePath)
        Catch ex As Exception
            Console.WriteLine("Error al mostrar la imagen: " & ex.Message)
        End Try
    End Sub
    Private Sub BTNguardarCambios_Click(sender As Object, e As EventArgs) Handles BTNguardarCambios.Click
        Try
            If String.IsNullOrWhiteSpace(CMBgrado.Text) OrElse
            String.IsNullOrWhiteSpace(CMBcursolectivo.Text) OrElse
            String.IsNullOrWhiteSpace(CMBasignatura.Text) OrElse
            String.IsNullOrWhiteSpace(CMBperiodo.Text) OrElse
            String.IsNullOrWhiteSpace(CMBseccion.Text) OrElse
            String.IsNullOrWhiteSpace(TXTidentifacion.Text) OrElse
            String.IsNullOrWhiteSpace(TXTnombre.Text) OrElse
            String.IsNullOrWhiteSpace(TXTcorreo.Text) OrElse
            String.IsNullOrWhiteSpace(TXTcontrasena.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay campos vacíos
            End If

            If fotoCambiada <> False Then ' Verifica si se ha cambiado la foto
                Dim imagenBytes As Byte() = ObtenerBytesDeImagen(BTNfotoSeleccionar.Image)
                comando = "UPDATE ESTUDIANTE SET Curso_Lectivo = '" & CMBcursolectivo.Text & "', Nivel = '" & CMBgrado.Text & "', Asignatura = '" & CMBasignatura.Text & "', periodo = '" & CMBperiodo.Text & "', seccion = '" & CMBseccion.Text & "', identificacion = '" & TXTidentifacion.Text & "', nombre_completo = '" & TXTnombre.Text & "', correo_electronico = '" & TXTcorreo.Text & "', contrasena = '" & TXTcontrasena.Text & "', fotografia = ? where ID_usuario = " & ID & ""
                EJECUTAR(comando, imagenBytes)
                MsgBox("Datos actualizados sastifactoriamente.", vbOKOnly, "")
            Else
                comando = "UPDATE ESTUDIANTE SET Curso_Lectivo = '" & CMBcursolectivo.Text & "', Nivel = '" & CMBgrado.Text & "', Asignatura = '" & CMBasignatura.Text & "', periodo = '" & CMBperiodo.Text & "', seccion = '" & CMBseccion.Text & "', identificacion = '" & TXTidentifacion.Text & "', nombre_completo = '" & TXTnombre.Text & "', correo_electronico = '" & TXTcorreo.Text & "', contrasena = '" & TXTcontrasena.Text & "' where ID_usuario = " & ID & ""
                EJECUTARSI(comando)
                MsgBox("Datos actualizados sastifactoriamente.", vbOKOnly, "")
            End If

            INICIALIZAR()
            Me.Hide()
            FrmMenuEstudiante.ShowDialog()
            Me.Close()

        Catch ex As Exception
            Console.WriteLine("Error de actualización: " & ex.Message)
            MessageBox.Show("Ocurrió un error al ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNcomenzarJuego_Click(sender As Object, e As EventArgs) Handles BTNcomenzarJuego.Click
        Me.Hide()
        FrmMenuEstudiante.ShowDialog()
        Me.Close()
    End Sub
End Class