/* 18. Escreva	um	número	por	extenso	aceitando	números	de	até	9	dígitos,	usando	métodos	para	
as	 traduções	 e	 vetores	 de	 Strings	 que	 guardam	 cada	 tradução	 (ex.:	 unidades	 =	 {	 “zero”,	
“um”,	“dois”,	...,	“nove”	}).
 */
 using System;
class NumeroExtenso
{
    public int LerNumero()
    {
        Console.WriteLine("Digite um número até 9 dígitos:");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    public string Ate999(int num)
    {
        string[] unidades = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        string[] especiais = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        string[] dezenas = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        string[] centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        int c = num / 100;
        int d = (num % 100) / 10;
        int u = num % 10;

        string resultado = "";

        if (num == 100)
            return "cem";

        if (c > 0)
            resultado += centenas[c] + " ";

        if (d == 1)
            resultado += especiais[u];
        else
        {
            if (d > 1)
                resultado += dezenas[d] + " ";

            if (u > 0)
                resultado += unidades[u];
        }

        return resultado;
    }

    static void Main()
    {
        NumeroExtenso obj = new NumeroExtenso();

        int num = obj.LerNumero();

        int milhoes = num / 1000000;
        int milhares = (num % 1000000) / 1000;
        int unidades = num % 1000;

        string resultado = "";

        if (milhoes > 0)
            resultado += obj.Ate999(milhoes) + " milhões(ão) ";

        if (milhares > 0)
            resultado += obj.Ate999(milhares) + " mil ";

        if (unidades > 0)
            resultado += obj.Ate999(unidades);

        Console.WriteLine(resultado);
    }
}