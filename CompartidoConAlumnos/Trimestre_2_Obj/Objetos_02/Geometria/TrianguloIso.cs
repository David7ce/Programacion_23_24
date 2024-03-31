namespace Geometria;
public class TrianguloIso : Figura
{
    private int alto;
    private int base1;

    public TrianguloIso(int x, int y, int base1, int alto) : base(x, y)
    {
        this.alto = Math.Abs(alto);
        this.base1 = Math.Abs(base1);
    }
    public int GetBase()
    {
        return this.base1;

    }
    public int GetAlto()
    {
        return this.alto;

    }
    public override double Area()
    {
        return base1 * alto / 2.0;
    }
    private double LadoHipotenusa()
    {
        double mediaBase = base1 / 2.0;
        return Math.Sqrt(alto * alto + mediaBase * mediaBase);
    }
    public override double Perimetro()
    {
        return base1 + 2 * LadoHipotenusa();
    }
}
