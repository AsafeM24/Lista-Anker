/* 11. Calcule	 a	 raiz	 quadrada	 aproximada	 de	 um	 número	 inteiro	 informado	 pelo	 usuário,	
respeitando	 o	 erro	 máximo	 também	 informado	 pelo	 usuário.	 Não	 utilize	 funções	
predefinidas. */
using System;
class Program
{
    static void Main()
    {
        double x = 0.0, erroMax; //Incremento baixo para ser mais preciso.
        int num;
        Console.WriteLine("Digite um número inteiro:");
        string a = Console.ReadLine()!;
        Console.WriteLine("Informe o Erro Máximo permitido: Ex:(0.0001)");
        string b = Console.ReadLine()!;
        double.TryParse(b, out erroMax);
        int.TryParse(a, out num);
        while ((x * x - num > erroMax) || num - x * x > erroMax)
        {
            x = x + erroMax;
        }
        Console.WriteLine($"Raiz Aproximada: {x}");
    }
}