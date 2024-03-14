<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOPCIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOPCIONES))
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.Panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNadmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNestudiante = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNprofesor = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Temporizado
        '
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Transparent
        Me.Panel.Controls.Add(Me.BTNcerrar)
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.BTNadmin)
        Me.Panel.Controls.Add(Me.BTNestudiante)
        Me.Panel.Controls.Add(Me.BTNprofesor)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(768, 402)
        Me.Panel.TabIndex = 0
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
        Me.BTNcerrar.TabIndex = 19
        Me.BTNcerrar.Text = "X"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(67, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(619, 91)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "¿Cómo deseas iniciar partida?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNadmin
        '
        Me.BTNadmin.Animated = True
        Me.BTNadmin.BackColor = System.Drawing.Color.Transparent
        Me.BTNadmin.BorderRadius = 10
        Me.BTNadmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNadmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNadmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNadmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNadmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNadmin.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNadmin.ForeColor = System.Drawing.Color.White
        Me.BTNadmin.Location = New System.Drawing.Point(499, 179)
        Me.BTNadmin.Name = "BTNadmin"
        Me.BTNadmin.Size = New System.Drawing.Size(187, 76)
        Me.BTNadmin.TabIndex = 17
        Me.BTNadmin.Text = "Administrador"
        Me.BTNadmin.UseTransparentBackground = True
        '
        'BTNestudiante
        '
        Me.BTNestudiante.Animated = True
        Me.BTNestudiante.BackColor = System.Drawing.Color.Transparent
        Me.BTNestudiante.BorderRadius = 10
        Me.BTNestudiante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNestudiante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNestudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNestudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNestudiante.FillColor = System.Drawing.Color.CornflowerBlue
        Me.BTNestudiante.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNestudiante.ForeColor = System.Drawing.Color.White
        Me.BTNestudiante.Location = New System.Drawing.Point(283, 179)
        Me.BTNestudiante.Name = "BTNestudiante"
        Me.BTNestudiante.Size = New System.Drawing.Size(187, 76)
        Me.BTNestudiante.TabIndex = 16
        Me.BTNestudiante.Text = "Estudiante"
        Me.BTNestudiante.UseTransparentBackground = True
        '
        'BTNprofesor
        '
        Me.BTNprofesor.Animated = True
        Me.BTNprofesor.BackColor = System.Drawing.Color.Transparent
        Me.BTNprofesor.BorderRadius = 10
        Me.BTNprofesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNprofesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNprofesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNprofesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNprofesor.FillColor = System.Drawing.Color.SeaGreen
        Me.BTNprofesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNprofesor.ForeColor = System.Drawing.Color.White
        Me.BTNprofesor.Location = New System.Drawing.Point(67, 179)
        Me.BTNprofesor.Name = "BTNprofesor"
        Me.BTNprofesor.Size = New System.Drawing.Size(187, 76)
        Me.BTNprofesor.TabIndex = 15
        Me.BTNprofesor.Text = "Profesor"
        Me.BTNprofesor.UseTransparentBackground = True
        '
        'FrmOPCIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 402)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOPCIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmOPCIONES"
        Me.Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Temporizado As Timer
    Friend WithEvents Panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNadmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNestudiante As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNprofesor As Guna.UI2.WinForms.Guna2Button
End Class
