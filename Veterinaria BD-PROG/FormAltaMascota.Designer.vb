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
        Me.LblId = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.ButtonCrear = New System.Windows.Forms.Button()
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
        Me.LblBirthDate.Location = New System.Drawing.Point(12, 138)
        Me.LblBirthDate.Name = "LblBirthDate"
        Me.LblBirthDate.Size = New System.Drawing.Size(95, 13)
        Me.LblBirthDate.TabIndex = 16
        Me.LblBirthDate.Text = "Año de nacimiento"
        '
        'TextBoxAnoNac
        '
        Me.TextBoxAnoNac.Location = New System.Drawing.Point(12, 154)
        Me.TextBoxAnoNac.Name = "TextBoxAnoNac"
        Me.TextBoxAnoNac.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxAnoNac.TabIndex = 15
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(12, 96)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(44, 13)
        Me.LblName.TabIndex = 14
        Me.LblName.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(12, 112)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxNombre.TabIndex = 13
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(12, 56)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(16, 13)
        Me.LblId.TabIndex = 12
        Me.LblId.Text = "Id"
        '
        'TextBoxId
        '
        Me.TextBoxId.Location = New System.Drawing.Point(12, 72)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxId.TabIndex = 11
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
        'FormAltaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblBirthDate)
        Me.Controls.Add(Me.TextBoxAnoNac)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TextBoxId)
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
    Friend WithEvents LblId As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents ButtonCrear As Button
End Class
