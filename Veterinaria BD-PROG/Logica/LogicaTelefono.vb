Public Class LogicaTelefono
    Public Sub AltaTelefono(telefono As Telefono)
        Dim persistencia = New PersistenciaTelefono
        persistencia.AltaTelefono(telefono)
    End Sub

    Public Function ListarTelefonos(ci As Integer) As List(Of Telefono)
        Dim persistencia = New PersistenciaTelefono
        Return persistencia.ListarTelefonos(ci)
    End Function
End Class
