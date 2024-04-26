
Public Class FrmJuegoPreguntas
    Dim M(100, 8) As String
    Dim FILA_ACTUAL As Integer = 0
    Dim PTOTAL As Integer = 0
    Dim CODIGOJUEGO As Integer = 0
    Dim tiempo_limite As Integer = 0

    Private Sub FrmJuegoPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR_PREGUNTAS()
    End Sub

    Friend Sub mostrar()
        comando = ""

    End Sub

    Friend Sub Buscar()

    End Sub

    Friend Sub REFRESCAR_PREGUNTAS()
        Dim T2 As New DataSet
        Dim ID_CATEGORIA As Integer = FrmMenuPartidaEstudiante.CMBseleccionarFRM.SelectedIndex + 1

        ds.Tables.Clear()
        comando = "SELECT ID_PREGUNTA, ENUNCIADO_PREGUNTA, PUNTAJE,tiempo_limite FROM PREGUNTA WHERE ID_CATEGORIA = " & ID_CATEGORIA & ""
        CARGAR_TABLA(ds, comando)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                M(I, 0) = ds.Tables(0).Rows(I).ItemArray(1) 'PREGUNTA
                M(I, 1) = ds.Tables(0).Rows(I).ItemArray(2) 'VALOR DE LA PREGUNTA
                M(I, 8) = ds.Tables(0).Rows(I).ItemArray(3)
                PTOTAL += ds.Tables(0).Rows(I).ItemArray(2)
                M(I, 7) = ds.Tables(0).Rows(I).ItemArray(0) 'ID PREGUNTA
                T2.Tables.Clear()
                comando = "SELECT TEXTO_OPCION FROM OPCION WHERE ID_PREGUNTA = " & ds.Tables(0).Rows(I).ItemArray(0) & ""
                CARGAR_TABLA(T2, comando)
                If T2.Tables(0).Rows.Count > 0 Then
                    For J = 0 To T2.Tables(0).Rows.Count - 1
                        M(I, J + 2) = T2.Tables(0).Rows(J).ItemArray(0) 'RESPUESTA
                        'If Not (IsDBNull(T2.Tables(0).Rows(J).ItemArray(1))) Then
                        '    M(I, 8) = T2.Tables(0).Rows(J).ItemArray(1) 'EXPLICACION
                        'End If
                    Next

                End If

                T2.Tables.Clear()
                comando = "SELECT TEXTO_OPCION FROM OPCION WHERE ID_PREGUNTA = " & ds.Tables(0).Rows(I).ItemArray(0) & " AND ESCORRECTA = '" & "VERDADERO" & "'"
                CARGAR_TABLA(T2, comando)
                If T2.Tables(0).Rows.Count > 0 Then
                    M(I, 6) = T2.Tables(0).Rows(0).ItemArray(0) 'RESPUESTA CORRECTA
                End If
            Next

            IniciarTiempoLimite(M(0, 8))

            CargarPregunta(0)
        End If
    End Sub


    Friend Sub SIGUIENTE()
        TiempoPregunta.Stop()

        FILA_ACTUAL += 1
        If M(FILA_ACTUAL, 0) <> "" Then

            IniciarTiempoLimite(M(FILA_ACTUAL, 8))
            CargarPregunta(FILA_ACTUAL)
            TiempoPregunta.Start()
        Else
            MsgBox("Su juego ha concluido.", vbInformation + vbOKOnly, "Fin del juego")
            Me.Hide()
            FrmResultados.ShowDialog()
        End If
    End Sub



    Friend Sub REVISAR(ByVal RESPUESTA As String)

        TiempoPregunta.Stop()
        Progreso_Barra.Value = 0

        If RESPUESTA = M(FILA_ACTUAL, 6) Then
            ' Si la respuesta es correcta
            LBLPUNTOS.Text = CInt(LBLPUNTOS.Text) + CInt(M(FILA_ACTUAL, 1))
        ElseIf RESPUESTA <> M(FILA_ACTUAL, 6) Then
            ' Si la respuesta es incorrecta, mostrar tanto la respuesta seleccionada como la correcta
            Select Case RESPUESTA
                Case BTN1.Text
                    BTN1.FillColor = Color.Red ' Cambia el color del botón seleccionado a rojo
                Case BTN2.Text
                    BTN2.FillColor = Color.Red
                Case BTN3.Text
                    BTN3.FillColor = Color.Red
                Case BTN4.Text
                    BTN4.FillColor = Color.Red
            End Select
        End If

        MarcarRespuestaCorrecta()

        Temporizador.Interval = 3000
        Temporizador.Start()

        'GUARDAR(RESPUESTA)
    End Sub

    Private Sub MarcarRespuestaCorrecta()
        ' Buscar la opción correcta y marcarla
        Select Case M(FILA_ACTUAL, 6)
            Case BTN1.Text
                BTN1.FillColor = Color.Green
            Case BTN2.Text
                BTN2.FillColor = Color.Green
            Case BTN3.Text
                BTN3.FillColor = Color.Green
            Case BTN4.Text
                BTN4.FillColor = Color.Green
        End Select
    End Sub

    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        REVISAR(BTN1.Text)
    End Sub


    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN3.Click
        REVISAR(BTN3.Text)
    End Sub


    Private Sub BTN3_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        REVISAR(BTN2.Text)
    End Sub


    Private Sub BTN4_Click(sender As Object, e As EventArgs) Handles BTN4.Click
        REVISAR(BTN4.Text)
    End Sub

    Private Sub Temporizador_Tick(sender As Object, e As EventArgs) Handles Temporizador.Tick
        BTN1.FillColor = Color.MediumSlateBlue
        BTN2.FillColor = Color.MediumSlateBlue
        BTN3.FillColor = Color.MediumSlateBlue
        BTN4.FillColor = Color.MediumSlateBlue

        Temporizador.Stop() ' Detener el temporizador
        SIGUIENTE()
    End Sub

    Private Sub TiempoPregunta_Tick(sender As Object, e As EventArgs) Handles TiempoPregunta.Tick
        If Progreso_Barra.Value <= Progreso_Barra.Maximum And Progreso_Barra.Value <> 0 Then
            Progreso_Barra.Value -= 1
        Else
            REVISAR("")
        End If
    End Sub

    Private Sub IniciarTiempoLimite(tiempoLimite As Integer)
        Progreso_Barra.Maximum = tiempoLimite
        Progreso_Barra.Value = tiempoLimite
        TiempoPregunta.Enabled = True
        TiempoPregunta.Interval = 1000
        TiempoPregunta.Start()
    End Sub


    Private Sub CargarPregunta(indicePregunta As Integer)
        Progreso_Barra.Value = Progreso_Barra.Maximum
        LBLPREGUNTA.Text = M(indicePregunta, 0)
        LBLPREGUNTA.Tag = M(indicePregunta, 7)
        Dim OPCIONES() As String = {M(indicePregunta, 2), M(indicePregunta, 3), M(indicePregunta, 4), M(indicePregunta, 5)}
        Dim rnd As New Random()
        Dim opcionesmezclados = OPCIONES.OrderBy(Function(r) rnd.Next()).ToArray()
        BTN1.Text = opcionesmezclados(0)
        BTN3.Text = opcionesmezclados(1)
        BTN2.Text = opcionesmezclados(2)
        BTN4.Text = opcionesmezclados(3)
    End Sub
End Class