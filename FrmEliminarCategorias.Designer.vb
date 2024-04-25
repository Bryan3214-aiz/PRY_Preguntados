<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEliminarCategorias
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
        Me.TXTNOMBRECATEGORIA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNeliminarCategoria = New Guna.UI2.WinForms.Guna2Button()
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
        Me.LabelEliTemas.Size = New System.Drawing.Size(895, 115)
        Me.LabelEliTemas.TabIndex = 28
        Me.LabelEliTemas.Text = "Eliminar categorias "
        Me.LabelEliTemas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTNOMBRECATEGORIA
        '
        Me.TXTNOMBRECATEGORIA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTNOMBRECATEGORIA.BorderRadius = 15
        Me.TXTNOMBRECATEGORIA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXTNOMBRECATEGORIA.DefaultText = ""
        Me.TXTNOMBRECATEGORIA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXTNOMBRECATEGORIA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXTNOMBRECATEGORIA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOMBRECATEGORIA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXTNOMBRECATEGORIA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBRECATEGORIA.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.TXTNOMBRECATEGORIA.ForeColor = System.Drawing.Color.DimGray
        Me.TXTNOMBRECATEGORIA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTNOMBRECATEGORIA.Location = New System.Drawing.Point(30, 129)
        Me.TXTNOMBRECATEGORIA.Name = "TXTNOMBRECATEGORIA"
        Me.TXTNOMBRECATEGORIA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXTNOMBRECATEGORIA.PlaceholderText = "Ingrese el nombre de la categoria"
        Me.TXTNOMBRECATEGORIA.SelectedText = ""
        Me.TXTNOMBRECATEGORIA.Size = New System.Drawing.Size(832, 42)
        Me.TXTNOMBRECATEGORIA.TabIndex = 29
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
        Me.L.Location = New System.Drawing.Point(30, 196)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.MultiSelect = False
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(832, 399)
        Me.L.TabIndex = 30
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
        'BTNeliminarCategoria
        '
        Me.BTNeliminarCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNeliminarCategoria.Animated = True
        Me.BTNeliminarCategoria.BackColor = System.Drawing.Color.Transparent
        Me.BTNeliminarCategoria.BorderRadius = 10
        Me.BTNeliminarCategoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarCategoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNeliminarCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNeliminarCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNeliminarCategoria.Enabled = False
        Me.BTNeliminarCategoria.FillColor = System.Drawing.Color.Red
        Me.BTNeliminarCategoria.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNeliminarCategoria.ForeColor = System.Drawing.Color.White
        Me.BTNeliminarCategoria.Location = New System.Drawing.Point(712, 600)
        Me.BTNeliminarCategoria.Name = "BTNeliminarCategoria"
        Me.BTNeliminarCategoria.Size = New System.Drawing.Size(150, 42)
        Me.BTNeliminarCategoria.TabIndex = 33
        Me.BTNeliminarCategoria.Text = "Eliminar"
        Me.BTNeliminarCategoria.UseTransparentBackground = True
        '
        'FrmEliminarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.BTNeliminarCategoria)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.TXTNOMBRECATEGORIA)
        Me.Controls.Add(Me.LabelEliTemas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEliminarCategorias"
        Me.Text = "FrmEliminarCategorias"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelEliTemas As Label
    Friend WithEvents TXTNOMBRECATEGORIA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BTNeliminarCategoria As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
