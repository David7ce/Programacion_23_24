namespace Pruebas.Programacion;
using Geometria;

public class Program
{
    public static void Main(String[] args)
    {
        //Console.WriteLine("Areas total: " + AreaRectangulos(CreaRectangulos()));

        //Crear_y_Mostrar_ListarFigurasDeCSV("datosDePrueba.csv");
        //FigurasDeFichero01();

        //FiguraConHerencia01();
        //ConstructoresEnHerencia();
    }


    private static void ConstructoresEnHerencia()
    {
        Console.Clear();
        Biologia.Animal gato = new Biologia.Mamifero("Macho", 4, 2, 1.4, "Romano", "gris", true);
        Console.WriteLine($"El Gato:{gato}");
        Console.WriteLine("-----------------------------");
        Biologia.Cetaceo ballena = new Biologia.Cetaceo("Macho", 2, 1000.4, "Jorobada");
        Console.WriteLine($"La Ballena: {ballena}");
        Console.WriteLine("-----------------------------");
        Biologia.Mujer idara = new Biologia.Mujer(25, 57.3, "Castaño", true, false, false);
        Console.WriteLine($"Idara: {idara}");
        Console.WriteLine("-----------------------------");
        Biologia.Hombre romen = new Biologia.Hombre(25, 77.76, "Moreno", true, false);
        Console.WriteLine($"Romen: {romen}");
        Console.WriteLine("-----------------------------");
    }
    private static void FiguraConHerencia01()
    {
        Figura[] figuras = {
            new Rectangulo(1, 1, 5, 8),
            new Rectangulo(1, 1, 5, 10),
            new Circulo(1, 1, 3),
            new Trapecio(1,1, 5,10,8),
            new Casita(5,5, 10)
        };
        Random random = new Random();
        Figura elegida = figuras[random.Next(figuras.Length)];
        Console.WriteLine("Area: " + elegida.Area());
        Console.WriteLine("Es de la clase " + elegida.GetType());

        foreach (Figura f in figuras)
        {
            Console.WriteLine(f);
        }
    }
    private static void Crear_y_Mostrar_ListarFigurasDeCSV(String fichero)
    {
        String[,] datos;
        datos = HojaCalculo.datos(fichero);
        Tablas.mostrar(datos, 15);
    }

    private static void FigurasDeFichero01()
    {
        Object fig;
        String[,] datos = HojaCalculo.datos("datosDePrueba.csv");
        for (int f = 0; f < datos.GetLength(0); f++)
        {
            switch (datos[f, 0])
            {
                case "Rectangulo":
                    fig = new Rectangulo(toInt(datos[f, 1]), toInt(datos[f, 2]),
                                                    toInt(datos[f, 3]), toInt(datos[f, 4]));
                    break;

                case "Circulo":
                    fig = new Circulo(toInt(datos[f, 1]), toInt(datos[f, 2]),
                                                    toInt(datos[f, 3]));
                    break;
                case "TrianguloEq":
                    fig = new TrianguloEq(toInt(datos[f, 1]), toInt(datos[f, 2]),
                                                    toInt(datos[f, 3]));
                    break;
                case "TrianguloIso":
                    fig = new TrianguloIso(toInt(datos[f, 1]), toInt(datos[f, 2]),
                                                    toInt(datos[f, 3]), toInt(datos[f, 4]));
                    break;
                default:
                    fig = null;
                    Console.WriteLine(String.Format("No conozco la figura {0}.", datos[f, 0]));
                    break;
                    //throw new Exception($"No conozco la figura {datos[f, 0]}.");
            }
            Console.WriteLine(fig);
        }
    }
    private static int toInt(string v) { return Convert.ToInt32(v); }

    public static Rectangulo[] CreaRectangulos()
    {
        Rectangulo[] rect =
        {
            new Rectangulo(0,0,2,2),
            new Rectangulo(4,12,2,2),
            new Rectangulo(15,10,5,-5),
            new Rectangulo(40,4,1,1)
        };
        return rect;
    }
    private static double AreaRectangulos(Rectangulo[] l)
    {
        double aTot = 0;
        for (int i = 0; i < l.Length; i++)
        {
            aTot += l[i].Area();
        }
        return aTot;
    }
}
