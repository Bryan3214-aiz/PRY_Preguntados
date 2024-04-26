<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmJuegoPreguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJuegoPreguntas))
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.PBBARRA = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Temporizador = New System.Windows.Forms.Timer(Me.components)
        Me.LBLPUNTOS = New System.Windows.Forms.Label()
        Me.IMAGENES = New System.Windows.Forms.ImageList(Me.components)
        Me.BTN1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN3 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN4 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN2 = New Guna.UI2.WinForms.Guna2Button()
        Me.LBLPREGUNTA = New System.Windows.Forms.Label()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(-51, -38)
        Me.MediaPlayer.Margin = New System.Windows.Forms.Padding(4)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(1040, 560)
        Me.MediaPlayer.TabIndex = 37
        '
        'PBBARRA
        '
        Me.PBBARRA.BackColor = System.Drawing.Color.Transparent
        Me.PBBARRA.FillColor = System.Drawing.Color.Black
        Me.PBBARRA.Location = New System.Drawing.Point(101, 562)
        Me.PBBARRA.Margin = New System.Windows.Forms.Padding(4)
        Me.PBBARRA.Name = "PBBARRA"
        Me.PBBARRA.ProgressColor = System.Drawing.Color.Gold
        Me.PBBARRA.ProgressColor2 = System.Drawing.Color.Gold
        Me.PBBARRA.Size = New System.Drawing.Size(1075, 18)
        Me.PBBARRA.TabIndex = 20
        Me.PBBARRA.Text = "Guna2ProgressBar1"
        Me.PBBARRA.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.PBBARRA.Value = 70
        '
        'Temporizador
        '
        '
        'LBLPUNTOS
        '
        Me.LBLPUNTOS.BackColor = System.Drawing.Color.White
        Me.LBLPUNTOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPUNTOS.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LBLPUNTOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LBLPUNTOS.ImageIndex = 0
        Me.LBLPUNTOS.ImageList = Me.IMAGENES
        Me.LBLPUNTOS.Location = New System.Drawing.Point(1117, -2)
        Me.LBLPUNTOS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLPUNTOS.Name = "LBLPUNTOS"
        Me.LBLPUNTOS.Size = New System.Drawing.Size(164, 76)
        Me.LBLPUNTOS.TabIndex = 21
        Me.LBLPUNTOS.Text = "0"
        Me.LBLPUNTOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IMAGENES
        '
        Me.IMAGENES.ImageStream = CType(resources.GetObject("IMAGENES.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMAGENES.TransparentColor = System.Drawing.Color.Transparent
        Me.IMAGENES.Images.SetKeyName(0, "icono.jpg")
        '
        'BTN1
        '
        Me.BTN1.Animated = True
        Me.BTN1.BackColor = System.Drawing.Color.Transparent
        Me.BTN1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN1.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN1.ForeColor = System.Drawing.Color.White
        Me.BTN1.Location = New System.Drawing.Point(71, 305)
        Me.BTN1.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN1.Name = "BTN1"
        Me.BTN1.Size = New System.Drawing.Size(499, 96)
        Me.BTN1.TabIndex = 1
        Me.BTN1.Text = "Guna2Button1"
        Me.BTN1.UseTransparentBackground = True
        '
        'BTN3
        '
        Me.BTN3.Animated = True
        Me.BTN3.BackColor = System.Drawing.Color.Transparent
        Me.BTN3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN3.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN3.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN3.ForeColor = System.Drawing.Color.White
        Me.BTN3.Location = New System.Drawing.Point(711, 305)
        Me.BTN3.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN3.Name = "BTN3"
        Me.BTN3.Size = New System.Drawing.Size(499, 96)
        Me.BTN3.TabIndex = 2
        Me.BTN3.Text = "Guna2Button1"
        Me.BTN3.UseTransparentBackground = True
        '
        'BTN4
        '
        Me.BTN4.Animated = True
        Me.BTN4.BackColor = System.Drawing.Color.Transparent
        Me.BTN4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN4.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN4.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN4.ForeColor = System.Drawing.Color.White
        Me.BTN4.Location = New System.Drawing.Point(711, 425)
        Me.BTN4.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN4.Name = "BTN4"
        Me.BTN4.Size = New System.Drawing.Size(499, 96)
        Me.BTN4.TabIndex = 4
        Me.BTN4.Text = "Guna2Button1"
        Me.BTN4.UseTransparentBackground = True
        '
        'BTN2
        '
        Me.BTN2.Animated = True
        Me.BTN2.BackColor = System.Drawing.Color.Transparent
        Me.BTN2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN2.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN2.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.BTN2.ForeColor = System.Drawing.Color.White
        Me.BTN2.Location = New System.Drawing.Point(71, 425)
        Me.BTN2.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN2.Name = "BTN2"
        Me.BTN2.Size = New System.Drawing.Size(499, 96)
        Me.BTN2.TabIndex = 3
        Me.BTN2.Text = "Guna2Button1"
        Me.BTN2.UseTransparentBackground = True
        '
        'LBLPREGUNTA
        '
        Me.LBLPREGUNTA.BackColor = System.Drawing.Color.Transparent
        Me.LBLPREGUNTA.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPREGUNTA.ForeColor = System.Drawing.SystemColors.Control
        Me.LBLPREGUNTA.Location = New System.Drawing.Point(95, 122)
        Me.LBLPREGUNTA.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBLPREGUNTA.Name = "LBLPREGUNTA"
        Me.LBLPREGUNTA.Size = New System.Drawing.Size(1081, 148)
        Me.LBLPREGUNTA.TabIndex = 29
        Me.LBLPREGUNTA.Text = "Nombre del estudiante:"
        Me.LBLPREGUNTA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmJuegoPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1281, 615)
        Me.Controls.Add(Me.LBLPREGUNTA)
        Me.Controls.Add(Me.BTN2)
        Me.Controls.Add(Me.BTN4)
        Me.Controls.Add(Me.BTN3)
        Me.Controls.Add(Me.BTN1)
        Me.Controls.Add(Me.LBLPUNTOS)
        Me.Controls.Add(Me.PBBARRA)
        Me.Controls.Add(Me.MediaPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmJuegoPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmJuegoPreguntas"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PBBARRA As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Temporizador As Timer
    Friend WithEvents LBLPUNTOS As Label
    Friend WithEvents IMAGENES As ImageList
    Friend WithEvents BTN1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBLPREGUNTA As Label
End Class
