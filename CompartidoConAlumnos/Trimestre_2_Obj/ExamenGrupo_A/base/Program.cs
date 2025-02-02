﻿public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n\n");
        PruebaSorteo();
        Console.WriteLine("\n\n#################### ####################\n\n");
        PruebaSorteoSinDuplicados();
    }

    private static void PruebaSorteo()
    {
        Sorteo s = new Sorteo();
        s.Incluir("Ana");
        s.Incluir(new string[] { "Pedro", "Anastasia", "Ludovico" });
        s.Incluir("Mararía");
        s.Incluir("Mararía");
        s.Incluir("Mararía");
        Console.WriteLine($"Candidatos: {s}.\n");

        Console.WriteLine("Los tres seleccionados son:");
        for (int i = 0; i < 3; i++)
            Console.WriteLine($" - {s.Seleccionar()}");

        Console.WriteLine($"Los no seleccionado fueron:\n{s}");

    }

    private static void PruebaSorteoSinDuplicados()
    {
        Sorteo s = new SorteoSinDuplicados();
        s.Incluir("Ana");
        s.Incluir(new string[] { "Pedro", "Pedro", "Anastasia", "Ludovico", "Pedro", "Pedro" });
        s.Incluir("Mararía");
        s.Incluir("Mararía");
        s.Incluir("Mararía");
        Console.WriteLine($"Candidatos: {s}.\n");

        Console.WriteLine("Los tres seleccionados son:");
        for (int i = 0; i < 3; i++)
            Console.WriteLine($" - {s.Seleccionar()}");

        Console.WriteLine($"Los no seleccionado fueron:\n{s}");
    }

}