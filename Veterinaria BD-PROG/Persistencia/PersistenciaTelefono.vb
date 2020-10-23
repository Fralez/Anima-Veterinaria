Public Class PersistenciaTelefono
    Dim conexion As Npgsql.NpgsqlConnection

    Public Sub AltaTelefono(telefono As Telefono)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim query As String = "INSERT INTO Telefonos (ci, telefono) VALUES (@ci, @telefono)"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono.Ci
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono.Numero

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function ListarTelefonos(ci As Integer) As List(Of Telefono)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim listaTelefonos As New List(Of Telefono)

            Dim query = "SELECT * FROM Telefonos WHERE ci = @ci"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim lector As Npgsql.NpgsqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                While lector.Read()
                    Dim telefono As New Telefono
                    telefono.Ci = ci
                    telefono.Numero = Convert.ToInt32(lector(1).ToString)
                    listaTelefonos.Add(telefono)
                End While
            End If

            Return listaTelefonos
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function
End Class
