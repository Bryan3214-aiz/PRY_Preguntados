﻿Imports System.Net
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Core
Imports System.Reflection
Imports Microsoft.Win32

Module Correo




    Public CLAVE As String = "" 'clave del correo de origen
    Public CORREOUSUARIO As String 'direccion del correo de destino
    Public CORREOORIGEN As String = "" 'direccion del correo de origen

    Friend Sub ENVIAR_CORREO_OUTLOOK_ADJUNTO(ByVal ASUNTO As String, ByVal CUERPO As String, ByVal CDESTINO As String, ByVal ADJUNTO As String, ByVal CORIGEN As String)

        Try
            Dim POSICION As Integer = 0
            Dim DESTINO As New SmtpClient("smtp.office365.com")

            DESTINO.Port = 587
            DESTINO.EnableSsl = True
            DESTINO.UseDefaultCredentials = False
            DESTINO.Credentials = New NetworkCredential(CORIGEN, CLAVE)
            Dim cuerpoHTML As String = CUERPO
            Dim CUERPO_CORREO As String
            CUERPO_CORREO = CUERPO

            Dim emisor As New MailMessage
            emisor.To.Clear()
            emisor.From = New MailAddress(CORIGEN)
            emisor.To.Add(CDESTINO)
            emisor.Subject = ASUNTO
            emisor.Body = CUERPO_CORREO

            Dim ARCHIVO_ADJUNTO As New System.Net.Mail.Attachment(ADJUNTO)

            emisor.Attachments.Add(ARCHIVO_ADJUNTO)
            emisor.Priority = MailPriority.High
            emisor.IsBodyHtml = False
            DESTINO.Send(emisor)

            ' Mensaje de éxito
            MsgBox("El correo se ha enviado correctamente.", vbInformation + vbOKOnly, "Envío exitoso")

        Catch ex As Exception
            MsgBox("Ha ocurrido el siguiente inconveniente: " & vbNewLine + vbNewLine & ex.Message, vbCritical + vbOKOnly, "Problemas en el envío")

            ' Mensaje de error
            MsgBox("El correo electrónico no pudo ser enviado", vbExclamation + vbOKOnly, "Envío fallido")
        End Try
    End Sub

End Module

