﻿namespace MetroTenerife;
public class VagonPasajeros
{
    private int asientosOcupados;
    private Pasajero[] asientos;

    public VagonPasajeros() : this(20)
    {
    }
    public VagonPasajeros(int capacidad)
    {
        this.asientosOcupados = 0;
        this.asientos = new Pasajero[capacidad];
    }

    public void Subir(Pasajero pasajero)
    {
        if (asientosOcupados == asientos.Length)
            throw new Exception("No hay asientos libres en el vagon");
        asientos[asientosOcupados] = pasajero;
        asientosOcupados++;
        //for (int i = 0; i < asientos.Length; i++)
        //{
        //    if (asientos[i] == null)
        //    {
        //        asientos[i] = pasajero;
        //        asientosOcupados++
        //        return i; // Devuelve el índice del último asiento ocupado
        //    }
        //}
        //throw new Exception("No hay asientos libres en el vagon");
    }

    public Pasajero? Bajar(string nombre)
    {
        Pasajero? queBaja = null;
        int pos = 0;
        while (pos < asientosOcupados - 1 & asientos[pos].GetNombre() != nombre)
            pos++;
        if (asientos[pos].GetNombre() == nombre)
        {
            queBaja = asientos[pos];
            asientos[pos] = asientos[asientosOcupados - 1];
            asientosOcupados--;
        }
        return queBaja;


        //for (int i = 0; i < asientos.Length; i++)
        //{
        //    if (asientos[i] != null && asientos[i].GetNombre() == nombre)
        //    {
        //        Pasajero pasajeroEncontrado = asientos[i];
        //        asientos[i] = null;
        //        asientosOcupados--;
        //        return pasajeroEncontrado;
        //    }
        //}
        //throw new Exception($"No se encontró al pasajero {nombre} en el vagón.");
    }

    public override string ToString()
    {
        String aux = "VagonPasajeros\n";
        for (int i = 0; i < asientosOcupados; i++)
            aux += "  - " + asientos[i] + "\n";
        return aux;
    }
}
