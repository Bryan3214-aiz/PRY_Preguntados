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
        Me.BTNinfoPRO = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BTNayuda = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNmiPerfil = New Guna.UI2.WinForms.Guna2Button()
        Me.panelReportes = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNreportes = New Guna.UI2.WinForms.Guna2Button()
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
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.panelContenedor = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTNinfoPRO.SuspendLayout()
        Me.panelReportes.SuspendLayout()
        Me.panelCategorias.SuspendLayout()
        Me.panelTemas.SuspendLayout()
        Me.PanelLOGO.SuspendLayout()
        Me.panelContenedor.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNinfoPRO
        '
        Me.BTNinfoPRO.AutoScroll = True
        Me.BTNinfoPRO.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNinfoPRO.Controls.Add(Me.BTNayuda)
        Me.BTNinfoPRO.Controls.Add(Me.BTNmiPerfil)
        Me.BTNinfoPRO.Controls.Add(Me.panelReportes)
        Me.BTNinfoPRO.Controls.Add(Me.BTNreportes)
        Me.BTNinfoPRO.Controls.Add(Me.panelCategorias)
        Me.BTNinfoPRO.Controls.Add(Me.BTNcategorias)
        Me.BTNinfoPRO.Controls.Add(Me.panelTemas)
        Me.BTNinfoPRO.Controls.Add(Me.BTNtemas)
        Me.BTNinfoPRO.Controls.Add(Me.BTNinicio)
        Me.BTNinfoPRO.Controls.Add(Me.PanelLOGO)
        Me.BTNinfoPRO.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNinfoPRO.Location = New System.Drawing.Point(0, 0)
        Me.BTNinfoPRO.Name = "BTNinfoPRO"
        Me.BTNinfoPRO.Size = New System.Drawing.Size(250, 654)
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
        Me.BTNayuda.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNayuda.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNayuda.ForeColor = System.Drawing.Color.White
        Me.BTNayuda.Location = New System.Drawing.Point(0, 766)
        Me.BTNayuda.Name = "BTNayuda"
        Me.BTNayuda.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNayuda.Size = New System.Drawing.Size(233, 45)
        Me.BTNayuda.TabIndex = 17
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
        Me.BTNmiPerfil.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNmiPerfil.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNmiPerfil.ForeColor = System.Drawing.Color.White
        Me.BTNmiPerfil.Location = New System.Drawing.Point(0, 721)
        Me.BTNmiPerfil.Name = "BTNmiPerfil"
        Me.BTNmiPerfil.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNmiPerfil.Size = New System.Drawing.Size(233, 45)
        Me.BTNmiPerfil.TabIndex = 11
        Me.BTNmiPerfil.Text = "Mi perfil"
        Me.BTNmiPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelReportes
        '
        Me.panelReportes.Controls.Add(Me.Guna2Button1)
        Me.panelReportes.Controls.Add(Me.Guna2Button2)
        Me.panelReportes.Controls.Add(Me.Guna2Button3)
        Me.panelReportes.Controls.Add(Me.Guna2Button4)
        Me.panelReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelReportes.Location = New System.Drawing.Point(0, 579)
        Me.panelReportes.Name = "panelReportes"
        Me.panelReportes.Size = New System.Drawing.Size(233, 142)
        Me.panelReportes.TabIndex = 16
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
        Me.Guna2Button1.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 105)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Guna2Button1.Size = New System.Drawing.Size(233, 37)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Buscar temas"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Button2.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button2.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(0, 70)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Guna2Button2.Size = New System.Drawing.Size(233, 35)
        Me.Guna2Button2.TabIndex = 5
        Me.Guna2Button2.Text = "Eliminar temas"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Button3.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button3.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(0, 35)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Guna2Button3.Size = New System.Drawing.Size(233, 35)
        Me.Guna2Button3.TabIndex = 4
        Me.Guna2Button3.Text = "actualizar temas"
        Me.Guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Button4.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button4.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Guna2Button4.Size = New System.Drawing.Size(233, 35)
        Me.Guna2Button4.TabIndex = 3
        Me.Guna2Button4.Text = "crear temas"
        Me.Guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.BTNreportes.Location = New System.Drawing.Point(0, 534)
        Me.BTNreportes.Name = "BTNreportes"
        Me.BTNreportes.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNreportes.Size = New System.Drawing.Size(233, 45)
        Me.BTNreportes.TabIndex = 15
        Me.BTNreportes.Text = "Reportes"
        Me.BTNreportes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'panelCategorias
        '
        Me.panelCategorias.Controls.Add(Me.BTNbuscarCategorias)
        Me.panelCategorias.Controls.Add(Me.BTNeliminarCategorias)
        Me.panelCategorias.Controls.Add(Me.BTNeditarCategorias)
        Me.panelCategorias.Controls.Add(Me.BTNcrearCategorias)
        Me.panelCategorias.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelCategorias.Location = New System.Drawing.Point(0, 392)
        Me.panelCategorias.Name = "panelCategorias"
        Me.panelCategorias.Size = New System.Drawing.Size(233, 142)
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
        Me.BTNbuscarCategorias.Location = New System.Drawing.Point(0, 105)
        Me.BTNbuscarCategorias.Name = "BTNbuscarCategorias"
        Me.BTNbuscarCategorias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNbuscarCategorias.Size = New System.Drawing.Size(233, 37)
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
        Me.BTNeliminarCategorias.Location = New System.Drawing.Point(0, 70)
        Me.BTNeliminarCategorias.Name = "BTNeliminarCategorias"
        Me.BTNeliminarCategorias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeliminarCategorias.Size = New System.Drawing.Size(233, 35)
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
        Me.BTNeditarCategorias.Location = New System.Drawing.Point(0, 35)
        Me.BTNeditarCategorias.Name = "BTNeditarCategorias"
        Me.BTNeditarCategorias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeditarCategorias.Size = New System.Drawing.Size(233, 35)
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
        Me.BTNcrearCategorias.Name = "BTNcrearCategorias"
        Me.BTNcrearCategorias.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNcrearCategorias.Size = New System.Drawing.Size(233, 35)
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
        Me.BTNcategorias.Location = New System.Drawing.Point(0, 347)
        Me.BTNcategorias.Name = "BTNcategorias"
        Me.BTNcategorias.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNcategorias.Size = New System.Drawing.Size(233, 45)
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
        Me.panelTemas.Location = New System.Drawing.Point(0, 205)
        Me.panelTemas.Name = "panelTemas"
        Me.panelTemas.Size = New System.Drawing.Size(233, 142)
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
        Me.BTNbuscarTemas.Location = New System.Drawing.Point(0, 105)
        Me.BTNbuscarTemas.Name = "BTNbuscarTemas"
        Me.BTNbuscarTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNbuscarTemas.Size = New System.Drawing.Size(233, 37)
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
        Me.BTNeliminarTemas.Location = New System.Drawing.Point(0, 70)
        Me.BTNeliminarTemas.Name = "BTNeliminarTemas"
        Me.BTNeliminarTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeliminarTemas.Size = New System.Drawing.Size(233, 35)
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
        Me.BTNeditarTemas.Location = New System.Drawing.Point(0, 35)
        Me.BTNeditarTemas.Name = "BTNeditarTemas"
        Me.BTNeditarTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNeditarTemas.Size = New System.Drawing.Size(233, 35)
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
        Me.BTNcrearTemas.Name = "BTNcrearTemas"
        Me.BTNcrearTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNcrearTemas.Size = New System.Drawing.Size(233, 35)
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
        Me.BTNtemas.Location = New System.Drawing.Point(0, 160)
        Me.BTNtemas.Name = "BTNtemas"
        Me.BTNtemas.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNtemas.Size = New System.Drawing.Size(233, 45)
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
        Me.BTNinicio.Location = New System.Drawing.Point(0, 115)
        Me.BTNinicio.Name = "BTNinicio"
        Me.BTNinicio.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNinicio.Size = New System.Drawing.Size(233, 45)
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
        Me.PanelLOGO.Name = "PanelLOGO"
        Me.PanelLOGO.Size = New System.Drawing.Size(233, 115)
        Me.PanelLOGO.TabIndex = 0
        '
        'Temporizado
        '
        '
        'panelContenedor
        '
        Me.panelContenedor.Controls.Add(Me.BTNcerrar)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(250, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(895, 654)
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
        Me.BTNcerrar.Location = New System.Drawing.Point(851, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 10
        Me.BTNcerrar.Text = "X"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(233, 112)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'FrmMenuProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1145, 654)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.BTNinfoPRO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuProfesor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuEstudiante"
        Me.BTNinfoPRO.ResumeLayout(False)
        Me.panelReportes.ResumeLayout(False)
        Me.panelCategorias.ResumeLayout(False)
        Me.panelTemas.ResumeLayout(False)
        Me.PanelLOGO.ResumeLayout(False)
        Me.panelContenedor.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNinfoPRO As Guna.UI2.WinForms.Guna2GradientPanel
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
    Friend WithEvents BTNreportes As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelReportes As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNayuda As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNmiPerfil As Guna.UI2.WinForms.Guna2Button
End Class
