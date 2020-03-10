<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Jugador1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtjugador1 = New System.Windows.Forms.TextBox()
        Me.txtjugador2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Jugador1
        '
        Me.Jugador1.AutoSize = True
        Me.Jugador1.Location = New System.Drawing.Point(56, 20)
        Me.Jugador1.Name = "Jugador1"
        Me.Jugador1.Size = New System.Drawing.Size(54, 13)
        Me.Jugador1.TabIndex = 0
        Me.Jugador1.Text = "Jugador 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jugador 2"
        '
        'txtjugador1
        '
        Me.txtjugador1.Location = New System.Drawing.Point(35, 59)
        Me.txtjugador1.Name = "txtjugador1"
        Me.txtjugador1.Size = New System.Drawing.Size(100, 20)
        Me.txtjugador1.TabIndex = 2
        '
        'txtjugador2
        '
        Me.txtjugador2.Location = New System.Drawing.Point(35, 131)
        Me.txtjugador2.Name = "txtjugador2"
        Me.txtjugador2.Size = New System.Drawing.Size(100, 20)
        Me.txtjugador2.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Iniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 240)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtjugador2)
        Me.Controls.Add(Me.txtjugador1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Jugador1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Jugador1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtjugador1 As TextBox
    Friend WithEvents txtjugador2 As TextBox
    Friend WithEvents Button1 As Button
End Class
