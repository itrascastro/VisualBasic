Module PruebaPunto
    Dim p As New Punto()
    Dim p1 As New Punto(2, 3)

    Sub prueba()
        p.mover(p1)
        Dim d As Double = p.distancia(p1)
        Dim cadena As String = p.ToString()
    End Sub

End Module
