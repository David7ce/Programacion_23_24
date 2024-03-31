namespace WinFormPersona.Modelo;

public class Persona
{
    protected int DniNumero;
    protected char DniLetra;
    private string nombre = "Desconocido";
    private int edad;
    public string Nombre
    {
        get
        { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException();
            nombre = value;
        }
    }
    public int Edad
    {
        get { return edad; }
        set
        {
            if (value < 0 || value > 140)
                throw new ArgumentException();
            edad = value;
        }
    }
    public Persona(int n, char l)
    {
        l = char.ToUpper(l);
        if (LetraDNI(n) != l)
            throw new ArgumentException("El dni facilitado no es válido");
        DniNumero = n;
        DniLetra = l;
    }
    public override bool Equals(object? obj)
    {
        bool igual;
        if (obj == null || !(obj is Persona))
            igual = false;
        else
        {
            Persona elOtro = (Persona)obj;
            igual = DniNumero == elOtro.DniNumero;
        }
        return igual;
    }
    public override string ToString()
    {
        return $"{Nombre} con DNI:{DniNumero}{DniLetra} tiene {Edad} años.";
    }
    private static char LetraDNI(int dni)
    {
        string LETRAS = "TRWAGMYFPDXBNJZSQVHLCKE";
        int posLetra = dni % LETRAS.Length;
        return LETRAS[posLetra];
    }

}
