Public Class PersistenciaPersona
    Dim conexion As Npgsql.NpgsqlConnection

    Public Sub AltaPersona(persona As Persona)
        Try
            Dim classcnn = New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim query As String = "INSERT INTO Personas (ci, nombre, direccion) VALUES (@ci, @nombre, @direccion);"
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

    Public Function BuscarPersona(ci As Integer) As Persona
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim persistenciaTelefono As New PersistenciaTelefono
            Dim persona As New Persona

            Dim query As String = "SELECT * FROM Personas WHERE ci = @ci"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                persona.Ci = Convert.ToInt32(lector(0).ToString)
                persona.Nombre = lector(1).ToString
                persona.Direccion = lector(2).ToString
            End If

            persona.Telefonos = persistenciaTelefono.ListarTelefonos(ci)

            Return persona
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Sub ModificarPersona(persona As Persona)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim persistenciaTelefono As New PersistenciaTelefono

            ' Modificar datos de persona
            Dim query As String = "UPDATE Personas SET nombre = @nombre, direccion = @direccion WHERE ci = @ci"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Direccion

            cmd.ExecuteNonQuery()

            ' Borrar todos sus telefonos
            query = "DELETE FROM Telefonos WHERE ci = @ci"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci

            cmd.ExecuteNonQuery()

            ' Crear nuevamente sus telefonos en base a los modificados
            For Each telefono As Telefono In persona.Telefonos
                persistenciaTelefono.AltaTelefono(telefono)
            Next
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function ListarPersona() As List(Of Persona)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            Dim listaPersonas As New List(Of Persona)

            Dim query = "SELECT * FROM Personas"
            cmd.CommandText = query


            Dim lector As Npgsql.NpgsqlDataReader
            lector = cmd.ExecuteReader

            If lector.HasRows Then
                While lector.Read()
                    Dim persona As New Persona
                    persona.Ci = Convert.ToInt32(lector(0).ToString)
                    persona.Nombre = lector(1).ToString
                    persona.Direccion = lector(2).ToString
                    listaPersonas.Add(persona)
                End While
            End If

            Return listaPersonas
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Sub EliminarPersona(ci As Integer)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand
            cmd.Connection = conexion

            ' Borrar todos sus telefonos
            Dim query As String = "DELETE FROM Telefonos WHERE ci = @ci"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()

            ' Borrar todas sus mascotas
            query = "DELETE FROM Mascotas WHERE ci = @ci"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()

            ' Borrar persona
            query = "DELETE FROM Personas WHERE ci = @ci"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub
End Class
