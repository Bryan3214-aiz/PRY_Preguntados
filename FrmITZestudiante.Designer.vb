<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmITZestudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmITZestudiante))
        Me.panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNeditar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNiniciar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.BorderRadius = 100
        Me.panel.Controls.Add(Me.BTNeditar)
        Me.panel.Controls.Add(Me.BTNcerrar)
        Me.panel.Controls.Add(Me.BTNiniciar)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Location = New System.Drawing.Point(112, 70)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(544, 261)
        Me.panel.TabIndex = 1
        '
        'BTNeditar
        '
        Me.BTNeditar.BackColor = System.Drawing.Color.Transparent
        Me.BTNeditar.BorderRadius = 10
        Me.BTNeditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeditar.FillColor = System.Drawing.Color.DodgerBlue
        Me.BTNeditar.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditar.ForeColor = System.Drawing.Color.White
        Me.BTNeditar.Location = New System.Drawing.Point(199, 166)
        Me.BTNeditar.Name = "BTNeditar"
        Me.BTNeditar.Size = New System.Drawing.Size(150, 41)
        Me.BTNeditar.TabIndex = 10
        Me.BTNeditar.Text = "Editar información"
        '
        'BTNcerrar
        '
        Me.BTNcerrar.BackColor = System.Drawing.Color.Transparent
        Me.BTNcerrar.BorderRadius = 10
        Me.BTNcerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcerrar.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNcerrar.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNcerrar.ForeColor = System.Drawing.Color.White
        Me.BTNcerrar.Location = New System.Drawing.Point(379, 166)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(150, 41)
        Me.BTNcerrar.TabIndex = 9
        Me.BTNcerrar.Text = "Salir del juego"
        '
        'BTNiniciar
        '
        Me.BTNiniciar.BackColor = System.Drawing.Color.Transparent
        Me.BTNiniciar.BorderRadius = 10
        Me.BTNiniciar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNiniciar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNiniciar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNiniciar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNiniciar.FillColor = System.Drawing.Color.SeaGreen
        Me.BTNiniciar.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNiniciar.ForeColor = System.Drawing.Color.White
        Me.BTNiniciar.Location = New System.Drawing.Point(18, 166)
        Me.BTNiniciar.Name = "BTNiniciar"
        Me.BTNiniciar.Size = New System.Drawing.Size(150, 41)
        Me.BTNiniciar.TabIndex = 8
        Me.BTNiniciar.Text = "Iniciar partida"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(3, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 101)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "MENU PRINCIPAL"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Temporizado
        '
        '
        'FrmITZestudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 402)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmITZestudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PREGUNTADOS"
        Me.panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNiniciar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNeditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Temporizado As Timer
End Class
