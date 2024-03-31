public class Jugador
{
    private string nombre;
    private int puntos;
    public Jugador(string nombre) : this(nombre, 0) { }
    public Jugador(string nombre, int puntos)
    {
        if (puntos < 0 || nombre == null || nombre.Length == 0)
            throw new Exception("Un Jugador no puede tener una puntuación negativa, ni adolecer de nombre");
        this.nombre = nombre;
        this.puntos = puntos;
    }
    public String GetNombre => nombre;

    public int GetPuntos()
    {
        return puntos;
    }





    public override string ToString()
    {
        String s = nombre;
        if (puntos != 0)
            s += $" con {puntos} puntos";
        return s;
    }
}