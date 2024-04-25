Public Class FrmResultados
    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0
    Private Sub FrmResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        Temporizado.Interval = 20
        Temporizado.Start()
        Guna2Panel1.BackColor = Color.FromArgb(80, Color.Black)
        inicializar()
    End Sub
    Friend Sub inicializar()

    End Sub

    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000

        Me.Opacity = Math.Min(tiempoTranscurrido / duracionTransicion, 1)

        If tiempoTranscurrido >= duracionTransicion Then
            Temporizado.Stop()
        End If
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            FrmMenuEstudiante.Close()
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        Me.Hide()
        FrmMenuPartidaEstudiante.Show()
    End Sub
End Class