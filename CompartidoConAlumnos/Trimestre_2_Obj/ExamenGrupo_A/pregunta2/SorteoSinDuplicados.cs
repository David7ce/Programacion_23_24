public class SorteoSinDuplicados : Sorteo
{
    public SorteoSinDuplicados() { }
    public SorteoSinDuplicados(int nCand) : base(nCand) { }

    public override void Incluir(String nombre)
    {
        int pos = 0;
        while (pos < nCandidatos - 1 && candidatos[pos] != nombre)
            pos++;
        if (candidatos[pos] != nombre)
            base.Incluir(nombre);
    }

    //
    // NO ES NECESARIO SOBREESCRIBIR  ****************************
    // (su comportamiento cambia al sobreescribir la anterior) ***
    //
    //public override void Incluir(String[] nombres)
    //{
    //	foreach (String n in nombres)
    //		Incluir(n);
    //}

}