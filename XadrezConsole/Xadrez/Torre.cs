using XadrezConsole.Tabuleiro;

namespace XadrezConsole.Xadrez;

public sealed class Torre : Peca
{
    public Torre(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {
    }

    public override string ToString()
    {
        return "T";
    }
}
