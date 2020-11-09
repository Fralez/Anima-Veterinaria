<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdministrarMascota
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
        Me.ButtonEliminarMascota = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.TextBoxAnoNacimiento = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblBirthYear = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDuenoCI = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonEliminarMascota
        '
        Me.ButtonEliminarMascota.Location = New System.Drawing.Point(516, 195)
        Me.ButtonEliminarMascota.Name = "ButtonEliminarMascota"
        Me.ButtonEliminarMascota.Size = New System.Drawing.Size(133, 30)
        Me.ButtonEliminarMascota.TabIndex = 35
        Me.ButtonEliminarMascota.Text = "ELIMINAR MASCOTA"
        Me.ButtonEliminarMascota.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(12, 195)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(160, 30)
        Me.ButtonModificar.TabIndex = 34
        Me.ButtonModificar.Text = "APLICAR MODIFICACIÓN"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'TextBoxAnoNacimiento
        '
        Me.TextBoxAnoNacimiento.Location = New System.Drawing.Point(115, 134)
        Me.TextBoxAnoNacimiento.Name = "TextBoxAnoNacimiento"
        Me.TextBoxAnoNacimiento.Size = New System.Drawing.Size(534, 20)
        Me.TextBoxAnoNacimiento.TabIndex = 33
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(115, 108)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(534, 20)
        Me.TextBoxNombre.TabIndex = 32
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(12, 17)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(137, 13)
        Me.LblTitle.TabIndex = 31
        Me.LblTitle.Text = "ADMINISTRAR MASCOTA"
        '
        'LblBirthYear
        '
        Me.LblBirthYear.AutoSize = True
        Me.LblBirthYear.Location = New System.Drawing.Point(11, 138)
        Me.LblBirthYear.Name = "LblBirthYear"
        Me.LblBirthYear.Size = New System.Drawing.Size(100, 13)
        Me.LblBirthYear.TabIndex = 30
        Me.LblBirthYear.Text = "Año de Nacimiento:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(11, 111)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(47, 13)
        Me.LblName.TabIndex = 29
        Me.LblName.Text = "Nombre:"
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(12, 55)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(18, 13)
        Me.LblId.TabIndex = 28
        Me.LblId.Text = "ID"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(12, 71)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxId.TabIndex = 27
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(578, 65)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(71, 30)
        Me.ButtonBuscar.TabIndex = 26
        Me.ButtonBuscar.Text = "BUSCAR"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Cédula del Dueño:"
        '
        'LabelDuenoCI
        '
        Me.LabelDuenoCI.AutoSize = True
        Me.LabelDuenoCI.Location = New System.Drawing.Point(118, 169)
        Me.LabelDuenoCI.Name = "LabelDuenoCI"
        Me.LabelDuenoCI.Size = New System.Drawing.Size(10, 13)
        Me.LabelDuenoCI.TabIndex = 37
        Me.LabelDuenoCI.Text = "-"
        '
        'FormAdministrarMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelDuenoCI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEliminarMascota)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.TextBoxAnoNacimiento)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblBirthYear)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Name = "FormAdministrarMascota"
        Me.Text = "FormAdministrarMascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonEliminarMascota As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents TextBoxAnoNacimiento As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents LblBirthYear As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblId As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDuenoCI As Label
End Class
