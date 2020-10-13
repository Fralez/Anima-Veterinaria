Public Class FormBuscarPersona
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim ci As Integer
        ci = TextBoxCedula.Text

        Dim logica = New LogicaPersonas
        Dim persona As Personas
        persona = logica.BuscarPersona(ci)

        TextBoxNombre.Text = persona.Nombre
        TextBoxDireccion.Text = persona.Direccion

        For Each telefono As Integer In persona.Telefonos
            ListBoxTelefonos.Items.Add(telefono)
        Next
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            Dim persona As New Personas
            persona.Ci = TextBoxCedula.Text
            persona.Nombre = TextBoxNombre.Text
            persona.Direccion = TextBoxDireccion.Text
            persona.Telefonos = ListBoxTelefonos.Items.Cast(Of Integer).ToList

            Dim logica = New LogicaPersonas
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
            Dim logica = New LogicaPersonas
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