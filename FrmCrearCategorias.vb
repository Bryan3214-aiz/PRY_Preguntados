Imports System.IO
Public Class FrmCrearCategorias
    Private Sub BTNimgEstaticaCategoria_Click(sender As Object, e As EventArgs) Handles BTNimgEstaticaCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar la imagen: " & ex.Message)
        End Try
    End Sub
    Private Sub MostrarImagen(imagenBytes As Byte())
        Try
            Dim tempFilePath As String = Path.GetTempFileName()
            tempFilePath = Path.ChangeExtension(tempFilePath, ".jpg")
            File.WriteAllBytes(tempFilePath, imagenBytes)

            BTNimgEstaticaCategoria.Image = Image.FromFile(tempFilePath)
        Catch ex As Exception
            Console.WriteLine("Error al mostrar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNimgAnimadaCategoria_Click(sender As Object, e As EventArgs) Handles BTNimgAnimadaCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.gif*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar el gift: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNSonidoCategoria_Click(sender As Object, e As EventArgs) Handles BTNSonidoCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp3*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar el audio: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNAudioVozCategoria_Click(sender As Object, e As EventArgs) Handles BTNAudioVozCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp3*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar el audio: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNvideoCategoria_Click(sender As Object, e As EventArgs) Handles BTNvideoCategoria.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.mp4*|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                MostrarImagen(imagenBytes)
            End If
        Catch ex As Exception
            Console.WriteLine("Error al insertar el audio: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNcrearCategoria_Click(sender As Object, e As EventArgs) Handles BTNcrearCategoria.Click

    End Sub
End Class