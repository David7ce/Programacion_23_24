    internal class Pruebas_0503
    {

    // --------------------------------
    // Pruebas para los ejercicios 0503
    // --------------------------------
    public static void pruebaFuncion1()
    {
        double[] datos = { 45.5, -2.06, 0.1, 9.2, -12.0, 0.0, 6.1 };
        Tablas.mostrar(datos);
        Console.WriteLine("La suma de estos datos es {0:f2}", Ejercicios_0503.Funcion1_SumarElementos(datos));
    }
    public static void pruebaFuncion2()
    {
        double[] datos = { 45.5, -2.06, 0.1, 9.2, -12.0, 0.0, 6.1 };
        Tablas.mostrar(datos);
        Console.WriteLine("La media de estos datos es {0:f2}", Ejercicios_0503.Funcion2_CalcularPromedio(datos));
    }
    public static void pruebaFuncion3()
    {
        int pos;
        double[] datos = { 45.5, -2.06, 0.1, 9.2, -12.0, 0.0, 6.1 };
        Tablas.mostrar(datos);
        pos = Ejercicios_0503.Funcion3_BuscarElemento(datos, 0.2);
        if (pos != -1)
            Console.WriteLine("El dato {0} está en la posición {1}", 0.2, pos);
        else
            Console.WriteLine("El dato {0} no está.", 0.2);
        pos = Ejercicios_0503.Funcion3_BuscarElemento(datos, 9.2);
        if (pos != -1)
            Console.WriteLine("El dato {0} está en la posición {1}", 9.2, pos);
        else
            Console.WriteLine("El dato {0} no está.", 9.2);
    }
    public static void pruebaFuncion4()
    {
        double[] limite = { 5.0, 0.0 };
        double[] seleccion;
        double[] datos = { 45.5, -2.06, 0.1, 9.2, -12.0, 0.0, 6.1 };
        Tablas.mostrar(datos);

        foreach (double lim in limite)
        {
            seleccion = Ejercicios_0503.Funcion4_FiltrarDatos(datos, lim);
            Console.Write("Los datos por encima de {0:f2} son: ", lim);
            Tablas.mostrar(seleccion);
        }
    }
    public static void pruebaFuncion5y6()
    {
        double[,] datos = Tablas.creaTabla(6, 8);
        double[,] recorte;
        double[,] orlada;
        int desdeFila=1,
            desdeColum=1,
            alto=3,
            ancho=3;
        Console.WriteLine("------ ORIGINAL ----");
        Tablas.mostrar(datos, 7);
        Console.WriteLine("\n------ RECORTE ----");
        recorte = Ejercicios_0503.Funcion5_RecortaMatriz(datos, desdeFila, desdeColum, alto, ancho);
        Tablas.mostrar(recorte, 7);
        Console.WriteLine("\n------ ORLADA ----");
        orlada = Ejercicios_0503.Funcion6_OrlarMatriz(datos, desdeFila, desdeColum, alto, ancho);
        Tablas.mostrar(orlada, 7);
    }


}

