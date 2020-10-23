Public Class FormAltaPersona
    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        Try
            Dim persona = New Persona
            persona.Ci = TextBoxCedula.Text
            persona.Nombre = TextBoxNombre.Text
            persona.Direccion = TextBoxDir.Text

            Dim logica = New LogicaPersona
            logica.AltaPersona(persona)
        Catch ex As Exception
        End Try
    End Sub
End Class
