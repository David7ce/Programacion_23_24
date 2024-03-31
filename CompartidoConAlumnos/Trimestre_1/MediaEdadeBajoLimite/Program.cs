namespace MediaEdadeBajoLimite;

internal class Program
{
    static void Main(string[] args)
    {
        String[] nombres = new String[5];
        int[] edades = new int[5];
        int i;
        int edadLimite;
        int sumaEdades = 0, contEdades = 0;
        double mediaEdades;

        for (i = 0; i < edades.Length; i++)
        {

            Console.WriteLine("¿Cómo te llamas?");
            nombres[i] = Console.ReadLine();
            Console.WriteLine("¿Cuántos años tienes?");
            edades[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("¿Cuál será la edad límite?");
        edadLimite = Convert.ToInt32(Console.ReadLine());
        for (i = 0; i <= edades.Length - 1; i++)
        {
            if (edades[i] < edadLimite)
            {
                Console.WriteLine(nombres[i] + " - " + edades[i]);
                sumaEdades = sumaEdades + edades[i];
                contEdades++;
            }
        }
        mediaEdades = (double)sumaEdades / contEdades;
        Console.WriteLine("\nMedia de las edades: {0} años", mediaEdades);
        Console.WriteLine("Edad tope {0} años.", edadLimite);



    }
}