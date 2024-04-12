Public Class FrmBuscarPerfilProfesor
    Dim ID As Integer = 0 'CODIGO SELECCIONADO
    Friend Sub INICIALIZAR()
        comando = "SELECT ID_PROFESOR, NOMBRE_COMPLETO, CORREO_ELECTRONICO, IDENTIFICACION,CONTRASENA, PATRON FROM PROFESOR"
        BUSCAR(comando)
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
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(4))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(5))
            Next
        End If
    End Sub
    Private Sub TXTNOMBREPROFESOR_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBREPROFESOR.TextChanged
        comando = "SELECT ID_PROFESOR, NOMBRE_COMPLETO, CORREO_ELECTRONICO, IDENTIFICACION, CONTRASENA, PATRON FROM PROFESOR WHERE NOMBRE_COMPLETO LIKE '%" & TXTNOMBREPROFESOR.Text & "%'"
        BUSCAR(comando)
    End Sub

    Private Sub FrmBuscarPerfilProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR()
    End Sub
End Class