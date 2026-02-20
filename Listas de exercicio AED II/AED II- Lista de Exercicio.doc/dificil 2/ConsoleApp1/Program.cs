/* 2) Faça uma classe Conta que contenha o nome do cliente, o número da conta e o saldo. 
Estes valores deverão ser informados no construtor da classe. 
Faça um método depositar e um método sacar para realizar o depósito e saque de valores da conta. 
Faça um método obterSaldo que retorne o saldo do cliente. 
Faça um método obterNumero que retorne o número da conta. 
Faça um método obterNomeCliente que retorna o nome do cliente titular da conta.
Desenvolva um programa para testar a classe Conta. O programa deverá criar 3 contas diferentes e 
realizar diversas operações de saque e depósito. 
Depois, o programa deverá emitir um relatório (no console) apresentando o número, o titular e o saldo atual de cada conta.
Faça uma classe Extrato, que contenha a data da movimentação e o valor movimentado (pode ser tanto positivo quanto negativo);
Incremente a classe Conta, incluindo um vetor de 1000 posições de Extrato.
Cada vez que ocorrer um depósito ou um saque na conta, 
deverá criar um objeto Extrato com as informações de data da movimentação e o valor da movimentação;
Desenvolva um programa para testar a nova classe Conta. 
O programa deverá criar 3 contas diferentes e realizar diversas operações de saque e depósito. Depois, 
o programa deverá emitir um relatório (no console) apresentando o número, o titular, saldo atual e o extrato de cada conta.
Faça uma classe Cartão, que contenha o número do cartão, a validade do cartão.
Incremente a classe Conta, incluindo a informação de cartão.
Desenvolva um programa para testar a nova classe Conta. 
O programa deverá criar 3 contas diferentes e realizar diversas operações de saque e depósito. 
O programa deverá realizar operações de saque com cartão, 
onde deverá solicitar o número e a validade do cartão e identificar a conta à qual pertence o cartão. 
Depois, o programa deverá emitir um relatório (no console) apresentando o número, o titular, saldo atual e o extrato de cada conta. */

class Conta
{
    private string _Cliente;
    private long _NumConta;
    private double _Saldo;
    private Extrato[] _Extratos = new Extrato[1000];
    private int indExtrato;
    private Cartão _Cartão;

    public Conta(string cliente, long Numconta, double Saldo, Cartão cartão)
    {
        _Cliente = cliente;
        _NumConta = Numconta;
        _Saldo = Saldo;
        _Cartão = cartão;
    }
    public string Get_Cliente()
    {
        return _Cliente;
    }
    public void Set_Cliente(string cliente)
    {
        _Cliente = cliente;
    }
    public long Get_NumConta()
    {
        return _NumConta;
    }
    public void Set_NumConta(long NumConta)
    {
        _NumConta = NumConta;
    }
    public double Get_Saldo()
    {
        return _Saldo;
    }
    public void Set_Saldo(double Saldo)
    {
        _Saldo = Saldo;
    }
    public void Depositar(double Dindin)
    {

        if (Dindin > 0)
        {
            _Saldo += Dindin;
            _Extratos[indExtrato] = new Extrato(DateTime.Now, Dindin);
            indExtrato++;
        }
    }
    public void Sacar(double Dindin)
    {

        if (_Saldo >= Dindin && Dindin > 0)
        {
            _Saldo -= Dindin;
            _Extratos[indExtrato] = new Extrato(DateTime.Now, -Dindin);
            indExtrato++;
            Console.WriteLine($"Saldo Atual: {_Saldo}");
        }
        else
        {
            Console.WriteLine("Valor de Saque maior que saldo disponível.");
        }
    }
    public void ExibirExtrato()
    {
        int i;
        Console.WriteLine("Extrato:");
        Console.WriteLine();
        for (i = 0; i < indExtrato; i++)
        {
            Console.WriteLine($"{_Extratos[i].Get_data()} -{_Extratos[i].Get_ValorMovi()} ");
        }
    }
    public bool VerificarCartão(string numero, string validade)
    {
        if (_Cartão.get_Numcart() == numero && _Cartão.get_Validade() == validade)
        {
            return true;
        }
        return false;
    }
}
class Extrato
{
    private DateTime _Data;
    private double _ValorMovi;

    public Extrato(DateTime data, double valor)
    {
        _Data = data;
        _ValorMovi = valor;
    }
    public DateTime Get_data()
    {
        return _Data;
    }
    public double Get_ValorMovi()
    {
        return _ValorMovi;
    }
}
class Cartão
{
    private string _NumCart, _Validade;
    public Cartão(string numcart, string validade)
    {
        _NumCart = numcart;
        _Validade = validade;
    }
    public string get_Numcart()
    {
        return _NumCart;
    }
    public string get_Validade()
    {
        return _Validade;
    }
}
class Teste
{
    static void Main()
    {
        Cartão cartão1 = new Cartão("123193210", "04/04");
        Cartão cartão2 = new Cartão("312313124", "05/02");
        Cartão cartão3 = new Cartão("903812930", "14/01");

        Conta conta1 = new Conta("Vinicius", 8489212, 10000, cartão1);
        Conta conta2 = new Conta("Rafaela", 129318031, 10000, cartão2);
        Conta conta3 = new Conta("Asafe", 98140321, 10000, cartão3);

        conta1.Depositar(1000);
        conta1.Sacar(100);

        conta2.Depositar(10);
        conta2.Sacar(30);

        conta3.Depositar(9999);
        conta3.Sacar(20000);

        Console.WriteLine("Saque com Cartão");
        Console.WriteLine("Informe o Numero do Cartão:");
        string num = Console.ReadLine();
        Console.WriteLine("Informe a validade do Cartão:");
        string vali = Console.ReadLine();

        Conta[] contas = [conta1, conta2, conta3];
        bool encontrou = false;
        foreach (Conta conta in contas)
        {
            if (conta.VerificarCartão(num, vali))
            {
                Console.WriteLine("Cartão Verificado");
                conta.Sacar(50);
                encontrou = true;
                break;
            }
        }
        if (!encontrou)
        {
            Console.WriteLine("Cartão Inválido");
        }
        Console.WriteLine("RELATÓRIO");
        Console.WriteLine();
        foreach (Conta conta in contas)
        {
            Console.WriteLine($"Conta: {conta.Get_NumConta()}");
            Console.WriteLine($"Cliente: {conta.Get_Cliente()}");
            Console.WriteLine($"Saldo: {conta.Get_Saldo()}");
            conta.ExibirExtrato();
            Console.WriteLine($"_____________________");
        }
    }
}