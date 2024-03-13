<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPregunta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPregunta))
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TemporizadorVideo = New System.Windows.Forms.Timer(Me.components)
        Me.TiemproPregunta = New System.Windows.Forms.Timer(Me.components)
        Me.BTNopcionTres = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTNopcionUno = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTNopcionCuatro = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.BTNopcionDos = New Guna.UI2.WinForms.Guna2ImageButton()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(-27, -72)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(838, 555)
        Me.MediaPlayer.TabIndex = 1
        '
        'TemporizadorVideo
        '
        '
        'BTNopcionTres
        '
        Me.BTNopcionTres.BackColor = System.Drawing.Color.Transparent
        Me.BTNopcionTres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTNopcionTres.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTNopcionTres.HoverState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionTres.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTNopcionTres.ImageRotate = 0!
        Me.BTNopcionTres.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionTres.Location = New System.Drawing.Point(93, 265)
        Me.BTNopcionTres.Name = "BTNopcionTres"
        Me.BTNopcionTres.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionTres.Size = New System.Drawing.Size(262, 69)
        Me.BTNopcionTres.TabIndex = 4
        '
        'BTNopcionUno
        '
        Me.BTNopcionUno.BackColor = System.Drawing.Color.Transparent
        Me.BTNopcionUno.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTNopcionUno.HoverState.Image = Global.PRY_Preguntados.My.Resources.Resources.BotonSeleccionado
        Me.BTNopcionUno.HoverState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionUno.Image = Global.PRY_Preguntados.My.Resources.Resources.long_button
        Me.BTNopcionUno.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTNopcionUno.ImageRotate = 0!
        Me.BTNopcionUno.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionUno.Location = New System.Drawing.Point(93, 173)
        Me.BTNopcionUno.Name = "BTNopcionUno"
        Me.BTNopcionUno.PressedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BTNopcionUno.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionUno.Size = New System.Drawing.Size(262, 69)
        Me.BTNopcionUno.TabIndex = 2
        Me.BTNopcionUno.UseTransparentBackground = True
        '
        'BTNopcionCuatro
        '
        Me.BTNopcionCuatro.BackColor = System.Drawing.Color.Transparent
        Me.BTNopcionCuatro.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTNopcionCuatro.HoverState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionCuatro.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTNopcionCuatro.ImageRotate = 0!
        Me.BTNopcionCuatro.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionCuatro.Location = New System.Drawing.Point(421, 265)
        Me.BTNopcionCuatro.Name = "BTNopcionCuatro"
        Me.BTNopcionCuatro.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionCuatro.Size = New System.Drawing.Size(262, 69)
        Me.BTNopcionCuatro.TabIndex = 5
        '
        'BTNopcionDos
        '
        Me.BTNopcionDos.BackColor = System.Drawing.Color.Transparent
        Me.BTNopcionDos.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTNopcionDos.HoverState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionDos.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTNopcionDos.ImageRotate = 0!
        Me.BTNopcionDos.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionDos.Location = New System.Drawing.Point(421, 173)
        Me.BTNopcionDos.Name = "BTNopcionDos"
        Me.BTNopcionDos.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionDos.Size = New System.Drawing.Size(262, 69)
        Me.BTNopcionDos.TabIndex = 6
        '
        'FrmPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.BTNopcionDos)
        Me.Controls.Add(Me.BTNopcionCuatro)
        Me.Controls.Add(Me.BTNopcionTres)
        Me.Controls.Add(Me.BTNopcionUno)
        Me.Controls.Add(Me.MediaPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPregunta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPregunta"
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TemporizadorVideo As Timer
    Friend WithEvents TiemproPregunta As Timer
    Friend WithEvents BTNopcionTres As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTNopcionUno As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTNopcionCuatro As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents BTNopcionDos As Guna.UI2.WinForms.Guna2ImageButton
End Class
