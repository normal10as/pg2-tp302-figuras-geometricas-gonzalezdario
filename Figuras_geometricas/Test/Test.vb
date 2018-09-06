Imports Figuras

Module Test

    Sub Main()
        Dim f As New Figura("Figurita-sensei")
        Console.WriteLine("Figura: " & f.Nombre)
        Console.WriteLine()

        Dim t As New Triangulo("Triangulito-kun", 5, 3)
        Console.WriteLine("Figura: " & t.Nombre)
        Console.WriteLine("Base: {0}cm  Altura: {1}cm", t.Base, t.Altura)
        Console.WriteLine("Area: " & t.calcularArea() & "cm2")
        Console.WriteLine()

        Dim c As New Cuadrado("Cuadradita-chan", 5)
        Console.WriteLine("Figura: " & c.Nombre)
        Console.WriteLine("Lado: {0}cm", c.Lado)
        Console.WriteLine("Area: " & c.calcularArea() & "cm2")
        Console.WriteLine()

        Dim cir As New Circulo("Circulo-senpai", 3)
        Console.WriteLine("Figura: " & cir.Nombre)
        Console.WriteLine("Radio:  {0}cm", cir.Radio)
        Console.WriteLine("Area: " & cir.calcularArea() & "cm2")
        Console.WriteLine()

        Dim r As New Rectangulo("Rectangulo-niichan", 7, 4)
        Console.WriteLine("Figura: " & r.Nombre)
        Console.WriteLine("Base: {0}cm  Altura: {1}cm", r.Base, r.Altura)
        Console.WriteLine("Area: " & r.calcularArea() & "cm2")
        Console.WriteLine()
    End Sub

End Module