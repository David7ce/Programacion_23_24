namespace Geometria;
public abstract class Figura
{
    protected Punto posicion;
    public int GetX() { return posicion.GetX(); }
    public int GetY() { return posicion.GetY(); }

    public Figura() : this(1, 1)
    {
    }
    public Figura(int x, int y)
    {
        posicion = new Punto(x, y);
    }

    public abstract double Area();
    public abstract double Perimetro();

    //public virtual double Area()
    //{
    //    return -1;
    //    //throw new NotImplementedException();
    //}


    public override String ToString()
    {
        return $"{GetType().Name}[x:{GetX()};y:{GetY()};área:{Area():f2};perímetro:{Perimetro():f2}]";
    }
}
