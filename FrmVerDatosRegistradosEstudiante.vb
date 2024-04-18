Imports System.IO

Public Class FrmVerDatosRegistradosEstudiante
    Private duracionTransicion As Double = 0.5
    Private tiempoTranscurrido As Double = 0
    Dim ID As Integer = 0

    Private Sub FrmVerDatosRegistradosEstudiante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el formulario para usar DoubleBuffered para reducir el parpadeo
        Me.DoubleBuffered = True
        ' Configurar la opacidad inicial del formulario en 0
        Me.Opacity = 0
        ' Iniciar el temporizador para controlar la transición
        Temporizado.Interval = 20 ' Intervalo en milisegundos
        Temporizado.Start()
        panel1.BackColor = Color.FromArgb(70, Color.Black)

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

    Private Sub BTNjuego_Click(sender As Object, e As EventArgs) Handles BTNcomenzarJuego.Click
        Me.Hide()
        FrmMenuEstudiante.ShowDialog()
        Me.Close()
    End Sub

    Private Sub BTNcerrar_Click(sender As Object, e As EventArgs) Handles BTNcerrar.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Estás seguro de que deseas salir del juego?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            ID = Convert.ToInt32(L.SelectedItems(0).Text)
            BTNeditarInfo.Enabled = True
        End If
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
            Next
        End If
    End Sub

    Friend Sub INICIALIZAR()
        comando = "SELECT COLABORADORES.ID, COLABORADORES.IDENTIFICACION,COLABORADORES.NOMBRE,COLABORADORES.TELEFONO,SUCURSALES.NOMBRE FROM COLABORADORES INNER JOIN SUCURSALES ON COLABORADORES.ID_SUCURSAL = SUCURSALES.ID"
        BTNeditarInfo.Enabled = False
        BTNguardarCambios.Enabled = False
        ID = 0
    End Sub

    Private Sub panel1_Paint(sender As Object, e As PaintEventArgs) Handles panel1.Paint
        INICIALIZAR()
    End Sub
End Class