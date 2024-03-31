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
        nombre = Console.ReadLine();
        while (nombre != null && nombre.Length != 0 && numDatos < nombres.Length - 1)
        {
            nombres[numDatos] = nombre;
            Console.WriteLine("Introduce el numero de telefono: ");
            telefono = Convert.ToInt32(Console.ReadLine());
            telefonos[numDatos] = telefono;
            numDatos++;

            Console.WriteLine("Introduce el nombre: ");
            nombre = Console.ReadLine();
        }



        if (numDatos != 0)
        {
            if (nombre != null && nombre != "")
            {
                nombres[numDatos] = nombre;
                Console.WriteLine("Introduce el numero de telefono: ");
                telefono = Convert.ToInt32(Console.ReadLine());
                telefonos[numDatos] = telefono;
                numDatos++;
            }
            Console.WriteLine("Introduce un teléfono para hallar el nombre de la persona: ");
            telefono_marcado = Convert.ToInt32(Console.ReadLine());

            // BUSQUEDA LINEAL
            posActual = 0;
            while (telefono_marcado != telefonos[posActual] & posActual < numDatos - 1)
                posActual++;
            if (telefono_marcado == telefonos[posActual])
                Console.WriteLine("El número {0} pertenece a {1}.   ({2})", telefono_marcado, nombres[posActual], posActual);
            else
                Console.WriteLine("El número no exixte");
        }

    }
}