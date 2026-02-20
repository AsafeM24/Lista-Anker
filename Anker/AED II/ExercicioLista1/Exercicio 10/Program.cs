using System;
using System.Globalization;

class program
{
    static void Main()
    {
        float invest;
        float juros;
        float soma = 0;
        float saldo_anterior = 0;
        string resp = "S";
        float conta;
        float porcem;
        int num = 1;

        while (resp == "S" || resp == "s")
        {


            Console.WriteLine("Insira o valor do investimento");
            invest = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite os juros mensais");
            juros = float.Parse(Console.ReadLine());


            while (num <= 12)
            {
                porcem = (juros / 100);
                soma = (saldo_anterior + invest);
                conta = (soma) * (1 + porcem);
                saldo_anterior = conta;
                Console.WriteLine($"Mês {num}: saldo = {conta:F2}");
                num++;

            }

            num = 1;

            Console.WriteLine("Deseja proseguir para o próximo ano? (S/N)");
            resp = Console.ReadLine();
        }

    }
}
