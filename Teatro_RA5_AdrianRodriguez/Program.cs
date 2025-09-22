public class Cliente
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Cliente(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }
    public decimal ObtenerDescuentoPorEdad()
    {
        if (Edad > 0 && Edad < 10) return 0.50;
        if (Edad > 11 && Edad < 18) return 0.30;
        if (Edad > 19 && Edad < 26) return 0.10;
        if (Edad > 65) return 0.50;
        return 0.00;
    }
}

public class Obra
{
    public string Titulo { get; set; }
    public int Duracion { get; set; }
    public decimal Precio { get; set; }

    public Obra(string Titulo, int Duracion, decimal Precio)
    {
        this.Titulo = titulo;
        this.Duracion = duracion;
        this.Precio = Precio;
    }
}

public class Teatro
{
    public string Nombre { get; set; }
    public string Domicilio { get; set; }
    private Obra obra;
    private Cliente[,] sala;


    public Teatro(int filas, int butacasPorFila, Obra obra)
    {
        sala = new Cliente[filas, butacasPorFila];
        this.obra = obra;
    }

    public bool VenderEntrada(int fila, int butaca, Cliente cliente)
    {
        if (sala[fila, butaca] == null)
        {
            sala[fila, butaca] = cliente;
            return true;
        }
        return false;
    }
    public bool CancelarEntrada(int fila, int butaca)
    {
        if (sala[fila, butaca] != null)
        {
            sala[fila, butaca] = null;
            return true;
        }
        return false;
    }

    public string ListarLibres()
    {
        for (int i = 0; i < sala.GetLenght(0); i++)
        {
            for (int j = 0; j < sala.GetLenght(1); j++)
            {
                if (sala[i, j] == null)
                {
                    console.WriteLine($"Fila{i + 1} | Butaca {j + 1}: Libre");
                }
            }
        }
    }

    public string ListarOcupadas()
    {
        for (int i = 0; i < sala.GetLenght(0); i++)
        {
            for (int j = 0; j < sala.GetLenght(1); j++)
            {
                if (sala[i, j] != null)
                {
                    console.WriteLine($"Fila{i + 1} | Butaca {j + 1} " +
                    $"{sala[i, j].Nombre}, Edad: {sala[i, j].Edad}");
                }
            }
        }
    }

    public decimal CalcularRecaudacion()
}