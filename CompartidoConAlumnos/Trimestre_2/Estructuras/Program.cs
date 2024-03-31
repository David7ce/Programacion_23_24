internal class Program
{
    static void Main(string[] args)
    {
        //pruebaPila();
        pruebaInvertirNombres();
    }

    private static void pruebaInvertirNombres()
    {
        String[] nombres = { "Ana", "Carlos", "Diana", "Helena", "Jose" };
        int i;
        String[] datosPila = new string[100];
        int cima = -1;

        Tablas.mostrar(nombres);
        for (i = 0; i < nombres.Length; i++)
        {
            Pila.apilar(datosPila, ref cima, nombres[i]);
        }
        for (i = 0; i < nombres.Length; i++)
        {
            nombres[i] = Pila.desapilar(datosPila, ref cima);
        }
        Tablas.mostrar(nombres);
    }














    private static void pruebaPila()
    {
        String[] miPila = new String[20];
        int cima = -1;

        imprimeEstadoDePila(cima);
        Pila.apilar(miPila, ref cima, "Juan");
        Pila.apilar(miPila, ref cima, "Marta");
        Pila.apilar(miPila, ref cima, "Olga");
        imprimeEstadoDePila(cima);
        // Sacando todos los elementos de la pila
        while (!Pila.vacia(cima))
            Console.WriteLine(Pila.desapilar(miPila, ref cima));
        imprimeEstadoDePila(cima);
    }
    private static void imprimeEstadoDePila(int cima)
    {
        // Cómo está la pila
        Console.Write("La pila está ");
        if (Pila.vacia(cima))
            Console.WriteLine("vacía.");
        else
            Console.WriteLine("no vacía.");
    }

}