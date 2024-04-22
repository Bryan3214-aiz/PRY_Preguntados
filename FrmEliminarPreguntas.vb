Public Class FrmEliminarPreguntas
    Dim ID As Integer = 0 'CODIGO SELECCIONADO
    Friend Sub INICIALIZAR()
        comando = "SELECT PREGUNTA.ID_PREGUNTA, PREGUNTA.ENUNCIADO_PREGUNTA, CATEGORIA.NOMBRE_CATEGORIA, PREGUNTA.PUNTAJE FROM PREGUNTA INNER JOIN CATEGORIA ON CATEGORIA.ID_CATEGORIA = PREGUNTA.ID_CATEGORIA"
        BUSCAR(comando)
        BTNeliminarCategoria.Enabled = False
        ID = 0
    End Sub
    Friend Sub BUSCAR(ByVal SQL As String)
        ds.Tables.Clear()
        L.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(3))
            Next
        End If
    End Sub
    Private Sub TXTNOMBRECATEGORIA_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRECATEGORIA.TextChanged
        comando = "SELECT PREGUNTA.ID_PREGUNTA, PREGUNTA.ENUNCIADO_PREGUNTA, CATEGORIA.NOMBRE_CATEGORIA, PREGUNTA.PUNTAJE FROM PREGUNTA INNER JOIN CATEGORIA ON CATEGORIA.ID_CATEGORIA = PREGUNTA.ID_CATEGORIA WHERE ENUNCIADO_PREGUNTA LIKE '%" & TXTNOMBRECATEGORIA.Text & "%'"
        BUSCAR(comando)
    End Sub

    Private Sub BTNeliminarCategoria_Click(sender As Object, e As EventArgs) Handles BTNeliminarCategoria.Click
        If ID <> 0 Then
            If MsgBox("¿Desea realmente eliminar la categoria seleccionada?", vbQuestion + vbYesNo, "Confirmar Eliminación") = vbYes Then
                comando = "DELETE FROM OPCION WHERE ID_PREGUNTA = " & ID
                EJECUTARSI(comando)
                comando = "DELETE FROM PREGUNTA WHERE ID_PREGUNTA = " & ID
                EJECUTARSI(comando)
                INICIALIZAR()
                MsgBox("La pregunta ha sido eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminación Exitosa")
                BTNeliminarCategoria.Enabled = False
            End If
        End If
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToString(L.SelectedItems(0).Text)
            BTNeliminarCategoria.Enabled = True
        End If
    End Sub

    Private Sub FrmEliminarPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR()
    End Sub
End Class