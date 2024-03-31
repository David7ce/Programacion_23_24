namespace Normaliza;
internal class Program
{
    static void Main(string[] args)
    {
        const int HOR = 0;
        const int MIN = 1;
        const int SEG = 2;

        int[] hora = new int[3];
        int tiempo;
        Console.Write("Segundos: ");
        tiempo = Convert.ToInt32(Console.ReadLine());
        hora[SEG] = tiempo % 60;
        tiempo = (tiempo / 60);
        hora[MIN] = tiempo % 60;
        tiempo /= 60;
        hora[HOR] = tiempo % 24;
        Console.WriteLine("{0} horas, {1} minutos, {2} segundos", hora[HOR], hora[MIN], hora[SEG]);
    }
}