internal class Pruebas_0502
{

    // --------------------------------
    // Pruebas para los ejercicios 0502
    // --------------------------------
    public static void pruebaFuncion1()
    {
        int[] datos = { 45, -2, 0, 9, -12, 0, 6 };
        int menor;
        menor = Ejercicios_0502.funcion1_menor(datos);
        Tablas.mostrar(datos);
        Console.WriteLine("El menor número es: " + menor);
    }
    public static void pruebaFuncion2()
    {
        int[] datos = { -45, -2, 0, 9, -12, 0, 6 };
        int pos;
        pos = Ejercicios_0502.funcion2_posMenor(datos);
        Tablas.mostrar(datos);
        Console.WriteLine("El menor número es: " + datos[pos]);
        Console.WriteLine("Ubicado en {0}ª posición.", pos + 1);
    }
    public static void pruebaFuncion3()
    {
        int[] datos;
        datos = Ejercicios_0502.funcion3_creaTabla(10);
        Tablas.mostrar(datos);
    }
    public static void pruebaFuncion4()
    {
        Boolean esBisiesto;
        int[] años = { 2000, 2001, 1900, 1952 };
        int i;
        for (i = 0; i < años.Length; i++)
        {
            esBisiesto = Ejercicios_0502.funcion4_esBisiesto(años[i]);
            Console.WriteLine("El año {0}{1}es bisiesto.", años[i], (esBisiesto ? " " : " no "));
        }
    }
    public static void pruebaFuncion5()
    {
        int[] numeros = { 123, 1, 900, 0 };
        int tam, i;
        for (i = 0; i < numeros.Length; i++)
        {
            tam = Ejercicios_0502.funcion5_numDigitos(numeros[i]);
            Console.WriteLine("El número {0} tiene {1} dígitos.", numeros[i], tam);
        }
    }
    public static void pruebaFuncion6()
    {
        int[][] pruebas = {
            new int[] { 100, 50, 100 },
            new int[] {},
            new int[] { 100, 50, 100, 0, 0 },
            new int[] { 1, 2, 3, -30 },
            Ejercicios_0502.funcion3_creaTabla(15)
        };
        double media;
        int i;
        for (i = 0; i < pruebas.Length; i++)
        {
            Console.Write("Secuencia de datos... ");
            Tablas.mostrar(pruebas[i]);
            try
            {
                media = Ejercicios_0502.funcion6_media(pruebas[i]);
                Console.WriteLine("Media: " + media);
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se calculó la media...");
            }
        }
    }
    public static void pruebaFuncion7()
    {
        int veces;
        String s = "La Cosa, últimos capítulos\nTítulo: \"Un final espeluznante\".";
        String caracteres = "aip";
        int i;
        Console.WriteLine("En la frase...\n \"{0}\"", s);
        for (i = 0; i < caracteres.Length; i++)
        {
            veces = Ejercicios_0502.funcion7_repeticiones(s, caracteres[i]);
            Console.WriteLine("   el caracter {0} aparece {1} veces.", caracteres[i], veces);
        }
    }
    public static void pruebaFuncion8()
    {
        int[] posiciones;
        String s = "La Cosa, últimos capítulos\nTítulo: \"Un final espeluznante\".";
        String caracteres = "aip\"";
        int i;
        Console.WriteLine("En la frase...\n \"{0}\"", s);
        for (i = 0; i < caracteres.Length; i++)
        {
            posiciones = Ejercicios_0502.funcion8_posRepeticiones(s, caracteres[i]);
            Console.Write("   el caracter {0} aparece en las posiciones: ", caracteres[i]);
            Tablas.mostrar(posiciones);
        }
    }
    public static void pruebaFuncion78()
    {
        int[] posiciones;
        int veces;
        String s = "La Cosa, últimos capítulos\nTítulo: \"Un final espeluznante\".";
        String caracteres = "aip";
        int i;
        Console.WriteLine("En la frase...\n \"{0}\"", s);
        for (i = 0; i < caracteres.Length; i++)
        {
            veces = Ejercicios_0502.funcion78_repeticiones_y_pos(s, caracteres[i], out posiciones);
            Console.Write("   el caracter {0} aparece {1} veces, en las posiciones: ", caracteres[i], veces);
            Tablas.mostrar(posiciones);
        }
    }
}
