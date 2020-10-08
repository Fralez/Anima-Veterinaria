Public Class FormAltaMascota
    Private Sub FormAltaMascota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCrear_Click(sender As Object, e As EventArgs) Handles ButtonCrear.Click
        Try
            Dim ci As Integer
            ci = TextBoxDuenoCi.Text

            Dim nombre As String
            nombre = TextBoxNombre.Text


            Dim anoNacimiento As String
            anoNacimiento = TextBoxAnoNac.Text

            Dim logica = New LogicaMascotas
            logica.AltaMascota(ci, nombre, anoNacimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class