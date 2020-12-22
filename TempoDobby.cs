using System;

class Desafio6
{
    public static void Main(string[] args)
    {
        int finalExpediente = int.Parse(Console.ReadLine());
        string[] presentes = Console.ReadLine().Split(" ");
        int primeiroPresente = int.Parse(presentes[0]);
        int segundoPresente = int.Parse(presentes[1]);

        int soma = primeiroPresente + segundoPresente;
        if (soma > finalExpediente)
        {
            Console.WriteLine("Deixa para amanha!");
        }
        else
        {
            Console.WriteLine("Farei hoje!");
        }

    }
}