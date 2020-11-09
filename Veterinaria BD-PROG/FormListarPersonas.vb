Public Class FormListarPersonas
    Private Sub FormListarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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