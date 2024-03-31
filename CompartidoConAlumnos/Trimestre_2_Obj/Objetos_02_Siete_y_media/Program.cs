namespace Siete_y_media;

using Baraja;
public class Program
{
    static void Main(string[] args)
    {
        //PruebaNaipes();
        //PruebaJuego7yMedia();
        PruebaNaipes2();
        //PruebaNaipesIguales();
    }

    private static void PruebaNaipes2()
    {
        //Carta a, b;
        //a = new Carta(3, Palo.Copas);
        //b = new Carta(3, Palo.Copas);
        ////        if (a == b)
        //if (a.Equals(b))
        //    Console.WriteLine("Iguales");
        //else
        //    Console.WriteLine("Distintas");

        String a, b;
        a = "Javier";
        b = "Javier";
        //        if (a == b)
        if (a.Equals(b))
            Console.WriteLine("Iguales");
        else
            Console.WriteLine("Distintas");
    }
    private static void PruebaNaipesIguales()
    {
        Carta[] t = new Carta[] {
                            new Carta(1,Palo.Oros),
                            new Carta(2,Palo.Oros),
                            new Carta(5,Palo.Copas)
        };
        Carta x = new Carta(2, Palo.Oros);
        //Carta x = t[1];

        Console.WriteLine(t.Contains(x));


        //if (a.Equals(b))
        //    Console.WriteLine("Iguales");
        //else
        //    Console.WriteLine("Distintas");
    }

    private static void PruebaJuego7yMedia()
    {
        Mazo mazo = new Mazo();
        Mano mano = new ManoSieteyMedia();
        char opcion;
        try
        {
            do
            {
                mano.AñadeCarta(mazo.daCarta());
                Console.WriteLine(mano);
                Console.Write("¿Desea otra carta? (S/n): ");
                opcion = Char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (opcion != 'n');
            Console.WriteLine("Prudencia y suerte.");
        }
        catch (Exception)
        {
            Console.WriteLine(mano);
            Console.WriteLine("\nPerdiste por pasar el límite de 7.5 puntos.");
        }
        Console.WriteLine($"Tienes {mano.CuentaPuntos():f1} puntos");
    }

    private static void PruebaNaipes()
    {
        Mazo m = new Mazo();
        Carta[] cartas = new Carta[5];
        for (int i = 0; i < cartas.Length; i++)
            cartas[i] = m.daCarta();
        Tablas.mostrar(cartas);
    }




}