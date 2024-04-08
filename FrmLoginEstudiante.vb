Imports System.Data.OleDb

Public Class FrmLoginEstudiante
    Private duracionTransicion As Double = 0.5 ' Duración de la transición en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente

    Private Sub BTNregistrarEstudiante_Click(sender As Object, e As EventArgs) Handles BTNregistrarEstudiante.Click
        Me.Hide()
        FrmRegistrarEstudiante.ShowDialog()
        Me.Close()
    End Sub

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(55, Color.Black)
    End Sub

    Private Sub FrmLoginEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox("  Si es la primera vez que utilizas el juego:" & vbCrLf &
        "     • Dale click al botón de registrarse." & vbCrLf &
        "     • Ingresa tus datos personales en los respectivos campos." & vbCrLf &
        "     • Finalmente le das click al botón crear usuario." & vbCrLf & "" & vbCrLf &
        "  Si ya has utilizado el juego anteriormente:" & vbCrLf &
        "     • Inicia sesión rellenando los campos con tu" & vbCrLf &
        "       información personal." & vbCrLf & "" & vbCrLf &
        "   ¡Que disfrutes del juego, buena suerte! :D", vbOKOnly + vbInformation, "PREGUNTADOS (PLATAFORMA DE JUEGOS DE TRIVIA)")

        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        Label1.BackColor = Color.FromArgb(35, Color.Black)

    End Sub

    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000
        ' Calcular la opacidad del formulario en función del tiempo transcurrido y la duración de la transición
        Me.Opacity = Math.Min(tiempoTranscurrido / duracionTransicion, 1)

        ' Si el tiempo transcurrido supera la duración de la transición, detener el temporizador
        If tiempoTranscurrido >= duracionTransicion Then
            Temporizado.Stop()
        End If
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            FrmOPCIONES.Close()
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub BTNiniciar_Click(sender As Object, e As EventArgs) Handles BTNiniciar.Click
        ' Conexión a la base de datos
        CONECTAR()
        ' Comando SQL para realizar la verificación de login
        Dim comando As String = "SELECT * FROM ESTUDIANTE WHERE CORREO_ELECTRONICO = '" & TXTcorreo.Text & "' AND CONTRASENA = '" & TXTcontrasena.Text & "'"
        Dim adp As New OleDb.OleDbDataAdapter(comando, miconexion)
        ' Se crea un nuevo DataSet para almacenar los resultados
        Dim ds As New DataSet()
        ' Se llena el DataSet con los resultados de la consulta
        adp.Fill(ds, "tabla")
        ' Se verifica si se encontraron filas en el DataSet
        If ds.Tables("tabla").Rows.Count > 0 Then
            ' Si se encontraron filas, el inicio de sesión es exitoso
            Me.Hide()
            FrmMenuEstudiante.ShowDialog()
            Me.Close()
        Else
            ' Si no se encontraron filas, se muestra un mensaje de error
            MsgBox("El usuario o contraseña no coinciden")
            ' Se limpian los campos de texto
            TXTcorreo.Text = ""
            TXTcontrasena.Text = ""
        End If
        ' Se desconecta de la base de datos
        DESCONECTAR()
    End Sub

    Private Sub panel2_Paint(sender As Object, e As PaintEventArgs) Handles panel2.Paint
        panel2.BackColor = Color.FromArgb(85, Color.Black)
    End Sub

    Private Sub BTNvolverMenu_Click(sender As Object, e As EventArgs) Handles BTNvolverMenu.Click
        Me.Hide()
        FrmOPCIONES.Show()
    End Sub
End Class