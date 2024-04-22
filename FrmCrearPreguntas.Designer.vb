<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearPreguntas
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
        Me.CMBseleccionarCate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTpregunta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_OPC_DOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_OPC_TRES = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_OPC_UNO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_OPC_CUATRO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNcrearPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BTN_OPCIONES = New Guna.UI2.WinForms.Guna2Button()
        Me.LBL_IDPREG = New System.Windows.Forms.Label()
        Me.TXT_ID_PREGUNTA = New System.Windows.Forms.TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Guna2TextBox6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Guna2TextBox7 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelbienvenidaProfesor.TabIndex = 33
        Me.LabelbienvenidaProfesor.Text = "Registrar nuevas preguntas"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMBseleccionarCate
        '
        Me.CMBseleccionarCate.BackColor = System.Drawing.Color.Transparent
        Me.CMBseleccionarCate.BorderRadius = 10
        Me.CMBseleccionarCate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMBseleccionarCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBseleccionarCate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarCate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMBseleccionarCate.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMBseleccionarCate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMBseleccionarCate.ItemHeight = 30
        Me.CMBseleccionarCate.Location = New System.Drawing.Point(241, 51)
        Me.CMBseleccionarCate.Name = "CMBseleccionarCate"
        Me.CMBseleccionarCate.Size = New System.Drawing.Size(220, 36)
        Me.CMBseleccionarCate.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(30, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 67)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Seleccione una categoría: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(467, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 36)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Pregunta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTpregunta
        '
        Me.TXTpregunta.Animated = True
        Me.TXTpregunta.BackColor = System.Drawing.Color.Transparent
        Me.TXTpregunta.BorderRadius = 10
        Me.TXTpregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTpregunta.DefaultText = ""
        Me.TXTpregunta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTpregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTpregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTpregunta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTpregunta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTpregunta.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXTpregunta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTpregunta.Location = New System.Drawing.Point(629, 51)
        Me.TXTpregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTpregunta.Name = "TXTpregunta"
        Me.TXTpregunta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTpregunta.PlaceholderText = "Digite la pregunta"
        Me.TXTpregunta.SelectedText = ""
        Me.TXTpregunta.Size = New System.Drawing.Size(220, 36)
        Me.TXTpregunta.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(76, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Respuesta 2:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_OPC_DOS
        '
        Me.TXT_OPC_DOS.Animated = True
        Me.TXT_OPC_DOS.BackColor = System.Drawing.Color.Transparent
        Me.TXT_OPC_DOS.BorderRadius = 10
        Me.TXT_OPC_DOS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_OPC_DOS.DefaultText = ""
        Me.TXT_OPC_DOS.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_OPC_DOS.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_OPC_DOS.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_DOS.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_DOS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_DOS.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXT_OPC_DOS.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_DOS.Location = New System.Drawing.Point(242, 268)
        Me.TXT_OPC_DOS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_DOS.Name = "TXT_OPC_DOS"
        Me.TXT_OPC_DOS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_DOS.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_DOS.SelectedText = ""
        Me.TXT_OPC_DOS.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_DOS.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(74, 323)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 36)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Respuesta 3:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_OPC_TRES
        '
        Me.TXT_OPC_TRES.Animated = True
        Me.TXT_OPC_TRES.BackColor = System.Drawing.Color.Transparent
        Me.TXT_OPC_TRES.BorderRadius = 10
        Me.TXT_OPC_TRES.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_OPC_TRES.DefaultText = ""
        Me.TXT_OPC_TRES.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_OPC_TRES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_OPC_TRES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_TRES.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_TRES.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_TRES.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXT_OPC_TRES.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_TRES.Location = New System.Drawing.Point(242, 323)
        Me.TXT_OPC_TRES.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_TRES.Name = "TXT_OPC_TRES"
        Me.TXT_OPC_TRES.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_TRES.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_TRES.SelectedText = ""
        Me.TXT_OPC_TRES.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_TRES.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(76, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 36)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Respuesta 1:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_OPC_UNO
        '
        Me.TXT_OPC_UNO.Animated = True
        Me.TXT_OPC_UNO.BackColor = System.Drawing.Color.Transparent
        Me.TXT_OPC_UNO.BorderRadius = 10
        Me.TXT_OPC_UNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_OPC_UNO.DefaultText = ""
        Me.TXT_OPC_UNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_OPC_UNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_OPC_UNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_UNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_UNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_UNO.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXT_OPC_UNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_UNO.Location = New System.Drawing.Point(242, 212)
        Me.TXT_OPC_UNO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_UNO.Name = "TXT_OPC_UNO"
        Me.TXT_OPC_UNO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_UNO.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_UNO.SelectedText = ""
        Me.TXT_OPC_UNO.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_UNO.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(74, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 36)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Respuesta 4:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_OPC_CUATRO
        '
        Me.TXT_OPC_CUATRO.Animated = True
        Me.TXT_OPC_CUATRO.BackColor = System.Drawing.Color.Transparent
        Me.TXT_OPC_CUATRO.BorderRadius = 10
        Me.TXT_OPC_CUATRO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_OPC_CUATRO.DefaultText = ""
        Me.TXT_OPC_CUATRO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_OPC_CUATRO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_OPC_CUATRO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_CUATRO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_OPC_CUATRO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_CUATRO.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.TXT_OPC_CUATRO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_OPC_CUATRO.Location = New System.Drawing.Point(242, 382)
        Me.TXT_OPC_CUATRO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_CUATRO.Name = "TXT_OPC_CUATRO"
        Me.TXT_OPC_CUATRO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_CUATRO.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_CUATRO.SelectedText = ""
        Me.TXT_OPC_CUATRO.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_CUATRO.TabIndex = 44
        '
        'BTNcrearPregunta
        '
        Me.BTNcrearPregunta.Animated = True
        Me.BTNcrearPregunta.BackColor = System.Drawing.Color.Lavender
        Me.BTNcrearPregunta.BorderRadius = 10
        Me.BTNcrearPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearPregunta.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNcrearPregunta.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNcrearPregunta.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNcrearPregunta.Location = New System.Drawing.Point(461, 461)
        Me.BTNcrearPregunta.Name = "BTNcrearPregunta"
        Me.BTNcrearPregunta.Size = New System.Drawing.Size(180, 60)
        Me.BTNcrearPregunta.TabIndex = 46
        Me.BTNcrearPregunta.Text = "Crear pregunta"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox2.Location = New System.Drawing.Point(774, 272)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PRY_Preguntados.My.Resources.Resources.CORRECTA__1_
        Me.PictureBox1.Location = New System.Drawing.Point(774, 216)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox3.Location = New System.Drawing.Point(774, 327)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox4.Location = New System.Drawing.Point(774, 386)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 50
        Me.PictureBox4.TabStop = False
        '
        'BTN_OPCIONES
        '
        Me.BTN_OPCIONES.Animated = True
        Me.BTN_OPCIONES.BackColor = System.Drawing.Color.Lavender
        Me.BTN_OPCIONES.BorderRadius = 10
        Me.BTN_OPCIONES.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONES.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONES.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCIONES.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCIONES.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN_OPCIONES.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTN_OPCIONES.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_OPCIONES.Location = New System.Drawing.Point(669, 461)
        Me.BTN_OPCIONES.Name = "BTN_OPCIONES"
        Me.BTN_OPCIONES.Size = New System.Drawing.Size(180, 60)
        Me.BTN_OPCIONES.TabIndex = 51
        Me.BTN_OPCIONES.Text = "Crear opciones"
        '
        'LBL_IDPREG
        '
        Me.LBL_IDPREG.AutoSize = True
        Me.LBL_IDPREG.Location = New System.Drawing.Point(639, 280)
        Me.LBL_IDPREG.Name = "LBL_IDPREG"
        Me.LBL_IDPREG.Size = New System.Drawing.Size(0, 13)
        Me.LBL_IDPREG.TabIndex = 52
        '
        'TXT_ID_PREGUNTA
        '
        Me.TXT_ID_PREGUNTA.Location = New System.Drawing.Point(520, 249)
        Me.TXT_ID_PREGUNTA.Name = "TXT_ID_PREGUNTA"
        Me.TXT_ID_PREGUNTA.Size = New System.Drawing.Size(0, 20)
        Me.TXT_ID_PREGUNTA.TabIndex = 53
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TXTpregunta)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.CMBseleccionarCate)
        Me.Guna2Panel1.Controls.Add(Me.BTN_OPCIONES)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox3)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_UNO)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.BTNcrearPregunta)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_DOS)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_CUATRO)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_TRES)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(895, 550)
        Me.Guna2Panel1.TabIndex = 54
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox7)
        Me.Guna2Panel2.Controls.Add(Me.Label14)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox6)
        Me.Guna2Panel2.Controls.Add(Me.Label13)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel2.Controls.Add(Me.Label7)
        Me.Guna2Panel2.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.Label8)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox5)
        Me.Guna2Panel2.Controls.Add(Me.Label9)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox6)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox7)
        Me.Guna2Panel2.Controls.Add(Me.PictureBox8)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Controls.Add(Me.Label11)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox4)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox5)
        Me.Guna2Panel2.Controls.Add(Me.Label12)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 115)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(895, 550)
        Me.Guna2Panel2.TabIndex = 55
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Animated = True
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
        Me.Guna2TextBox1.Location = New System.Drawing.Point(629, 51)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = "Digite la pregunta"
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(220, 36)
        Me.Guna2TextBox1.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label7.Location = New System.Drawing.Point(30, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 67)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Seleccione una categoría: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2ComboBox1
        '
        Me.Guna2ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ComboBox1.BorderRadius = 10
        Me.Guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2ComboBox1.ItemHeight = 30
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(241, 51)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(220, 36)
        Me.Guna2ComboBox1.TabIndex = 35
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button1.Location = New System.Drawing.Point(669, 461)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 60)
        Me.Guna2Button1.TabIndex = 51
        Me.Guna2Button1.Text = "Crear opciones"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label8.Location = New System.Drawing.Point(467, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(156, 36)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Pregunta:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox5.Location = New System.Drawing.Point(774, 386)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 50
        Me.PictureBox5.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label9.Location = New System.Drawing.Point(76, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 36)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Respuesta 1:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox6.Location = New System.Drawing.Point(774, 327)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 49
        Me.PictureBox6.TabStop = False
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Animated = True
        Me.Guna2TextBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox2.BorderRadius = 10
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(242, 212)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = "Digite una opción de respuesta"
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(514, 36)
        Me.Guna2TextBox2.TabIndex = 42
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox7.Location = New System.Drawing.Point(774, 272)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 48
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.PRY_Preguntados.My.Resources.Resources.CORRECTA__1_
        Me.PictureBox8.Location = New System.Drawing.Point(774, 216)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 47
        Me.PictureBox8.TabStop = False
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.Guna2Button2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button2.Location = New System.Drawing.Point(461, 461)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(180, 60)
        Me.Guna2Button2.TabIndex = 46
        Me.Guna2Button2.Text = "Crear pregunta"
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.Animated = True
        Me.Guna2TextBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox3.BorderRadius = 10
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(242, 268)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = "Digite una opción de respuesta"
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(514, 36)
        Me.Guna2TextBox3.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label10.Location = New System.Drawing.Point(74, 382)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(166, 36)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Respuesta 4:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label11.Location = New System.Drawing.Point(76, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(163, 36)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Respuesta 2:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.Animated = True
        Me.Guna2TextBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox4.BorderRadius = 10
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(242, 382)
        Me.Guna2TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = "Digite una opción de respuesta"
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(514, 36)
        Me.Guna2TextBox4.TabIndex = 44
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.Animated = True
        Me.Guna2TextBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox5.BorderRadius = 10
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = ""
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Location = New System.Drawing.Point(242, 323)
        Me.Guna2TextBox5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderText = "Digite una opción de respuesta"
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(514, 36)
        Me.Guna2TextBox5.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label12.Location = New System.Drawing.Point(74, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(162, 36)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Respuesta 3:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2TextBox6
        '
        Me.Guna2TextBox6.Animated = True
        Me.Guna2TextBox6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox6.BorderRadius = 10
        Me.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox6.DefaultText = ""
        Me.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Location = New System.Drawing.Point(242, 134)
        Me.Guna2TextBox6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox6.Name = "Guna2TextBox6"
        Me.Guna2TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox6.PlaceholderText = "Digite la pregunta"
        Me.Guna2TextBox6.SelectedText = ""
        Me.Guna2TextBox6.Size = New System.Drawing.Size(219, 36)
        Me.Guna2TextBox6.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label13.Location = New System.Drawing.Point(54, 134)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 36)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Pregunta:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2TextBox7
        '
        Me.Guna2TextBox7.Animated = True
        Me.Guna2TextBox7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox7.BorderRadius = 10
        Me.Guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox7.DefaultText = ""
        Me.Guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.Font = New System.Drawing.Font("Showcard Gothic", 8.25!)
        Me.Guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.Location = New System.Drawing.Point(629, 134)
        Me.Guna2TextBox7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox7.Name = "Guna2TextBox7"
        Me.Guna2TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox7.PlaceholderText = "Digite la pregunta"
        Me.Guna2TextBox7.SelectedText = ""
        Me.Guna2TextBox7.Size = New System.Drawing.Size(220, 36)
        Me.Guna2TextBox7.TabIndex = 54
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label14.Location = New System.Drawing.Point(467, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(156, 36)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Pregunta:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCrearPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 665)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.TXT_ID_PREGUNTA)
        Me.Controls.Add(Me.LBL_IDPREG)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCrearPreguntas"
        Me.Text = "FrmCrearPreguntas"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents CMBseleccionarCate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTpregunta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_OPC_DOS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_OPC_TRES As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_OPC_UNO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_OPC_CUATRO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNcrearPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BTN_OPCIONES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LBL_IDPREG As Label
    Friend WithEvents TXT_ID_PREGUNTA As TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox7 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Guna2TextBox6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
End Class
