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
End Class
