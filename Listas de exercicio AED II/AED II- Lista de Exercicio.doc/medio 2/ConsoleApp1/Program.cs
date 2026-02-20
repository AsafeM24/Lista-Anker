/* 2) Crie uma classe Ponto, com a capacidade de armazenar a localização de ponto no plano cartesiano, de modo que ela possua três construtores:
Um construtor sem parâmetros, que cria um ponto nas coordenadas (0,0);
Um construtor que recebe dois parâmetros de coordenadas X e Y;
Um construtor que inicializa o ponto através das coordenadas de um outro ponto recebido como parâmetro. */
class Ponto
{
    protected float _x,_y;

    public Ponto()
    {
        _x=0;
        _y=0;
    }
    public Ponto(float x, float y)
    {
        _x=x;
        _y=y;
    }
    public Ponto(Ponto outro)
    {
        _x=outro._x;
        _y=outro._y;
    }
    public float X
    {
        get{ return _x;}
        set{_x=value;}
    }
    public float Y
    {
        get{ return _y;}
        set{_y=value;}
    }
    static void Main()
    {
        Ponto p1=new Ponto();
        Ponto p2=new Ponto(10,20);
        Ponto p3=new Ponto(p2);
        Console.WriteLine($"Ponto 1: {p1.X}, {p1.Y}");
        Console.WriteLine($"Ponto 2: {p2.X}, {p2.Y}");
        Console.WriteLine($"Ponto 3: {p3.X}, {p3.Y}");
    }
}