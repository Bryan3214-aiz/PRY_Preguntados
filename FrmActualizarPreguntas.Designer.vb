﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmActualizarPreguntas
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
        Me.TXTpregunta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTN_OPCIONES = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TXT_OPC_UNO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXT_OPC_DOS = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_OPC_CUATRO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_OPC_TRES = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelbienvenidaProfesor.TabIndex = 46
        Me.LabelbienvenidaProfesor.Text = "Actualizar preguntas y sus opciones"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.TXTpregunta)
        Me.Guna2Panel1.Controls.Add(Me.Label7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.BTN_OPCIONES)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox4)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox3)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_UNO)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_DOS)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_CUATRO)
        Me.Guna2Panel1.Controls.Add(Me.TXT_OPC_TRES)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(895, 539)
        Me.Guna2Panel1.TabIndex = 55
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
        Me.TXTpregunta.Location = New System.Drawing.Point(242, 115)
        Me.TXTpregunta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTpregunta.Name = "TXTpregunta"
        Me.TXTpregunta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTpregunta.PlaceholderText = "Digite la pregunta"
        Me.TXTpregunta.SelectedText = ""
        Me.TXTpregunta.Size = New System.Drawing.Size(514, 36)
        Me.TXTpregunta.TabIndex = 36
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
        Me.BTN_OPCIONES.Location = New System.Drawing.Point(648, 424)
        Me.BTN_OPCIONES.Name = "BTN_OPCIONES"
        Me.BTN_OPCIONES.Size = New System.Drawing.Size(180, 60)
        Me.BTN_OPCIONES.TabIndex = 51
        Me.BTN_OPCIONES.Text = "Actualizar preguntas"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(74, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 36)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Pregunta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox4.Location = New System.Drawing.Point(774, 342)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 50
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(76, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 36)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Respuesta 1:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox3.Location = New System.Drawing.Point(774, 283)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 49
        Me.PictureBox3.TabStop = False
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
        Me.TXT_OPC_UNO.Location = New System.Drawing.Point(242, 168)
        Me.TXT_OPC_UNO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_UNO.Name = "TXT_OPC_UNO"
        Me.TXT_OPC_UNO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_UNO.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_UNO.SelectedText = ""
        Me.TXT_OPC_UNO.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_UNO.TabIndex = 42
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PRY_Preguntados.My.Resources.Resources.png_transparent_x_red_mark_incorrect_thumbnail__1_
        Me.PictureBox2.Location = New System.Drawing.Point(774, 228)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PRY_Preguntados.My.Resources.Resources.CORRECTA__1_
        Me.PictureBox1.Location = New System.Drawing.Point(774, 172)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
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
        Me.TXT_OPC_DOS.Location = New System.Drawing.Point(242, 224)
        Me.TXT_OPC_DOS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_DOS.Name = "TXT_OPC_DOS"
        Me.TXT_OPC_DOS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_DOS.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_DOS.SelectedText = ""
        Me.TXT_OPC_DOS.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_DOS.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(74, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 36)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Respuesta 4:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(76, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Respuesta 2:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TXT_OPC_CUATRO.Location = New System.Drawing.Point(242, 338)
        Me.TXT_OPC_CUATRO.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_CUATRO.Name = "TXT_OPC_CUATRO"
        Me.TXT_OPC_CUATRO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_CUATRO.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_CUATRO.SelectedText = ""
        Me.TXT_OPC_CUATRO.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_CUATRO.TabIndex = 44
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
        Me.TXT_OPC_TRES.Location = New System.Drawing.Point(242, 279)
        Me.TXT_OPC_TRES.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXT_OPC_TRES.Name = "TXT_OPC_TRES"
        Me.TXT_OPC_TRES.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_OPC_TRES.PlaceholderText = "Digite una opción de respuesta"
        Me.TXT_OPC_TRES.SelectedText = ""
        Me.TXT_OPC_TRES.Size = New System.Drawing.Size(514, 36)
        Me.TXT_OPC_TRES.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(74, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 36)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Respuesta 3:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(461, 44)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(220, 36)
        Me.Guna2ComboBox1.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label7.Location = New System.Drawing.Point(114, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(341, 67)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Seleccione una pregunta para modificarla: "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmActualizarPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmActualizarPreguntas"
        Me.Text = "FrmActualizarPreguntas"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TXTpregunta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTN_OPCIONES As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TXT_OPC_UNO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TXT_OPC_DOS As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_OPC_CUATRO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_OPC_TRES As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
End Class
