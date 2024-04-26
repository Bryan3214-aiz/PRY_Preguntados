<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuEstudiante))
        Me.panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarInfoEstudiante = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNranking = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcomenzar = New Guna.UI2.WinForms.Guna2Button()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.panel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.BorderRadius = 100
        Me.panel.Controls.Add(Me.Guna2PictureBox1)
        Me.panel.Controls.Add(Me.BTNcerrar)
        Me.panel.Controls.Add(Me.Guna2Button2)
        Me.panel.Controls.Add(Me.BTNeditarInfoEstudiante)
        Me.panel.Controls.Add(Me.Guna2Button1)
        Me.panel.Controls.Add(Me.BTNranking)
        Me.panel.Controls.Add(Me.BTNcomenzar)
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(770, 400)
        Me.panel.TabIndex = 2
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(164, 59)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(448, 71)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 16
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
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
        Me.BTNcerrar.Location = New System.Drawing.Point(726, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 15
        Me.BTNcerrar.Text = "X"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.DimGray
        Me.Guna2Button2.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(395, 219)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(150, 41)
        Me.Guna2Button2.TabIndex = 14
        Me.Guna2Button2.Text = "Funcion Y"
        Me.Guna2Button2.UseTransparentBackground = True
        '
        'BTNeditarInfoEstudiante
        '
        Me.BTNeditarInfoEstudiante.Animated = True
        Me.BTNeditarInfoEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.BTNeditarInfoEstudiante.BorderRadius = 10
        Me.BTNeditarInfoEstudiante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarInfoEstudiante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarInfoEstudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeditarInfoEstudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeditarInfoEstudiante.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNeditarInfoEstudiante.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarInfoEstudiante.ForeColor = System.Drawing.Color.White
        Me.BTNeditarInfoEstudiante.Location = New System.Drawing.Point(223, 219)
        Me.BTNeditarInfoEstudiante.Name = "BTNeditarInfoEstudiante"
        Me.BTNeditarInfoEstudiante.Size = New System.Drawing.Size(150, 41)
        Me.BTNeditarInfoEstudiante.TabIndex = 13
        Me.BTNeditarInfoEstudiante.Text = "Editar información"
        Me.BTNeditarInfoEstudiante.UseTransparentBackground = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(485, 149)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(150, 41)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "Ver mis puntaciones"
        Me.Guna2Button1.UseTransparentBackground = True
        '
        'BTNranking
        '
        Me.BTNranking.Animated = True
        Me.BTNranking.BackColor = System.Drawing.Color.Transparent
        Me.BTNranking.BorderRadius = 10
        Me.BTNranking.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNranking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNranking.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNranking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNranking.FillColor = System.Drawing.Color.Gold
        Me.BTNranking.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNranking.ForeColor = System.Drawing.Color.White
        Me.BTNranking.Location = New System.Drawing.Point(314, 149)
        Me.BTNranking.Name = "BTNranking"
        Me.BTNranking.Size = New System.Drawing.Size(150, 41)
        Me.BTNranking.TabIndex = 10
        Me.BTNranking.Text = "Ranking "
        Me.BTNranking.UseTransparentBackground = True
        '
        'BTNcomenzar
        '
        Me.BTNcomenzar.Animated = True
        Me.BTNcomenzar.BackColor = System.Drawing.Color.Transparent
        Me.BTNcomenzar.BorderRadius = 10
        Me.BTNcomenzar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcomenzar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcomenzar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcomenzar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcomenzar.FillColor = System.Drawing.Color.SeaGreen
        Me.BTNcomenzar.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcomenzar.ForeColor = System.Drawing.Color.White
        Me.BTNcomenzar.Location = New System.Drawing.Point(138, 149)
        Me.BTNcomenzar.Name = "BTNcomenzar"
        Me.BTNcomenzar.Size = New System.Drawing.Size(150, 41)
        Me.BTNcomenzar.TabIndex = 8
        Me.BTNcomenzar.Text = "Comenzar a jugar"
        Me.BTNcomenzar.UseTransparentBackground = True
        '
        'Temporizado
        '
        '
        'FrmMenuEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(770, 400)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuEstudiante"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCargarPregunta"
        Me.panel.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNranking As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcomenzar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeditarInfoEstudiante As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Temporizado As Timer
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
