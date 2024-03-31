namespace Principal;

using Geometria;
public class Program
{
    static void Main(string[] args)
    {
        //pruebaEqual_01();
        pruebaEqual_02();
    }

    private static void pruebaEqual_02()
    {
        Punto[] puntos = {
            new Punto(5, 6),
            new Punto(15, 0),
            new Punto(0, 0),
            new Punto(3, 20)
        };
        Punto x = new Punto(5, 6);
        foreach (Punto p in puntos) { 
            Console.WriteLine(p);
        }
        if (puntos.Contains(x))
            Console.WriteLine($"{x} está");
        else
            Console.WriteLine($"{x} NO está");
    }

    private static void pruebaEqual_01()
    {
        Object p = new Punto(5, 6);
        //Punto q = p;
        Punto q = new Punto(5, 6);
        if (p.Equals(q))
            Console.WriteLine($"{p} y {q} son iguales");
        else
            Console.WriteLine($"{p} y {q} NO son iguales");
    }
}