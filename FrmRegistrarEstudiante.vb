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
        ' Construye la cadena de comando SQL para insertar un nuevo estudiante en la tabla ESTUDIANTE.
        ' Se utilizan los valores de los controles del formulario para completar los campos correspondientes.
        Dim Comando As String = "INSERT INTO ESTUDIANTE (ID_USUARIO, CURSO_LECTIVO, NIVEL, ASIGNATURA, PERIODO, SECCION, IDENTIFICACION, NOMBRE_COMPLETO, CORREO_ELECTRONICO, CONTRASENA) VALUES ('" & PK("ESTUDIANTE", "ID_USUARIO") & "', '" & CMBcursoLectivo.Text & "', '" & CMBgrado.Text & "', '" & CMBasignatura.Text & "', '" & CMBperiodo.Text & "', '" & CMBseccion.Text & "', '" & TXTidentifacion.Text & "', '" & TXTnombre.Text & "', '" & TXTcorreo.Text & "', '" & TXTcontrasena.Text & "')"
        ' Ejecuta la función EJECUTAR pasando la cadena de comando SQL como argumento.
        EJECUTAR(Comando)
        ' Muestra un mensaje de confirmación.
        MsgBox("Listo")
        ' Oculta el formulario actual.
        Me.Hide()
        ' Muestra el formulario de inicio de sesión para estudiantes.
        FrmOPCIONES.Show()
    End Sub

End Class