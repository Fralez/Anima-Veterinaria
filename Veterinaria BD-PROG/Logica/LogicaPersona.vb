Public Class LogicaPersona
    Public Sub AltaPersona(persona As Persona)
        Dim persistencia As New PersistenciaPersona

        persistencia.AltaPersona(persona)
    End Sub

    Public Function BuscarPersona(ci As Integer) As Persona
        Dim persistencia = New PersistenciaPersona

        Return persistencia.BuscarPersona(ci)
    End Function

    Public Sub ModificarPersona(persona As Persona)
        Dim persistencia As New PersistenciaPersona

        persistencia.ModificarPersona(persona)
    End Sub

    Public Function ListarPersonas() As List(Of Persona)
        Dim persistencia As New PersistenciaPersona

        Return persistencia.ListarPersona()
    End Function

    Public Sub EliminarPersona(ci As Integer)
        Dim persistencia = New PersistenciaPersona

        persistencia.EliminarPersona(ci)
    End Sub
End Class
