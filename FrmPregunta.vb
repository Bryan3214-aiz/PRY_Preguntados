Imports System.IO
Public Class FrmPregunta
    Dim duracionTransicion As Integer = 0.5
    Dim duracionVideo As Integer = 10.31
    Dim tiempoTranscurrido As Integer = 0

    Private Sub TemporizadorVideo_Tick(sender As Object, e As EventArgs) Handles TemporizadorVideo.Tick
        tiempoTranscurrido += 1

        ' Si el tiempo transcurrido es mayor o igual a la duración del video entonces se oculta la ventana actual del video, se abre el siguiente FORM y luego se cierra la actual por completo.
        If tiempoTranscurrido >= duracionVideo Then
            ' Detener el temporizador
            TemporizadorVideo.Stop()
        End If
    End Sub

    Private Sub MediaPlayer_Enter(sender As Object, e As EventArgs) Handles MediaPlayer.Enter
        MediaPlayer.uiMode = "none"
        MediaPlayer.enableContextMenu = False
    End Sub
    Private Sub FrmPregunta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
        Me.KeyPreview = True
        ' Configurar el máximo valor del temporizador para que coincida con la duración del video
        TemporizadorVideo.Interval = 1000 ' Intervalo en milisegundos
        TemporizadorVideo.Start()
        DisableMouseInteraction()
        ' Asigna la imagen deseada a cada botón (reemplaza MyImage1, MyImage2, MyImage3, MyImage4)
        BTNopcionUno.Image = My.Resources.long_button
        BTNopcionDos.Image = My.Resources.long_button
        BTNopcionTres.Image = My.Resources.long_button
        BTNopcionCuatro.Image = My.Resources.long_button
        ' Agregar los eventos de MouseEnter y MouseLeave para cada botón
        AddHandler BTNopcionUno.GotFocus, AddressOf Boton_ConFocus
        AddHandler BTNopcionUno.LostFocus, AddressOf Boton_SinFocus
        AddHandler BTNopcionDos.GotFocus, AddressOf Boton_ConFocus
        AddHandler BTNopcionDos.LostFocus, AddressOf Boton_SinFocus
        AddHandler BTNopcionTres.GotFocus, AddressOf Boton_ConFocus
        AddHandler BTNopcionTres.LostFocus, AddressOf Boton_SinFocus
        AddHandler BTNopcionCuatro.GotFocus, AddressOf Boton_ConFocus
        AddHandler BTNopcionCuatro.LostFocus, AddressOf Boton_SinFocus
        AddHandler Me.KeyDown, AddressOf MainForm_KeyDown
        For Each control As Control In Me.Controls
            If TypeOf control Is Guna.UI2.WinForms.Guna2ImageButton Then
                control.TabStop = True
            End If
        Next


    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                PreviousButton()
            Case Keys.Right
                NextButton()
            Case Keys.Space
        End Select
    End Sub

    Private Sub PreviousButton()
        Dim focusedControl As Control = Me.ActiveControl

        If focusedControl IsNot Nothing Then
            Dim currentIndex As Integer = Me.Controls.IndexOf(focusedControl)
            Dim previousIndex As Integer = (currentIndex - 1 + Me.Controls.Count) Mod Me.Controls.Count

            Me.Controls(previousIndex).Focus()
            UpdateImageButtonImage(Me.Controls(previousIndex))
        End If
    End Sub

    Private Sub NextButton()
        Dim focusedControl As Control = Me.ActiveControl

        If focusedControl IsNot Nothing Then
            Dim currentIndex As Integer = Me.Controls.IndexOf(focusedControl)
            Dim nextIndex As Integer = (currentIndex + 1) Mod Me.Controls.Count

            Me.Controls(nextIndex).Focus()
            UpdateImageButtonImage(Me.Controls(nextIndex))
        End If
    End Sub


    Private Sub UpdateImageButtonImage(button As Control)
        If TypeOf button Is Guna.UI2.WinForms.Guna2ImageButton Then
            Dim gunaButton As Guna.UI2.WinForms.Guna2ImageButton = DirectCast(button, Guna.UI2.WinForms.Guna2ImageButton)
            If gunaButton Is BTNopcionUno Then
                gunaButton.Image = My.Resources.BotonSeleccionado
            ElseIf gunaButton Is BTNopcionDos Then
                gunaButton.Image = My.Resources.BotonSeleccionado
            ElseIf gunaButton Is BTNopcionTres Then
                gunaButton.Image = My.Resources.BotonSeleccionado
            ElseIf gunaButton Is BTNopcionCuatro Then
                gunaButton.Image = My.Resources.BotonSeleccionado
            End If
        End If
    End Sub
    Private Sub DisableMouseInteraction()
        RemoveHandler BTNopcionUno.MouseEnter, AddressOf Boton_MouseEnter
        RemoveHandler BTNopcionUno.MouseLeave, AddressOf Boton_MouseLeave
        RemoveHandler BTNopcionDos.MouseEnter, AddressOf Boton_MouseEnter
        RemoveHandler BTNopcionDos.MouseLeave, AddressOf Boton_MouseLeave
        RemoveHandler BTNopcionTres.MouseEnter, AddressOf Boton_MouseEnter
        RemoveHandler BTNopcionTres.MouseLeave, AddressOf Boton_MouseLeave
        RemoveHandler BTNopcionCuatro.MouseEnter, AddressOf Boton_MouseEnter
        RemoveHandler BTNopcionCuatro.MouseLeave, AddressOf Boton_MouseLeave
    End Sub
    Private Sub Boton_MouseEnter(sender As Object, e As EventArgs)
        Dim boton As Guna.UI2.WinForms.Guna2ImageButton = CType(sender, Guna.UI2.WinForms.Guna2ImageButton)
        boton.Image = My.Resources.BotonSeleccionado
    End Sub

    Private Sub Boton_MouseLeave(sender As Object, e As EventArgs)
        Dim boton As Guna.UI2.WinForms.Guna2ImageButton = CType(sender, Guna.UI2.WinForms.Guna2ImageButton)
        boton.Image = My.Resources.long_button
    End Sub
    Private Sub Boton_ConFocus(sender As Object, e As EventArgs)
        Dim boton As Guna.UI2.WinForms.Guna2ImageButton = CType(sender, Guna.UI2.WinForms.Guna2ImageButton)
        boton.Image = My.Resources.BotonSeleccionado
    End Sub

    Private Sub Boton_SinFocus(sender As Object, e As EventArgs)
        Dim boton As Guna.UI2.WinForms.Guna2ImageButton = CType(sender, Guna.UI2.WinForms.Guna2ImageButton)
        boton.Image = My.Resources.long_button
    End Sub

    Private Sub PKeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space Then
            Dim focusedControl As Control = Me.ActiveControl
            If TypeOf focusedControl Is Guna.UI2.WinForms.Guna2ImageButton Then
                Dim focusedButton As Guna.UI2.WinForms.Guna2ImageButton = DirectCast(focusedControl, Guna.UI2.WinForms.Guna2ImageButton)
                focusedButton.Image = My.Resources.BotonSeleccionadoPresionado
            End If
        End If
    End Sub

    Private Sub PKeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Space Then
            Dim focusedControl As Control = Me.ActiveControl
            If TypeOf focusedControl Is Guna.UI2.WinForms.Guna2ImageButton Then
                Dim focusedButton As Guna.UI2.WinForms.Guna2ImageButton = DirectCast(focusedControl, Guna.UI2.WinForms.Guna2ImageButton)
                focusedButton.Image = My.Resources.Botonverde
            End If
        End If
    End Sub

    Private Sub PKeyUp2(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Space Then
            Dim focusedControl As Control = Me.ActiveControl
            If TypeOf focusedControl Is Guna.UI2.WinForms.Guna2ImageButton Then
                Dim focusedButton As Guna.UI2.WinForms.Guna2ImageButton = DirectCast(focusedControl, Guna.UI2.WinForms.Guna2ImageButton)
                focusedButton.Image = My.Resources.Botonrojo
            End If
        End If
    End Sub

End Class