<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearCategorias
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
        Me.LabelbienvenidaProfesor = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BTNcrearCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.CMBseleccionarTemaC = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BTNvideoCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNAudioVozCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNSonidoCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgAnimadaCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgEstaticaCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTcategoria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelbienvenidaProfesor
        '
        Me.LabelbienvenidaProfesor.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelbienvenidaProfesor.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelbienvenidaProfesor.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelbienvenidaProfesor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelbienvenidaProfesor.Location = New System.Drawing.Point(0, 0)
        Me.LabelbienvenidaProfesor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelbienvenidaProfesor.Name = "LabelbienvenidaProfesor"
        Me.LabelbienvenidaProfesor.Size = New System.Drawing.Size(1193, 142)
        Me.LabelbienvenidaProfesor.TabIndex = 32
        Me.LabelbienvenidaProfesor.Text = "Registrar nuevas categorias"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BTNcrearCategoria)
        Me.Guna2Panel1.Controls.Add(Me.CMBseleccionarTemaC)
        Me.Guna2Panel1.Controls.Add(Me.BTNvideoCategoria)
        Me.Guna2Panel1.Controls.Add(Me.BTNAudioVozCategoria)
        Me.Guna2Panel1.Controls.Add(Me.BTNSonidoCategoria)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgAnimadaCategoria)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgEstaticaCategoria)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.TXTcategoria)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 142)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1193, 663)
        Me.Guna2Panel1.TabIndex = 33
        '
        'BTNcrearCategoria
        '
        Me.BTNcrearCategoria.Animated = True
        Me.BTNcrearCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNcrearCategoria.BorderRadius = 10
        Me.BTNcrearCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearCategoria.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNcrearCategoria.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNcrearCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNcrearCategoria.Location = New System.Drawing.Point(907, 529)
        Me.BTNcrearCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNcrearCategoria.Name = "BTNcrearCategoria"
        Me.BTNcrearCategoria.Size = New System.Drawing.Size(240, 74)
        Me.BTNcrearCategoria.TabIndex = 31
        Me.BTNcrearCategoria.Text = "Crear categoria"
        '
        'CMBseleccionarTemaC
        '
        Me.CMBseleccionarTemaC.BackColor = System.Drawing.Color.Transparent
        Me.CMBseleccionarTemaC.BorderRadius = 10
        Me.CMBseleccionarTemaC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBseleccionarTemaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBseleccionarTemaC.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarTemaC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarTemaC.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBseleccionarTemaC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBseleccionarTemaC.ItemHeight = 30
        Me.CMBseleccionarTemaC.Location = New System.Drawing.Point(827, 96)
        Me.CMBseleccionarTemaC.Margin = New System.Windows.Forms.Padding(4)
        Me.CMBseleccionarTemaC.Name = "CMBseleccionarTemaC"
        Me.CMBseleccionarTemaC.Size = New System.Drawing.Size(292, 36)
        Me.CMBseleccionarTemaC.TabIndex = 30
        '
        'BTNvideoCategoria
        '
        Me.BTNvideoCategoria.Animated = True
        Me.BTNvideoCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNvideoCategoria.BorderRadius = 15
        Me.BTNvideoCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNvideoCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNvideoCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNvideoCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNvideoCategoria.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNvideoCategoria.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNvideoCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNvideoCategoria.Location = New System.Drawing.Point(701, 364)
        Me.BTNvideoCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNvideoCategoria.Name = "BTNvideoCategoria"
        Me.BTNvideoCategoria.Size = New System.Drawing.Size(260, 86)
        Me.BTNvideoCategoria.TabIndex = 29
        Me.BTNvideoCategoria.Text = "Video de la categoria"
        '
        'BTNAudioVozCategoria
        '
        Me.BTNAudioVozCategoria.Animated = True
        Me.BTNAudioVozCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNAudioVozCategoria.BorderRadius = 15
        Me.BTNAudioVozCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNAudioVozCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNAudioVozCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNAudioVozCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNAudioVozCategoria.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNAudioVozCategoria.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNAudioVozCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNAudioVozCategoria.Location = New System.Drawing.Point(251, 364)
        Me.BTNAudioVozCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNAudioVozCategoria.Name = "BTNAudioVozCategoria"
        Me.BTNAudioVozCategoria.Size = New System.Drawing.Size(260, 86)
        Me.BTNAudioVozCategoria.TabIndex = 28
        Me.BTNAudioVozCategoria.Text = "Audio de voz de la categoria"
        '
        'BTNSonidoCategoria
        '
        Me.BTNSonidoCategoria.Animated = True
        Me.BTNSonidoCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNSonidoCategoria.BorderRadius = 15
        Me.BTNSonidoCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNSonidoCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNSonidoCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNSonidoCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNSonidoCategoria.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNSonidoCategoria.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNSonidoCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNSonidoCategoria.Location = New System.Drawing.Point(861, 230)
        Me.BTNSonidoCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNSonidoCategoria.Name = "BTNSonidoCategoria"
        Me.BTNSonidoCategoria.Size = New System.Drawing.Size(260, 86)
        Me.BTNSonidoCategoria.TabIndex = 27
        Me.BTNSonidoCategoria.Text = "Sonido de la categoria"
        '
        'BTNimgAnimadaCategoria
        '
        Me.BTNimgAnimadaCategoria.Animated = True
        Me.BTNimgAnimadaCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNimgAnimadaCategoria.BorderRadius = 15
        Me.BTNimgAnimadaCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgAnimadaCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgAnimadaCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNimgAnimadaCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNimgAnimadaCategoria.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNimgAnimadaCategoria.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNimgAnimadaCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNimgAnimadaCategoria.Location = New System.Drawing.Point(472, 230)
        Me.BTNimgAnimadaCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNimgAnimadaCategoria.Name = "BTNimgAnimadaCategoria"
        Me.BTNimgAnimadaCategoria.Size = New System.Drawing.Size(260, 86)
        Me.BTNimgAnimadaCategoria.TabIndex = 26
        Me.BTNimgAnimadaCategoria.Text = "Imagen animada de la categoria"
        '
        'BTNimgEstaticaCategoria
        '
        Me.BTNimgEstaticaCategoria.Animated = True
        Me.BTNimgEstaticaCategoria.BackColor = System.Drawing.Color.Lavender
        Me.BTNimgEstaticaCategoria.BorderRadius = 15
        Me.BTNimgEstaticaCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgEstaticaCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNimgEstaticaCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNimgEstaticaCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNimgEstaticaCategoria.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNimgEstaticaCategoria.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTNimgEstaticaCategoria.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNimgEstaticaCategoria.Location = New System.Drawing.Point(84, 230)
        Me.BTNimgEstaticaCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNimgEstaticaCategoria.Name = "BTNimgEstaticaCategoria"
        Me.BTNimgEstaticaCategoria.Size = New System.Drawing.Size(260, 86)
        Me.BTNimgEstaticaCategoria.TabIndex = 25
        Me.BTNimgEstaticaCategoria.Text = "Imagen estática de la categoria"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(61, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 44)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Categoria:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTcategoria
        '
        Me.TXTcategoria.Animated = True
        Me.TXTcategoria.BackColor = System.Drawing.Color.Transparent
        Me.TXTcategoria.BorderRadius = 10
        Me.TXTcategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTcategoria.DefaultText = ""
        Me.TXTcategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTcategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTcategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTcategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcategoria.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXTcategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTcategoria.Location = New System.Drawing.Point(277, 96)
        Me.TXTcategoria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXTcategoria.Name = "TXTcategoria"
        Me.TXTcategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcategoria.PlaceholderText = "Digite el nombre de la categoria "
        Me.TXTcategoria.SelectedText = ""
        Me.TXTcategoria.Size = New System.Drawing.Size(293, 44)
        Me.TXTcategoria.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(559, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(280, 82)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Seleccione un tema: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCrearCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1193, 805)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCrearCategorias"
        Me.Text = "FrmCrearCategorias"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTcategoria As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNvideoCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNAudioVozCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNSonidoCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgAnimadaCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgEstaticaCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBseleccionarTemaC As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNcrearCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
