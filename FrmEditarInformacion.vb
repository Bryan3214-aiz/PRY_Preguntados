Public Class FrmEditarInformacion

    Private duracionTransicion As Double = 0.5 ' Duración de la transición en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente
    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(65, Color.Black)
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        Dim resultado As DialogResult = MessageBox.Show("Si sales y no guardas los cambios, estos se perderan.       ¿Deseas salir de todas formas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resultado = DialogResult.Yes Then
            Me.DoubleBuffered = True
            Temporizado.Interval = 20 ' Intervalo en milisegundos
            Temporizado.Start()
            Me.Hide()
            FrmMenuEstudiante.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FrmEditarInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        Label1.BackColor = Color.FromArgb(50, Color.Black)
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

    Private Sub panelinfo_Paint(sender As Object, e As PaintEventArgs) Handles panelinfo.Paint
        panelinfo.BackColor = Color.FromArgb(85, Color.Black)
    End Sub

End Class