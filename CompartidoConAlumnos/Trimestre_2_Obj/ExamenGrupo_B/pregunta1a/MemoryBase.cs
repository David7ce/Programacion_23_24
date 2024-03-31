public class MemoryBase : JuegoAbstracto
{
    private String[] palabras;
    protected static Random aleat = new Random();
    public MemoryBase(String[] palabras)
    {
        this.palabras = palabras;
    }
    public override Boolean Jugar()
    {
        String elegida = palabras[aleat.Next(palabras.Length)];
        String? resp;
        pantallaVolatil.Mostrar(elegida);
        Console.WriteLine("\n¿Qué texto viste entre las flechas? ");
        resp = Console.ReadLine();
        return resp == elegida;
    }

    public override Jugador GetLider()
    {
        if (ganador == null)
            throw new Exception("Aún no hay lider");
        return ganador;
    }

}
