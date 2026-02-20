/* 1. Determine	 as	 raízes	 de	 uma	 equação	 de	 2º	 grau:	 ax2 +	 bx	 +	 c	 =	 0	 (recordar	 que	 o	
discriminante	Δ =	b2 – 4ac,	e	que	a	raiz	r	=	(–b	± √Δ)/2a).
using System;
 */
class Equa
{
    private float a;
    private float b;
    private float c;


    public Equa(float a, float b, float c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }
    //métodos

    public float CalDelt()
    {
        float delta = (b * b) - (4 * a * c);

        return delta;
    }

    public float Raiz(float num)
    {


        for (float i = 0; i <= num; i++)
        {

            if (i * i == num)
            {
                return i;
            }

        }

        return -1;

    }
    public void CalRaiz()
    {
        float delta = CalDelt();

        if (delta < 0)
        {

            Console.WriteLine("Não existe raiz real.");

        }
        else
        {

            float RaizDelta = Raiz(delta);

            float x1 = (-b + RaizDelta) / (2 * a);
            float x2 = (-b - RaizDelta) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);



        }

    }

}

class Program
{
    static void Main(string[] args)
    {
        Equa eq = new Equa(1, -5, 6);
        eq.CalRaiz();
    }
}

