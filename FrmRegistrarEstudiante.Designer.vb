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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox3 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNcerrar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNcrearUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTcontrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CMBsecciones = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TXTcorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.panel.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Temporizado
        '
        '
        'panel
        '
        Me.panel.BackColor = System.Drawing.Color.Transparent
        Me.panel.BorderRadius = 100
        Me.panel.Controls.Add(Me.Label10)
        Me.panel.Controls.Add(Me.Guna2ComboBox3)
        Me.panel.Controls.Add(Me.Label9)
        Me.panel.Controls.Add(Me.Guna2ComboBox2)
        Me.panel.Controls.Add(Me.Label8)
        Me.panel.Controls.Add(Me.Guna2ComboBox1)
        Me.panel.Controls.Add(Me.Label7)
        Me.panel.Controls.Add(Me.Guna2TextBox2)
        Me.panel.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.panel.Controls.Add(Me.Label6)
        Me.panel.Controls.Add(Me.Label5)
        Me.panel.Controls.Add(Me.Guna2TextBox1)
        Me.panel.Controls.Add(Me.BTNcerrar)
        Me.panel.Controls.Add(Me.BTNcrearUsuario)
        Me.panel.Controls.Add(Me.Label4)
        Me.panel.Controls.Add(Me.Label3)
        Me.panel.Controls.Add(Me.Label2)
        Me.panel.Controls.Add(Me.Label1)
        Me.panel.Controls.Add(Me.TXTcontrasena)
        Me.panel.Controls.Add(Me.CMBsecciones)
        Me.panel.Controls.Add(Me.TXTcorreo)
        Me.panel.Location = New System.Drawing.Point(0, 0)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(990, 616)
        Me.panel.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label10.Location = New System.Drawing.Point(515, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 67)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Seleccione su sección"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2ComboBox3
        '
        Me.Guna2ComboBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox3.BorderRadius = 5
        Me.Guna2ComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox3.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox3.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2ComboBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox3.ItemHeight = 30
        Me.Guna2ComboBox3.Items.AddRange(New Object() {"Profesor", "Estudiante"})
        Me.Guna2ComboBox3.Location = New System.Drawing.Point(745, 225)
        Me.Guna2ComboBox3.Name = "Guna2ComboBox3"
        Me.Guna2ComboBox3.Size = New System.Drawing.Size(220, 36)
        Me.Guna2ComboBox3.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(515, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(210, 67)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Seleccione su periodo"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2ComboBox2
        '
        Me.Guna2ComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox2.BorderRadius = 5
        Me.Guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox2.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox2.ItemHeight = 30
        Me.Guna2ComboBox2.Items.AddRange(New Object() {"Profesor", "Estudiante"})
        Me.Guna2ComboBox2.Location = New System.Drawing.Point(745, 157)
        Me.Guna2ComboBox2.Name = "Guna2ComboBox2"
        Me.Guna2ComboBox2.Size = New System.Drawing.Size(220, 36)
        Me.Guna2ComboBox2.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(31, 457)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(210, 67)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Seleccione su grado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderRadius = 5
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Items.AddRange(New Object() {"Profesor", "Estudiante"})
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(261, 472)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(220, 36)
        Me.Guna2ComboBox1.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(45, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 36)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Contraseña:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox2.BorderRadius = 10
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(261, 331)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Guna2TextBox2.PlaceholderText = "Digite una contraseña"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(220, 36)
        Me.Guna2TextBox2.TabIndex = 18
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.DimGray
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(564, 331)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(182, 161)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 16
        Me.Guna2CirclePictureBox1.TabStop = False
        Me.Guna2CirclePictureBox1.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(525, 281)
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
        Me.Label5.Location = New System.Drawing.Point(45, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 36)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Nombre:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderRadius = 10
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(261, 157)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Digite su nombre completo"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(220, 36)
        Me.Guna2TextBox1.TabIndex = 13
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
        Me.BTNcrearUsuario.Location = New System.Drawing.Point(828, 550)
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
        Me.Label4.Location = New System.Drawing.Point(31, 381)
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
        Me.Label3.Location = New System.Drawing.Point(45, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Identificación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(45, 214)
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
        Me.TXTcontrasena.Location = New System.Drawing.Point(261, 270)
        Me.TXTcontrasena.Name = "TXTcontrasena"
        Me.TXTcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTcontrasena.PlaceholderText = "Digite su identificación personal"
        Me.TXTcontrasena.SelectedText = ""
        Me.TXTcontrasena.Size = New System.Drawing.Size(220, 36)
        Me.TXTcontrasena.TabIndex = 3
        '
        'CMBsecciones
        '
        Me.CMBsecciones.BackColor = System.Drawing.Color.Transparent
        Me.CMBsecciones.BorderRadius = 5
        Me.CMBsecciones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBsecciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBsecciones.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBsecciones.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBsecciones.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.CMBsecciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBsecciones.ItemHeight = 30
        Me.CMBsecciones.Items.AddRange(New Object() {"Profesor", "Estudiante"})
        Me.CMBsecciones.Location = New System.Drawing.Point(261, 396)
        Me.CMBsecciones.Name = "CMBsecciones"
        Me.CMBsecciones.Size = New System.Drawing.Size(220, 36)
        Me.CMBsecciones.TabIndex = 2
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
        Me.TXTcorreo.Location = New System.Drawing.Point(261, 214)
        Me.TXTcorreo.Name = "TXTcorreo"
        Me.TXTcorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcorreo.PlaceholderText = "Digite un correo electrónico"
        Me.TXTcorreo.SelectedText = ""
        Me.TXTcorreo.Size = New System.Drawing.Size(220, 36)
        Me.TXTcorreo.TabIndex = 1
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
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Temporizado As Timer
    Friend WithEvents panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcrearUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTcontrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CMBsecciones As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BTNcerrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTcorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Guna2ComboBox2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2ComboBox3 As Guna.UI2.WinForms.Guna2ComboBox
End Class
