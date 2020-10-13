Public Class LogicaPersonas
    Public Sub AltaPersona(persona As Personas)
        Dim persistencia As New PersistenciaPersonas

        persistencia.AltaPersona(persona)
    End Sub

    Public Sub AltaTelefono(ci As Integer, telefono As Integer)
        Dim persistencia = New PersistenciaPersonas
        persistencia.AltaTelefono(ci, telefono)
    End Sub

    Public Function BuscarPersona(ci As Integer) As Personas
        Dim persistencia = New PersistenciaPersonas

        Return persistencia.BuscarPersona(ci)
    End Function

    Public Sub ModificarPersona(persona As Personas)
        Dim persistencia As New PersistenciaPersonas

        persistencia.ModificarPersona(persona)
    End Sub

    Public Function ListarPersonas() As List(Of Personas)
        Dim persistencia As New PersistenciaPersonas

        Return persistencia.ListarPersona()
    End Function

    Public Sub EliminarPersona(ci As Integer)
        Dim persistencia = New PersistenciaPersonas

        persistencia.EliminarPersona(ci)
    End Sub
End Class
