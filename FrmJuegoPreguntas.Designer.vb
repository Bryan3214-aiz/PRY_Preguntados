<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmJuegoPreguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJuegoPreguntas))
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.BTN1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.PBBARRA = New Guna.UI2.WinForms.Guna2ProgressBar()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(-12, -47)
        Me.MediaPlayer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(1298, 586)
        Me.MediaPlayer.TabIndex = 2
        '
        'BTN1
        '
        Me.BTN1.BorderRadius = 35
        Me.BTN1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN1.ForeColor = System.Drawing.Color.White
        Me.BTN1.Location = New System.Drawing.Point(13, 322)
        Me.BTN1.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN1.Name = "BTN1"
        Me.BTN1.Size = New System.Drawing.Size(615, 92)
        Me.BTN1.TabIndex = 4
        Me.BTN1.Text = "Guna2Button1"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 35
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(653, 322)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(615, 92)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "Guna2Button1"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 35
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(13, 422)
        Me.Guna2Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(615, 92)
        Me.Guna2Button2.TabIndex = 6
        Me.Guna2Button2.Text = "Guna2Button1"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BorderRadius = 35
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(653, 422)
        Me.Guna2Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(615, 92)
        Me.Guna2Button3.TabIndex = 7
        Me.Guna2Button3.Text = "Guna2Button1"
        '
        'PBBARRA
        '
        Me.PBBARRA.BackColor = System.Drawing.Color.White
        Me.PBBARRA.BorderRadius = 15
        Me.PBBARRA.FillColor = System.Drawing.Color.Black
        Me.PBBARRA.Location = New System.Drawing.Point(514, 62)
        Me.PBBARRA.Margin = New System.Windows.Forms.Padding(4)
        Me.PBBARRA.Name = "PBBARRA"
        Me.PBBARRA.ProgressColor = System.Drawing.Color.Gold
        Me.PBBARRA.ProgressColor2 = System.Drawing.Color.Gold
        Me.PBBARRA.Size = New System.Drawing.Size(675, 37)
        Me.PBBARRA.TabIndex = 8
        Me.PBBARRA.Text = "Guna2ProgressBar1"
        Me.PBBARRA.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.PBBARRA.Value = 70
        '
        'FrmJuegoPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1281, 538)
        Me.Controls.Add(Me.PBBARRA)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.BTN1)
        Me.Controls.Add(Me.MediaPlayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmJuegoPreguntas"
        Me.Text = "FrmJuegoPreguntas"
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BTN1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PBBARRA As Guna.UI2.WinForms.Guna2ProgressBar
End Class
