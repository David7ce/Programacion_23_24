public class Memory : MemoryBase
{
    public Memory(String[] pTextos) : base(pTextos) { }
    public override Boolean Jugar()
    {
        int aciertos = 0;
        Boolean superaRecord = false;
        while (base.Jugar())
            aciertos++;

        if (ganador == null || aciertos > ganador.GetPuntos())
        {
            Console.WriteLine("Felicidades. ¡Superaste el record!");
            Console.Write("Dime tu nombre: ");
            ganador = new Jugador(Console.ReadLine(), aciertos);
            superaRecord = true;
        }
        return superaRecord;
    }
}
