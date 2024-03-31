namespace BusquedaLineal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] datos = {12.3f , 10 , -3.5f , 0.00004f};
            float DATO_BUSCADO = 9;
            int i=0;

            while(DATO_BUSCADO != datos[i] & i<datos.Length-1) {
                i++;
            }
            if(DATO_BUSCADO == datos[i])


        }
    }
}