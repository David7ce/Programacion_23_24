internal class Funciones_02
{
    public static void separador()
    {
        separador(30);
    }
    public static void separador(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write('-');
        }
        Console.WriteLine();
    }

    public static int absoluto(int num)
    {
        int result;
        if (num < 0)
            result = -num;
        else
            result = num;
        return result;
    }


    public static String encripta(String frase)
    {
        String result = "";
        for (int i = 0; i < frase.Length; i++)
            result += (char)(frase[i] + 5);
        return result;
    }
    public static String desencripta(String frase)
    {
        String result = "";
        for (int i = 0; i < frase.Length; i++)
            result += (char)(frase[i] - 5);
        return result;
    }
    public static String concatena(String s1, String s2)
    {
        String result;
        int i;
        // result = s1 + s2;
        result = s1;
        for (i = 0; i < s2.Length; i++)
            result = result + s2[i];

        return result;
    }

    // Búqueda lineal
    public static int busca(String s, char ch)
    {
        int i = 0;
        while (s[i] != ch && i != s.Length - 1)
            i++;
        if (s[i] != ch)
            i = -1;
        return i;
    }

    public static int fibonacci(int n)
    {
        if (n < 0)
            throw new Exception("La función fibonacci solo acepta números positivos.");

        int sol = 1;
        int anterior, anteAnterior;
        int i;
        if (n <= 1)
            sol = n;
        else
        {
            anterior = 1;
            anteAnterior = 0;
            for (i = 1; i < n; i++)
            {
                sol = anterior + anteAnterior;
                anteAnterior = anterior;
                anterior = sol;
            }
        }
        return sol;
    }


    public static int fibonacci_REC(int n)
    {
        int sol;
        switch (n)
        {
            case 0:
            case 1:
                sol = n;
                break;
            default:
                sol = fibonacci_REC(n - 1) + fibonacci_REC(n - 2);
                break;
        }
        return sol;
    }

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
    public static void mostrarGuay(int[,] datos)
    {
        // Sobre indices de fila
        Console.Write("{0, 5}", ' ');
        // Sobre cada columna
        for (int col = 0; col < datos.GetLength(1); col++)
            Console.Write("{0, 3}  ", col);
        Console.WriteLine();
        //        separador(ANCHO_COL * (datos.GetLength(1) + 1));
        for (int fila = 0; fila < datos.GetLength(0); fila++)
        {
            // Indice antes de cada fila
            Console.Write("{0, -2}:", fila);
            // Datos de cada columna de la fila actual
            for (int col = 0; col < datos.GetLength(1); col++)
                Console.Write("{0,5}", datos[fila, col]);
            Console.WriteLine();
        }
    }
}
