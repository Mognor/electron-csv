Public Class Form1

    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click
        BTN1.Enabled = False
        Cont = Cont + 1
        If cont Mod 2 Then
            BTN1.Text = "x"
        Else
            BTN1.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub
    Dim X As String
    Dim O As String
    Dim Cont As Integer = 0
    Dim Empate As Integer = 0
    Private Sub BTN2_Click(sender As Object, e As EventArgs) Handles BTN2.Click
        BTN2.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN2.Text = "x"
        Else
            BTN2.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTN3_Click(sender As Object, e As EventArgs) Handles BTN3.Click
        BTN3.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN3.Text = "x"
        Else
            BTN3.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTN4_Click(sender As Object, e As EventArgs) Handles BTN4.Click
        BTN4.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN4.Text = "x"
        Else
            BTN4.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTN5_Click(sender As Object, e As EventArgs) Handles BTN5.Click
        BTN5.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN5.Text = "x"
        Else
            BTN5.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTN6_Click(sender As Object, e As EventArgs) Handles BTN6.Click
        BTN6.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN6.Text = "x"
        Else
            BTN6.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTN7_Click(sender As Object, e As EventArgs) Handles BTN7.Click
        BTN7.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN7.Text = "x"
        Else
            BTN7.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTN8_Click(sender As Object, e As EventArgs) Handles BTN8.Click
        BTN8.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN8.Text = "x"
        Else
            BTN8.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTN9_Click(sender As Object, e As EventArgs) Handles BTN9.Click
        BTN9.Enabled = False
        Cont = Cont + 1
        If Cont Mod 2 Then
            BTN9.Text = "x"
        Else
            BTN9.Text = "0"
        End If
        Evaluar()
        EvaluarO()
    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        BTN1.Enabled = True
        BTN2.Enabled = True
        BTN3.Enabled = True
        BTN4.Enabled = True
        BTN5.Enabled = True
        BTN6.Enabled = True
        BTN7.Enabled = True
        BTN8.Enabled = True
        BTN9.Enabled = True
        BTN1.Text = " "
        BTN2.Text = " "
        BTN3.Text = " "
        BTN4.Text = " "
        BTN5.Text = " "
        BTN6.Text = " "
        BTN7.Text = " "
        BTN8.Text = " "
        BTN9.Text = " "



    End Sub
    Public Sub Evaluar()
        If (BTN1.Text = "x" And BTN2.Text = "x" And BTN3.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        ElseIf (BTN4.Text = "x" And BTN5.Text = "x" And BTN6.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        ElseIf (BTN7.Text = "x" And BTN8.Text = "x" And BTN9.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        ElseIf (BTN1.Text = "x" And BTN4.Text = "x" And BTN7.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        ElseIf (BTN2.Text = "x" And BTN5.Text = "x" And BTN8.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        ElseIf (BTN3.Text = "x" And BTN6.Text = "x" And BTN9.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        ElseIf (BTN1.Text = "x" And BTN5.Text = "x" And BTN9.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        ElseIf (BTN3.Text = "x" And BTN5.Text = "x" And BTN7.Text = "x") Then
            MessageBox.Show("X : GANADOR :)")
            FIN()
        End If
    End Sub
    Public Sub EvaluarO()
        If (BTN1.Text = "0" And BTN2.Text = "0" And BTN3.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        ElseIf (BTN4.Text = "0" And BTN5.Text = "0" And BTN6.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        ElseIf (BTN7.Text = "0" And BTN8.Text = "0" And BTN9.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        ElseIf (BTN1.Text = "0" And BTN4.Text = "0" And BTN7.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        ElseIf (BTN2.Text = "0" And BTN5.Text = "0" And BTN8.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        ElseIf (BTN3.Text = "0" And BTN6.Text = "0" And BTN9.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        ElseIf (BTN1.Text = "0" And BTN5.Text = "0" And BTN9.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        ElseIf (BTN3.Text = "0" And BTN5.Text = "0" And BTN7.Text = "0") Then
            MessageBox.Show("0 : GANADOR :)")
            FIN()
        End If
    End Sub
    Public Sub FIN()
        BTN1.Enabled = False
        BTN2.Enabled = False
        BTN3.Enabled = False
        BTN4.Enabled = False
        BTN5.Enabled = False
        BTN6.Enabled = False
        BTN7.Enabled = False
        BTN8.Enabled = False
        BTN9.Enabled = False
    End Sub
End Class
