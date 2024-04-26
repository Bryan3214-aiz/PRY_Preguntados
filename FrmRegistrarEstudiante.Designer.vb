<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrarEstudiante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarEstudiante))
        Me.Temporizado = New System.Windows.Forms.Timer(Me.components)
        Me.panel = New Guna.UI2.WinForms.Guna2Panel()
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
        Me.BTNcrearUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTidentifacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CMBgrado = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTcorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BTNvolverMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.panel.SuspendLayout()
        CType(Me.BTNfotoSeleccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Temporizado
        '
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.BorderRadius = 100
        Me.panel.Controls.Add(Me.BTNvolverMenu)
        Me.panel.Controls.Add(Me.Label12)
        Me.panel.Controls.Add(Me.CMBperiodo)
        Me.panel.Controls.Add(Me.Label10)
        Me.panel.Controls.Add(Me.CMBseccion)
        Me.panel.Controls.Add(Me.Label9)
        Me.panel.Controls.Add(Me.CMBasignatura)
        Me.panel.Controls.Add(Me.Label8)
        Me.panel.Controls.Add(Me.CMBcursolectivo)
        Me.panel.Controls.Add(Me.Label13)
        Me.panel.Controls.Add(Me.TXTcontrasena)
        Me.panel.Controls.Add(Me.BTNfotoSeleccionar)
        Me.panel.Controls.Add(Me.Label6)
        Me.panel.Controls.Add(Me.Label5)
        Me.panel.Controls.Add(Me.TXTnombre)
        Me.panel.Controls.Add(Me.BTNcerrar)
        Me.panel.Controls.Add(Me.BTNcrearUsuario)
        Me.panel.Controls.Add(Me.Label4)
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.TXTidentifacion)
        Me.panel.Controls.Add(Me.CMBgrado)
        Me.panel.Controls.Add(Me.TXTcorreo)
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(990, 616)
        Me.panel.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(68, 342)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(187, 67)
        Me.Label12.TabIndex = 25
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
        Me.CMBperiodo.Location = New System.Drawing.Point(273, 353)
        Me.CMBperiodo.Name = "CMBperiodo"
        Me.CMBperiodo.Size = New System.Drawing.Size(220, 36)
        Me.CMBperiodo.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(71, 409)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 67)
        Me.Label10.TabIndex = 25
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
        Me.CMBseccion.Location = New System.Drawing.Point(273, 424)
        Me.CMBseccion.Name = "CMBseccion"
        Me.CMBseccion.Size = New System.Drawing.Size(220, 36)
        Me.CMBseccion.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(57, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 67)
        Me.Label9.TabIndex = 23
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
        Me.CMBasignatura.Location = New System.Drawing.Point(273, 286)
        Me.CMBasignatura.Name = "CMBasignatura"
        Me.CMBasignatura.Size = New System.Drawing.Size(220, 36)
        Me.CMBasignatura.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(57, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(210, 67)
        Me.Label8.TabIndex = 21
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
        Me.CMBcursolectivo.Location = New System.Drawing.Point(273, 157)
        Me.CMBcursolectivo.Name = "CMBcursolectivo"
        Me.CMBcursolectivo.Size = New System.Drawing.Size(220, 36)
        Me.CMBcursolectivo.TabIndex = 20
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label13.Location = New System.Drawing.Point(547, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 36)
        Me.Label13.TabIndex = 19
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
        Me.TXTcontrasena.Location = New System.Drawing.Point(745, 157)
        Me.TXTcontrasena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcontrasena.Name = "TXTcontrasena"
        Me.TXTcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTcontrasena.PlaceholderText = "Digite una contraseña"
        Me.TXTcontrasena.SelectedText = ""
        Me.TXTcontrasena.Size = New System.Drawing.Size(220, 36)
        Me.TXTcontrasena.TabIndex = 18
        '
        'BTNfotoSeleccionar
        '
        Me.BTNfotoSeleccionar.FillColor = System.Drawing.Color.DimGray
        Me.BTNfotoSeleccionar.Image = CType(resources.GetObject("BTNfotoSeleccionar.Image"), System.Drawing.Image)
        Me.BTNfotoSeleccionar.ImageRotate = 0!
        Me.BTNfotoSeleccionar.Location = New System.Drawing.Point(650, 363)
        Me.BTNfotoSeleccionar.Name = "BTNfotoSeleccionar"
        Me.BTNfotoSeleccionar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNfotoSeleccionar.Size = New System.Drawing.Size(182, 161)
        Me.BTNfotoSeleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNfotoSeleccionar.TabIndex = 16
        Me.BTNfotoSeleccionar.TabStop = False
        Me.BTNfotoSeleccionar.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(605, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(284, 53)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Seleccione una foto "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(547, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 36)
        Me.Label5.TabIndex = 14
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
        Me.TXTnombre.Location = New System.Drawing.Point(745, 214)
        Me.TXTnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTnombre.PlaceholderText = "Digite su nombre completo"
        Me.TXTnombre.SelectedText = ""
        Me.TXTnombre.Size = New System.Drawing.Size(220, 36)
        Me.TXTnombre.TabIndex = 13
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
        Me.BTNcerrar.Location = New System.Drawing.Point(946, 0)
        Me.BTNcerrar.Name = "BTNcerrar"
        Me.BTNcerrar.Size = New System.Drawing.Size(44, 37)
        Me.BTNcerrar.TabIndex = 11
        Me.BTNcerrar.Text = "X"
        '
        'BTNcrearUsuario
        '
        Me.BTNcrearUsuario.Animated = True
        Me.BTNcrearUsuario.BackColor = System.Drawing.Color.Transparent
        Me.BTNcrearUsuario.BorderRadius = 10
        Me.BTNcrearUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearUsuario.FillColor = System.Drawing.Color.SeaGreen
        Me.BTNcrearUsuario.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearUsuario.ForeColor = System.Drawing.Color.White
        Me.BTNcrearUsuario.Location = New System.Drawing.Point(815, 542)
        Me.BTNcrearUsuario.Name = "BTNcrearUsuario"
        Me.BTNcrearUsuario.Size = New System.Drawing.Size(150, 41)
        Me.BTNcrearUsuario.TabIndex = 8
        Me.BTNcrearUsuario.Text = "crear usuario"
        Me.BTNcrearUsuario.UseTransparentBackground = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(57, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 67)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Seleccione el curso lectivo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(72, 488)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Identificación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(535, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Correo:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.ImageKey = "(ninguno)"
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(990, 121)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "registrar nuevo usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TXTidentifacion.Location = New System.Drawing.Point(273, 488)
        Me.TXTidentifacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTidentifacion.Name = "TXTidentifacion"
        Me.TXTidentifacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTidentifacion.PlaceholderText = "Digite su identificación personal"
        Me.TXTidentifacion.SelectedText = ""
        Me.TXTidentifacion.Size = New System.Drawing.Size(220, 36)
        Me.TXTidentifacion.TabIndex = 3
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
        Me.CMBgrado.Location = New System.Drawing.Point(273, 225)
        Me.CMBgrado.Name = "CMBgrado"
        Me.CMBgrado.Size = New System.Drawing.Size(220, 36)
        Me.CMBgrado.TabIndex = 2
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
        Me.TXTcorreo.Location = New System.Drawing.Point(745, 275)
        Me.TXTcorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcorreo.Name = "TXTcorreo"
        Me.TXTcorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcorreo.PlaceholderText = "Digite un correo electrónico"
        Me.TXTcorreo.SelectedText = ""
        Me.TXTcorreo.Size = New System.Drawing.Size(220, 36)
        Me.TXTcorreo.TabIndex = 1
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
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
        'FrmRegistrarEstudiante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(990, 614)
        Me.Controls.Add(Me.panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistrarEstudiante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmRegistrarUsuario"
        Me.panel.ResumeLayout(False)
        CType(Me.BTNfotoSeleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Temporizado As Timer
    Friend WithEvents panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcrearUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTidentifacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CMBgrado As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTnombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTcorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CMBcursolectivo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CMBasignatura As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CMBseccion As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CMBperiodo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNfotoSeleccionar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTcontrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents BTNvolverMenu As Guna.UI2.WinForms.Guna2Button
End Class
