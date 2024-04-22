Imports System.IO
Public Class FrmActualizarPerfilProfesor
    Dim ID As Integer = 0
    Private fotoCambiada As Boolean = False
    Private Sub FrmActualizarPerfilProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        INICIALIZAR()
    End Sub

    Friend Sub INICIALIZAR()
        comando = "SELECT ID_PROFESOR, NOMBRE_COMPLETO, CORREO_ELECTRONICO, IDENTIFICACION,CONTRASENA, PATRON FROM PROFESOR"
        BUSCAR(comando)
        reiniciar()
        ID = 0
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
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(3))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(4))
                L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(5))
            Next
        End If
    End Sub


    Friend Sub reiniciar()
        BTNguardarCambios.Enabled = False
        BTNeditarInfo.Enabled = False
        TXTnombre.Enabled = False
        TXTcontrasena.Enabled = False
        TXTcorreo.Enabled = False
        TXTidentifacion.Enabled = False
        TXTpatron.Enabled = False
        BTNfotoSeleccionar.Enabled = False
        BTNfotoSeleccionar.Image = My.Resources.img_usuario
        TXTnombre.Text = ""
        TXTcorreo.Text = ""
        TXTidentifacion.Text = ""
        TXTcontrasena.Text = ""
        TXTpatron.Text = ""
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToInt32(L.SelectedItems(0).Text)
            BTNeditarInfo.Enabled = True
        End If
    End Sub

    Private Sub BTNeditarInfo_Click(sender As Object, e As EventArgs) Handles BTNeditarInfo.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Desea actualizar su información personal?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            BTNguardarCambios.Enabled = True
            TXTnombre.Enabled = True
            TXTcontrasena.Enabled = True
            TXTcorreo.Enabled = True
            TXTpatron.Enabled = True
            TXTidentifacion.Enabled = True
            BTNfotoSeleccionar.Enabled = True

            If ID <> 0 Then
                comando = "SELECT ID_PROFESOR, NOMBRE_COMPLETO, CORREO_ELECTRONICO, IDENTIFICACION,CONTRASENA, PATRON,FOTOGRAFIA FROM PROFESOR where ID_PROFESOR = " & ID & ""
                ds.Tables.Clear()
                L.Items.Clear()
                CARGAR_TABLA(ds, comando)
                If ds.Tables(0).Rows.Count > 0 Then
                    For I = 0 To ds.Tables(0).Rows.Count - 1
                        L.Items.Add(ds.Tables(0).Rows(I).Item(0))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(1))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(2))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(3))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(4))
                        L.Items(L.Items.Count - 1).SubItems.Add(ds.Tables(0).Rows(I).Item(5))

                        Dim fotoBytes As Byte() = CType(ds.Tables(0).Rows(I).Item(6), Byte())
                        If fotoBytes IsNot Nothing Then
                            Using ms As New MemoryStream(fotoBytes)
                                Dim imagen As Image = Image.FromStream(ms)
                                BTNfotoSeleccionar.Image = imagen
                            End Using
                        End If
                    Next
                End If
                TXTnombre.Text = L.Items(L.Items.Count - 1).SubItems(1).Text
                TXTcorreo.Text = L.Items(L.Items.Count - 1).SubItems(2).Text
                TXTidentifacion.Text = L.Items(L.Items.Count - 1).SubItems(3).Text
                TXTcontrasena.Text = L.Items(L.Items.Count - 1).SubItems(4).Text
                TXTpatron.Text = L.Items(L.Items.Count - 1).SubItems(5).Text
            End If
        End If
    End Sub

    Private Sub BTNfotoSeleccionar_Click(sender As Object, e As EventArgs) Handles BTNfotoSeleccionar.Click
        Try
            OpenFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif|Todos los archivos|*.*"

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim rutaImagen As String = OpenFileDialog1.FileName
                Dim imagenBytes As Byte() = File.ReadAllBytes(rutaImagen)
                fotoCambiada = True
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

            BTNfotoSeleccionar.Image = Image.FromFile(tempFilePath)
        Catch ex As Exception
            Console.WriteLine("Error al mostrar la imagen: " & ex.Message)
        End Try
    End Sub
    Private Function ObtenerBytesDeImagen(ByVal imagen As Image) As Byte()
        Using ms As New MemoryStream()
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub BTNguardarCambios_Click(sender As Object, e As EventArgs) Handles BTNguardarCambios.Click
        Try
            If String.IsNullOrWhiteSpace(TXTidentifacion.Text) OrElse
                String.IsNullOrWhiteSpace(TXTnombre.Text) OrElse
                String.IsNullOrWhiteSpace(TXTcorreo.Text) OrElse
                String.IsNullOrWhiteSpace(TXTpatron.Text) OrElse
                String.IsNullOrWhiteSpace(TXTcontrasena.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            If fotoCambiada = True Then ' Verifica si se ha cambiado la foto
                Dim imagenBytes As Byte() = ObtenerBytesDeImagen(BTNfotoSeleccionar.Image)
                comando = "UPDATE PROFESOR SET nombre_completo = '" & TXTnombre.Text & "', identificacion = '" & TXTidentifacion.Text & "', correo_electronico = '" & TXTcorreo.Text & "', contrasena = '" & TXTcontrasena.Text & "', PATRON = '" & TXTpatron.Text & "', fotografia = ? WHERE ID_profesor = " & ID & ""
                EJECUTAR(comando, imagenBytes)
                MsgBox("Datos actualizados con foto nueva.", vbOKOnly, "")
            Else
                comando = "UPDATE PROFESOR SET nombre_completo = '" & TXTnombre.Text & "', identificacion = '" & TXTidentifacion.Text & "', correo_electronico = '" & TXTcorreo.Text & "', contrasena = '" & TXTcontrasena.Text & "', PATRON = '" & TXTpatron.Text & "' WHERE ID_profesor = " & ID & ""
                EJECUTARSI(comando)
                MsgBox("Datos actualizados sin foto.", vbOKOnly, "")
            End If
            INICIALIZAR()

        Catch ex As Exception
            Console.WriteLine("Error de actualización: " & ex.Message)
            MessageBox.Show("Ocurrió un error al ingresar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class