internal class Program
{
    static void Main(string[] args)
    {
        // pruebaParametros();
        pruebaIncremento1();
        pruebaIncremento2();
    }

    private static void pruebaIncremento2()
    {
        int numero = 0;
        int VECES = 8, LIM = 5;
        Console.WriteLine("La variable numero comienza con valor " + numero);
        Console.WriteLine("Se incrementa {0} veces.", VECES);
        for (int i = 1; i <= VECES; i++)
        {
            Funciones.incrementar(ref numero, LIM);
            Console.WriteLine("Ahora, numero vale " + numero);
        }
        Console.WriteLine("Se decrementa {0} veces.", VECES);
        for (int i = 1; i <= VECES; i++)
        {
            Funciones.decrementar(ref numero, LIM);
            Console.WriteLine("Ahora, numero vale " + numero);
        }

        try
        {
            Funciones.decrementar(ref numero, -4);
            Console.WriteLine("PROBLEMA: No se ha producido Error, tal y como se esparaba.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Se ha producido Error, tal y como se esparaba.");
        }



    }


    private static void pruebaIncremento1()
    {
        int n = 5;
        Console.WriteLine("n: " + n);
        Funciones.incrementa(ref n);
        Console.WriteLine("n: " + n);
    }

    private static void pruebaParametros()
    {
        double n1, n2;
        n1 = 3.3;
        n2 = 12.08;
        double[] punto = { n1, n2 };

        Console.WriteLine("Num1: {0} \nNum2: {1}", n1, n2);
        Funciones.intercambiar(n1, n2);
        Console.WriteLine("Num1: {0} \nNum2: {1}", n1, n2);

        Console.WriteLine("Num1: {0} \nNum2: {1}", n1, n2);
        Funciones.intercambiar(ref n1, ref n2);
        Console.WriteLine("Num1: {0} \nNum2: {1}", n1, n2);

        Console.WriteLine("punto[0]: {0} \npunto[1]: {1}",
            punto[0], punto[1]);
        Funciones.intercambiar(punto);
        Console.WriteLine("punto[0]: {0} \npunto[1]: {1}",
            punto[0], punto[1]);

    }
}