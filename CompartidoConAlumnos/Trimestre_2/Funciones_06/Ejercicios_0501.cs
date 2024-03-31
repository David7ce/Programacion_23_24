public class Ejercicios_0501
{
    public static double Funcion1_CentigradosKelvin(double temp)
    {
        return temp + 273.15;
    }
    public static double Funcion1_CentigradosFarenheit(double temp)
    {
        return temp * 1.8 + 32;
    }
    public static double Funcion2_ConvertirCentigrados(double temp, char t)
    {
        double result;
        t = Char.ToUpper(t);
        switch (t)
        {
            case 'K':
                result = Funcion1_CentigradosKelvin(temp);
                break;
            case 'F':
                result = Funcion1_CentigradosFarenheit(temp);
                break;
            default:
                throw new Exception();
        }
        return result;
    }
    public static int Funcion3_ContarAparicionesDeLetra(string cadena, char ch)
    {
        int contador = 0;
        // BUCLE FOREACH
        foreach (char caracter in cadena)
            if (caracter == char.ToLower(ch))
                contador++;
        return contador;
    }

    public static void Funcion4_MostrarNumerosDel1Al100()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void Funcion4_MostrarNumerosDel1Al100Recursivo(int numero)
    {
        if (numero <= 100)
        {
            Console.WriteLine(numero);
            Funcion4_MostrarNumerosDel1Al100Recursivo(numero + 1);
        }
    }

    public static bool Funcion5_EsPrimo(int numero)
    {
        int i;
        double raiz = Math.Sqrt(numero);
        Boolean esPrimo = true;
        if (numero > 1)
        {
            i = 2;
            while (i <= raiz && numero % i != 0)
                i++;
            esPrimo = numero % i != 0;
        }
        return esPrimo;
    }
}

