public class Sorteo : AbtractaSorteo
{
    //public Sorteo() : base(10) { }
    //public Sorteo() : this(10) { }

    public Sorteo(int nCand = 10) : base(nCand) { }
    public override void Incluir(String nombre)
    {
        if (nCandidatos == candidatos.Length)
            throw new Exception("El cupo de candidatos está completo.");
        candidatos[nCandidatos++] = nombre;
    }
    public override void Incluir(String[] nombres)
    {
        foreach (String n in nombres)
            Incluir(n);
    }
    public override String Seleccionar()
    {
        if (nCandidatos == 0)
            throw new Exception("No hay ni un solo candidato.");
        int posElegida = alea.Next(nCandidatos);
        String elegido = candidatos[posElegida];
        candidatos[posElegida] = candidatos[nCandidatos - 1];
        nCandidatos--;
        return elegido;
    }
    public override String[] Seleccionar(int cuantos)
    {
        //if (nCandidatos < cuantos)
        //    cuantos = nCandidatos;
        //String[] elegidos = new string[cuantos];
        //for (int i = 0; i < cuantos; i++)
        //    elegidos[i] = Seleccionar();
        //return elegidos;

        String[] elegidos;
        if (nCandidatos <= cuantos)
        {
            elegidos = new string[nCandidatos];
            for (int i = 0; i < nCandidatos; i++)
                elegidos[i] = candidatos[i];
            nCandidatos = 0;
        }
        else
        {
            elegidos = new string[cuantos];
            for (int i = 0; i < cuantos; i++)
                elegidos[i] = Seleccionar();
        }
        return elegidos;
    }

    public override string ToString()
    {
        int i;
        String aux = "{";
        for (i = 0; i < nCandidatos - 1; i++)
        {
            aux += $"\"{candidatos[i]}\",";
        }
        if (nCandidatos > 0)
            aux += $"\"{candidatos[i]}\"";
        aux += "}";
        return aux;
    }
    public override void Vaciar()
    {
        nCandidatos = 0;
    }
}
