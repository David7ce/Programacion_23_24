internal class Funciones_01
{
    static void Main(string[] args)
    {
        /*
        const String SALUDO = "Hello, World!     ";
        const String DESPEDIDA = "Adios mundo...";
        Console.WriteLine(SALUDO);
        separador(SALUDO.Length);
        Console.WriteLine(DESPEDIDA);
        separador(SALUDO.Length);
        */

        // probar funcion absoluto
        //int x;
        //x = absoluto(-5);
        //Console.WriteLine("\nValor absoluto de -5 es " + x);

        separador();
        Console.WriteLine("\nValor absoluto de -34 es {0}", absoluto(-34));
        separador(70);
    }
    static void separador()
    {
        separador(30);
        /*
           for (int i = 0; i < 30; i++)
           {
               Console.Write('-');
           }
           Console.WriteLine();
        */
    }

    static void separador(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
    }

    static int absoluto(int num)
    {
        int result;
        if (num < 0)
            result = -num;
        else
            result = num;
        return result;
    }


}
