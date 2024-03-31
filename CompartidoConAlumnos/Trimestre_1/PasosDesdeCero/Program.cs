namespace pro.cesar;

public class Program
{
    public static void Main(String[] args)
    {
        int pasos;
        int posicion = 0, i = 0;
        int tope;
        int[] listaPasos = new int[20];
        Console.WriteLine("Numeros de pasos");
        pasos = Convert.ToInt32(Console.ReadLine());
        while (posicion != pasos)
        {
            listaPasos[i++] = pasos;

            posicion += pasos;
            Console.WriteLine("Numeros de pasos");
            pasos = Convert.ToInt32(Console.ReadLine());
        }
        tope = i;
        Console.WriteLine("Punto de la linea -> " + posicion);
        Console.Write("[ ");
        for (i = 0; i < tope - 1; i++)
        {
            Console.Write(listaPasos[i] + ", ");
        }
        if (tope != 0)
            Console.Write(listaPasos[i]);
        Console.WriteLine(" ]");

    }
}