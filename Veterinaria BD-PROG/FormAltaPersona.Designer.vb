<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAltaPersona
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
        Me.ButtonCrear = New System.Windows.Forms.Button()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TextBoxDir = New System.Windows.Forms.TextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonCrear
        '
        Me.ButtonCrear.Location = New System.Drawing.Point(704, 400)
        Me.ButtonCrear.Name = "ButtonCrear"
        Me.ButtonCrear.Size = New System.Drawing.Size(85, 38)
        Me.ButtonCrear.TabIndex = 0
        Me.ButtonCrear.Text = "CREAR"
        Me.ButtonCrear.UseVisualStyleBackColor = True
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(12, 77)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxCedula.TabIndex = 1
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(12, 61)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(17, 13)
        Me.LblCedula.TabIndex = 2
        Me.LblCedula.Text = "CI"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(12, 101)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(44, 13)
        Me.LblName.TabIndex = 4
        Me.LblName.Text = "Nombre"
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(12, 117)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxNombre.TabIndex = 3
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(12, 143)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(52, 13)
        Me.LblAddress.TabIndex = 6
        Me.LblAddress.Text = "Direccion"
        '
        'TextBoxDir
        '
        Me.TextBoxDir.Location = New System.Drawing.Point(12, 159)
        Me.TextBoxDir.Name = "TextBoxDir"
        Me.TextBoxDir.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxDir.TabIndex = 5
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(12, 23)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(89, 13)
        Me.LblTitle.TabIndex = 9
        Me.LblTitle.Text = "ALTA PERSONA"
        '
        'FormAltaPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 450)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.TextBoxDir)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.ButtonCrear)
        Me.Name = "FormAltaPersona"
        Me.Text = "Alta Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonCrear As Button
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents LblName As Label
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents TextBoxDir As TextBox
    Friend WithEvents LblTitle As Label
End Class
