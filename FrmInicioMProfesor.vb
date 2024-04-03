Public Class FrmInicioMProfesor
    Private Sub FrmInicioMProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nombreP As String = obtenerNombre()
        LabelbienvenidaProfesor.Text = LabelbienvenidaProfesor.Text & nombreP
    End Sub
    Function obtenerNombre()
        Return "Bryan Leiva"
    End Function
End Class