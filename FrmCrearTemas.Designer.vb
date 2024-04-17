<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrearTemas
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
        Me.LabelbienvenidaProfesor = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcrearTema = New Guna.UI2.WinForms.Guna2Button()
        Me.CMBgradoTemas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNvideoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAudioVozTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNsonidoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgAnimadaTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgEstaticaTema = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTtema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelbienvenidaProfesor
        '
        Me.LabelbienvenidaProfesor.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelbienvenidaProfesor.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelbienvenidaProfesor.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelbienvenidaProfesor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelbienvenidaProfesor.Location = New System.Drawing.Point(0, 0)
        Me.LabelbienvenidaProfesor.Name = "LabelbienvenidaProfesor"
        Me.LabelbienvenidaProfesor.Size = New System.Drawing.Size(895, 115)
        Me.LabelbienvenidaProfesor.TabIndex = 31
        Me.LabelbienvenidaProfesor.Text = "Registrar nuevos temas"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTNcrearTema)
        Me.Guna2Panel1.Controls.Add(Me.CMBgradoTemas)
        Me.Guna2Panel1.Controls.Add(Me.BTNvideoTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNAudioVozTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNsonidoTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgAnimadaTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgEstaticaTema)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.TXTtema)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(895, 539)
        Me.Guna2Panel1.TabIndex = 34
        '
        'BTNcrearTema
        '
        Me.BTNcrearTema.Animated = True
        Me.BTNcrearTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNcrearTema.BorderRadius = 10
        Me.BTNcrearTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearTema.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNcrearTema.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNcrearTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNcrearTema.Location = New System.Drawing.Point(680, 430)
        Me.BTNcrearTema.Name = "BTNcrearTema"
        Me.BTNcrearTema.Size = New System.Drawing.Size(180, 60)
        Me.BTNcrearTema.TabIndex = 31
        Me.BTNcrearTema.Text = "Crear tema"
        '
        'CMBgradoTemas
        '
        Me.CMBgradoTemas.BackColor = System.Drawing.Color.Transparent
        Me.CMBgradoTemas.BorderRadius = 10
        Me.CMBgradoTemas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBgradoTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBgradoTemas.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBgradoTemas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBgradoTemas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBgradoTemas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBgradoTemas.ItemHeight = 30
        Me.CMBgradoTemas.Items.AddRange(New Object() {"Sétimo", "Octavo", "Noveno", "Décimo", "Undécimo", "Duodécimo"})
        Me.CMBgradoTemas.Location = New System.Drawing.Point(621, 78)
        Me.CMBgradoTemas.Name = "CMBgradoTemas"
        Me.CMBgradoTemas.Size = New System.Drawing.Size(220, 36)
        Me.CMBgradoTemas.TabIndex = 30
        '
        'BTNvideoTema
        '
        Me.BTNvideoTema.Animated = True
        Me.BTNvideoTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNvideoTema.BorderRadius = 15
        Me.BTNvideoTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNvideoTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNvideoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNvideoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNvideoTema.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNvideoTema.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNvideoTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNvideoTema.Location = New System.Drawing.Point(526, 296)
        Me.BTNvideoTema.Name = "BTNvideoTema"
        Me.BTNvideoTema.Size = New System.Drawing.Size(195, 70)
        Me.BTNvideoTema.TabIndex = 29
        Me.BTNvideoTema.Text = "Video del tema"
        '
        'BTNAudioVozTema
        '
        Me.BTNAudioVozTema.Animated = True
        Me.BTNAudioVozTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNAudioVozTema.BorderRadius = 15
        Me.BTNAudioVozTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNAudioVozTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNAudioVozTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNAudioVozTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNAudioVozTema.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNAudioVozTema.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNAudioVozTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNAudioVozTema.Location = New System.Drawing.Point(188, 296)
        Me.BTNAudioVozTema.Name = "BTNAudioVozTema"
        Me.BTNAudioVozTema.Size = New System.Drawing.Size(195, 70)
        Me.BTNAudioVozTema.TabIndex = 28
        Me.BTNAudioVozTema.Text = "Audio de voz del tema"
        '
        'BTNsonidoTema
        '
        Me.BTNsonidoTema.Animated = True
        Me.BTNsonidoTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNsonidoTema.BorderRadius = 15
        Me.BTNsonidoTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNsonidoTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNsonidoTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNsonidoTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNsonidoTema.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNsonidoTema.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNsonidoTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNsonidoTema.Location = New System.Drawing.Point(646, 187)
        Me.BTNsonidoTema.Name = "BTNsonidoTema"
        Me.BTNsonidoTema.Size = New System.Drawing.Size(195, 70)
        Me.BTNsonidoTema.TabIndex = 27
        Me.BTNsonidoTema.Text = "Sonido del tema"
        '
        'BTNimgAnimadaTema
        '
        Me.BTNimgAnimadaTema.Animated = True
        Me.BTNimgAnimadaTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNimgAnimadaTema.BorderRadius = 15
        Me.BTNimgAnimadaTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgAnimadaTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgAnimadaTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNimgAnimadaTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNimgAnimadaTema.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNimgAnimadaTema.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNimgAnimadaTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNimgAnimadaTema.Location = New System.Drawing.Point(354, 187)
        Me.BTNimgAnimadaTema.Name = "BTNimgAnimadaTema"
        Me.BTNimgAnimadaTema.Size = New System.Drawing.Size(195, 70)
        Me.BTNimgAnimadaTema.TabIndex = 26
        Me.BTNimgAnimadaTema.Text = "Imagen animada del tema"
        '
        'BTNimgEstaticaTema
        '
        Me.BTNimgEstaticaTema.Animated = True
        Me.BTNimgEstaticaTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNimgEstaticaTema.BorderRadius = 15
        Me.BTNimgEstaticaTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgEstaticaTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgEstaticaTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNimgEstaticaTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNimgEstaticaTema.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNimgEstaticaTema.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNimgEstaticaTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNimgEstaticaTema.Location = New System.Drawing.Point(63, 187)
        Me.BTNimgEstaticaTema.Name = "BTNimgEstaticaTema"
        Me.BTNimgEstaticaTema.Size = New System.Drawing.Size(195, 70)
        Me.BTNimgEstaticaTema.TabIndex = 25
        Me.BTNimgEstaticaTema.Text = "Imagen estática del tema"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(46, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 36)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Tema:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTtema
        '
        Me.TXTtema.Animated = True
        Me.TXTtema.BackColor = System.Drawing.Color.Transparent
        Me.TXTtema.BorderRadius = 10
        Me.TXTtema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTtema.DefaultText = ""
        Me.TXTtema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTtema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTtema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTtema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTtema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTtema.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXTtema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTtema.Location = New System.Drawing.Point(188, 78)
        Me.TXTtema.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTtema.Name = "TXTtema"
        Me.TXTtema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTtema.PlaceholderText = "Digite el nombre del tema"
        Me.TXTtema.SelectedText = ""
        Me.TXTtema.Size = New System.Drawing.Size(220, 36)
        Me.TXTtema.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(419, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 87)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Seleccione el grado: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCrearTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCrearTemas"
        Me.Text = "Frmprueba"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcrearTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBgradoTemas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNvideoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAudioVozTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNsonidoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgAnimadaTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgEstaticaTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTtema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
