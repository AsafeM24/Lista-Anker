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
        Console.WriteLine($"Raça do Cachorro: {get_raça}");
        Console.WriteLine($"Porte do Cachorro: {get_porte}");
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
        Console.WriteLine($"Condição de castragem: {get_castrado}");
        Console.WriteLine($"Tipo de Pelagem: {get_tipoPelagem}");
    }
}
class Peixe : Animal
{
    protected string _espécie, tipoAgua;

    
}