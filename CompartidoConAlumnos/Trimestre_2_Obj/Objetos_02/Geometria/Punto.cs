namespace Geometria;
public class Punto
{
    private int x;
    private int y;
    public Punto() { }

    public Punto(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Punto(Punto p)
    {
        this.x = p.x;
        this.y = p.y;
    }
    public int GetX()
    {
        return x;
    }
    public void SetX(int x)
    {
        this.x = x;
    }
    public int GetY()
    {
        return y;
    }
    public void SetY(int y)
    {
        this.y = y;
    }
}
