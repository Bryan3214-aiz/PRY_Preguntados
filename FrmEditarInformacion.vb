Public Class FrmEditarInformacion

    Private duracionTransicion As Double = 0.5 ' Duración de la transición en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente
    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(65, Color.Black)
    End Sub

    Private Sub BTNvolver_Click(sender As Object, e As EventArgs) Handles BTNvolver.Click
        Dim resultado As DialogResult = MessageBox.Show("Si sales y no guardas los cambios, estos se perderan.       ¿Deseas salir de todas formas?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If resultado = DialogResult.Yes Then
            Me.DoubleBuffered = True
            Temporizado.Interval = 20 ' Intervalo en milisegundos
            Temporizado.Start()
            Me.Hide()
            FrmMenuEstudiante.Show()
            Me.Close()
        End If
    End Sub

    Friend Sub inicializar()
        Dim ID As Integer = FrmLoginEstudiante.ID_estudiante
        comando = "SELECT Nivel,nombre_completo,correo_electronico,contrasena from estudiante where ID_usuario = " & ID & ""
        ds.Tables.Clear()
        CARGAR_TABLA(ds, comando)
        If ds.Tables(0).Rows.Count > 0 Then
            CMBnuevogrado.SelectedItem = ds.Tables(0).Rows(0).Item(0)
            TXTnuevoNombre.Text = ds.Tables(0).Rows(0).Item(1)
            TXTcorreo.Text = ds.Tables(0).Rows(0).Item(2)
            TXTcontrasena.Text = ds.Tables(0).Rows(0).Item(3)
        End If

    End Sub
    Friend Sub reiniciar()
        BTNguardar.Enabled = False
        TXTnuevoNombre.Enabled = False
        TXTcontrasena.Enabled = False
        TXTcorreo.Enabled = False
        CMBnuevogrado.SelectedItem = Nothing

        TXTnuevoNombre.Text = ""
        TXTcorreo.Text = ""
        TXTcontrasena.Text = ""
    End Sub

    Private Sub FrmEditarInformacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        Label1.BackColor = Color.FromArgb(50, Color.Black)
        inicializar()
    End Sub

    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000 ' Convertir el intervalo a segundos

        ' Calcular la opacidad del formulario en función del tiempo transcurrido y la duración de la transición
        Me.Opacity = Math.Min(tiempoTranscurrido / duracionTransicion, 1)

        ' Si el tiempo transcurrido supera la duración de la transición, detener el temporizador
        If tiempoTranscurrido >= duracionTransicion Then
            Temporizado.Stop()

        End If
    End Sub

    Private Sub panelinfo_Paint(sender As Object, e As PaintEventArgs) Handles panelinfo.Paint
        panelinfo.BackColor = Color.FromArgb(85, Color.Black)
    End Sub

    Private Sub BTNguardar_Click(sender As Object, e As EventArgs) Handles BTNguardar.Click
        Try
            BTNguardar.Enabled = False
            TXTnuevoNombre.Enabled = False
            CMBnuevogrado.Enabled = False
            TXTcontrasena.Enabled = False
            TXTcorreo.Enabled = False
            If String.IsNullOrWhiteSpace(TXTnuevoNombre.Text) OrElse
                String.IsNullOrWhiteSpace(CMBnuevogrado.Text) OrElse
                String.IsNullOrWhiteSpace(TXTcorreo.Text) OrElse
                String.IsNullOrWhiteSpace(TXTcontrasena.Text) Then
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return ' Salir del método si hay campos vacíos
            End If
            Dim ID As Integer = FrmLoginEstudiante.ID_estudiante
            comando = "UPDATE ESTUDIANTE SET NOMBRE_COMPLETO = '" & TXTnuevoNombre.Text & "', CORREO_ELECTRONICO = '" & TXTcorreo.Text & "', CONTRASENA = '" & TXTcontrasena.Text & "', NIVEL = '" & CMBnuevogrado.Text & "' WHERE ID_USUARIO = " & ID & " "
            EJECUTARSI(comando)
            MsgBox("Usuario actualizado exitosamente.")
        Catch ex As Exception
            Console.WriteLine("Error al actualizar usuario: " & ex.Message)
            MessageBox.Show("Ocurrió un error al actualizar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class