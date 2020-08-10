Public Class FormBuscarPersona
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Dim ci As Integer
        ci = TextBoxCedula.Text

        Dim logica = New LogicaPersonas
        Dim persona As Personas
        persona = logica.BuscarPersona(ci)

        LblName.Text = "Nombre: " + persona.Nombre
        LblAddress.Text = "Dirección: " + persona.Direccion
    End Sub
End Class