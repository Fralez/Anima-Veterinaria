Public Class FormAdministrarMascota
    Private Sub ButtonBuscar_Click(sender As Object, e As EventArgs) Handles ButtonBuscar.Click
        Try
            Dim logica = New LogicaMascota
            Dim mascota As New Mascota
            mascota = logica.BuscarMascota(TextBoxId.Text)

            TextBoxNombre.Text = mascota.Nombre
            TextBoxAnoNacimiento.Text = mascota.AnoNacimiento
            LabelDuenoCI.Text = mascota.DuenoCi
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Try
            Dim logica = New LogicaMascota

            logica.ModificarMascota(TextBoxId.Text, TextBoxNombre.Text, TextBoxAnoNacimiento.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonEliminarMascota_Click(sender As Object, e As EventArgs) Handles ButtonEliminarMascota.Click
        Try
            Dim logica = New LogicaMascota
            logica.EliminarMascota(TextBoxId.Text)

            TextBoxId.Clear()
            TextBoxNombre.Clear()
            TextBoxAnoNacimiento.Clear()
            LabelDuenoCI.Text = "-"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class