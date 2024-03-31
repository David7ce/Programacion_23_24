public class HundirFlota
{
    public static int disparar(char[,] tablero, String coordDisparo)
    {
        const char AGUA = '·';
        const char DISPARADO = '*';
        const int COD_AGUA = 1;
        const int COD_TOCADO = 2;
        const int COD_REPETIDO = 3;
        int f, c;
        int codResul;
        extraerCoordenada(coordDisparo, out f, out c);

        switch (tablero[f, c])
        {
            case AGUA:
                tablero[f, c] = DISPARADO;
                codResul = COD_AGUA;
                break;
            case DISPARADO:
                codResul = COD_REPETIDO;
                break;
            default:
                tablero[f, c] = DISPARADO;
                codResul = COD_TOCADO;
                break;
        }
        return codResul;
    }
    internal static void extraerCoordenada(string coord, out int row, out int col)
    {
        char letra;
        int f, c;
        letra = Char.ToUpper(coord[0]);
        f = letra - 'A';
        c = Convert.ToByte(coord.Substring(1)) - 1;
        if (f < 0 || f > 9 || c < 0 || c > 9)
            throw new Exception();
        row = f;
        col = c;
    }

}
