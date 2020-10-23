Public Class Telefono
    Private _ci As Integer
    Private _numero As Integer
    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property

    Public Sub Telefono(ci_ As Integer, numero_ As Integer)
        Ci = ci_
        Numero = numero_
    End Sub
End Class
