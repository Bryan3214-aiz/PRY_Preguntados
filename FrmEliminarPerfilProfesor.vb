Public Class FrmEliminarPerfilProfesor
    Dim ID As Integer = 0 'CODIGO SELECCIONADO

    Friend Sub INICIALIZAR()
        comando = "SELECT ID_PROFESOR, NOMBRE_COMPLETO, CORREO_ELECTRONICO, IDENTIFICACION FROM PROFESOR"
        BUSCAR(comando)
        BTNeliminarProfesor.Enabled = False
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

    Private Sub TXTNOMBREPROFESOR_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBREPROFESOR.TextChanged
        comando = "SELECT ID_PROFESOR, NOMBRE_COMPLETO, CORREO_ELECTRONICO, IDENTIFICACION FROM PROFESOR WHERE NOMBRE_COMPLETO LIKE '%" & TXTNOMBREPROFESOR.Text & "%'"
        BUSCAR(comando)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToString(L.SelectedItems(0).Text)
            BTNeliminarProfesor.Enabled = True
        End If
    End Sub

    Private Sub FrmEliminarPerfilProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR()
    End Sub

    Private Sub BTNeliminarProfesor_Click(sender As Object, e As EventArgs) Handles BTNeliminarProfesor.Click
        If ID <> 0 Then
            If MsgBox("¿Desea realmente eliminar la categoria seleccionada?", vbQuestion + vbYesNo, "Confirmar Eliminación") = vbYes Then
                comando = "DELETE FROM PROFESOR WHERE ID_PROFESOR = " & ID
                EJECUTARSI(comando)
                INICIALIZAR()
                MsgBox("La categoria ha sido eliminada satisfactoriamente.", vbInformation + vbOKOnly, "Eliminación Exitosa")
                BTNeliminarProfesor.Enabled = False
            End If
        End If
    End Sub
End Class