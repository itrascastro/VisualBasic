Public Class Form2
    Dim n1 As Integer
    Dim n2 As Integer
    Dim res As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        entrada()

        res = n1 + n2

        salida()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        entrada()

        res = n1 - n2

        salida()
    End Sub

    Private Sub entrada()
        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)
    End Sub

    Private Sub salida()
        TextBox3.Text = res.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        entrada()

        res = n1 * n2

        salida()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        entrada()

        If n2 <> 0 Then
            res = n1 / n2
        Else
            res = 0
        End If

        salida()
    End Sub
End Class