public class Pila
{
    public static void apilar(String[] pila, ref int cima, String dato)
    {
        //pila[cima + 1] = dato;
        //cima++;

        if (llena(pila, cima))
            throw new Exception("No se puede apilar a una pila que ya está llena.");
        pila[++cima] = dato;
    }
    public static String desapilar(String[] pila, ref int cima)
    {
        if (vacia(cima))
            throw new Exception("No se puede desapilar de una pila que ya está vacía.");
        return pila[cima--];
    }
    public static Boolean vacia(int cima)
    {
        return cima == -1;
    }
    public static Boolean llena(String[] pila, int cima)
    {
        return pila.Length - 1 == cima;
    }


}
