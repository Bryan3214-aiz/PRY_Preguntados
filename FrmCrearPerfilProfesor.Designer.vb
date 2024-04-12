<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrearPerfilProfesor
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
        Me.LabelbienvenidaProfesor = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
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
        Me.BTNcrearPerfilProfesor = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Guna2Panel1.SuspendLayout()
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
        Me.LabelbienvenidaProfesor.TabIndex = 33
        Me.LabelbienvenidaProfesor.Text = "Registro de nuevos profesores"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.TXTpatron)
        Me.Guna2Panel1.Controls.Add(Me.Label13)
        Me.Guna2Panel1.Controls.Add(Me.TXTcontrasena)
        Me.Guna2Panel1.Controls.Add(Me.BTNfotoSeleccionar)
        Me.Guna2Panel1.Controls.Add(Me.Label6)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.TXTnombre)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.TXTidentifacion)
        Me.Guna2Panel1.Controls.Add(Me.TXTcorreo)
        Me.Guna2Panel1.Controls.Add(Me.BTNcrearPerfilProfesor)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(895, 539)
        Me.Guna2Panel1.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(471, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 36)
        Me.Label1.TabIndex = 43
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
        Me.TXTpatron.Location = New System.Drawing.Point(640, 68)
        Me.TXTpatron.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTpatron.Name = "TXTpatron"
        Me.TXTpatron.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTpatron.PlaceholderText = "Digite un patron de seguridad"
        Me.TXTpatron.SelectedText = ""
        Me.TXTpatron.Size = New System.Drawing.Size(220, 36)
        Me.TXTpatron.TabIndex = 42
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label13.Location = New System.Drawing.Point(38, 226)
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
        Me.TXTcontrasena.Location = New System.Drawing.Point(224, 222)
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
        Me.BTNfotoSeleccionar.BackColor = System.Drawing.Color.Transparent
        Me.BTNfotoSeleccionar.FillColor = System.Drawing.Color.DimGray
        Me.BTNfotoSeleccionar.Image = Global.PRY_Preguntados.My.Resources.Resources.img_usuario
        Me.BTNfotoSeleccionar.ImageRotate = 0!
        Me.BTNfotoSeleccionar.Location = New System.Drawing.Point(535, 194)
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
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(491, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(275, 53)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Seleccione una foto "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(50, 68)
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
        Me.TXTnombre.Location = New System.Drawing.Point(224, 68)
        Me.TXTnombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTnombre.Name = "TXTnombre"
        Me.TXTnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTnombre.PlaceholderText = "Digite su nombre completo"
        Me.TXTnombre.SelectedText = ""
        Me.TXTnombre.Size = New System.Drawing.Size(220, 36)
        Me.TXTnombre.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(43, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 36)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Identificación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(55, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 36)
        Me.Label2.TabIndex = 34
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
        Me.TXTidentifacion.Location = New System.Drawing.Point(224, 308)
        Me.TXTidentifacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTidentifacion.Name = "TXTidentifacion"
        Me.TXTidentifacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTidentifacion.PlaceholderText = "Digite su identificación personal"
        Me.TXTidentifacion.SelectedText = ""
        Me.TXTidentifacion.Size = New System.Drawing.Size(220, 36)
        Me.TXTidentifacion.TabIndex = 33
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
        Me.TXTcorreo.Location = New System.Drawing.Point(224, 146)
        Me.TXTcorreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTcorreo.Name = "TXTcorreo"
        Me.TXTcorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcorreo.PlaceholderText = "Digite un correo electrónico"
        Me.TXTcorreo.SelectedText = ""
        Me.TXTcorreo.Size = New System.Drawing.Size(220, 36)
        Me.TXTcorreo.TabIndex = 32
        '
        'BTNcrearPerfilProfesor
        '
        Me.BTNcrearPerfilProfesor.Animated = True
        Me.BTNcrearPerfilProfesor.BackColor = System.Drawing.Color.Lavender
        Me.BTNcrearPerfilProfesor.BorderRadius = 10
        Me.BTNcrearPerfilProfesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearPerfilProfesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearPerfilProfesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearPerfilProfesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearPerfilProfesor.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTNcrearPerfilProfesor.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.BTNcrearPerfilProfesor.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTNcrearPerfilProfesor.Location = New System.Drawing.Point(680, 430)
        Me.BTNcrearPerfilProfesor.Name = "BTNcrearPerfilProfesor"
        Me.BTNcrearPerfilProfesor.Size = New System.Drawing.Size(180, 60)
        Me.BTNcrearPerfilProfesor.TabIndex = 31
        Me.BTNcrearPerfilProfesor.Text = "Crear usuario"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmCrearPerfilProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCrearPerfilProfesor"
        Me.Text = "FrmCrearPerfilProfesor"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.BTNfotoSeleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BTNcrearPerfilProfesor As Guna.UI2.WinForms.Guna2Button
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
End Class
