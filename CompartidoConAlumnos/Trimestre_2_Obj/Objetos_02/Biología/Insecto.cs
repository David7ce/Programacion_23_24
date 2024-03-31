namespace Biologia;
public class Insecto : Animal
{
    public byte numeroDeAlas;
    public Insecto(String _sexo,
                     int _numeroPatas,
                     short _edad,
                     double _peso,
                     String _especie,
                     byte _numeroDeAlas) : base(_sexo, _numeroPatas, _edad, _peso, _especie)
    {
        numeroDeAlas = _numeroDeAlas;
        Console.WriteLine("Inicializados mis atributos como Insecto que soy...");
    }//Constructor
}//class Insecto
