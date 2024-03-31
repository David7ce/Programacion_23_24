namespace HundirLaFlota;
internal class Program
{
    static void Main(string[] args)
    {
        String input;
        int fila, col;
        const char AGUA = '·';
        const char DISPARADO = '*';
        char[,] tabla = {
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,'P' ,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,'P' ,AGUA,'T' ,'T' ,'T' ,AGUA,AGUA,AGUA,AGUA},
            {AGUA,'P' ,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,'P' ,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA},
            {AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA,AGUA}
        };
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
        Console.Write("Coordenada: ");
        input = Console.ReadLine();
        while (input != "")
        {
            //Gestionar Disparo
            fila = input[0] - 'A';
            col = Convert.ToInt32(input.Substring(1)) - 1;

            Console.Clear();

            if (tabla[fila, col] == AGUA)
                Console.WriteLine("**** AGUA   *****");
            else if (tabla[fila, col] == DISPARADO)
                Console.WriteLine("Disparo repetido.");
            else
                Console.WriteLine("Tocado o hundido.");
            tabla[fila, col] = DISPARADO;

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
            Console.Write("Coordenada: ");
            input = Console.ReadLine();
        };
    }
}
