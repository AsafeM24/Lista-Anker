/* 15.Faça um método que calcule a	média de um	aluno de acordo	com	o critério definido	neste curso.
Além disso, faça um	outro método que informe o status do aluno de acordo com a tabela a	seguir:
Nota acima de 6 à  “Aprovado”
Nota entre 4 e 6 à Conceito	“Verificação Suplementar”
Nota abaixo	de 4 à Conceito	“Reprovado”. */
using System;
class CalculoMedias
{
    protected float _Nota1;
    protected float _Nota2;
    public CalculoMedias(float nota1, float nota2)
    {
        _Nota1 = nota1;
        _Nota2 = nota2;
    }

    public float Get_Nota1()
    {
        return _Nota1;
    }
    protected void Set_Nota1(float nota1)
    {
        _Nota1 = nota1;
    }
    public float Get_Nota2()
    {
        return _Nota2;
    }
    protected void Set_Nota2(float nota2)
    {
        _Nota2 = nota2;
    }
    public float CalculoMedia(float nota1, float nota2)
    {
        float media = 0;
        media = (nota1 + nota2) / 2;
        return media;
    }
    public string Aprovacao(float media)
    {
        string aprovacao = "";
        if (media > 6)
        {
            aprovacao = "Aprovado";
        }
        else if (media >= 4 && media <= 6)
        {
            aprovacao = "Verificação Suplementar";
        }
        else
        {
            aprovacao = "Reprovado";
        }
        return aprovacao;
    }
    static void Main()
    {
        CalculoMedias aluno = new CalculoMedias(7, 5);
        CalculoMedias aluno2 = new CalculoMedias(10, 10);
        CalculoMedias aluno3 = new CalculoMedias(3, 3);

        float media = aluno.CalculoMedia(aluno.Get_Nota1(), aluno.Get_Nota2());
        Console.WriteLine("Média: " + media);
        Console.WriteLine("Status: " + aluno.Aprovacao(media));
        Console.WriteLine();
        media = aluno2.CalculoMedia(aluno2.Get_Nota1(), aluno2.Get_Nota2());
        Console.WriteLine("Média: " + media);
        Console.WriteLine("Status: " + aluno2.Aprovacao(media));
        Console.WriteLine();
        media = aluno3.CalculoMedia(aluno3.Get_Nota1(), aluno3.Get_Nota2());
        Console.WriteLine("Média: " + media);
        Console.WriteLine("Status: " + aluno3.Aprovacao(media));
        Console.WriteLine();
    }
}