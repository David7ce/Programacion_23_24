namespace CuantasVocales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numVocales = 0;
            Console.WriteLine("Introduce una cadena: ");
            string cadena = Console.ReadLine();
            for (int j = 0; j < cadena.Length; j++)
            {
                char letra = Char.ToLower(cadena[j]);
                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        numVocales++;
                        break;
                }
            }
            Console.WriteLine("Contiene {0} vocales.", numVocales);
        }
    }

}