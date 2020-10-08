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

    Public Sub ModificarPersona(ci As Integer, nombre As String, direccion As String)
        Dim persistencia As New PersistenciaPersonas

        persistencia.ModificarPersona(ci, nombre, direccion)
    End Sub
End Class
