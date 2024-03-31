namespace MetroTenerife;
public class Pasajero
{
    private static List<String> nombreUsados = new List<string>();
    private string nombre;
    public Pasajero(string nombre)
    {
        if (nombreUsados.Contains(nombre))
            throw new ArgumentException();
        this.nombre = nombre;
        nombreUsados.Add(nombre);
    }
    public string GetNombre()
    {
        return nombre;
    }

    public override string ToString()
    {
        return $"Pasajero: {nombre}";
    }
}
