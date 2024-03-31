namespace IslaEnHundirLaFlota;
internal class Program
{
    static void Main(string[] args)
    {
        String input;
        int V1col, V1fila;
        int V2col, V2fila;
        int fila, col;
        const char AGUA = '·';
        const char TIERRA = 'O';
        char[,] tabla = {
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA}
            };

        Console.Write("Coordenada V1: ");
        input = Console.ReadLine();
        V1fila = input[0] - 'A';
        V1col = Convert.ToInt32(input.Substring(1)) - 1;

        Console.Write("Coordenada V2: ");
        input = Console.ReadLine();
        V2fila = input[0] - 'A';
        V2col = Convert.ToInt32(input.Substring(1)) - 1;

        for (fila = V1fila; fila <= V2fila; fila++)
            for (col = V1col; col <= V2col; col++)
                tabla[fila, col] = TIERRA;



        // MOSTRAR TABLERO DE JUEGO
        Console.Write("     ");
        for (col = 0; col < tabla.GetLength(1); col++)
        {
            Console.Write("{0} ", col + 1);
        }
        Console.WriteLine();
        for (fila = 0; fila < tabla.GetLength(0); fila++)
        {
            //            Console.Write("{0} - ", sFila[fila]);
            Console.Write("{0} - ", (char)('A' + fila));
            for (col = 0; col < tabla.GetLength(1); col++)
            {
                Console.Write(" {0}", tabla[fila, col]);
            }
            Console.WriteLine();
        }
    }
}

