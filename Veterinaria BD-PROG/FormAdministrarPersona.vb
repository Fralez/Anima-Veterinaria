Public Class FormAdministrarPersona
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        ListBoxTelefonos.Items.Clear()

        Dim ci As Integer
        ci = TextBoxCedula.Text

        Dim logica = New LogicaPersona
        Dim persona As Persona
        persona = logica.BuscarPersona(ci)

        TextBoxNombre.Text = persona.Nombre
        TextBoxDireccion.Text = persona.Direccion

        For Each telefono As Telefono In persona.Telefonos
            ListBoxTelefonos.Items.Add(telefono.Numero)
        Next
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            Dim persona As New Persona
            Dim telefonos As New List(Of Telefono)
            persona.Ci = TextBoxCedula.Text
            persona.Nombre = TextBoxNombre.Text
            persona.Direccion = TextBoxDireccion.Text

            For Each tel As Integer In ListBoxTelefonos.Items
                Dim nuevoTelefono As New Telefono
                nuevoTelefono.Ci = persona.Ci
                nuevoTelefono.Numero = tel
                telefonos.Add(nuevoTelefono)
            Next

            persona.Telefonos = telefonos

            Dim logica = New LogicaPersona
            logica.ModificarPersona(persona)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonAddTel_Click(sender As Object, e As EventArgs) Handles ButtonAddTel.Click
        Try
            ListBoxTelefonos.Items.Add(Convert.ToInt32(TextBoxAddTel.Text.ToString))
            TextBoxAddTel.Clear()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonRemoveSelectedTel_Click(sender As Object, e As EventArgs) Handles ButtonRemoveSelectedTel.Click
        Try
            ListBoxTelefonos.Items.RemoveAt(ListBoxTelefonos.SelectedIndex)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonEliminarPersona_Click(sender As Object, e As EventArgs) Handles ButtonEliminarPersona.Click
        Try
            Dim logica = New LogicaPersona
            logica.EliminarPersona(TextBoxCedula.Text)

            TextBoxCedula.Clear()
            TextBoxDireccion.Clear()
            TextBoxNombre.Clear()
            TextBoxAddTel.Clear()
            ListBoxTelefonos.Items.Clear()
        Catch ex As Exception
        End Try
    End Sub
End Class