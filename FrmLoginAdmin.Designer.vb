<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLoginAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoginAdmin))
        Me.TXTcorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTcontrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNiniciar = New Guna.UI2.WinForms.Guna2Button()
        Me.panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNvolverMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.panel.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTcorreo
        '
        Me.TXTcorreo.BackColor = System.Drawing.Color.Transparent
        Me.TXTcorreo.BorderRadius = 10
        Me.TXTcorreo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTcorreo.DefaultText = ""
        Me.TXTcorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTcorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTcorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcorreo.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTcorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcorreo.Location = New System.Drawing.Point(263, 113)
        Me.TXTcorreo.Name = "TXTcorreo"
        Me.TXTcorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcorreo.PlaceholderText = "Digite un correo electrónico"
        Me.TXTcorreo.SelectedText = ""
        Me.TXTcorreo.Size = New System.Drawing.Size(211, 36)
        Me.TXTcorreo.TabIndex = 1
        '
        'TXTcontrasena
        '
        Me.TXTcontrasena.BackColor = System.Drawing.Color.Transparent
        Me.TXTcontrasena.BorderRadius = 10
        Me.TXTcontrasena.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTcontrasena.DefaultText = ""
        Me.TXTcontrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTcontrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTcontrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcontrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcontrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcontrasena.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTcontrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcontrasena.Location = New System.Drawing.Point(263, 169)
        Me.TXTcontrasena.Name = "TXTcontrasena"
        Me.TXTcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTcontrasena.PlaceholderText = "Digite una contraseña"
        Me.TXTcontrasena.SelectedText = ""
        Me.TXTcontrasena.Size = New System.Drawing.Size(211, 36)
        Me.TXTcontrasena.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(555, 101)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BIENVENIDO A PREGUNTADOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(77, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Correo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(77, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contraseña:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNiniciar
        '
        Me.BTNiniciar.Animated = True
        Me.BTNiniciar.BackColor = System.Drawing.Color.Transparent
        Me.BTNiniciar.BorderRadius = 10
        Me.BTNiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNiniciar.FillColor = System.Drawing.Color.SeaGreen
        Me.BTNiniciar.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNiniciar.ForeColor = System.Drawing.Color.White
        Me.BTNiniciar.Location = New System.Drawing.Point(375, 224)
        Me.BTNiniciar.Name = "BTNiniciar"
        Me.BTNiniciar.Size = New System.Drawing.Size(150, 41)
        Me.BTNiniciar.TabIndex = 8
        Me.BTNiniciar.Text = "Iniciar sesión "
        Me.BTNiniciar.UseTransparentBackground = True
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.Controls.Add(Me.BTNiniciar)
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.TXTcontrasena)
        Me.panel.Controls.Add(Me.TXTcorreo)
        Me.panel.Location = New System.Drawing.Point(103, 40)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(560, 304)
        Me.panel.TabIndex = 10
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
        Me.BTNcerrar.Location = New System.Drawing.Point(724, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 11
        Me.BTNcerrar.Text = "X"
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.Transparent
        Me.panel2.Controls.Add(Me.BTNvolverMenu)
        Me.panel2.Controls.Add(Me.panel)
        Me.panel2.Controls.Add(Me.BTNcerrar)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(768, 402)
        Me.panel2.TabIndex = 12
        '
        'BTNvolverMenu
        '
        Me.BTNvolverMenu.Animated = True
        Me.BTNvolverMenu.BackColor = System.Drawing.Color.Transparent
        Me.BTNvolverMenu.BorderColor = System.Drawing.Color.Transparent
        Me.BTNvolverMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNvolverMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNvolverMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNvolverMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNvolverMenu.FillColor = System.Drawing.Color.CadetBlue
        Me.BTNvolverMenu.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNvolverMenu.ForeColor = System.Drawing.Color.White
        Me.BTNvolverMenu.HoverState.FillColor = System.Drawing.Color.DimGray
        Me.BTNvolverMenu.Image = CType(resources.GetObject("BTNvolverMenu.Image"), System.Drawing.Image)
        Me.BTNvolverMenu.Location = New System.Drawing.Point(0, 0)
        Me.BTNvolverMenu.Name = "BTNvolverMenu"
        Me.BTNvolverMenu.Size = New System.Drawing.Size(44, 37)
        Me.BTNvolverMenu.TabIndex = 13
        '
        'FrmLoginAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 402)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLoginAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLoginAdmin"
        Me.panel.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNiniciar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTcontrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTcorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNvolverMenu As Guna.UI2.WinForms.Guna2Button
End Class
