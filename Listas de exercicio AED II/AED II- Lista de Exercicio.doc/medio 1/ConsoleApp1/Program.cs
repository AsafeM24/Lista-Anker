/* 1) Crie um programa que exiba para o usuário qual é a área de um retângulo. Para implementar esse programa você deverá seguir as seguintes regras:
O usuário deverá informar para o programa o valor da base e altura do retângulo/quadrado.
É obrigatório criar/utilizar uma classe para representar o retângulo/quadrado.
A base e a altura informada pelo usuário deveram ser representadas na classe como propriedades.
O objeto deverá possuir uma propriedade para exibir o valor da área do retângulo/quadrado.
O objeto deverá possuir um método que exiba os dados de todas as suas propriedades. */

class Retangulo
{
    protected double _base;
    protected double _altura;
    public Retangulo(double Base, double altura)
    {
        _base = Base;
        _altura = altura;
    }
    public double get_base()
    {
        return _base;
    }
    public void set_base(double Base)
    {
        _base = Base;
    }
    public double get_altura()
    {
        return _altura;
    }
    public void set_altura(double altura)
    {
        _altura = altura;
    }

    public double Area
    {
        get
        {
            return _base * _altura;
        }
    }
    public void ExibirDados()
    {

        Console.WriteLine("Dados do Retangulo");
        Console.WriteLine();
        Console.WriteLine($"Base: {_base}");
        Console.WriteLine($"Altura: {_altura}");
        Console.WriteLine($"Area: {Area}");
    }
    static void Main()
    {
        double b, alt;
        string l;
        Console.WriteLine("Informe a base do Retângulo:");
        l=Console.ReadLine();
        double.TryParse(l,out b);
        Console.WriteLine("Informe a altura do Retângulo:");
        l=Console.ReadLine();
        double.TryParse(l,out alt);
        Retangulo retangulo= new Retangulo(b,alt);
        retangulo.ExibirDados();
    }
}