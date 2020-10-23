Public Class FormAltaTelefono
    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        Try
            Dim telefono As New Telefono
            telefono.Ci = TextBoxCedula.Text
            telefono.Numero = TextBoxTelefono.Text

            Dim logica = New LogicaTelefono
            logica.AltaTelefono(telefono)
        Catch ex As Exception
        End Try
    End Sub
End Class