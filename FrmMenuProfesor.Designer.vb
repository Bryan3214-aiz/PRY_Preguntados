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
        Me.BTNmiPerfil = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.panelReportes = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcrearReportes = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNasignarCalificacion = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNreportes = New Guna.UI2.WinForms.Guna2Button()
        Me.panelPreguntas = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNbuscarPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeliminarPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNactualizarPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNpreguntas = New Guna.UI2.WinForms.Guna2Button()
        Me.panelCategorias = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNbuscarCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeliminarCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearCategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcategorias = New Guna.UI2.WinForms.Guna2Button()
        Me.panelTemas = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNbuscarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeliminarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNtemas = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNinicio = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLOGO = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNmiPerfil.SuspendLayout()
        Me.panelReportes.SuspendLayout()
        Me.panelPreguntas.SuspendLayout()
        Me.panelCategorias.SuspendLayout()
        Me.panelTemas.SuspendLayout()
        Me.PanelLOGO.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNmiPerfil
        '
        Me.BTNmiPerfil.AutoScroll = True
        Me.BTNmiPerfil.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNmiPerfil.Controls.Add(Me.panelReportes)
        Me.BTNmiPerfil.Controls.Add(Me.BTNcerrarSesion)
        Me.BTNmiPerfil.Controls.Add(Me.BTNreportes)
        Me.BTNmiPerfil.Controls.Add(Me.panelPreguntas)
        Me.BTNmiPerfil.Controls.Add(Me.BTNpreguntas)
        Me.BTNmiPerfil.Controls.Add(Me.panelCategorias)
        Me.BTNmiPerfil.Controls.Add(Me.BTNcategorias)
        Me.BTNmiPerfil.Controls.Add(Me.panelTemas)
        Me.BTNmiPerfil.Controls.Add(Me.BTNtemas)
        Me.BTNmiPerfil.Controls.Add(Me.BTNinicio)
        Me.BTNmiPerfil.Controls.Add(Me.PanelLOGO)
        Me.BTNmiPerfil.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNmiPerfil.Location = New System.Drawing.Point(0, 0)
        Me.BTNmiPerfil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNmiPerfil.Name = "BTNmiPerfil"
        Me.BTNmiPerfil.Size = New System.Drawing.Size(333, 805)
        Me.BTNmiPerfil.TabIndex = 12
        '
        'panelReportes
        '
        Me.panelReportes.Controls.Add(Me.BTNcrearReportes)
        Me.panelReportes.Controls.Add(Me.BTNasignarCalificacion)
        Me.panelReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelReportes.Location = New System.Drawing.Point(0, 942)
        Me.panelReportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelReportes.Name = "panelReportes"
        Me.panelReportes.Size = New System.Drawing.Size(312, 98)
        Me.panelReportes.TabIndex = 18
        '
        'BTNcrearReportes
        '
        Me.BTNcrearReportes.Animated = True
        Me.BTNcrearReportes.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNcrearReportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearReportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearReportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearReportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcrearReportes.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNcrearReportes.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearReportes.ForeColor = System.Drawing.Color.White
        Me.BTNcrearReportes.Location = New System.Drawing.Point(0, 50)
        Me.BTNcrearReportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcrearReportes.Name = "BTNcrearReportes"
        Me.BTNcrearReportes.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNcrearReportes.Size = New System.Drawing.Size(312, 50)
        Me.BTNcrearReportes.TabIndex = 4
        Me.BTNcrearReportes.Text = "crear reportes"
        Me.BTNcrearReportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNasignarCalificacion
        '
        Me.BTNasignarCalificacion.Animated = True
        Me.BTNasignarCalificacion.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNasignarCalificacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNasignarCalificacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNasignarCalificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNasignarCalificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNasignarCalificacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNasignarCalificacion.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNasignarCalificacion.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNasignarCalificacion.ForeColor = System.Drawing.Color.White
        Me.BTNasignarCalificacion.Location = New System.Drawing.Point(0, 0)
        Me.BTNasignarCalificacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNasignarCalificacion.Name = "BTNasignarCalificacion"
        Me.BTNasignarCalificacion.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNasignarCalificacion.Size = New System.Drawing.Size(312, 50)
        Me.BTNasignarCalificacion.TabIndex = 3
        Me.BTNasignarCalificacion.Text = "Asignar calificaciones"
        Me.BTNasignarCalificacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcerrarSesion
        '
        Me.BTNcerrarSesion.Animated = True
        Me.BTNcerrarSesion.BackColor = System.Drawing.Color.Teal
        Me.BTNcerrarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcerrarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcerrarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcerrarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTNcerrarSesion.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNcerrarSesion.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcerrarSesion.ForeColor = System.Drawing.Color.White
        Me.BTNcerrarSesion.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BTNcerrarSesion.Location = New System.Drawing.Point(0, 1040)
        Me.BTNcerrarSesion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcerrarSesion.Name = "BTNcerrarSesion"
        Me.BTNcerrarSesion.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BTNcerrarSesion.Size = New System.Drawing.Size(312, 55)
        Me.BTNcerrarSesion.TabIndex = 17
        Me.BTNcerrarSesion.Text = "Cerrar sesión"
        Me.BTNcerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNreportes
        '
        Me.BTNreportes.Animated = True
        Me.BTNreportes.BackColor = System.Drawing.Color.Teal
        Me.BTNreportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNreportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNreportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNreportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNreportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNreportes.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNreportes.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNreportes.ForeColor = System.Drawing.Color.White
        Me.BTNreportes.Location = New System.Drawing.Point(0, 887)
        Me.BTNreportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNreportes.Name = "BTNreportes"
        Me.BTNreportes.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BTNreportes.Size = New System.Drawing.Size(312, 55)
        Me.BTNreportes.TabIndex = 11
        Me.BTNreportes.Text = "Reportes"
        Me.BTNreportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelPreguntas
        '
        Me.panelPreguntas.Controls.Add(Me.BTNbuscarPregunta)
        Me.panelPreguntas.Controls.Add(Me.BTNeliminarPregunta)
        Me.panelPreguntas.Controls.Add(Me.BTNactualizarPregunta)
        Me.panelPreguntas.Controls.Add(Me.BTNcrearPregunta)
        Me.panelPreguntas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelPreguntas.Location = New System.Drawing.Point(0, 712)
        Me.panelPreguntas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelPreguntas.Name = "panelPreguntas"
        Me.panelPreguntas.Size = New System.Drawing.Size(312, 175)
        Me.panelPreguntas.TabIndex = 16
        '
        'BTNbuscarPregunta
        '
        Me.BTNbuscarPregunta.Animated = True
        Me.BTNbuscarPregunta.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNbuscarPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNbuscarPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNbuscarPregunta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNbuscarPregunta.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNbuscarPregunta.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNbuscarPregunta.ForeColor = System.Drawing.Color.White
        Me.BTNbuscarPregunta.Location = New System.Drawing.Point(0, 129)
        Me.BTNbuscarPregunta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNbuscarPregunta.Name = "BTNbuscarPregunta"
        Me.BTNbuscarPregunta.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNbuscarPregunta.Size = New System.Drawing.Size(312, 46)
        Me.BTNbuscarPregunta.TabIndex = 6
        Me.BTNbuscarPregunta.Text = "Buscar preguntas"
        Me.BTNbuscarPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNeliminarPregunta
        '
        Me.BTNeliminarPregunta.Animated = True
        Me.BTNeliminarPregunta.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNeliminarPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeliminarPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeliminarPregunta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNeliminarPregunta.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNeliminarPregunta.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarPregunta.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarPregunta.Location = New System.Drawing.Point(0, 86)
        Me.BTNeliminarPregunta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNeliminarPregunta.Name = "BTNeliminarPregunta"
        Me.BTNeliminarPregunta.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNeliminarPregunta.Size = New System.Drawing.Size(312, 43)
        Me.BTNeliminarPregunta.TabIndex = 5
        Me.BTNeliminarPregunta.Text = "Eliminar preguntas"
        Me.BTNeliminarPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNactualizarPregunta
        '
        Me.BTNactualizarPregunta.Animated = True
        Me.BTNactualizarPregunta.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNactualizarPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNactualizarPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNactualizarPregunta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNactualizarPregunta.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNactualizarPregunta.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNactualizarPregunta.ForeColor = System.Drawing.Color.White
        Me.BTNactualizarPregunta.Location = New System.Drawing.Point(0, 43)
        Me.BTNactualizarPregunta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNactualizarPregunta.Name = "BTNactualizarPregunta"
        Me.BTNactualizarPregunta.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNactualizarPregunta.Size = New System.Drawing.Size(312, 43)
        Me.BTNactualizarPregunta.TabIndex = 4
        Me.BTNactualizarPregunta.Text = "actualizar preguntas"
        Me.BTNactualizarPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcrearPregunta
        '
        Me.BTNcrearPregunta.Animated = True
        Me.BTNcrearPregunta.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNcrearPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearPregunta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcrearPregunta.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNcrearPregunta.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearPregunta.ForeColor = System.Drawing.Color.White
        Me.BTNcrearPregunta.Location = New System.Drawing.Point(0, 0)
        Me.BTNcrearPregunta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcrearPregunta.Name = "BTNcrearPregunta"
        Me.BTNcrearPregunta.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNcrearPregunta.Size = New System.Drawing.Size(312, 43)
        Me.BTNcrearPregunta.TabIndex = 3
        Me.BTNcrearPregunta.Text = "Crear preguntas"
        Me.BTNcrearPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNpreguntas
        '
        Me.BTNpreguntas.Animated = True
        Me.BTNpreguntas.BackColor = System.Drawing.Color.Teal
        Me.BTNpreguntas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNpreguntas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNpreguntas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNpreguntas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNpreguntas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNpreguntas.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNpreguntas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNpreguntas.ForeColor = System.Drawing.Color.White
        Me.BTNpreguntas.Location = New System.Drawing.Point(0, 657)
        Me.BTNpreguntas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNpreguntas.Name = "BTNpreguntas"
        Me.BTNpreguntas.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BTNpreguntas.Size = New System.Drawing.Size(312, 55)
        Me.BTNpreguntas.TabIndex = 15
        Me.BTNpreguntas.Text = "Preguntas"
        Me.BTNpreguntas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelCategorias
        '
        Me.panelCategorias.Controls.Add(Me.BTNbuscarCategorias)
        Me.panelCategorias.Controls.Add(Me.BTNeliminarCategorias)
        Me.panelCategorias.Controls.Add(Me.BTNeditarCategorias)
        Me.panelCategorias.Controls.Add(Me.BTNcrearCategorias)
        Me.panelCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCategorias.Location = New System.Drawing.Point(0, 482)
        Me.panelCategorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelCategorias.Name = "panelCategorias"
        Me.panelCategorias.Size = New System.Drawing.Size(312, 175)
        Me.panelCategorias.TabIndex = 14
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
        Me.BTNbuscarCategorias.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNbuscarCategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNbuscarCategorias.ForeColor = System.Drawing.Color.White
        Me.BTNbuscarCategorias.Location = New System.Drawing.Point(0, 129)
        Me.BTNbuscarCategorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNbuscarCategorias.Name = "BTNbuscarCategorias"
        Me.BTNbuscarCategorias.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNbuscarCategorias.Size = New System.Drawing.Size(312, 46)
        Me.BTNbuscarCategorias.TabIndex = 6
        Me.BTNbuscarCategorias.Text = "Buscar categorias"
        Me.BTNbuscarCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNeliminarCategorias
        '
        Me.BTNeliminarCategorias.Animated = True
        Me.BTNeliminarCategorias.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNeliminarCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeliminarCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeliminarCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNeliminarCategorias.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNeliminarCategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarCategorias.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarCategorias.Location = New System.Drawing.Point(0, 86)
        Me.BTNeliminarCategorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNeliminarCategorias.Name = "BTNeliminarCategorias"
        Me.BTNeliminarCategorias.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNeliminarCategorias.Size = New System.Drawing.Size(312, 43)
        Me.BTNeliminarCategorias.TabIndex = 5
        Me.BTNeliminarCategorias.Text = "Eliminar categorias"
        Me.BTNeliminarCategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BTNeditarCategorias.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNeditarCategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarCategorias.ForeColor = System.Drawing.Color.White
        Me.BTNeditarCategorias.Location = New System.Drawing.Point(0, 43)
        Me.BTNeditarCategorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNeditarCategorias.Name = "BTNeditarCategorias"
        Me.BTNeditarCategorias.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNeditarCategorias.Size = New System.Drawing.Size(312, 43)
        Me.BTNeditarCategorias.TabIndex = 4
        Me.BTNeditarCategorias.Text = "actualizar categorias"
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
        Me.BTNcrearCategorias.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNcrearCategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearCategorias.ForeColor = System.Drawing.Color.White
        Me.BTNcrearCategorias.Location = New System.Drawing.Point(0, 0)
        Me.BTNcrearCategorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcrearCategorias.Name = "BTNcrearCategorias"
        Me.BTNcrearCategorias.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNcrearCategorias.Size = New System.Drawing.Size(312, 43)
        Me.BTNcrearCategorias.TabIndex = 3
        Me.BTNcrearCategorias.Text = "crear categorias"
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
        Me.BTNcategorias.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNcategorias.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcategorias.ForeColor = System.Drawing.Color.White
        Me.BTNcategorias.Location = New System.Drawing.Point(0, 427)
        Me.BTNcategorias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcategorias.Name = "BTNcategorias"
        Me.BTNcategorias.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BTNcategorias.Size = New System.Drawing.Size(312, 55)
        Me.BTNcategorias.TabIndex = 11
        Me.BTNcategorias.Text = "Categorias"
        Me.BTNcategorias.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelTemas
        '
        Me.panelTemas.Controls.Add(Me.BTNbuscarTemas)
        Me.panelTemas.Controls.Add(Me.BTNeliminarTemas)
        Me.panelTemas.Controls.Add(Me.BTNeditarTemas)
        Me.panelTemas.Controls.Add(Me.BTNcrearTemas)
        Me.panelTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTemas.Location = New System.Drawing.Point(0, 252)
        Me.panelTemas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelTemas.Name = "panelTemas"
        Me.panelTemas.Size = New System.Drawing.Size(312, 175)
        Me.panelTemas.TabIndex = 13
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
        Me.BTNbuscarTemas.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNbuscarTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNbuscarTemas.ForeColor = System.Drawing.Color.White
        Me.BTNbuscarTemas.Location = New System.Drawing.Point(0, 129)
        Me.BTNbuscarTemas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNbuscarTemas.Name = "BTNbuscarTemas"
        Me.BTNbuscarTemas.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNbuscarTemas.Size = New System.Drawing.Size(312, 46)
        Me.BTNbuscarTemas.TabIndex = 6
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
        Me.BTNeliminarTemas.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNeliminarTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarTemas.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarTemas.Location = New System.Drawing.Point(0, 86)
        Me.BTNeliminarTemas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNeliminarTemas.Name = "BTNeliminarTemas"
        Me.BTNeliminarTemas.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNeliminarTemas.Size = New System.Drawing.Size(312, 43)
        Me.BTNeliminarTemas.TabIndex = 5
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
        Me.BTNeditarTemas.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNeditarTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarTemas.ForeColor = System.Drawing.Color.White
        Me.BTNeditarTemas.Location = New System.Drawing.Point(0, 43)
        Me.BTNeditarTemas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNeditarTemas.Name = "BTNeditarTemas"
        Me.BTNeditarTemas.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNeditarTemas.Size = New System.Drawing.Size(312, 43)
        Me.BTNeditarTemas.TabIndex = 4
        Me.BTNeditarTemas.Text = "actualizar temas"
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
        Me.BTNcrearTemas.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNcrearTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearTemas.ForeColor = System.Drawing.Color.White
        Me.BTNcrearTemas.Location = New System.Drawing.Point(0, 0)
        Me.BTNcrearTemas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcrearTemas.Name = "BTNcrearTemas"
        Me.BTNcrearTemas.Padding = New System.Windows.Forms.Padding(47, 0, 0, 0)
        Me.BTNcrearTemas.Size = New System.Drawing.Size(312, 43)
        Me.BTNcrearTemas.TabIndex = 3
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
        Me.BTNtemas.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNtemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNtemas.ForeColor = System.Drawing.Color.White
        Me.BTNtemas.Location = New System.Drawing.Point(0, 197)
        Me.BTNtemas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNtemas.Name = "BTNtemas"
        Me.BTNtemas.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BTNtemas.Size = New System.Drawing.Size(312, 55)
        Me.BTNtemas.TabIndex = 12
        Me.BTNtemas.Text = "Temas"
        Me.BTNtemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNinicio
        '
        Me.BTNinicio.Animated = True
        Me.BTNinicio.BackColor = System.Drawing.Color.Transparent
        Me.BTNinicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNinicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNinicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNinicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNinicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNinicio.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNinicio.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNinicio.ForeColor = System.Drawing.Color.White
        Me.BTNinicio.Location = New System.Drawing.Point(0, 142)
        Me.BTNinicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNinicio.Name = "BTNinicio"
        Me.BTNinicio.Padding = New System.Windows.Forms.Padding(13, 0, 0, 0)
        Me.BTNinicio.Size = New System.Drawing.Size(312, 55)
        Me.BTNinicio.TabIndex = 11
        Me.BTNinicio.Text = "Inicio"
        Me.BTNinicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PanelLOGO
        '
        Me.PanelLOGO.BackColor = System.Drawing.Color.Transparent
        Me.PanelLOGO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PanelLOGO.Controls.Add(Me.Guna2PictureBox1)
        Me.PanelLOGO.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLOGO.Location = New System.Drawing.Point(0, 0)
        Me.PanelLOGO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLOGO.Name = "PanelLOGO"
        Me.PanelLOGO.Size = New System.Drawing.Size(312, 142)
        Me.PanelLOGO.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(312, 138)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Temporizado
        '
        '
        'panelContenedor
        '
        Me.panelContenedor.Controls.Add(Me.BTNcerrar)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(333, 0)
        Me.panelContenedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(1194, 805)
        Me.panelContenedor.TabIndex = 13
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
        Me.BTNcerrar.Location = New System.Drawing.Point(1135, 0)
        Me.BTNcerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(59, 46)
        Me.BTNcerrar.TabIndex = 10
        Me.BTNcerrar.Text = "X"
        '
        'FrmMenuProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1527, 805)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.BTNmiPerfil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmMenuProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuEstudiante"
        Me.BTNmiPerfil.ResumeLayout(False)
        Me.panelReportes.ResumeLayout(False)
        Me.panelPreguntas.ResumeLayout(False)
        Me.panelCategorias.ResumeLayout(False)
        Me.panelTemas.ResumeLayout(False)
        Me.PanelLOGO.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNmiPerfil As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Temporizado As Timer
    Friend WithEvents PanelLOGO As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelContenedor As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNinicio As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNtemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelTemas As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcrearTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNbuscarTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeliminarTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeditarTemas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelCategorias As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNbuscarCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeliminarCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeditarCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcrearCategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcategorias As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelPreguntas As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNbuscarPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeliminarPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNactualizarPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcrearPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNreportes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNpreguntas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelReportes As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNasignarCalificacion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcrearReportes As Guna.UI2.WinForms.Guna2Button
End Class
