public class Candado
{
    private Boolean abierto = false;
    private int codigo;
    private static Random r = new Random();

    public Candado()
    {
        codigo = r.Next(0, 11);
    }
    public void Abrir(int codigo)
    {
        if (codigo == this.codigo)
            abierto = true;
    }
    public Boolean EstaCerrado()
    {
        return !abierto;
    }
    public void Cerrar()
    {
        if (abierto)
        {
            abierto = false;
            codigo = r.Next(0, 11);
        }
    }
    public String ToString()
    {
        String resul;
        if (abierto)
            resul = String.Format("Abierto (cod: {0})", codigo);
        else
            resul = "Cerrado";
        return resul;
    }

}
