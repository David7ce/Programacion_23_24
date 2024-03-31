public class MiLista
{
    public const int TAM_INI = 10;
    public const int TAM_CREC = 10;
    private int[] datos = new int[TAM_INI];
    private int nDatos = 0;

    private void Crecer()
    {
        int[] aux = new int[datos.Length + TAM_CREC];
        for (int i = 0; i < datos.Length; i++)
        {
            aux[i] = datos[i];
        }
        datos = aux;
    }
    public void Mostrar()
    {
        int i;
        Console.Write("{ ");
        for (i = 0; i < nDatos - 1; i++)
        {
            Console.Write(" {0,2} ,", datos[i]);
        }
        if (nDatos > 0)
        {
            Console.Write(" {0,2} ", datos[i]);
        }
        Console.WriteLine(" }");
    }
    // Función para insertar un elemento en una posición del array
    public void Insertar(int elemento, int posicion)
    {
        // Verificar si la posición es válida
        if (posicion > nDatos || posicion < 0)
            throw new Exception();
        if (nDatos == datos.Length)
            Crecer();
        // Desplazar los elementos hacia el final para dejar espacio al nuevo elemento
        for (int i = nDatos; i > posicion; i--)
            datos[i] = datos[i - 1];
        // Insertar el nuevo elemento en la posición especificada
        datos[posicion] = elemento;
        nDatos++;
    }

    // Función para insertar un elemento en una posición del array
    public int Sacar(int posicion)
    {
        int elemento;
        // Verificar si la posición es válida
        if (posicion >= nDatos || posicion < 0)
            throw new Exception();

        elemento = datos[posicion];
        // Desplazar los elementos hacia el final para dejar espacio al nuevo elemento
        for (int i = posicion; i < nDatos - 1; i++)
        {
            datos[i] = datos[i + 1];
        }
        nDatos--;
        return elemento;
    }
}
