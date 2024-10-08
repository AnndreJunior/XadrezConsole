using XadrezConsole.Tabuleiro;

namespace XadrezConsole;

public class Tela
{
    public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
    {
        for (int i = 0; i < tabuleiro.NumeroLinhas; i++)
        {
            Console.Write(8 - i + " ");
            for (int j = 0; j < tabuleiro.NumeroColunas; j++)
            {
                if (tabuleiro.PegarPeca(i, j) is null)
                    Console.Write("- ");
                else
                {
                    ImprimirPeca(tabuleiro.PegarPeca(i, j));
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
    }

    public static void ImprimirPeca(Peca peca)
    {
        if (peca.Cor == Cor.Branca)
        {
            Console.Write(peca);
        }
        else
        {
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(peca);
            Console.ForegroundColor = aux;
        }
    }
}
