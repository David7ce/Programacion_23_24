internal class Principal
{
    static void Main(string[] args)
    {
        //pruebaExtraerCoordenadas();
        //pruebaDisparar();
        Console.WriteLine("FIN");
    }

    private static void pruebaDisparar()
    {
        char[,] tablero = new char[10, 10];
        String coord = " ";
        int codigo;

        Tablas.rellenar(tablero, '·');
        tablero[3, 4] = 'T';
        tablero[3, 5] = 'T';
        tablero[3, 6] = 'T';
        do
        {
            try
            {
                Tablas.mostrar(tablero);
                Console.Write("Coordenada: ");
                coord = Console.ReadLine();
                codigo = HundirFlota.disparar(tablero, coord);
                Console.WriteLine("Codigo retornado: " + codigo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("La coordenada {0} no es correcta.", coord);
                Console.WriteLine("Repítemela...");
            }
        } while (coord.Length != 0);

    }
    private static void pruebaExtraerCoordenadas()
    {
        String coord1 = "B7";
        String coord2 = "e10";
        String coord3 = "hJJ";
        String coord4 = "D12";
        int f, c;
        HundirFlota.extraerCoordenada(coord1, out f, out c);
        Console.WriteLine("Coordenada {0} es ({1},{2})", coord1, f, c);
        HundirFlota.extraerCoordenada(coord2, out f, out c);
        Console.WriteLine("Coordenada {0} es ({1},{2})", coord2, f, c);
        try
        {
            HundirFlota.extraerCoordenada(coord3, out f, out c);
            Console.WriteLine("Coordenada {0} es ({1},{2})", coord3, f, c);
        }
        catch (Exception ex)
        {
            Console.WriteLine("La coordenada {0} no es válida.", coord3);
        }
        try
        {
            HundirFlota.extraerCoordenada(coord3, out f, out c);
            Console.WriteLine("Coordenada {0} es ({1},{2})", coord4, f, c);
        }
        catch (Exception ex)
        {
            Console.WriteLine("La coordenada {0} no es válida.", coord4);
        }

    }
}