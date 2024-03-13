<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuProfesor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuProfesor))
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNinfoPRO = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BTNmiperfil = New Guna.UI2.WinForms.Guna2Button()
        Me.panelCalificaciones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNenviarCalificaciones = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarCalificaciones = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcalificaciones = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelSubFormularios = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNbuscarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNtemas = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLOGO = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.BTNayuda = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNinfoPRO.SuspendLayout()
        Me.panelCalificaciones.SuspendLayout()
        Me.PanelSubFormularios.SuspendLayout()
        Me.PanelLOGO.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNcerrar
        '
        Me.BTNcerrar.Animated = True
        Me.BTNcerrar.BackColor = System.Drawing.Color.Transparent
        Me.BTNcerrar.BorderColor = System.Drawing.Color.Transparent
        Me.BTNcerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNcerrar.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcerrar.ForeColor = System.Drawing.Color.White
        Me.BTNcerrar.HoverState.FillColor = System.Drawing.Color.IndianRed
        Me.BTNcerrar.Location = New System.Drawing.Point(1026, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 11
        Me.BTNcerrar.Text = "X"
        '
        'BTNinfoPRO
        '
        Me.BTNinfoPRO.AutoScroll = True
        Me.BTNinfoPRO.BackColor = System.Drawing.Color.Teal
        Me.BTNinfoPRO.Controls.Add(Me.BTNayuda)
        Me.BTNinfoPRO.Controls.Add(Me.BTNmiperfil)
        Me.BTNinfoPRO.Controls.Add(Me.panelCalificaciones)
        Me.BTNinfoPRO.Controls.Add(Me.BTNcalificaciones)
        Me.BTNinfoPRO.Controls.Add(Me.PanelSubFormularios)
        Me.BTNinfoPRO.Controls.Add(Me.BTNtemas)
        Me.BTNinfoPRO.Controls.Add(Me.PanelLOGO)
        Me.BTNinfoPRO.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNinfoPRO.Location = New System.Drawing.Point(0, 0)
        Me.BTNinfoPRO.Name = "BTNinfoPRO"
        Me.BTNinfoPRO.Size = New System.Drawing.Size(250, 572)
        Me.BTNinfoPRO.TabIndex = 12
        '
        'BTNmiperfil
        '
        Me.BTNmiperfil.Animated = True
        Me.BTNmiperfil.BackColor = System.Drawing.Color.Teal
        Me.BTNmiperfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNmiperfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNmiperfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNmiperfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNmiperfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNmiperfil.FillColor = System.Drawing.Color.DarkCyan
        Me.BTNmiperfil.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNmiperfil.ForeColor = System.Drawing.Color.White
        Me.BTNmiperfil.Location = New System.Drawing.Point(0, 415)
        Me.BTNmiperfil.Name = "BTNmiperfil"
        Me.BTNmiperfil.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNmiperfil.Size = New System.Drawing.Size(250, 45)
        Me.BTNmiperfil.TabIndex = 7
        Me.BTNmiperfil.Text = "Mi perfil"
        Me.BTNmiperfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelCalificaciones
        '
        Me.panelCalificaciones.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelCalificaciones.Controls.Add(Me.BTNenviarCalificaciones)
        Me.panelCalificaciones.Controls.Add(Me.BTNeditarCalificaciones)
        Me.panelCalificaciones.Controls.Add(Me.Guna2Button1)
        Me.panelCalificaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCalificaciones.Location = New System.Drawing.Point(0, 308)
        Me.panelCalificaciones.Name = "panelCalificaciones"
        Me.panelCalificaciones.Size = New System.Drawing.Size(250, 107)
        Me.panelCalificaciones.TabIndex = 6
        '
        'BTNenviarCalificaciones
        '
        Me.BTNenviarCalificaciones.Animated = True
        Me.BTNenviarCalificaciones.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNenviarCalificaciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNenviarCalificaciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNenviarCalificaciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNenviarCalificaciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNenviarCalificaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNenviarCalificaciones.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNenviarCalificaciones.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNenviarCalificaciones.ForeColor = System.Drawing.Color.White
        Me.BTNenviarCalificaciones.Location = New System.Drawing.Point(0, 70)
        Me.BTNenviarCalificaciones.Name = "BTNenviarCalificaciones"
        Me.BTNenviarCalificaciones.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNenviarCalificaciones.Size = New System.Drawing.Size(250, 35)
        Me.BTNenviarCalificaciones.TabIndex = 3
        Me.BTNenviarCalificaciones.Text = "Enviar por correo"
        Me.BTNenviarCalificaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNeditarCalificaciones
        '
        Me.BTNeditarCalificaciones.Animated = True
        Me.BTNeditarCalificaciones.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNeditarCalificaciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarCalificaciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarCalificaciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeditarCalificaciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeditarCalificaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNeditarCalificaciones.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNeditarCalificaciones.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarCalificaciones.ForeColor = System.Drawing.Color.White
        Me.BTNeditarCalificaciones.Location = New System.Drawing.Point(0, 35)
        Me.BTNeditarCalificaciones.Name = "BTNeditarCalificaciones"
        Me.BTNeditarCalificaciones.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeditarCalificaciones.Size = New System.Drawing.Size(250, 35)
        Me.BTNeditarCalificaciones.TabIndex = 2
        Me.BTNeditarCalificaciones.Text = "Editar calificaciones "
        Me.BTNeditarCalificaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Guna2Button1.Size = New System.Drawing.Size(250, 35)
        Me.Guna2Button1.TabIndex = 1
        Me.Guna2Button1.Text = "Asignar calificaciones"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcalificaciones
        '
        Me.BTNcalificaciones.Animated = True
        Me.BTNcalificaciones.BackColor = System.Drawing.Color.Teal
        Me.BTNcalificaciones.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcalificaciones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcalificaciones.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcalificaciones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcalificaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcalificaciones.FillColor = System.Drawing.Color.DarkCyan
        Me.BTNcalificaciones.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNcalificaciones.ForeColor = System.Drawing.Color.White
        Me.BTNcalificaciones.Location = New System.Drawing.Point(0, 263)
        Me.BTNcalificaciones.Name = "BTNcalificaciones"
        Me.BTNcalificaciones.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNcalificaciones.Size = New System.Drawing.Size(250, 45)
        Me.BTNcalificaciones.TabIndex = 5
        Me.BTNcalificaciones.Text = "Categorias"
        Me.BTNcalificaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PanelSubFormularios
        '
        Me.PanelSubFormularios.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PanelSubFormularios.Controls.Add(Me.BTNbuscarTemas)
        Me.PanelSubFormularios.Controls.Add(Me.BTNeditarTemas)
        Me.PanelSubFormularios.Controls.Add(Me.BTNcrearTemas)
        Me.PanelSubFormularios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubFormularios.Location = New System.Drawing.Point(0, 160)
        Me.PanelSubFormularios.Name = "PanelSubFormularios"
        Me.PanelSubFormularios.Size = New System.Drawing.Size(250, 103)
        Me.PanelSubFormularios.TabIndex = 2
        '
        'BTNbuscarTemas
        '
        Me.BTNbuscarTemas.Animated = True
        Me.BTNbuscarTemas.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNbuscarTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNbuscarTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNbuscarTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNbuscarTemas.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNbuscarTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNbuscarTemas.ForeColor = System.Drawing.Color.White
        Me.BTNbuscarTemas.Location = New System.Drawing.Point(0, 70)
        Me.BTNbuscarTemas.Name = "BTNbuscarTemas"
        Me.BTNbuscarTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNbuscarTemas.Size = New System.Drawing.Size(250, 35)
        Me.BTNbuscarTemas.TabIndex = 2
        Me.BTNbuscarTemas.Text = "Buscar temas"
        Me.BTNbuscarTemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNeditarTemas
        '
        Me.BTNeditarTemas.Animated = True
        Me.BTNeditarTemas.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNeditarTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeditarTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeditarTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNeditarTemas.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNeditarTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarTemas.ForeColor = System.Drawing.Color.White
        Me.BTNeditarTemas.Location = New System.Drawing.Point(0, 35)
        Me.BTNeditarTemas.Name = "BTNeditarTemas"
        Me.BTNeditarTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeditarTemas.Size = New System.Drawing.Size(250, 35)
        Me.BTNeditarTemas.TabIndex = 1
        Me.BTNeditarTemas.Text = "editar temas"
        Me.BTNeditarTemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcrearTemas
        '
        Me.BTNcrearTemas.Animated = True
        Me.BTNcrearTemas.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNcrearTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcrearTemas.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNcrearTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearTemas.ForeColor = System.Drawing.Color.White
        Me.BTNcrearTemas.Location = New System.Drawing.Point(0, 0)
        Me.BTNcrearTemas.Name = "BTNcrearTemas"
        Me.BTNcrearTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNcrearTemas.Size = New System.Drawing.Size(250, 35)
        Me.BTNcrearTemas.TabIndex = 0
        Me.BTNcrearTemas.Text = "crear categorias"
        Me.BTNcrearTemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNtemas
        '
        Me.BTNtemas.Animated = True
        Me.BTNtemas.BackColor = System.Drawing.Color.Teal
        Me.BTNtemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNtemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNtemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNtemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNtemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNtemas.FillColor = System.Drawing.Color.DarkCyan
        Me.BTNtemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNtemas.ForeColor = System.Drawing.Color.White
        Me.BTNtemas.Location = New System.Drawing.Point(0, 115)
        Me.BTNtemas.Name = "BTNtemas"
        Me.BTNtemas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNtemas.Size = New System.Drawing.Size(250, 45)
        Me.BTNtemas.TabIndex = 1
        Me.BTNtemas.Text = "Temas"
        Me.BTNtemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PanelLOGO
        '
        Me.PanelLOGO.BackColor = System.Drawing.Color.Transparent
        Me.PanelLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelLOGO.Controls.Add(Me.Guna2PictureBox1)
        Me.PanelLOGO.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLOGO.Location = New System.Drawing.Point(0, 0)
        Me.PanelLOGO.Name = "PanelLOGO"
        Me.PanelLOGO.Size = New System.Drawing.Size(250, 115)
        Me.PanelLOGO.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(6, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(244, 112)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Temporizado
        '
        '
        'BTNayuda
        '
        Me.BTNayuda.Animated = True
        Me.BTNayuda.BackColor = System.Drawing.Color.Teal
        Me.BTNayuda.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNayuda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNayuda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNayuda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNayuda.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNayuda.FillColor = System.Drawing.Color.DarkCyan
        Me.BTNayuda.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNayuda.ForeColor = System.Drawing.Color.White
        Me.BTNayuda.Location = New System.Drawing.Point(0, 460)
        Me.BTNayuda.Name = "BTNayuda"
        Me.BTNayuda.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNayuda.Size = New System.Drawing.Size(250, 45)
        Me.BTNayuda.TabIndex = 8
        Me.BTNayuda.Text = "Ayuda"
        Me.BTNayuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmMenuProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1070, 572)
        Me.Controls.Add(Me.BTNcerrar)
        Me.Controls.Add(Me.BTNinfoPRO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuEstudiante"
        Me.BTNinfoPRO.ResumeLayout(False)
        Me.panelCalificaciones.ResumeLayout(False)
        Me.PanelSubFormularios.ResumeLayout(False)
        Me.PanelLOGO.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNinfoPRO As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Temporizado As Timer
    Friend WithEvents PanelSubFormularios As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNtemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcrearTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcalificaciones As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelCalificaciones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNeditarCalificaciones As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelLOGO As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTNmiperfil As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNenviarCalificaciones As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNbuscarTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeditarTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNayuda As Guna.UI2.WinForms.Guna2Button
End Class
