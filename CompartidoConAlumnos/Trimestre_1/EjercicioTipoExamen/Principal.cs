internal class Principal
{
    static void Main(string[] args)
    {
        int i;
        //double absActual, absAnterior;
        double[] datos;
        datos = new double[15];
        for (i = 0; i < datos.Length; i++)
        {
            datos[i] = Convert.ToDouble(Console.ReadLine());
        }
        for (i = 0; i < datos.Length - 1; i++)
        {
            // absActual = datos[i] < 0 ? -datos[i] : datos[i];
            // absAnterior = datos[i-1] < 0 ? -datos[i-1] : datos[i-1];
            // if (absActual < absAnterior)


            Console.Write("{0,8}", datos[i]);
            if (Math.Abs(datos[i]) > Math.Abs(datos[i + 1]))
                Console.WriteLine();
        }
        Console.Write("{0,8}", datos[datos.Length - 1]);
    }
}

