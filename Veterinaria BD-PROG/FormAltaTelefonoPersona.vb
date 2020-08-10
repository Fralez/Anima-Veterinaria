Public Class FormAltaTelefonoPersona
    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        Try
            Dim ci As Integer
            ci = TextBoxCedula.Text

            Dim telefono As String
            telefono = TextBoxTelefono.Text

            Dim logica = New LogicaPersonas
            logica.AltaTelefono(ci, telefono)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class