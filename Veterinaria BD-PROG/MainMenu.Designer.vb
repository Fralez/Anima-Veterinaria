<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AltasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeléfonoDePersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MascotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MascotaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MascotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AltasToolStripMenuItem, Me.BuscarToolStripMenuItem, Me.ListarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AltasToolStripMenuItem
        '
        Me.AltasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem, Me.TeléfonoDePersonaToolStripMenuItem, Me.MascotaToolStripMenuItem})
        Me.AltasToolStripMenuItem.Name = "AltasToolStripMenuItem"
        Me.AltasToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.AltasToolStripMenuItem.Text = "Alta"
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.PersonaToolStripMenuItem.Text = "Persona"
        '
        'TeléfonoDePersonaToolStripMenuItem
        '
        Me.TeléfonoDePersonaToolStripMenuItem.Name = "TeléfonoDePersonaToolStripMenuItem"
        Me.TeléfonoDePersonaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.TeléfonoDePersonaToolStripMenuItem.Text = "Teléfono"
        '
        'MascotaToolStripMenuItem
        '
        Me.MascotaToolStripMenuItem.Name = "MascotaToolStripMenuItem"
        Me.MascotaToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.MascotaToolStripMenuItem.Text = "Mascota"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonaToolStripMenuItem1, Me.MascotaToolStripMenuItem1})
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.BuscarToolStripMenuItem.Text = "Administrar"
        '
        'PersonaToolStripMenuItem1
        '
        Me.PersonaToolStripMenuItem1.Name = "PersonaToolStripMenuItem1"
        Me.PersonaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PersonaToolStripMenuItem1.Text = "Persona"
        '
        'MascotaToolStripMenuItem1
        '
        Me.MascotaToolStripMenuItem1.Name = "MascotaToolStripMenuItem1"
        Me.MascotaToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.MascotaToolStripMenuItem1.Text = "Mascota"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonasToolStripMenuItem, Me.MascotasToolStripMenuItem})
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PersonasToolStripMenuItem.Text = "Persona"
        '
        'MascotasToolStripMenuItem
        '
        Me.MascotasToolStripMenuItem.Name = "MascotasToolStripMenuItem"
        Me.MascotasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MascotasToolStripMenuItem.Text = "Mascota"
        '
        'FormMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FormMainMenu"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AltasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MascotaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeléfonoDePersonaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MascotasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MascotaToolStripMenuItem1 As ToolStripMenuItem
End Class
