public class Strings
{
    public static String rTrim(String s)
    {
        String soluc;
        int nChars;
        int i = s.Length - 1;
        if (s.Length != 0)
        {
            while (Char.IsWhiteSpace(s[i]) && i > 0)
                i--;
            if (Char.IsWhiteSpace(s[i]))
                nChars = i; // o bien nChars = 0;
            else
                nChars = i + 1;
            soluc = s.Substring(0, nChars);
        }
        else
            soluc = s;
        return soluc;
    }
    public static String lTrim(String s)
    {
        String soluc;
        int nChars;
        int i = 0;
        if (s.Length != 0)
        {
            while (Char.IsWhiteSpace(s[i]) && i < s.Length - 1)
                i++;
            if (Char.IsWhiteSpace(s[i]))
                nChars = 0;
            else
                nChars = s.Length - i;
            soluc = s.Substring(i, nChars);
        }
        else
            soluc = s;
        return soluc;
    }
    public static String trim(String s)
    {
        return rTrim(lTrim(s));
    }
    public static int numItems(String s)
    {
        int i;
        int nItems = 0;
        Boolean en_Item = false;
        for (i = 0; i < s.Length; i++)
            if (en_Item)
            {
                // Saliendo de palabra
                if (Char.IsWhiteSpace(s[i]))
                    en_Item = false;
            }
            else
            {
                // Entrando en palabra
                if (!Char.IsWhiteSpace(s[i]))
                {
                    en_Item = true;
                    nItems++;
                }
            }
        return nItems;
    }

    public static String[] split(String s)
    {
        int item = 0, i = 0, iniItem, tamItem;
        String[] resul = new String[numItems(s)];

        while (i < s.Length)
        {
            // Acotar item actual
            // Marcar el primer caracter que no sea espacio en blanco.
            while (Char.IsWhiteSpace(s[i]) && i < s.Length - 1)
                i++;
            iniItem = i;
            // Avanzar hasta el caracter que sea espacio en blanco.
            // para calcular tamaño del item.
            tamItem = 0;
            while (!Char.IsWhiteSpace(s[i]) && i < s.Length - 1)
                i++;
            // por si se salió por llegar al final y termina en caracter no espacio.
            tamItem = i - iniItem;
            if (!Char.IsWhiteSpace(s[i]))
                tamItem++;
            if (tamItem != 0)
            {
                resul[item] = s.Substring(iniItem, tamItem);
                item++;
            }
            i++;
        }
        return resul;
    }
}


