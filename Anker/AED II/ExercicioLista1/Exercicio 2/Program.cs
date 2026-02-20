using System;

class ddd
{

    private float x;

    private float y;

    private float z;

    public ddd(float x, float y, float z)
    {
        this.x = x;

        this.y = y;

        this.z = z;
    }


    public float Raiz(float num)
    {

        float passos = 0.0001f;



        for (float i = 0; i <= num; i += passos)
        {

            if (i * i >= num)
            {
                return i;
            }

        }

        return -1;
    }

    public float distance(ddd outro)
    {
        float dx = outro.x - this.x;
        float dy = outro.y - this.y;
        float dz = outro.z - this.z;

        float soma = (dx * dx) + (dy * dy) + (dz * dz);

        return Raiz(soma);
    }

}

class Program
{
    static void Main(string[] args)
    {
        ddd p1 = new ddd(1, 2, 3);
        ddd p2 = new ddd(4, 6, 8);

        float distancia = p1.distance(p2);

        Console.WriteLine("Distância = " + distancia);
    }
}
