Public Class FrmMenuPartidaEstudiante
    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0
    Public ID_CAT As Integer

    Private Sub FrmMenuPartidaEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        Temporizado.Interval = 20
        Temporizado.Start()
        Guna2Panel1.BackColor = Color.FromArgb(75, Color.Black)
        Inicializar()
        DetenerMusica()

    End Sub
    Private Sub DetenerMusica()
        If reproductor IsNot Nothing Then
            reproductor.Stop()
        End If
    End Sub
    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            FrmMenuEstudiante.Close()
            FrmResultados.Close()
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000

        Me.Opacity = Math.Min(tiempoTranscurrido / duracionTransicion, 1)

        If tiempoTranscurrido >= duracionTransicion Then
            Temporizado.Stop()
        End If
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        Me.Hide()
        FrmMenuEstudiante.Show()
    End Sub

    Friend Sub Inicializar()
        Dim nivel As String = FrmLoginEstudiante.NIVEL_ESTUDIANTE
        Dim ID_ESTUDIANTE_ACTUAL As Integer = FrmLoginEstudiante.ID_estudiante
        comando = "SELECT C.ID_CATEGORIA, C.NOMBRE_CATEGORIA FROM CATEGORIA C " &
              "INNER JOIN TEMA T ON C.ID_TEMA = T.ID_TEMA " &
              "INNER JOIN PARTIDA P ON C.ID_CATEGORIA = P.ID_CATEGORIA " &
              "WHERE T.NIVEL = '" & nivel & "' AND P.ID_ESTUDIANTE <> '" & ID_ESTUDIANTE_ACTUAL & "'"
        BUSCARcombo(comando)
    End Sub

    Friend Sub BUSCARcombo(ByVal SQL As String)
        ds.Tables.Clear()
        CMBseleccionarFRM.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                ID_CAT = ds.Tables(0).Rows(I).Item(0)
                CMBseleccionarFRM.Items.Add(ds.Tables(0).Rows(I).Item(1))
            Next
        End If
    End Sub

    Private Sub BTNcomenzar_Click(sender As Object, e As EventArgs) Handles BTNcomenzar.Click
        Me.Hide()
        FrmJuegoPreguntas.ShowDialog()
    End Sub

End Class