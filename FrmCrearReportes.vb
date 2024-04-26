Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports Microsoft.VisualBasic.Logging

Public Class FrmCrearReportes
    Dim ID As String
    Dim IDUsuario, IDCategoria, nombre, categoria, puntaje, RespuestasCorrectas, RepuestasIncorrectas, Fecha As String
    Dim Identificacion, asignatura, nivel, seccion, periodo, correoElectronico, tiempo As String
    Dim Opcion1 As Boolean = False
    Dim Opcion2 As Boolean = False

    Private Sub BTNactualizar_Click(sender As Object, e As EventArgs) Handles BTN_Actualizar.Click
        INICIALIZAR2()
        TXT_BUSCAR.Clear()
    End Sub

    Private Sub FrmCrearReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR2()
        BTN_Actividad_con_Respuestas.Enabled = True
    End Sub

    Friend Sub INICIALIZAR2()
        comando = "SELECT partida.ID_Partida, partida.ID_Usuario, (SELECT TOP 1 Nombre_Completo FROM estudiante WHERE ID_Usuario = partida.ID_Usuario) AS Nombre_Estudiante, (SELECT TOP 1 Nombre_Categoria FROM categoria WHERE ID_Categoria = partida.ID_Categoria) AS Nombre_Categoria, partida.ID_Categoria, partida.Puntaje, partida.Respuestas_Correctas, partida.Respuestas_Incorrectas, partida.Fecha_Partida, partida.Tiempo_Total FROM partida"
        BUSCAR(comando)
        ID = 0
    End Sub



    Friend Sub BUSCAR(ByVal SQL As String)
        ds.Tables.Clear()
        L.Items.Clear()
        CARGAR_TABLA(ds, SQL)
        If ds.Tables(0).Rows.Count > 0 Then
            For I = 0 To ds.Tables(0).Rows.Count - 1
                L.Items.Add(ds.Tables(0).Rows(I).Item(1))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2)) 'Nombre
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(3)) 'Categoria
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(5)) 'Puntaje
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(6)) 'Correctas
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(7)) 'Incorrectas
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(8))  'Fecha
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(4))  'IDcategoria
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(9))  'Tiempo

            Next
        End If
    End Sub


    Private Sub TXT_BUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCAR.TextChanged
        comando = "SELECT partida.ID_Partida, partida.ID_Usuario, (SELECT TOP 1 Nombre_Completo FROM estudiante WHERE ID_Usuario = partida.ID_Usuario) AS Nombre_Estudiante, (SELECT TOP 1 Nombre_Categoria FROM categoria WHERE ID_Categoria = partida.ID_Categoria) AS Nombre_Categoria, partida.ID_Categoria, partida.Puntaje, partida.Respuestas_Correctas, partida.Respuestas_Incorrectas, partida.Fecha_Partida,partida.Tiempo_Total FROM partida WHERE (SELECT TOP 1 Nombre_Completo FROM estudiante WHERE ID_Usuario = partida.ID_Usuario) LIKE '%' + '" & TXT_BUSCAR.Text & "' + '%'"
        BUSCAR(comando)
    End Sub


    Private Sub GenerarReporteActividadCalificadaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ID <> 0 Then
            If MsgBox("¿Deseas generar el informe 'Activada Calificada'?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                Opcion2 = True
                IMPRIMIR()
                If MsgBox("¿Deseas enviar la información al correo del estudiante?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    enviarCorreo()
                    CERRAR_DOCUMENTO_WORD()
                Else
                    CERRAR_DOCUMENTO_WORD()
                End If
            End If
        End If

    End Sub


    Friend Sub MayorNota()
        comando = "SELECT partida.ID_Partida, partida.ID_Usuario, (SELECT TOP 1 Nombre_Completo FROM estudiante WHERE ID_Usuario = partida.ID_Usuario) AS Nombre_Estudiante, (SELECT TOP 1 Nombre_Categoria FROM categoria WHERE ID_Categoria = partida.ID_Categoria) AS Nombre_Categoria, partida.ID_Categoria, partida.Puntaje, partida.Respuestas_Correctas, partida.Respuestas_Incorrectas, partida.Fecha_Partida FROM partida WHERE partida.Puntaje = (SELECT MAX(Puntaje) FROM partida)"
        BUSCAR(comando)

    End Sub


    Friend Sub MenorNota()
        comando = "SELECT partida.ID_Partida, partida.ID_Usuario, (SELECT TOP 1 Nombre_Completo FROM estudiante WHERE ID_Usuario = partida.ID_Usuario) AS Nombre_Estudiante, (SELECT TOP 1 Nombre_Categoria FROM categoria WHERE ID_Categoria = partida.ID_Categoria) AS Nombre_Categoria, partida.ID_Categoria, partida.Puntaje, partida.Respuestas_Correctas, partida.Respuestas_Incorrectas, partida.Fecha_Partida FROM partida WHERE partida.Puntaje = (SELECT MIN(Puntaje) FROM partida)"
        BUSCAR(comando)
    End Sub


    Private Sub BTN_Puntacion_Alta_Click(sender As Object, e As EventArgs) Handles BTN_Puntacion_Alta.Click

        MayorNota()

    End Sub

    Private Sub BTN_MinimaCalificacion_Click(sender As Object, e As EventArgs) Handles BTN_MinimaCalificacion.Click
        MenorNota()
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = L.SelectedItems(0).SubItems(0).Text
            nombre = L.SelectedItems(0).SubItems(1).Text
            categoria = L.SelectedItems(0).SubItems(2).Text
            puntaje = L.SelectedItems(0).SubItems(3).Text
            RespuestasCorrectas = L.SelectedItems(0).SubItems(4).Text
            RepuestasIncorrectas = L.SelectedItems(0).SubItems(5).Text
            Fecha = L.SelectedItems(0).SubItems(6).Text
            IDCategoria = L.SelectedItems(0).SubItems(7).Text
            tiempo = L.SelectedItems(0).SubItems(8).Text

        End If
    End Sub




    Private Sub ActividadConRespuestasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BTN_Actividad_con_Respuestas.Click
        If ID <> 0 Then


            If MsgBox("Desea generar el informacion?", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                Opcion1 = True
                IMPRIMIR()
                If MsgBox("Desea enviar el informacion al correo del estudiante", vbQuestion + vbYesNo, "Confirmar") = vbYes Then
                    enviarCorreo()
                    CERRAR_DOCUMENTO_WORD()
                Else
                    CERRAR_DOCUMENTO_WORD()
                End If

            End If
        End If
    End Sub
    Friend Sub IMPRIMIR()
        Try
            OWORD = New Word.Application()
            OWORD.Visible = False
            DOCUMENTO = OWORD.Documents.Add

            CargarOtroDatosEstudiantes() 'Llama funcion para cargar los datos del estudiante

            ' Insertando la primera línea de texto
            INSERTAR_REGLON(True, P0, "RESULTADO DEL JUEGO PREGUNTADOS", True, False, 14, "Arial", "C", 0)
            'Insertando la segunda línea de texto
            INSERTAR_REGLON(True, P1, "", True, False, 14, "Arial", "C", 0)
            INSERTAR_REGLON(True, P2, "", True, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P4, "Datos del Estudiante", True, False, 14, "Arial", "I", 0)
            INSERTAR_REGLON(True, P5, "Nombre estudiante: " & nombre, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P6, "Identificación: " & Identificacion, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P7, "Nivel: " & nivel, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P8, "Sección: " & seccion, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P9, "Asignatura: " & asignatura, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P10, "Periodo: " & periodo, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P11, "Correo electronico: " & correoElectronico, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P12, "", True, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P4, "Estadísticas del Juego", True, False, 14, "Arial", "I", 0)
            INSERTAR_REGLON(True, P14, "Nombre categoria: " & categoria, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P15, "Puntaje obtenido: " & puntaje & " pts", False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P16, "Respuestas correctas: " & RespuestasCorrectas, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P17, "Respuestas incorrectas: " & RepuestasIncorrectas, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P18, "Tiempo total: " & tiempo & " mins", False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P19, "Fecha: " & Fecha, False, False, 12, "Arial", "I", 0)
            INSERTAR_REGLON(True, P20, "", True, False, 12, "Arial", "I", 0)

            'Empiza cargar las preguntas y respuesta correctas
            If Opcion1 = True Then
                'Almacenando los encabezados de la tabla en una matriz
                ds.Tables.Clear()

                'Consulta para cargar las preguntas y respuesta correctas
                comando = "SELECT P.Enunciado_Pregunta,
                           MAX(O.Texto_Opcion) AS Texto_Opcion
                           FROM Pregunta P
                           INNER JOIN Opcion O ON P.ID_Pregunta = O.ID_Pregunta
                           WHERE P.ID_Categoria = " & IDCategoria & "
                           AND O.EsCorrecta = true
                           GROUP BY P.Enunciado_Pregunta"


                CARGAR_TABLA(ds, comando)
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    M(0, 0) = "Pregunta # " & i + 1 & "- " & ds.Tables(0).Rows(i).ItemArray(0) 'Pregunta
                    M(1, 0) = "Respuesta correcta: " & ds.Tables(0).Rows(i).ItemArray(1) 'Respuesta correcta
                    INSERTAR_TABLA(M, 2, 2, 0, 12, "Arial", 1, 1, "I", True, True, 2, True, 1, True, T1, 0, False, False)
                Next
            End If

            ' Creando DIRECTORIO
            CREAR_DIRECTORIO("Reportes")

            'Guardando DOCUMENTO en .docx, .pdf
            GUARDAR_DOCUMENTO_PDF("Reportes", True)
        Catch ex As NullReferenceException
            MessageBox.Show("Se produjo una excepción NullReferenceException. Verifica que todos los objetos estén inicializados correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Dim correo As String

    Friend Sub enviarCorreo()
        ds.Clear()
        comando = "SELECT Nombre_Completo, Correo_Electronico FROM Estudiante WHERE ID_Usuario = " & ID & "" ' Busca el correo del estudiante con el ID del usuariario
        CARGAR_TABLA(ds, comando)
        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            correo = ds.Tables(0).Rows(0).Item("Correo_Electronico").ToString() ' Obtener el correo electrónico de la primera fila
        End If
        CLAVE = "NBSg&n-6k+%OH].){H2024"
        ENVIAR_CORREO_OUTLOOK_ADJUNTO("Resultados obtenidos", " Buenas estudiante :" & nombre & " Se adjunta documento con los resultados que se ha obtenido ", correo, REPORTE_DIRECCION_PDF, "NotificacionesPreguntados@outlook.com")

    End Sub

    Friend Sub CargarOtroDatosEstudiantes()   'Metodo para cargar los datos del estudiante
        ds.Clear()
        comando = "SELECT identificacion, Asignatura, Nivel, Seccion, Periodo, Correo_Electronico FROM Estudiante WHERE ID_Usuario =" & ID & "" ' Secuencia de SQL para seleccionar datos de estudiantes según el ID de usuario.
        CARGAR_TABLA(ds, comando)
        'Verificacion de Datos
        If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
            Dim primeraFila = ds.Tables(0).Rows(0)
            If Not primeraFila.IsNull("Identificacion") Then
                Identificacion = primeraFila("Identificacion").ToString()
            Else
                Identificacion = ""
            End If

            If Not primeraFila.IsNull("Asignatura") Then
                asignatura = primeraFila("Asignatura").ToString()
            Else
                asignatura = " "
            End If

            If Not primeraFila.IsNull("Nivel") Then
                nivel = primeraFila("Nivel").ToString()
            Else
                nivel = " "
            End If

            If Not primeraFila.IsNull("Periodo") Then
                periodo = primeraFila("Periodo").ToString()
            Else
                periodo = " "
            End If

            If Not primeraFila.IsNull("Correo_electronico") Then
                correoElectronico = primeraFila("Correo_electronico").ToString()
            Else
                correoElectronico = " "
            End If

            If Not primeraFila.IsNull("Seccion") Then
                seccion = primeraFila("Seccion").ToString()
            Else
                seccion = " "
            End If
        End If

    End Sub


End Class