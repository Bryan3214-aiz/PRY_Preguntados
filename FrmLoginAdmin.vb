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
        CONECTAR()
        comando = "SELECT * FROM ADMINISTRADOR WHERE CORREO_ELECTRONICO = '" & TXTcorreo.Text & "' AND CONTRASENA = '" & TXTcontrasena.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(comando, miconexion)
        Dim adp As New OleDb.OleDbDataAdapter(comando, miconexion)
        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))
        If adp.Fill(ds.Tables("tabla")) Then
            Me.Hide()
            FrmMenuProfesor.ShowDialog()
            Me.Close()
        Else
            DESCONECTAR()
            MsgBox("El usuario o contraseña no coinciden")
            TXTcorreo.Text = ""
            TXTcontrasena.Text = ""
        End If
    End Sub
End Class