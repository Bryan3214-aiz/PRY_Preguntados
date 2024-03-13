<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOPCIONES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOPCIONES))
        Me.BTNprofesor = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNestudiante = New Guna.UI2.WinForms.Guna2Button()
        Me.BTNadmin = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'BTNprofesor
        '
        Me.BTNprofesor.Animated = True
        Me.BTNprofesor.BackColor = System.Drawing.Color.Transparent
        Me.BTNprofesor.BorderRadius = 10
        Me.BTNprofesor.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNprofesor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNprofesor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNprofesor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNprofesor.FillColor = System.Drawing.Color.SeaGreen
        Me.BTNprofesor.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNprofesor.ForeColor = System.Drawing.Color.White
        Me.BTNprofesor.Location = New System.Drawing.Point(68, 179)
        Me.BTNprofesor.Name = "BTNprofesor"
        Me.BTNprofesor.Size = New System.Drawing.Size(187, 76)
        Me.BTNprofesor.TabIndex = 10
        Me.BTNprofesor.Text = "Profesor"
        Me.BTNprofesor.UseTransparentBackground = True
        '
        'BTNestudiante
        '
        Me.BTNestudiante.Animated = True
        Me.BTNestudiante.BackColor = System.Drawing.Color.Transparent
        Me.BTNestudiante.BorderRadius = 10
        Me.BTNestudiante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNestudiante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNestudiante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNestudiante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNestudiante.FillColor = System.Drawing.Color.CornflowerBlue
        Me.BTNestudiante.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNestudiante.ForeColor = System.Drawing.Color.White
        Me.BTNestudiante.Location = New System.Drawing.Point(284, 179)
        Me.BTNestudiante.Name = "BTNestudiante"
        Me.BTNestudiante.Size = New System.Drawing.Size(187, 76)
        Me.BTNestudiante.TabIndex = 11
        Me.BTNestudiante.Text = "Estudiante"
        Me.BTNestudiante.UseTransparentBackground = True
        '
        'BTNadmin
        '
        Me.BTNadmin.Animated = True
        Me.BTNadmin.BackColor = System.Drawing.Color.Transparent
        Me.BTNadmin.BorderRadius = 10
        Me.BTNadmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTNadmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTNadmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTNadmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTNadmin.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BTNadmin.Font = New System.Drawing.Font("Showcard Gothic", 9.75!)
        Me.BTNadmin.ForeColor = System.Drawing.Color.White
        Me.BTNadmin.Location = New System.Drawing.Point(500, 179)
        Me.BTNadmin.Name = "BTNadmin"
        Me.BTNadmin.Size = New System.Drawing.Size(187, 76)
        Me.BTNadmin.TabIndex = 12
        Me.BTNadmin.Text = "Administrador"
        Me.BTNadmin.UseTransparentBackground = True
        '
        'FrmOPCIONES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PRY_Preguntados.My.Resources.Resources.fondoPRG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(768, 402)
        Me.Controls.Add(Me.BTNadmin)
        Me.Controls.Add(Me.BTNestudiante)
        Me.Controls.Add(Me.BTNprofesor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOPCIONES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmOPCIONES"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNprofesor As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNestudiante As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNadmin As Guna.UI2.WinForms.Guna2Button
End Class
