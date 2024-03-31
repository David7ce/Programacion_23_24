namespace BuscarTelefono;
internal class Program
{
    static void Main(string[] args)
    {
        const int LIMITE = 20;
        int[] telefonos = new int[LIMITE];
        string[] nombres = new string[LIMITE];
        int telefono, numDatos = 0, telefono_marcado;
        string nombre;
        int posActual;

        Console.WriteLine("Introduce el nombre: ");
        nombres[numDatos] = Console.ReadLine();
        while (nombres[numDatos] != "")      //.Length != 0)
        {
            Console.WriteLine("Introduce el numero de telefono: ");
            telefonos[numDatos] = Convert.ToInt32(Console.ReadLine()); ;
            numDatos++;

            Console.WriteLine("Introduce el nombre: ");
            nombres[numDatos] = Console.ReadLine();
        }

        if (numDatos != 0)
        {
            Console.WriteLine("Introduce un teléfono para hallar el nombre de la persona: ");
            telefono_marcado = Convert.ToInt32(Console.ReadLine());

            // BUSQUEDA LINEAL
            posActual = 0;
            while (telefono_marcado != telefonos[posActual] & posActual < numDatos - 1)
                posActual++;
            if (telefono_marcado == telefonos[posActual])
                Console.WriteLine("El número {0} pertenece a {1}.", telefono_marcado, nombres[posActual]);
            else
                Console.WriteLine("El número no exixte");
        }

    }
}