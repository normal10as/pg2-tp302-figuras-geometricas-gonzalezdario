Public Class Triangulo
    Inherits Figura

    Private _base As UShort
    Private _altura As UShort

    Public Property Base As UShort
        Get
            Return _base
        End Get
        Set(value As UShort)
            _base = value
        End Set
    End Property

    Public Property Altura As UShort
        Get
            Return _altura
        End Get
        Set(value As UShort)
            _altura = value
        End Set
    End Property

    Sub New(Nombre As String, Base As UShort, Altura As UShort)
        MyBase.New(Nombre)
        Me.Base = Base
        Me.Altura = Altura
    End Sub

    Public Overrides Function calcularArea() As Single
        Return (Base * Altura) / 2
    End Function

End Class
