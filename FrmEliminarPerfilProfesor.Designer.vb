<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarPerfilProfesor
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
        Me.BTNeliminarProfesor = New Guna.UI2.WinForms.Guna2Button()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TXTNOMBREPROFESOR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LabelEliTemas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNeliminarProfesor
        '
        Me.BTNeliminarProfesor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNeliminarProfesor.Animated = True
        Me.BTNeliminarProfesor.BackColor = System.Drawing.Color.Transparent
        Me.BTNeliminarProfesor.BorderRadius = 10
        Me.BTNeliminarProfesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarProfesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarProfesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeliminarProfesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeliminarProfesor.Enabled = False
        Me.BTNeliminarProfesor.FillColor = System.Drawing.Color.Red
        Me.BTNeliminarProfesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarProfesor.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarProfesor.Location = New System.Drawing.Point(711, 589)
        Me.BTNeliminarProfesor.Name = "BTNeliminarProfesor"
        Me.BTNeliminarProfesor.Size = New System.Drawing.Size(150, 42)
        Me.BTNeliminarProfesor.TabIndex = 36
        Me.BTNeliminarProfesor.Text = "Eliminar"
        Me.BTNeliminarProfesor.UseTransparentBackground = True
        '
        'L
        '
        Me.L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.L.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.ForeColor = System.Drawing.SystemColors.WindowText
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.L.HideSelection = False
        Me.L.HoverSelection = True
        Me.L.Location = New System.Drawing.Point(29, 197)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(832, 380)
        Me.L.TabIndex = 35
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
        Me.ColumnHeader2.Text = "Nombre del profesor"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 275
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Correo del profesor"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 275
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Identificación"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 280
        '
        'TXTNOMBREPROFESOR
        '
        Me.TXTNOMBREPROFESOR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTNOMBREPROFESOR.BorderRadius = 15
        Me.TXTNOMBREPROFESOR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNOMBREPROFESOR.DefaultText = ""
        Me.TXTNOMBREPROFESOR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTNOMBREPROFESOR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTNOMBREPROFESOR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOMBREPROFESOR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOMBREPROFESOR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBREPROFESOR.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.TXTNOMBREPROFESOR.ForeColor = System.Drawing.Color.DimGray
        Me.TXTNOMBREPROFESOR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBREPROFESOR.Location = New System.Drawing.Point(29, 135)
        Me.TXTNOMBREPROFESOR.Name = "TXTNOMBREPROFESOR"
        Me.TXTNOMBREPROFESOR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNOMBREPROFESOR.PlaceholderText = "Ingrese el nombre del profesor"
        Me.TXTNOMBREPROFESOR.SelectedText = ""
        Me.TXTNOMBREPROFESOR.Size = New System.Drawing.Size(832, 42)
        Me.TXTNOMBREPROFESOR.TabIndex = 34
        '
        'LabelEliTemas
        '
        Me.LabelEliTemas.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelEliTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelEliTemas.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEliTemas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelEliTemas.Location = New System.Drawing.Point(0, 0)
        Me.LabelEliTemas.Name = "LabelEliTemas"
        Me.LabelEliTemas.Size = New System.Drawing.Size(895, 115)
        Me.LabelEliTemas.TabIndex = 37
        Me.LabelEliTemas.Text = "Selecciona y elimina a un profesor"
        Me.LabelEliTemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmEliminarPerfilProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.LabelEliTemas)
        Me.Controls.Add(Me.BTNeliminarProfesor)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.TXTNOMBREPROFESOR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEliminarPerfilProfesor"
        Me.Text = "FrmEliminarPerfilProfesor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNeliminarProfesor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents TXTNOMBREPROFESOR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LabelEliTemas As Label
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
