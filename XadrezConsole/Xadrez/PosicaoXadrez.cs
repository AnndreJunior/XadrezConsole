using XadrezConsole.Tabuleiro;

namespace XadrezConsole.Xadrez;

public class PosicaoXadrez
{
    private const int numeroTotalDeLinhas = 8;

    public char Coluna { get; set; }
    public int Linha { get; set; }

    public PosicaoXadrez(char coluna, int linha)
    {
        Coluna = coluna;
        Linha = linha;
    }

    public Posicao ToPosicao()
    {
        return new Posicao(numeroTotalDeLinhas - Linha, Coluna - 'a');
    }

    public override string ToString()
    {
        return "" + Coluna + Linha;
    }
}
