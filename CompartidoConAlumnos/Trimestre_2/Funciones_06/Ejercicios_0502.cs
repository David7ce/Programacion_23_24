public class Ejercicios_0502
{
    public static int funcion1_menor(int[] numeros)
    {
        int min = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < min)
                min = numeros[i];
        }
        return min;
    }
    public static int funcion2_posMenor(int[] numeros)
    {
        int posMin = 0;
        for (int i = 1; i < numeros.Length; i++)
            if (numeros[i] <= numeros[posMin])
                posMin = i;
        return posMin;
    }
    public static int[] funcion3_creaTabla(int tam)
    {
        int[] cadena = new int[tam];
        Random aleatorio = new Random();
        for (int i = 0; i < tam; i++)
            cadena[i] = aleatorio.Next(1, 100);
        return cadena;
    }
    public static Boolean funcion4_esBisiesto(int año)
    {
        //Un año es bisiesto si es divisible entre 4, excepto si es divisible entre 100 pero no entre 400
        return (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));
    }
    public static int funcion5_numDigitos(int numero)
    {
        int cantidad = 0;
        do
        {
            numero /= 10;
            cantidad++;
        } while (numero > 0);
        return cantidad;
    }
    public static double funcion6_media(int[] numeros)
    {
        int total = numeros[0]; // Declaro la Variable total y le Asigno el Valor 0.
        for (int i = 1; i < numeros.Length; i++) // Bucle al Tamaño del Array.
        {
            total += numeros[i]; // Acumulo en la Variable total la Suma de Todos los Valores en el Array.
        }

        return total / (double)numeros.Length;
    }
    public static int funcion7_repeticiones(String cadena, char ch)
    {
        int cont = 0;
        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == ch)
                cont++;
        }
        return cont;
    }
    public static int[] funcion8_posRepeticiones(String cadena, char ch)
    {
        int[] posiciones;
        int cont;
        cont = funcion7_repeticiones(cadena, ch);
        posiciones = new int[cont];

        cont = 0;

        for (int i = 0; i < cadena.Length; i++)
        {
            if (cadena[i] == ch)
            {
                posiciones[cont++] = i;
            }
        }
        return posiciones;
    }















    public static int funcion78_repeticiones_y_pos(String frase, char ch, out int[] posiciones)
    {
        List<int> listaDePosiciones = new List<int>();
        int i;
        for (i = 0; i < frase.Length; i++)
        {
            if (frase[i] == ch)
                listaDePosiciones.Add(i);

        }
        posiciones = listaDePosiciones.ToArray();
        return posiciones.Length;
    }
}

