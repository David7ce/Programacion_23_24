namespace Biologia;
public class Hombre : Persona
{
    public Hombre(short _edad,
                     double _peso,
                     String _colorPelo,
                     bool _tieneDientes,
                     bool _estaCasado) : base("Varon", _edad, _peso,
              _colorPelo, _tieneDientes, _estaCasado)
    {
        Console.WriteLine("Inicializados mis atributos como Hombre que soy...");
    }//Constructor	
}//class Hombre

