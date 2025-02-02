﻿namespace Baraja;
public class Mazo
{
    private int numCartas = 40;
    private Carta[] cartas;
    private static Random alea = new Random();
    public Mazo()
    {
        int i = 0;
        cartas = new Carta[numCartas];
        for (int palo = 0; palo < 4; palo++)
            for (int num = 1; num <= 10; num++)
            {
                cartas[i++] = new Carta(num, (Palo)palo);
            }
        //for (int i = 0; i < numCartas; i++)
        //{
        //    cartas[i] = new Carta((i % 10) + 1, (Palo)(i / 10));
        //}
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