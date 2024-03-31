namespace Biologia;
public class Animal
{
    public String sexo; //M o H
    public int numeroPatas;
    public short edad;
    public double peso;
    public String especie;
    public Animal(String _sexo,
                   int _numeroPatas,
                   short _edad,
                   double _peso,
                   String _especie)
    {
        sexo = _sexo;
        numeroPatas = _numeroPatas;
        edad = _edad;
        peso = _peso;
        especie = _especie;
        Console.WriteLine("Inicializados mis atributos como Animal que soy...");
    }//Constructor

    public override String ToString()
    {
        return $"Soy un objeto de clase {base.ToString()}";
    }
}//class Animal


