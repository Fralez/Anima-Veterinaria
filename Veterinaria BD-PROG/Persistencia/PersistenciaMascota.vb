Public Class PersistenciaMascota
    Dim conexion As Npgsql.NpgsqlConnection
    Public Sub AltaMascota(ci As Integer, nombre As String, anoNacimiento As Integer)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim query As String = "INSERT INTO Mascotas (ci, nombre, anoNacimiento) VALUES (@ci, @nombre, @anoNacimiento);"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nombre
            cmd.Parameters.Add("@anoNacimiento", NpgsqlTypes.NpgsqlDbType.Integer).Value = anoNacimiento

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub ModificarMascota(id As Integer, nombre As String, anoNacimiento As Integer)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim query As String = "UPDATE Mascotas SET nombre = @nombre, anonacimiento = @anoNacimiento WHERE id = @id"

            cmd.CommandText = query
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nombre
            cmd.Parameters.Add("@anoNacimiento", NpgsqlTypes.NpgsqlDbType.Integer).Value = anoNacimiento

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function BuscarMascota(id As Integer) As Mascota
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim mascota As New Mascota
            Dim query As String = "SELECT * FROM Mascotas WHERE id = @id"

            cmd.CommandText = query
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            Dim lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                mascota.Id = Convert.ToInt32(lector(0).ToString)
                mascota.Nombre = lector(1).ToString
                mascota.AnoNacimiento = lector(2).ToString
                mascota.DuenoCi = Convert.ToInt32(lector(3).ToString)
            End If

            Return mascota
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ListarMascota() As List(Of Mascota)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim mascotas As New List(Of Mascota)
            Dim query As String = "SELECT * FROM Mascotas"

            cmd.CommandText = query

            Dim lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If lector.HasRows Then
                While lector.Read()
                    Dim mascota As New Mascota
                    mascota.Id = Convert.ToInt32(lector(0).ToString)
                    mascota.Nombre = lector(1).ToString
                    mascota.AnoNacimiento = lector(2).ToString
                    mascota.DuenoCi = Convert.ToInt32(lector(3).ToString)
                    mascotas.Add(mascota)
                End While
            End If

            Return mascotas
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Sub EliminarMascota(id As Integer)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim query As String = "DELETE FROM Mascotas WHERE id = @id"

            cmd.CommandText = query

            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
