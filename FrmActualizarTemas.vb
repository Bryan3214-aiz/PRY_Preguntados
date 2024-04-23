Public Class FrmActualizarTemas
    Dim ID As Integer = 0
    Private Sub FrmActualizarTemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializar()
    End Sub

    Friend Sub inicializar()
        comando = "SELECT * FROM TEMA"
        reiniciar()
        BUSCAR(comando)
    End Sub

    Friend Sub reiniciar()
        BTNseleccionarTema.Enabled = False
        BTNactualizarTema.Enabled = False
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

    Private Sub TXTNOMBRESUCURSAL_TextChanged(sender As Object, e As EventArgs) Handles TXTfiltrarNombreTema.TextChanged
        comando = "SELECT * FROM TEMA WHERE NOMBRE_TEMA Like '%" & TXTfiltrarNombreTema.Text & "%'"
        BUSCAR(comando)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToString(L.SelectedItems(0).Text)
            BTNseleccionarTema.Enabled = True
        End If
    End Sub

    Private Sub BTNseleccionarTema_Click(sender As Object, e As EventArgs) Handles BTNseleccionarTema.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Desea actualizar su información personal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            If ID <> 0 Then
                comando = "SELECT ID_TEMA, NOMBRE_TEMA, NIVEL FROM TEMA where ID_tema = " & ID & ""
                ds.Tables.Clear()
                L.Items.Clear()
                CARGAR_TABLA(ds, comando)
                If ds.Tables(0).Rows.Count > 0 Then
                    For I = 0 To ds.Tables(0).Rows.Count - 1
                        L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
                    Next
                End If
                TXTtema.Text = L.Items(L.Items.Count - 1).SubItems(1).Text
                CMBgradoTemas.Text = L.Items(L.Items.Count - 1).SubItems(2).Text
            End If
        End If
    End Sub
End Class