Public Class FrmMenuProfesor
    Private duracionTransicion As Double = 1 ' Duración de la transición en segundos almacenado en una variable global.
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente
    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub FrmMenuProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        ocultarMenu()

    End Sub

    Private Sub ocultarMenu()
        PanelSubFormularios.Visible = False
        panelCalificaciones.Visible = False
    End Sub

    Private Sub mostrarMenu(SubMenu As Panel)
        If SubMenu.Visible = False Then
            ocultarMenu()
            SubMenu.Visible = True
        Else
            SubMenu.Visible = False
        End If
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

    Private Sub BTNtemas_Click(sender As Object, e As EventArgs) Handles BTNtemas.Click
        mostrarMenu(PanelSubFormularios)
    End Sub

    Private Sub BTNcategorias_Click(sender As Object, e As EventArgs) Handles BTNcategorias.Click
        mostrarMenu(panelCalificaciones)
    End Sub

    Private Sub BTNcalificaciones_Click_1(sender As Object, e As EventArgs) Handles BTNcalificaciones.Click
        mostrarMenu(Panel_Reportes)
    End Sub
End Class