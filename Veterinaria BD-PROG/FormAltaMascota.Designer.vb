<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAltaMascota
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblBirthDate = New System.Windows.Forms.Label()
        Me.TextBoxAnoNac = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.ButtonCrear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDuenoCi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(12, 26)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(89, 13)
        Me.LblTitle.TabIndex = 19
        Me.LblTitle.Text = "ALTA MASCOTA"
        '
        'LblBirthDate
        '
        Me.LblBirthDate.AutoSize = True
        Me.LblBirthDate.Location = New System.Drawing.Point(12, 94)
        Me.LblBirthDate.Name = "LblBirthDate"
        Me.LblBirthDate.Size = New System.Drawing.Size(95, 13)
        Me.LblBirthDate.TabIndex = 16
        Me.LblBirthDate.Text = "Año de nacimiento"
        '
        'TextBoxAnoNac
        '
        Me.TextBoxAnoNac.Location = New System.Drawing.Point(12, 110)
        Me.TextBoxAnoNac.Name = "TextBoxAnoNac"
        Me.TextBoxAnoNac.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxAnoNac.TabIndex = 15
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(12, 52)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(44, 13)
        Me.LblName.TabIndex = 14
        Me.LblName.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(12, 68)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxNombre.TabIndex = 13
        '
        'ButtonCrear
        '
        Me.ButtonCrear.Location = New System.Drawing.Point(704, 395)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(85, 38)
        Me.ButtonCrear.TabIndex = 10
        Me.ButtonCrear.Text = "CREAR"
        Me.ButtonCrear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Cedula Dueño"
        '
        'TextBoxDuenoCi
        '
        Me.TextBoxDuenoCi.Location = New System.Drawing.Point(12, 147)
        Me.TextBoxDuenoCi.Name = "TextBoxDuenoCi"
        Me.TextBoxDuenoCi.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxDuenoCi.TabIndex = 20
        '
        'FormAltaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxDuenoCi)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblBirthDate)
        Me.Controls.Add(Me.TextBoxAnoNac)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.ButtonCrear)
        Me.Name = "FormAltaMascota"
        Me.Text = "Alta Mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblBirthDate As Label
    Friend WithEvents TextBoxAnoNac As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents ButtonCrear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxDuenoCi As TextBox
End Class
