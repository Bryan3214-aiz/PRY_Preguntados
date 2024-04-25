<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuPartidaEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPartidaEstudiante))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.CMBseleccionarFRM = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNvolver = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcomenzar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.CMBseleccionarFRM)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.BTNvolver)
        Me.Guna2Panel1.Controls.Add(Me.BTNcomenzar)
        Me.Guna2Panel1.Controls.Add(Me.BTNcerrar)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(520, 300)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(78, 35)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(362, 61)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 33
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'CMBseleccionarFRM
        '
        Me.CMBseleccionarFRM.BackColor = System.Drawing.Color.Transparent
        Me.CMBseleccionarFRM.BorderRadius = 10
        Me.CMBseleccionarFRM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBseleccionarFRM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBseleccionarFRM.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarFRM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarFRM.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBseleccionarFRM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBseleccionarFRM.ItemHeight = 30
        Me.CMBseleccionarFRM.Location = New System.Drawing.Point(234, 127)
        Me.CMBseleccionarFRM.Name = "CMBseleccionarFRM"
        Me.CMBseleccionarFRM.Size = New System.Drawing.Size(220, 36)
        Me.CMBseleccionarFRM.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(45, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 73)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Seleccione un formulario: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNvolver
        '
        Me.BTNvolver.Animated = True
        Me.BTNvolver.BackColor = System.Drawing.Color.Transparent
        Me.BTNvolver.BorderRadius = 10
        Me.BTNvolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNvolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNvolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNvolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNvolver.FillColor = System.Drawing.Color.DimGray
        Me.BTNvolver.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNvolver.ForeColor = System.Drawing.Color.White
        Me.BTNvolver.Location = New System.Drawing.Point(304, 213)
        Me.BTNvolver.Name = "BTNvolver"
        Me.BTNvolver.Size = New System.Drawing.Size(150, 41)
        Me.BTNvolver.TabIndex = 19
        Me.BTNvolver.Text = "Volver al menú principal"
        Me.BTNvolver.UseTransparentBackground = True
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
        Me.BTNcomenzar.Location = New System.Drawing.Point(92, 213)
        Me.BTNcomenzar.Name = "BTNcomenzar"
        Me.BTNcomenzar.Size = New System.Drawing.Size(150, 41)
        Me.BTNcomenzar.TabIndex = 18
        Me.BTNcomenzar.Text = "Iniciar partida"
        Me.BTNcomenzar.UseTransparentBackground = True
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
        Me.BTNcerrar.Location = New System.Drawing.Point(476, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 16
        Me.BTNcerrar.Text = "X"
        '
        'Temporizado
        '
        '
        'FrmMenuPartidaEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(520, 300)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuPartidaEstudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenuPartidaEstudiante"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Temporizado As Timer
    Friend WithEvents BTNvolver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcomenzar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBseleccionarFRM As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
