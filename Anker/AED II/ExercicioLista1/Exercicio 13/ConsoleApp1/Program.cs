/* 13.Ordene um vetor de 100 números inteiros gerados aleatoriamente. */
class VetorRando
{
    static void Main()
    {
        Random rand = new Random();
        int[] vet = new int[100];
        int i = 0, j = 0;
        for (i = 0; i < 99; i++)
        {
            vet[i] = rand.Next(0, 100);
        }

        Console.WriteLine("Vetor gerado aleatóriamente:");
        for (i = 0; i < 99; i++)
        {
            Console.Write($"{vet[i]} ");
        }
        for (i = 0; i < 99; i++)
        {
            for (j = 0; j < 99; j++)
            {
                if (vet[j] > vet[j + 1])
                {
                    int valor = vet[j];
                    vet[j] = vet[j + 1];
                    vet[j + 1] = valor;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Vetor Agora Ordenado:");
        for (i=0;i<99;i++)
        {
            Console.Write($"{vet[i]} ");
        }

    }
}