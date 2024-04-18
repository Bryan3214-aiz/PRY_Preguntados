<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVerDatosRegistradosEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVerDatosRegistradosEstudiante))
        Me.panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CMBperiodo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CMBseccion = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CMBasignatura = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CMBcursolectivo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTcontrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNfotoSeleccionar = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTnombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTidentifacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CMBgrado = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTcorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNguardarCambios = New Guna.UI2.WinForms.Guna2Button()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNeditarInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcomenzarJuego = New Guna.UI2.WinForms.Guna2Button()
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.panel1.SuspendLayout()
        CType(Me.BTNfotoSeleccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.Label12)
        Me.panel1.Controls.Add(Me.CMBperiodo)
        Me.panel1.Controls.Add(Me.Label10)
        Me.panel1.Controls.Add(Me.CMBseccion)
        Me.panel1.Controls.Add(Me.Label9)
        Me.panel1.Controls.Add(Me.CMBasignatura)
        Me.panel1.Controls.Add(Me.Label8)
        Me.panel1.Controls.Add(Me.CMBcursolectivo)
        Me.panel1.Controls.Add(Me.Label13)
        Me.panel1.Controls.Add(Me.TXTcontrasena)
        Me.panel1.Controls.Add(Me.BTNfotoSeleccionar)
        Me.panel1.Controls.Add(Me.Label6)
        Me.panel1.Controls.Add(Me.Label5)
        Me.panel1.Controls.Add(Me.TXTnombre)
        Me.panel1.Controls.Add(Me.BTNcerrar)
        Me.panel1.Controls.Add(Me.Label4)
        Me.panel1.Controls.Add(Me.Label3)
        Me.panel1.Controls.Add(Me.Label2)
        Me.panel1.Controls.Add(Me.TXTidentifacion)
        Me.panel1.Controls.Add(Me.CMBgrado)
        Me.panel1.Controls.Add(Me.TXTcorreo)
        Me.panel1.Controls.Add(Me.BTNguardarCambios)
        Me.panel1.Controls.Add(Me.L)
        Me.panel1.Controls.Add(Me.BTNeditarInfo)
        Me.panel1.Controls.Add(Me.BTNcomenzarJuego)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1248, 641)
        Me.panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(140, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 67)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Seleccione su periodo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBperiodo
        '
        Me.CMBperiodo.BackColor = System.Drawing.Color.Transparent
        Me.CMBperiodo.BorderRadius = 5
        Me.CMBperiodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBperiodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBperiodo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBperiodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBperiodo.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBperiodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBperiodo.ItemHeight = 30
        Me.CMBperiodo.Items.AddRange(New Object() {"Primer Trimestre", "Segundo Trimestre", "Tercer Trimestre"})
        Me.CMBperiodo.Location = New System.Drawing.Point(345, 401)
        Me.CMBperiodo.Name = "CMBperiodo"
        Me.CMBperiodo.Size = New System.Drawing.Size(220, 36)
        Me.CMBperiodo.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(143, 457)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 67)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Seleccione sección"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBseccion
        '
        Me.CMBseccion.BackColor = System.Drawing.Color.Transparent
        Me.CMBseccion.BorderRadius = 5
        Me.CMBseccion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBseccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBseccion.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseccion.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBseccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBseccion.ItemHeight = 30
        Me.CMBseccion.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.CMBseccion.Location = New System.Drawing.Point(345, 472)
        Me.CMBseccion.Name = "CMBseccion"
        Me.CMBseccion.Size = New System.Drawing.Size(220, 36)
        Me.CMBseccion.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(129, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 67)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Seleccione su asignatura"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBasignatura
        '
        Me.CMBasignatura.BackColor = System.Drawing.Color.Transparent
        Me.CMBasignatura.BorderRadius = 5
        Me.CMBasignatura.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBasignatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBasignatura.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBasignatura.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBasignatura.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBasignatura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBasignatura.ItemHeight = 30
        Me.CMBasignatura.Items.AddRange(New Object() {"Informática", "Diseño Gráfico", "Inglés Conversacional", "Contabilidad", "Diseño Publicitario", "Técnicas Secretariales"})
        Me.CMBasignatura.Location = New System.Drawing.Point(345, 334)
        Me.CMBasignatura.Name = "CMBasignatura"
        Me.CMBasignatura.Size = New System.Drawing.Size(220, 36)
        Me.CMBasignatura.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(129, 262)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(210, 67)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Seleccione su grado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBcursolectivo
        '
        Me.CMBcursolectivo.BackColor = System.Drawing.Color.Transparent
        Me.CMBcursolectivo.BorderRadius = 5
        Me.CMBcursolectivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBcursolectivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBcursolectivo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBcursolectivo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBcursolectivo.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBcursolectivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBcursolectivo.ItemHeight = 30
        Me.CMBcursolectivo.Items.AddRange(New Object() {"2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.CMBcursolectivo.Location = New System.Drawing.Point(345, 205)
        Me.CMBcursolectivo.Name = "CMBcursolectivo"
        Me.CMBcursolectivo.Size = New System.Drawing.Size(220, 36)
        Me.CMBcursolectivo.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(654, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 36)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Contraseña:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TXTcontrasena.Location = New System.Drawing.Point(852, 205)
        Me.TXTcontrasena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcontrasena.Name = "TXTcontrasena"
        Me.TXTcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTcontrasena.PlaceholderText = "Digite una contraseña"
        Me.TXTcontrasena.SelectedText = ""
        Me.TXTcontrasena.Size = New System.Drawing.Size(220, 36)
        Me.TXTcontrasena.TabIndex = 40
        '
        'BTNfotoSeleccionar
        '
        Me.BTNfotoSeleccionar.FillColor = System.Drawing.Color.DimGray
        Me.BTNfotoSeleccionar.Image = CType(resources.GetObject("BTNfotoSeleccionar.Image"), System.Drawing.Image)
        Me.BTNfotoSeleccionar.ImageRotate = 0!
        Me.BTNfotoSeleccionar.Location = New System.Drawing.Point(757, 411)
        Me.BTNfotoSeleccionar.Name = "BTNfotoSeleccionar"
        Me.BTNfotoSeleccionar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNfotoSeleccionar.Size = New System.Drawing.Size(182, 161)
        Me.BTNfotoSeleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNfotoSeleccionar.TabIndex = 38
        Me.BTNfotoSeleccionar.TabStop = False
        Me.BTNfotoSeleccionar.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(712, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 53)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Seleccione una foto "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(654, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 36)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTnombre
        '
        Me.TXTnombre.BackColor = System.Drawing.Color.Transparent
        Me.TXTnombre.BorderRadius = 10
        Me.TXTnombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTnombre.DefaultText = ""
        Me.TXTnombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTnombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTnombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTnombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTnombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTnombre.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXTnombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTnombre.Location = New System.Drawing.Point(852, 262)
        Me.TXTnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTnombre.PlaceholderText = "Digite su nombre completo"
        Me.TXTnombre.SelectedText = ""
        Me.TXTnombre.Size = New System.Drawing.Size(220, 36)
        Me.TXTnombre.TabIndex = 36
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
        Me.BTNcerrar.Location = New System.Drawing.Point(1204, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 35
        Me.BTNcerrar.Text = "X"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(129, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 67)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Seleccione el curso lectivo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(144, 536)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 36)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Identificación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(642, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 36)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Correo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTidentifacion
        '
        Me.TXTidentifacion.BackColor = System.Drawing.Color.Transparent
        Me.TXTidentifacion.BorderRadius = 10
        Me.TXTidentifacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTidentifacion.DefaultText = ""
        Me.TXTidentifacion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTidentifacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTidentifacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTidentifacion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTidentifacion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTidentifacion.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTidentifacion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTidentifacion.Location = New System.Drawing.Point(345, 536)
        Me.TXTidentifacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTidentifacion.Name = "TXTidentifacion"
        Me.TXTidentifacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTidentifacion.PlaceholderText = "Digite su identificación personal"
        Me.TXTidentifacion.SelectedText = ""
        Me.TXTidentifacion.Size = New System.Drawing.Size(220, 36)
        Me.TXTidentifacion.TabIndex = 31
        '
        'CMBgrado
        '
        Me.CMBgrado.BackColor = System.Drawing.Color.Transparent
        Me.CMBgrado.BorderRadius = 5
        Me.CMBgrado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBgrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBgrado.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBgrado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBgrado.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBgrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBgrado.ItemHeight = 30
        Me.CMBgrado.Items.AddRange(New Object() {"Sétimo", "Octavo", "Noveno", "Décimo", "Undécimo", "Duodécimo"})
        Me.CMBgrado.Location = New System.Drawing.Point(345, 273)
        Me.CMBgrado.Name = "CMBgrado"
        Me.CMBgrado.Size = New System.Drawing.Size(220, 36)
        Me.CMBgrado.TabIndex = 30
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
        Me.TXTcorreo.Location = New System.Drawing.Point(852, 323)
        Me.TXTcorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcorreo.Name = "TXTcorreo"
        Me.TXTcorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcorreo.PlaceholderText = "Digite un correo electrónico"
        Me.TXTcorreo.SelectedText = ""
        Me.TXTcorreo.Size = New System.Drawing.Size(220, 36)
        Me.TXTcorreo.TabIndex = 29
        '
        'BTNguardarCambios
        '
        Me.BTNguardarCambios.Animated = True
        Me.BTNguardarCambios.BackColor = System.Drawing.Color.Transparent
        Me.BTNguardarCambios.BorderRadius = 10
        Me.BTNguardarCambios.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNguardarCambios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNguardarCambios.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNguardarCambios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNguardarCambios.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNguardarCambios.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNguardarCambios.ForeColor = System.Drawing.Color.White
        Me.BTNguardarCambios.Location = New System.Drawing.Point(1070, 577)
        Me.BTNguardarCambios.Name = "BTNguardarCambios"
        Me.BTNguardarCambios.Size = New System.Drawing.Size(150, 41)
        Me.BTNguardarCambios.TabIndex = 28
        Me.BTNguardarCambios.Text = "Guardar cambios "
        Me.BTNguardarCambios.UseTransparentBackground = True
        '
        'L
        '
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.L.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.L.HideSelection = False
        Me.L.Location = New System.Drawing.Point(49, 86)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Scrollable = False
        Me.L.Size = New System.Drawing.Size(1142, 41)
        Me.L.TabIndex = 27
        Me.L.UseCompatibleStateImageBehavior = False
        Me.L.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Curso Lectivo"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 100
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Grado"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Asignatura"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Periodo"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sección"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Identificación"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 150
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nombre Completo"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 200
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Correo"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Contraseña"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 120
        '
        'BTNeditarInfo
        '
        Me.BTNeditarInfo.Animated = True
        Me.BTNeditarInfo.BackColor = System.Drawing.Color.Transparent
        Me.BTNeditarInfo.BorderRadius = 10
        Me.BTNeditarInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeditarInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeditarInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeditarInfo.Enabled = False
        Me.BTNeditarInfo.FillColor = System.Drawing.Color.DimGray
        Me.BTNeditarInfo.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarInfo.ForeColor = System.Drawing.Color.White
        Me.BTNeditarInfo.Location = New System.Drawing.Point(223, 144)
        Me.BTNeditarInfo.Name = "BTNeditarInfo"
        Me.BTNeditarInfo.Size = New System.Drawing.Size(150, 41)
        Me.BTNeditarInfo.TabIndex = 10
        Me.BTNeditarInfo.Text = "Editar información"
        Me.BTNeditarInfo.UseTransparentBackground = True
        '
        'BTNcomenzarJuego
        '
        Me.BTNcomenzarJuego.Animated = True
        Me.BTNcomenzarJuego.BackColor = System.Drawing.Color.Transparent
        Me.BTNcomenzarJuego.BorderRadius = 10
        Me.BTNcomenzarJuego.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcomenzarJuego.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcomenzarJuego.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcomenzarJuego.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcomenzarJuego.FillColor = System.Drawing.Color.SeaGreen
        Me.BTNcomenzarJuego.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcomenzarJuego.ForeColor = System.Drawing.Color.White
        Me.BTNcomenzarJuego.Location = New System.Drawing.Point(49, 144)
        Me.BTNcomenzarJuego.Name = "BTNcomenzarJuego"
        Me.BTNcomenzarJuego.Size = New System.Drawing.Size(150, 41)
        Me.BTNcomenzarJuego.TabIndex = 9
        Me.BTNcomenzarJuego.Text = "Comenzar a jugar "
        Me.BTNcomenzarJuego.UseTransparentBackground = True
        '
        'Temporizado
        '
        '
        'FrmVerDatosRegistradosEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1248, 641)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmVerDatosRegistradosEstudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVerDatosRegistradosEstudiante"
        Me.panel1.ResumeLayout(False)
        CType(Me.BTNfotoSeleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNeditarInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNcomenzarJuego As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Temporizado As Timer
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents BTNguardarCambios As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label12 As Label
    Friend WithEvents CMBperiodo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CMBseccion As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CMBasignatura As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CMBcursolectivo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTcontrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNfotoSeleccionar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTnombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTidentifacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CMBgrado As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TXTcorreo As Guna.UI2.WinForms.Guna2TextBox
End Class
