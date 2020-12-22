using System;

class Desafio
{
    public static void Main(string[] args)
    {

        string[] numeroDeTestes = Console.ReadLine().Split(" ");
        int pessoas = int.Parse(numeroDeTestes[0]);
        int numeroDeDatas = int.Parse(numeroDeTestes[1]);

        string datas = "";
        bool podemIr = true;
        for (int i = 1; i <= numeroDeDatas; i++)
        {
            podemIr = true;
            string[] entradaDatas = Console.ReadLine().Split(" ");
            datas = entradaDatas[0];
            for (int j = 1; j <= pessoas; j++)
            {
                int convidados = int.Parse(entradaDatas[j]);

                if (convidados == 0)
                {
                    podemIr = false;
                    break;
                }
            }
            if (podemIr)
            {
                Console.WriteLine(datas);
                break;
            }
        }

        if (!podemIr)
        {
            Console.WriteLine("Pizza antes de FdA");
        }

    }
}