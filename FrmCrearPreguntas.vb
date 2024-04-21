Public Class FrmCrearPreguntas
    Friend Sub INICIALIZARCOMBO()
        comando = "SELECT NOMBRE_CATEGORIA FROM CATEGORIA"
        BUSCARcombo(comando)
    End Sub

    Friend Sub BUSCARcombo(ByVal SQL As String)
        ds.Tables.Clear()
        CMBseleccionarCate.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                CMBseleccionarCate.Items.Add(ds.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub

    Private Sub FrmCrearPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZARCOMBO()
    End Sub
End Class