/* 9. Determine	a	saída	do seguinte	programa:
public class Loop {
 public static void main(String[] args) {
 for (int i = 2; i <= 8; i = i + 2) {
 for (int j = i; j <= 4; j++) {
 for (int k = 1; k <= j; k = k + i) {
 System.out.println(i + ", " + j + ", " + k);
 }
 }
 }
 }
 */using System;

public class Loop
{
    public static void Main(string[] args)
    {
        for (int i = 2; i <= 8; i = i + 2)
        {
            for (int j = i; j <= 4; j++)
            {
                for (int k = 1; k <= j; k = k + i)
                {
                    Console.WriteLine(i + ", " + j + ", " + k);
                }
            }
        }
    }
}
