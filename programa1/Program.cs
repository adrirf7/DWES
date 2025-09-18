using System;

class Programa1
{
    static void Main()
    {
        int x = 23;
        byte y = 3;
        byte z = (byte)(x + y);
        Console.WriteLine(z);

        Console.WriteLine($"El tipo int ocupa {sizeof(int)} bytes y su valor máximo es {int.MinValue}");
        Console.WriteLine($"El tipo double ocupa {sizeof(double)} bytes y su valor máximo es {double.MaxValue}");
        Console.WriteLine($"El tipo bool ocupa {sizeof(bool)} bytes");
        Console.WriteLine($"El tipo char ocupa {sizeof(char)} bytes y su valor máximo es {(int)char.MaxValue}");
    }
}

