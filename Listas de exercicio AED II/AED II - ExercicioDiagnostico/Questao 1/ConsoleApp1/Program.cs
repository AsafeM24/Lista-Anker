/* a)	Implemente a classe Veiculo, que deve representar as seguintes características:
•	Quantidade de ocupantes;
•	Quantidade de rodas;
•	Capacidade Máxima do Tanque de Combustível (em litros);
•	O nível atual do tanque de combustível em percentual;
•	O consumo médio (em km/litro) de combustível do veículo;
•	A quilometragem atual do veículo;
•	Autonomia do veículo, que identifica a quantidade de Km que ele ainda pode percorrer sem abastecer.
 */

class Veiculo
{
    protected int _qtOcup, _qtRodas;
    protected float _maxCombus, _percentCombus, _consumoMed, _KmAtual;

    public Veiculo(int qtOcup, int qtRodas, float maxCombus, float percentCombus, float consumoMed, float KmAtual)
    {
        _qtOcup = qtOcup;
        _qtRodas = qtRodas;
        _maxCombus = maxCombus;
        _percentCombus = percentCombus;
        _consumoMed = consumoMed;
        _KmAtual = KmAtual;
    }

    /* b)	Crie os métodos de acesso (get/set) para:
    •	Acessar e alterar a quilometragem do veículo;
    •	Acessar e alterar o consumo médio do veículo;
     */
    public float GetKmAtual()
    {
        return _KmAtual;
    }
    public void SetKmAtual(float KmAtual)
    {
        _KmAtual = KmAtual;
    }
    public float GetconsumoMed()
    {
        return _consumoMed;
    }
    public void SetconsumoMed(float consumoMed)
    {
        _consumoMed = consumoMed;
    }

    public float Autonomia()
    {
        float LitroAtual = _maxCombus * (_percentCombus / 100);
        float autonomia = LitroAtual * _consumoMed;
        return autonomia;
    }

    /* c)	Implemente a classe Carro, que deve ser derivada da classe Veiculo e deve representar as seguintes características:
   •	Modelo do carro;
   •	Quantidade de portas */
}
class Carro : Veiculo
{
    private string _Modelo;
    private int _qtPortas;

    /*     d)	Crie dois construtores para a classe Carro, um default (construtor padrão) 
        e outro completo, compreendendo todos os atributos da classe;
     */
    public Carro() : base(0, 0, 0, 0, 0, 0)
    {
        _Modelo = "";
        _qtPortas = 0;
    }

    public Carro(int qtOcup, int qtRodas, float maxCombus, float percentCombus, float consumoMed, float KmAtual, string Modelo, int qtPortas) : base(qtOcup, qtRodas, maxCombus, percentCombus, consumoMed, KmAtual)
    {
        _Modelo = Modelo;
        _qtPortas = qtPortas;
    }
/*     e)	Crie o método float Percorrer(float qtdQuilometros), que atualiza a quilometragem atual do carro, com a quantidade de quilômetros informada como parâmetro do método.O método deve retornar ao final do processo a quilometragem atual do carro.
    Obs.: O limite de quilometragem do carro é de 999.999 Km.Faça os devidos tratamentos.
 */
 public float Percorrer(float qtKm)
    {
        if(_KmAtual+ qtKm > 999999)
        {
            _KmAtual=999999;
        }
        else
        {
            _KmAtual=qtKm;
        }
        return _KmAtual;
    }
}