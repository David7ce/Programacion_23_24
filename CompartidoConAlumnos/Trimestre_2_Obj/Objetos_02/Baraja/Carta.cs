namespace Baraja;
public class Carta
{
    //private static string[] nombreCarta = { "A", "DOS", "TRES", "CUATRO", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
    private static string[] nombreCarta = { "A", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "J", "Q", "K" };
    private int valor;
    private Palo palo;

    public Carta(int valor, Palo palo)
    {
        this.valor = valor;
        this.palo = palo;
    }

    public Palo Palo()
    {
        return palo;
    }

    public int Valor()
    {
        return valor;
    }

    public override String ToString()
    {
        return nombreCarta[valor - 1] + " de " + palo;
    }
}