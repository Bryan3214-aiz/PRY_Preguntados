Public Class FrmMenuAdministrador
    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            FrmOPCIONES.Close()
            Me.Close() ' Cerrar el formulario
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

    Private Sub FrmMenuAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        FormularioAbierto(New FrmCrearPerfilProfesor())
    End Sub

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

    Private Sub BTNcrearProfesor_Click(sender As Object, e As EventArgs) Handles BTNcrearProfesor.Click
        FormularioAbierto(New FrmCrearPerfilProfesor())
    End Sub

    Private Sub BTNactualizarProfesor_Click(sender As Object, e As EventArgs) Handles BTNactualizarProfesor.Click
        FormularioAbierto(New FrmActualizarPerfilProfesor())
    End Sub

    Private Sub BTNeliminarProfesor_Click(sender As Object, e As EventArgs) Handles BTNeliminarProfesor.Click
        FormularioAbierto(New FrmEliminarPerfilProfesor())
    End Sub

    Private Sub BTNbuscarProfesor_Click(sender As Object, e As EventArgs) Handles BTNbuscarProfesor.Click
        FormularioAbierto(New FrmBuscarPerfilProfesor())
    End Sub
End Class