/* 17.Leia um número decimal (até 3 dígitos) e	escreva	o seu equivalente em numeração	
romana. Utilize métodos para obter cada dígito do número decimal e para a transformação de numeração decimal para romana	
(Dica1:	1 = I,	5 = V,	10 = X,	50 = L,	100 = C,500 = D, 1.000 = M; Dica2: utilize um vetor guardando a tradução para cada um dos dígitos). */

using System;
class Numero_em_Romano
{
    public int Ler_num()
    {
        Console.WriteLine("Digite um número (de até 3 digitos) para a conversão para Numeros Romanos:");
        string a = Console.ReadLine();
        int num = 0;
        if (a.Length > 3)
        {
            Console.WriteLine("ERRO: Numero Maior que 3 digitos.");
            return 0;
        }
        else
        {
            int.TryParse(a, out num);
            return num;
        }
    }
    public int centena(int num)
    {
        return num / 100;
    }
    public int dezena(int num)
    {
        return (num % 100) / 10;
    }

    public int unidade(int num)
    {
        return num % 10;
    }
    static void Main()
    {
        Numero_em_Romano objeto = new Numero_em_Romano();
        int num = objeto.Ler_num();
        int c = objeto.centena(num);
        int d = objeto.dezena(num);
        int u = objeto.unidade(num);
        string[] centenas = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] dezenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

        string NumRomano = centenas[c] + dezenas[d] + unidades[u];
        Console.WriteLine($"Número em Romano: {NumRomano}");
    }

}