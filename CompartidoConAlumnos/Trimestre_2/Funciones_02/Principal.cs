internal class Principal
{
    static void Main(string[] args)
    {
        // Prueba Funcion separador
        const String SALUDO = "Hello, World!  ";
        const String DESPEDIDA = "Adios mundo...";
        Console.WriteLine(SALUDO);
        Funciones_02.separador();
        Console.WriteLine(DESPEDIDA);
        Funciones_02.separador(DESPEDIDA.Length);

        // Prueba Funcion absoluto
        int x = -5;
        int abs_x;
        abs_x = Funciones_02.absoluto(x);
        Console.WriteLine("\nValor absoluto de {0} es {1}", x, abs_x);

        //Console.WriteLine("\nValor absoluto de -34 es " + Funciones.absoluto(-34));

        // Prueba Funcion mostrar(...)
        int[,] tabla =
        {
                  {1,2,3,4},
                  {5,6,7,8},
                  {5,6,7,8},
                  {9,10,11,12}
              };
        int[,] tabla2 = new int[7, 10];
        Funciones_02.separador();
        Funciones_02.mostrar(tabla);
        Funciones_02.separador();
        Funciones_02.mostrar(tabla2);
        Funciones_02.rellenar(tabla2);
        Funciones_02.separador();
        Funciones_02.mostrar(tabla2);

        /*
              // Prueba concatena
              String s;
              s = Funciones.concatena("Hola ","Pepe.");
              Console.WriteLine(s);
              Console.WriteLine(Funciones.concatena("3 + 5 = ", "8"));

        //        Console.WriteLine("Abc");
        //Console.WriteLine(Funciones.encripta("mnñop"));

        Console.WriteLine("_____");
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Fib({0})={1}", i, Funciones_02.fibonacci(i));
        }
        Console.WriteLine("_____");

        // La versión recursiva tarda muchísimo...
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("Fib({0})={1}", i, Funciones_02.fibonacci_REC(i));
        }
        Console.WriteLine("_____");
*/

    }
}
