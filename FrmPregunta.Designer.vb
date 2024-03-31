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
        Me.BTN_VideoInsert = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BTNMostrarVideo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNIMGInsert = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNMostrarIMG = New Guna.UI2.WinForms.Guna2Button()
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
        Me.MediaPlayer.Margin = New System.Windows.Forms.Padding(4)
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
        Me.BTNopcionTres.Image = CType(resources.GetObject("BTNopcionTres.Image"), System.Drawing.Image)
        Me.BTNopcionTres.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTNopcionTres.ImageRotate = 0!
        Me.BTNopcionTres.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionTres.Location = New System.Drawing.Point(124, 326)
        Me.BTNopcionTres.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNopcionTres.Name = "BTNopcionTres"
        Me.BTNopcionTres.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionTres.Size = New System.Drawing.Size(349, 85)
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
        Me.BTNopcionUno.Location = New System.Drawing.Point(124, 213)
        Me.BTNopcionUno.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNopcionUno.Name = "BTNopcionUno"
        Me.BTNopcionUno.PressedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BTNopcionUno.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionUno.Size = New System.Drawing.Size(349, 85)
        Me.BTNopcionUno.TabIndex = 2
        Me.BTNopcionUno.UseTransparentBackground = True
        '
        'BTNopcionCuatro
        '
        Me.BTNopcionCuatro.BackColor = System.Drawing.Color.Transparent
        Me.BTNopcionCuatro.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTNopcionCuatro.HoverState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionCuatro.Image = CType(resources.GetObject("BTNopcionCuatro.Image"), System.Drawing.Image)
        Me.BTNopcionCuatro.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTNopcionCuatro.ImageRotate = 0!
        Me.BTNopcionCuatro.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionCuatro.Location = New System.Drawing.Point(561, 326)
        Me.BTNopcionCuatro.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNopcionCuatro.Name = "BTNopcionCuatro"
        Me.BTNopcionCuatro.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionCuatro.Size = New System.Drawing.Size(349, 85)
        Me.BTNopcionCuatro.TabIndex = 5
        '
        'BTNopcionDos
        '
        Me.BTNopcionDos.BackColor = System.Drawing.Color.Transparent
        Me.BTNopcionDos.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.BTNopcionDos.HoverState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionDos.Image = CType(resources.GetObject("BTNopcionDos.Image"), System.Drawing.Image)
        Me.BTNopcionDos.ImageOffset = New System.Drawing.Point(0, 0)
        Me.BTNopcionDos.ImageRotate = 0!
        Me.BTNopcionDos.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionDos.Location = New System.Drawing.Point(561, 213)
        Me.BTNopcionDos.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNopcionDos.Name = "BTNopcionDos"
        Me.BTNopcionDos.PressedState.ImageSize = New System.Drawing.Size(260, 66)
        Me.BTNopcionDos.Size = New System.Drawing.Size(349, 85)
        Me.BTNopcionDos.TabIndex = 6
        '
        'BTN_VideoInsert
        '
        Me.BTN_VideoInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VideoInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VideoInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VideoInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VideoInsert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_VideoInsert.ForeColor = System.Drawing.Color.White
        Me.BTN_VideoInsert.Location = New System.Drawing.Point(805, 38)
        Me.BTN_VideoInsert.Name = "BTN_VideoInsert"
        Me.BTN_VideoInsert.Size = New System.Drawing.Size(180, 45)
        Me.BTN_VideoInsert.TabIndex = 7
        Me.BTN_VideoInsert.Text = "Insertar video"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BTNMostrarVideo
        '
        Me.BTNMostrarVideo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNMostrarVideo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNMostrarVideo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNMostrarVideo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNMostrarVideo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNMostrarVideo.ForeColor = System.Drawing.Color.White
        Me.BTNMostrarVideo.Location = New System.Drawing.Point(281, 38)
        Me.BTNMostrarVideo.Name = "BTNMostrarVideo"
        Me.BTNMostrarVideo.Size = New System.Drawing.Size(180, 45)
        Me.BTNMostrarVideo.TabIndex = 8
        Me.BTNMostrarVideo.Text = "Mostrar video"
        '
        'BTNIMGInsert
        '
        Me.BTNIMGInsert.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNIMGInsert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNIMGInsert.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNIMGInsert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNIMGInsert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNIMGInsert.ForeColor = System.Drawing.Color.White
        Me.BTNIMGInsert.Location = New System.Drawing.Point(805, 133)
        Me.BTNIMGInsert.Name = "BTNIMGInsert"
        Me.BTNIMGInsert.Size = New System.Drawing.Size(180, 45)
        Me.BTNIMGInsert.TabIndex = 9
        Me.BTNIMGInsert.Text = "Insertar imagen"
        '
        'BTNMostrarIMG
        '
        Me.BTNMostrarIMG.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNMostrarIMG.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNMostrarIMG.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNMostrarIMG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNMostrarIMG.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTNMostrarIMG.ForeColor = System.Drawing.Color.White
        Me.BTNMostrarIMG.Location = New System.Drawing.Point(281, 133)
        Me.BTNMostrarIMG.Name = "BTNMostrarIMG"
        Me.BTNMostrarIMG.Size = New System.Drawing.Size(180, 45)
        Me.BTNMostrarIMG.TabIndex = 10
        Me.BTNMostrarIMG.Text = "Mostrar imagen"
        '
        'FrmPregunta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 506)
        Me.Controls.Add(Me.BTNMostrarIMG)
        Me.Controls.Add(Me.BTNIMGInsert)
        Me.Controls.Add(Me.BTNMostrarVideo)
        Me.Controls.Add(Me.BTN_VideoInsert)
        Me.Controls.Add(Me.BTNopcionDos)
        Me.Controls.Add(Me.BTNopcionCuatro)
        Me.Controls.Add(Me.BTNopcionTres)
        Me.Controls.Add(Me.BTNopcionUno)
        Me.Controls.Add(Me.MediaPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents BTN_VideoInsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BTNMostrarVideo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNIMGInsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNMostrarIMG As Guna.UI2.WinForms.Guna2Button
End Class
