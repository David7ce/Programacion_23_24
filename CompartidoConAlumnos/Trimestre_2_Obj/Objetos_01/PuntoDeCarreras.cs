public class PuntoDeCarreras
{
    private int x;
    private int y;
    private char id;
    private static Random azar = new Random();
    private static int meta;
    public PuntoDeCarreras(int x, int y, char id)
    {
        if (x < 0 | x > 110 | y < 0 | y > 25)
            throw new Exception();
        this.x = x;
        this.y = y;
        this.id = id;
    }
    public PuntoDeCarreras(int x, int y) : this(x, y, 'x') { }


    public char getId() { return id; }

    public static void FijarMeta(int meta)
    {
        if (meta > 0 & meta <= 110)
            PuntoDeCarreras.meta = meta;
    }
    public static int getMeta()
    {
        return meta;
    }
    public bool Avanzar(int potencia)
    {
        if (meta > 0)
            if (potencia >= 1 && potencia <= 10)
                x += azar.Next(1, potencia + 1);
        return x >= meta;
    }
    public void Mostrar()
    {
        Imprimir(id);
    }
    public void Ocultar()
    {
        Imprimir(' ');
    }
    private void Imprimir(char ch)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(ch);
        Console.SetCursorPosition(0, 0);
    }


}
