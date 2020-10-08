Public Class Mascotas
    Private _id As Integer
    Private _nombre As String
    Private _anoNacimiento As Integer
    Private _dueno_ci As Integer

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

    Public Property DuenoCi As Integer
        Get
            Return _dueno_ci
        End Get
        Set(value As Integer)
            _dueno_ci = value
        End Set
    End Property

    Public Sub Mascotas(id_ As Integer, nombre_ As String, anoNacimiento_ As Integer, dueno_ci As Integer)
        Id = id_
        Nombre = nombre_
        AnoNacimiento = anoNacimiento_
        DuenoCi = dueno_ci
    End Sub
End Class
