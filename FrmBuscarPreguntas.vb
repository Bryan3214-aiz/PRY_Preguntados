Public Class FrmBuscarPreguntas
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
            Next
        End If
    End Sub
    Private Sub TXTNOMBRESUCURSAL_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRESUCURSAL.TextChanged
        comando = "SELECT PREGUNTA.ENUNCIADO_PREGUNTA, OPCION.ID_OPCION, PREGUNTA.PUNTAJE, OPCION.TEXTO_OPCION, OPCION.ESCORRECTA FROM OPCION INNER JOIN PREGUNTA ON PREGUNTA.ID_PREGUNTA = OPCION.ID_PREGUNTA WHERE ENUNCIADO_PREGUNTA LIKE '%" & TXTNOMBRESUCURSAL.Text & "%'"
        BUSCAR(comando)
    End Sub
End Class