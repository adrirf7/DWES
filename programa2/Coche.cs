using System;

class Program
{
    static void Main()
    {
        Coche miCoche1 = new Coche();
        Coche miCoche2 = new Coche("1234ABC", "Toyota", "Yaris");
        miCoche1.Acelerar();
        miCoche2.Acelerar(50);
        miCoche2.Frenar(10);
        Console.WriteLine(miCoche1);
        Console.WriteLine(miCoche2);
        //miCoche1.Velocidad = 50; // Error
        // Velocidad es de sólo lectura.
    }
}
