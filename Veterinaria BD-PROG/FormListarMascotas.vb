Public Class FormListarMascotas
    Private Sub FormListarMascotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MascotasListBox.Items.Clear()
            Dim logica = New LogicaMascota
            Dim mascotas As New List(Of Mascota)
            mascotas = logica.ListarMascota()

            For Each mascota As Mascota In mascotas
                MascotasListBox.Items.Add(mascota.Nombre)
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class