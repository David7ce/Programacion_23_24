namespace Geometria;
public class Circulo : Figura
{
    private int radio;

    public Circulo(int radio)
    {
        this.radio = Math.Abs(radio);
    }
    public Circulo(int x, int y, int radio) : base(x, y)
    {
        this.radio = Math.Abs(radio);
    }

    public int GetRadio() { return radio; }
    public override double Perimetro()
    {
        return 2 * Math.PI * radio;
    }
    public override double Area()
    {
        return Math.PI * radio * radio;
    }
}
