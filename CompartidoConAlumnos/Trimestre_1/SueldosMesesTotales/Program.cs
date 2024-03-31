namespace SueldosMesesTotales;
internal class Program
{
    static void Main(string[] args)
    {
        int[,] sueldos;
        String[] nombres = { "Pedro", "Andrea", "Gracia", "Eva" };
        String[] meses = { "Último", "Penúltimo", "Antepenúltimo" };
        sueldos = new int[meses.Length, nombres.Length];
        Random azar = new Random();
        int pers, m;
        int margenSueldo;
        int[] totales = new int[nombres.Length];


        // Generando sueldos al azar
        for (pers = 0; pers < sueldos.GetLength(1); pers++)
        {
            sueldos[0, pers] = azar.Next(100, 201) * 10;
            for (m = 1; m < sueldos.GetLength(0); m++)
            {
                margenSueldo = azar.Next(-10, 11) * 10;
                sueldos[m, pers] = sueldos[0, pers] + margenSueldo;
                if (sueldos[m, pers] > 2000)
                    sueldos[m, pers] = 2000;
                else if (sueldos[m, pers] < 1000)
                    sueldos[m, pers] = 1000;
            }
        }
        // Mostrando tabla
        // Cabecera
        Console.Write("\t");
        for (pers = 0; pers < nombres.Length; pers++)
            Console.Write("\t{0}", nombres[pers]);
        Console.WriteLine();
        // Datos
        for (m = 0; m < sueldos.GetLength(0); m++)
        {
            // Linea de detalle
            Console.Write("{0,-10}", meses[m]);
            for (pers = 0; pers < nombres.Length; pers++)
            {
                Console.Write("\t{0}", sueldos[m, pers]);
                totales[pers] = totales[pers] + sueldos[m, pers];
            }
            Console.WriteLine();
        }
        Console.Write("   TOTALES:");
        for (pers = 0; pers < nombres.Length; pers++)
            Console.Write("\t{0}", totales[pers]);
        Console.WriteLine();
    }
}
