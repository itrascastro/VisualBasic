Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n1 As Integer
        Dim n2 As Integer
        Dim suma As Integer

        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)

        suma = n1 + n2

        TextBox3.Text = suma.ToString
    End Sub

End Class