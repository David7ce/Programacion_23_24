namespace Personas;

public class Persona
{
    protected long DniNumero;
    protected char DniLetra;
    public String Nombre { get; set; }
    private int edad;
    public int Edad
    {
        get { return edad; }
        set
        {
            if (value < 0 || value > 140)
                throw new Exception();
            edad = value;
        }
    }
    public Persona(long n, char l)
    {
        l = Char.ToUpper(l);
        if (LetraDNI(n) != l)
            throw new ArgumentException("El dni facilitado no es válido");
        this.DniNumero = n;
        this.DniLetra = l;
    }
    public override bool Equals(object? obj)
    {
        Persona elOtro = (Persona)obj;
        return this.DniNumero == elOtro.DniNumero;
    }
    public override string ToString()
    {
        return $"{Nombre} con DNI:{DniNumero}{DniLetra} tiene {Edad} años.";
    }
    private static char LetraDNI(long l)
    {
        String LETRAS = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posLetra = (int)(l % LETRAS.Length);
        return LETRAS[posLetra];
    }

}
