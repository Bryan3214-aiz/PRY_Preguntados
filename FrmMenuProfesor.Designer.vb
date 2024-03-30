<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuProfesor))
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNinfoPRO = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BTNayuda = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNmiPerfil = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_Reportes = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNenviarReporte = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcalificarRespuestas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcalificaciones = New Guna.UI2.WinForms.Guna2Button()
        Me.panelCalificaciones = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNbuscarCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelSubFormularios = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNbuscarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeliminarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNtemas = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLOGO = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNinfoPRO.SuspendLayout()
        Me.Panel_Reportes.SuspendLayout()
        Me.panelCalificaciones.SuspendLayout()
        Me.PanelSubFormularios.SuspendLayout()
        Me.PanelLOGO.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenedor.SuspendLayout()
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
        Me.BTNcerrar.Location = New System.Drawing.Point(894, 0)
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
        Me.BTNinfoPRO.Controls.Add(Me.BTNmiPerfil)
        Me.BTNinfoPRO.Controls.Add(Me.Panel_Reportes)
        Me.BTNinfoPRO.Controls.Add(Me.BTNcalificaciones)
        Me.BTNinfoPRO.Controls.Add(Me.panelCalificaciones)
        Me.BTNinfoPRO.Controls.Add(Me.BTNcategorias)
        Me.BTNinfoPRO.Controls.Add(Me.PanelSubFormularios)
        Me.BTNinfoPRO.Controls.Add(Me.BTNtemas)
        Me.BTNinfoPRO.Controls.Add(Me.PanelLOGO)
        Me.BTNinfoPRO.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNinfoPRO.Location = New System.Drawing.Point(0, 0)
        Me.BTNinfoPRO.Name = "BTNinfoPRO"
        Me.BTNinfoPRO.Size = New System.Drawing.Size(250, 669)
        Me.BTNinfoPRO.TabIndex = 12
        '
        'BTNayuda
        '
        Me.BTNayuda.Animated = True
        Me.BTNayuda.BackColor = System.Drawing.Color.Teal
        Me.BTNayuda.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNayuda.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNayuda.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNayuda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNayuda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTNayuda.FillColor = System.Drawing.Color.DarkCyan
        Me.BTNayuda.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNayuda.ForeColor = System.Drawing.Color.White
        Me.BTNayuda.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNayuda.Location = New System.Drawing.Point(0, 624)
        Me.BTNayuda.Name = "BTNayuda"
        Me.BTNayuda.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNayuda.Size = New System.Drawing.Size(250, 45)
        Me.BTNayuda.TabIndex = 10
        Me.BTNayuda.Text = "Ayuda"
        Me.BTNayuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNmiPerfil
        '
        Me.BTNmiPerfil.Animated = True
        Me.BTNmiPerfil.BackColor = System.Drawing.Color.Teal
        Me.BTNmiPerfil.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNmiPerfil.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNmiPerfil.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNmiPerfil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNmiPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNmiPerfil.FillColor = System.Drawing.Color.DarkCyan
        Me.BTNmiPerfil.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNmiPerfil.ForeColor = System.Drawing.Color.White
        Me.BTNmiPerfil.Location = New System.Drawing.Point(0, 572)
        Me.BTNmiPerfil.Name = "BTNmiPerfil"
        Me.BTNmiPerfil.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNmiPerfil.Size = New System.Drawing.Size(250, 45)
        Me.BTNmiPerfil.TabIndex = 9
        Me.BTNmiPerfil.Text = "Mi perfil"
        Me.BTNmiPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel_Reportes
        '
        Me.Panel_Reportes.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel_Reportes.Controls.Add(Me.BTNenviarReporte)
        Me.Panel_Reportes.Controls.Add(Me.BTNcalificarRespuestas)
        Me.Panel_Reportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Reportes.Location = New System.Drawing.Point(0, 499)
        Me.Panel_Reportes.Name = "Panel_Reportes"
        Me.Panel_Reportes.Size = New System.Drawing.Size(250, 73)
        Me.Panel_Reportes.TabIndex = 8
        '
        'BTNenviarReporte
        '
        Me.BTNenviarReporte.Animated = True
        Me.BTNenviarReporte.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNenviarReporte.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNenviarReporte.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNenviarReporte.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNenviarReporte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNenviarReporte.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNenviarReporte.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNenviarReporte.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNenviarReporte.ForeColor = System.Drawing.Color.White
        Me.BTNenviarReporte.Location = New System.Drawing.Point(0, 35)
        Me.BTNenviarReporte.Name = "BTNenviarReporte"
        Me.BTNenviarReporte.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNenviarReporte.Size = New System.Drawing.Size(250, 38)
        Me.BTNenviarReporte.TabIndex = 2
        Me.BTNenviarReporte.Text = "Enviar reporte"
        Me.BTNenviarReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcalificarRespuestas
        '
        Me.BTNcalificarRespuestas.Animated = True
        Me.BTNcalificarRespuestas.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNcalificarRespuestas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcalificarRespuestas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcalificarRespuestas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcalificarRespuestas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcalificarRespuestas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcalificarRespuestas.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNcalificarRespuestas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcalificarRespuestas.ForeColor = System.Drawing.Color.White
        Me.BTNcalificarRespuestas.Location = New System.Drawing.Point(0, 0)
        Me.BTNcalificarRespuestas.Name = "BTNcalificarRespuestas"
        Me.BTNcalificarRespuestas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNcalificarRespuestas.Size = New System.Drawing.Size(250, 35)
        Me.BTNcalificarRespuestas.TabIndex = 1
        Me.BTNcalificarRespuestas.Text = "Calificar respuestas "
        Me.BTNcalificarRespuestas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BTNcalificaciones.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcalificaciones.ForeColor = System.Drawing.Color.White
        Me.BTNcalificaciones.Location = New System.Drawing.Point(0, 454)
        Me.BTNcalificaciones.Name = "BTNcalificaciones"
        Me.BTNcalificaciones.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNcalificaciones.Size = New System.Drawing.Size(250, 45)
        Me.BTNcalificaciones.TabIndex = 7
        Me.BTNcalificaciones.Text = "Reportes"
        Me.BTNcalificaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelCalificaciones
        '
        Me.panelCalificaciones.BackColor = System.Drawing.Color.DarkSlateGray
        Me.panelCalificaciones.Controls.Add(Me.BTNbuscarCategorias)
        Me.panelCalificaciones.Controls.Add(Me.BTNeditarCategorias)
        Me.panelCalificaciones.Controls.Add(Me.BTNcrearCategorias)
        Me.panelCalificaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCalificaciones.Location = New System.Drawing.Point(0, 347)
        Me.panelCalificaciones.Name = "panelCalificaciones"
        Me.panelCalificaciones.Size = New System.Drawing.Size(250, 107)
        Me.panelCalificaciones.TabIndex = 6
        '
        'BTNbuscarCategorias
        '
        Me.BTNbuscarCategorias.Animated = True
        Me.BTNbuscarCategorias.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNbuscarCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNbuscarCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNbuscarCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNbuscarCategorias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNbuscarCategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNbuscarCategorias.ForeColor = System.Drawing.Color.White
        Me.BTNbuscarCategorias.Location = New System.Drawing.Point(0, 70)
        Me.BTNbuscarCategorias.Name = "BTNbuscarCategorias"
        Me.BTNbuscarCategorias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNbuscarCategorias.Size = New System.Drawing.Size(250, 37)
        Me.BTNbuscarCategorias.TabIndex = 3
        Me.BTNbuscarCategorias.Text = "Buscar categorias"
        Me.BTNbuscarCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNeditarCategorias
        '
        Me.BTNeditarCategorias.Animated = True
        Me.BTNeditarCategorias.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNeditarCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeditarCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeditarCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNeditarCategorias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNeditarCategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarCategorias.ForeColor = System.Drawing.Color.White
        Me.BTNeditarCategorias.Location = New System.Drawing.Point(0, 35)
        Me.BTNeditarCategorias.Name = "BTNeditarCategorias"
        Me.BTNeditarCategorias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeditarCategorias.Size = New System.Drawing.Size(250, 35)
        Me.BTNeditarCategorias.TabIndex = 2
        Me.BTNeditarCategorias.Text = "Editar categorias"
        Me.BTNeditarCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcrearCategorias
        '
        Me.BTNcrearCategorias.Animated = True
        Me.BTNcrearCategorias.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNcrearCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcrearCategorias.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNcrearCategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearCategorias.ForeColor = System.Drawing.Color.White
        Me.BTNcrearCategorias.Location = New System.Drawing.Point(0, 0)
        Me.BTNcrearCategorias.Name = "BTNcrearCategorias"
        Me.BTNcrearCategorias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNcrearCategorias.Size = New System.Drawing.Size(250, 35)
        Me.BTNcrearCategorias.TabIndex = 1
        Me.BTNcrearCategorias.Text = "Crear categorias"
        Me.BTNcrearCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcategorias
        '
        Me.BTNcategorias.Animated = True
        Me.BTNcategorias.BackColor = System.Drawing.Color.Teal
        Me.BTNcategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcategorias.FillColor = System.Drawing.Color.DarkCyan
        Me.BTNcategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNcategorias.ForeColor = System.Drawing.Color.White
        Me.BTNcategorias.Location = New System.Drawing.Point(0, 302)
        Me.BTNcategorias.Name = "BTNcategorias"
        Me.BTNcategorias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNcategorias.Size = New System.Drawing.Size(250, 45)
        Me.BTNcategorias.TabIndex = 5
        Me.BTNcategorias.Text = "Categorias"
        Me.BTNcategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PanelSubFormularios
        '
        Me.PanelSubFormularios.BackColor = System.Drawing.Color.Turquoise
        Me.PanelSubFormularios.Controls.Add(Me.BTNbuscarTemas)
        Me.PanelSubFormularios.Controls.Add(Me.BTNeliminarTemas)
        Me.PanelSubFormularios.Controls.Add(Me.BTNeditarTemas)
        Me.PanelSubFormularios.Controls.Add(Me.BTNcrearTemas)
        Me.PanelSubFormularios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubFormularios.Location = New System.Drawing.Point(0, 160)
        Me.PanelSubFormularios.Name = "PanelSubFormularios"
        Me.PanelSubFormularios.Size = New System.Drawing.Size(250, 142)
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
        Me.BTNbuscarTemas.Location = New System.Drawing.Point(0, 105)
        Me.BTNbuscarTemas.Name = "BTNbuscarTemas"
        Me.BTNbuscarTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNbuscarTemas.Size = New System.Drawing.Size(250, 37)
        Me.BTNbuscarTemas.TabIndex = 3
        Me.BTNbuscarTemas.Text = "Buscar temas"
        Me.BTNbuscarTemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNeliminarTemas
        '
        Me.BTNeliminarTemas.Animated = True
        Me.BTNeliminarTemas.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNeliminarTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeliminarTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeliminarTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNeliminarTemas.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNeliminarTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarTemas.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarTemas.Location = New System.Drawing.Point(0, 70)
        Me.BTNeliminarTemas.Name = "BTNeliminarTemas"
        Me.BTNeliminarTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeliminarTemas.Size = New System.Drawing.Size(250, 35)
        Me.BTNeliminarTemas.TabIndex = 2
        Me.BTNeliminarTemas.Text = "Eliminar temas"
        Me.BTNeliminarTemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BTNeditarTemas.Text = "Actualizar temas"
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
        Me.BTNcrearTemas.Text = "crear temas"
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
        'panelContenedor
        '
        Me.panelContenedor.BackColor = System.Drawing.Color.Transparent
        Me.panelContenedor.Controls.Add(Me.BTNcerrar)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(250, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(938, 669)
        Me.panelContenedor.TabIndex = 13
        '
        'FrmMenuProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1188, 669)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.BTNinfoPRO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuEstudiante"
        Me.BTNinfoPRO.ResumeLayout(False)
        Me.Panel_Reportes.ResumeLayout(False)
        Me.panelCalificaciones.ResumeLayout(False)
        Me.PanelSubFormularios.ResumeLayout(False)
        Me.PanelLOGO.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNinfoPRO As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Temporizado As Timer
    Friend WithEvents PanelSubFormularios As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNtemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcrearTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelCalificaciones As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNeditarCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcrearCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelLOGO As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BTNcalificaciones As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNbuscarCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeliminarTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeditarTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel_Reportes As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNenviarReporte As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcalificarRespuestas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNmiPerfil As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNayuda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelContenedor As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNbuscarTemas As Guna.UI2.WinForms.Guna2Button
End Class
