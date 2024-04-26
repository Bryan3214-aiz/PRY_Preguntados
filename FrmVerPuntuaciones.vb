Public Class FrmVerPuntuaciones
    Dim ID_ESTUDIANTE As Integer = FrmLoginEstudiante.ID_estudiante
    Friend Sub BUSCAR(ByVal SQL As String)
        ds.Tables.Clear()
        L.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(0))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(3))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(4))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(5))
            Next
        End If
    End Sub

    Private Sub FrmVerPuntuaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comando = "SELECT ESTUDIANTE.NOMBRE_COMPLETO, ESTUDIANTE.NIVEL, PARTIDA.PUNTAJE, PARTIDA.TIEMPO_TOTAL, PARTIDA.RESPUESTAS_CORRECTAS, PARTIDA.RESPUESTAS_INCORRECTAS FROM PARTIDA INNER JOIN ESTUDIANTE ON ESTUDIANTE.ID_USUARIO = PARTIDA.ID_USUARIO WHERE PARTIDA.ID_USUARIO = " & ID_ESTUDIANTE & ""
        BUSCAR(comando)
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        Me.Hide()
        FrmMenuEstudiante.ShowDialog()
    End Sub
End Class