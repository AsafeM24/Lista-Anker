/* 19. Identifique	 as	 classes	 e	 implemente	 um	 programa	 para	 a	 seguinte	 especificação:	 “O	
supermercado	 vende	 diferentes	 tipos	 de	 produtos.	 Cada	 produto	 tem	 um	 preço	 e	 uma	
quantidade	em	estoque.	Um	pedido	de	um	cliente	é	composto	de	itens,	onde	cada	item	
especifica	o	produto	que	o	cliente	deseja	e	a	respectiva	quantidade. Esse	pedido	pode	ser	
pago	em	dinheiro,	cheque	ou	cartão.”
 */
using System;

class Produto
{
    public string nome;
    public double preço;
    public int quantidade_estoque;
}
class ItemPedido
{
    public Produto produto;
    public int quantidadeItens;
}
enum Tipopagamento
{
    dinheiro, crédito, débito, PIX
}
class Pedido
{
    public List<ItemPedido> itens = new List<ItemPedido>();
    public Tipopagamento FormaPagamento;
}

class Program
{
    public double CalcularMédia(ItemPedido item)
    {
        return item.produto.preço * item.quantidadeItens;
    }
    static void Main()
    {
        Program obj = new Program();
        Produto produto = new Produto();
        produto.nome = "Iphone";
        produto.preço = 1499.99;
        produto.quantidade_estoque = 10;

        ItemPedido item = new ItemPedido();
        item.produto = produto;
        item.quantidadeItens = 2;

        Pedido pedido = new Pedido();
        pedido.itens.Add(item);
        pedido.FormaPagamento = Tipopagamento.crédito;

        Console.WriteLine($"O preço a pagar por {item.quantidadeItens} de {item.produto.nome} é de {obj.CalcularMédia(item)}");
    }
}