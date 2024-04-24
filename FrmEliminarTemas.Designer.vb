<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEliminarTemas
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
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelEliTemas = New System.Windows.Forms.Label()
        Me.TXTNOMBRESUCURSAL = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BTNeliminarTema = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'L
        '
        Me.L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.L.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.ForeColor = System.Drawing.SystemColors.WindowText
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.L.HideSelection = False
        Me.L.HoverSelection = True
        Me.L.Location = New System.Drawing.Point(30, 186)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(838, 401)
        Me.L.TabIndex = 19
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
        Me.ColumnHeader2.Text = "Nombre del tema"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 417
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Grado asignado"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 418
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
        Me.LabelEliTemas.TabIndex = 20
        Me.LabelEliTemas.Text = "Eliminar temas"
        Me.LabelEliTemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.TXTNOMBRESUCURSAL.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMBRESUCURSAL.ForeColor = System.Drawing.Color.DimGray
        Me.TXTNOMBRESUCURSAL.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBRESUCURSAL.Location = New System.Drawing.Point(30, 130)
        Me.TXTNOMBRESUCURSAL.Name = "TXTNOMBRESUCURSAL"
        Me.TXTNOMBRESUCURSAL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNOMBRESUCURSAL.PlaceholderText = "Ingrese el nombre del tema que desea eliminar"
        Me.TXTNOMBRESUCURSAL.SelectedText = ""
        Me.TXTNOMBRESUCURSAL.Size = New System.Drawing.Size(838, 42)
        Me.TXTNOMBRESUCURSAL.TabIndex = 21
        '
        'BTNeliminarTema
        '
        Me.BTNeliminarTema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNeliminarTema.Animated = True
        Me.BTNeliminarTema.BackColor = System.Drawing.Color.Transparent
        Me.BTNeliminarTema.BorderRadius = 10
        Me.BTNeliminarTema.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarTema.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarTema.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeliminarTema.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeliminarTema.Enabled = False
        Me.BTNeliminarTema.FillColor = System.Drawing.Color.Red
        Me.BTNeliminarTema.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarTema.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarTema.Location = New System.Drawing.Point(715, 600)
        Me.BTNeliminarTema.Name = "BTNeliminarTema"
        Me.BTNeliminarTema.Size = New System.Drawing.Size(150, 42)
        Me.BTNeliminarTema.TabIndex = 22
        Me.BTNeliminarTema.Text = "Eliminar"
        Me.BTNeliminarTema.UseTransparentBackground = True
        '
        'FrmEliminarTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.BTNeliminarTema)
        Me.Controls.Add(Me.TXTNOMBRESUCURSAL)
        Me.Controls.Add(Me.LabelEliTemas)
        Me.Controls.Add(Me.L)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEliminarTemas"
        Me.Text = "FrmEliminarTemas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents LabelEliTemas As Label
    Friend WithEvents TXTNOMBRESUCURSAL As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BTNeliminarTema As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
