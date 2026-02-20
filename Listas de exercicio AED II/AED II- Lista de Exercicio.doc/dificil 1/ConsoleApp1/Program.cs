/* 1) Desenvolva uma classe Lâmpada, a qual pode ser ligada e desligada. 
Também deve ser possível observar o estado da lâmpada (se desligada ou ligada).
Desenvolva uma nova classe para a lâmpada de forma a incluir as características de potência e voltagem. 
Garanta que seja possível tanto ler quanto alterar os valores de potência e voltagem de uma lâmpada.
Crie uma classe Teste com um método main para testar as classes desenvolvidas nos exercícios 1 e 2. 
Crie uma lâmpada, apresente no console as informações de estado (se ligada ou desligada, potência e voltagem), 
ligue a lâmpada e apresente novamente as informações de estado.
Modifique a classe da lâmpada criada anteriormente para incluir o caso de uma lâmpada queimar ao ser ligada. 
Sabe-se que existe uma chance de 15% da lâmpada queimar ao ser ligada. 
Dica: neste exercício é importante pesquisar na biblioteca de classes fornecida pela 
linguagem de programação uma classe que dê suporte à geração de números aleatórios */

class Lâmpada
{
    protected bool ligado;
    protected float _Potencia;
    protected float _Voltagem;
    protected bool queimada;
    protected Random rando = new Random();
    int chance;

    public Lâmpada(float Potencia, float Voltagem)
    {
        ligado = false;
        _Potencia = Potencia;
        _Voltagem = Voltagem;
    }
    public void ligar()
    {
        if (queimada)
        {
            Console.WriteLine("A lampada queimou D:");
            return;
        }
        chance = rando.Next(1, 101);
        if (chance <= 15)
        {
            queimada = true;
            ligado = false;
            Console.WriteLine("A lampada queimou ao ligar");
        }
        else
        {
            ligado = true;
        }

    }
    public void desligar()
    {
        ligado = false;
    }
    public bool estaLigado()
    {
        return ligado;
    }
    public bool estaQueimada()
    {
        return queimada;
    }

    public float get_Potencia()
    {
        return _Potencia;
    }
    public void set_Potencia(float Potencia)
    {
        _Potencia = Potencia;
    }
    public float get_Voltagem()
    {
        return _Voltagem;
    }
    public void set_Voltagem(float Voltagem)
    {
        _Voltagem = Voltagem;
    }
}

class Teste
{
    static void DadosLampada(Lâmpada lâmpada)
    {
        Console.WriteLine($"Dados da Lâmpada");
        Console.WriteLine();
        Console.WriteLine($"Ligada: {lâmpada.estaLigado()}");
        Console.WriteLine($"Queimada: {lâmpada.estaQueimada()}");
        Console.WriteLine($"Potência: {lâmpada.get_Potencia()}W");
        Console.WriteLine($"Voltagem: {lâmpada.get_Voltagem()}V");
    }
    static void Main()
    {
        bool sim=true;
        while(sim){
        Lâmpada lâmpada= new Lâmpada(30,110);
        DadosLampada(lâmpada);
        lâmpada.ligar();
        Console.WriteLine("Após tentar ligar:");
        DadosLampada(lâmpada);
        Console.WriteLine("Deseja testar novamente? S/N");
        string a=Console.ReadLine().ToLower();
            if (a == "s")
            {
                sim=true;
            }
            else if (a == "n")
            {
                sim=false;
            }
            else
            {
             Console.WriteLine("Opção Inválida");
             Console.WriteLine("Fechando Teste...");
             sim=false;
            }
        }
    }
}