namespace XadrezConsole;

public class Tela
{
    public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
    {
        for (int i = 0; i < tabuleiro.NumeroLinhas; i++)
        {
            for (int j = 0; j < tabuleiro.NumeroColunas; j++)
            {
                if (tabuleiro.PegarPeca(i, j) is null)
                    Console.Write("- ");
                else
                    Console.Write(tabuleiro.PegarPeca(i, j) + " ");
            }
            Console.WriteLine();
        }
    }
}
