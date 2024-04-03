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
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNimgEstaticaCategoria = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTcategoria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.LabelbienvenidaProfesor.Name = "LabelbienvenidaProfesor"
        Me.LabelbienvenidaProfesor.Size = New System.Drawing.Size(895, 122)
        Me.LabelbienvenidaProfesor.TabIndex = 32
        Me.LabelbienvenidaProfesor.Text = "Registro de categorias"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.BTNimgEstaticaCategoria)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.TXTcategoria)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 122)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(895, 532)
        Me.Guna2Panel1.TabIndex = 33
        '
        'Guna2Button6
        '
        Me.Guna2Button6.Animated = True
        Me.Guna2Button6.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Button6.BorderRadius = 10
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.Guna2Button6.Font = New System.Drawing.Font("Showcard Gothic", 12.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button6.Location = New System.Drawing.Point(680, 430)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(180, 60)
        Me.Guna2Button6.TabIndex = 31
        Me.Guna2Button6.Text = "Crear categoria"
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
        Me.Guna2ComboBox1.Location = New System.Drawing.Point(620, 78)
        Me.Guna2ComboBox1.Name = "Guna2ComboBox1"
        Me.Guna2ComboBox1.Size = New System.Drawing.Size(220, 36)
        Me.Guna2ComboBox1.TabIndex = 30
        '
        'Guna2Button5
        '
        Me.Guna2Button5.Animated = True
        Me.Guna2Button5.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Button5.BorderRadius = 15
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button5.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.Guna2Button5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button5.Location = New System.Drawing.Point(526, 296)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(195, 70)
        Me.Guna2Button5.TabIndex = 29
        Me.Guna2Button5.Text = "Video de la categoria"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Button4.BorderRadius = 15
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button4.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button4.Location = New System.Drawing.Point(188, 296)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(195, 70)
        Me.Guna2Button4.TabIndex = 28
        Me.Guna2Button4.Text = "Audio de la categoria"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Button3.BorderRadius = 15
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button3.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button3.Location = New System.Drawing.Point(646, 187)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(195, 70)
        Me.Guna2Button3.TabIndex = 27
        Me.Guna2Button3.Text = "Sonido de la categoria"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Button2.BorderRadius = 15
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Button2.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Guna2Button2.Location = New System.Drawing.Point(354, 187)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(195, 70)
        Me.Guna2Button2.TabIndex = 26
        Me.Guna2Button2.Text = "Imagen animada de la categoria"
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
        Me.BTNimgEstaticaCategoria.Location = New System.Drawing.Point(63, 187)
        Me.BTNimgEstaticaCategoria.Name = "BTNimgEstaticaCategoria"
        Me.BTNimgEstaticaCategoria.Size = New System.Drawing.Size(195, 70)
        Me.BTNimgEstaticaCategoria.TabIndex = 25
        Me.BTNimgEstaticaCategoria.Text = "Imagen estática de la categoria"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(46, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 36)
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
        Me.TXTcategoria.Location = New System.Drawing.Point(208, 78)
        Me.TXTcategoria.Name = "TXTcategoria"
        Me.TXTcategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTcategoria.PlaceholderText = "Digite el nombre de la categoria "
        Me.TXTcategoria.SelectedText = ""
        Me.TXTcategoria.Size = New System.Drawing.Size(220, 36)
        Me.TXTcategoria.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(419, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 67)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Seleccione un tema: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCrearCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNimgEstaticaCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
End Class
