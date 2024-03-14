Public Class FrmOPCIONES
    Dim DuracionTransicion As Double = 0.7
    Private tiempoTranscurrido As Double = 0

    Private Sub FrmOPCIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        Temporizado.Interval = 20
        Temporizado.Start()
    End Sub


    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000 ' Convertir el intervalo a segundos

        ' Calcular la opacidad del formulario en función del tiempo transcurrido y la duración de la transición
        Me.Opacity = Math.Min(tiempoTranscurrido / DuracionTransicion, 1)

        ' Si el tiempo transcurrido supera la duración de la transición, detener el temporizador
        If tiempoTranscurrido >= DuracionTransicion Then
            Temporizado.Stop()
        End If
    End Sub


    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles Panel.Paint
        Panel.BackColor = Color.FromArgb(99, Color.Black)
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub BTNprofesor_Click(sender As Object, e As EventArgs) Handles BTNprofesor.Click
        Me.Hide()
        FrmLoginProfesor.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BTNestudiante_Click(sender As Object, e As EventArgs) Handles BTNestudiante.Click
        Me.Hide()
        FrmLoginEstudiante.ShowDialog()
        Me.Close()
    End Sub


    Private Sub BTNadmin_Click(sender As Object, e As MouseEventArgs) Handles BTNadmin.Click
        ' Verificar si se hizo clic derecho
        If e.Button = MouseButtons.Left Then
            ' Preguntar al usuario por el patrón
            Dim patron As String = InputBox("Ingrese el patrón para habilitar el acceso de administrador:")

            ' Verificar si el patrón es correcto
            If patron = "patron" Then
                ' Habilitar el botón de administrador
                Me.Hide()
                FrmLoginAdmin.ShowDialog()
                Me.Close()
            Else
                MessageBox.Show("Patrón incorrecto. No tiene acceso de administrador.")
            End If
        End If
    End Sub
End Class