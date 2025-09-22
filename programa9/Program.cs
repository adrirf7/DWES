enum DiaSemana
{
    Lunes,
    Martes,
    Miercoles,
    Jueves,
    Viernes,
    Sabado,
    Domingo
}
class Program
{
    static void Main()
    {
        DiaSemana dia = DiaSemana.Viernes;
        Console.WriteLine(dia);           // Viernes
        Console.WriteLine((int)dia);      // 4
    }
}
