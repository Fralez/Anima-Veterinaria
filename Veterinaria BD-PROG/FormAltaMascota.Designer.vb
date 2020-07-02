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
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
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
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 154)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(542, 20)
        Me.TextBox3.TabIndex = 15
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 112)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(542, 20)
        Me.TextBox2.TabIndex = 13
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(542, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(704, 395)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 38)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "CREAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormAltaMascota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.LblBirthDate)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormAltaMascota"
        Me.Text = "Alta Mascota"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblBirthDate As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
