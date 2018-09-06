Public Class Circulo
    Inherits Figura
    Private _radio As UShort

    Public Property Radio As UShort
        Get
            Return _radio
        End Get
        Set(value As UShort)
            _radio = value
        End Set
    End Property

    Sub New(Nombre As String, Radio As UShort)
        MyBase.New(Nombre)
        Me.Radio = Radio
    End Sub

    Public Overrides Function calcularArea() As Single
        Dim pi As Single = Math.PI
        Return (Radio * Radio) * pi
    End Function
End Class
