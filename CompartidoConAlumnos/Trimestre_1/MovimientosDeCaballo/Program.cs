namespace MovimientosDeCaballo;

internal class Program
{
    static void Main(string[] args)
    {
        int fDest, cDest;
        int f0, c0;
        int i;
        int[] despF = { 1, 1, -1, -1, 2, 2, -2, -2 };
        int[] despC = { 2, -2, 2, -2, 1, -1, 1, -1 };
        Console.WriteLine("Posición del caballo.");
        Console.Write("fila: ");
        f0 = Convert.ToInt32(Console.ReadLine());
        Console.Write("columna: ");
        c0 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Desde la posición [{0},{1}], el caballo se despaza a las siguientes posiciones.", f0, c0);
        for (i = 0; i < despF.Length; i++)
        {
            fDest = f0 + despF[i];
            cDest = c0 + despC[i];
            if (fDest >= 0 && fDest <= 7 && cDest >= 0 && cDest <= 7)
                Console.WriteLine("posición [{0},{1}]", fDest, cDest);
        }



    }
}
