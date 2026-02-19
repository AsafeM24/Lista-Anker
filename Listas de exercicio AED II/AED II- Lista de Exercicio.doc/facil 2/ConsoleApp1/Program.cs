/* 2) Crie um programa que exiba os números pares entre 1 e 100. */
class programa
{
    static void Main()
    {
        int i;
        Console.WriteLine("Números Pares entre 1 e 100:");
        for (i = 1; i < 101; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}