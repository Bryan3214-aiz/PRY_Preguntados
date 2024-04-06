Public Class FrmMenuProfesor
    Private duracionTransicion As Double = 0.5 ' Duración de la transición en segundos almacenado en una variable global.
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente

    Private Sub FrmMenuProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        FormularioAbierto(New FrmInicioMProfesor())
        ocultarMenu()

    End Sub

    Private Sub ocultarMenu()
        panelTemas.Visible = False
        panelCategorias.Visible = False
        panelPreguntas.Visible = False
        panelReportes.Visible = False
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

    '---------------------------------------------Metodos para mostrar paneles con las opciones de menu-------------------------------------------------------

    Private Sub BTNtemas_Click(sender As Object, e As EventArgs) Handles BTNtemas.Click
        mostrarMenu(panelTemas)
    End Sub

    Private Sub BTNcategorias_Click(sender As Object, e As EventArgs) Handles BTNcategorias.Click
        mostrarMenu(panelCategorias)
    End Sub

    Private Sub BTNpreguntas_Click_1(sender As Object, e As EventArgs) Handles BTNpreguntas.Click
        mostrarMenu(panelPreguntas)
    End Sub
    Private Sub BTNmiPerfil_Click(sender As Object, e As EventArgs) Handles BTNreportes.Click
        mostrarMenu(panelReportes)
    End Sub


    '---------------------------------------------Botones del menu que llaman a los formularios-------------------------------------------------------------

    Private Sub BTNcrearTemas_Click(sender As Object, e As EventArgs) Handles BTNcrearTemas.Click
        FormularioAbierto(New FrmCrearTemas())
        ocultarMenu()
    End Sub

    Private Sub BTNeditarTemas_Click(sender As Object, e As EventArgs) Handles BTNeditarTemas.Click
        FormularioAbierto(New FrmEditarTemas())
        ocultarMenu()
    End Sub

    Private Sub BTNeliminarTemas_Click(sender As Object, e As EventArgs) Handles BTNeliminarTemas.Click
        FormularioAbierto(New FrmEliminarTemas())
        ocultarMenu()
    End Sub

    Private Sub BTNbuscarTemas_Click(sender As Object, e As EventArgs) Handles BTNbuscarTemas.Click
        FormularioAbierto(New FrmBuscarTemas())
        ocultarMenu()
    End Sub



    Private Sub BTNcrearCategorias_Click(sender As Object, e As EventArgs) Handles BTNcrearCategorias.Click
        FormularioAbierto(New FrmCrearCategorias())
        ocultarMenu()
    End Sub

    Private Sub BTNeditarCategorias_Click(sender As Object, e As EventArgs) Handles BTNeditarCategorias.Click
        ocultarMenu()
    End Sub

    Private Sub BTNbuscarCategorias_Click(sender As Object, e As EventArgs) Handles BTNbuscarCategorias.Click
        FormularioAbierto(New FrmBuscarCategorias())
        ocultarMenu()
    End Sub
    Private Sub BTNeliminarCategorias_Click(sender As Object, e As EventArgs) Handles BTNeliminarCategorias.Click
        FormularioAbierto(New FrmEliminarCategorias())
        ocultarMenu()
    End Sub





    Private Sub BTNasignarCalificacion_Click(sender As Object, e As EventArgs) Handles BTNasignarCalificacion.Click
        FormularioAbierto(New FrmAsignarCalificaciones())
        ocultarMenu()
    End Sub
    Private Sub BTNcrearReportes_Click(sender As Object, e As EventArgs) Handles BTNcrearReportes.Click
        FormularioAbierto(New FrmCrearReportes())
        ocultarMenu()
    End Sub

    Private Sub BTNenviarCorreoReporte_Click(sender As Object, e As EventArgs) Handles BTNenviarCorreoReporte.Click
        FormularioAbierto(New FrmEnviarCorreo())
        ocultarMenu()
    End Sub






    Private Sub BTNperfil_Click(sender As Object, e As EventArgs) Handles BTNperfil.Click
        ocultarMenu()
    End Sub

    Private Sub BTNinicio_Click(sender As Object, e As EventArgs) Handles BTNinicio.Click
        FormularioAbierto(New FrmInicioMProfesor())
        ocultarMenu()
    End Sub




    '--------------------------------------------- Metodo que llama a los formularios -------------------------------------------------------

    Private formularioActual As Form = Nothing

    Private Sub FormularioAbierto(formulario As Form)
        If formularioActual IsNot Nothing Then
            formularioActual.Close()
        End If
        formularioActual = formulario
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill
        panelContenedor.Controls.Add(formulario)
        panelContenedor.Tag = formulario
        formulario.Show()
    End Sub


    Private Sub BTNcerrar_Click_1(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            FrmOPCIONES.Close()
            Me.Close() ' Cerrar el formulario
        End If
    End Sub


End Class