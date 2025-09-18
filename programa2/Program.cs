// Coche.cs
public class Coche
{
    // Propiedades
    public string Matricula { get; private set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Velocidad { get; private set; }
    // Sobrecarga de constructores
    public Coche()
    {
        this.Matricula = "Sin Matricular";
        this.Marca = "Ford";
        this.Modelo = "Fiesta";
        this.Velocidad = 0;
    }
    public Coche(string Matricula, string Marca, string Modelo)
    {
        this.Matricula = Matricula;
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Velocidad = 0;
    }


    // Sobrecarga de métodos
    public void Acelerar()
    {
        this.Velocidad += 10;
    }
    public void Acelerar(int cuanto)
    {
        this.Velocidad += cuanto;
    }
    public void Frenar()
    {
        this.Velocidad -= 10;
    }
    public void Frenar(int cuanto)
    {
        this.Velocidad -= cuanto;
    }
    // Sobreescritura del método toString heredado de System.Object
    public override string ToString()
    {
        return $"El {Marca} {Modelo} {Matricula} va a {Velocidad} km/h";
    }
}
