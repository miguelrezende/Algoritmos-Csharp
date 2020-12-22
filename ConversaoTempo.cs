using System;

class Desafio
{
    public static void Main(string[] args)
    {

        int valor = int.Parse(Console.ReadLine());
        int quantidadeDeHoras = valor / 3600;
        int quantidadeDeMinutos = (valor % 3600) / 60;
        int quantidadeDeSegundos = (valor % 3600) % 60;
        Console.Write($"{quantidadeDeHoras}:{quantidadeDeMinutos}:{quantidadeDeSegundos}");
    }
}