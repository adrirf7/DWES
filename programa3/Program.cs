using System;
using Hogar.Mascotas;
class Program
{
    static void Main()
    {
        Mascota m = new Mascota();
        m.Nombre = "Lucas";
        m.Especie = "Gato";
        m.Raza = "Bengalí";
        m.Edad = 2;
        m.Peso = 3;


        Console.WriteLine($"Nombre: {m.Nombre}");
        Console.WriteLine($"Especie: {m.Especie}");
        Console.WriteLine($"Raza: {m.Raza}");
        Console.WriteLine($"Edad: {m.Edad}");
        Console.WriteLine($"Peso: {m.Peso}");
    }
}