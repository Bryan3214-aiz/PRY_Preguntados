Imports System.Data.OleDb
Public Class FrmLoginProfesor

    Private duracionTransicion As Double = 0.5 ' Duración de la transición en segundos
    Private tiempoTranscurrido As Double = 0 ' Tiempo transcurrido inicialmente
    Public ID_profesor As Integer = 0
    Public NOMBRE_PROFESOR As String

    Private Sub panel_Paint(sender As Object, e As PaintEventArgs) Handles panel.Paint
        panel.BackColor = Color.FromArgb(55, Color.Black)
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Verificar si el usuario ha confirmado el cierre del formulario
        If resultado = DialogResult.Yes Then
            FrmOPCIONES.Close()
            Me.Close() ' Cerrar el formulario
        End If
    End Sub

    Public Sub BTNiniciar_Click(sender As Object, e As EventArgs) Handles BTNiniciar.Click
        Try
            ds.Tables.Clear()
            comando = "SELECT ID_PROFESOR, NOMBRE_COMPLETO FROM PROFESOR WHERE CORREO_ELECTRONICO = '" & TXTcorreo.Text & "' AND CONTRASENA = '" & TXTcontrasena.Text & "'"
            DESCONECTAR()
            CARGAR_TABLA(ds, comando)
            ID_profesor = ds.Tables(0).Rows(0).Item(0)
            NOMBRE_PROFESOR = ds.Tables(0).Rows(0).Item(1)
            If ID_profesor > 0 Then
                Me.Hide()
                FrmMenuProfesor.ShowDialog()
                Me.Close()
            Else
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


    Private Sub FrmLoginUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        LabelPro1.BackColor = Color.FromArgb(35, Color.Black)

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

    Private Sub panel2_Paint(sender As Object, e As PaintEventArgs) Handles panel2.Paint
        panel2.BackColor = Color.FromArgb(85, Color.Black)
    End Sub

    Private Sub BTNvolverMenu_Click(sender As Object, e As EventArgs) Handles BTNvolverMenu.Click
        Me.Hide()
        FrmOPCIONES.Show()
    End Sub

End Class

