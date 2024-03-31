namespace Biologia;
public class Ave : Animal
{
    public String colorPlumaje;
    public int longitudDelPico;
    public byte numeroDeAlas;
    public Ave(String _sexo,
                 short _edad,
                 int _peso,
                 String _especie,
                 String _colorPlumaje,
                 int _longitudDelPico,
                 byte _numeroDeAlas) : base(_sexo, 2, _edad, _peso, _especie)
    {
        colorPlumaje = _colorPlumaje;
        longitudDelPico = _longitudDelPico;
        numeroDeAlas = _numeroDeAlas;
        Console.WriteLine("Inicializados mis atributos como Ave que soy...");

    }//Constructor	
}//class Ave
