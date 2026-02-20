/* Crie uma classe chamada CorpoCeleste (massa, densidade, posiçãoX, posiçãoY). Após a criação da classe, 
crie um programa que preencha os dados de 10 CorposCelestes e ao final do processo, liste na tela o corpo de maior massa, 
o de maior raio e os dois mais distantes entre si (considerando o eixo X). 
O código deve fazer uso das boas práticas de Programação Orientada a Objetos, 
criando os métodos adequados e fazendo uso de encapsulamento.
Obs.: Lembre-se de que o raio do corpo é calculado a partir da massa e da densidade. */

class CorpoCeleste
{
    protected float _massa, _densidade;
    protected int _posiçãoX, _posiçãoY;

    public CorpoCeleste(float massa, float densidade, int posiçãoX, int posiçãoY)
    {
        _massa = massa;
        _densidade = densidade;
        _posiçãoX = posiçãoX;
        _posiçãoY = posiçãoY;
    }

    public float getmassa()
    {
        return _massa;
    }
    public float getdensidade()
    {
        return _densidade;
    }
    public float getposiçãoX()
    {
        return _posiçãoX;
    }
    public float getposiçãoY()
    {
        return _posiçãoY;
    }
    public double Raio()
    {
        double volume = _massa / _densidade;
        double raio = Math.Pow((3 * volume) / (4 * Math.PI), 1.0 / 3.0);
        return raio;
    }
    public float DistanciaEixo(CorpoCeleste outro)
    {
        return Math.Abs(this._posiçãoX - outro._posiçãoX); //Calcula a distancia entre corpos celestes e deixa o resultado Positivo
    }

    static void Main()
    {
        CorpoCeleste[] corpos = new CorpoCeleste[10];
        int i, j, posX, posY;
        float massa, densidade;
        string a;

        //Registro de Corpos Celestes
        for (i = 0; i < 10; i++)
        {
            Console.WriteLine($"Corpo Celeste {i + 1} :");

            Console.WriteLine("Massa:");
            a = Console.ReadLine()!;
            float.TryParse(a, out massa);

            Console.WriteLine("Densidade:");
            a = Console.ReadLine()!;
            float.TryParse(a, out densidade);

            Console.WriteLine("Posição X:");
            a = Console.ReadLine()!;
            int.TryParse(a, out posX);

            Console.WriteLine("Posição Y:");
            a = Console.ReadLine()!;
            int.TryParse(a, out posY);

            corpos[i] = new CorpoCeleste(massa, densidade, posX, posY);
        }
        //Preenchimento de maior massa e raio
        CorpoCeleste maiorMassa = corpos[0];
        CorpoCeleste maiorRaio = corpos[0];
        for (i = 1; i < 10; i++)
        {
            if (corpos[i].getmassa() > maiorMassa.getmassa())
            {
                maiorMassa = corpos[i];
            }
            if (corpos[i].Raio() > maiorRaio.Raio())
            {
                maiorRaio = corpos[i];
            }
        }
        //Calculo de Distancia entre 2 objetos
        float maiorDist = 0, distancia;
        CorpoCeleste corpo1, corpo2;
        for (i = 0; i < 10; i++)
        {
            for (j = 0; j < 10; j++)
            {
                distancia = corpos[i].DistanciaEixo(corpos[j]); //Recebe a distancia no eixo X entre os corpos celestes que estão sendo comparados 
                if (distancia > maiorDist)
                {
                    maiorDist = distancia;
                    corpo1 = corpos[i];
                    corpo2 = corpos[j];
                }
            }
        }

        Console.WriteLine("Resultado");
        Console.WriteLine();
        Console.WriteLine($"Maior Massa: {maiorMassa.getmassa()}");
        Console.WriteLine($"Maior Raio: {maiorRaio.Raio}");
        Console.WriteLine($"Maior Distância no eixo X: {maiorDist}");

    }
}