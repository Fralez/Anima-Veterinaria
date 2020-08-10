Public Class FormMainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        FormAltaPersona.Show()
    End Sub

    Private Sub MascotaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MascotaToolStripMenuItem.Click
        FormAltaMascota.Show()
    End Sub

    Private Sub TeléfonoDePersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeléfonoDePersonaToolStripMenuItem.Click
        FormAltaTelefonoPersona.Show()
    End Sub

    Private Sub PersonaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem1.Click
        FormBuscarPersona.Show()
    End Sub
End Class