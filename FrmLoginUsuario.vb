Imports System.Drawing.Drawing2D

Public Class FrmLoginUsuario
    Private duracionTransicion As Double = 0.5 ' Duración de la transición en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente
    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(99, Color.Black)
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub BTNiniciar_Click(sender As Object, e As EventArgs) Handles BTNiniciar.Click

        Me.Hide()
        FrmITZestudiante.ShowDialog()
        Me.Close()

    End Sub

    Private Sub FrmLoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
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
End Class

