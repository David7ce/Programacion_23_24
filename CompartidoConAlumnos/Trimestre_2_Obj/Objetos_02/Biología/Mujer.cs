namespace Biologia;
public class Mujer : Persona
{
    public bool embarazada = false;
    public Mujer(short _edad,
                    double _peso,
                    String _colorPelo,
                    bool _tieneDientes,
                    bool _estaCasado,
                    bool _embarazada) : base("Femenino", _edad, _peso,
              _colorPelo, _tieneDientes, _estaCasado)
    {
        embarazada = _embarazada;
        Console.WriteLine("Inicializados mis atributos como Mujer que soy...");
    }//Constructor
}//class Mujer