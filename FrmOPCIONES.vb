Imports System.Media
Public Class FrmOPCIONES
    Dim DuracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0
    Dim reproductor As System.Media.SoundPlayer

    Private Sub FrmOPCIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.Opacity = 0
        Temporizado.Interval = 20
        Temporizado.Start()
        Musica()
    End Sub

    Private Sub Musica()
        Dim MusicaActual = My.Resources.sonidoJuego2
        reproductor = New System.Media.SoundPlayer(MusicaActual)
        reproductor.PlayLooping()
    End Sub
    Private Sub Temporizado_Tick(sender As Object, e As EventArgs) Handles Temporizado.Tick
        tiempoTranscurrido += Temporizado.Interval / 1000

        Me.Opacity = Math.Min(tiempoTranscurrido / DuracionTransicion, 1)

        If tiempoTranscurrido >= DuracionTransicion Then
            Temporizado.Stop()
        End If
    End Sub


    Private Sub Panel_Paint(sender As Object, e As PaintEventArgs) Handles Panel.Paint
        Panel.BackColor = Color.FromArgb(99, Color.Black)
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BTNprofesor_Click(sender As Object, e As MouseEventArgs) Handles BTNprofesor.Click
        ' Verificar si se hizo clic derecho
        If e.Button = MouseButtons.Left Then
            ' Preguntar al usuario por el patrón
            Dim patron As String = InputBox("Ingrese el patrón para habilitar el acceso de profesor:")
            ' Establecer conexión con la base de datos
            CONECTAR()
            ' Construir la consulta SQL para buscar el patrón en la tabla ADMINISTRADOR
            Dim comando As String = "SELECT * FROM PROFESOR WHERE PATRON = '" & patron & "'"
            Dim adp As New OleDb.OleDbDataAdapter(comando, miconexion)
            Dim ds As New DataSet()
            ' Ejecutar la consulta y llenar el DataSet
            adp.Fill(ds, "tabla")
            ' Verificar si se encontraron resultados en la consulta
            If ds.Tables("tabla").Rows.Count > 0 Then
                reproductor.Stop()
                Me.Hide()
                FrmLoginProfesor.ShowDialog()
            Else
                ' Si no se encontraron filas, mostrar un mensaje de error
                MsgBox("Patrón Incorrecto. No tiene acceso como profesor")
            End If
        End If
        ' Desconectar la base de datos
        DESCONECTAR()

    End Sub

    Private Sub BTNestudiante_Click(sender As Object, e As EventArgs) Handles BTNestudiante.Click
        Me.Hide()
        FrmLoginEstudiante.ShowDialog()
    End Sub


    Private Sub BTNadmin_Click(sender As Object, e As MouseEventArgs) Handles BTNadmin.Click
        ' Verificar si se hizo clic izquierdo
        If e.Button = MouseButtons.Left Then
            ' Preguntar al usuario por el patrón
            Dim patron As String = InputBox("Ingrese el patrón para habilitar el acceso de administrador:")
            ' Establecer conexión con la base de datos
            CONECTAR()
            ' Construir la consulta SQL para buscar el patrón en la tabla ADMINISTRADOR
            Dim comando As String = "SELECT * FROM ADMINISTRADOR WHERE PATRON = '" & patron & "'"
            Dim adp As New OleDb.OleDbDataAdapter(comando, miconexion)
            Dim ds As New DataSet()
            ' Ejecutar la consulta y llenar el DataSet
            adp.Fill(ds, "tabla")
            ' Verificar si se encontraron resultados en la consulta
            If ds.Tables("tabla").Rows.Count > 0 Then
                Me.Hide()
                FrmLoginAdmin.ShowDialog()
            Else
                ' Si no se encontraron filas, mostrar un mensaje de error
                MsgBox("Patrón Incorrecto. No tiene acceso como administrador")
            End If
        End If
        ' Desconectar la base de datos
        DESCONECTAR()
    End Sub

End Class