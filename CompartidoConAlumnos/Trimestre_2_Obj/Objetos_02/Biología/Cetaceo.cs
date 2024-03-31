namespace Biologia;
public class Cetaceo : Mamifero, Acuatico
{
    public Cetaceo(String _sexo,
                      short _edad,
                      double _peso,
                      String _especie) : base(_sexo, 0, _edad, _peso, _especie, "", false)
    {
        Console.WriteLine("Inicializados mis atributos como Cetaceo que soy...");
    }
    public bool EsMarino() { return true; }
}
