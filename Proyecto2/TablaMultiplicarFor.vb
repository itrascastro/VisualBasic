Public Class TablaMultiplicarFor

    Dim n, m As Integer
    Dim salida As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim res As Integer

        TextBox3.Clear()
        salida = ""

        n = CInt(TextBox1.Text)
        m = CInt(TextBox2.Text)

        For i As Integer = 0 To m
            res = n * i
            salida = n & " x " & i & " = " & res
            TextBox3.Text = TextBox3.Text & salida & vbNewLine
        Next
    End Sub
End Class