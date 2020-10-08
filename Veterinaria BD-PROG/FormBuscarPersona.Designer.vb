<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarPersona
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
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.ButtonBuscar = New System.Windows.Forms.Button()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(12, 18)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(106, 13)
        Me.LblTitle.TabIndex = 17
        Me.LblTitle.Text = "BUSCAR PERSONA"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.Location = New System.Drawing.Point(11, 139)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(55, 13)
        Me.LblAddress.TabIndex = 16
        Me.LblAddress.Text = "Direccion:"
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(11, 112)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(47, 13)
        Me.LblName.TabIndex = 14
        Me.LblName.Text = "Nombre:"
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(12, 56)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(17, 13)
        Me.LblCedula.TabIndex = 12
        Me.LblCedula.Text = "CI"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(12, 72)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxCedula.TabIndex = 11
        '
        'ButtonBuscar
        '
        Me.ButtonBuscar.Location = New System.Drawing.Point(560, 66)
        Me.ButtonBuscar.Name = "ButtonBuscar"
        Me.ButtonBuscar.Size = New System.Drawing.Size(71, 30)
        Me.ButtonBuscar.TabIndex = 10
        Me.ButtonBuscar.Text = "BUSCAR"
        Me.ButtonBuscar.UseVisualStyleBackColor = True
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(64, 109)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(542, 20)
        Me.TextBoxNombre.TabIndex = 18
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(72, 135)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(534, 20)
        Me.TextBoxDireccion.TabIndex = 19
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(15, 170)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(133, 30)
        Me.ButtonModificar.TabIndex = 20
        Me.ButtonModificar.Text = "MODIFICAR PERSONA"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'FormBuscarPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.ButtonBuscar)
        Me.Name = "FormBuscarPersona"
        Me.Text = "FormBuscarPersona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblAddress As Label
    Friend WithEvents LblName As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents ButtonBuscar As Button
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents ButtonModificar As Button
End Class
