using System;

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