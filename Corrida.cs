using System;

class MinhaClasse
{
    public static void Main(string[] args)
    {

        string[] entrada = Console.ReadLine().Split(" ");
        int numeroDeVoltas = int.Parse(entrada[0]);
        int numeroDePlacasNaPista = int.Parse(entrada[1]);

        int totalDePlacas = numeroDePlacasNaPista * numeroDeVoltas;

        for (int i = 10; i < 100; i += 10)
        {
            double result = (double)totalDePlacas / 100 * i;
            Console.Write(Math.Ceiling(result) + " ");
        }
    }
}