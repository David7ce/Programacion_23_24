namespace MisContenedores;

public class MiLista
{
    public const int TAM_INI = 10;
    public const int TAM_CREC = 10;
    private Object[] datos = new Object[TAM_INI];
    private int nDatos = 0;

    private void Crecer()
    {
        Object[] aux = new Object[datos.Length + TAM_CREC];
        for (int i = 0; i < datos.Length; i++)
        {
            aux[i] = datos[i];
        }
        datos = aux;
    }
    public override string ToString()
    {
        int i;
        String resul="";
        for (i = 0; i < nDatos; i++)
        {
            resul += String.Format("{0}{1}", datos[i], Environment.NewLine);
        }
        return resul;
    }
    // Función para insertar un elemento en una posición del array
    public void Add(Object elemento)
    {
        Insertar(elemento, nDatos);
    }
    public void Insertar(Object elemento, int posicion)
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
    public Object Sacar(int posicion)
    {
        Object elemento;
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
