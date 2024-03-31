public class Funciones_03
{
    public static void mostrar(int[] numeros)
    {

        int i;
        Console.Write("{ ");
        for (i = 0; i < numeros.Length - 1; i++)
        {
            Console.Write(" {0,2} ,", numeros[i]);
        }
        if (numeros.Length > 0)
        {
            Console.Write(" {0,2} ", numeros[i]);
        }
        Console.WriteLine(" }");
    }
    public static void rellenar(int[] datos)
    {
        rellenar(datos, -10, 11);

        //int i;
        //Random random = new Random();
        //for (i = 0; i < datos.GetLength(0); i++)
        //{
        //    datos[i] = random.Next(-10, 11);
        //}
    }
    public static void rellenar(int[] datos, int desde, int hasta)
    {
        int i;
        Random random = new Random();
        for (i = 0; i < datos.GetLength(0); i++)
        {
            datos[i] = random.Next(desde, hasta);
        }
    }
    public static int[] merge(int[] tablaA, int[] tablaB)
    {
        int[] tablaC;
        int i = 0, j = 0, k = 0;

        tablaC = new int[tablaA.Length + tablaB.Length];
        while (i < tablaA.Length && j < tablaB.Length)
        {
            if (tablaA[i] <= tablaB[j])
            {
                tablaC[k] = tablaA[i];
                i++;
            }
            else
            {
                tablaC[k] = tablaB[j];
                j++;
            }
            k++;
        }

        while (i < tablaA.Length)
        {
            tablaC[k] = tablaA[i];
            k++;
            i++;
        }
        while (j < tablaB.Length)
        {
            tablaC[k] = tablaB[j];
            k++;
            j++;
        }
        return tablaC;
    }

    public static int[] concat(int[] tablaA, int[] tablaB)
    {
        int i, j;
        int[] tablaC;

        tablaC = new int[tablaA.Length + tablaB.Length];

        for (i = 0; i < tablaA.Length; i++)
        {
            tablaC[i] = tablaA[i];
        }

        for (j = 0; j < tablaB.Length; j++, i++)
        {
            tablaC[i] = tablaB[j];
        }
        return tablaC;
    }



    // Bidimensionales
    public static void rellenar(int[,] datos)
    {
        Random random = new Random();

        for (int fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Datos de cada columna de la fila actual
            for (int col = 0; col < datos.GetLength(1); col++)
                datos[fila, col] = random.Next(-10, 11);
        }
    }
    public static void mostrar(int[,] datos)
    {
        int fila, col;
        for (fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Datos de cada columna de la fila actual
            for (col = 0; col < datos.GetLength(1); col++)
                Console.Write("{0,5}", datos[fila, col]);
            Console.WriteLine();
        }

    }
}