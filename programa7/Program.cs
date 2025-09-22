using System;


interface IFigura
{
    double Longitud();
    double Area();
    string Dibujar();
}


public class Circulo : IFigura
{
    public double Radio { get; set; }


    public Circulo(double radio)
    {
        this.Radio = radio;
    }


    public double Longitud()
    {
        return 2 * Math.PI * Radio;
    }


    public double Area()
    {
        return Math.PI * Radio * Radio;
    }


    public string Dibujar()
    {
        return "Dibujando un círculo";
    }
}


public class Rectangulo : IFigura
{
    public double Ancho { get; set; }
    public double Alto { get; set; }


    public Rectangulo(double ancho, double alto)
    {
        this.Ancho = ancho;
        this.Alto = alto;
    }


    public double Longitud()
    {
        return 2 * (Ancho + Alto);
    }


    public double Area()
    {
        return Ancho * Alto;
    }


    public string Dibujar()
    {
        return "Dibujando un rectángulo";
    }
}


class Program
{
    static void Main()
    {
        IFigura figura1 = new Circulo(3);
        IFigura figura2 = new Rectangulo(4, 5);


        Console.WriteLine(figura1.Dibujar());
        Console.WriteLine($"Área: {figura1.Area()}");
        Console.WriteLine($"Longitud: {figura1.Longitud()}");
        Console.WriteLine();


        Console.WriteLine(figura2.Dibujar());
        Console.WriteLine($"Área: {figura2.Area()}");
        Console.WriteLine($"Longitud: {figura2.Longitud()}");
    }
}
