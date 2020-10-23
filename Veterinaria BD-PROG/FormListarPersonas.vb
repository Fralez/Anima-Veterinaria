Public Class FormListarPersonas
    Private Sub ListarButton_Click(sender As Object, e As EventArgs) Handles ListarButton.Click
        Try
            PersonasListBox.Items.Clear()
            Dim logica = New LogicaPersona
            Dim listaPersonas As List(Of Persona)

            listaPersonas = logica.ListarPersonas()

            For Each persona As Persona In listaPersonas
                PersonasListBox.Items.Add(persona.Nombre)
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class