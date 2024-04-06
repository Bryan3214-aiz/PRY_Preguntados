Imports System.IO
Public Class FrmRegistrarEstudiante
    Private duracionTransicion As Double = 1 ' Duración de la transición en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente

    Private Sub FrmRegistrarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        Temporizado.Interval = 20
        Temporizado.Start()
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

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(80, Color.Black)
    End Sub

    Private Sub BTNcerrar_Click_1(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            FrmOPCIONES.Close()
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub Label1_paint(sender As Object, e As EventArgs) Handles Label1.Paint
        Label1.BackColor = Color.FromArgb(85, Color.Black)
    End Sub

    Private Sub BTNcrearUsuario_Click(sender As Object, e As EventArgs) Handles BTNcrearUsuario.Click
        Try
            If String.IsNullOrWhiteSpace(CMBcursoLectivo.Text) OrElse
                String.IsNullOrWhiteSpace(CMBgrado.Text) OrElse
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
            Dim imagenBytes As Byte() = ObtenerBytesDeImagen(BTNfotoSeleccionar.Image)
            Dim Comando As String = "INSERT INTO ESTUDIANTE (ID_USUARIO, CURSO_LECTIVO, NIVEL, ASIGNATURA, PERIODO, SECCION, IDENTIFICACION, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CONTRASENA, FOTOGRAFIA) VALUES ('" & PK("ESTUDIANTE", "ID_USUARIO") & "', '" & CMBcursoLectivo.Text & "', '" & CMBgrado.Text & "', '" & CMBasignatura.Text & "', '" & CMBperiodo.Text & "', '" & CMBseccion.Text & "', '" & TXTidentifacion.Text & "', '" & TXTnombre.Text & "', '" & TXTcorreo.Text & "', '" & TXTcontrasena.Text & "', ?)"

            EJECUTAR(Comando, imagenBytes)
            MsgBox("Usuario creado exitosamente.")
            Me.Hide()
            FrmVerDatosRegistradosEstudiante.ShowDialog()
            Me.Close()
        Catch ex As Exception
            Console.WriteLine("Error al crear usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BTNfotoSeleccionar_Click(sender As Object, e As EventArgs) Handles BTNfotoSeleccionar.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
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
    Private Function ObtenerBytesDeImagen(ByVal imagen As Image) As Byte()
        Using ms As New MemoryStream()
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

End Class