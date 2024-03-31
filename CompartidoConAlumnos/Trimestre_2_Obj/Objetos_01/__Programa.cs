internal class __Programa
{
    static void Main(string[] args)
    {
        //PruebaPunto();
        //PruebaMenu();
        //PruebaTablaLista();
        //PruebaMiLista();
        //PruebaPuntoDeCarreras();
        PruebaCandado();
    }
    private static void PruebaCandado()
    {
        Candado candado = new Candado();
        int cod, intentos = 0;
        do
        {
            Console.WriteLine("Intento: " + (++intentos));
            Console.Write("Codigo: ");
            try
            {
                cod = Convert.ToInt32(Console.ReadLine());
                candado.Abrir(cod);
                Console.WriteLine(candado.ToString());
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida");
            }
        } while (candado.EstaCerrado());
        Console.WriteLine("Adivinado en {0} intentos.", intentos);
    }

    private static void PruebaPuntoDeCarreras()
    {
        PuntoDeCarreras[] competidores = {
            new PuntoDeCarreras(5, 2, 'ñ'),
            new PuntoDeCarreras(5, 4, '*'),
            new PuntoDeCarreras(5, 6, 'o'),
            new PuntoDeCarreras(5, 8, '>')
        };
        char pulsacion;
        Boolean fin = false;
        PuntoDeCarreras.FijarMeta(100);
        for (int i = 0; i < 10; i++)
        {
            Console.SetCursorPosition(PuntoDeCarreras.getMeta(), i);
            Console.Write('|');
        }
        foreach (PuntoDeCarreras p in competidores)
            p.Mostrar();
        pulsacion = Console.ReadKey().KeyChar;
        while (pulsacion != 'q' && !fin)
        {
            foreach (PuntoDeCarreras p in competidores)
            {
                p.Ocultar();
                //                fin = fin | p.Avanzar(10);
                fin = fin | (p.getId() == 'ñ' ? p.Avanzar(10) : p.Avanzar(7));
                p.Mostrar();
            }
            pulsacion = Console.ReadKey().KeyChar;
        }
    }

    private static void PruebaMiLista()
    {
        MiLista l1, l2;
        l1 = new MiLista();
        l2 = new MiLista();
        l1.Insertar(23, 0);
        l1.Insertar(-4, 0);
        l2.Insertar(0, 0);
        l2.Insertar(3, 1);
        l1.Mostrar();
        l2.Mostrar();
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Insertar(-4, 0);
        l1.Mostrar();
    }

    private static void PruebaTablaLista()
    {
        //        int[] datos = Tablas.creaTabla(10);
        int[] datos = { 79, 42, 0, 27, 1, 999, 0, 0, 0, 0 };
        int numDatos = 5;
        int extraido;
        Console.WriteLine("La tabla Completa");
        Tablas.mostrar(datos);

        Console.WriteLine("Los datos de mi tabla con {0} elementos.", numDatos);
        DatosEnArray.Mostrar(datos, numDatos);

        DatosEnArray.InsertarElementoEnPosicion(datos, ref numDatos, -1, 0);

        Console.WriteLine("Los datos de mi tabla con {0} elementos.", numDatos);
        DatosEnArray.Mostrar(datos, numDatos);

        extraido = DatosEnArray.QuitarElementoEnPosicion(datos, ref numDatos, 1);

        Console.WriteLine("Los datos de mi tabla con {0} elementos.", numDatos);
        Console.WriteLine("Tras haber sacado {0} de la posición {1}.", extraido, 1);
        DatosEnArray.Mostrar(datos, numDatos);

    }


    static void PruebaMenu()
    {
        Menu m;
        int op;
        m = new Menu();
        m.añadir("Comecocos.");
        m.añadir("Snake.");
        m.añadir("Barcos.");
        m.añadir("Terminar.");
        m.mostrar();
        op = m.leer();
        while (op != m.getOpciones() - 1)
        {
            //Console.WriteLine("Opcion seleccionada " + (op + 1));
            Console.WriteLine("Opcion seleccionada " + m.getOpcion(op));

            m.mostrar();
            op = m.leer();
        }
    }

    static void PruebaPunto()
    {
        ConsoleKeyInfo pulsado;
        //Punto p = new Punto(20, 20);
        Punto p = new Punto();
        while ((pulsado = Console.ReadKey()).Key != ConsoleKey.Escape)
        {
            switch (pulsado.Key)
            {
                case ConsoleKey.RightArrow:
                    p.derecha();
                    break;
                case ConsoleKey.LeftArrow:
                    p.izquierda();
                    break;
                case ConsoleKey.UpArrow:
                    p.arriba();
                    break;
                case ConsoleKey.DownArrow:
                    p.abajo();
                    break;
            }
            Console.SetCursorPosition(p.getX(), p.getY());
            Console.Write('*');
            Console.SetCursorPosition(0, 0);
        }
        Console.WriteLine("Adios");
    }
}