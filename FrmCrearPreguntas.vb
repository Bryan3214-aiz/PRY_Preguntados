Public Class FrmCrearPreguntas
    Friend Sub INICIALIZAR()
        INICIALIZARCOMBO()
        BTN_OPCIONESA.Enabled = False
        BTNcrearPreguntaA.Enabled = True
        TXTpreguntaA.Enabled = True
        TXTpuntaje.Enabled = True
        TXTtiempo.Enabled = True
        TXT_OPC_UNOA.Enabled = False
        TXT_OPC_DOSA.Enabled = False
        TXT_OPC_TRESA.Enabled = False
        TXT_OPC_CUATROA.Enabled = False
    End Sub
    Friend Sub INICIALIZARCOMBO()
        comando = "SELECT NOMBRE_CATEGORIA FROM CATEGORIA"
        BUSCARcombo(comando)
    End Sub

    Friend Sub BUSCARcombo(ByVal SQL As String)
        ds.Tables.Clear()
        CMBseleccionarCateA.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                CMBseleccionarCateA.Items.Add(ds.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub

    Private Sub FrmCrearPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR()
    End Sub

    Private Sub BTNcrearPreguntaA_Click(sender As Object, e As EventArgs) Handles BTNcrearPreguntaA.Click
        Try
            If String.IsNullOrWhiteSpace(CMBseleccionarCateA.Text) OrElse
                String.IsNullOrWhiteSpace(TXTpuntaje.Text) OrElse
                String.IsNullOrWhiteSpace(TXTtiempo.Text) OrElse
               String.IsNullOrWhiteSpace(TXTpreguntaA.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If CMBseleccionarCateA.SelectedIndex >= 0 Then
                Dim index As Integer = CMBseleccionarCateA.SelectedIndex + 1
                Dim caracteres As Integer = 100000
                Dim comando As String = "INSERT INTO PREGUNTA (ID_PREGUNTA, ID_CATEGORIA, ENUNCIADO_PREGUNTA, TIEMPO_LIMITE, MAX_CARACTERES, PUNTAJE) VALUES ( '" & PK("PREGUNTA", "ID_PREGUNTA") & "','" & index & "', '" & TXTpreguntaA.Text & "','" & TXTtiempo.Text & "','" & caracteres & "','" & TXTpuntaje.Text & "')"
                EJECUTARSI(comando)
            End If
            MsgBox("Pregunta creada exitosamente.", vbOK, "")
            BTN_OPCIONESA.Enabled = True
            BTNcrearPreguntaA.Enabled = False
            TXTpreguntaA.Enabled = False
            TXTpuntaje.Enabled = False
            TXTtiempo.Enabled = False
            TXT_OPC_UNOA.Enabled = True
            TXT_OPC_DOSA.Enabled = True
            TXT_OPC_TRESA.Enabled = True
            TXT_OPC_CUATROA.Enabled = True
        Catch ex As Exception
            Console.WriteLine("Error al crear usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al crear la categoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_OPCIONESA_Click(sender As Object, e As EventArgs) Handles BTN_OPCIONESA.Click
        Try
            If String.IsNullOrWhiteSpace(TXT_OPC_UNOA.Text) OrElse
               String.IsNullOrWhiteSpace(TXT_OPC_DOSA.Text) OrElse
               String.IsNullOrWhiteSpace(TXT_OPC_TRESA.Text) OrElse
               String.IsNullOrWhiteSpace(TXT_OPC_CUATROA.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim id_pregunta As Integer
            ds.Tables.Clear()
            Dim comando As String = "SELECT ID_PREGUNTA FROM PREGUNTA WHERE ENUNCIADO_PREGUNTA = '" & TXTpreguntaA.Text & "'"
            CARGAR_TABLA(ds, comando)
            id_pregunta = ds.Tables(0).Rows(0).Item(0)
            Dim verdadero As String = "Verdadero"
            Dim falso As String = "Falso"
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_UNOA.Text & "','" & verdadero & "')"
            EJECUTARSI(comando)
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_DOSA.Text & "','" & falso & "')"
            EJECUTARSI(comando)
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_TRESA.Text & "','" & falso & "')"
            EJECUTARSI(comando)
            comando = "INSERT INTO OPCION (ID_OPCION, ID_PREGUNTA, TEXTO_OPCION, ESCORRECTA) VALUES ( '" & PK("OPCION", "ID_OPCION") & "','" & id_pregunta & "', '" & TXT_OPC_CUATROA.Text & "','" & falso & "')"
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
        CMBseleccionarCateA.SelectedItem = Nothing
        TXTpreguntaA.Text = ""
        TXTtiempo.Text = ""
        TXTpuntaje.Text = ""
        TXT_OPC_UNOA.Text = ""
        TXT_OPC_DOSA.Text = ""
        TXT_OPC_TRESA.Text = ""
        TXT_OPC_CUATROA.Text = ""
    End Sub
End Class