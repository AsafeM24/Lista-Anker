/* 12.Leia uma matriz 3 x 3	que	representa um tabuleiro de jogo da velha e indique qual posição	
deveria	ser	jogada para ganhar o jogo (se possível)	ou ao menos para evitar uma derrota. */

class Tabuleiro
{
    static void tabuleiro(char[,] tab)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tab[i, j]);

                if (j < 2) Console.Write(" | ");
            }
            Console.WriteLine();

            if (i < 2) Console.WriteLine("---------");
        }
    }

    static void Main()
    {

        char jogador = 'X';
        while (true)
        {
            tabuleiro(tab);
            Console.WriteLine($"Jogador: {jogador} É a sua vez!");

            Console.Write("Linha (0-2): ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Coluna (0-2): ");
            int coluna = int.Parse(Console.ReadLine());

            if (tab[linha, coluna] != ' ')
            {
                Console.WriteLine("Posição ocupada! Tente novamente.");
                continue;
            }
        }
        char[,] tab = new char[3, 3]
        {
        {' ',' ',' '},
        {' ',' ',' '},
        {' ',' ',' '}
        };
        tabuleiro(tab);
    }
}