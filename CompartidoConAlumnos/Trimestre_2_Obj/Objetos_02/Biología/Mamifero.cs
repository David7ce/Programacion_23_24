namespace Biologia;
public class Mamifero : Animal
{
    public String colorPelo;
    public bool tieneDientes = true;

    public Mamifero(String _sexo,
                      int _numeroPatas,
                      short _edad,
                      double _peso,
                      String _especie,
                      String _colorPelo,
                      bool _tieneDientes) : base(_sexo, _numeroPatas, _edad, _peso, _especie)
    {
        //Propiedades especificas de Mamifero
        colorPelo = _colorPelo;
        tieneDientes = _tieneDientes;
        Console.WriteLine("Inicializados mis atributos como Mamifero que soy...");
    }//Constructor
}//class Mamifero