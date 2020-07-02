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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LblPhones = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(704, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CREAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 77)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(542, 20)
        Me.TextBox1.TabIndex = 1
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(542, 20)
        Me.TextBox2.TabIndex = 3
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 159)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(542, 20)
        Me.TextBox3.TabIndex = 5
        '
        'LblPhones
        '
        Me.LblPhones.AutoSize = True
        Me.LblPhones.Location = New System.Drawing.Point(12, 191)
        Me.LblPhones.Name = "LblPhones"
        Me.LblPhones.Size = New System.Drawing.Size(170, 13)
        Me.LblPhones.TabIndex = 7
        Me.LblPhones.Text = "Telefonos (separados por espacio)"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 207)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(539, 96)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
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
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.LblPhones)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormAltaPersona"
        Me.Text = "Alta Persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblCedula As Label
    Friend WithEvents LblName As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LblPhones As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents LblTitle As Label
End Class
