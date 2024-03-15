Imports System.Data.OleDb

Public Class FrmLoginAdmin
    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(95, Color.Black)

    End Sub


    Private Sub panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles panel2.Paint
        panel2.BackColor = Color.FromArgb(60, Color.Black)
    End Sub

    Private Sub BTNiniciar_Click(sender As Object, e As EventArgs) Handles BTNiniciar.Click
        ' Conexión a la base de datos
        CONECTAR()
        ' Comando SQL para realizar la verificación de login
        Dim comando As String = "SELECT * FROM ADMINISTRADOR WHERE CORREO_ELECTRONICO = '" & TXTcorreo.Text & "' AND CONTRASENA = '" & TXTcontrasena.Text & "'"
        Dim adp As New OleDb.OleDbDataAdapter(comando, miconexion)
        ' Se crea un nuevo DataSet para almacenar los resultados
        Dim ds As New DataSet()
        ' Se llena el DataSet con los resultados de la consulta
        adp.Fill(ds, "tabla")
        ' Se verifica si se encontraron filas en el DataSet
        If ds.Tables("tabla").Rows.Count > 0 Then
            ' Si se encontraron filas, el inicio de sesión es exitoso
            Me.Hide()
            FrmMenuProfesor.ShowDialog()
            Me.Close()
        Else
            ' Si no se encontraron filas, se muestra un mensaje de error
            MsgBox("El usuario o contraseña no coinciden")
            ' Se limpian los campos de texto
            TXTcorreo.Text = ""
            TXTcontrasena.Text = ""
        End If
        ' Se desconecta de la base de datos
        DESCONECTAR()
    End Sub
End Class