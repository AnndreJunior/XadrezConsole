using XadrezConsole;
using XadrezConsole.Tabuleiro;
using XadrezConsole.Xadrez;

try
{
    PartidaDeXadrez partida = new();
    Tela.ImprimirTabuleiro(partida.tabuleiro);
}
catch (TabuleiroException ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();
