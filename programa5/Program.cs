using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Vamos a crear un coche con un motor");
        Coche miCoche = new Coche("1234ABC", "Ford", "Fiesta", "Híbrido", 100);
        Console.WriteLine(miCoche.ToString());
    }
}


public class Motor
{
    public string Combustible { get; set; } // Diesel, Gasolina, Eléctrico, Híbrido
    public int Caballos { get; set; }


    public Motor()
    {
        this.Combustible = "Híbrido";
        this.Caballos = 100;
    }


    public Motor(string Combustible, int Caballos)
    {
        this.Combustible = Combustible;
        this.Caballos = Caballos;
    }


    public override string ToString()
    {
        return $"Motor {Combustible} de {Caballos} caballos";
    }
}


public class Coche
{
    // Propiedades
    public string Matricula { get; private set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public Motor TipoMotor { get; set; }
    public Coche()
    {
        this.Matricula = "SinMatricula";
        this.Marca = "Desconocida";
        this.Modelo = "Desconocido";
        this.TipoMotor = new Motor();
    }
    public Coche(string Matricula, string Marca, string Modelo, string Combustible, int Caballos)
    {
        this.Matricula = Matricula;
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.TipoMotor = new Motor(Combustible, Caballos);
    }


    // Sobreescritura del método toString heredado de System.Object
    public override string ToString()
    {
        return $"{Marca} {Modelo} {Matricula} Motor: {TipoMotor.Combustible} {TipoMotor.Caballos} Caballos";
    }
}
