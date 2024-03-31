using MetroTenerife;

namespace Objetos_02_Tranvia_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tranvia t = new Tranvia();
            Console.WriteLine(t);
            t.Subir(new Pasajero("Garcia"), 2);
            t.Subir(new Pasajero("Jana"), 2);
            t.Subir(new Pasajero("Felipe"), 2);
            t.Subir(new Pasajero("Ana"), 2);
            t.Subir(new Pasajero("Alba"), 2);
            t.Subir(new Pasajero("Gustavo"), 2);
            Console.WriteLine(t);

            Pasajero p = t.Bajar("Gustavo", 3);
            t.Subir(p, 0);
            Console.WriteLine(t);



        }
    }
}