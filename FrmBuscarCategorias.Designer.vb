<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBuscarCategorias
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
        Me.LabelEliTemas = New System.Windows.Forms.Label()
        Me.TXTnombreCategoria = New Guna.UI2.WinForms.Guna2TextBox()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'LabelEliTemas
        '
        Me.LabelEliTemas.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelEliTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelEliTemas.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEliTemas.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LabelEliTemas.Location = New System.Drawing.Point(0, 0)
        Me.LabelEliTemas.Name = "LabelEliTemas"
        Me.LabelEliTemas.Size = New System.Drawing.Size(895, 72)
        Me.LabelEliTemas.TabIndex = 29
        Me.LabelEliTemas.Text = "Buscando categorias creadas"
        Me.LabelEliTemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTnombreCategoria
        '
        Me.TXTnombreCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTnombreCategoria.BorderRadius = 15
        Me.TXTnombreCategoria.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTnombreCategoria.DefaultText = ""
        Me.TXTnombreCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTnombreCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTnombreCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTnombreCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTnombreCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTnombreCategoria.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.TXTnombreCategoria.ForeColor = System.Drawing.Color.DimGray
        Me.TXTnombreCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTnombreCategoria.Location = New System.Drawing.Point(29, 99)
        Me.TXTnombreCategoria.Name = "TXTnombreCategoria"
        Me.TXTnombreCategoria.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTnombreCategoria.PlaceholderText = "Ingrese el nombre de la categoria"
        Me.TXTnombreCategoria.SelectedText = ""
        Me.TXTnombreCategoria.Size = New System.Drawing.Size(832, 42)
        Me.TXTnombreCategoria.TabIndex = 30
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
        Me.L.Location = New System.Drawing.Point(29, 158)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Scrollable = False
        Me.L.Size = New System.Drawing.Size(832, 464)
        Me.L.TabIndex = 31
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
        Me.ColumnHeader2.Text = "Nombre de la categoria"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 275
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre del tema asociado"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 275
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Grado"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 280
        '
        'FrmBuscarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.TXTnombreCategoria)
        Me.Controls.Add(Me.LabelEliTemas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBuscarCategorias"
        Me.Text = "FrmBuscarCategorias"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelEliTemas As Label
    Friend WithEvents TXTnombreCategoria As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
