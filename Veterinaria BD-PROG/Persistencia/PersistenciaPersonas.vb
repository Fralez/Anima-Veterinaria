Public Class PersistenciaPersonas
    Dim conexion As Npgsql.NpgsqlConnection
    Public Sub AltaPersona(persona As Personas)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim query As String
            query = "INSERT INTO PERSONAS (ci, nombre, direccion) VALUES (@ci, @nombre, @direccion);"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Direccion

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub AltaTelefono(ci As Integer, telefono As Integer)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim query As String
            query = "INSERT INTO Telefonos (ci, telefono) VALUES (@ci, @telefono)"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function BuscarPersona(ci As Integer) As Personas
        Try
            Dim persona As New Personas
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim query As String
            query = "SELECT * FROM PERSONAS WHERE ci = @ci"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                persona.Ci = Convert.ToInt32(lector(0).ToString)
                persona.Nombre = lector(1).ToString
                persona.Direccion = lector(2).ToString
            End If

            Return persona
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Sub ModificarPersona(ci As Integer, nombre As String, direccion As String)
        Try
            Dim persona As New Personas
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim query As String
            query = "UPDATE PERSONAS SET nombre = @nombre, direccion = @direccion WHERE ci = @ci"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = direccion

            Dim lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
