public class Punto
{
    private int x, y;
    public Punto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public int GetX() { return x; }
    public int GetY() { return y; }

    public override string ToString()
    {
        return $"Punto(x:{x},y:{y})";
    }

    public static Punto CrearPunto(Punto a, Punto b)
    {
        Random r = new Random();
        return new Punto(r.Next(a.x, b.x + 1), r.Next(a.y, b.y + 1));
    }
    public Boolean EstaDentro(Punto a, Punto b)
    {
        return x >= a.x && y >= a.y && x <= b.x && y <= b.y;
    }

    public double Distancia(Punto p)
    {
        int cat1, cat2;
        cat1 = x - p.x;
        cat2 = y - p.y;
        return Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    }

}
