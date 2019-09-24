Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declaracoón de variables
        'Entradas
        Dim n1 As Integer
        Dim n2 As Integer
        Dim suma As Integer

        'Asignación de variables
        'Procesado de la entrada
        n1 = 4
        n2 = 3
        suma = n1 + n2

        'Salida
        Label1.Text = suma.ToString
    End Sub
End Class
