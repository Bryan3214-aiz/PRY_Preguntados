Imports System.Data.OleDb

Public Class FrmLoginAdmin
    Private duracionTransicion As Double = 0.5 ' Duración de la transición en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente
    Public ID_administrador As Integer = 0
    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            FrmOPCIONES.Close()
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(55, Color.Black)

    End Sub


    Private Sub panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles panel2.Paint
        panel2.BackColor = Color.FromArgb(85, Color.Black)
    End Sub

    Private Sub BTNiniciar_Click(sender As Object, e As EventArgs) Handles BTNiniciar.Click
        Try
            ds.Tables.Clear()
            comando = "SELECT ID FROM ADMINISTRADOR WHERE CORREO_ELECTRONICO = '" & TXTcorreo.Text & "' AND CONTRASENA = '" & TXTcontrasena.Text & "'"
            DESCONECTAR()
            CARGAR_TABLA(ds, comando)
            ID_administrador = ds.Tables(0).Rows(0).Item(0)
            If ID_administrador > 0 Then
                Me.Hide()
                FrmMenuAdministrador.ShowDialog()
                Me.Close()
            Else
                ' Si no se encontraron filas, se muestra un mensaje de error
                MsgBox("El usuario o contraseña no coinciden")
                TXTcorreo.Text = ""
                TXTcontrasena.Text = ""
            End If
            DESCONECTAR()
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
            MessageBox.Show("Ocurrió un error al autenticar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BTNvolverMenu_Click(sender As Object, e As EventArgs) Handles BTNvolverMenu.Click
        Me.Hide()
        FrmOPCIONES.Show()
    End Sub

    Private Sub FrmLoginAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        Temporizado.Interval = 20
        Temporizado.Start()
        LabelAdmin1.BackColor = Color.FromArgb(35, Color.Black)
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

End Class