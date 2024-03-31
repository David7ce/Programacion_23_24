namespace RuletaPalabra;
internal class Program
{
    static void Main(string[] args)
    {
        //Juego de la ruleta
        Random rand = new Random();
        String pSecreta;
        String palabraIntentada;
        int posAleat;

        Console.WriteLine("Introduce una palabra para jugar");
        pSecreta = Console.ReadLine().ToUpper();
        Console.Clear();

        posAleat = rand.Next(1, pSecreta.Length);
        for (int i = 1; i <= pSecreta.Length; i++)
        {
            Console.Write(pSecreta[posAleat]);
            posAleat = (posAleat + 1) % pSecreta.Length;
        }
        //posAleat = rand.Next(1, pSecreta.Length);
        //for (int i = posAleat; i < pSecreta.Length; i++)
        //{
        //    Console.Write(pSecreta[i]);
        //}
        //for (int i = 0; i < posAleat; i++)
        //{
        //    Console.Write(pSecreta[i]);
        //}
        //Console.WriteLine();


        Console.Write("\nAhora, dime la palabra que creas que es: ");
        palabraIntentada = Console.ReadLine().ToUpper();
        if (pSecreta == palabraIntentada)
        {
            Console.WriteLine("¡Felicidades has ganado!");
        }
        else
        {
            Console.WriteLine("Lo siento esa no era la palabra");
            Console.WriteLine("La palabra era: {0}", pSecreta);
        }
    }
}

