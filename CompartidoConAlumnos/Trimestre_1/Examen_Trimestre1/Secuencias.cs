namespace Secuencias;
internal class Program
{
    static void Main(string[] args)
    {
        int i;
        int[] numeros = new int[20];
        int totalAbsoluto=0;
        for (i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < numeros.Length; i++)
        {
            Console.Write("{0}  ",numeros[i]);
            totalAbsoluto += Math.Abs(numeros[i]);
            if (totalAbsoluto > 100) {
                Console.WriteLine("\\{0}\\", totalAbsoluto);
                totalAbsoluto = 0;
            }
        }
        if(totalAbsoluto!=0)
            Console.WriteLine("\\{0}\\", totalAbsoluto);
    }
}