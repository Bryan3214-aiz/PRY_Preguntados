<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarCategorias
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelbienvenidaProfesor = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CMBseleccionarTemaC = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTcategoria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTfiltrarNombreCat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNseleccionarCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNactualizarCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNvideoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAudioVozTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNsonidoTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgAnimadaTema = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgEstaticaTema = New Guna.UI2.WinForms.Guna2Button()
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
        Me.LabelbienvenidaProfesor.TabIndex = 37
        Me.LabelbienvenidaProfesor.Text = "Actualizar temas categorías"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.L)
        Me.Guna2Panel1.Controls.Add(Me.CMBseleccionarTemaC)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.TXTcategoria)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.TXTfiltrarNombreCat)
        Me.Guna2Panel1.Controls.Add(Me.BTNseleccionarCategoria)
        Me.Guna2Panel1.Controls.Add(Me.BTNactualizarCategoria)
        Me.Guna2Panel1.Controls.Add(Me.BTNvideoTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNAudioVozTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNsonidoTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgAnimadaTema)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgEstaticaTema)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(895, 539)
        Me.Guna2Panel1.TabIndex = 38
        '
        'L
        '
        Me.L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
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
        Me.L.Scrollable = False
        Me.L.Size = New System.Drawing.Size(630, 119)
        Me.L.TabIndex = 39
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
        Me.ColumnHeader2.Text = "Nombre de la categoria"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 215
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre del tema asociado"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 215
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Grado"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 200
        '
        'CMBseleccionarTemaC
        '
        Me.CMBseleccionarTemaC.BackColor = System.Drawing.Color.Transparent
        Me.CMBseleccionarTemaC.BorderRadius = 10
        Me.CMBseleccionarTemaC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBseleccionarTemaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBseleccionarTemaC.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarTemaC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarTemaC.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBseleccionarTemaC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBseleccionarTemaC.ItemHeight = 30
        Me.CMBseleccionarTemaC.Location = New System.Drawing.Point(617, 234)
        Me.CMBseleccionarTemaC.Name = "CMBseleccionarTemaC"
        Me.CMBseleccionarTemaC.Size = New System.Drawing.Size(220, 36)
        Me.CMBseleccionarTemaC.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(43, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 36)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Categoria:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTcategoria
        '
        Me.TXTcategoria.Animated = True
        Me.TXTcategoria.BackColor = System.Drawing.Color.Transparent
        Me.TXTcategoria.BorderRadius = 10
        Me.TXTcategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTcategoria.DefaultText = ""
        Me.TXTcategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTcategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTcategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcategoria.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXTcategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcategoria.Location = New System.Drawing.Point(205, 234)
        Me.TXTcategoria.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcategoria.Name = "TXTcategoria"
        Me.TXTcategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcategoria.PlaceholderText = "Digite el nombre de la categoria "
        Me.TXTcategoria.SelectedText = ""
        Me.TXTcategoria.Size = New System.Drawing.Size(220, 36)
        Me.TXTcategoria.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(416, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 67)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Seleccione un tema: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTfiltrarNombreCat
        '
        Me.TXTfiltrarNombreCat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTfiltrarNombreCat.BorderRadius = 15
        Me.TXTfiltrarNombreCat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTfiltrarNombreCat.DefaultText = ""
        Me.TXTfiltrarNombreCat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTfiltrarNombreCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTfiltrarNombreCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTfiltrarNombreCat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTfiltrarNombreCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTfiltrarNombreCat.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.TXTfiltrarNombreCat.ForeColor = System.Drawing.Color.DimGray
        Me.TXTfiltrarNombreCat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTfiltrarNombreCat.Location = New System.Drawing.Point(32, 21)
        Me.TXTfiltrarNombreCat.Name = "TXTfiltrarNombreCat"
        Me.TXTfiltrarNombreCat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTfiltrarNombreCat.PlaceholderText = "filtrar datos por el nombre de la categoría"
        Me.TXTfiltrarNombreCat.SelectedText = ""
        Me.TXTfiltrarNombreCat.Size = New System.Drawing.Size(629, 42)
        Me.TXTfiltrarNombreCat.TabIndex = 34
        '
        'BTNseleccionarCategoria
        '
        Me.BTNseleccionarCategoria.Animated = True
        Me.BTNseleccionarCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNseleccionarCategoria.BorderRadius = 10
        Me.BTNseleccionarCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNseleccionarCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNseleccionarCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNseleccionarCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNseleccionarCategoria.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNseleccionarCategoria.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNseleccionarCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNseleccionarCategoria.Location = New System.Drawing.Point(688, 30)
        Me.BTNseleccionarCategoria.Name = "BTNseleccionarCategoria"
        Me.BTNseleccionarCategoria.Size = New System.Drawing.Size(180, 60)
        Me.BTNseleccionarCategoria.TabIndex = 32
        Me.BTNseleccionarCategoria.Text = "Selecionar categoría"
        '
        'BTNactualizarCategoria
        '
        Me.BTNactualizarCategoria.Animated = True
        Me.BTNactualizarCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNactualizarCategoria.BorderRadius = 10
        Me.BTNactualizarCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNactualizarCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNactualizarCategoria.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNactualizarCategoria.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNactualizarCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNactualizarCategoria.Location = New System.Drawing.Point(688, 113)
        Me.BTNactualizarCategoria.Name = "BTNactualizarCategoria"
        Me.BTNactualizarCategoria.Size = New System.Drawing.Size(180, 60)
        Me.BTNactualizarCategoria.TabIndex = 31
        Me.BTNactualizarCategoria.Text = "Actualizar categoría"
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmActualizarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmActualizarCategorias"
        Me.Text = "FrmActualizarCategorias"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTfiltrarNombreCat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNseleccionarCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNactualizarCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNvideoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAudioVozTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNsonidoTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgAnimadaTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgEstaticaTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBseleccionarTemaC As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTcategoria As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
