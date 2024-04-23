Public Class FrmActualizarTemas
    Dim ID As Integer = 0
    Private fotoCambiada As Boolean = False
    Private imagenBytesEstTemp As Byte()
    Private imagenBytesAniTemp As Byte()
    Private audioBytesTemp As Byte()
    Private sonidoBytesTemp As Byte()
    Private videoBytesTemp As Byte()

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
            BTNactualizarTema.Enabled = True
            If ID <> 0 Then
                BTNseleccionarTema.Enabled = False
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

    Private Sub BTNactualizarTema_Click(sender As Object, e As EventArgs) Handles BTNactualizarTema.Click
        Try
            If String.IsNullOrWhiteSpace(TXTtema.Text) OrElse
                String.IsNullOrWhiteSpace(CMBgradoTemas.Text) OrElse
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) Then
                Return
            End If

            If fotoCambiada = True Then ' Verifica si se ha cambiado la foto
                comando = "UPDATE PROFESOR SET nombre_completo = '" & TXTnombre.Text & "', identificacion = '" & TXTidentifacion.Text & "', correo_electronico = '" & TXTcorreo.Text & "', contrasena = '" & TXTcontrasena.Text & "', PATRON = '" & TXTpatron.Text & "', fotografia = ? WHERE ID_profesor = " & ID & ""
                MsgBox("Datos actualizados con foto nueva.", vbOKOnly, "")
            Else
                EJECUTARSI(comando)
                MsgBox("Datos actualizados sin foto.", vbOKOnly, "")
            End If
            inicializar()
        Catch ex As Exception
            Console.WriteLine("Error de actualización: " & ex.Message)
            MessageBox.Show("Ocurrió un error al ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class