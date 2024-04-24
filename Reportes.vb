Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO
Imports TheArtOfDevHtmlRenderer.Adapters.Entities



Module REPORTE
    Public OWORD As New Word.Application()
    Public DOCUMENTO As New Word.Document
    Public DIRECTORIO As String
    Public OTABLA As Word.Table

    Public REPORTE_DIRECCION_PDF As String = ""
    Public REPORTE_DIRECCION_WORD As String = ""
    Public P0, P1, P2, P3, P4, P5, P6, P7, P8, P9, P10 As Word.Paragraph
    Public T1, TB2 As Word.Paragraph
    Public M(100, 100) As String

    Friend Sub INSERTAR_REGLON(ByVal ES_EL_PRIMER_PARRAFO As Boolean, ByRef PARRAFO As Word.Paragraph, ByVal TEXTO As String, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal TAMANO As Byte, ByVal NOMBRE_FUENTE As String, ByVal ALINEACION As Char, ByVal ESPACIADO_ANTERIOR As Byte)
        If ES_EL_PRIMER_PARRAFO = True Then
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add
        Else
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add(DOCUMENTO.Bookmarks.Item("\endofdoc").Range)
        End If
        PARRAFO.Range.Text = TEXTO

        If NEGRITA = True Then
            PARRAFO.Range.Font.Bold = True
        Else
            PARRAFO.Range.Font.Bold = False
        End If
        If CURSIVA = True Then
            PARRAFO.Range.Font.Italic = True
        Else
            PARRAFO.Range.Font.Italic = False
        End If
        PARRAFO.Range.Font.Size = TAMANO
        PARRAFO.Range.Font.Name = NOMBRE_FUENTE

        Select Case ALINEACION
            Case "I" 'IZQUIERDA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
            Case "D" 'DERECHA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
            Case "J" 'JUSTIFICADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
            Case "C" 'CENTRADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        End Select
        PARRAFO.Format.SpaceAfter = ESPACIADO_ANTERIOR
        PARRAFO.Range.InsertParagraphAfter()
    End Sub

    Friend Sub INSERTAR_LINEA_BLANCO(ByRef PARRAFO_ANTERIOR As Word.Paragraph, ByVal CANTIDAD_LINEAS_EN_BLANCO As Byte)
        Dim I As Byte
        For I = 1 To CANTIDAD_LINEAS_EN_BLANCO
            PARRAFO_ANTERIOR.Range.InsertParagraphBefore()
        Next
    End Sub

    Friend Sub INSERTAR_TABLA(ByVal VECTOR(,) As String, ByVal FILAS As Byte, ByVal COLUMNAS As Byte, ByVal ESPACIADO_ANTERIOR As Byte, ByVal TAMANO As Byte, ByVal FUENTE As String, ByVal ANCHO_CELDA As Byte, ByVal ALTO_CELDA As Byte, ByVal ALINEACION As Char, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal INDICE_COLUMNA_NEGRITA As Byte, ByVal REQUIERE_COLUMNA_NEGRITA As Boolean, ByVal INDICE_COLUMNA_CURSIVA As Byte, ByVal REQUIERE_COLUMNA_CURSIVA As Boolean, ByRef PARRAFO As Word.Paragraph, ByVal INDICE_COLUMNA_CENTRAR As Byte, ByVal REQUIERE_COLUMNA_CENTRAR As Boolean, ByVal VALOR_ALTERADO As Boolean)
        Dim FILA As Byte, COLUMNA As Byte
        OTABLA = DOCUMENTO.Tables.Add(DOCUMENTO.Bookmarks.Item("\endofdoc").Range, FILAS, COLUMNAS)
        OTABLA.Range.ParagraphFormat.SpaceAfter = ESPACIADO_ANTERIOR


        For FILA = 1 To FILAS
            For COLUMNA = 1 To COLUMNAS
                OTABLA.Cell(FILA, COLUMNA).Range.Text = VECTOR(FILA - 1, COLUMNA - 1)
                Select Case ALINEACION
                    Case "I" 'IZQUIERDA
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    Case "D" 'DERECHA
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    Case "J" 'JUSTIFICADO
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
                    Case "C" 'CENTRADO
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                End Select


                OTABLA.Cell(FILA, COLUMNA).Range.Font.Size = TAMANO
                OTABLA.Cell(FILA, COLUMNA).Range.Font.Name = FUENTE
                If NEGRITA = True Then
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = True
                Else
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = False
                End If
                If CURSIVA = True Then
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = True
                Else
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = False
                End If

                If REQUIERE_COLUMNA_NEGRITA = True Then
                    If COLUMNA = INDICE_COLUMNA_NEGRITA And VALOR_ALTERADO = True Then
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = True
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Color = WdColor.wdColorRed
                    Else
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = False
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Color = WdColor.wdColorBlack
                    End If
                End If


                If REQUIERE_COLUMNA_CURSIVA = True Then
                    If COLUMNA = INDICE_COLUMNA_CURSIVA Then
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = True
                    Else
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = False
                    End If
                End If
                If REQUIERE_COLUMNA_CENTRAR = True Then
                    If COLUMNA = INDICE_COLUMNA_CENTRAR Then
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    End If
                End If
            Next
        Next

        OTABLA.Borders.OutsideColor = WdColor.wdColorWhite
        PARRAFO = DOCUMENTO.Content.Paragraphs.Add(DOCUMENTO.Bookmarks.Item("\endofdoc").Range)
    End Sub

    Friend Sub CREAR_DIRECTORIO(ByVal CARPETA As String)
        DIRECTORIO = "C:\" & CARPETA
        Directory.CreateDirectory(DIRECTORIO)
    End Sub


    Friend Sub GUARDAR_DOCUMENTO_PDF2(ByVal NOMBRE_DOCUMENTO As String, ByVal VER_REPORTE As Boolean)
        Dim DIRECCION As String = DIRECTORIO & "\" & NOMBRE_DOCUMENTO
        DOCUMENTO.SaveAs2(DIRECCION & ".DOCX")
        REPORTE_DIRECCION_WORD = DIRECCION & ".DOCX"
        DOCUMENTO.ExportAsFixedFormat(DIRECCION, WdExportFormat.wdExportFormatPDF, VER_REPORTE)
        REPORTE_DIRECCION_PDF = DIRECCION & ".pdf"
        If MsgBox("¿Desea guardar el documento?", vbQuestion + vbYesNo, "Guardar") = vbYes Then
            ' Mostrar el cuadro de diálogo Guardar como
            DOCUMENTO.SaveAs2(FileName:=DIRECCION & ".pdf", FileFormat:=WdSaveFormat.wdFormatPDF)
            MsgBox("Documento guardado exitosamente, en la ruta c:\Reportes", vbInformation, "Guardado")
        End If
    End Sub

    Friend Sub GUARDAR_DOCUMENTO_PDF(ByVal NOMBRE_DOCUMENTO As String, ByVal VER_REPORTE As Boolean)
        Dim DIRECCION As String
        Dim NOMBRE_ARCHIVO As String
        Dim FECHA_ACTUAL As String

        ' Obtener la fecha y hora actual en formato "yyyyMMdd_HHmmss"
        FECHA_ACTUAL = Format(Now, "dd-MM-yyyy-hh-mm-ss")

        ' Construir el nombre de archivo con la fecha y hora actual
        NOMBRE_ARCHIVO = NOMBRE_DOCUMENTO & "_" & FECHA_ACTUAL

        ' Construir la dirección completa con el nombre de archivo y la ruta
        DIRECCION = DIRECTORIO & "\" & NOMBRE_ARCHIVO

        DOCUMENTO.SaveAs2(DIRECCION & ".DOCX")
        REPORTE_DIRECCION_WORD = DIRECCION & ".DOCX"
        DOCUMENTO.ExportAsFixedFormat(DIRECCION, WdExportFormat.wdExportFormatPDF, VER_REPORTE)
        REPORTE_DIRECCION_PDF = DIRECCION & ".pdf"

        If MsgBox("¿Desea guardar el documento?", vbQuestion + vbYesNo, "Guardar") = vbYes Then
            ' Guardar el documento con el nombre modificado
            DOCUMENTO.SaveAs2(FileName:=DIRECCION & ".pdf", FileFormat:=WdSaveFormat.wdFormatPDF)
            MsgBox("Documento guardado exitosamente en la ruta: " & DIRECCION, vbInformation, "Guardado")
        End If
    End Sub


    Friend Sub CERRAR_DOCUMENTO_WORD()
        If DOCUMENTO IsNot Nothing Then
            DOCUMENTO.Close()
            DOCUMENTO = Nothing
        End If

        If OWORD IsNot Nothing Then
            OWORD.Application.Quit()
            OWORD = Nothing
        End If
    End Sub





End Module


