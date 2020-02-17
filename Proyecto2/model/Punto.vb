Public Class Punto
    Private x As Integer
    Private y As Integer

    Public Sub New()
        Me.setX(0)
        Me.setY(0)
    End Sub

    Public Sub New(x As Integer, y As Integer)
        Me.setX(x)
        Me.setY(y)
    End Sub

    Public Sub setY(y As Integer)
        Me.y = y
    End Sub

    Public Sub setX(x As Integer)
        Me.x = x
    End Sub

    Public Function getX() As Integer
        Return Me.x
    End Function

    Public Function getY() As Integer
        Return Me.y
    End Function

    Public Function Iguales(p As Punto) As Boolean
        Return Me.getX() = p.getX() And Me.getY() = p.getY()
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me.getX() = obj.getX() And Me.getY() = obj.getY()
    End Function

    Public Overrides Function ToString() As String
        Return "(" & Me.getX() & ", " & Me.getY() & ")"
    End Function

    Public Sub mover(p As Punto)
        Me.setX(p.getX())
        Me.setY(p.getY())
    End Sub

    Public Function distancia(p As Punto) As Double
        Return Math.Sqrt(Math.Pow(Me.getX() - p.getX(), 2) + Math.Pow(Me.getY() - p.getY(), 2))
    End Function
End Class
