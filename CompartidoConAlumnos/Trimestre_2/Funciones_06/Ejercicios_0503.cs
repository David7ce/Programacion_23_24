internal class Ejercicios_0503
{
    public static double Funcion1_SumarElementos(double[] array)
    {
        // Implementa la lógica para sumar los elementos del array
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    public static double Funcion2_CalcularPromedio(double[] array)
    {
        // Implementa la lógica para calcular el promedio
        double total = Funcion1_SumarElementos(array);
        double media = total / array.Length;
        return media;

        // Opcion
        //return SumarElementos(array) / array.Length;
    }
    public static int Funcion3_BuscarElemento(double[] array, double valor)
    {
        // Implementa la lógica para buscar el elemento y devolver su posición
        int pos = 0;
        while (pos < array.Length - 1 && array[pos] != valor)
            pos++;
        return  array[pos] == valor ? pos : -1;
    }
    public static double[] Funcion4_FiltrarDatos(double[] tabla, double limite)
    {
        // Implementa la lógica para filtrar los datos y devolver un nuevo array
        //double[] resultado;
        //int rPosicion = 0;
        //int contador = 0;
        //foreach (double item in tabla)
        //{
        //    if (item > limite)
        //        contador++;
        //}
        //resultado = new double[contador];

        //foreach (double item in tabla)
        //{
        //    if (item > limite)
        //        resultado[rPosicion++] = item;
        //}
        //return resultado;

        List<double> list = new List<double>();
        foreach (double item in tabla)
            if (item > limite)
                list.Add(item);
        return list.ToArray();



    }
    public static double[,] Funcion5_RecortaMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int numFilas, int numColumnas)
    {
        double[,] nuevoArray = new double[numFilas, numColumnas];
        int f, c;

        for (f = 0; f < nuevoArray.GetLength(0); f++)
        {
            for (c = 0; c < nuevoArray.GetLength(1); c++)
            {
                nuevoArray[f, c] = matrizOriginal[inicioFila + f, inicioColumna + c];
            }
        }
        return nuevoArray;
    }
    public static double[,] Funcion6_OrlarMatriz(double[,] matrizOriginal, int inicioFila, int inicioColumna, int numFilas, int numColumnas)
    {
        double[,] nuevoArray = new double[numFilas + 2, numColumnas + 2];
        int fOrig, cOrig;
        int fNueva, cNueva;

        for (fNueva = 1 , fOrig=inicioFila; fNueva < nuevoArray.GetLength(0)-1 ; fNueva++,fOrig++)
        {
            for (cNueva = 1,cOrig=inicioColumna; cNueva < nuevoArray.GetLength(1)-1; cNueva++,cOrig++)
            {
                 nuevoArray[fNueva, cNueva] = matrizOriginal[inicioFila + fNueva - 1, inicioColumna + cNueva - 1];
            }
        }
        return nuevoArray;
    }

    public static void FuncEXTRA_incrementaTabla()
    {
        int[] t = Ejercicios_0502.funcion3_creaTabla(6);
        Tablas.mostrar(t);
        int i = 0;
        while (i < t.Length)
            t[i++]++;
        // MAL
        //foreach (int i in t)
        //{
        //    i = i + 1;
        //}
        Tablas.mostrar(t);
    }
}
