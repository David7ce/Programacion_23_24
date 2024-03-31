using System.Drawing;

namespace Geometria;
public class Punto
{
    private int _x, _y;

    public int X
    {
        get { return _x; }
        //set { if (value >= 0) _x = value; }
        set
        {
            if (value < 0) throw new Exception();
            _x = value;
        }
    }
    public int Y
    {
        get { return _y; }
        set
        {
            if (value < 0) throw new Exception();
            _y = value;
        }
    }

    public Punto() { }

    public Punto(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Punto(Punto p) : this(p.X, p.Y) { }
    public override string ToString()
    {
        return $"({_x},{_y})";
    }

    public override bool Equals(object? obj)
    {
        bool iguales;
        if (obj == null || !(obj is Punto))
            iguales = false;
        else
        {
			Punto elOtro = (Punto)obj;
			iguales = ( X == elOtro.X && Y == elOtro.Y );
		}
        return iguales;
	}
}
