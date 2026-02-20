/* 1 Crie um programa que exiba o seu nome na tela 100 vezes. */

using System.ComponentModel.Design.Serialization;

class programa
{
    static void Main()
    {
        int i;
        string nome;

        Console.WriteLine("Insira seu Nome:");
        nome = Console.ReadLine();
        for (i = 0; i < 100; i++)
        {
            Console.WriteLine(nome);
        }
    }
}