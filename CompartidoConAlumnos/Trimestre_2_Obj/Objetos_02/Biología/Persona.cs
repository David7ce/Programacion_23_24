namespace Biologia;
public class Persona : Mamifero
{

    public bool estaCasado = false;

    public Persona(String _sexo,
                      short _edad,
                      double _peso,
                      String _colorPelo,
                      bool _tieneDientes,
                      bool _estaCasado) : base(_sexo, 2, _edad, _peso,
              "Homo Sapiens", _colorPelo, _tieneDientes)
    {
        estaCasado = _estaCasado;
        Console.WriteLine("Inicializados mis atributos como Persona que soy...");
    }//Constructor
}//class Persona
