Public Class FrmBuscarCategorias

    Friend Sub BUSCAR(ByVal SQL As String)
        ds.Tables.Clear()
        L.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(0))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
            Next
        End If
    End Sub

    Private Sub TXTNOMBRESUCURSAL_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRESUCURSAL.TextChanged
        comando = "SELECT NOMBRE_CATEGORIA, TEMA.NOMBRE_TEMA FROM CATEGORIA INNER JOIN TEMA ON TEMA.ID_TEMA = CATEGORIA.ID_TEMA WHERE NOMBRE_CATEGORIA LIKE '%" & TXTNOMBRESUCURSAL.Text & "%'"
        BUSCAR(comando)
    End Sub
End Class