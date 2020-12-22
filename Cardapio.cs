using System;

class Desafio
{
    public static void Main(string[] args)
    {

        string[] refeicoes = Console.ReadLine().Split(" ");
        int ca = int.Parse(refeicoes[0]);
        int ba = int.Parse(refeicoes[1]);
        int pa = int.Parse(refeicoes[2]);
        string[] pedidos = Console.ReadLine().Split(" ");
        int cr = int.Parse(pedidos[0]);
        int br = int.Parse(pedidos[1]);
        int pr = int.Parse(pedidos[2]);

        int pizzasFaltantes = 0;
        if (cr > ca)
        {
            pizzasFaltantes = cr - ca;
        }

        int saladasFaltantes = 0;

        if (br > ba)
        {
            saladasFaltantes = br - ba;
        }

        int massasFaltantes = 0;

        if (pr > pa)
        {
            massasFaltantes = pr - pa;
        }

        int totalFaltando = pizzasFaltantes + saladasFaltantes + massasFaltantes;
        Console.WriteLine(totalFaltando);
    }

}