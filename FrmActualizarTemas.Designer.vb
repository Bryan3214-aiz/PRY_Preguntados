<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmActualizarTemas
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNseleccionarTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNactualizarTema = New Guna.UI2.WinForms.Guna2Button()
        Me.CMBgradoTemas = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNvideoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAudioVozTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNsonidoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgAnimadaTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgEstaticaTema = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTtema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelbienvenidaProfesor = New System.Windows.Forms.Label()
        Me.TXTfiltrarNombreTema = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.Controls.Add(Me.TXTfiltrarNombreTema)
        Me.Guna2Panel1.Controls.Add(Me.L)
        Me.Guna2Panel1.Controls.Add(Me.BTNseleccionarTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNactualizarTema)
        Me.Guna2Panel1.Controls.Add(Me.CMBgradoTemas)
        Me.Guna2Panel1.Controls.Add(Me.BTNvideoTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNAudioVozTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNsonidoTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgAnimadaTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgEstaticaTema)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.TXTtema)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(895, 539)
        Me.Guna2Panel1.TabIndex = 36
        '
        'L
        '
        Me.L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.L.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.ForeColor = System.Drawing.SystemColors.WindowText
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.L.HideSelection = False
        Me.L.HoverSelection = True
        Me.L.Location = New System.Drawing.Point(32, 77)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(629, 107)
        Me.L.TabIndex = 33
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre del tema"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 325
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Grado asignado"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 300
        '
        'BTNseleccionarTema
        '
        Me.BTNseleccionarTema.Animated = True
        Me.BTNseleccionarTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNseleccionarTema.BorderRadius = 10
        Me.BTNseleccionarTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNseleccionarTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNseleccionarTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNseleccionarTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNseleccionarTema.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNseleccionarTema.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNseleccionarTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNseleccionarTema.Location = New System.Drawing.Point(688, 30)
        Me.BTNseleccionarTema.Name = "BTNseleccionarTema"
        Me.BTNseleccionarTema.Size = New System.Drawing.Size(180, 60)
        Me.BTNseleccionarTema.TabIndex = 32
        Me.BTNseleccionarTema.Text = "Selecionar tema"
        '
        'BTNactualizarTema
        '
        Me.BTNactualizarTema.Animated = True
        Me.BTNactualizarTema.BackColor = System.Drawing.Color.Lavender
        Me.BTNactualizarTema.BorderRadius = 10
        Me.BTNactualizarTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNactualizarTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNactualizarTema.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNactualizarTema.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNactualizarTema.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNactualizarTema.Location = New System.Drawing.Point(688, 113)
        Me.BTNactualizarTema.Name = "BTNactualizarTema"
        Me.BTNactualizarTema.Size = New System.Drawing.Size(180, 60)
        Me.BTNactualizarTema.TabIndex = 31
        Me.BTNactualizarTema.Text = "Actualizar tema"
        '
        'CMBgradoTemas
        '
        Me.CMBgradoTemas.BackColor = System.Drawing.Color.Transparent
        Me.CMBgradoTemas.BorderRadius = 10
        Me.CMBgradoTemas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBgradoTemas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBgradoTemas.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBgradoTemas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBgradoTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBgradoTemas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBgradoTemas.ItemHeight = 30
        Me.CMBgradoTemas.Items.AddRange(New Object() {"Sétimo", "Octavo", "Noveno", "Décimo", "Undécimo", "Duodécimo"})
        Me.CMBgradoTemas.Location = New System.Drawing.Point(611, 226)
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
        Me.BTNvideoTema.Location = New System.Drawing.Point(522, 421)
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
        Me.BTNAudioVozTema.Location = New System.Drawing.Point(184, 421)
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
        Me.BTNsonidoTema.Location = New System.Drawing.Point(642, 312)
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
        Me.BTNimgAnimadaTema.Location = New System.Drawing.Point(350, 312)
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
        Me.BTNimgEstaticaTema.Location = New System.Drawing.Point(59, 312)
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
        Me.Label5.Location = New System.Drawing.Point(36, 226)
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
        Me.TXTtema.Location = New System.Drawing.Point(178, 226)
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
        Me.Label4.Location = New System.Drawing.Point(409, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 87)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Seleccione el grado: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.LabelbienvenidaProfesor.TabIndex = 35
        Me.LabelbienvenidaProfesor.Text = "Actualizar temas creados"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTfiltrarNombreTema
        '
        Me.TXTfiltrarNombreTema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTfiltrarNombreTema.BorderRadius = 15
        Me.TXTfiltrarNombreTema.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTfiltrarNombreTema.DefaultText = ""
        Me.TXTfiltrarNombreTema.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTfiltrarNombreTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTfiltrarNombreTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTfiltrarNombreTema.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTfiltrarNombreTema.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTfiltrarNombreTema.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.TXTfiltrarNombreTema.ForeColor = System.Drawing.Color.DimGray
        Me.TXTfiltrarNombreTema.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTfiltrarNombreTema.Location = New System.Drawing.Point(32, 21)
        Me.TXTfiltrarNombreTema.Name = "TXTfiltrarNombreTema"
        Me.TXTfiltrarNombreTema.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTfiltrarNombreTema.PlaceholderText = "Ingrese el nombre del tema"
        Me.TXTfiltrarNombreTema.SelectedText = ""
        Me.TXTfiltrarNombreTema.Size = New System.Drawing.Size(629, 42)
        Me.TXTfiltrarNombreTema.TabIndex = 34
        '
        'FrmActualizarTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmActualizarTemas"
        Me.Text = "FrmEditarTemas"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNactualizarTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBgradoTemas As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNvideoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAudioVozTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNsonidoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgAnimadaTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgEstaticaTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTtema As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents BTNseleccionarTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents TXTfiltrarNombreTema As Guna.UI2.WinForms.Guna2TextBox
End Class
