public class Rectangulo
{
    private int ancho;
    private int alto;
    private Punto posicion;

    public Rectangulo(int x, int y, int alto, int ancho)
    {
        this.ancho = Math.abs(ancho);
        this.alto = Math.abs(alto);
        posicion = new Punto();
        posicion.setX(x);
        posicion.setY(y);
    }
    public int perimetro()
    {
        return 2*alto + 2*ancho;
    }
}
