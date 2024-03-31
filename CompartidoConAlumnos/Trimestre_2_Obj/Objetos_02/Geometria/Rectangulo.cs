namespace Geometria;
public class Rectangulo : Figura
{
    private int ancho;
    private int alto;

    public Rectangulo(int x, int y, int alto, int ancho) : base(x, y)
    {
        this.ancho = Math.Abs(ancho);
        this.alto = Math.Abs(alto);
    }

    public int GetAncho() { return ancho; }
    public int GetAlto() { return alto; }

    public override double Perimetro()
    {
        return 2 * alto + 2 * ancho;
    }
    public override double Area()
    {
        return alto * ancho;
    }

}
