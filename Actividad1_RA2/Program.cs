
class Actividad1
{
    static void Main()
    {
        int opcion;
        int[] tirada = null;
        do
        {
            MostarMenu();
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        tirada = NuevaTirada();
                        break;

                    case 2:
                        MostrarTirada(tirada);
                        break;
                    case 3:
                        Console.Write($"Valor de la tirada : {MostrarValorTirada(tirada)}");
                        break;
                    case 4:
                        MostrarValorMedioTirada(tirada);
                        break;
                    case 5:
                        ConteoDeNumeros(tirada);
                        break;
                }
            }
        } while (opcion != 6);
    }

    static void MostarMenu()
    {
        string[] opciones = { "Nueva tirada", "Mostrar tirada", "Mostrar valor de la tirad", "Mostrar valor medio de la tirada", "Contar cuántas veces salió cada número (1 a 6)", "Terminar programa" };
        Console.WriteLine("------------------------------------");
        for (int i = 0; i < opciones.Length; i++)
        {
            Console.WriteLine($"{i + 1}.- {opciones[i]}");
        }
        Console.Write("---Ingrese una opcion: ");
    }

    //Generar una nueva tirada aleatoria
    static int[] NuevaTirada()
    {
        Random random = new Random();
        int[] tirada = new int[10];

        for (int i = 0; i < tirada.Length; i++)
        {
            tirada[i] = random.Next(1, 7);
        }

        Console.WriteLine("Tirada generada correctamente");
        return tirada;
    }

    //Mosrar la tirada generada
    static void MostrarTirada(int[] tirada)
    {
        for (int i = 0; i < tirada.Length; i++)
        {
            Console.Write($"Tirada {i}: {tirada[i]}||");
        }
    }

    //Mostrar el valor de la tirada generada
    static int MostrarValorTirada(int[] tirada)
    {
        int suma = 0;
        for (int i = 0; i < tirada.Length; i++)
        {
            suma += tirada[i];
        }
        return suma;
    }

    //Mostrar la media de la tirada
    static void MostrarValorMedioTirada(int[] tirada)
    {
        int suma = MostrarValorTirada(tirada);
        double media = (double)suma / tirada.Length;

        Console.WriteLine($"Valor medio de la tirada: {media}");
    }

    //Mosrar cuantas veces salio cada numero en la tirada
    static void ConteoDeNumeros(int[] tirada)
    {
        int[] contador = new int[6];

        for (int i = 0; i < tirada.Length; i++)
        {
            int numero = tirada[i];

            if (numero >= 1 && numero <= 6)
            {
                contador[numero - 1]++;
            }
        }

        Console.WriteLine("Recuento de números (1 a 6):");
        for (int i = 0; i < contador.Length; i++)
        {
            Console.WriteLine($"Número {i + 1}: {contador[i]} veces");
        }
    }
}