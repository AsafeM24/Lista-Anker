/* 3) Implemente um programa no qual o usuário deverá informar o nome e a idade de três pessoas. 
O programa deverá informar o nome da pessoa que possuir a maior idade.
Regras que deverão ser seguidas para a implementação do algoritmo:
É obrigatório o uso de classe para representar uma pessoa e 
ela deverá possuir como propriedades (características) um nome e uma idade.
A classe deverá possuir um método chamado ExibirDados. Esse método deverá exibir o nome e a idade da pessoa em questão.
Ao implementar a classe é obrigatório implementar dois construtores (Sobrecarga), um que não recebe parâmetro algum e 
outro que irá receber o nome e a idade de uma pessoa. */

class Pessoa
{
    protected string _nome = "";
    protected int _idade = 0;
    public Pessoa()
    {
        _nome = "";
        _idade = 0;
    }
    public Pessoa(string nome, int idade)
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
    public void ExibirDados()
    {
        Console.WriteLine($"{_nome} é a pessoa mais velha com {_idade} anos de idade");
    }
    static void Main()
    {
        int  i;
        string nome = "";
        Pessoa[] pessoa = new Pessoa[3];
        for (i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite o nome da {i + 1}ª pessoa");
            nome = Console.ReadLine()!;
            Console.WriteLine($"Digite a idade da {i + 1}ª pessoa");
            string a = Console.ReadLine()!;
            int.TryParse(a, out int idade);
            pessoa[i] = new Pessoa(nome, idade);
        }
        Pessoa maisVelha = pessoa[0];
        for (i = 1; i < 3; i++)
        {
            if (pessoa[i].get_idade() > maisVelha.get_idade())
            {
                maisVelha=pessoa[i];
            }
        }
        maisVelha.ExibirDados();
    }
}