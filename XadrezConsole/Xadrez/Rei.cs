using XadrezConsole.Tabuleiro;

namespace XadrezConsole.Xadrez;

public sealed class Rei : Peca
{
    public Rei(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {
    }

    public override string ToString()
    {
        return "R";
    }
}
