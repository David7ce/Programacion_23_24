namespace Geometria;
public class Trapecio : Figura
{
    private int baseMayor;
    private int baseMenor;
    private int alto;

    public Trapecio(int x, int y, int alto, int baseMayor, int baseMenor)
    {
        this.baseMayor = Math.Abs(baseMayor);
        this.baseMenor = Math.Abs(baseMenor);
        this.alto = Math.Abs(alto);
        posicion = new Punto(x, y);
    }
    public override double Area()
    {
        return (baseMayor + baseMenor) / 2.0 * alto;
    }
    public override double Perimetro()
    {
        double cateto = (baseMayor - baseMenor) / 2.0;
        double ladoInclinado = Math.Sqrt(alto * alto + cateto * cateto);
        return 2 * ladoInclinado + baseMayor + baseMenor;
    }
}

