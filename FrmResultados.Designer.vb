<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmResultados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmResultados))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNvolver = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblNombreEstudiante = New System.Windows.Forms.Label()
        Me.LbLNombreCategoria = New System.Windows.Forms.Label()
        Me.LblPuntaje = New System.Windows.Forms.Label()
        Me.LblDuracion = New System.Windows.Forms.Label()
        Me.LblRsCorrectas = New System.Windows.Forms.Label()
        Me.LblRsIncorrectas = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.BTNvolver)
        Me.Guna2Panel1.Controls.Add(Me.BTNcerrar)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Temporizado
        '
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
        Me.BTNcerrar.Location = New System.Drawing.Point(756, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 17
        Me.BTNcerrar.Text = "X"
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
        Me.BTNvolver.Location = New System.Drawing.Point(552, 382)
        Me.BTNvolver.Name = "BTNvolver"
        Me.BTNvolver.Size = New System.Drawing.Size(150, 41)
        Me.BTNvolver.TabIndex = 20
        Me.BTNvolver.Text = "Volver al menú principal"
        Me.BTNvolver.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(186, 26)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(416, 74)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 34
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.LblRsIncorrectas)
        Me.Guna2Panel2.Controls.Add(Me.LblRsCorrectas)
        Me.Guna2Panel2.Controls.Add(Me.LblDuracion)
        Me.Guna2Panel2.Controls.Add(Me.LblPuntaje)
        Me.Guna2Panel2.Controls.Add(Me.LbLNombreCategoria)
        Me.Guna2Panel2.Controls.Add(Me.LblNombreEstudiante)
        Me.Guna2Panel2.Controls.Add(Me.Label6)
        Me.Guna2Panel2.Controls.Add(Me.Label4)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Controls.Add(Me.Label2)
        Me.Guna2Panel2.Controls.Add(Me.Label1)
        Me.Guna2Panel2.Controls.Add(Me.Label5)
        Me.Guna2Panel2.Location = New System.Drawing.Point(93, 106)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(609, 261)
        Me.Guna2Panel2.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(319, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 60)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Duración:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-5, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 60)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Categoría:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(3, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 60)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nombre del estudiante:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(319, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 60)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Respuestas correctas:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(-5, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 60)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Puntaje:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(319, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 60)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Respuestas incorrectas:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblNombreEstudiante
        '
        Me.LblNombreEstudiante.BackColor = System.Drawing.Color.Transparent
        Me.LblNombreEstudiante.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreEstudiante.ForeColor = System.Drawing.SystemColors.Control
        Me.LblNombreEstudiante.Location = New System.Drawing.Point(178, 20)
        Me.LblNombreEstudiante.Name = "LblNombreEstudiante"
        Me.LblNombreEstudiante.Size = New System.Drawing.Size(135, 60)
        Me.LblNombreEstudiante.TabIndex = 34
        Me.LblNombreEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbLNombreCategoria
        '
        Me.LbLNombreCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LbLNombreCategoria.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLNombreCategoria.ForeColor = System.Drawing.SystemColors.Control
        Me.LbLNombreCategoria.Location = New System.Drawing.Point(178, 89)
        Me.LbLNombreCategoria.Name = "LbLNombreCategoria"
        Me.LbLNombreCategoria.Size = New System.Drawing.Size(135, 60)
        Me.LbLNombreCategoria.TabIndex = 35
        Me.LbLNombreCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblPuntaje
        '
        Me.LblPuntaje.BackColor = System.Drawing.Color.Transparent
        Me.LblPuntaje.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPuntaje.ForeColor = System.Drawing.SystemColors.Control
        Me.LblPuntaje.Location = New System.Drawing.Point(178, 162)
        Me.LblPuntaje.Name = "LblPuntaje"
        Me.LblPuntaje.Size = New System.Drawing.Size(135, 60)
        Me.LblPuntaje.TabIndex = 36
        Me.LblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDuracion
        '
        Me.LblDuracion.BackColor = System.Drawing.Color.Transparent
        Me.LblDuracion.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDuracion.ForeColor = System.Drawing.SystemColors.Control
        Me.LblDuracion.Location = New System.Drawing.Point(478, 20)
        Me.LblDuracion.Name = "LblDuracion"
        Me.LblDuracion.Size = New System.Drawing.Size(116, 60)
        Me.LblDuracion.TabIndex = 38
        Me.LblDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRsCorrectas
        '
        Me.LblRsCorrectas.BackColor = System.Drawing.Color.Transparent
        Me.LblRsCorrectas.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRsCorrectas.ForeColor = System.Drawing.SystemColors.Control
        Me.LblRsCorrectas.Location = New System.Drawing.Point(478, 102)
        Me.LblRsCorrectas.Name = "LblRsCorrectas"
        Me.LblRsCorrectas.Size = New System.Drawing.Size(116, 60)
        Me.LblRsCorrectas.TabIndex = 39
        Me.LblRsCorrectas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRsIncorrectas
        '
        Me.LblRsIncorrectas.BackColor = System.Drawing.Color.Transparent
        Me.LblRsIncorrectas.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRsIncorrectas.ForeColor = System.Drawing.SystemColors.Control
        Me.LblRsIncorrectas.Location = New System.Drawing.Point(478, 171)
        Me.LblRsIncorrectas.Name = "LblRsIncorrectas"
        Me.LblRsIncorrectas.Size = New System.Drawing.Size(116, 60)
        Me.LblRsIncorrectas.TabIndex = 40
        Me.LblRsIncorrectas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmResultados"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Temporizado As Timer
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNvolver As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LblRsIncorrectas As Label
    Friend WithEvents LblRsCorrectas As Label
    Friend WithEvents LblDuracion As Label
    Friend WithEvents LblPuntaje As Label
    Friend WithEvents LbLNombreCategoria As Label
    Friend WithEvents LblNombreEstudiante As Label
End Class
