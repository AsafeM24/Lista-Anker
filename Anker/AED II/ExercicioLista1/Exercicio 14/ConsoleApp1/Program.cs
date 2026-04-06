/* 14 Crie dois vetores de	50 posições com	valores	inteiros aleatórios, ordene	cada vetor	
individualmente, e combine os dois vetores gerando	um novo vetor de 100 posições, de	
forma que esse novo	vetor já seja criado ordenado. */
using System;
class Vetores50
{
    static void Main()
    {
        Random rand = new Random();
        int[] vet1 = new int[50], vet2 = new int[50], vet3 = new int[100];
        int i = 0, j = 0;
        for (i = 0; i < 50; i++)
        {
            vet1[i] = rand.Next(0, 100);
            vet2[i] = rand.Next(0, 200);
        }
        Console.WriteLine("Vetor 1 de 50 posições gerado aleatóriamente:");
        for (i = 0; i < 50; i++)
        {
            vet3[i] = vet1[i];
            Console.Write($"{vet1[i]} ");

        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Vetor 2 de 50 posições gerado aleatóriamente:");
        for (i = 0; i < 50; i++)
        {
            vet3[i + 50] = vet2[i];
            Console.Write($"{vet2[i]} ");

        }
        Console.WriteLine();
        Console.WriteLine();
        for (i = 0; i < 99; i++)
        {
            for (j = 0; j < 99 - 1; j++)
            {
                if (vet3[j] > vet3[j + 1])
                {
                    int valor = vet3[j];
                    vet3[j] = vet3[j + 1];
                    vet3[j + 1] = valor;
                }
            }
        }
        Console.WriteLine("Vetor 3 de 100 posições ordenado com os valores dos vetores 1 e 2:");
        for (i = 0; i < 100; i++)
        {
            Console.Write($"{vet3[i]} ");
        }

    }
}