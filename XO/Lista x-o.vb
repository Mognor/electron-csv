Public Class Lista_x_o
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB1.SelectedIndexChanged

    End Sub

    Private Sub Lista_x_o_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form2.Nombre = "Jugador 1" Then
            LB1.Items.Add(Form2.txtjugador1.Text)
        ElseIf Form2.Nombre = "Jugador 2" Then
            LB1.Items.Add(Form2.txtjugador2.Text)
        End If
    End Sub
End Class