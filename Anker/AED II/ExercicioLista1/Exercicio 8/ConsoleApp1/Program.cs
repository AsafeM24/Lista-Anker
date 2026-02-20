/* 8. Calcule a	série	de	Fibonacci	para	um	número	inteiro	não	negativo	informado	pelo	usuário.	
A	 série	 de	 Fibonacci	 inicia	 com	 os	 números	 F0 =	 0 e	 F1 =	 1,	 e	 cada	 número	 posterior	
equivale	à	soma	dos	dois	números	anteriores (Fn =	Fn-1 +	Fn-2).	Por	exemplo,	caso	o	usuário	
informe	o	número	9,	o	resultado	seria:	0,	1,	1,	2,	3,	5,	8,	13,	21,	34.
 */class programa
{
    static void Main()
    {
        long anterior=0;
        long atual=1;
        long proximo; 
        int i;
        Console.WriteLine("Informe até q valor de fibonacci deseja que seja mostrado:");
        string a=Console.ReadLine();
        int.TryParse(a,out int num);
        Console.Write($"{anterior} {atual} ");
        
        for (i = 3; i < num; i++)
        {
            proximo=anterior+atual;
            Console.Write($"{proximo} ");
            anterior=atual;
            atual=proximo;
        }
    }
}