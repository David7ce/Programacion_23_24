internal class Principal
{
    static void Main(string[] args)
    {
        int[] datos1 = { 1, 2, 3, 4, 9, 10, 11, 12 };
        int[] datos2 = new int[10];
        Funciones_03.mostrar(datos1);
        Funciones_03.mostrar(datos2);
        Funciones_03.rellenar(datos2, 1, 11);
        Funciones_03.mostrar(datos2);
        Funciones_03.rellenar(datos2, 1, 11);
        Funciones_03.mostrar(datos2);
        Funciones_03.rellenar(datos2, 1, 11);
        Funciones_03.mostrar(datos2);
    }
}
