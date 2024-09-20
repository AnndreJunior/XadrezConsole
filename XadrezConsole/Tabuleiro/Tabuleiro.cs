namespace XadrezConsole.Tabuleiro;

public class Tabuleiro
{
    private Peca[,] pecas = new Peca[0, 0];

    public Tabuleiro(int numeroLinhas, int numeroColunas)
    {
        NumeroLinhas = numeroLinhas;
        NumeroColunas = numeroColunas;
        pecas = new Peca[NumeroLinhas, NumeroColunas];
    }

    public int NumeroLinhas { get; set; }
    public int NumeroColunas { get; set; }

    public Peca PegarPeca(int linha, int coluna)
    {
        return pecas[linha, coluna];
    }

    public Peca PegarPeca(Posicao posicao)
    {
        return pecas[posicao.Linha, posicao.Coluna];
    }

    public void ColocarPeca(Peca peca, Posicao posicao)
    {
        if (ExisteUmaPeca(posicao))
        {
            throw new TabuleiroException("Já existe uma peça nessa posição");
        }
        pecas[posicao.Linha, posicao.Coluna] = peca;
        peca.Posicao = posicao;
    }

    public Peca? RetirarPeca(Posicao posicao)
    {
        if (PegarPeca(posicao) is null)
        {
            return null;
        }
        Peca aux = PegarPeca(posicao);
        aux.Posicao = null;
        pecas[posicao.Linha, posicao.Coluna] = null;
        return aux;
    }

    #region validações

    public bool PosicaoValida(Posicao posicao)
    {
        if (posicao.Linha < 0 || posicao.Linha >= NumeroLinhas || posicao.Coluna < 0 || posicao.Coluna >= NumeroColunas)
        {
            return false;
        }
        return true;
    }

    public bool ExisteUmaPeca(Posicao posicao)
    {
        ValidarPosicao(posicao);
        return PegarPeca(posicao) != null;
    }

    public void ValidarPosicao(Posicao posicao)
    {
        if (!PosicaoValida(posicao))
        {
            throw new TabuleiroException("Posição inválida");
        }
    }

    #endregion
}
