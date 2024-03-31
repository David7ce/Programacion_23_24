namespace Geometria;
public class Casita : Figura
{
    private TrianguloEq tejado;
    private Cuadrado fachada;

    public Casita(int x, int y, int ancho) : base(x, y)
    {
        tejado = new TrianguloEq(x, y, ancho);
        fachada = new Cuadrado(x, y + (int)tejado.GetAlto(), ancho);
    }
    public double GetAlto()
    {
        return tejado.GetAlto() + fachada.GetAlto();
    }
    public double GetAncho()
    {
        return fachada.GetAncho();
    }

    public override double Area()
    {
        return fachada.Area() + tejado.Area();
    }
    public override double Perimetro()
    {
        return 5 * tejado.GetBase();
    }

    public override String ToString()
    {
        return $"Casita preciosa de {Area():f2} metros cuadrados.";
    }
}
