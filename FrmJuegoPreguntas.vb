Imports System.Data.OleDb
Imports System.Globalization
Imports System.IO
Imports WMPLib

Public Class FrmJuegoPreguntas
    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0

    Dim M(100, 8) As String
    Dim FILA_ACTUAL As Integer = 0
    Dim PTOTAL As Integer = 0
    Dim CODIGOJUEGO As Integer = 0
    Dim tiempo_limite As Integer = 0
    Dim Respuestas_Correctas As Integer = 0
    Dim Respuestas_Incorrectas As Integer = 0

    Private Sub FrmJuegoPreguntas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        TemporizadoTransicion.Interval = 20
        TemporizadoTransicion.Start()
        MostrarSonido()
        MostrarVideo()
        REFRESCAR_PREGUNTAS()
        Me.BeginInvoke(Sub() BTN1.Focus())
    End Sub

    Friend Function ObtenerVideo() As Byte()

        Dim videoBytes As Byte() = Nothing
        Try
            CONECTAR()
            Dim ID_CATEGORIA As Integer = FrmMenuPartidaEstudiante.ID_CAT
            Dim query As String = "SELECT VIDEO_CATEGORIA FROM CATEGORIA WHERE ID_CATEGORIA = " & ID_CATEGORIA & ""
            Using cmd As New OleDbCommand(query, miconexion)
                Dim result As Object = cmd.ExecuteScalar()

                If result IsNot Nothing AndAlso Not IsDBNull(result) Then

                    videoBytes = DirectCast(result, Byte())

                End If

            End Using

            Console.WriteLine("Video recuperado exitosamente de la base de datos.")
        Catch ex As Exception
            Console.WriteLine("Error al recuperar el video de la base de datos: " & ex.Message)
        Finally
            DESCONECTAR()
        End Try

        Return videoBytes
    End Function

    Private Sub MostrarVideo()
        Dim videoBytes As Byte() = ObtenerVideo()

        If videoBytes IsNot Nothing AndAlso videoBytes.Length > 0 Then
            Try
                Dim tempFilePath As String = Path.GetTempFileName()
                tempFilePath = Path.ChangeExtension(tempFilePath, ".mp4")
                File.WriteAllBytes(tempFilePath, videoBytes)
                MediaPlayer.URL = tempFilePath
                MediaPlayer.settings.setMode("loop", True)
                MediaPlayer.uiMode = "none" ' Ocultar la interfaz de usuario
                MediaPlayer.settings.volume = 0
                MediaPlayer.Ctlcontrols.play()

            Catch ex As Exception
                Console.WriteLine("Error al mostrar el video: " & ex.Message)
            End Try
        Else
            Console.WriteLine("No se encontró el video en la base de datos.")
        End If
    End Sub
    Private Sub DetenerVideo()
        MediaPlayer.Ctlcontrols.stop()
    End Sub

    Friend Function ObtenerSonido() As Byte()
        Dim sonidoBytes As Byte() = Nothing
        Try
            CONECTAR()
            Dim ID_CATEGORIA As Integer = FrmMenuPartidaEstudiante.ID_CAT
            Dim query As String = "SELECT SONIDO_CATEGORIA FROM CATEGORIA WHERE ID_CATEGORIA = " & ID_CATEGORIA & ""
            Using cmd As New OleDbCommand(query, miconexion)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    sonidoBytes = DirectCast(result, Byte())
                End If
            End Using
        Catch ex As Exception
        Finally
            DESCONECTAR()
        End Try
        Return sonidoBytes
    End Function

    Friend Sub MostrarSonido()
        Dim sonidoBytes As Byte() = ObtenerSonido()
        If sonidoBytes IsNot Nothing AndAlso sonidoBytes.Length > 0 Then
            Try
                Dim tempFilePath As String = Path.GetTempFileName()
                tempFilePath = Path.ChangeExtension(tempFilePath, ".mp3")
                File.WriteAllBytes(tempFilePath, sonidoBytes)

                wmp.URL = tempFilePath
                wmp.controls.play()
            Catch ex As Exception
            End Try
        Else
        End If
    End Sub


    Friend Sub REFRESCAR_PREGUNTAS()

        Dim T2 As New DataSet
        Dim ID_CATEGORIA As Integer = FrmMenuPartidaEstudiante.CMBseleccionarFRM.SelectedItem

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
            sonidoTransicion()
            IniciarTiempoLimite(M(FILA_ACTUAL, 8))
            CargarPregunta(FILA_ACTUAL)
            TiempoPregunta.Start()
        Else
            wmp.controls.stop()
            MsgBox("Su juego ha concluido.", vbInformation + vbOKOnly, "Fin del juego")
            Me.Hide()
            FrmResultados.ShowDialog()
            Me.Close()
        End If
    End Sub


    Friend Sub REVISAR(ByVal RESPUESTA As String)

        TiempoPregunta.Stop()
        Progreso_Barra.Value = 0

        If RESPUESTA = M(FILA_ACTUAL, 6) Then
            sonidoCorrecta()
            LBLPUNTOS.Text = CInt(LBLPUNTOS.Text) + CInt(M(FILA_ACTUAL, 1))
            Respuestas_Correctas = Respuestas_Correctas + 1
        ElseIf RESPUESTA <> M(FILA_ACTUAL, 6) Then
            sonidoIncorrecta()
            Respuestas_Incorrectas = Respuestas_Incorrectas + 1

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

        Temporizador.Interval = 1000
        Temporizador.Start()

        GUARDAR(RESPUESTA)
    End Sub

    Friend Sub GUARDAR(ByVal RESPUESTA As String)
        Dim ID_CATEGORIA As Integer = FrmMenuPartidaEstudiante.CMBseleccionarFRM.SelectedIndex + 1
        Dim ID_USUARIO As Integer = FrmLoginEstudiante.ID_estudiante
        Dim Tiempo As Integer = 1000
        Dim Fecha_Hora As DateTime = DateTime.Now
        Dim Fecha_HoraStr As String = Fecha_Hora.ToString("yyyy-MM-dd HH:mm:ss")
        ds.Tables.Clear()
        comando = "SELECT PUNTAJE FROM PARTIDA WHERE ID_CATEGORIA = " & ID_CATEGORIA & " AND ID_USUARIO = " & ID_USUARIO & ""
        CARGAR_TABLA(ds, comando)
        If ds.Tables(0).Rows.Count = 0 Then
            CODIGOJUEGO = PK("PARTIDA", "ID_PARTIDA")
            comando = "INSERT INTO PARTIDA (ID_PARTIDA, ID_USUARIO, ID_CATEGORIA, PUNTAJE, TIEMPO_TOTAL, RESPUESTAS_CORRECTAS, RESPUESTAS_INCORRECTAS, FECHA_PARTIDA) VALUES(" & CODIGOJUEGO & ", " & ID_USUARIO & ", " & ID_CATEGORIA & ", " & LBLPUNTOS.Text & ", " & Tiempo & ", " & Respuestas_Correctas & ", " & Respuestas_Incorrectas & ", '" & Fecha_HoraStr & "')"
        Else
            comando = "UPDATE PARTIDA SET PUNTAJE = " & LBLPUNTOS.Text & " ,RESPUESTAS_INCORRECTAS = " & Respuestas_Incorrectas & ", RESPUESTAS_CORRECTAS = " & Respuestas_Correctas & " WHERE ID_CATEGORIA = " & ID_CATEGORIA & " AND ID_USUARIO = " & ID_USUARIO & ""
        End If
        EJECUTARSI(comando)
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

    Private Sub sonidoTransicion()

        Try
            ' Reproducir el efecto de sonido de forma independiente
            My.Computer.Audio.Play(My.Resources.sonidoTransición, AudioPlayMode.Background)
        Catch ex As Exception
            Console.WriteLine("Error al reproducir el efecto de sonido: " & ex.Message)
        End Try

    End Sub
    Private Sub sonidoPresionar()
        Try
            ' Reproducir el efecto de sonido de forma independiente
            My.Computer.Audio.Play(My.Resources.OpcionSeleccionada, AudioPlayMode.Background)
        Catch ex As Exception
            Console.WriteLine("Error al reproducir el efecto de sonido: " & ex.Message)
        End Try

    End Sub

    Private Sub sonidoCorrecta()

        Try
            ' Reproducir el efecto de sonido de forma independiente
            My.Computer.Audio.Play(My.Resources.correcto, AudioPlayMode.Background)
        Catch ex As Exception
            Console.WriteLine("Error al reproducir el efecto de sonido: " & ex.Message)
        End Try

    End Sub

    Private Sub sonidoIncorrecta()
        Try
            ' Reproducir el efecto de sonido de forma independiente
            My.Computer.Audio.Play(My.Resources.PreguntaIncorrecta, AudioPlayMode.Background)
        Catch ex As Exception
            Console.WriteLine("Error al reproducir el efecto de sonido: " & ex.Message)
        End Try
    End Sub

    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        sonidoPresionar()
        REVISAR(BTN1.Text)
    End Sub


    Private Sub BTN3_Click(sender As Object, e As EventArgs) Handles BTN3.Click
        sonidoPresionar()
        REVISAR(BTN3.Text)
    End Sub


    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        sonidoPresionar()
        REVISAR(BTN2.Text)
    End Sub


    Private Sub BTN4_Click(sender As Object, e As EventArgs) Handles BTN4.Click
        sonidoPresionar()
        REVISAR(BTN4.Text)
    End Sub

    Private Sub Temporizador_Tick(sender As Object, e As EventArgs) Handles Temporizador.Tick

        ResetButtonColors()

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


    Private Sub Modulo_Teclas(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                Select Case Me.ActiveControl.Name
                    Case "BTN2"
                        BTN2.Focus()
                    Case "BTN3"
                        BTN3.Focus()
                    Case "BTN4"
                        BTN4.Focus()
                End Select
            Case Keys.Right
                Select Case Me.ActiveControl.Name
                    Case "BTN1"
                        BTN1.Focus()
                    Case "BTN2"
                        BTN2.Focus()
                    Case "BTN3"
                        BTN3.Focus()
                End Select
            Case Keys.Space
                DirectCast(Me.ActiveControl, Button).PerformClick()
        End Select

    End Sub

    Private Sub ResetButtonColors()
        BTN1.FillColor = Color.MediumSlateBlue
        BTN2.FillColor = Color.MediumSlateBlue
        BTN3.FillColor = Color.MediumSlateBlue
        BTN4.FillColor = Color.MediumSlateBlue
    End Sub

    Private Sub BTN1_GotFocus(sender As Object, e As EventArgs) Handles BTN1.GotFocus
        ResetButtonColors()
        BTN1.FillColor = Color.Gold
    End Sub

    Private Sub BTN2_GotFocus(sender As Object, e As EventArgs) Handles BTN2.GotFocus
        ResetButtonColors()
        BTN2.FillColor = Color.Gold
    End Sub

    Private Sub BTN3_GotFocus(sender As Object, e As EventArgs) Handles BTN3.GotFocus
        ResetButtonColors()
        BTN3.FillColor = Color.Gold
    End Sub

    Private Sub BTN4_GotFocus(sender As Object, e As EventArgs) Handles BTN4.GotFocus
        ResetButtonColors()
        BTN4.FillColor = Color.Gold
    End Sub

    Private Sub TemporizadoTR_Tick(sender As Object, e As EventArgs) Handles TemporizadoTransicion.Tick
        tiempoTranscurrido += TemporizadoTransicion.Interval / 1000

        Me.Opacity = Math.Min(tiempoTranscurrido / duracionTransicion, 1)

        If tiempoTranscurrido >= duracionTransicion Then
            TemporizadoTransicion.Stop()
        End If
    End Sub
End Class





