Public Class Arrays1D
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num() As Integer = {1, 2, -4}
        Dim i As Integer
        Dim n, n2, n3 As String

        For i = 0 To 2
            n = num(i).ToString
            n2 = (Math.Pow(num(i), 2)).ToString
            n3 = (Math.Pow(num(i), 3)).ToString
            TextBox1.Text += n + ", " + n2 + ", " + n3 + vbNewLine
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num(14) As Integer
        Dim Random As New Random()
        Dim i As Integer
        Dim N As Integer = 4
        Dim sum As Integer = 0

        For i = 0 To 14
            num(i) = Random.Next(-50, 50)
        Next

        For i = 0 To N - 1
            sum += num(i)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num(19) As Integer
        Dim Random As New Random()
        Dim i As Integer
        Dim encontrado As Boolean = False
        Dim out As String = ""

        For i = 0 To 19
            num(i) = Random.Next(-50, 50)
        Next

        For i = 0 To 19
            If num(i) > 30 Then
                encontrado = True
                out += num(i) + " " + i
            End If
        Next

        If Not encontrado Then
            TextBox1.Text = "No hay números mayores que 30"
        Else
            TextBox1.Text = out
        End If

    End Sub
End Class