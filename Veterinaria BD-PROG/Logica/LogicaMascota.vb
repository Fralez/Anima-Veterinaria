﻿Public Class LogicaMascota
    Public Sub AltaMascota(ci As Integer, nombre As String, anoNacimiento As Integer)
        Dim persistencia As New PersistenciaMascota

        persistencia.AltaMascota(ci, nombre, anoNacimiento)
    End Sub

    Public Sub ModificarMascota(id As Integer, nombre As String, anoNacimiento As Integer)
        Dim persistencia As New PersistenciaMascota

        persistencia.ModificarMascota(id, nombre, anoNacimiento)
    End Sub

    Public Function BuscarMascota(id As Integer) As Mascota
        Dim persistencia As New PersistenciaMascota

        Dim mascota As Mascota = persistencia.BuscarMascota(id)

        Return mascota
    End Function

    Public Function ListarMascota() As List(Of Mascota)
        Dim persistencia As New PersistenciaMascota

        Dim mascotas As List(Of Mascota) = persistencia.ListarMascota()

        Return mascotas
    End Function

    Public Sub EliminarMascota(id As Integer)
        Dim persistencia As New PersistenciaMascota

        persistencia.EliminarMascota(id)
    End Sub
End Class
