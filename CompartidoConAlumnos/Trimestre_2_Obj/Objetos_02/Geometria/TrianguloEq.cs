namespace Geometria;
public class TrianguloEq : Figura // Triángulo Equilatero.
{
    private int lado;

    public TrianguloEq(int x, int y, int lado) : base(x, y)
    {
        this.lado = lado;
    }

    public int GetBase()
    {
        return lado;
    }
    public double GetAlto()
    {
        int base2 = lado * lado;
        return Math.Sqrt(base2 - base2 / 4);
    }


    public override double Perimetro()
    {
        return lado * 3;
    }

    public override double Area()
    {
        return (lado * GetAlto()) / 2.0;
    }
}