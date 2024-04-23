<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarPerfilProfesor
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
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNguardarCambios = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNeditarInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTpatron = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTcontrasena = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNfotoSeleccionar = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTnombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTidentifacion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXTcorreo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TXTNOMBRESUCURSAL = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.BTNfotoSeleccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelbienvenidaProfesor
        '
        Me.LabelbienvenidaProfesor.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelbienvenidaProfesor.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelbienvenidaProfesor.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelbienvenidaProfesor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelbienvenidaProfesor.Location = New System.Drawing.Point(0, 0)
        Me.LabelbienvenidaProfesor.Name = "LabelbienvenidaProfesor"
        Me.LabelbienvenidaProfesor.Size = New System.Drawing.Size(895, 115)
        Me.LabelbienvenidaProfesor.TabIndex = 34
        Me.LabelbienvenidaProfesor.Text = "Actualizar registros de profesores"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L
        '
        Me.L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.L.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.ForeColor = System.Drawing.SystemColors.WindowText
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.L.HideSelection = False
        Me.L.HoverSelection = True
        Me.L.Location = New System.Drawing.Point(31, 191)
        Me.L.Margin = New System.Windows.Forms.Padding(50)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Scrollable = False
        Me.L.Size = New System.Drawing.Size(832, 126)
        Me.L.TabIndex = 39
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
        Me.ColumnHeader2.Text = "Profesor"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Correo"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "identificación"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 175
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Contraseña"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Patrón"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 150
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
        Me.BTNguardarCambios.Location = New System.Drawing.Point(209, 329)
        Me.BTNguardarCambios.Name = "BTNguardarCambios"
        Me.BTNguardarCambios.Size = New System.Drawing.Size(150, 41)
        Me.BTNguardarCambios.TabIndex = 41
        Me.BTNguardarCambios.Text = "Guardar cambios "
        Me.BTNguardarCambios.UseTransparentBackground = True
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
        Me.BTNeditarInfo.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.BTNeditarInfo.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeditarInfo.ForeColor = System.Drawing.Color.White
        Me.BTNeditarInfo.Location = New System.Drawing.Point(31, 329)
        Me.BTNeditarInfo.Name = "BTNeditarInfo"
        Me.BTNeditarInfo.Size = New System.Drawing.Size(150, 41)
        Me.BTNeditarInfo.TabIndex = 40
        Me.BTNeditarInfo.Text = "Editar información"
        Me.BTNeditarInfo.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(437, 356)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 36)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Patron:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTpatron
        '
        Me.TXTpatron.BackColor = System.Drawing.Color.Transparent
        Me.TXTpatron.BorderRadius = 10
        Me.TXTpatron.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTpatron.DefaultText = ""
        Me.TXTpatron.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTpatron.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTpatron.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTpatron.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTpatron.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTpatron.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTpatron.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTpatron.Location = New System.Drawing.Point(606, 356)
        Me.TXTpatron.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTpatron.Name = "TXTpatron"
        Me.TXTpatron.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTpatron.PlaceholderText = "Digite un patron de seguridad"
        Me.TXTpatron.SelectedText = ""
        Me.TXTpatron.Size = New System.Drawing.Size(220, 36)
        Me.TXTpatron.TabIndex = 54
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label13.Location = New System.Drawing.Point(23, 509)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(180, 36)
        Me.Label13.TabIndex = 53
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
        Me.TXTcontrasena.Location = New System.Drawing.Point(209, 505)
        Me.TXTcontrasena.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcontrasena.Name = "TXTcontrasena"
        Me.TXTcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTcontrasena.PlaceholderText = "Digite una contraseña"
        Me.TXTcontrasena.SelectedText = ""
        Me.TXTcontrasena.Size = New System.Drawing.Size(220, 36)
        Me.TXTcontrasena.TabIndex = 52
        '
        'BTNfotoSeleccionar
        '
        Me.BTNfotoSeleccionar.BackColor = System.Drawing.Color.Transparent
        Me.BTNfotoSeleccionar.FillColor = System.Drawing.Color.DimGray
        Me.BTNfotoSeleccionar.Image = Global.PRY_Preguntados.My.Resources.Resources.img_usuario
        Me.BTNfotoSeleccionar.ImageRotate = 0!
        Me.BTNfotoSeleccionar.Location = New System.Drawing.Point(569, 452)
        Me.BTNfotoSeleccionar.Name = "BTNfotoSeleccionar"
        Me.BTNfotoSeleccionar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BTNfotoSeleccionar.Size = New System.Drawing.Size(182, 161)
        Me.BTNfotoSeleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNfotoSeleccionar.TabIndex = 50
        Me.BTNfotoSeleccionar.TabStop = False
        Me.BTNfotoSeleccionar.UseTransparentBackground = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(525, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(275, 53)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Seleccione una foto "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(35, 396)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 36)
        Me.Label5.TabIndex = 49
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
        Me.TXTnombre.Location = New System.Drawing.Point(209, 396)
        Me.TXTnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTnombre.PlaceholderText = "Digite su nombre completo"
        Me.TXTnombre.SelectedText = ""
        Me.TXTnombre.Size = New System.Drawing.Size(220, 36)
        Me.TXTnombre.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(28, 560)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 36)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Identificación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(40, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 36)
        Me.Label2.TabIndex = 46
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
        Me.TXTidentifacion.Location = New System.Drawing.Point(209, 560)
        Me.TXTidentifacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTidentifacion.Name = "TXTidentifacion"
        Me.TXTidentifacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTidentifacion.PlaceholderText = "Digite su identificación personal"
        Me.TXTidentifacion.SelectedText = ""
        Me.TXTidentifacion.Size = New System.Drawing.Size(220, 36)
        Me.TXTidentifacion.TabIndex = 45
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
        Me.TXTcorreo.Location = New System.Drawing.Point(209, 451)
        Me.TXTcorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcorreo.Name = "TXTcorreo"
        Me.TXTcorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcorreo.PlaceholderText = "Digite un correo electrónico"
        Me.TXTcorreo.SelectedText = ""
        Me.TXTcorreo.Size = New System.Drawing.Size(220, 36)
        Me.TXTcorreo.TabIndex = 44
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TXTNOMBRESUCURSAL
        '
        Me.TXTNOMBRESUCURSAL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTNOMBRESUCURSAL.BorderRadius = 15
        Me.TXTNOMBRESUCURSAL.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNOMBRESUCURSAL.DefaultText = ""
        Me.TXTNOMBRESUCURSAL.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTNOMBRESUCURSAL.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTNOMBRESUCURSAL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOMBRESUCURSAL.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOMBRESUCURSAL.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBRESUCURSAL.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.TXTNOMBRESUCURSAL.ForeColor = System.Drawing.Color.DimGray
        Me.TXTNOMBRESUCURSAL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBRESUCURSAL.Location = New System.Drawing.Point(31, 133)
        Me.TXTNOMBRESUCURSAL.Name = "TXTNOMBRESUCURSAL"
        Me.TXTNOMBRESUCURSAL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNOMBRESUCURSAL.PlaceholderText = "Filtrar resultados por el nombre del profesor"
        Me.TXTNOMBRESUCURSAL.SelectedText = ""
        Me.TXTNOMBRESUCURSAL.Size = New System.Drawing.Size(831, 42)
        Me.TXTNOMBRESUCURSAL.TabIndex = 56
        '
        'FrmActualizarPerfilProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.TXTNOMBRESUCURSAL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTpatron)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXTcontrasena)
        Me.Controls.Add(Me.BTNfotoSeleccionar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTidentifacion)
        Me.Controls.Add(Me.TXTcorreo)
        Me.Controls.Add(Me.BTNguardarCambios)
        Me.Controls.Add(Me.BTNeditarInfo)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmActualizarPerfilProfesor"
        Me.Text = "FrmActualizarPerfilProfesor"
        CType(Me.BTNfotoSeleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents BTNguardarCambios As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNeditarInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTpatron As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTcontrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNfotoSeleccionar As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTnombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTidentifacion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTcorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TXTNOMBRESUCURSAL As Guna.UI2.WinForms.Guna2TextBox
End Class
