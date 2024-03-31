namespace Figura;
internal class Program
{
    static void Main(string[] args)
    {
        int fila, col;
        int tope;
        char[,] tabla = new char[7, 7];
        /*
        tope = tabla.GetLength(1) - 1;
        for (fila = 0; fila < tabla.GetLength(0); fila++)
        {
            for (col = 0; col < tope; col++)
            {
                tabla[fila, col] = (char)('A' + col);
            }
            for (; col < tabla.GetLength(1); col++)
            {
                tabla[fila, col] = 'O';
            }
            tope--;
        }
        */
        // Mostrar del derecho
        for (fila = 0; fila < tabla.GetLength(0); fila++)
        {
            for (col = 0; col < tabla.GetLength(1); col++)
            {
                Console.Write("{0} ", tabla[fila, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("__________________________");
        Console.WriteLine();
        // Mostrar Invertido
        for (col = 0; col < tabla.GetLength(1); col++)
        {
            for (fila = 0; fila < tabla.GetLength(0); fila++)
            {
                Console.Write("{0} ", tabla[fila, col]);
            }
            Console.WriteLine();
        }
    }
}