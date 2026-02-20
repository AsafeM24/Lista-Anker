/* 10. Calcule o retorno de umm	investimento financeiro fazendo	as	contas mês	a mês, sem	usar	a	
fórmula	 de	 juros	 compostos.	 O usuário deve informar quanto	 será	 investido	 por	 mês	 e	
qual	será	a	taxa	de	juros	mensal.	O	programa	deve	informar	o	saldo	do	investimento	após	
um	ano	(soma	das	aplicações	mês	a	mês considerando	os juros	compostos),	e	perguntar	ao	
usuário	 se	 ele	 deseja	 que	 seja	 calculado	 o	 ano	 seguinte,	 sucessivamente.	 Por	 exemplo,	
caso	o	usuário	deseje	investir	R$	100,00	por	mês,	e	tenha	uma	taxa	de	juros	de	1%	ao	mês,	
o	programa	forneceria	a	seguinte	saída:
Saldo do investimento após 1 ano: 1280.9328
 */using System;
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
