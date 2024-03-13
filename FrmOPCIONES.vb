Public Class FrmOPCIONES
    Private Sub BTNprofesor_Click(sender As Object, e As EventArgs) Handles BTNprofesor.Click
        Me.Hide()
        FrmLoginUsuario.ShowDialog()
        Me.Close()
    End Sub
End Class