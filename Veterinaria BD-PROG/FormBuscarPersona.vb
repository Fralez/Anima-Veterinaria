Public Class FormBuscarPersona
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim ci As Integer
        ci = TextBoxCedula.Text

        Dim logica = New LogicaPersonas
        Dim persona As Personas
        persona = logica.BuscarPersona(ci)

        TextBoxNombre.Text = persona.Nombre
        TextBoxDireccion.Text = persona.Direccion
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Dim ci As Integer
        ci = TextBoxCedula.Text
        Dim nombre As String
        nombre = TextBoxNombre.Text
        Dim direccion As String
        direccion = TextBoxDireccion.Text

        Dim logica = New LogicaPersonas
        logica.ModificarPersona(ci, nombre, direccion)
    End Sub
End Class