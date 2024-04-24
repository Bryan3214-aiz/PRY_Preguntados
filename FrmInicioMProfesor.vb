Public Class FrmInicioMProfesor

    Private Sub FrmInicioMProfesor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nombreP As String = obtenerNombre()
        LabelbienvenidaProfesor.Text = LabelbienvenidaProfesor.Text & nombreP
    End Sub
    Function obtenerNombre()
        Dim nombrep As String = FrmLoginProfesor.NOMBRE_PROFESOR
        Return nombrep
    End Function
End Class