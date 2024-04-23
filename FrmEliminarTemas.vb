Public Class FrmEliminarTemas
    Dim ID As Integer = 0
    Friend Sub INICIALIZAR()
        comando = "SELECT * FROM TEMA"
        BUSCAR(comando)
        BTNeliminarTema.Enabled = False
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
            Next
        End If
    End Sub

    Private Sub TXTNOMBRESUCURSAL_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRESUCURSAL.TextChanged
        comando = "SELECT * FROM TEMA WHERE NOMBRE_TEMA LIKE '%" & TXTNOMBRESUCURSAL.Text & "%'"
        BUSCAR(comando)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToString(L.SelectedItems(0).Text)
            BTNeliminarTema.Enabled = True
        End If
    End Sub
    Private Sub BTNeliminarTema_Click(sender As Object, e As EventArgs) Handles BTNeliminarTema.Click
        If ID <> 0 Then
            If MsgBox("¿Desea realmente eliminar el tema seleccionado?", vbQuestion + vbYesNo, "Confirmar Solicitud") = vbYes Then
                comando = "DELETE FROM TEMA WHERE ID_TEMA = " & ID
                EJECUTARSI(comando)
                INICIALIZAR()
                MsgBox("El tema ha sido eliminado satisfactoriamente.", vbInformation + vbOKOnly, "Eliminación Exitosa")
                BTNeliminarTema.Enabled = False
            End If
        End If
    End Sub
End Class