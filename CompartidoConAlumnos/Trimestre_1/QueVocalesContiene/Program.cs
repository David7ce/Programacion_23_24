namespace QueVocalesContiene;
internal class Program
{
    static void Main(string[] args)
    {
        string vocales = "aeiouAEIOU";
        string frase;
        int suma = 0;
        int letrActual;
        int i;
        int j;
        String vocalesEncontradas = " ";
        Console.WriteLine("Escribe una frase");
        frase = Console.ReadLine();


        for (letrActual = 0; letrActual < frase.Length; letrActual++)
        {
            /*
              if (vocales.Contains(frase[i]))
              {
                Console.Write(frase[i]);
                suma++;
              }
            */
            i = 0;
            while (frase[letrActual] != vocales[i] & i < vocales.Length - 1)
                i++;
            if (frase[letrActual] == vocales[i])//(palabra.Contains(vocales))
            {
                j = 0;
                while (frase[letrActual] != vocalesEncontradas[j] & j < vocalesEncontradas.Length - 1)
                    j++;
                if (vocalesEncontradas[j] != frase[letrActual])
                {
                    vocalesEncontradas += frase[letrActual];
                    Console.Write(frase[letrActual]);
                }
                suma++;
            }
        }
        Console.Write("\nEl numero de vocales es: " + suma);
    }
}