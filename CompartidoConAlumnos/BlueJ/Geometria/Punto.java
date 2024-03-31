public class Punto
{
    private int x;
    private int y;
    private static int radio=5;
    
    public Punto() { }
    
    public Punto(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    public static int getRadio()
    {
        return radio;
    }
    public static void setRadio(int r)
    {
        Punto.radio = r;
    }
    
    public int getX()
    {
        return x;
    }
    public Punto setX(int x)
    {
        this.x = x;
        return this;
    }
    public int getY()
    {
        return y;
    }
    public Punto setY(int y)
    {
        this.y = y;
        return this;
    }


}
