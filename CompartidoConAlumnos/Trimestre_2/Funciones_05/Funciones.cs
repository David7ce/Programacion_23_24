public class Funciones
{
    // Paso de param por copia
    public static void intercambiar(double a, double b)
    {
        double piv;
        piv = a;
        a = b;
        b = piv;
    }
    // Paso de param por nombre
    public static void intercambiar(ref double a, ref double b)
    {
        double piv;
        piv = a;
        a = b;
        b = piv;
    }
    // Paso de param por copia de la referencia del objeto
    public static void intercambiar(double[] coord)
    {
        // coord = null;

        double piv;
        piv = coord[0];
        coord[0] = coord[1];
        coord[1] = piv;
    }
    // Paso de param por copia de la referencia del objeto UFFFF
    public static void intercambiar(ref double[] coord)
    {
        // coord = null;

        double piv;
        piv = coord[0];
        coord[0] = coord[1];
        coord[1] = piv;
    }

    public static void incrementa(ref int v)
    {
        v++;
    }

    public static void incrementar(ref int v, int tope)
    {
        if (tope < 1 | v < 0 | v >= tope)
            throw new Exception("Parámetros no válidos");
        if (v == tope - 1)
            v = 0;
        else
            v++;
    }

    public static void decrementar(ref int v, int tope)
    {
        if (tope < 1 | v < 0 | v >= tope)
            throw new Exception("Parámetros no válidos");
        if (v == 0)
            v = tope - 1;
        else
            v--;
    }
}
