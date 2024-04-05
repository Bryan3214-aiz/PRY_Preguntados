<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAdministrador))
        Me.BTNinfoPRO = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.BTNcerrarSesion = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNbuscarProfesor = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeliminarProfesor = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNactualizarProfesor = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearProfesor = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLOGO = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.panelContenedor = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.BTNinfoPRO.SuspendLayout()
        Me.PanelLOGO.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNinfoPRO
        '
        Me.BTNinfoPRO.AutoScroll = True
        Me.BTNinfoPRO.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNinfoPRO.Controls.Add(Me.BTNcerrarSesion)
        Me.BTNinfoPRO.Controls.Add(Me.BTNbuscarProfesor)
        Me.BTNinfoPRO.Controls.Add(Me.BTNeliminarProfesor)
        Me.BTNinfoPRO.Controls.Add(Me.BTNactualizarProfesor)
        Me.BTNinfoPRO.Controls.Add(Me.BTNcrearProfesor)
        Me.BTNinfoPRO.Controls.Add(Me.PanelLOGO)
        Me.BTNinfoPRO.Dock = System.Windows.Forms.DockStyle.Left
        Me.BTNinfoPRO.Location = New System.Drawing.Point(0, 0)
        Me.BTNinfoPRO.Name = "BTNinfoPRO"
        Me.BTNinfoPRO.Size = New System.Drawing.Size(250, 654)
        Me.BTNinfoPRO.TabIndex = 13
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
        Me.BTNcerrarSesion.Location = New System.Drawing.Point(0, 609)
        Me.BTNcerrarSesion.Name = "BTNcerrarSesion"
        Me.BTNcerrarSesion.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNcerrarSesion.Size = New System.Drawing.Size(250, 45)
        Me.BTNcerrarSesion.TabIndex = 17
        Me.BTNcerrarSesion.Text = "Cerrar sesión"
        Me.BTNcerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNbuscarProfesor
        '
        Me.BTNbuscarProfesor.Animated = True
        Me.BTNbuscarProfesor.BackColor = System.Drawing.Color.Teal
        Me.BTNbuscarProfesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarProfesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNbuscarProfesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNbuscarProfesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNbuscarProfesor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNbuscarProfesor.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNbuscarProfesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNbuscarProfesor.ForeColor = System.Drawing.Color.White
        Me.BTNbuscarProfesor.Location = New System.Drawing.Point(0, 250)
        Me.BTNbuscarProfesor.Name = "BTNbuscarProfesor"
        Me.BTNbuscarProfesor.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNbuscarProfesor.Size = New System.Drawing.Size(250, 45)
        Me.BTNbuscarProfesor.TabIndex = 15
        Me.BTNbuscarProfesor.Text = "Buscar perfil profesor"
        Me.BTNbuscarProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNeliminarProfesor
        '
        Me.BTNeliminarProfesor.Animated = True
        Me.BTNeliminarProfesor.BackColor = System.Drawing.Color.Teal
        Me.BTNeliminarProfesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarProfesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarProfesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeliminarProfesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeliminarProfesor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNeliminarProfesor.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNeliminarProfesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarProfesor.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarProfesor.Location = New System.Drawing.Point(0, 205)
        Me.BTNeliminarProfesor.Name = "BTNeliminarProfesor"
        Me.BTNeliminarProfesor.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNeliminarProfesor.Size = New System.Drawing.Size(250, 45)
        Me.BTNeliminarProfesor.TabIndex = 11
        Me.BTNeliminarProfesor.Text = "Eliminar perfil profesor"
        Me.BTNeliminarProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNactualizarProfesor
        '
        Me.BTNactualizarProfesor.Animated = True
        Me.BTNactualizarProfesor.BackColor = System.Drawing.Color.Teal
        Me.BTNactualizarProfesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarProfesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNactualizarProfesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNactualizarProfesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNactualizarProfesor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNactualizarProfesor.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNactualizarProfesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNactualizarProfesor.ForeColor = System.Drawing.Color.White
        Me.BTNactualizarProfesor.Location = New System.Drawing.Point(0, 160)
        Me.BTNactualizarProfesor.Name = "BTNactualizarProfesor"
        Me.BTNactualizarProfesor.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNactualizarProfesor.Size = New System.Drawing.Size(250, 45)
        Me.BTNactualizarProfesor.TabIndex = 12
        Me.BTNactualizarProfesor.Text = "Actualizar perfil profesor"
        Me.BTNactualizarProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BTNcrearProfesor
        '
        Me.BTNcrearProfesor.Animated = True
        Me.BTNcrearProfesor.BackColor = System.Drawing.Color.Transparent
        Me.BTNcrearProfesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearProfesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearProfesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearProfesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearProfesor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcrearProfesor.FillColor = System.Drawing.Color.SlateBlue
        Me.BTNcrearProfesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNcrearProfesor.ForeColor = System.Drawing.Color.White
        Me.BTNcrearProfesor.Location = New System.Drawing.Point(0, 115)
        Me.BTNcrearProfesor.Name = "BTNcrearProfesor"
        Me.BTNcrearProfesor.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BTNcrearProfesor.Size = New System.Drawing.Size(250, 45)
        Me.BTNcrearProfesor.TabIndex = 11
        Me.BTNcrearProfesor.Text = "crear perfil profesor"
        Me.BTNcrearProfesor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(250, 112)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'panelContenedor
        '
        Me.panelContenedor.Controls.Add(Me.BTNcerrar)
        Me.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenedor.Location = New System.Drawing.Point(250, 0)
        Me.panelContenedor.Name = "panelContenedor"
        Me.panelContenedor.Size = New System.Drawing.Size(895, 654)
        Me.panelContenedor.TabIndex = 14
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
        'Temporizado
        '
        '
        'FrmMenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1145, 654)
        Me.Controls.Add(Me.panelContenedor)
        Me.Controls.Add(Me.BTNinfoPRO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenuAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuAdministrador"
        Me.BTNinfoPRO.ResumeLayout(False)
        Me.PanelLOGO.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContenedor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNinfoPRO As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents BTNcerrarSesion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNbuscarProfesor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeliminarProfesor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNactualizarProfesor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcrearProfesor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelLOGO As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents panelContenedor As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Temporizado As Timer
End Class
