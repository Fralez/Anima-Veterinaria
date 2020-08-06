Public Class LogicaPersonas
    Public Sub AltaPersona(persona As Personas)
        Dim persistencia As New PersistenciaPersonas

        persistencia.AltaPersona(persona)
    End Sub
End Class
