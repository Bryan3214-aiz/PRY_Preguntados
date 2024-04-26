Public Class FrmResultados
    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0

    Private Sub FrmResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        Temporizado.Interval = 20
        Temporizado.Start()
        Guna2Panel1.BackColor = Color.FromArgb(80, Color.Black)
        INICIALIZAR()
    End Sub


    Friend Sub INICIALIZAR()

        ds.Tables.Clear()
        Dim ID_ESTUDIANTE As Integer = FrmLoginEstudiante.ID_estudiante
        Dim ID_CATEGORIA As Integer = FrmMenuPartidaEstudiante.CMBseleccionarFRM.SelectedIndex + 1
        comando = "SELECT ESTUDIANTE.NOMBRE_COMPLETO, ESTUDIANTE.NIVEL, PARTIDA.PUNTAJE, PARTIDA.TIEMPO_TOTAL, PARTIDA.RESPUESTAS_CORRECTAS, PARTIDA.RESPUESTAS_INCORRECTAS FROM PARTIDA INNER JOIN ESTUDIANTE ON ESTUDIANTE.ID_USUARIO = PARTIDA.ID_USUARIO WHERE PARTIDA.ID_USUARIO = " & ID_ESTUDIANTE & " AND PARTIDA.ID_CATEGORIA = " & ID_CATEGORIA & ""

        CARGAR_TABLA(ds, comando)

        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                LblNombreEstudiante.Text = ds.Tables(0).Rows(I).ItemArray(0)
                LbLNombreCategoria.Text = ds.Tables(0).Rows(I).ItemArray(1)
                LblPuntaje.Text = ds.Tables(0).Rows(I).ItemArray(2)
                LblDuracion.Text = ds.Tables(0).Rows(I).ItemArray(3)
                LblRsCorrectas.Text = ds.Tables(0).Rows(I).ItemArray(4)
                LblRsIncorrectas.Text = ds.Tables(0).Rows(I).ItemArray(5)
            Next

        End If

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
        FrmMenuEstudiante.Show()
    End Sub


End Class