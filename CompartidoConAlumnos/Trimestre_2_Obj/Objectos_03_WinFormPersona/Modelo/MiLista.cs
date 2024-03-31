namespace WinFormPersona.Modelo;

public class MiLista
{
    public const int TAM_INI = 10;
    public const int TAM_CREC = 10;
    private object[] datos = new object[TAM_INI];
    private int nDatos = 0;

    private void Crecer()
    {
        object[] aux = new object[datos.Length + TAM_CREC];
        for (int i = 0; i < datos.Length; i++)
        {
            aux[i] = datos[i];
        }
        datos = aux;
    }
    public override string ToString()
    {
        int i;
        string resul = "";
        for (i = 0; i < nDatos; i++)
        {
            resul += string.Format("{0}{1}", datos[i], Environment.NewLine);
        }
        return resul;
    }
    // Función para insertar un elemento en una posición del array
    public void Add(object elemento)
    {
        Insertar(elemento, nDatos);
    }
    public void Insertar(object elemento, int posicion)
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
    public object Sacar(int posicion)
    {
        object elemento;
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
