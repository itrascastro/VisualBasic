Public Class OrdenarTresValores
    'entradas
    Dim n1, n2, n3 As Integer
    'salidas
    Dim mayor, med, menor As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
        n3 = CInt(TextBox3.Text)

        If (n1 > n2 And n1 > n3) Then
            mayor = n1

            If (n2 > n3) Then
                med = n2
                menor = n3
            Else
                med = n3
                menor = n2
            End If
        ElseIf (n2 > n1 And n2 > n3) Then
            mayor = n2

            If (n1 > n3) Then
                med = n1
                menor = n3
            Else
                med = n3
                menor = n1
            End If
        Else
            mayor = n3

            If (n1 > n2) Then
                med = n1
                menor = n2
            Else
                med = n2
                menor = n1
            End If
        End If

        TextBox4.Text = mayor.ToString
        TextBox5.Text = med.ToString
        TextBox6.Text = menor.ToString
    End Sub
End Class