Imports System.IO
Public Class FrmActualizarPreguntas
    Friend Sub INICIALIZAR()
        INICIALIZARCOMBO()
        BTN_actualizar.Enabled = False
        BTN_CARGAROPC.Enabled = True
        CMB_ACT_PRE.Enabled = True
        TXTactpregunta.Enabled = False
        TXT_actOPC_UNO.Enabled = False
        TXT_actOPC_DOS.Enabled = False
        TXT_actOPC_TRES.Enabled = False
        TXT_actOPC_CUATRO.Enabled = False
    End Sub
    Friend Sub INICIALIZARCOMBO()
        comando = "SELECT ENUNCIADO_PREGUNTA FROM PREGUNTA"
        BUSCARcombo(comando)
    End Sub
    Friend Sub BUSCARcombo(ByVal SQL As String)
        ds.Tables.Clear()
        CMB_ACT_PRE.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                CMB_ACT_PRE.Items.Add(ds.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub

    Private Sub BTN_CARGAROPC_Click(sender As Object, e As EventArgs) Handles BTN_CARGAROPC.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Desea editar la su información personal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            BTN_actualizar.Enabled = True
            BTN_CARGAROPC.Enabled = False
            TXTactpregunta.Enabled = True
            TXT_actOPC_UNO.Enabled = True
            TXT_actOPC_DOS.Enabled = True
            TXT_actOPC_TRES.Enabled = True
            TXT_actOPC_CUATRO.Enabled = True
            Dim index As Integer = CMB_ACT_PRE.SelectedIndex + 1
            ds.Tables.Clear()
            comando = "SELECT ID_PREGUNTA, ENUNCIADO_PREGUNTA FROM PREGUNTA WHERE ID_PREGUNTA = " & index & ""
            CARGAR_TABLA(ds, comando)
            LBL_CARGAR_PREGUNTA.Text = ds.Tables(0).Rows(0).Item(0)
            TXTactpregunta.Text = ds.Tables(0).Rows(0).Item(1)

            ds.Tables.Clear()
            comando = "SELECT ID_OPCION, TEXTO_OPCION FROM OPCION WHERE ID_PREGUNTA = " & index & ""
            CARGAR_TABLA(ds, comando)
            Dim id_opcion As Integer = ds.Tables(0).Rows(0).Item(0)
            TXT_actOPC_UNO.Text = ds.Tables(0).Rows(0).Item(1)

            ds.Tables.Clear()
            comando = "SELECT TEXTO_OPCION FROM OPCION WHERE ID_OPCION = " & id_opcion + 1 & ""
            CARGAR_TABLA(ds, comando)
            TXT_actOPC_DOS.Text = ds.Tables(0).Rows(0).Item(0)

            ds.Tables.Clear()
            comando = "SELECT TEXTO_OPCION FROM OPCION WHERE ID_OPCION = " & id_opcion + 1 + 1 & ""
            CARGAR_TABLA(ds, comando)
            TXT_actOPC_TRES.Text = ds.Tables(0).Rows(0).Item(0)

            ds.Tables.Clear()
            comando = "SELECT TEXTO_OPCION FROM OPCION WHERE ID_OPCION = " & id_opcion + 1 + 1 + 1 & ""
            CARGAR_TABLA(ds, comando)
            TXT_actOPC_CUATRO.Text = ds.Tables(0).Rows(0).Item(0)
        Else
            CMB_ACT_PRE.SelectedItem = Nothing
        End If
    End Sub
    Private Sub FrmActualizarPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR()
    End Sub
    Private Sub BTN_actualizar_Click(sender As Object, e As EventArgs) Handles BTN_actualizar.Click
        Try
            If String.IsNullOrWhiteSpace(TXTactpregunta.Text) OrElse
            String.IsNullOrWhiteSpace(TXT_actOPC_UNO.Text) OrElse
            String.IsNullOrWhiteSpace(TXT_actOPC_DOS.Text) OrElse
            String.IsNullOrWhiteSpace(TXT_actOPC_TRES.Text) OrElse
            String.IsNullOrWhiteSpace(TXT_actOPC_CUATRO.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay campos vacíos
            End If
            ds.Tables.Clear()
            comando = "SELECT ID_OPCION FROM OPCION WHERE ID_PREGUNTA = " & LBL_CARGAR_PREGUNTA.Text & ""
            CARGAR_TABLA(ds, comando)
            Dim id_opcion As Integer = ds.Tables(0).Rows(0).Item(0)

            comando = "UPDATE PREGUNTA SET ENUNCIADO_PREGUNTA = '" & TXTactpregunta.Text & "' WHERE ID_PREGUNTA = " & LBL_CARGAR_PREGUNTA.Text & ""
            EJECUTARSI(comando)

            comando = "UPDATE OPCION SET TEXTO_OPCION = '" & TXT_actOPC_UNO.Text & "' WHERE ID_OPCION = " & id_opcion & ""
            EJECUTARSI(comando)

            comando = "UPDATE OPCION SET TEXTO_OPCION = '" & TXT_actOPC_DOS.Text & "' WHERE ID_OPCION = " & id_opcion + 1 & ""
            EJECUTARSI(comando)

            comando = "UPDATE OPCION SET TEXTO_OPCION = '" & TXT_actOPC_TRES.Text & "' WHERE ID_OPCION = " & id_opcion + 1 + 1 & ""
            EJECUTARSI(comando)

            comando = "UPDATE OPCION SET TEXTO_OPCION = '" & TXT_actOPC_CUATRO.Text & "' WHERE ID_OPCION = " & id_opcion + 1 + 1 + 1 & ""
            EJECUTARSI(comando)

            MsgBox("Datos actualizados.", vbOKOnly, "")
            INICIALIZAR()
            REINICIAR()
        Catch ex As Exception
            Console.WriteLine("Error de actualización: " & ex.Message)
            MessageBox.Show("Ocurrió un error al ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend Sub REINICIAR()
        CMB_ACT_PRE.SelectedItem = Nothing
        TXTactpregunta.Text = ""
        TXT_actOPC_UNO.Text = ""
        TXT_actOPC_DOS.Text = ""
        TXT_actOPC_TRES.Text = ""
        TXT_actOPC_CUATRO.Text = ""
    End Sub
End Class