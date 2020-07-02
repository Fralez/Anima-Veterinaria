Public Class Mascotas
    Private _id As Integer
    Private _nombre As String
    Private _anoNacimiento As Integer
    Private _dueno As Personas

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property AnoNacimiento As Integer
        Get
            Return _anoNacimiento
        End Get
        Set(value As Integer)
            _anoNacimiento = value
        End Set
    End Property

    Public Property Dueno As Personas
        Get
            Return _dueno
        End Get
        Set(value As Personas)
            _dueno = value
        End Set
    End Property

    Public Sub Mascotas(id_ As Integer, nombre_ As String, anoNacimiento_ As Integer, dueno_ As Personas)
        Id = id_
        Nombre = nombre_
        AnoNacimiento = anoNacimiento_
        Dueno = dueno_
    End Sub
End Class
