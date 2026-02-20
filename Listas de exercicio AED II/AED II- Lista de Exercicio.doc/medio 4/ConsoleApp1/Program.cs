/* 4) Crie um programa no qual o usuário deverá informar o nome e o tipo de cinco animais de estimação. 
O programa deverá exibir na tela para o usuário quantos cachorros, gatos e peixes foram informados.
Regras que deverão ser seguidas para a implementação do algoritmo:
Os únicos tipos de animais válidos são cachorro, gato e peixe.
Caso seja informado um tipo diferente o programa deverá definir o tipo do animal como Peixe.
É obrigatório criar uma classe para representar o Animal.
A classe deverá possuir dois dados privados (propriedades) para representar as características do animal.
A classe deverá possuir métodos de acesso para permitir que o usuário armazene/leia os dados dos dois dados privados (propriedades). */

class Animal
{
    protected string _nome;
    protected int _idade;
    public Animal(string nome, int idade)
    {
        _nome = nome;
        _idade = idade;
    }
    public string get_nome()
    {
        return _nome;
    }
    public void set_nome(string nome)
    {
        _nome = nome;
    }
    public int get_idade()
    {
        return _idade;
    }
    public void set_idade(int idade)
    {
        _idade = idade;
    }
    public virtual void ExibirDados()
    {
        Console.WriteLine($"Nome do Animal: {get_nome()}");
        Console.WriteLine($"Idade do Animal: {get_idade()}");
    }
}

class Cachorro : Animal
{
    protected string _raça;
    protected string _porte;
    public Cachorro(string nome, int idade, string raça, string porte) : base(nome, idade)
    {
        _raça = raça;
        _porte = porte;
    }
    public string get_raça()
    {
        return _raça;
    }
    public void set_raça(string raça)
    {
        _raça = raça;
    }
    public string get_porte()
    {
        return _porte;
    }
    public void set_porte(string porte)
    {
        _porte = porte;
    }
    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Raça do Cachorro: {get_raça()}");
        Console.WriteLine($"Porte do Cachorro: {get_porte()}");
    }
}
class Gato : Animal
{
    protected string _castrado, _tipoPelagem;
    public Gato(string nome, int idade, string castrado, string tipoPelagem) : base(nome, idade)
    {
        _castrado = castrado;
        _tipoPelagem = tipoPelagem;
    }
    public string get_castrado()
    {
        return _castrado;
    }
    public void set_castrado(string castrado)
    {
        _castrado = castrado;
    }
    public string get_tipoPelagem()
    {
        return _tipoPelagem;
    }
    public void set_tipoPelagem(string tipoPelagem)
    {
        _tipoPelagem = tipoPelagem;
    }

    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Condição de castragem: {get_castrado()}");
        Console.WriteLine($"Tipo de Pelagem: {get_tipoPelagem()}");
    }
}
class Peixe : Animal
{
    protected string _espécie, _tipoAgua;

    public Peixe(string nome, int idade, string espécie, string tipoAgua) : base(nome, idade)
    {
        _espécie = espécie;
        _tipoAgua = tipoAgua;
    }


}
class Programa
{
    static void Main()
    {
        Animal[] animais = new Animal[5];
        int qntdCachorro = 0;
        int qntdGato = 0;
        int qntdPeixe = 0;
        int i;
        for (i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o Nome do animal:");
            string nome = Console.ReadLine()!;
            Console.WriteLine("Digite a Idade do animal:");
            string a = Console.ReadLine()!;
            int.TryParse(a, out int idade);
            Console.WriteLine("Tipo de Animal: Cachorro/Gato/Peixe: ");
            string tipo = Console.ReadLine()!.ToLower();

            if (tipo == "cachorro")
            {
                Console.WriteLine("Qual a raça:");
                string raça = Console.ReadLine()!;
                Console.WriteLine("Qual o porte? Pequeno/Médio/Grande:");
                string porte = Console.ReadLine()!;
                animais[i] = new Cachorro(nome, idade, raça, porte);
                qntdCachorro++;
            }
            else if (tipo == "gato")
            {
                Console.WriteLine("O gato é Castrado? Sim/Não: ");
                string castrado = Console.ReadLine()!;
                Console.WriteLine("Tipo de Pelagem? Curta/Longa");
                string pelagem = Console.ReadLine()!;
                animais[i] = new Gato(nome, idade, castrado, pelagem);
                qntdGato++;
            }

            else
            {
                Console.WriteLine("Qual a espécie do Peixe: ");
                string espécie = Console.ReadLine()!;
                Console.WriteLine("Tipo de Água: Doce/Salgado");
                string tipoAgua = Console.ReadLine()!;
                animais[i] = new Peixe(nome, idade, espécie, tipoAgua);
                qntdPeixe++;
            }
        }
        Console.WriteLine("\n--- Dados dos Animais ---");

        for (i = 0; i < 5; i++)
        {
            animais[i].ExibirDados();
            Console.WriteLine("-------------------");
        }
    }
}