Public Class FrmCrearPreguntas
    Friend Sub INICIALIZAR()
        INICIALIZARCOMBO()
        BTN_OPCIONES.Enabled = False
        BTNcrearPregunta.Enabled = True
        TXTpregunta.Enabled = True
        TXT_OPC_UNO.Enabled = False
        TXT_OPC_DOS.Enabled = False
        TXT_OPC_TRES.Enabled = False
        TXT_OPC_CUATRO.Enabled = False
    End Sub
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
        INICIALIZAR()
    End Sub

    Private Sub BTNcrearPregunta_Click(sender As Object, e As EventArgs) Handles BTNcrearPregunta.Click
        Try
            If String.IsNullOrWhiteSpace(CMBseleccionarCate.Text) OrElse
               String.IsNullOrWhiteSpace(TXTpregunta.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If CMBseleccionarCate.SelectedIndex >= 0 Then
                Dim index As Integer = CMBseleccionarCate.SelectedIndex + 1
                Dim tiempo As Integer = 60
                Dim puntaje As Integer = 1
                Dim caracteres As Integer = 100000
                Dim comando As String = "INSERT INTO PREGUNTA (ID_PREGUNTA, ID_CATEGORIA, ENUNCIADO_PREGUNTA, TIEMPO_LIMITE, MAX_CARACTERES, PUNTAJE) VALUES ( '" & PK("PREGUNTA", "ID_PREGUNTA") & "','" & index & "', '" & TXTpregunta.Text & "','" & tiempo & "','" & caracteres & "','" & puntaje & "')"
                EJECUTARSI(comando)
            End If
            MsgBox("Pregunta creada exitosamente.", vbOK, "")
            BTN_OPCIONES.Enabled = True
            BTNcrearPregunta.Enabled = False
            TXTpregunta.Enabled = False
            TXT_OPC_UNO.Enabled = True
            TXT_OPC_DOS.Enabled = True
            TXT_OPC_TRES.Enabled = True
            TXT_OPC_CUATRO.Enabled = True
        Catch ex As Exception
            Console.WriteLine("Error al crear usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al crear la categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_OPCIONES_Click(sender As Object, e As EventArgs) Handles BTN_OPCIONES.Click
        Try
            If String.IsNullOrWhiteSpace(TXT_OPC_UNO.Text) OrElse
               String.IsNullOrWhiteSpace(TXT_OPC_DOS.Text) OrElse
               String.IsNullOrWhiteSpace(TXT_OPC_DOS.Text) OrElse
               String.IsNullOrWhiteSpace(TXT_OPC_CUATRO.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim id_pregunta As Integer
            ds.Tables.Clear()
            Dim comando As String = "SELECT ID_PREGUNTA FROM PREGUNTA WHERE ENUNCIADO_PREGUNTA = '" & TXTpregunta.Text & "'"
            CARGAR_TABLA(ds, comando)
            id_pregunta = ds.Tables(0).Rows(0).Item(0)
            Dim verdadero As String = "Verdadero"
            Dim falso As String = "Falso"
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_UNO.Text & "','" & verdadero & "')"
            EJECUTARSI(comando)
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_DOS.Text & "','" & falso & "')"
            EJECUTARSI(comando)
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_TRES.Text & "','" & falso & "')"
            EJECUTARSI(comando)
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_CUATRO.Text & "','" & falso & "')"
            EJECUTARSI(comando)
            MsgBox("Opciones creadas exitosamente.", vbOK, "")
            REINICIAR()
            INICIALIZAR()
        Catch ex As Exception
            Console.WriteLine("Error al crear usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al crear la categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend Sub REINICIAR()
        CMBseleccionarCate.SelectedItem = Nothing
        TXTpregunta.Text = ""
        TXT_OPC_UNO.Text = ""
        TXT_OPC_DOS.Text = ""
        TXT_OPC_TRES.Text = ""
        TXT_OPC_CUATRO.Text = ""
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LBL_IDPREG.Click

    End Sub
End Class