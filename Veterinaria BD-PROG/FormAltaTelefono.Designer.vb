<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaTelefono
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.ButtonCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(12, 25)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(94, 13)
        Me.LblTitle.TabIndex = 14
        Me.LblTitle.Text = "ALTA TELÉFONO"
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(12, 103)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.LblTelefono.TabIndex = 13
        Me.LblTelefono.Text = "Teléfono"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(12, 119)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxTelefono.TabIndex = 12
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(12, 63)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(17, 13)
        Me.LblCedula.TabIndex = 11
        Me.LblCedula.Text = "CI"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(12, 79)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxCedula.TabIndex = 10
        '
        'ButtonCrear
        '
        Me.ButtonCrear.Location = New System.Drawing.Point(703, 400)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(85, 38)
        Me.ButtonCrear.TabIndex = 15
        Me.ButtonCrear.Text = "CREAR"
        Me.ButtonCrear.UseVisualStyleBackColor = True
        '
        'FormAltaTelefonoPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonCrear)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblTelefono)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Name = "FormAltaTelefonoPersona"
        Me.Text = "FormAltaTelefonoPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents ButtonCrear As Button
End Class
