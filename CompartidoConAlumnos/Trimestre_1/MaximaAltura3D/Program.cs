namespace MaximaAltura3D;
internal class Program
{
    static void Main(string[] args)
    {
        int i, r, curso;
        int iMax, rMax, cursoMax;
        iMax = rMax = cursoMax = 0;
        double alturamaxima;
        double[][][] alturas =
         new double[][][]
         {
            //1ºCurso
            new double[][] {
              new double[]{ 1.89,1.79,1.67,1.56,1.90,1.59}, //norepetidor
              new double[] {1.60,1.40,1.30,1.34} //repetidor
            },
            //2ºCurso
            new double[][] {
              new double[]{ 1.12,1.23,1.34,1.45,1.56,1.67,1.78,1.89,1.91}, //norepetidor
              new double[] {} //repetidor
            },
            //3ºCurso
            new double[][] {
              new double[]{ 1.80,1.65,1.97,1.76}, //norepetidor
              new double[] {1.00,1.05,1.66,1.30} //repetidor
            },
            //4ºCurso
            new double[][] {
              new double[]{0.90,1.34,1.47,1.09,1.12,1.14}, //norepetidor
              new double[] {1.88,1.40,1.97,1.22,1.65,1.33,1.55} //repetidor
            }
         };

        alturamaxima = 0;     //Double.NegativeInfinity;
        for (curso = 0; curso < alturas.Length; curso++)
        {
            for (r = 0; r < alturas[curso].Length; r++)
            {
                for (i = 0; i < alturas[curso][r].Length; i++)
                {
                    if (alturas[curso][r][i] > alturamaxima)
                    {
                        alturamaxima = alturas[curso][r][i];
                        cursoMax = curso;
                        rMax = r;
                        iMax = i;
                    }
                }
            }
        }
        Console.WriteLine(alturamaxima);
        Console.WriteLine("Se trata del un alumno/a de {0}ºESO.", cursoMax + 1);
        Console.WriteLine("{0}s repetidor.", rMax == 0 ? "No e" : "E");

    }
}
