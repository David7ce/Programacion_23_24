namespace Baraja;
public class Mazo
{
    private int numCartas = 52;
    private Carta[] cartas;
    private static Random alea = new Random();
    public Mazo()
    {
        cartas = new Carta[numCartas];
        for (int i = 0; i < numCartas; i++)
        {
            cartas[i] = new Carta((i % 13) + 1, (Palo)(i / 13));
        }
    }
    public int numeroCartas()
    {
        return numCartas;
    }
    public Carta daCarta()
    {
        int posCarta = alea.Next(numCartas);
        Carta ret = cartas[posCarta];
        cartas[posCarta] = cartas[numCartas - 1];
        numCartas--;
        return ret;
    }
}