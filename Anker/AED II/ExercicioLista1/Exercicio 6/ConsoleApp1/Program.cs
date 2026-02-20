/* 6. Determine o	número	de	dígitos	de	um	número	informado. */
using System;
class Programa
{
    static void Main()
    {
        Console.WriteLine("Digite um número:");
        string a= Console.ReadLine();
        Console.WriteLine($"O número {a} possui {a.Length} digitos.");
    }
}