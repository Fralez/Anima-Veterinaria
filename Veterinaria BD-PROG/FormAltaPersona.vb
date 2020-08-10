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
            Throw ex
        End Try
    End Sub

    Private Sub LblAddress_Click(sender As Object, e As EventArgs) Handles LblAddress.Click

    End Sub

    Private Sub TextBoxDir_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDir.TextChanged

    End Sub

    Private Sub LblName_Click(sender As Object, e As EventArgs) Handles LblName.Click

    End Sub

    Private Sub TextBoxNombre_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNombre.TextChanged

    End Sub

    Private Sub LblCedula_Click(sender As Object, e As EventArgs) Handles LblCedula.Click

    End Sub

    Private Sub TextBoxCedula_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCedula.TextChanged

    End Sub

    Private Sub LblTitle_Click(sender As Object, e As EventArgs) Handles LblTitle.Click

    End Sub
End Class
