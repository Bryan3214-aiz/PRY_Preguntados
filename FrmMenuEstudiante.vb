Public Class FrmMenuEstudiante

    Dim nombree As String = FrmLoginEstudiante.NOMBRE_ESTUDIANTE
    Dim id_estudiante As Integer = FrmLoginEstudiante.ID_estudiante
    Dim nivele As String = FrmLoginEstudiante.NIVEL_ESTUDIANTE

    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0
    Private Sub FrmMenuEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True

        Me.Opacity = 0

        Temporizado.Interval = 20
        Temporizado.Start()
    End Sub
    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000
        Me.Opacity = Math.Min(tiempoTranscurrido / duracionTransicion, 1)

        If tiempoTranscurrido >= duracionTransicion Then
            Temporizado.Stop()
        End If
    End Sub

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(99, Color.Black)
    End Sub

    Private Sub BTNeditarInfoEstudiante_Click(sender As Object, e As EventArgs) Handles BTNeditarInfoEstudiante.Click
        Me.Hide()
        FrmEditarInformacion.ShowDialog()
    End Sub

    Private Sub BTNcomenzar_Click(sender As Object, e As EventArgs) Handles BTNcomenzar.Click
        Me.Hide()
        FrmMenuPartidaEstudiante.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BTNranking_Click(sender As Object, e As EventArgs) Handles BTNranking.Click
        Me.Hide()
        FrmRankingEstudiante.ShowDialog()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Hide()
        FrmVerPuntuaciones.ShowDialog()
    End Sub

    Private Sub btnSAlir2_Click(sender As Object, e As EventArgs) Handles btnSAlir2.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        If resultado = DialogResult.Yes Then
            FrmOPCIONES.Close()
            FrmMenuPartidaEstudiante.Close()
            FrmResultados.Close()
            Me.Close()
        End If
    End Sub


End Class