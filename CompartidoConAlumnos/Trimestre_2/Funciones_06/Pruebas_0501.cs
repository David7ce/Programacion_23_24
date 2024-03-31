    internal class Pruebas_0501
    {

    // --------------------------------
    // Pruebas para los ejercicios 0501
    // --------------------------------
    public static void pruebaFuncion5()
    {
        for (int numero = 25; numero <= 70; numero++)
        {
            if (Ejercicios_0501.Funcion5_EsPrimo(numero))
                Console.WriteLine($"{numero} es un número primo.");
        }
    }
}

