internal class Program
{
    static void Main(string[] args)
    {
        String LETRAS = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posLetra;
        int iDni;
        String dni;
        Console.Write("Ingresa tu Número de D.N.I y te Diré la Letra: ");
        iDni = Convert.ToInt32(Console.ReadLine());
        posLetra = iDni % LETRAS.Length;
        //dni = String.Format("{0}{1}", iDni, LETRAS[posLetra]);
        dni = "" + iDni + LETRAS[posLetra];
        Console.WriteLine("Tu D.N.I. es: {0}", dni);
    }
}