public class Punto
{
    private const int X_LIM = 110;
    private const int Y_LIM = 25;
    private int x;
    private int y;


    ~Punto() { }

    public Punto() { }
    public Punto(int x, int y)
    {
        if (x < 0 | x > X_LIM | y < 0 | y > Y_LIM)
            throw new ArgumentException();
        this.x = x;
        this.y = y;
    }

    public void setX(int x)
    {
        if (x >= 0 && x <= X_LIM)
        {
            this.x = x;
        }
    }
    public void setY(int y)
    {
        if (y >= 0 && y <= Y_LIM)
        {
            this.y = y;
        }
    }
    public int getX()
    {
        return x;
    }
    public int getY()
    {
        return y;
    }

    public void arriba()
    {
        if (y == 0)
            y = Y_LIM;
        else
            y--;
    }
    public void abajo()
    {
        if (y == Y_LIM)
            y = 0;
        else
            y++;
    }

    public void izquierda()
    {
        if (x == 0)
            x = X_LIM;
        else
            x--;
    }

    public void derecha()
    {
        if (x == X_LIM)
            x = 0;
        else
            x++;
    }

}
