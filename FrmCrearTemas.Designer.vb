<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrearTemas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCrearTemas))
        Me.BTNcrearTemas = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'BTNcrearTemas
        '
        Me.BTNcrearTemas.Animated = True
        Me.BTNcrearTemas.BackColor = System.Drawing.Color.DarkCyan
        Me.BTNcrearTemas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearTemas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNcrearTemas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNcrearTemas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNcrearTemas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BTNcrearTemas.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BTNcrearTemas.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNcrearTemas.ForeColor = System.Drawing.Color.White
        Me.BTNcrearTemas.Location = New System.Drawing.Point(0, 0)
        Me.BTNcrearTemas.Name = "BTNcrearTemas"
        Me.BTNcrearTemas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BTNcrearTemas.Size = New System.Drawing.Size(922, 35)
        Me.BTNcrearTemas.TabIndex = 1
        Me.BTNcrearTemas.Text = "crear temas"
        Me.BTNcrearTemas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FrmCrearTemas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(922, 630)
        Me.Controls.Add(Me.BTNcrearTemas)
        Me.Name = "FrmCrearTemas"
        Me.Text = "Frmprueba"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNcrearTemas As Guna.UI2.WinForms.Guna2Button
End Class
