<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lista_x_o
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LB1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LB1
        '
        Me.LB1.FormattingEnabled = True
        Me.LB1.Location = New System.Drawing.Point(12, 21)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(120, 264)
        Me.LB1.TabIndex = 0
        '
        'Lista_x_o
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(157, 316)
        Me.Controls.Add(Me.LB1)
        Me.Name = "Lista_x_o"
        Me.Text = "Lista_x_o"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LB1 As ListBox
End Class
