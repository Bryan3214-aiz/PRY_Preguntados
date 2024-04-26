<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearReportes
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
        Me.TXT_BUSCAR = New Guna.UI2.WinForms.Guna2TextBox()
        Me.L = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.BTN_Actividad_con_Respuestas = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_Actualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_Puntacion_Alta = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_MinimaCalificacion = New Guna.UI2.WinForms.Guna2Button()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2ContextMenuStrip1.SuspendLayout()
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
        Me.LabelbienvenidaProfesor.TabIndex = 32
        Me.LabelbienvenidaProfesor.Text = "crear reportes nuevos"
        Me.LabelbienvenidaProfesor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXT_BUSCAR
        '
        Me.TXT_BUSCAR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXT_BUSCAR.BorderRadius = 15
        Me.TXT_BUSCAR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_BUSCAR.DefaultText = ""
        Me.TXT_BUSCAR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_BUSCAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_BUSCAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BUSCAR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_BUSCAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BUSCAR.Font = New System.Drawing.Font("Showcard Gothic", 9.0!)
        Me.TXT_BUSCAR.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_BUSCAR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_BUSCAR.Location = New System.Drawing.Point(27, 130)
        Me.TXT_BUSCAR.Name = "TXT_BUSCAR"
        Me.TXT_BUSCAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_BUSCAR.PlaceholderText = "Filtrar partidas con el nombre del estudiante"
        Me.TXT_BUSCAR.SelectedText = ""
        Me.TXT_BUSCAR.Size = New System.Drawing.Size(832, 42)
        Me.TXT_BUSCAR.TabIndex = 34
        '
        'L
        '
        Me.L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader5, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.L.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.L.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L.ForeColor = System.Drawing.SystemColors.WindowText
        Me.L.FullRowSelect = True
        Me.L.GridLines = True
        Me.L.HideSelection = False
        Me.L.HoverSelection = True
        Me.L.Location = New System.Drawing.Point(27, 194)
        Me.L.Margin = New System.Windows.Forms.Padding(2)
        Me.L.Name = "L"
        Me.L.Scrollable = False
        Me.L.Size = New System.Drawing.Size(832, 363)
        Me.L.TabIndex = 33
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
        Me.ColumnHeader2.Text = "Estudiante"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 145
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Categoría"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 145
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Puntaje"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Respuestas correctas"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Respuestas incorrectas"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 185
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Fecha "
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 100
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTN_Actividad_con_Respuestas, Me.GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem})
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(310, 48)
        '
        'BTN_Actividad_con_Respuestas
        '
        Me.BTN_Actividad_con_Respuestas.Name = "BTN_Actividad_con_Respuestas"
        Me.BTN_Actividad_con_Respuestas.Size = New System.Drawing.Size(309, 22)
        Me.BTN_Actividad_con_Respuestas.Text = "Generar reporte respuestas incluidas"
        '
        'GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem
        '
        Me.GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem.Name = "GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem"
        Me.GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem.Size = New System.Drawing.Size(309, 22)
        Me.GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem.Text = "Generar reporte sin respuestas del estudiante"
        '
        'BTN_Actualizar
        '
        Me.BTN_Actualizar.Animated = True
        Me.BTN_Actualizar.BackColor = System.Drawing.Color.Lavender
        Me.BTN_Actualizar.BorderRadius = 10
        Me.BTN_Actualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Actualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Actualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Actualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Actualizar.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN_Actualizar.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTN_Actualizar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_Actualizar.Location = New System.Drawing.Point(679, 571)
        Me.BTN_Actualizar.Name = "BTN_Actualizar"
        Me.BTN_Actualizar.Size = New System.Drawing.Size(180, 60)
        Me.BTN_Actualizar.TabIndex = 35
        Me.BTN_Actualizar.Text = "Actualizar"
        '
        'BTN_Puntacion_Alta
        '
        Me.BTN_Puntacion_Alta.Animated = True
        Me.BTN_Puntacion_Alta.BackColor = System.Drawing.Color.Lavender
        Me.BTN_Puntacion_Alta.BorderRadius = 10
        Me.BTN_Puntacion_Alta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Puntacion_Alta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_Puntacion_Alta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_Puntacion_Alta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_Puntacion_Alta.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN_Puntacion_Alta.Font = New System.Drawing.Font("Showcard Gothic", 11.25!)
        Me.BTN_Puntacion_Alta.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_Puntacion_Alta.Location = New System.Drawing.Point(42, 571)
        Me.BTN_Puntacion_Alta.Name = "BTN_Puntacion_Alta"
        Me.BTN_Puntacion_Alta.Size = New System.Drawing.Size(180, 60)
        Me.BTN_Puntacion_Alta.TabIndex = 36
        Me.BTN_Puntacion_Alta.Text = "Máxima Calificación por Estudiante"
        '
        'BTN_MinimaCalificacion
        '
        Me.BTN_MinimaCalificacion.Animated = True
        Me.BTN_MinimaCalificacion.BackColor = System.Drawing.Color.Lavender
        Me.BTN_MinimaCalificacion.BorderRadius = 10
        Me.BTN_MinimaCalificacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MinimaCalificacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_MinimaCalificacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_MinimaCalificacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_MinimaCalificacion.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.BTN_MinimaCalificacion.Font = New System.Drawing.Font("Showcard Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_MinimaCalificacion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BTN_MinimaCalificacion.Location = New System.Drawing.Point(260, 571)
        Me.BTN_MinimaCalificacion.Name = "BTN_MinimaCalificacion"
        Me.BTN_MinimaCalificacion.Size = New System.Drawing.Size(180, 60)
        Me.BTN_MinimaCalificacion.TabIndex = 37
        Me.BTN_MinimaCalificacion.Text = "Ver Mínima Calificación por Estudiante"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Width = 0
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Width = 0
        '
        'FrmCrearReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(895, 654)
        Me.Controls.Add(Me.BTN_MinimaCalificacion)
        Me.Controls.Add(Me.BTN_Puntacion_Alta)
        Me.Controls.Add(Me.BTN_Actualizar)
        Me.Controls.Add(Me.TXT_BUSCAR)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.LabelbienvenidaProfesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCrearReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCrearReportes"
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelbienvenidaProfesor As Label
    Friend WithEvents TXT_BUSCAR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BTN_Actualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents BTN_Actividad_con_Respuestas As ToolStripMenuItem
    Friend WithEvents GenerarReporteSinRespuestasDelEstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_Puntacion_Alta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_MinimaCalificacion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
End Class
