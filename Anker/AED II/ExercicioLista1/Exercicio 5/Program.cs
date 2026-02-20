/* 5.Construa a tabela	de	multiplicação	de	números	de	1	a	10	
(ex.:	1   x   1	=	1,  1	x	2	=	2, etc.).
 */using System;
using System.Globalization;

public class program
{
    static void Main()
    {

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {

                Console.WriteLine($"{i}x{j} = {i * j}");
            }
        }


    }
}