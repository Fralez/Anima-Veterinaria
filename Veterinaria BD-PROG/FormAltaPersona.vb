Public Class FormAltaPersona
    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        Try
            Dim ci As Integer
            ci = TextBoxCedula.Text

            Dim nombre As String
            nombre = TextBoxNombre.Text


            Dim direccion As String
            direccion = TextBoxDir.Text

            Dim newPersona = New Personas
            newPersona.Ci = ci
            newPersona.Nombre = nombre
            newPersona.Direccion = direccion

            Dim logica = New LogicaPersonas
            logica.AltaPersona(newPersona)
        Catch ex As Exception
        End Try
    End Sub
End Class
