﻿public class Drawing
{
    public static void showRectangle(int x, int y, int ancho, int alto)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = x; i <= ancho + x; i++)
        {
            Console.SetCursorPosition(i, 0 + y);
            Console.Write("*");
            Console.SetCursorPosition(i, alto + y);
            Console.Write("*");
        }

        for (int j = y; j < alto + y; j++)
        {
            Console.SetCursorPosition(x, j);
            Console.Write("*");
            Console.SetCursorPosition(ancho + x, j);
            Console.Write("*");
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n");
    }

    public static void showTriangle(char c, int altura)
    {
        Render(Draw(c, altura)); // Llama al Método Render que llama al Método Draw y le Pasa el Caracter a Dibujar y la Altura.
    }

    public static void Render(char[,] map) // Chorizeado de Internet, recibe el Array Bidimensional map.
    {
        int width = map.GetLength(1); // El Ancho es el Tamaño del Array de las X.
        int height = map.GetLength(0); // El Alto es el Tamaño del Array de las Y.

        for (int i = 0; i < height; i++) // Hace un Bucle Desde 0 a la Altura.
        {
            if (i != 0) // Si i es Distinto de 0.
            {
                Console.WriteLine(); // Hace un Salto de Línea.
            }

            for (int j = 0; j < width; j++) // Hace un Bucle Desde 0 al Ancho.
            {
                char c = map[i, j]; // Asgina al char c el Caracter en el Array Bidimensional map en los índices i y j.
                Console.Write(c == '\0' ? ' ' : c); // Dibuja en Pantalla el Caracter c, si es NULL Dibuja un Espacio, si no Dibuja el Caracter Pasado Para Dibujar.
            }
        }
        Console.WriteLine(); // Hace un Salto de Línea
    }

    public static char[,] Draw(char sym, int height) // Chorizeado de Internet, Recibe el Caracter y la Altura.
    {
        int width = height * 2 - 1; // El Ancho es igual al alto * 2 - 1.
        char[,] map = new char[height, width]; // Crea un Array Bidimensional de Caracteres Llamado map con la Altura y el Ancho.
        int x = width - 1; // Asigna a x el Ancho - 1.
        int y = height - 1; // Asigna a y el Alto - 1.

        for (int i = 0; i < height; i++) // Hace un Bucle Desde 0 a la Altura.
        {
            map[y, i * 2] = sym; // En el Array de char map Pone en y, i * 2 el Caracter a Dibujar.

            if (i != 0) // Si i es Distinto de 0.
            {
                map[y - i, i] = sym; // map de y - i, i = al Caracter a Dibujar.
                map[y - i, x - i] = sym; // en map de y - i, x - i = al Carater a Dibujar.
            }
        }
        return map; // Retorna el Array Bidimensional map.
    }

    public static void showCircle(int radio)
    {
        double thickness = 0.4; // Espesor del borde
        double rIn = radio - thickness, rOut = radio + thickness; // Al Borde del Radio Interno se le resta el Espesor y al Externo de le Suma.

        Console.ForegroundColor = ConsoleColor.Green; // Cambio el color del Pincel a Verde.
        for (double y = radio; y >= -radio; --y) // Bucle Desde el radio Hasta el radio Negativo Predecrementando y la Vertical.
        {
            for (double x = -radio; x < rOut; x += 0.5) // Bucle Desde el Radio Negativo Hasta el radio + el Espesor Post Incrementando en .5.
            {
                double value = x * x + y * y; // Asigno a la Variable value la Suma de x al Cuadrado + y al Cuadrado.
                if (value >= rIn * rIn && value <= rOut * rOut) // Si value es Mayor o Igual que el Radio Interno al Cuadrado Y es Menor o Igual que el Radio Externo al Caudrado.
                {
                    Console.Write('*'); // Pinto el Asterisco, Cuerpo de la Circunferencia.
                }
                else // Si No.
                {
                    Console.Write(' '); // Pinto un Espacio.
                }
            }
            Console.WriteLine(); // Salto de Línea.
        }
        Console.ForegroundColor = ConsoleColor.Gray; // Cambio el Color del Pincel a Gris, el Estandar de la Consola.
    }

    public static void showOctogon(int size, double apotema)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(30, 85);
        horizontal(size);
        Console.SetCursorPosition(30, size / 2 + (int)apotema + 85);
        horizontal(size);
        vertical(size, apotema);
        diagonal(size, apotema);
        Console.ForegroundColor = ConsoleColor.Gray;
    }

    private static void diagonal(int size, double apotema)
    {
        int j = 0;
        for (int i = 1; i <= size / 2 - 1; i++)
        {
            Console.SetCursorPosition(30 - (int)apotema - 1 + i + j, 85 + (int)apotema / 2 - i + 1);
            Console.Write('*');
            Console.SetCursorPosition(30 + size + i - 1 + j, size / 2 + (int)apotema + 85 - j);
            Console.Write('*');
            Console.SetCursorPosition(30 + size + i + j - 1, 85 + j);
            Console.Write('*');
            Console.SetCursorPosition(30 - (int)apotema - 1 + i + j, 85 + size + j - 1);
            Console.Write('*');
            j++;
        }
    }

    private static void horizontal(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write('*');
        }
    }

    private static void vertical(int size, double apotema)
    {
        for (int i = 0; i < size / 2 + 1; i++)
        {
            Console.SetCursorPosition(30 - (int)apotema, i + 85 + (int)apotema / 2);
            Console.Write("*");
            Console.SetCursorPosition(30 + size + (int)apotema - 1, i + 85 + (int)apotema / 2);
            Console.Write("*");
        }
    }
}