/* 3) Crie um programa que imprima na tela um triângulo de “*”:
*
**
***
** 
*/
class programa
{
    static void Main()
    {
        int i, j,num;
        string n;
        Console.WriteLine("Informe o tamanho (em linhas) que deseja o triangulo:");
        n=Console.ReadLine();
        int.TryParse(n,out num);

        for (i = 1; i < num; i++)
        {
            for (j = 1; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}