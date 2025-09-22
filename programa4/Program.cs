using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Vamos a aparcar un coche en una plaza");
        Coche miCoche = new Coche("1234ABC", "Opel", "Corsa");
        Plaza miPlaza = new Plaza(23, miCoche);
        Console.WriteLine(miPlaza.ToString());
    }
}


public class Coche
{
    // Propiedades
    public string Matricula { get; private set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }


    public Coche()
    {
        this.Matricula = "SinMatricula";
        this.Marca = "Desconocida";
        this.Modelo = "Desconocido";
    }
    public Coche(string Matricula, string Marca, string Modelo)
    {
        this.Matricula = Matricula;
        this.Marca = Marca;
        this.Modelo = Modelo;
    }


    // Sobreescritura del método toString heredado de System.Object
    public override string ToString()
    {
        return $"{Marca} {Modelo} {Matricula}";
    }
}


public class Plaza
{
    // Propiedades
    public int Numero { get; set; }
    public Coche CocheAparcado { get; set; }


    public Plaza(int Numero, Coche CocheAparcado)
    {
        this.Numero = Numero;
        this.CocheAparcado = CocheAparcado;
    }


    public override string ToString()
    {
        return $"{this.CocheAparcado.Marca} {this.CocheAparcado.Modelo} {this.CocheAparcado.Matricula} está en plaza {this.Numero}";
    }
}



