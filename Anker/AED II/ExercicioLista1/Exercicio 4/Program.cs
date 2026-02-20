/* 4.Para  cada produto	 informado	 (nome, preço	 e	 quantidade),
escreva	 o	 nome	 do	 produto	
comprado e	o	valor	 total a	 ser pago, considerando	 
que são oferecidos	 descontos	 pelo	
número	de	unidades	compradas, segundo	a	tabela	abaixo:	
a.Até  10  unidades: valor total
b.de   11 a    20	unidades: 10 % de  desconto
c.de   21  a   50	unidades: 20 % de  desconto
d.acima de  50	unidades: 25 % de  desconto
 */using System;

class loja
{
    private string nome;

    private float preco;

    private int quant;

    public loja(string nome, float preco, int quant)
    {

        this.preco = preco;

        this.nome = nome;

        this.quant = quant;
    }

    public float Comprar()
    {
        float total = preco * quant;

        if (quant <= 10)
        {
            return total;
        }
        else if (quant <= 20)
        {
            return total - (total * 10 / 100);
        }
        else if (quant <= 50)
        {
            return total - (total * 20 / 100);
        }
        else
        {
            return total - (total * 25 / 100);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escreva o nome do produto que quer comprar");
        string nome = Console.ReadLine();
        Console.WriteLine("Escreva o valor do produto");
        float preco = float.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade de unidades do produto");
        int quant = int.Parse(Console.ReadLine());

        loja produto = new loja(nome, preco, quant);

        Console.WriteLine("Valor total: R$ " + produto.Comprar());

    }
}