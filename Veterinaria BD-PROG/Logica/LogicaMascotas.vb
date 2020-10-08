Public Class LogicaMascotas
    Public Sub AltaMascota(ci As Integer, nombre As String, anoNacimiento As Integer)
        Dim persistencia As New PersistenciaMascotas

        persistencia.AltaMascota(ci, nombre, anoNacimiento)
    End Sub
End Class
