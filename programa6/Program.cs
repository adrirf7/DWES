using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Vamos a aplicar Herencia en C#");
        Vehiculo miVehiculo = new Coche("1234ABC", "Suzuki", "Ignis", 5);
        Console.WriteLine(miVehiculo);
        Console.WriteLine(miVehiculo.Acelerar());
    }
}


public class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Matricula { get; set; }
    public Vehiculo()
    {
        this.Matricula = "SinMatricula";
        this.Marca = "Desconocida";
        this.Modelo = "Desconocido";
    }
    public Vehiculo(string Matricula, string Marca, string Modelo)
    {
        this.Matricula = Matricula;
        this.Marca = Marca;
        this.Modelo = Modelo;
    }
    public virtual string Acelerar()
    {
        return "El vehículo acelera";
    }
    public override string ToString()
    {
        return $"{Marca} {Modelo} {Matricula}";
    }
}


public class Coche : Vehiculo
{
    public int NumeroPuertas { get; set; }


    public Coche() : base() { }
    public Coche(string Matricula, string Marca, string Modelo, int NumeroPuertas) : base(Matricula, Marca, Modelo)
    {
        this.NumeroPuertas = NumeroPuertas;
    }


    public override string ToString()
    {
        return base.ToString() + $" ({NumeroPuertas} puertas)";
    }

    public override string Acelerar()
    {
        return "El coche acelera";
    }
}
