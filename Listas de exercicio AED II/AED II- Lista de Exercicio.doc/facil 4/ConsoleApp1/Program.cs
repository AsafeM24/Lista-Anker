/* 4) Os números de Fibonacci são uma sequência de números definidas recursivamente. 
O primeiro elemento da sequência é 0 e o segundo é 1. 
Os outros elementos são calculados somando os dois antecessores. 
Crie um programa que exiba os primeiros 30 números da série de Fibonacci. */

class programa
{
    static void Main()
    {
        long anterior=0;
        long atual=1;
        long proximo; 
        int i;
        Console.WriteLine(anterior);
        Console.WriteLine(atual);
        for (i = 3; i < 31; i++)
        {
            proximo=anterior+atual;
            Console.WriteLine(proximo);
            anterior=atual;
            atual=proximo;
        }
    }
}