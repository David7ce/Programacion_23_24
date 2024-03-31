public class DatosEnArray
{
    public static void Mostrar(int[] numeros, int nDatos)
    {
        int i;
        Console.Write("{ ");
        for (i = 0; i < nDatos - 1; i++)
        {
            Console.Write(" {0,2} ,", numeros[i]);
        }
        if (nDatos > 0)
        {
            Console.Write(" {0,2} ", numeros[i]);
        }
        Console.WriteLine(" }");
    }
    // Función para insertar un elemento en una posición del array
    public static void InsertarElementoEnPosicion(int[] array, ref int numDatos, int elemento, int posicion)
    {
        // Verificar si la posición es válida
        if (numDatos == array.Length || posicion > numDatos || posicion < 0)
            throw new Exception();
        // Desplazar los elementos hacia el final para dejar espacio al nuevo elemento
        for (int i = numDatos; i > posicion; i--)
            array[i] = array[i - 1];
        // Insertar el nuevo elemento en la posición especificada
        array[posicion] = elemento;
        numDatos++;
    }

    // Función para insertar un elemento en una posición del array
    public static int QuitarElementoEnPosicion(int[] array, ref int numDatos, int posicion)
    {
        int elemento;
        // Verificar si la posición es válida
        if (numDatos == 0 || posicion >= numDatos || posicion < 0)
            throw new ArgumentException();

        elemento = array[posicion];
        // Desplazar los elementos hacia el final para dejar espacio al nuevo elemento
        for (int i = posicion; i < numDatos - 1; i++)
        {
            array[i] = array[i + 1];
        }
        numDatos--;
        return elemento;
    }
}
