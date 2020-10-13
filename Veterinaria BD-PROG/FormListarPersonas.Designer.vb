<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListarPersonas
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
        Me.ListarButton = New System.Windows.Forms.Button()
        Me.PersonasListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListarButton
        '
        Me.ListarButton.Location = New System.Drawing.Point(664, 389)
        Me.ListarButton.Name = "ListarButton"
        Me.ListarButton.Size = New System.Drawing.Size(124, 49)
        Me.ListarButton.TabIndex = 0
        Me.ListarButton.Text = "Listar Personas"
        Me.ListarButton.UseVisualStyleBackColor = True
        '
        'PersonasListBox
        '
        Me.PersonasListBox.FormattingEnabled = True
        Me.PersonasListBox.Location = New System.Drawing.Point(12, 5)
        Me.PersonasListBox.Name = "PersonasListBox"
        Me.PersonasListBox.Size = New System.Drawing.Size(646, 433)
        Me.PersonasListBox.TabIndex = 1
        '
        'FormListarPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PersonasListBox)
        Me.Controls.Add(Me.ListarButton)
        Me.Name = "FormListarPersonas"
        Me.Text = "FormListarPersonas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListarButton As Button
    Friend WithEvents PersonasListBox As ListBox
End Class
